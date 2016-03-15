﻿namespace gui
{
    partial class SetupFrame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetupFrame));
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.videoPage = new System.Windows.Forms.TabPage();
            this.GP_DxWndWindowBordersCheckBox = new System.Windows.Forms.CheckBox();
            this.GP_DxWndWindowBordersLabel = new System.Windows.Forms.Label();
            this.GP_DxWndWindowedCheckBox = new System.Windows.Forms.CheckBox();
            this.GP_DxWndWindowedLabel = new System.Windows.Forms.Label();
            this.GP_DxWndRadioButton = new System.Windows.Forms.RadioButton();
            this.GP_DxWndLabel = new System.Windows.Forms.Label();
            this.GP_TSDDrawRadioButton = new System.Windows.Forms.RadioButton();
            this.GP_TSDDrawLabel = new System.Windows.Forms.Label();
            this.GP_FakeVsyncCheckBox = new System.Windows.Forms.CheckBox();
            this.GP_FakeVsyncLabel = new System.Windows.Forms.Label();
            this.GP_NoVideoMemoryCheckBox = new System.Windows.Forms.CheckBox();
            this.GP_NoVideoMemoryLabel = new System.Windows.Forms.Label();
            this.GP_ddwrapperRadioButton = new System.Windows.Forms.RadioButton();
            this.GP_IEddrawRadioButton = new System.Windows.Forms.RadioButton();
            this.GP_DisabledRadioButton = new System.Windows.Forms.RadioButton();
            this.GP_ddwrapperLabel = new System.Windows.Forms.Label();
            this.GP_IEddrawLabel = new System.Windows.Forms.Label();
            this.GP_DisabledLabel = new System.Windows.Forms.Label();
            this.GraphicPatchLabel = new System.Windows.Forms.Label();
            this.chkBackbuffer = new System.Windows.Forms.CheckBox();
            this.lblBackbuffer = new System.Windows.Forms.Label();
            this.lblVideo = new System.Windows.Forms.Label();
            this.chkWindowed = new System.Windows.Forms.CheckBox();
            this.lblWindowed = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbResolution = new System.Windows.Forms.ComboBox();
            this.gameOptionsPage = new System.Windows.Forms.TabPage();
            this.lblGameOptions = new System.Windows.Forms.Label();
            this.chkProcAffinity = new System.Windows.Forms.CheckBox();
            this.lblProcAffinity = new System.Windows.Forms.Label();
            this.chkCD = new System.Windows.Forms.CheckBox();
            this.lblCD = new System.Windows.Forms.Label();
            this.chkIntro = new System.Windows.Forms.CheckBox();
            this.lblIntro = new System.Windows.Forms.Label();
            this.chkToolTips = new System.Windows.Forms.CheckBox();
            this.lblToolTips = new System.Windows.Forms.Label();
            this.chkUnitActionLines = new System.Windows.Forms.CheckBox();
            this.lblUnitActionLines = new System.Windows.Forms.Label();
            this.soundPage = new System.Windows.Forms.TabPage();
            this.lblSound = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSoundVolumeValue = new System.Windows.Forms.Label();
            this.lblVoiceVolumeValue = new System.Windows.Forms.Label();
            this.lblScoreVolumeValue = new System.Windows.Forms.Label();
            this.lblSoundVolume = new System.Windows.Forms.Label();
            this.trbSoundVolume = new System.Windows.Forms.TrackBar();
            this.lblVoiceVolume = new System.Windows.Forms.Label();
            this.trbVoiceVolume = new System.Windows.Forms.TrackBar();
            this.lblScoreVolume = new System.Windows.Forms.Label();
            this.trbScoreVolume = new System.Windows.Forms.TrackBar();
            this.chkShuffle = new System.Windows.Forms.CheckBox();
            this.lblShuffle = new System.Windows.Forms.Label();
            this.chkRepeat = new System.Windows.Forms.CheckBox();
            this.lblRepeat = new System.Windows.Forms.Label();
            this.mpPage = new System.Windows.Forms.TabPage();
            this.btnColorSchemeEditor = new System.Windows.Forms.Button();
            this.chkUseCustomColors = new System.Windows.Forms.CheckBox();
            this.lblUseCustomColors = new System.Windows.Forms.Label();
            this.lblMP = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.videoPage.SuspendLayout();
            this.gameOptionsPage.SuspendLayout();
            this.soundPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbSoundVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbVoiceVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbScoreVolume)).BeginInit();
            this.mpPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOK.Location = new System.Drawing.Point(12, 398);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(222, 398);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(125, 398);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.videoPage);
            this.tabControl.Controls.Add(this.gameOptionsPage);
            this.tabControl.Controls.Add(this.soundPage);
            this.tabControl.Controls.Add(this.mpPage);
            this.tabControl.Location = new System.Drawing.Point(3, 6);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(301, 386);
            this.tabControl.TabIndex = 0;
            // 
            // videoPage
            // 
            this.videoPage.Controls.Add(this.GP_DxWndWindowBordersCheckBox);
            this.videoPage.Controls.Add(this.GP_DxWndWindowBordersLabel);
            this.videoPage.Controls.Add(this.GP_DxWndWindowedCheckBox);
            this.videoPage.Controls.Add(this.GP_DxWndWindowedLabel);
            this.videoPage.Controls.Add(this.GP_DxWndRadioButton);
            this.videoPage.Controls.Add(this.GP_DxWndLabel);
            this.videoPage.Controls.Add(this.GP_TSDDrawRadioButton);
            this.videoPage.Controls.Add(this.GP_TSDDrawLabel);
            this.videoPage.Controls.Add(this.GP_FakeVsyncCheckBox);
            this.videoPage.Controls.Add(this.GP_FakeVsyncLabel);
            this.videoPage.Controls.Add(this.GP_NoVideoMemoryCheckBox);
            this.videoPage.Controls.Add(this.GP_NoVideoMemoryLabel);
            this.videoPage.Controls.Add(this.GP_ddwrapperRadioButton);
            this.videoPage.Controls.Add(this.GP_IEddrawRadioButton);
            this.videoPage.Controls.Add(this.GP_DisabledRadioButton);
            this.videoPage.Controls.Add(this.GP_ddwrapperLabel);
            this.videoPage.Controls.Add(this.GP_IEddrawLabel);
            this.videoPage.Controls.Add(this.GP_DisabledLabel);
            this.videoPage.Controls.Add(this.GraphicPatchLabel);
            this.videoPage.Controls.Add(this.chkBackbuffer);
            this.videoPage.Controls.Add(this.lblBackbuffer);
            this.videoPage.Controls.Add(this.lblVideo);
            this.videoPage.Controls.Add(this.chkWindowed);
            this.videoPage.Controls.Add(this.lblWindowed);
            this.videoPage.Controls.Add(this.label1);
            this.videoPage.Controls.Add(this.cmbResolution);
            this.videoPage.Location = new System.Drawing.Point(4, 22);
            this.videoPage.Name = "videoPage";
            this.videoPage.Padding = new System.Windows.Forms.Padding(3);
            this.videoPage.Size = new System.Drawing.Size(293, 360);
            this.videoPage.TabIndex = 0;
            this.videoPage.Text = "Video";
            this.videoPage.UseVisualStyleBackColor = true;
            // 
            // GP_DxWndWindowBordersCheckBox
            // 
            this.GP_DxWndWindowBordersCheckBox.AutoSize = true;
            this.GP_DxWndWindowBordersCheckBox.Enabled = false;
            this.GP_DxWndWindowBordersCheckBox.Location = new System.Drawing.Point(164, 302);
            this.GP_DxWndWindowBordersCheckBox.Name = "GP_DxWndWindowBordersCheckBox";
            this.GP_DxWndWindowBordersCheckBox.Size = new System.Drawing.Size(29, 17);
            this.GP_DxWndWindowBordersCheckBox.TabIndex = 11;
            this.GP_DxWndWindowBordersCheckBox.Text = " ";
            this.GP_DxWndWindowBordersCheckBox.UseVisualStyleBackColor = true;
            // 
            // GP_DxWndWindowBordersLabel
            // 
            this.GP_DxWndWindowBordersLabel.Location = new System.Drawing.Point(34, 303);
            this.GP_DxWndWindowBordersLabel.Name = "GP_DxWndWindowBordersLabel";
            this.GP_DxWndWindowBordersLabel.Size = new System.Drawing.Size(230, 16);
            this.GP_DxWndWindowBordersLabel.TabIndex = 12;
            this.GP_DxWndWindowBordersLabel.Text = "No window border";
            // 
            // GP_DxWndWindowedCheckBox
            // 
            this.GP_DxWndWindowedCheckBox.AutoSize = true;
            this.GP_DxWndWindowedCheckBox.Enabled = false;
            this.GP_DxWndWindowedCheckBox.Location = new System.Drawing.Point(164, 280);
            this.GP_DxWndWindowedCheckBox.Name = "GP_DxWndWindowedCheckBox";
            this.GP_DxWndWindowedCheckBox.Size = new System.Drawing.Size(29, 17);
            this.GP_DxWndWindowedCheckBox.TabIndex = 10;
            this.GP_DxWndWindowedCheckBox.Text = " ";
            this.GP_DxWndWindowedCheckBox.UseVisualStyleBackColor = true;
            // 
            // GP_DxWndWindowedLabel
            // 
            this.GP_DxWndWindowedLabel.Location = new System.Drawing.Point(34, 281);
            this.GP_DxWndWindowedLabel.Name = "GP_DxWndWindowedLabel";
            this.GP_DxWndWindowedLabel.Size = new System.Drawing.Size(232, 18);
            this.GP_DxWndWindowedLabel.TabIndex = 13;
            this.GP_DxWndWindowedLabel.Text = "Windowed Mode:";
            // 
            // GP_DxWndRadioButton
            // 
            this.GP_DxWndRadioButton.AutoSize = true;
            this.GP_DxWndRadioButton.Location = new System.Drawing.Point(147, 256);
            this.GP_DxWndRadioButton.Name = "GP_DxWndRadioButton";
            this.GP_DxWndRadioButton.Size = new System.Drawing.Size(14, 13);
            this.GP_DxWndRadioButton.TabIndex = 9;
            this.GP_DxWndRadioButton.TabStop = true;
            this.GP_DxWndRadioButton.UseVisualStyleBackColor = true;
            this.GP_DxWndRadioButton.CheckedChanged += new System.EventHandler(this.GP_DxWndRadioButton_CheckedChanged);
            // 
            // GP_DxWndLabel
            // 
            this.GP_DxWndLabel.Location = new System.Drawing.Point(17, 256);
            this.GP_DxWndLabel.Name = "GP_DxWndLabel";
            this.GP_DxWndLabel.Size = new System.Drawing.Size(230, 15);
            this.GP_DxWndLabel.TabIndex = 14;
            this.GP_DxWndLabel.Text = "DxWnd:";
            this.GP_DxWndLabel.Click += new System.EventHandler(this.GP_DxWndLabel_Click);
            // 
            // GP_TSDDrawRadioButton
            // 
            this.GP_TSDDrawRadioButton.AutoSize = true;
            this.GP_TSDDrawRadioButton.Location = new System.Drawing.Point(147, 139);
            this.GP_TSDDrawRadioButton.Name = "GP_TSDDrawRadioButton";
            this.GP_TSDDrawRadioButton.Size = new System.Drawing.Size(14, 13);
            this.GP_TSDDrawRadioButton.TabIndex = 4;
            this.GP_TSDDrawRadioButton.TabStop = true;
            this.GP_TSDDrawRadioButton.UseVisualStyleBackColor = true;
            this.GP_TSDDrawRadioButton.CheckedChanged += new System.EventHandler(this.GP_TSDDrawRadioButton_CheckedChanged);
            // 
            // GP_TSDDrawLabel
            // 
            this.GP_TSDDrawLabel.Location = new System.Drawing.Point(17, 142);
            this.GP_TSDDrawLabel.Name = "GP_TSDDrawLabel";
            this.GP_TSDDrawLabel.Size = new System.Drawing.Size(230, 15);
            this.GP_TSDDrawLabel.TabIndex = 19;
            this.GP_TSDDrawLabel.Text = "TS-DDraw:";
            // 
            // GP_FakeVsyncCheckBox
            // 
            this.GP_FakeVsyncCheckBox.AutoSize = true;
            this.GP_FakeVsyncCheckBox.Enabled = false;
            this.GP_FakeVsyncCheckBox.Location = new System.Drawing.Point(164, 231);
            this.GP_FakeVsyncCheckBox.Name = "GP_FakeVsyncCheckBox";
            this.GP_FakeVsyncCheckBox.Size = new System.Drawing.Size(29, 17);
            this.GP_FakeVsyncCheckBox.TabIndex = 8;
            this.GP_FakeVsyncCheckBox.Text = " ";
            this.GP_FakeVsyncCheckBox.UseVisualStyleBackColor = true;
            // 
            // GP_FakeVsyncLabel
            // 
            this.GP_FakeVsyncLabel.Location = new System.Drawing.Point(34, 232);
            this.GP_FakeVsyncLabel.Name = "GP_FakeVsyncLabel";
            this.GP_FakeVsyncLabel.Size = new System.Drawing.Size(230, 16);
            this.GP_FakeVsyncLabel.TabIndex = 15;
            this.GP_FakeVsyncLabel.Text = "Fake Vsync:";
            // 
            // GP_NoVideoMemoryCheckBox
            // 
            this.GP_NoVideoMemoryCheckBox.AutoSize = true;
            this.GP_NoVideoMemoryCheckBox.Enabled = false;
            this.GP_NoVideoMemoryCheckBox.Location = new System.Drawing.Point(164, 209);
            this.GP_NoVideoMemoryCheckBox.Name = "GP_NoVideoMemoryCheckBox";
            this.GP_NoVideoMemoryCheckBox.Size = new System.Drawing.Size(29, 17);
            this.GP_NoVideoMemoryCheckBox.TabIndex = 7;
            this.GP_NoVideoMemoryCheckBox.Text = " ";
            this.GP_NoVideoMemoryCheckBox.UseVisualStyleBackColor = true;
            // 
            // GP_NoVideoMemoryLabel
            // 
            this.GP_NoVideoMemoryLabel.Location = new System.Drawing.Point(34, 210);
            this.GP_NoVideoMemoryLabel.Name = "GP_NoVideoMemoryLabel";
            this.GP_NoVideoMemoryLabel.Size = new System.Drawing.Size(232, 18);
            this.GP_NoVideoMemoryLabel.TabIndex = 16;
            this.GP_NoVideoMemoryLabel.Text = "No Video Memory:";
            // 
            // GP_ddwrapperRadioButton
            // 
            this.GP_ddwrapperRadioButton.AutoSize = true;
            this.GP_ddwrapperRadioButton.Location = new System.Drawing.Point(147, 185);
            this.GP_ddwrapperRadioButton.Name = "GP_ddwrapperRadioButton";
            this.GP_ddwrapperRadioButton.Size = new System.Drawing.Size(14, 13);
            this.GP_ddwrapperRadioButton.TabIndex = 6;
            this.GP_ddwrapperRadioButton.TabStop = true;
            this.GP_ddwrapperRadioButton.UseVisualStyleBackColor = true;
            this.GP_ddwrapperRadioButton.CheckedChanged += new System.EventHandler(this.GP_ddwrapperRadioButton_CheckedChanged);
            // 
            // GP_IEddrawRadioButton
            // 
            this.GP_IEddrawRadioButton.AutoSize = true;
            this.GP_IEddrawRadioButton.Location = new System.Drawing.Point(147, 162);
            this.GP_IEddrawRadioButton.Name = "GP_IEddrawRadioButton";
            this.GP_IEddrawRadioButton.Size = new System.Drawing.Size(14, 13);
            this.GP_IEddrawRadioButton.TabIndex = 5;
            this.GP_IEddrawRadioButton.TabStop = true;
            this.GP_IEddrawRadioButton.UseVisualStyleBackColor = true;
            // 
            // GP_DisabledRadioButton
            // 
            this.GP_DisabledRadioButton.AutoSize = true;
            this.GP_DisabledRadioButton.Location = new System.Drawing.Point(147, 116);
            this.GP_DisabledRadioButton.Name = "GP_DisabledRadioButton";
            this.GP_DisabledRadioButton.Size = new System.Drawing.Size(14, 13);
            this.GP_DisabledRadioButton.TabIndex = 3;
            this.GP_DisabledRadioButton.TabStop = true;
            this.GP_DisabledRadioButton.UseVisualStyleBackColor = true;
            // 
            // GP_ddwrapperLabel
            // 
            this.GP_ddwrapperLabel.Location = new System.Drawing.Point(17, 184);
            this.GP_ddwrapperLabel.Name = "GP_ddwrapperLabel";
            this.GP_ddwrapperLabel.Size = new System.Drawing.Size(230, 15);
            this.GP_ddwrapperLabel.TabIndex = 17;
            this.GP_ddwrapperLabel.Text = "ddwrapper:";
            // 
            // GP_IEddrawLabel
            // 
            this.GP_IEddrawLabel.Location = new System.Drawing.Point(17, 164);
            this.GP_IEddrawLabel.Name = "GP_IEddrawLabel";
            this.GP_IEddrawLabel.Size = new System.Drawing.Size(230, 13);
            this.GP_IEddrawLabel.TabIndex = 18;
            this.GP_IEddrawLabel.Text = "IE-ddraw:";
            // 
            // GP_DisabledLabel
            // 
            this.GP_DisabledLabel.Location = new System.Drawing.Point(17, 116);
            this.GP_DisabledLabel.Name = "GP_DisabledLabel";
            this.GP_DisabledLabel.Size = new System.Drawing.Size(230, 19);
            this.GP_DisabledLabel.TabIndex = 20;
            this.GP_DisabledLabel.Text = "Default:";
            // 
            // GraphicPatchLabel
            // 
            this.GraphicPatchLabel.AutoSize = true;
            this.GraphicPatchLabel.Location = new System.Drawing.Point(4, 91);
            this.GraphicPatchLabel.Name = "GraphicPatchLabel";
            this.GraphicPatchLabel.Size = new System.Drawing.Size(56, 13);
            this.GraphicPatchLabel.TabIndex = 21;
            this.GraphicPatchLabel.Text = "Rendering";
            // 
            // chkBackbuffer
            // 
            this.chkBackbuffer.AutoSize = true;
            this.chkBackbuffer.Location = new System.Drawing.Point(147, 68);
            this.chkBackbuffer.Name = "chkBackbuffer";
            this.chkBackbuffer.Size = new System.Drawing.Size(29, 17);
            this.chkBackbuffer.TabIndex = 2;
            this.chkBackbuffer.Text = " ";
            this.chkBackbuffer.UseVisualStyleBackColor = true;
            // 
            // lblBackbuffer
            // 
            this.lblBackbuffer.Location = new System.Drawing.Point(17, 68);
            this.lblBackbuffer.Name = "lblBackbuffer";
            this.lblBackbuffer.Size = new System.Drawing.Size(344, 14);
            this.lblBackbuffer.TabIndex = 22;
            this.lblBackbuffer.Text = "Graphics Patch:";
            // 
            // lblVideo
            // 
            this.lblVideo.AutoSize = true;
            this.lblVideo.Location = new System.Drawing.Point(4, 1);
            this.lblVideo.Name = "lblVideo";
            this.lblVideo.Size = new System.Drawing.Size(34, 13);
            this.lblVideo.TabIndex = 25;
            this.lblVideo.Text = "Video";
            // 
            // chkWindowed
            // 
            this.chkWindowed.AutoSize = true;
            this.chkWindowed.Location = new System.Drawing.Point(147, 45);
            this.chkWindowed.Name = "chkWindowed";
            this.chkWindowed.Size = new System.Drawing.Size(29, 17);
            this.chkWindowed.TabIndex = 1;
            this.chkWindowed.Text = " ";
            this.chkWindowed.UseVisualStyleBackColor = true;
            // 
            // lblWindowed
            // 
            this.lblWindowed.Location = new System.Drawing.Point(17, 47);
            this.lblWindowed.Name = "lblWindowed";
            this.lblWindowed.Size = new System.Drawing.Size(344, 14);
            this.lblWindowed.TabIndex = 23;
            this.lblWindowed.Text = "Windowed Mode:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Screen resolution:";
            // 
            // cmbResolution
            // 
            this.cmbResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbResolution.FormattingEnabled = true;
            this.cmbResolution.Location = new System.Drawing.Point(147, 19);
            this.cmbResolution.Name = "cmbResolution";
            this.cmbResolution.Size = new System.Drawing.Size(119, 21);
            this.cmbResolution.TabIndex = 0;
            // 
            // gameOptionsPage
            // 
            this.gameOptionsPage.Controls.Add(this.lblGameOptions);
            this.gameOptionsPage.Controls.Add(this.chkProcAffinity);
            this.gameOptionsPage.Controls.Add(this.lblProcAffinity);
            this.gameOptionsPage.Controls.Add(this.chkCD);
            this.gameOptionsPage.Controls.Add(this.lblCD);
            this.gameOptionsPage.Controls.Add(this.chkIntro);
            this.gameOptionsPage.Controls.Add(this.lblIntro);
            this.gameOptionsPage.Controls.Add(this.chkToolTips);
            this.gameOptionsPage.Controls.Add(this.lblToolTips);
            this.gameOptionsPage.Controls.Add(this.chkUnitActionLines);
            this.gameOptionsPage.Controls.Add(this.lblUnitActionLines);
            this.gameOptionsPage.Location = new System.Drawing.Point(4, 22);
            this.gameOptionsPage.Name = "gameOptionsPage";
            this.gameOptionsPage.Padding = new System.Windows.Forms.Padding(3);
            this.gameOptionsPage.Size = new System.Drawing.Size(293, 360);
            this.gameOptionsPage.TabIndex = 1;
            this.gameOptionsPage.Text = "Game Options";
            this.gameOptionsPage.UseVisualStyleBackColor = true;
            // 
            // lblGameOptions
            // 
            this.lblGameOptions.AutoSize = true;
            this.lblGameOptions.Location = new System.Drawing.Point(3, 3);
            this.lblGameOptions.Name = "lblGameOptions";
            this.lblGameOptions.Size = new System.Drawing.Size(74, 13);
            this.lblGameOptions.TabIndex = 66;
            this.lblGameOptions.Text = "Game Options";
            // 
            // chkProcAffinity
            // 
            this.chkProcAffinity.AutoSize = true;
            this.chkProcAffinity.Location = new System.Drawing.Point(146, 105);
            this.chkProcAffinity.Name = "chkProcAffinity";
            this.chkProcAffinity.Size = new System.Drawing.Size(29, 17);
            this.chkProcAffinity.TabIndex = 4;
            this.chkProcAffinity.Text = " ";
            this.chkProcAffinity.UseVisualStyleBackColor = true;
            // 
            // lblProcAffinity
            // 
            this.lblProcAffinity.Location = new System.Drawing.Point(16, 107);
            this.lblProcAffinity.Name = "lblProcAffinity";
            this.lblProcAffinity.Size = new System.Drawing.Size(297, 14);
            this.lblProcAffinity.TabIndex = 8;
            this.lblProcAffinity.Text = "Single Processor Affinity:";
            // 
            // chkCD
            // 
            this.chkCD.AutoSize = true;
            this.chkCD.Location = new System.Drawing.Point(146, 85);
            this.chkCD.Name = "chkCD";
            this.chkCD.Size = new System.Drawing.Size(29, 17);
            this.chkCD.TabIndex = 3;
            this.chkCD.Text = " ";
            this.chkCD.UseVisualStyleBackColor = true;
            // 
            // lblCD
            // 
            this.lblCD.Location = new System.Drawing.Point(16, 87);
            this.lblCD.Name = "lblCD";
            this.lblCD.Size = new System.Drawing.Size(331, 14);
            this.lblCD.TabIndex = 9;
            this.lblCD.Text = "No CD:";
            // 
            // chkIntro
            // 
            this.chkIntro.AutoSize = true;
            this.chkIntro.Location = new System.Drawing.Point(146, 65);
            this.chkIntro.Name = "chkIntro";
            this.chkIntro.Size = new System.Drawing.Size(29, 17);
            this.chkIntro.TabIndex = 2;
            this.chkIntro.Text = " ";
            this.chkIntro.UseVisualStyleBackColor = true;
            // 
            // lblIntro
            // 
            this.lblIntro.Location = new System.Drawing.Point(16, 67);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(331, 14);
            this.lblIntro.TabIndex = 10;
            this.lblIntro.Text = "Play Intro:";
            // 
            // chkToolTips
            // 
            this.chkToolTips.AutoSize = true;
            this.chkToolTips.Location = new System.Drawing.Point(146, 45);
            this.chkToolTips.Name = "chkToolTips";
            this.chkToolTips.Size = new System.Drawing.Size(29, 17);
            this.chkToolTips.TabIndex = 1;
            this.chkToolTips.Text = " ";
            this.chkToolTips.UseVisualStyleBackColor = true;
            // 
            // lblToolTips
            // 
            this.lblToolTips.Location = new System.Drawing.Point(16, 48);
            this.lblToolTips.Name = "lblToolTips";
            this.lblToolTips.Size = new System.Drawing.Size(331, 16);
            this.lblToolTips.TabIndex = 11;
            this.lblToolTips.Text = "Show tooltips:";
            // 
            // chkUnitActionLines
            // 
            this.chkUnitActionLines.AutoSize = true;
            this.chkUnitActionLines.Location = new System.Drawing.Point(146, 25);
            this.chkUnitActionLines.Name = "chkUnitActionLines";
            this.chkUnitActionLines.Size = new System.Drawing.Size(29, 17);
            this.chkUnitActionLines.TabIndex = 0;
            this.chkUnitActionLines.Text = " ";
            this.chkUnitActionLines.UseVisualStyleBackColor = true;
            // 
            // lblUnitActionLines
            // 
            this.lblUnitActionLines.Location = new System.Drawing.Point(16, 25);
            this.lblUnitActionLines.Name = "lblUnitActionLines";
            this.lblUnitActionLines.Size = new System.Drawing.Size(331, 39);
            this.lblUnitActionLines.TabIndex = 12;
            this.lblUnitActionLines.Text = "Show target lines:";
            // 
            // soundPage
            // 
            this.soundPage.Controls.Add(this.lblSound);
            this.soundPage.Controls.Add(this.label3);
            this.soundPage.Controls.Add(this.lblSoundVolumeValue);
            this.soundPage.Controls.Add(this.lblVoiceVolumeValue);
            this.soundPage.Controls.Add(this.lblScoreVolumeValue);
            this.soundPage.Controls.Add(this.lblSoundVolume);
            this.soundPage.Controls.Add(this.trbSoundVolume);
            this.soundPage.Controls.Add(this.lblVoiceVolume);
            this.soundPage.Controls.Add(this.trbVoiceVolume);
            this.soundPage.Controls.Add(this.lblScoreVolume);
            this.soundPage.Controls.Add(this.trbScoreVolume);
            this.soundPage.Controls.Add(this.chkShuffle);
            this.soundPage.Controls.Add(this.lblShuffle);
            this.soundPage.Controls.Add(this.chkRepeat);
            this.soundPage.Controls.Add(this.lblRepeat);
            this.soundPage.Location = new System.Drawing.Point(4, 22);
            this.soundPage.Name = "soundPage";
            this.soundPage.Size = new System.Drawing.Size(293, 360);
            this.soundPage.TabIndex = 2;
            this.soundPage.Text = "Sound";
            this.soundPage.UseVisualStyleBackColor = true;
            // 
            // lblSound
            // 
            this.lblSound.AutoSize = true;
            this.lblSound.Location = new System.Drawing.Point(5, 9);
            this.lblSound.Name = "lblSound";
            this.lblSound.Size = new System.Drawing.Size(38, 13);
            this.lblSound.TabIndex = 10;
            this.lblSound.Text = "Sound";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, -17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Sound";
            // 
            // lblSoundVolumeValue
            // 
            this.lblSoundVolumeValue.AutoSize = true;
            this.lblSoundVolumeValue.Location = new System.Drawing.Point(261, 131);
            this.lblSoundVolumeValue.Name = "lblSoundVolumeValue";
            this.lblSoundVolumeValue.Size = new System.Drawing.Size(27, 13);
            this.lblSoundVolumeValue.TabIndex = 43;
            this.lblSoundVolumeValue.Text = "30%";
            // 
            // lblVoiceVolumeValue
            // 
            this.lblVoiceVolumeValue.AutoSize = true;
            this.lblVoiceVolumeValue.Location = new System.Drawing.Point(261, 103);
            this.lblVoiceVolumeValue.Name = "lblVoiceVolumeValue";
            this.lblVoiceVolumeValue.Size = new System.Drawing.Size(27, 13);
            this.lblVoiceVolumeValue.TabIndex = 40;
            this.lblVoiceVolumeValue.Text = "30%";
            // 
            // lblScoreVolumeValue
            // 
            this.lblScoreVolumeValue.AutoSize = true;
            this.lblScoreVolumeValue.Location = new System.Drawing.Point(261, 75);
            this.lblScoreVolumeValue.Name = "lblScoreVolumeValue";
            this.lblScoreVolumeValue.Size = new System.Drawing.Size(27, 13);
            this.lblScoreVolumeValue.TabIndex = 37;
            this.lblScoreVolumeValue.Text = "30%";
            // 
            // lblSoundVolume
            // 
            this.lblSoundVolume.AutoSize = true;
            this.lblSoundVolume.Location = new System.Drawing.Point(12, 131);
            this.lblSoundVolume.Name = "lblSoundVolume";
            this.lblSoundVolume.Size = new System.Drawing.Size(78, 13);
            this.lblSoundVolume.TabIndex = 5;
            this.lblSoundVolume.Text = "Sound volume:";
            // 
            // trbSoundVolume
            // 
            this.trbSoundVolume.AutoSize = false;
            this.trbSoundVolume.Location = new System.Drawing.Point(134, 126);
            this.trbSoundVolume.Maximum = 20;
            this.trbSoundVolume.Name = "trbSoundVolume";
            this.trbSoundVolume.Size = new System.Drawing.Size(121, 27);
            this.trbSoundVolume.TabIndex = 4;
            this.trbSoundVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // lblVoiceVolume
            // 
            this.lblVoiceVolume.AutoSize = true;
            this.lblVoiceVolume.Location = new System.Drawing.Point(12, 103);
            this.lblVoiceVolume.Name = "lblVoiceVolume";
            this.lblVoiceVolume.Size = new System.Drawing.Size(79, 13);
            this.lblVoiceVolume.TabIndex = 6;
            this.lblVoiceVolume.Text = "Voices volume:";
            // 
            // trbVoiceVolume
            // 
            this.trbVoiceVolume.AutoSize = false;
            this.trbVoiceVolume.Location = new System.Drawing.Point(134, 98);
            this.trbVoiceVolume.Maximum = 20;
            this.trbVoiceVolume.Name = "trbVoiceVolume";
            this.trbVoiceVolume.Size = new System.Drawing.Size(121, 27);
            this.trbVoiceVolume.TabIndex = 3;
            this.trbVoiceVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // lblScoreVolume
            // 
            this.lblScoreVolume.AutoSize = true;
            this.lblScoreVolume.Location = new System.Drawing.Point(12, 75);
            this.lblScoreVolume.Name = "lblScoreVolume";
            this.lblScoreVolume.Size = new System.Drawing.Size(75, 13);
            this.lblScoreVolume.TabIndex = 7;
            this.lblScoreVolume.Text = "Music volume:";
            // 
            // trbScoreVolume
            // 
            this.trbScoreVolume.AutoSize = false;
            this.trbScoreVolume.Location = new System.Drawing.Point(134, 70);
            this.trbScoreVolume.Maximum = 20;
            this.trbScoreVolume.Name = "trbScoreVolume";
            this.trbScoreVolume.Size = new System.Drawing.Size(121, 27);
            this.trbScoreVolume.TabIndex = 2;
            this.trbScoreVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // chkShuffle
            // 
            this.chkShuffle.AutoSize = true;
            this.chkShuffle.Location = new System.Drawing.Point(142, 52);
            this.chkShuffle.Name = "chkShuffle";
            this.chkShuffle.Size = new System.Drawing.Size(29, 17);
            this.chkShuffle.TabIndex = 1;
            this.chkShuffle.Text = " ";
            this.chkShuffle.UseVisualStyleBackColor = true;
            // 
            // lblShuffle
            // 
            this.lblShuffle.Location = new System.Drawing.Point(12, 52);
            this.lblShuffle.Name = "lblShuffle";
            this.lblShuffle.Size = new System.Drawing.Size(124, 15);
            this.lblShuffle.TabIndex = 8;
            this.lblShuffle.Text = "Shuffle music:";
            // 
            // chkRepeat
            // 
            this.chkRepeat.AutoSize = true;
            this.chkRepeat.Location = new System.Drawing.Point(142, 30);
            this.chkRepeat.Name = "chkRepeat";
            this.chkRepeat.Size = new System.Drawing.Size(29, 17);
            this.chkRepeat.TabIndex = 0;
            this.chkRepeat.Text = " ";
            this.chkRepeat.UseVisualStyleBackColor = true;
            // 
            // lblRepeat
            // 
            this.lblRepeat.Location = new System.Drawing.Point(12, 31);
            this.lblRepeat.Name = "lblRepeat";
            this.lblRepeat.Size = new System.Drawing.Size(141, 14);
            this.lblRepeat.TabIndex = 9;
            this.lblRepeat.Text = "Repeat music:";
            // 
            // mpPage
            // 
            this.mpPage.Controls.Add(this.btnColorSchemeEditor);
            this.mpPage.Controls.Add(this.chkUseCustomColors);
            this.mpPage.Controls.Add(this.lblUseCustomColors);
            this.mpPage.Controls.Add(this.lblMP);
            this.mpPage.Location = new System.Drawing.Point(4, 22);
            this.mpPage.Name = "mpPage";
            this.mpPage.Padding = new System.Windows.Forms.Padding(3);
            this.mpPage.Size = new System.Drawing.Size(293, 360);
            this.mpPage.TabIndex = 3;
            this.mpPage.Text = "Multiplayer";
            this.mpPage.UseVisualStyleBackColor = true;
            // 
            // btnColorSchemeEditor
            // 
            this.btnColorSchemeEditor.Location = new System.Drawing.Point(164, 29);
            this.btnColorSchemeEditor.Name = "btnColorSchemeEditor";
            this.btnColorSchemeEditor.Size = new System.Drawing.Size(76, 22);
            this.btnColorSchemeEditor.TabIndex = 9;
            this.btnColorSchemeEditor.Text = "Edit Colors";
            this.btnColorSchemeEditor.Click += new System.EventHandler(this.btnColorSchemeEditor_Click);
            // 
            // chkUseCustomColors
            // 
            this.chkUseCustomColors.Location = new System.Drawing.Point(146, 27);
            this.chkUseCustomColors.Name = "chkUseCustomColors";
            this.chkUseCustomColors.Size = new System.Drawing.Size(29, 17);
            this.chkUseCustomColors.TabIndex = 8;
            this.chkUseCustomColors.Text = " ";
            this.chkUseCustomColors.UseVisualStyleBackColor = true;
            this.chkUseCustomColors.Click += new System.EventHandler(this.lblUseCustomColors_Click);
            // 
            // lblUseCustomColors
            // 
            this.lblUseCustomColors.Location = new System.Drawing.Point(16, 29);
            this.lblUseCustomColors.Name = "lblUseCustomColors";
            this.lblUseCustomColors.Size = new System.Drawing.Size(145, 14);
            this.lblUseCustomColors.TabIndex = 10;
            this.lblUseCustomColors.Text = "Use Custom Colors:";
            // 
            // lblMP
            // 
            this.lblMP.AutoSize = true;
            this.lblMP.Location = new System.Drawing.Point(7, 7);
            this.lblMP.Name = "lblMP";
            this.lblMP.Size = new System.Drawing.Size(57, 13);
            this.lblMP.TabIndex = 0;
            this.lblMP.Text = "Multiplayer";
            // 
            // SetupFrame
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(309, 433);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SetupFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tiberian Sun Config";
            this.Load += new System.EventHandler(this.SetupFrame_Load);
            this.tabControl.ResumeLayout(false);
            this.videoPage.ResumeLayout(false);
            this.videoPage.PerformLayout();
            this.gameOptionsPage.ResumeLayout(false);
            this.gameOptionsPage.PerformLayout();
            this.soundPage.ResumeLayout(false);
            this.soundPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbSoundVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbVoiceVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbScoreVolume)).EndInit();
            this.mpPage.ResumeLayout(false);
            this.mpPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage videoPage;
        private System.Windows.Forms.RadioButton GP_TSDDrawRadioButton;
        private System.Windows.Forms.Label GP_TSDDrawLabel;
        private System.Windows.Forms.CheckBox GP_FakeVsyncCheckBox;
        private System.Windows.Forms.Label GP_FakeVsyncLabel;
        private System.Windows.Forms.CheckBox GP_NoVideoMemoryCheckBox;
        private System.Windows.Forms.Label GP_NoVideoMemoryLabel;
        private System.Windows.Forms.RadioButton GP_ddwrapperRadioButton;
        private System.Windows.Forms.RadioButton GP_IEddrawRadioButton;
        private System.Windows.Forms.RadioButton GP_DisabledRadioButton;
        private System.Windows.Forms.Label GP_ddwrapperLabel;
        private System.Windows.Forms.Label GP_IEddrawLabel;
        private System.Windows.Forms.Label GP_DisabledLabel;
        private System.Windows.Forms.Label GraphicPatchLabel;
        private System.Windows.Forms.CheckBox chkBackbuffer;
        private System.Windows.Forms.Label lblBackbuffer;
        private System.Windows.Forms.Label lblVideo;
        private System.Windows.Forms.CheckBox chkWindowed;
        private System.Windows.Forms.Label lblWindowed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbResolution;
        private System.Windows.Forms.TabPage gameOptionsPage;
        private System.Windows.Forms.CheckBox chkProcAffinity;
        private System.Windows.Forms.Label lblProcAffinity;
        private System.Windows.Forms.CheckBox chkCD;
        private System.Windows.Forms.Label lblCD;
        private System.Windows.Forms.CheckBox chkIntro;
        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.CheckBox chkToolTips;
        private System.Windows.Forms.Label lblToolTips;
        private System.Windows.Forms.CheckBox chkUnitActionLines;
        private System.Windows.Forms.Label lblUnitActionLines;
        private System.Windows.Forms.TabPage soundPage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSoundVolumeValue;
        private System.Windows.Forms.Label lblVoiceVolumeValue;
        private System.Windows.Forms.Label lblScoreVolumeValue;
        private System.Windows.Forms.Label lblSoundVolume;
        private System.Windows.Forms.TrackBar trbSoundVolume;
        private System.Windows.Forms.Label lblVoiceVolume;
        private System.Windows.Forms.TrackBar trbVoiceVolume;
        private System.Windows.Forms.Label lblScoreVolume;
        private System.Windows.Forms.TrackBar trbScoreVolume;
        private System.Windows.Forms.CheckBox chkShuffle;
        private System.Windows.Forms.Label lblShuffle;
        private System.Windows.Forms.CheckBox chkRepeat;
        private System.Windows.Forms.Label lblRepeat;
        private System.Windows.Forms.Label lblGameOptions;
        private System.Windows.Forms.Label lblSound;
        private System.Windows.Forms.CheckBox GP_DxWndWindowBordersCheckBox;
        private System.Windows.Forms.Label GP_DxWndWindowBordersLabel;
        private System.Windows.Forms.CheckBox GP_DxWndWindowedCheckBox;
        private System.Windows.Forms.Label GP_DxWndWindowedLabel;
        private System.Windows.Forms.RadioButton GP_DxWndRadioButton;
        private System.Windows.Forms.Label GP_DxWndLabel;
        private System.Windows.Forms.TabPage mpPage;
        private System.Windows.Forms.Button btnColorSchemeEditor;
        private System.Windows.Forms.CheckBox chkUseCustomColors;
        private System.Windows.Forms.Label lblUseCustomColors;
        private System.Windows.Forms.Label lblMP;
    }
}

