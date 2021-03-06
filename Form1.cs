﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Drawing.Text;
using Newtonsoft.Json.Linq;
using OpenTK;

namespace NDI_SubTitle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Render Mode
        enum RenderMode
        {
            NDI = 0,
            FullScreen = 1
        }
        RenderMode render_mode = RenderMode.FullScreen; //Default

        // SubTitles
        private Dictionary<string, string> ST_Files = new Dictionary<string, string>();
        private string Using_FilePath;
        private string Selected_FilePath;
        private List<SubTitle> subTitles = new List<SubTitle>();

        // it means which SubTitle is being programed
        int run_printer = 0;

        SubTitle Previewing = SubTitle.Empty;

        RenderConfig renderConfig;
        NDIRender Renderer;
        CancellationTokenSource cancelNDI;

        FontFamily fontFamily;


        //Screen Output
        DisplayDevice display_screen = null;
        int scn_height, scn_width = 0;
        Render_Form render_form = null;

        #region Form
        private void Form1_Load(object sender, EventArgs e)
        {
            this.AutoScaleMode = AutoScaleMode.Dpi;
            // Init Fonts
            cmb_Fonts.Items.Clear();
            cmb_Fonts.Items.Add("[Select Font File]");
            using (InstalledFontCollection fontsCollection = new InstalledFontCollection())
            {
                FontFamily[] fontFamilies = fontsCollection.Families;
                List<string> fonts = new List<string>();
                foreach (FontFamily font in fontFamilies)
                {
                    cmb_Fonts.Items.Add(font.Name);
                }
            }
            cmb_Fonts.SelectedIndex = 1;
            Refresh_Monitors();
            // Read Config
            var config_path = Path.Combine(Directory.GetCurrentDirectory(), "NDI-SubTitle.config");
            try
            {
                renderConfig = RenderConfig.ReadConfig(config_path);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Reading Config File Failed");
                Console.WriteLine(ex.ToString());
                renderConfig = new RenderConfig(true);
                renderConfig.fontSize = 50;
            }
            // set Value for UI
            scroll_fontSize.Value = (int)renderConfig.fontSize * 10;
            txt_fontSize.Text = renderConfig.fontSize.ToString();
            txt_sub1X.Text = (scroll_sub1X.Value = renderConfig.Point_Sub1.X).ToString();
            txt_sub1Y.Text = (scroll_sub1Y.Value = renderConfig.Point_Sub1.Y).ToString();
            txt_sub2X.Text = (scroll_sub2X.Value = renderConfig.Point_Sub2.X).ToString();
            txt_sub2Y.Text = (scroll_sub2Y.Value = renderConfig.Point_Sub2.Y).ToString();
            txt_fadeTime.Text = (scroll_fadeTime.Value = renderConfig.Fade_Time).ToString();
            label_presetRemarks.Text = renderConfig.Remarks;
            txt_profileRemarks.Text = renderConfig.Remarks;
            const string DEBUG_LYRICS_FILENAME = "test-lyrics.txt";
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), DEBUG_LYRICS_FILENAME);
            if (File.Exists(filePath))
            {
                Console.WriteLine("detect test-lyrics file, load now");
                lst_File.Items.Add(DEBUG_LYRICS_FILENAME);
                ST_Files.Add(DEBUG_LYRICS_FILENAME, filePath);
                lst_File.SelectedIndex = 0;
                btn_Load_Click(null, null);
            }
        }

        private bool handleShortCut(Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.ProcessKey) || keyData == (Keys.Control | Keys.Space))
            {   //Fade to Blank
                Console.WriteLine("ShortCut: Ctrl + Space");
                btn_Clear_Fade_Click();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.Enter))
            {   //Cut to Blank
                Console.WriteLine("ShortCut: Ctrl + Enter");
                btn_Clear_Click();
                return true;
            }
            else if (keyData == Keys.Space)
            {   // Fade
                Console.WriteLine("ShortCut: Space");
                btn_fade_Click();
                return true;
            }
            else if (keyData == Keys.Enter)
            {   //fade to blank
                Console.WriteLine("ShortCut: Enter");
                btn_Hard_Click();
                return true;
            }
            else if (keyData == Keys.Up)
            {
                if (lst_SubTitle.SelectedIndex - 1 >= 0)
                    lst_SubTitle.SelectedIndex--;
                return true;
            }
            else if (keyData == Keys.Down)
            {
                if (lst_SubTitle.SelectedIndex + 1 < lst_SubTitle.Items.Count)
                    lst_SubTitle.SelectedIndex++;
                return true;
            }
            return false;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = handleShortCut(e.KeyData);
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            return handleShortCut(keyData) || base.ProcessCmdKey(ref msg, keyData);
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            btn_stop_Click();
            Close_Screen();
        }
        #endregion

        private List<SubTitle> GenerateSubTitles(string filePath)
        {

            List<string> lines;
            try { lines = new List<string>(File.ReadAllLines(filePath, GetTxtEncoding.GetType(filePath))); }
            catch (Exception e)
            {
                Console.WriteLine("!!!!Error When Reading SubTitle File");
                Console.WriteLine(e.ToString());
                return new List<SubTitle>();
            }
            var lst = new List<SubTitle>();
            lst.Add(new SubTitle(0, "", ""));
            if (lines.Count % 2 == 1)
                lines.Add("\r\n");
            for (int i = 0; i < lines.Count - 1; i += 2)
                lst.Add(new SubTitle(i / 2 + 1, lines[i], lines[i + 1]));
            lst.Add(new SubTitle(lines.Count / 2 + 1, "", ""));
            return lst;
        }

        private void Preview(SubTitle st)
        {
            lb_pre_id.Text = "Preview " + st.id.ToString();
            lb_preview.Text = st.ToString(true);
        }

        private void Program(SubTitle st)
        {
            lb_pgm_id.Text = "Program " + st.id.ToString();
            lb_program.Text = st.ToString(true);
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (Renderer != null)
                return;
            if (fontFamily == null)
            {
                MessageBox.Show("Please select font");
                return;
            }
            cancelNDI = new CancellationTokenSource();
            Renderer = new NDIRender(cancelNDI.Token, renderConfig, fontFamily);
            Task.Run(async () => await Renderer.Run());
            lb_Status.ForeColor = Color.Green;
            lb_Status.Text = "NDI On";
        }

        private void btn_stop_Click(object sender = null, EventArgs e = null)
        {
            btn_stop.Text = "Stopping....";
            if (Renderer != null)
            {
                cancelNDI.Cancel();
                Renderer = null;
            }
            lb_Status.ForeColor = Color.Red;
            lb_Status.Text = "NDI Off";
            btn_stop.Text = "Stop";
        }

        private void lst_SubTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Previewing = subTitles[lst_SubTitle.SelectedIndex];
                Preview(Previewing);
            }
            catch (Exception ex)
            { Console.WriteLine(ex.ToString()); }
        }

        #region Files
        private void btn_Load_Click(object sender, EventArgs e)
        {
            if (lst_File.SelectedItems.Count > 0)
            {
                string fileName = lst_File.SelectedItems[0].ToString();
                Using_FilePath = ST_Files[fileName];
                lb_program_file.Text = "Loaded File  : " + Using_FilePath;
                //TODO : Event?
                subTitles.Clear();
                lst_SubTitle.Items.Clear();
                run_printer = 0;
                subTitles = GenerateSubTitles(Using_FilePath);
                foreach (var st in subTitles)
                    lst_SubTitle.Items.Add(st);
            }
        }

        private void btn_DeleteFile_Click(object sender, EventArgs e)
        {
            if (lst_File.SelectedItems.Count > 0)
            {
                string fileName = lst_File.SelectedItems[0].ToString();
                lst_File.Items.Remove(fileName);
                ST_Files.Remove(fileName);
                Selected_FilePath = "";
                lb_selected_file.Text = "Selected File : None";
            }
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.SetApartmentState(ApartmentState.STA);
            var ofd = new OpenFileDialog();
            //   ofd.Reset();
            ofd.Filter = "Txt File (*.txt)|*.txt|All Files|*.*";
            ofd.ValidateNames = true;
            ofd.CheckPathExists = true;
            ofd.CheckFileExists = true;
            ofd.Multiselect = true;
            if (ofd.ShowDialog(this) == DialogResult.OK)
            {
                foreach (var filePath in ofd.FileNames)
                {
                    if (File.Exists(filePath))
                    {
                        string fileName = Path.GetFileName(filePath);
                        if (!lst_File.Items.Contains(fileName))
                        {
                            lst_File.Items.Add(fileName);
                            ST_Files.Add(fileName, filePath);
                        }
                    }
                }
            }
            ofd.Dispose();
        }

        private void lst_File_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_File.SelectedItems.Count > 0)
            {
                string fileName = lst_File.SelectedItems[0].ToString();
                Selected_FilePath = ST_Files[fileName];
                lb_selected_file.Text = "Selected File : " + Selected_FilePath;
            }
        }
        #endregion

        #region Fonts
        private void cmb_Fonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            if (cmb.SelectedItem != null)
            {
                Console.WriteLine("Change Font To " + cmb.SelectedItem.ToString());
                if (cmb.SelectedItem.ToString().Contains("Select Font File"))
                {
                    var ofd = new OpenFileDialog();
                    //   ofd.Reset();
                    ofd.Filter = "Font File (*.otf, *.ttf)|*.otf;*.ttf|All Files|*.*";
                    ofd.ValidateNames = true;
                    ofd.CheckPathExists = true;
                    ofd.CheckFileExists = true;
                    ofd.Multiselect = false;
                    if (ofd.ShowDialog(this) == DialogResult.OK)
                    {
                        foreach (var filePath in ofd.FileNames)
                        {
                            if (File.Exists(filePath))
                            {
                                PrivateFontCollection collection = new PrivateFontCollection();
                                collection.AddFontFile(filePath);
                                fontFamily = new FontFamily(collection.Families[0].Name, collection);
                                Console.WriteLine($"Change font to selected {fontFamily.Name} from path {filePath}");
                            }
                        }
                    }
                    ofd.Dispose();
                }
                else
                    fontFamily = new FontFamily(cmb.SelectedItem.ToString());
                if (render_mode == RenderMode.FullScreen)
                {
                    if (render_form != null)
                        render_form.ChangeFont(fontFamily);
                }
                else if (Renderer != null)
                    Renderer.ChangeFont(fontFamily);
                label_currentFont.Text = $"Current Font: {fontFamily.Name}";
            }
        }

        private void btn_Lock_Font_Click(object sender, EventArgs e)
        {
            if (panel_renderConfig.Enabled) // unlocked
            {
                // lock it
                panel_renderConfig.Enabled = false;
                btn_Lock_Font.ForeColor = Color.Green;
                btn_Lock_Font.Text = "Render Control Panel - Locked";
            }
            else
            {
                // unlock it
                panel_renderConfig.Enabled = true;
                btn_Lock_Font.ForeColor = Color.Red;
                btn_Lock_Font.Text = "Lock Render Control Panel";
            }
        }
        #endregion
        private void btn_load_presets(object sender, EventArgs e)
        {
            
        }
        private void btn_save_presets(object sender, EventArgs e)
        {

        }

        #region Change Buttons
        private void btn_Clear_Fade_Click(object sender = null, EventArgs e = null)
        {
            if (render_mode == RenderMode.NDI)
            {
                if (Renderer == null)
                    return;
                Renderer.Fade(SubTitle.Empty);
                Program(SubTitle.Empty);
            }
            if (render_mode == RenderMode.FullScreen)
            {
                if (render_form == null)
                    return;
                render_form.Fade(SubTitle.Empty);
                Program(SubTitle.Empty);
            }
        }

        private void btn_fade_Click(object sender = null, EventArgs e = null)  //Fade
        {
            if (subTitles.Count == 0)
                return;
            if (lst_SubTitle.SelectedIndex < 0)
                return;
            if (subTitles.Count > lst_SubTitle.SelectedIndex)
            {
                if (render_mode == RenderMode.FullScreen)
                {
                    if (render_form == null)
                        return;
                    render_form.Fade(Previewing);
                }
                else
                {
                    if (Renderer == null)
                        return;
                    Renderer.Fade(Previewing);
                }
                Program(Previewing);
                run_printer = Previewing.id + 1;
                if (run_printer != subTitles.Count)
                    lst_SubTitle.SetSelected(run_printer, true);
            }
        }

        private void btn_Hard_Click(object sender = null, EventArgs e = null)//Send Directly Preview To Program
        {

            if (subTitles.Count == 0)
                return;
            if (lst_SubTitle.SelectedIndex < 0 || subTitles.Count <= lst_SubTitle.SelectedIndex)
                return;
            if (render_mode == RenderMode.FullScreen)
            {
                if (render_form == null) return;
                render_form.Cut(Previewing);
            }
            else
            {
                if (Renderer == null)
                    return;
                Renderer.Cut(Previewing);
            }
            Program(Previewing);
            run_printer = Previewing.id + 1;
            if (run_printer != subTitles.Count)
                lst_SubTitle.SetSelected(run_printer, true);
        }

        private void btn_Clear_Click(object sender = null, EventArgs e = null)
        {
            Program(SubTitle.Empty);
            if (Renderer != null)
                Renderer.Cut(SubTitle.Empty);
            if (render_form != null)
                render_form.Cut(SubTitle.Empty);
        }
        #endregion

        private void Lst_File_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void Lst_File_DragDrop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            foreach (string filePath in s)
            {
                Console.WriteLine(filePath);
                if (File.Exists(filePath))
                {
                    if (Path.GetExtension(filePath) != ".txt")
                        continue;
                    string fileName = Path.GetFileName(filePath);
                    if (!lst_File.Items.Contains(fileName))
                    {
                        lst_File.Items.Add(fileName);
                        ST_Files.Add(fileName, filePath);
                    }
                }
            }
        }

        private void btn_refresh_monitor_Click(object sender, EventArgs e)
        {
            Refresh_Monitors();
        }

        private void Refresh_Monitors()
        {
            if (cmb_monitor.Enabled == true) //unlocked
            {
                cmb_monitor.Items.Clear();
                int id = 0;
                foreach (var screen in Screen.AllScreens)
                {
                    // For each screen, add the screen properties to a list box.
                    cmb_monitor.Items.Add($"{id}:{screen.DeviceName}");
                    id++;
                }
                if (cmb_monitor.Items.Count >= 1)
                    cmb_monitor.SelectedIndex = cmb_monitor.Items.Count - 1;
            }
        }

        private void btn_scnStart_Click(object sender, EventArgs e)
        {
            if (cmb_monitor.Enabled == false) //has locked
            {
                render_form = new Render_Form(display_screen, scn_width, scn_height, new Font(fontFamily, renderConfig.fontSize), renderConfig);
                render_form.Run(50.0f, 50.0f);
            }
            else
            {
                MessageBox.Show("Lock Output Screen!");
            }
        }

        void Close_Screen()
        {
            if (render_form != null)
            {
                render_form.Close();
                render_form.Dispose();
                render_form = null;
            }
        }

        private void btn_ScnStop_Click(object sender, EventArgs e)
        {
            var ds = MessageBox.Show("Close Output Screen?!!!!", "ARE YOU SURE??", MessageBoxButtons.YesNo);
            if (ds == DialogResult.Yes)
                Close_Screen();
        }

        private void rdo_Render_NDI_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_Render_NDI.Checked) render_mode = RenderMode.NDI;
        }

        private void rdo_Render_FullScreen_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_Render_FullScreen.Checked) render_mode = RenderMode.FullScreen;

        }

        private void NotifyChanges()
        {
            if (render_mode == RenderMode.FullScreen)
            {
                if (render_form != null)
                    render_form.onChanged(renderConfig);
            } else
            {
                if (Renderer != null)
                    Renderer.onChanged(renderConfig);
            }
        }

        private void scroll_fontSize_Scroll(object sender, ScrollEventArgs e)
        {
            renderConfig.fontSize = e.NewValue / 10.0f;
            txt_fontSize.Text = (e.NewValue / 10.0f).ToString();
            NotifyChanges();
        }

        private void scroll_sub1X_ValueChanged(object sender, EventArgs e)
        {
            renderConfig.Point_Sub1.X = scroll_sub1X.Value;
            txt_sub1X.Text = scroll_sub1X.Value.ToString();
            NotifyChanges();
        }

        private void scroll_sub1Y_ValueChanged(object sender, EventArgs e)
        {
            renderConfig.Point_Sub1.Y = scroll_sub1Y.Value;
            txt_sub1Y.Text = scroll_sub1Y.Value.ToString();
            NotifyChanges();
        }

        private void scroll_sub2X_ValueChanged(object sender, EventArgs e)
        {
            renderConfig.Point_Sub2.X = scroll_sub2X.Value;
            txt_sub2X.Text = scroll_sub2X.Value.ToString();
            NotifyChanges();
        }

        private void scroll_sub2Y_ValueChanged(object sender, EventArgs e)
        {
            renderConfig.Point_Sub2.Y = scroll_sub2Y.Value;
            txt_sub2Y.Text = scroll_sub2Y.Value.ToString();
            NotifyChanges();
        }

        private void btn_sync_sub2X_Click(object sender, EventArgs e)
        {
            renderConfig.Point_Sub2.X = renderConfig.Point_Sub1.X;
            txt_sub2X.Text = txt_sub1X.Text;
            scroll_sub2X.Value = scroll_sub1X.Value;
        }

        private void txt_NumberFilter(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void scroll_fadeTime_ValueChanged(object sender, EventArgs e)
        {
            renderConfig.Fade_Time = scroll_fadeTime.Value;
            txt_fadeTime.Text = scroll_fadeTime.Value.ToString();
            NotifyChanges();
        }

        private void txt_sub1X_TextChanged(object sender, EventArgs e)
        {
            renderConfig.Point_Sub1.X = scroll_sub1X.Value = Convert.ToInt32(txt_sub1X.Text);
            NotifyChanges();
        }

        private void txt_sub1Y_TextChanged(object sender, EventArgs e)
        {
            renderConfig.Point_Sub1.Y = scroll_sub1Y.Value = Convert.ToInt32(txt_sub1Y.Text);
            NotifyChanges();
        }

        private void txt_sub2X_TextChanged(object sender, EventArgs e)
        {
            renderConfig.Point_Sub2.X = scroll_sub2X.Value = Convert.ToInt32(txt_sub2X.Text);
            NotifyChanges();
        }

        private void txt_sub2Y_TextChanged(object sender, EventArgs e)
        {
            renderConfig.Point_Sub2.Y = scroll_sub2Y.Value = Convert.ToInt32(txt_sub2Y.Text);
            NotifyChanges();
        }

        private void txt_fontSize_TextChanged(object sender, EventArgs e)
        {
            try
            {
                renderConfig.fontSize = Convert.ToSingle(txt_fontSize.Text);
            }
            catch (Exception ex)
            {
                renderConfig.fontSize = 5.0f;
            }
            scroll_fontSize.Value = (int) renderConfig.fontSize * 10;
            NotifyChanges();
        }

        private void txt_fadeTime_TextChanged(object sender, EventArgs e)
        {
            renderConfig.Fade_Time = scroll_fadeTime.Value = Convert.ToInt32(txt_fadeTime.Text);
            NotifyChanges();
        }

        private void btn_lockSavePreset_Click(object sender, EventArgs e)
        {
            if (btn_savePreset1.Enabled)
            {
                btn_lockSavePreset.Text = "Save Preset - Locked";
                btn_lockSavePreset.ForeColor = Color.Green;
                btn_savePreset1.Enabled = false;
                btn_savePreset2.Enabled = false;
                btn_savePreset3.Enabled = false;
                btn_savePreset4.Enabled = false;
                btn_savePreset5.Enabled = false;
            }
            else
            {
                btn_lockSavePreset.Text = "Lock Save Preset";
                btn_lockSavePreset.ForeColor = Color.Red;
                btn_savePreset1.Enabled = true;
                btn_savePreset2.Enabled = true;
                btn_savePreset3.Enabled = true;
                btn_savePreset4.Enabled = true;
                btn_savePreset5.Enabled = true;
            }
        }

        private void btn_lockLoadPreset_Click(object sender, EventArgs e)
        {
            if (btn_loadPreset1.Enabled)
            {
                btn_lockLoadPreset.Text = "Load Preset - Locked";
                btn_lockLoadPreset.ForeColor = Color.Green;
                btn_loadPreset1.Enabled = false;
                btn_loadPreset2.Enabled = false;
                btn_loadPreset3.Enabled = false;
                btn_loadPreset4.Enabled = false;
                btn_loadPreset5.Enabled = false;
            }
            else
            {
                btn_lockLoadPreset.Text = "Lock Load Preset";
                btn_lockLoadPreset.ForeColor = Color.Red;
                btn_loadPreset1.Enabled = true;
                btn_loadPreset2.Enabled = true;
                btn_loadPreset3.Enabled = true;
                btn_loadPreset4.Enabled = true;
                btn_loadPreset5.Enabled = true;
            }
        }

        // TODO: Add lock
        private void btn_lock_screen_Click(object sender, EventArgs e)
        {
            if (cmb_monitor.Enabled == true) //not locked
            {
                int id = cmb_monitor.SelectedIndex;
                if (id == -1)
                    return;
                Screen scn = Screen.AllScreens[id];
                //lb_screen_info.Text = $"Name:{scn.DeviceName}  Bits:{scn.BitsPerPixel}";
                display_screen = DisplayDevice.GetDisplay((DisplayIndex)id);
                scn_height = Convert.ToInt32(txt_screen_height.Text);
                scn_width = Convert.ToInt32(txt_screen_width.Text);
                scroll_sub1X.Maximum = scroll_sub2X.Maximum = scn_height;
                scroll_sub1Y.Maximum = scroll_sub2Y.Maximum = scn_width;

                cmb_monitor.Enabled = false;
                btn_lock_screen.Text = "Locked";
                btn_lock_screen.ForeColor = Color.Green;

                txt_screen_height.ReadOnly = true;
                txt_screen_width.ReadOnly = true;

                scroll_sub1X.Maximum = scroll_sub2X.Maximum = Convert.ToInt32(txt_screen_width.Text);
                scroll_sub1Y.Maximum = scroll_sub2Y.Maximum = Convert.ToInt32(txt_screen_height.Text);
            }
            else
            {
                cmb_monitor.Enabled = true;
                btn_lock_screen.Text = "Unlocked";
                btn_lock_screen.ForeColor = Color.Red;

                txt_screen_height.ReadOnly = false;
                txt_screen_width.ReadOnly = false;
            }
        }

        private void loadPreset(int number)
        {
            if (number < 1 || number > 5)
                return;
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), $"NDI-SubTitle{number}.config");

            RenderConfig config = RenderConfig.ReadConfig(filePath);

            renderConfig.Point_Sub1.X = config.Point_Sub1.X;
            renderConfig.Point_Sub1.Y = config.Point_Sub1.Y;
            renderConfig.Point_Sub2.X = config.Point_Sub2.X;
            renderConfig.Point_Sub2.Y = config.Point_Sub2.Y;

            renderConfig.Default_Color = config.Default_Color;
            renderConfig.fontSize = config.fontSize;
            renderConfig.Fade_Time = config.Fade_Time;
            renderConfig.Remarks = config.Remarks;

            NotifyChanges();

            scroll_fontSize.Value = (int)renderConfig.fontSize * 10;
            txt_fontSize.Text = renderConfig.fontSize.ToString();
            txt_sub1X.Text = (scroll_sub1X.Value = renderConfig.Point_Sub1.X).ToString();
            txt_sub1Y.Text = (scroll_sub1Y.Value = renderConfig.Point_Sub1.Y).ToString();
            txt_sub2X.Text = (scroll_sub2X.Value = renderConfig.Point_Sub2.X).ToString();
            txt_sub2Y.Text = (scroll_sub2Y.Value = renderConfig.Point_Sub2.Y).ToString();
            txt_fadeTime.Text = (scroll_fadeTime.Value = renderConfig.Fade_Time).ToString();
            label_presetRemarks.Text = renderConfig.Remarks;
            txt_profileRemarks.Text = renderConfig.Remarks;

        }

        private void savePreset(int number)
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), $"NDI-SubTitle{number}.config");
            RenderConfig.SaveConfig(renderConfig, filePath);
        }

        private void btn_loadPreset_Click(object sender, EventArgs e)
        {
            if (!(sender is Button))
                return;
            var btn = (Button)sender;
            if (!btn.Name.StartsWith("btn_loadPreset"))
                return;
            int number;
            try
            {
                number = Convert.ToInt32(btn.Name.Replace("btn_loadPreset", ""));
            }
            catch(Exception ex)
            {
                return;
            }
            loadPreset(number);            
        }

        private void txt_profileRemarks_TextChanged(object sender, EventArgs e)
        {
            renderConfig.Remarks = txt_profileRemarks.Text;
        }

        private void btn_savePreset_Click(object sender, EventArgs e)
        {
            if (!(sender is Button))
                return;
            var btn = (Button)sender;
            if (!btn.Name.StartsWith("btn_savePreset"))
                return;
            int number;
            try
            {
                number = Convert.ToInt32(btn.Name.Replace("btn_savePreset", ""));
            }
            catch (Exception ex)
            {
                return;
            }
            savePreset(number);
        }

    }
}
