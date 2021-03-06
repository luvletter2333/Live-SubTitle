﻿namespace NDI_SubTitle
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lb_program_file = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.lable_text = new System.Windows.Forms.Label();
            this.lb_selected_file = new System.Windows.Forms.Label();
            this.btn_import = new System.Windows.Forms.Button();
            this.btn_Load = new System.Windows.Forms.Button();
            this.lb_pre_id = new System.Windows.Forms.Label();
            this.lb_pgm_id = new System.Windows.Forms.Label();
            this.lb_preview = new System.Windows.Forms.Label();
            this.lb_program = new System.Windows.Forms.Label();
            this.btn_fade = new System.Windows.Forms.Button();
            this.btn_Hard = new System.Windows.Forms.Button();
            this.btn_Clear_Cut = new System.Windows.Forms.Button();
            this.btn_DeleteFile = new System.Windows.Forms.Button();
            this.lst_File = new System.Windows.Forms.ListBox();
            this.lst_SubTitle = new System.Windows.Forms.ListBox();
            this.lb_Status = new System.Windows.Forms.Label();
            this.lb_Font = new System.Windows.Forms.Label();
            this.cmb_Fonts = new System.Windows.Forms.ComboBox();
            this.btn_Lock_Font = new System.Windows.Forms.Button();
            this.btn_Clear_Fade = new System.Windows.Forms.Button();
            this.btn_refresh_monitor = new System.Windows.Forms.Button();
            this.cmb_monitor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_lock_screen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_screen_width = new System.Windows.Forms.TextBox();
            this.txt_screen_height = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_ScnStop = new System.Windows.Forms.Button();
            this.btn_scnStart = new System.Windows.Forms.Button();
            this.gp_render_mode = new System.Windows.Forms.GroupBox();
            this.rdo_Render_FullScreen = new System.Windows.Forms.RadioButton();
            this.rdo_Render_NDI = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.scroll_sub1X = new System.Windows.Forms.HScrollBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.scroll_sub1Y = new System.Windows.Forms.HScrollBar();
            this.label6 = new System.Windows.Forms.Label();
            this.scroll_sub2X = new System.Windows.Forms.HScrollBar();
            this.label7 = new System.Windows.Forms.Label();
            this.scroll_sub2Y = new System.Windows.Forms.HScrollBar();
            this.panel_renderConfig = new System.Windows.Forms.GroupBox();
            this.txt_profileRemarks = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label_currentFont = new System.Windows.Forms.Label();
            this.txt_fadeTime = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.scroll_fadeTime = new System.Windows.Forms.HScrollBar();
            this.btn_sync_sub2X = new System.Windows.Forms.Button();
            this.txt_fontSize = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.scroll_fontSize = new System.Windows.Forms.HScrollBar();
            this.txt_sub2Y = new System.Windows.Forms.TextBox();
            this.txt_sub2X = new System.Windows.Forms.TextBox();
            this.txt_sub1Y = new System.Windows.Forms.TextBox();
            this.txt_sub1X = new System.Windows.Forms.TextBox();
            this.btn_savePreset1 = new System.Windows.Forms.Button();
            this.btn_loadPreset1 = new System.Windows.Forms.Button();
            this.btn_loadPreset2 = new System.Windows.Forms.Button();
            this.btn_savePreset2 = new System.Windows.Forms.Button();
            this.btn_loadPreset3 = new System.Windows.Forms.Button();
            this.btn_savePreset3 = new System.Windows.Forms.Button();
            this.btn_loadPreset4 = new System.Windows.Forms.Button();
            this.btn_savePreset4 = new System.Windows.Forms.Button();
            this.btn_loadPreset5 = new System.Windows.Forms.Button();
            this.btn_savePreset5 = new System.Windows.Forms.Button();
            this.btn_lockSavePreset = new System.Windows.Forms.Button();
            this.btn_lockLoadPreset = new System.Windows.Forms.Button();
            this.panel_presets = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label_presetRemarks = new System.Windows.Forms.Label();
            this.gp_render_mode.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel_renderConfig.SuspendLayout();
            this.panel_presets.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_program_file
            // 
            resources.ApplyResources(this.lb_program_file, "lb_program_file");
            this.lb_program_file.Name = "lb_program_file";
            // 
            // btn_start
            // 
            resources.ApplyResources(this.btn_start, "btn_start");
            this.btn_start.Name = "btn_start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            resources.ApplyResources(this.btn_stop, "btn_stop");
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // lable_text
            // 
            resources.ApplyResources(this.lable_text, "lable_text");
            this.lable_text.Name = "lable_text";
            // 
            // lb_selected_file
            // 
            resources.ApplyResources(this.lb_selected_file, "lb_selected_file");
            this.lb_selected_file.Name = "lb_selected_file";
            // 
            // btn_import
            // 
            resources.ApplyResources(this.btn_import, "btn_import");
            this.btn_import.Name = "btn_import";
            this.btn_import.UseVisualStyleBackColor = true;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // btn_Load
            // 
            resources.ApplyResources(this.btn_Load, "btn_Load");
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // lb_pre_id
            // 
            resources.ApplyResources(this.lb_pre_id, "lb_pre_id");
            this.lb_pre_id.Name = "lb_pre_id";
            // 
            // lb_pgm_id
            // 
            resources.ApplyResources(this.lb_pgm_id, "lb_pgm_id");
            this.lb_pgm_id.Name = "lb_pgm_id";
            // 
            // lb_preview
            // 
            resources.ApplyResources(this.lb_preview, "lb_preview");
            this.lb_preview.Name = "lb_preview";
            // 
            // lb_program
            // 
            resources.ApplyResources(this.lb_program, "lb_program");
            this.lb_program.Name = "lb_program";
            // 
            // btn_fade
            // 
            resources.ApplyResources(this.btn_fade, "btn_fade");
            this.btn_fade.Name = "btn_fade";
            this.btn_fade.UseVisualStyleBackColor = true;
            this.btn_fade.Click += new System.EventHandler(this.btn_fade_Click);
            // 
            // btn_Hard
            // 
            resources.ApplyResources(this.btn_Hard, "btn_Hard");
            this.btn_Hard.Name = "btn_Hard";
            this.btn_Hard.UseVisualStyleBackColor = true;
            this.btn_Hard.Click += new System.EventHandler(this.btn_Hard_Click);
            // 
            // btn_Clear_Cut
            // 
            resources.ApplyResources(this.btn_Clear_Cut, "btn_Clear_Cut");
            this.btn_Clear_Cut.Name = "btn_Clear_Cut";
            this.btn_Clear_Cut.UseVisualStyleBackColor = true;
            this.btn_Clear_Cut.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_DeleteFile
            // 
            resources.ApplyResources(this.btn_DeleteFile, "btn_DeleteFile");
            this.btn_DeleteFile.Name = "btn_DeleteFile";
            this.btn_DeleteFile.UseVisualStyleBackColor = true;
            this.btn_DeleteFile.Click += new System.EventHandler(this.btn_DeleteFile_Click);
            // 
            // lst_File
            // 
            this.lst_File.AllowDrop = true;
            resources.ApplyResources(this.lst_File, "lst_File");
            this.lst_File.FormattingEnabled = true;
            this.lst_File.Name = "lst_File";
            this.lst_File.SelectedIndexChanged += new System.EventHandler(this.lst_File_SelectedIndexChanged);
            this.lst_File.DragDrop += new System.Windows.Forms.DragEventHandler(this.Lst_File_DragDrop);
            this.lst_File.DragEnter += new System.Windows.Forms.DragEventHandler(this.Lst_File_DragEnter);
            // 
            // lst_SubTitle
            // 
            resources.ApplyResources(this.lst_SubTitle, "lst_SubTitle");
            this.lst_SubTitle.ForeColor = System.Drawing.Color.Black;
            this.lst_SubTitle.FormattingEnabled = true;
            this.lst_SubTitle.Name = "lst_SubTitle";
            this.lst_SubTitle.SelectedIndexChanged += new System.EventHandler(this.lst_SubTitle_SelectedIndexChanged);
            // 
            // lb_Status
            // 
            resources.ApplyResources(this.lb_Status, "lb_Status");
            this.lb_Status.ForeColor = System.Drawing.Color.Red;
            this.lb_Status.Name = "lb_Status";
            // 
            // lb_Font
            // 
            resources.ApplyResources(this.lb_Font, "lb_Font");
            this.lb_Font.Name = "lb_Font";
            // 
            // cmb_Fonts
            // 
            this.cmb_Fonts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Fonts.FormattingEnabled = true;
            resources.ApplyResources(this.cmb_Fonts, "cmb_Fonts");
            this.cmb_Fonts.Name = "cmb_Fonts";
            this.cmb_Fonts.SelectedIndexChanged += new System.EventHandler(this.cmb_Fonts_SelectedIndexChanged);
            // 
            // btn_Lock_Font
            // 
            resources.ApplyResources(this.btn_Lock_Font, "btn_Lock_Font");
            this.btn_Lock_Font.ForeColor = System.Drawing.Color.Red;
            this.btn_Lock_Font.Name = "btn_Lock_Font";
            this.btn_Lock_Font.UseVisualStyleBackColor = true;
            this.btn_Lock_Font.Click += new System.EventHandler(this.btn_Lock_Font_Click);
            // 
            // btn_Clear_Fade
            // 
            resources.ApplyResources(this.btn_Clear_Fade, "btn_Clear_Fade");
            this.btn_Clear_Fade.Name = "btn_Clear_Fade";
            this.btn_Clear_Fade.UseVisualStyleBackColor = true;
            this.btn_Clear_Fade.Click += new System.EventHandler(this.btn_Clear_Fade_Click);
            // 
            // btn_refresh_monitor
            // 
            resources.ApplyResources(this.btn_refresh_monitor, "btn_refresh_monitor");
            this.btn_refresh_monitor.Name = "btn_refresh_monitor";
            this.btn_refresh_monitor.UseVisualStyleBackColor = true;
            this.btn_refresh_monitor.Click += new System.EventHandler(this.btn_refresh_monitor_Click);
            // 
            // cmb_monitor
            // 
            this.cmb_monitor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_monitor.FormattingEnabled = true;
            resources.ApplyResources(this.cmb_monitor, "cmb_monitor");
            this.cmb_monitor.Name = "cmb_monitor";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btn_lock_screen
            // 
            this.btn_lock_screen.ForeColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.btn_lock_screen, "btn_lock_screen");
            this.btn_lock_screen.Name = "btn_lock_screen";
            this.btn_lock_screen.UseVisualStyleBackColor = true;
            this.btn_lock_screen.Click += new System.EventHandler(this.btn_lock_screen_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txt_screen_width
            // 
            resources.ApplyResources(this.txt_screen_width, "txt_screen_width");
            this.txt_screen_width.Name = "txt_screen_width";
            this.txt_screen_width.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NumberFilter);
            // 
            // txt_screen_height
            // 
            resources.ApplyResources(this.txt_screen_height, "txt_screen_height");
            this.txt_screen_height.Name = "txt_screen_height";
            this.txt_screen_height.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NumberFilter);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // btn_ScnStop
            // 
            resources.ApplyResources(this.btn_ScnStop, "btn_ScnStop");
            this.btn_ScnStop.Name = "btn_ScnStop";
            this.btn_ScnStop.UseVisualStyleBackColor = true;
            this.btn_ScnStop.Click += new System.EventHandler(this.btn_ScnStop_Click);
            // 
            // btn_scnStart
            // 
            resources.ApplyResources(this.btn_scnStart, "btn_scnStart");
            this.btn_scnStart.Name = "btn_scnStart";
            this.btn_scnStart.UseVisualStyleBackColor = true;
            this.btn_scnStart.Click += new System.EventHandler(this.btn_scnStart_Click);
            // 
            // gp_render_mode
            // 
            this.gp_render_mode.Controls.Add(this.rdo_Render_FullScreen);
            this.gp_render_mode.Controls.Add(this.rdo_Render_NDI);
            resources.ApplyResources(this.gp_render_mode, "gp_render_mode");
            this.gp_render_mode.Name = "gp_render_mode";
            this.gp_render_mode.TabStop = false;
            // 
            // rdo_Render_FullScreen
            // 
            resources.ApplyResources(this.rdo_Render_FullScreen, "rdo_Render_FullScreen");
            this.rdo_Render_FullScreen.Checked = true;
            this.rdo_Render_FullScreen.Name = "rdo_Render_FullScreen";
            this.rdo_Render_FullScreen.TabStop = true;
            this.rdo_Render_FullScreen.UseVisualStyleBackColor = true;
            this.rdo_Render_FullScreen.CheckedChanged += new System.EventHandler(this.rdo_Render_FullScreen_CheckedChanged);
            // 
            // rdo_Render_NDI
            // 
            resources.ApplyResources(this.rdo_Render_NDI, "rdo_Render_NDI");
            this.rdo_Render_NDI.Name = "rdo_Render_NDI";
            this.rdo_Render_NDI.UseVisualStyleBackColor = true;
            this.rdo_Render_NDI.CheckedChanged += new System.EventHandler(this.rdo_Render_NDI_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_refresh_monitor);
            this.groupBox1.Controls.Add(this.cmb_monitor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_lock_screen);
            this.groupBox1.Controls.Add(this.txt_screen_height);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_screen_width);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // scroll_sub1X
            // 
            resources.ApplyResources(this.scroll_sub1X, "scroll_sub1X");
            this.scroll_sub1X.Maximum = 1920;
            this.scroll_sub1X.Name = "scroll_sub1X";
            this.scroll_sub1X.ValueChanged += new System.EventHandler(this.scroll_sub1X_ValueChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // scroll_sub1Y
            // 
            resources.ApplyResources(this.scroll_sub1Y, "scroll_sub1Y");
            this.scroll_sub1Y.Maximum = 1080;
            this.scroll_sub1Y.Name = "scroll_sub1Y";
            this.scroll_sub1Y.ValueChanged += new System.EventHandler(this.scroll_sub1Y_ValueChanged);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // scroll_sub2X
            // 
            resources.ApplyResources(this.scroll_sub2X, "scroll_sub2X");
            this.scroll_sub2X.Maximum = 1920;
            this.scroll_sub2X.Name = "scroll_sub2X";
            this.scroll_sub2X.ValueChanged += new System.EventHandler(this.scroll_sub2X_ValueChanged);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // scroll_sub2Y
            // 
            resources.ApplyResources(this.scroll_sub2Y, "scroll_sub2Y");
            this.scroll_sub2Y.Maximum = 1080;
            this.scroll_sub2Y.Name = "scroll_sub2Y";
            this.scroll_sub2Y.ValueChanged += new System.EventHandler(this.scroll_sub2Y_ValueChanged);
            // 
            // panel_renderConfig
            // 
            resources.ApplyResources(this.panel_renderConfig, "panel_renderConfig");
            this.panel_renderConfig.Controls.Add(this.txt_profileRemarks);
            this.panel_renderConfig.Controls.Add(this.label10);
            this.panel_renderConfig.Controls.Add(this.label_currentFont);
            this.panel_renderConfig.Controls.Add(this.txt_fadeTime);
            this.panel_renderConfig.Controls.Add(this.label9);
            this.panel_renderConfig.Controls.Add(this.scroll_fadeTime);
            this.panel_renderConfig.Controls.Add(this.btn_sync_sub2X);
            this.panel_renderConfig.Controls.Add(this.txt_fontSize);
            this.panel_renderConfig.Controls.Add(this.label8);
            this.panel_renderConfig.Controls.Add(this.scroll_fontSize);
            this.panel_renderConfig.Controls.Add(this.txt_sub2Y);
            this.panel_renderConfig.Controls.Add(this.txt_sub2X);
            this.panel_renderConfig.Controls.Add(this.txt_sub1Y);
            this.panel_renderConfig.Controls.Add(this.cmb_Fonts);
            this.panel_renderConfig.Controls.Add(this.lb_Font);
            this.panel_renderConfig.Controls.Add(this.txt_sub1X);
            this.panel_renderConfig.Controls.Add(this.label7);
            this.panel_renderConfig.Controls.Add(this.scroll_sub2Y);
            this.panel_renderConfig.Controls.Add(this.scroll_sub1X);
            this.panel_renderConfig.Controls.Add(this.label6);
            this.panel_renderConfig.Controls.Add(this.label2);
            this.panel_renderConfig.Controls.Add(this.scroll_sub2X);
            this.panel_renderConfig.Controls.Add(this.scroll_sub1Y);
            this.panel_renderConfig.Controls.Add(this.label5);
            this.panel_renderConfig.Name = "panel_renderConfig";
            this.panel_renderConfig.TabStop = false;
            // 
            // txt_profileRemarks
            // 
            resources.ApplyResources(this.txt_profileRemarks, "txt_profileRemarks");
            this.txt_profileRemarks.Name = "txt_profileRemarks";
            this.txt_profileRemarks.TextChanged += new System.EventHandler(this.txt_profileRemarks_TextChanged);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label_currentFont
            // 
            resources.ApplyResources(this.label_currentFont, "label_currentFont");
            this.label_currentFont.Name = "label_currentFont";
            // 
            // txt_fadeTime
            // 
            resources.ApplyResources(this.txt_fadeTime, "txt_fadeTime");
            this.txt_fadeTime.Name = "txt_fadeTime";
            this.txt_fadeTime.TextChanged += new System.EventHandler(this.txt_fadeTime_TextChanged);
            this.txt_fadeTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NumberFilter);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // scroll_fadeTime
            // 
            resources.ApplyResources(this.scroll_fadeTime, "scroll_fadeTime");
            this.scroll_fadeTime.Maximum = 2000;
            this.scroll_fadeTime.Minimum = 10;
            this.scroll_fadeTime.Name = "scroll_fadeTime";
            this.scroll_fadeTime.Value = 10;
            this.scroll_fadeTime.ValueChanged += new System.EventHandler(this.scroll_fadeTime_ValueChanged);
            // 
            // btn_sync_sub2X
            // 
            resources.ApplyResources(this.btn_sync_sub2X, "btn_sync_sub2X");
            this.btn_sync_sub2X.Name = "btn_sync_sub2X";
            this.btn_sync_sub2X.UseVisualStyleBackColor = true;
            this.btn_sync_sub2X.Click += new System.EventHandler(this.btn_sync_sub2X_Click);
            // 
            // txt_fontSize
            // 
            resources.ApplyResources(this.txt_fontSize, "txt_fontSize");
            this.txt_fontSize.Name = "txt_fontSize";
            this.txt_fontSize.TextChanged += new System.EventHandler(this.txt_fontSize_TextChanged);
            this.txt_fontSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NumberFilter);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // scroll_fontSize
            // 
            resources.ApplyResources(this.scroll_fontSize, "scroll_fontSize");
            this.scroll_fontSize.Maximum = 500;
            this.scroll_fontSize.Minimum = 10;
            this.scroll_fontSize.Name = "scroll_fontSize";
            this.scroll_fontSize.Value = 10;
            this.scroll_fontSize.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scroll_fontSize_Scroll);
            // 
            // txt_sub2Y
            // 
            resources.ApplyResources(this.txt_sub2Y, "txt_sub2Y");
            this.txt_sub2Y.Name = "txt_sub2Y";
            this.txt_sub2Y.TextChanged += new System.EventHandler(this.txt_sub2Y_TextChanged);
            this.txt_sub2Y.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NumberFilter);
            // 
            // txt_sub2X
            // 
            resources.ApplyResources(this.txt_sub2X, "txt_sub2X");
            this.txt_sub2X.Name = "txt_sub2X";
            this.txt_sub2X.TextChanged += new System.EventHandler(this.txt_sub2X_TextChanged);
            this.txt_sub2X.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NumberFilter);
            // 
            // txt_sub1Y
            // 
            resources.ApplyResources(this.txt_sub1Y, "txt_sub1Y");
            this.txt_sub1Y.Name = "txt_sub1Y";
            this.txt_sub1Y.TextChanged += new System.EventHandler(this.txt_sub1Y_TextChanged);
            this.txt_sub1Y.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NumberFilter);
            // 
            // txt_sub1X
            // 
            resources.ApplyResources(this.txt_sub1X, "txt_sub1X");
            this.txt_sub1X.Name = "txt_sub1X";
            this.txt_sub1X.TextChanged += new System.EventHandler(this.txt_sub1X_TextChanged);
            this.txt_sub1X.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NumberFilter);
            // 
            // btn_savePreset1
            // 
            this.btn_savePreset1.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.btn_savePreset1, "btn_savePreset1");
            this.btn_savePreset1.Name = "btn_savePreset1";
            this.btn_savePreset1.UseVisualStyleBackColor = true;
            this.btn_savePreset1.Click += new System.EventHandler(this.btn_savePreset_Click);
            // 
            // btn_loadPreset1
            // 
            this.btn_loadPreset1.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.btn_loadPreset1, "btn_loadPreset1");
            this.btn_loadPreset1.Name = "btn_loadPreset1";
            this.btn_loadPreset1.UseVisualStyleBackColor = true;
            this.btn_loadPreset1.Click += new System.EventHandler(this.btn_loadPreset_Click);
            // 
            // btn_loadPreset2
            // 
            this.btn_loadPreset2.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.btn_loadPreset2, "btn_loadPreset2");
            this.btn_loadPreset2.Name = "btn_loadPreset2";
            this.btn_loadPreset2.UseVisualStyleBackColor = true;
            this.btn_loadPreset2.Click += new System.EventHandler(this.btn_loadPreset_Click);
            // 
            // btn_savePreset2
            // 
            this.btn_savePreset2.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.btn_savePreset2, "btn_savePreset2");
            this.btn_savePreset2.Name = "btn_savePreset2";
            this.btn_savePreset2.UseVisualStyleBackColor = true;
            this.btn_savePreset2.Click += new System.EventHandler(this.btn_savePreset_Click);
            // 
            // btn_loadPreset3
            // 
            this.btn_loadPreset3.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.btn_loadPreset3, "btn_loadPreset3");
            this.btn_loadPreset3.Name = "btn_loadPreset3";
            this.btn_loadPreset3.UseVisualStyleBackColor = true;
            this.btn_loadPreset3.Click += new System.EventHandler(this.btn_loadPreset_Click);
            // 
            // btn_savePreset3
            // 
            this.btn_savePreset3.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.btn_savePreset3, "btn_savePreset3");
            this.btn_savePreset3.Name = "btn_savePreset3";
            this.btn_savePreset3.UseVisualStyleBackColor = true;
            this.btn_savePreset3.Click += new System.EventHandler(this.btn_savePreset_Click);
            // 
            // btn_loadPreset4
            // 
            this.btn_loadPreset4.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.btn_loadPreset4, "btn_loadPreset4");
            this.btn_loadPreset4.Name = "btn_loadPreset4";
            this.btn_loadPreset4.UseVisualStyleBackColor = true;
            this.btn_loadPreset4.Click += new System.EventHandler(this.btn_loadPreset_Click);
            // 
            // btn_savePreset4
            // 
            this.btn_savePreset4.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.btn_savePreset4, "btn_savePreset4");
            this.btn_savePreset4.Name = "btn_savePreset4";
            this.btn_savePreset4.UseVisualStyleBackColor = true;
            this.btn_savePreset4.Click += new System.EventHandler(this.btn_savePreset_Click);
            // 
            // btn_loadPreset5
            // 
            this.btn_loadPreset5.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.btn_loadPreset5, "btn_loadPreset5");
            this.btn_loadPreset5.Name = "btn_loadPreset5";
            this.btn_loadPreset5.UseVisualStyleBackColor = true;
            this.btn_loadPreset5.Click += new System.EventHandler(this.btn_loadPreset_Click);
            // 
            // btn_savePreset5
            // 
            this.btn_savePreset5.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.btn_savePreset5, "btn_savePreset5");
            this.btn_savePreset5.Name = "btn_savePreset5";
            this.btn_savePreset5.UseVisualStyleBackColor = true;
            this.btn_savePreset5.Click += new System.EventHandler(this.btn_savePreset_Click);
            // 
            // btn_lockSavePreset
            // 
            resources.ApplyResources(this.btn_lockSavePreset, "btn_lockSavePreset");
            this.btn_lockSavePreset.ForeColor = System.Drawing.Color.Red;
            this.btn_lockSavePreset.Name = "btn_lockSavePreset";
            this.btn_lockSavePreset.UseVisualStyleBackColor = true;
            this.btn_lockSavePreset.Click += new System.EventHandler(this.btn_lockSavePreset_Click);
            // 
            // btn_lockLoadPreset
            // 
            resources.ApplyResources(this.btn_lockLoadPreset, "btn_lockLoadPreset");
            this.btn_lockLoadPreset.ForeColor = System.Drawing.Color.Red;
            this.btn_lockLoadPreset.Name = "btn_lockLoadPreset";
            this.btn_lockLoadPreset.UseVisualStyleBackColor = true;
            this.btn_lockLoadPreset.Click += new System.EventHandler(this.btn_lockLoadPreset_Click);
            // 
            // panel_presets
            // 
            resources.ApplyResources(this.panel_presets, "panel_presets");
            this.panel_presets.Controls.Add(this.btn_loadPreset1);
            this.panel_presets.Controls.Add(this.btn_savePreset5);
            this.panel_presets.Controls.Add(this.btn_loadPreset5);
            this.panel_presets.Controls.Add(this.btn_savePreset4);
            this.panel_presets.Controls.Add(this.btn_savePreset1);
            this.panel_presets.Controls.Add(this.btn_loadPreset3);
            this.panel_presets.Controls.Add(this.btn_savePreset2);
            this.panel_presets.Controls.Add(this.btn_loadPreset4);
            this.panel_presets.Controls.Add(this.btn_savePreset3);
            this.panel_presets.Controls.Add(this.btn_loadPreset2);
            this.panel_presets.Name = "panel_presets";
            this.panel_presets.TabStop = false;
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label_presetRemarks
            // 
            resources.ApplyResources(this.label_presetRemarks, "label_presetRemarks");
            this.label_presetRemarks.Name = "label_presetRemarks";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_presetRemarks);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel_presets);
            this.Controls.Add(this.btn_lockLoadPreset);
            this.Controls.Add(this.btn_lockSavePreset);
            this.Controls.Add(this.panel_renderConfig);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gp_render_mode);
            this.Controls.Add(this.btn_ScnStop);
            this.Controls.Add(this.btn_scnStart);
            this.Controls.Add(this.btn_Clear_Fade);
            this.Controls.Add(this.lb_Status);
            this.Controls.Add(this.lst_SubTitle);
            this.Controls.Add(this.btn_Lock_Font);
            this.Controls.Add(this.lst_File);
            this.Controls.Add(this.btn_DeleteFile);
            this.Controls.Add(this.btn_Clear_Cut);
            this.Controls.Add(this.btn_Hard);
            this.Controls.Add(this.btn_fade);
            this.Controls.Add(this.lb_program);
            this.Controls.Add(this.lb_preview);
            this.Controls.Add(this.lb_pgm_id);
            this.Controls.Add(this.lb_pre_id);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.btn_import);
            this.Controls.Add(this.lb_selected_file);
            this.Controls.Add(this.lable_text);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.lb_program_file);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.gp_render_mode.ResumeLayout(false);
            this.gp_render_mode.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel_renderConfig.ResumeLayout(false);
            this.panel_renderConfig.PerformLayout();
            this.panel_presets.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_program_file;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Label lable_text;
        private System.Windows.Forms.Label lb_selected_file;
        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.Label lb_pre_id;
        private System.Windows.Forms.Label lb_pgm_id;
        private System.Windows.Forms.Label lb_preview;
        private System.Windows.Forms.Label lb_program;
        private System.Windows.Forms.Button btn_fade;
        private System.Windows.Forms.Button btn_Hard;
        private System.Windows.Forms.Button btn_Clear_Cut;
        private System.Windows.Forms.Button btn_DeleteFile;
        private System.Windows.Forms.ListBox lst_File;
        private System.Windows.Forms.ListBox lst_SubTitle;
        private System.Windows.Forms.Label lb_Status;
        private System.Windows.Forms.Label lb_Font;
        private System.Windows.Forms.ComboBox cmb_Fonts;
        private System.Windows.Forms.Button btn_Lock_Font;
        private System.Windows.Forms.Button btn_Clear_Fade;
        private System.Windows.Forms.Button btn_refresh_monitor;
        private System.Windows.Forms.ComboBox cmb_monitor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_lock_screen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_screen_width;
        private System.Windows.Forms.TextBox txt_screen_height;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_ScnStop;
        private System.Windows.Forms.Button btn_scnStart;
        private System.Windows.Forms.GroupBox gp_render_mode;
        private System.Windows.Forms.RadioButton rdo_Render_FullScreen;
        private System.Windows.Forms.RadioButton rdo_Render_NDI;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.HScrollBar scroll_sub1X;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.HScrollBar scroll_sub2Y;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.HScrollBar scroll_sub2X;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.HScrollBar scroll_sub1Y;
        private System.Windows.Forms.GroupBox panel_renderConfig;
        private System.Windows.Forms.TextBox txt_sub2Y;
        private System.Windows.Forms.TextBox txt_sub2X;
        private System.Windows.Forms.TextBox txt_sub1Y;
        private System.Windows.Forms.TextBox txt_sub1X;
        private System.Windows.Forms.TextBox txt_fontSize;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.HScrollBar scroll_fontSize;
        private System.Windows.Forms.Button btn_sync_sub2X;
        private System.Windows.Forms.TextBox txt_fadeTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.HScrollBar scroll_fadeTime;
        private System.Windows.Forms.Button btn_savePreset1;
        private System.Windows.Forms.Button btn_loadPreset1;
        private System.Windows.Forms.Label label_currentFont;
        private System.Windows.Forms.Button btn_loadPreset5;
        private System.Windows.Forms.Button btn_savePreset5;
        private System.Windows.Forms.Button btn_loadPreset4;
        private System.Windows.Forms.Button btn_savePreset4;
        private System.Windows.Forms.Button btn_loadPreset3;
        private System.Windows.Forms.Button btn_savePreset3;
        private System.Windows.Forms.Button btn_loadPreset2;
        private System.Windows.Forms.Button btn_savePreset2;
        private System.Windows.Forms.Button btn_lockSavePreset;
        private System.Windows.Forms.Button btn_lockLoadPreset;
        private System.Windows.Forms.TextBox txt_profileRemarks;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox panel_presets;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label_presetRemarks;
    }
}

