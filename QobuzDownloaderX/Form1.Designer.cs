namespace QobuzDownloaderX
{
    partial class QobuzDownloaderX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QobuzDownloaderX));
            this.testURLBox = new System.Windows.Forms.TextBox();
            this.selectFolder = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.output = new System.Windows.Forms.TextBox();
            this.downloadBG = new System.ComponentModel.BackgroundWorker();
            this.openFolderButton = new System.Windows.Forms.Button();
            this.downloadButton = new System.Windows.Forms.Button();
            this.albumUrl = new System.Windows.Forms.TextBox();
            this.imageURLTextbox = new System.Windows.Forms.TextBox();
            this.verNumLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.albumArtistTextBox = new System.Windows.Forms.TextBox();
            this.albumTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.releaseDateTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.upcTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.albumArtPicBox = new System.Windows.Forms.PictureBox();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.totalTracksTextbox = new System.Windows.Forms.TextBox();
            this.totalTracksLabel = new System.Windows.Forms.Label();
            this.getLinkTypeBG = new System.ComponentModel.BackgroundWorker();
            this.downloadAlbumBG = new System.ComponentModel.BackgroundWorker();
            this.downloadTrackBG = new System.ComponentModel.BackgroundWorker();
            this.downloadDiscogBG = new System.ComponentModel.BackgroundWorker();
            this.qualityTextbox = new System.Windows.Forms.TextBox();
            this.qualityLabel = new System.Windows.Forms.Label();
            this.openSearch = new System.Windows.Forms.Button();
            this.tagsLabel = new System.Windows.Forms.Label();
            this.albumArtistCheckbox = new System.Windows.Forms.CheckBox();
            this.artistCheckbox = new System.Windows.Forms.CheckBox();
            this.trackTitleCheckbox = new System.Windows.Forms.CheckBox();
            this.trackNumberCheckbox = new System.Windows.Forms.CheckBox();
            this.trackTotalCheckbox = new System.Windows.Forms.CheckBox();
            this.discNumberCheckbox = new System.Windows.Forms.CheckBox();
            this.discTotalCheckbox = new System.Windows.Forms.CheckBox();
            this.albumCheckbox = new System.Windows.Forms.CheckBox();
            this.explicitCheckbox = new System.Windows.Forms.CheckBox();
            this.upcCheckbox = new System.Windows.Forms.CheckBox();
            this.isrcCheckbox = new System.Windows.Forms.CheckBox();
            this.copyrightCheckbox = new System.Windows.Forms.CheckBox();
            this.composerCheckbox = new System.Windows.Forms.CheckBox();
            this.genreCheckbox = new System.Windows.Forms.CheckBox();
            this.releaseCheckbox = new System.Windows.Forms.CheckBox();
            this.commentCheckbox = new System.Windows.Forms.CheckBox();
            this.commentTextbox = new System.Windows.Forms.TextBox();
            this.imageCheckbox = new System.Windows.Forms.CheckBox();
            this.mp3Checkbox = new System.Windows.Forms.CheckBox();
            this.flacLowCheckbox = new System.Windows.Forms.CheckBox();
            this.flacMidCheckbox = new System.Windows.Forms.CheckBox();
            this.flacHighCheckbox = new System.Windows.Forms.CheckBox();
            this.mp3WarnLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitLabel = new System.Windows.Forms.Label();
            this.minimizeLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.streamableCheckbox = new System.Windows.Forms.CheckBox();
            this.secretTextbox = new System.Windows.Forms.TextBox();
            this.displaySecretButton = new System.Windows.Forms.Button();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.logoutLabel = new System.Windows.Forms.Label();
            this.downloadLabelBG = new System.ComponentModel.BackgroundWorker();
            this.hiddenTextPanel = new System.Windows.Forms.Panel();
            this.downloadFaveAlbumsBG = new System.ComponentModel.BackgroundWorker();
            this.downloadFaveArtistsBG = new System.ComponentModel.BackgroundWorker();
            this.artSizeSelect = new System.Windows.Forms.ComboBox();
            this.artSizeLabel = new System.Windows.Forms.Label();
            this.typeCheckbox = new System.Windows.Forms.CheckBox();
            this.aboutLabel = new System.Windows.Forms.Label();
            this.enableBtnsButton = new System.Windows.Forms.Button();
            this.hideDebugButton = new System.Windows.Forms.Button();
            this.maxLengthLabel = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.maxLengthTextbox = new System.Windows.Forms.TextBox();
            this.maxLengthWarnLabel = new System.Windows.Forms.Label();
            this.customFormatPanel = new System.Windows.Forms.Panel();
            this.customFormatIDTextbox = new System.Windows.Forms.TextBox();
            this.formatIDLabel = new System.Windows.Forms.Label();
            this.filenameTempSelect = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.downloadPlaylistBG = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.albumArtPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // testURLBox
            // 
            this.testURLBox.Location = new System.Drawing.Point(968, 367);
            this.testURLBox.Multiline = true;
            this.testURLBox.Name = "testURLBox";
            this.testURLBox.Size = new System.Drawing.Size(390, 19);
            this.testURLBox.TabIndex = 1;
            this.testURLBox.Text = "Steamed Qobuz File URL";
            this.testURLBox.Visible = false;
            this.testURLBox.WordWrap = false;
            // 
            // selectFolder
            // 
            this.selectFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(239)))));
            this.selectFolder.FlatAppearance.BorderSize = 0;
            this.selectFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectFolder.ForeColor = System.Drawing.Color.White;
            this.selectFolder.Location = new System.Drawing.Point(16, 109);
            this.selectFolder.Name = "selectFolder";
            this.selectFolder.Size = new System.Drawing.Size(349, 21);
            this.selectFolder.TabIndex = 2;
            this.selectFolder.Text = "选择文件夹";
            this.selectFolder.UseVisualStyleBackColor = false;
            this.selectFolder.Click += new System.EventHandler(this.selectFolder_Click);
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.output.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.output.Location = new System.Drawing.Point(15, 136);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.output.Size = new System.Drawing.Size(705, 313);
            this.output.TabIndex = 3;
            this.output.Text = "Test String";
            // 
            // openFolderButton
            // 
            this.openFolderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(239)))));
            this.openFolderButton.FlatAppearance.BorderSize = 0;
            this.openFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openFolderButton.ForeColor = System.Drawing.Color.White;
            this.openFolderButton.Location = new System.Drawing.Point(371, 109);
            this.openFolderButton.Name = "openFolderButton";
            this.openFolderButton.Size = new System.Drawing.Size(349, 21);
            this.openFolderButton.TabIndex = 13;
            this.openFolderButton.Text = "打开下载文件夹";
            this.openFolderButton.UseVisualStyleBackColor = false;
            this.openFolderButton.Click += new System.EventHandler(this.openFolderButton_Click);
            // 
            // downloadButton
            // 
            this.downloadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(239)))));
            this.downloadButton.FlatAppearance.BorderSize = 0;
            this.downloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downloadButton.ForeColor = System.Drawing.Color.White;
            this.downloadButton.Location = new System.Drawing.Point(600, 82);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(120, 21);
            this.downloadButton.TabIndex = 17;
            this.downloadButton.Text = "下载";
            this.downloadButton.UseVisualStyleBackColor = false;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // albumUrl
            // 
            this.albumUrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.albumUrl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.albumUrl.ForeColor = System.Drawing.Color.White;
            this.albumUrl.Location = new System.Drawing.Point(18, 84);
            this.albumUrl.Multiline = true;
            this.albumUrl.Name = "albumUrl";
            this.albumUrl.Size = new System.Drawing.Size(576, 18);
            this.albumUrl.TabIndex = 16;
            this.albumUrl.WordWrap = false;
            this.albumUrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.albumUrl_KeyDown);
            // 
            // imageURLTextbox
            // 
            this.imageURLTextbox.Location = new System.Drawing.Point(966, 391);
            this.imageURLTextbox.Multiline = true;
            this.imageURLTextbox.Name = "imageURLTextbox";
            this.imageURLTextbox.Size = new System.Drawing.Size(390, 19);
            this.imageURLTextbox.TabIndex = 31;
            this.imageURLTextbox.Text = "Release Cover Art URL";
            this.imageURLTextbox.Visible = false;
            this.imageURLTextbox.WordWrap = false;
            // 
            // verNumLabel
            // 
            this.verNumLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            this.verNumLabel.Location = new System.Drawing.Point(162, 54);
            this.verNumLabel.Name = "verNumLabel";
            this.verNumLabel.Size = new System.Drawing.Size(63, 12);
            this.verNumLabel.TabIndex = 38;
            this.verNumLabel.Text = "#.#.#.#";
            this.verNumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            this.label1.Location = new System.Drawing.Point(804, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 40;
            this.label1.Text = "专辑封面";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            this.label2.Location = new System.Drawing.Point(754, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 41;
            this.label2.Text = "专辑艺术家";
            // 
            // albumArtistTextBox
            // 
            this.albumArtistTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.albumArtistTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.albumArtistTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            this.albumArtistTextBox.Location = new System.Drawing.Point(757, 236);
            this.albumArtistTextBox.Multiline = true;
            this.albumArtistTextBox.Name = "albumArtistTextBox";
            this.albumArtistTextBox.ReadOnly = true;
            this.albumArtistTextBox.Size = new System.Drawing.Size(150, 18);
            this.albumArtistTextBox.TabIndex = 42;
            this.albumArtistTextBox.WordWrap = false;
            // 
            // albumTextBox
            // 
            this.albumTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.albumTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.albumTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            this.albumTextBox.Location = new System.Drawing.Point(757, 274);
            this.albumTextBox.Multiline = true;
            this.albumTextBox.Name = "albumTextBox";
            this.albumTextBox.ReadOnly = true;
            this.albumTextBox.Size = new System.Drawing.Size(150, 18);
            this.albumTextBox.TabIndex = 44;
            this.albumTextBox.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            this.label3.Location = new System.Drawing.Point(754, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 43;
            this.label3.Text = "专辑名";
            // 
            // releaseDateTextBox
            // 
            this.releaseDateTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.releaseDateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.releaseDateTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            this.releaseDateTextBox.Location = new System.Drawing.Point(757, 430);
            this.releaseDateTextBox.Multiline = true;
            this.releaseDateTextBox.Name = "releaseDateTextBox";
            this.releaseDateTextBox.ReadOnly = true;
            this.releaseDateTextBox.Size = new System.Drawing.Size(150, 18);
            this.releaseDateTextBox.TabIndex = 46;
            this.releaseDateTextBox.WordWrap = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            this.label4.Location = new System.Drawing.Point(754, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 45;
            this.label4.Text = "发行日期";
            // 
            // upcTextBox
            // 
            this.upcTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.upcTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.upcTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            this.upcTextBox.Location = new System.Drawing.Point(757, 391);
            this.upcTextBox.Multiline = true;
            this.upcTextBox.Name = "upcTextBox";
            this.upcTextBox.ReadOnly = true;
            this.upcTextBox.Size = new System.Drawing.Size(150, 18);
            this.upcTextBox.TabIndex = 48;
            this.upcTextBox.WordWrap = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            this.label5.Location = new System.Drawing.Point(754, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 12);
            this.label5.TabIndex = 47;
            this.label5.Text = "UPC";
            // 
            // albumArtPicBox
            // 
            this.albumArtPicBox.Location = new System.Drawing.Point(757, 56);
            this.albumArtPicBox.MaximumSize = new System.Drawing.Size(150, 138);
            this.albumArtPicBox.MinimumSize = new System.Drawing.Size(150, 138);
            this.albumArtPicBox.Name = "albumArtPicBox";
            this.albumArtPicBox.Size = new System.Drawing.Size(150, 138);
            this.albumArtPicBox.TabIndex = 39;
            this.albumArtPicBox.TabStop = false;
            // 
            // logoBox
            // 
            this.logoBox.Image = global::QobuzDownloaderX.Properties.Resources.qbdlx_white;
            this.logoBox.Location = new System.Drawing.Point(15, 14);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(207, 48);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoBox.TabIndex = 36;
            this.logoBox.TabStop = false;
            this.logoBox.Click += new System.EventHandler(this.logoBox_Click);
            this.logoBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            this.label6.Location = new System.Drawing.Point(15, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 49;
            this.label6.Text = "Qobuz链接";
            // 
            // totalTracksTextbox
            // 
            this.totalTracksTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.totalTracksTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalTracksTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            this.totalTracksTextbox.Location = new System.Drawing.Point(757, 352);
            this.totalTracksTextbox.Multiline = true;
            this.totalTracksTextbox.Name = "totalTracksTextbox";
            this.totalTracksTextbox.ReadOnly = true;
            this.totalTracksTextbox.Size = new System.Drawing.Size(150, 18);
            this.totalTracksTextbox.TabIndex = 56;
            this.totalTracksTextbox.WordWrap = false;
            // 
            // totalTracksLabel
            // 
            this.totalTracksLabel.AutoSize = true;
            this.totalTracksLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            this.totalTracksLabel.Location = new System.Drawing.Point(754, 337);
            this.totalTracksLabel.Name = "totalTracksLabel";
            this.totalTracksLabel.Size = new System.Drawing.Size(65, 12);
            this.totalTracksLabel.TabIndex = 55;
            this.totalTracksLabel.Text = "总曲目数量";
            // 
            // getLinkTypeBG
            // 
            this.getLinkTypeBG.DoWork += new System.ComponentModel.DoWorkEventHandler(this.getLinkTypeBG_DoWork);
            // 
            // downloadAlbumBG
            // 
            this.downloadAlbumBG.DoWork += new System.ComponentModel.DoWorkEventHandler(this.downloadAlbumBG_DoWork);
            // 
            // downloadTrackBG
            // 
            this.downloadTrackBG.DoWork += new System.ComponentModel.DoWorkEventHandler(this.downloadTrackBG_DoWork);
            // 
            // downloadDiscogBG
            // 
            this.downloadDiscogBG.DoWork += new System.ComponentModel.DoWorkEventHandler(this.downloadDiscogBG_DoWork);
            // 
            // qualityTextbox
            // 
            this.qualityTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.qualityTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.qualityTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            this.qualityTextbox.Location = new System.Drawing.Point(757, 313);
            this.qualityTextbox.Multiline = true;
            this.qualityTextbox.Name = "qualityTextbox";
            this.qualityTextbox.ReadOnly = true;
            this.qualityTextbox.Size = new System.Drawing.Size(150, 18);
            this.qualityTextbox.TabIndex = 59;
            this.qualityTextbox.WordWrap = false;
            // 
            // qualityLabel
            // 
            this.qualityLabel.AutoSize = true;
            this.qualityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            this.qualityLabel.Location = new System.Drawing.Point(754, 298);
            this.qualityLabel.Name = "qualityLabel";
            this.qualityLabel.Size = new System.Drawing.Size(53, 12);
            this.qualityLabel.TabIndex = 58;
            this.qualityLabel.Text = "专辑音质";
            // 
            // openSearch
            // 
            this.openSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(239)))));
            this.openSearch.FlatAppearance.BorderSize = 0;
            this.openSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openSearch.ForeColor = System.Drawing.Color.White;
            this.openSearch.Location = new System.Drawing.Point(600, 56);
            this.openSearch.Name = "openSearch";
            this.openSearch.Size = new System.Drawing.Size(120, 21);
            this.openSearch.TabIndex = 60;
            this.openSearch.Text = "打开搜索";
            this.openSearch.UseVisualStyleBackColor = false;
            this.openSearch.Click += new System.EventHandler(this.openSearch_Click);
            // 
            // tagsLabel
            // 
            this.tagsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            this.tagsLabel.Location = new System.Drawing.Point(15, 465);
            this.tagsLabel.Name = "tagsLabel";
            this.tagsLabel.Size = new System.Drawing.Size(914, 21);
            this.tagsLabel.TabIndex = 61;
            this.tagsLabel.Text = "🠋 Choose which tags to save (click me) 🠋";
            this.tagsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tagsLabel.Click += new System.EventHandler(this.tagsLabel_Click);
            // 
            // albumArtistCheckbox
            // 
            this.albumArtistCheckbox.AutoSize = true;
            this.albumArtistCheckbox.Checked = true;
            this.albumArtistCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.albumArtistCheckbox.FlatAppearance.BorderSize = 0;
            this.albumArtistCheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            this.albumArtistCheckbox.Location = new System.Drawing.Point(15, 501);
            this.albumArtistCheckbox.Name = "albumArtistCheckbox";
            this.albumArtistCheckbox.Size = new System.Drawing.Size(96, 16);
            this.albumArtistCheckbox.TabIndex = 62;
            this.albumArtistCheckbox.Text = "Album Artist";
            this.albumArtistCheckbox.UseVisualStyleBackColor = true;
            this.albumArtistCheckbox.CheckedChanged += new System.EventHandler(this.albumArtistCheckbox_CheckedChanged);
            // 
            // artistCheckbox
            // 
            this.artistCheckbox.AutoSize = true;
            this.artistCheckbox.Checked = true;
            this.artistCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.artistCheckbox.FlatAppearance.BorderSize = 0;
            this.artistCheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            this.artistCheckbox.Location = new System.Drawing.Point(186, 501);
            this.artistCheckbox.Name = "artistCheckbox";
            this.artistCheckbox.Size = new System.Drawing.Size(96, 16);
            this.artistCheckbox.TabIndex = 63;
            this.artistCheckbox.Text = "Track Artist";
            this.artistCheckbox.UseVisualStyleBackColor = true;
            this.artistCheckbox.CheckedChanged += new System.EventHandler(this.artistCheckbox_CheckedChanged);
            // 
            // trackTitleCheckbox
            // 
            this.trackTitleCheckbox.AutoSize = true;
            this.trackTitleCheckbox.Checked = true;
            this.trackTitleCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.trackTitleCheckbox.FlatAppearance.BorderSize = 0;
            this.trackTitleCheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            this.trackTitleCheckbox.Location = new System.Drawing.Point(272, 501);
            this.trackTitleCheckbox.Name = "trackTitleCheckbox";
            this.trackTitleCheckbox.Size = new System.Drawing.Size(90, 16);
            this.trackTitleCheckbox.TabIndex = 64;
            this.trackTitleCheckbox.Text = "Track Title";
            this.trackTitleCheckbox.UseVisualStyleBackColor = true;
            this.trackTitleCheckbox.CheckedChanged += new System.EventHandler(this.trackTitleCheckbox_CheckedChanged);
            // 
            // trackNumberCheckbox
            // 
            this.trackNumberCheckbox.AutoSize = true;
            this.trackNumberCheckbox.Checked = true;
            this.trackNumberCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.trackNumberCheckbox.FlatAppearance.BorderSize = 0;
            this.trackNumberCheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            this.trackNumberCheckbox.Location = new System.Drawing.Point(107, 527);
            this.trackNumberCheckbox.Name = "trackNumberCheckbox";
            this.trackNumberCheckbox.Size = new System.Drawing.Size(96, 16);
            this.trackNumberCheckbox.TabIndex = 65;
            this.trackNumberCheckbox.Text = "Track Number";
            this.trackNumberCheckbox.UseVisualStyleBackColor = true;
            this.trackNumberCheckbox.CheckedChanged += new System.EventHandler(this.trackNumberCheckbox_CheckedChanged);
            // 
            // trackTotalCheckbox
            // 
            this.trackTotalCheckbox.AutoSize = true;
            this.trackTotalCheckbox.Checked = true;
            this.trackTotalCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.trackTotalCheckbox.FlatAppearance.BorderSize = 0;
            this.trackTotalCheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            this.trackTotalCheckbox.Location = new System.Drawing.Point(15, 527);
            this.trackTotalCheckbox.Name = "trackTotalCheckbox";
            this.trackTotalCheckbox.Size = new System.Drawing.Size(96, 16);
            this.trackTotalCheckbox.TabIndex = 66;
            this.trackTotalCheckbox.Text = "Total Tracks";
            this.trackTotalCheckbox.UseVisualStyleBackColor = true;
            this.trackTotalCheckbox.CheckedChanged += new System.EventHandler(this.trackTotalCheckbox_CheckedChanged);
            // 
            // discNumberCheckbox
            // 
            this.discNumberCheckbox.AutoSize = true;
            this.discNumberCheckbox.Checked = true;
            this.discNumberCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.discNumberCheckbox.FlatAppearance.BorderSize = 0;
            this.discNumberCheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            this.discNumberCheckbox.Location = new System.Drawing.Point(292, 527);
            this.discNumberCheckbox.Name = "discNumberCheckbox";
            this.discNumberCheckbox.Size = new System.Drawing.Size(90, 16);
            this.discNumberCheckbox.TabIndex = 67;
            this.discNumberCheckbox.Text = "Disc Number";
            this.discNumberCheckbox.UseVisualStyleBackColor = true;
            this.discNumberCheckbox.CheckedChanged += new System.EventHandler(this.discNumberCheckbox_CheckedChanged);
            // 
            // discTotalCheckbox
            // 
            this.discTotalCheckbox.AutoSize = true;
            this.discTotalCheckbox.Checked = true;
            this.discTotalCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.discTotalCheckbox.FlatAppearance.BorderSize = 0;
            this.discTotalCheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            this.discTotalCheckbox.Location = new System.Drawing.Point(207, 527);
            this.discTotalCheckbox.Name = "discTotalCheckbox";
            this.discTotalCheckbox.Size = new System.Drawing.Size(90, 16);
            this.discTotalCheckbox.TabIndex = 68;
            this.discTotalCheckbox.Text = "Total Discs";
            this.discTotalCheckbox.UseVisualStyleBackColor = true;
            this.discTotalCheckbox.CheckedChanged += new System.EventHandler(this.discTotalCheckbox_CheckedChanged);
            // 
            // albumCheckbox
            // 
            this.albumCheckbox.AutoSize = true;
            this.albumCheckbox.Checked = true;
            this.albumCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.albumCheckbox.FlatAppearance.BorderSize = 0;
            this.albumCheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            this.albumCheckbox.Location = new System.Drawing.Point(102, 501);
            this.albumCheckbox.Name = "albumCheckbox";
            this.albumCheckbox.Size = new System.Drawing.Size(90, 16);
            this.albumCheckbox.TabIndex = 69;
            this.albumCheckbox.Text = "Album Title";
            this.albumCheckbox.UseVisualStyleBackColor = true;
            this.albumCheckbox.CheckedChanged += new System.EventHandler(this.albumCheckbox_CheckedChanged);
            // 
            // explicitCheckbox
            // 
            this.explicitCheckbox.AutoSize = true;
            this.explicitCheckbox.Checked = true;
            this.explicitCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.explicitCheckbox.FlatAppearance.BorderSize = 0;
            this.explicitCheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            this.explicitCheckbox.Location = new System.Drawing.Point(461, 527);
            this.explicitCheckbox.Name = "explicitCheckbox";
            this.explicitCheckbox.Size = new System.Drawing.Size(132, 16);
            this.explicitCheckbox.TabIndex = 76;
            this.explicitCheckbox.Text = "Explicit Advisory*";
            this.explicitCheckbox.UseVisualStyleBackColor = true;
            this.explicitCheckbox.CheckedChanged += new System.EventHandler(this.explicitCheckbox_CheckedChanged);
            // 
            // upcCheckbox
            // 
            this.upcCheckbox.AutoSize = true;
            this.upcCheckbox.Checked = true;
            this.upcCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.upcCheckbox.FlatAppearance.BorderSize = 0;
            this.upcCheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            this.upcCheckbox.Location = new System.Drawing.Point(766, 501);
            this.upcCheckbox.Name = "upcCheckbox";
            this.upcCheckbox.Size = new System.Drawing.Size(48, 16);
            this.upcCheckbox.TabIndex = 75;
            this.upcCheckbox.Text = "UPC*";
            this.upcCheckbox.UseVisualStyleBackColor = true;
            this.upcCheckbox.CheckedChanged += new System.EventHandler(this.upcCheckbox_CheckedChanged);
            // 
            // isrcCheckbox
            // 
            this.isrcCheckbox.AutoSize = true;
            this.isrcCheckbox.Checked = true;
            this.isrcCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isrcCheckbox.FlatAppearance.BorderSize = 0;
            this.isrcCheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            this.isrcCheckbox.Location = new System.Drawing.Point(824, 501);
            this.isrcCheckbox.Name = "isrcCheckbox";
            this.isrcCheckbox.Size = new System.Drawing.Size(48, 16);
            this.isrcCheckbox.TabIndex = 74;
            this.isrcCheckbox.Text = "ISRC";
            this.isrcCheckbox.UseVisualStyleBackColor = true;
            this.isrcCheckbox.CheckedChanged += new System.EventHandler(this.isrcCheckbox_CheckedChanged);
            // 
            // copyrightCheckbox
            // 
            this.copyrightCheckbox.AutoSize = true;
            this.copyrightCheckbox.Checked = true;
            this.copyrightCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.copyrightCheckbox.FlatAppearance.BorderSize = 0;
            this.copyrightCheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            this.copyrightCheckbox.Location = new System.Drawing.Point(690, 501);
            this.copyrightCheckbox.Name = "copyrightCheckbox";
            this.copyrightCheckbox.Size = new System.Drawing.Size(78, 16);
            this.copyrightCheckbox.TabIndex = 73;
            this.copyrightCheckbox.Text = "Copyright";
            this.copyrightCheckbox.UseVisualStyleBackColor = true;
            this.copyrightCheckbox.CheckedChanged += new System.EventHandler(this.copyrightCheckbox_CheckedChanged);
            // 
            // composerCheckbox
            // 
            this.composerCheckbox.AutoSize = true;
            this.composerCheckbox.Checked = true;
            this.composerCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.composerCheckbox.FlatAppearance.BorderSize = 0;
            this.composerCheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            this.composerCheckbox.Location = new System.Drawing.Point(611, 501);
            this.composerCheckbox.Name = "composerCheckbox";
            this.composerCheckbox.Size = new System.Drawing.Size(72, 16);
            this.composerCheckbox.TabIndex = 72;
            this.composerCheckbox.Text = "Composer";
            this.composerCheckbox.UseVisualStyleBackColor = true;
            this.composerCheckbox.CheckedChanged += new System.EventHandler(this.composerCheckbox_CheckedChanged);
            // 
            // genreCheckbox
            // 
            this.genreCheckbox.AutoSize = true;
            this.genreCheckbox.Checked = true;
            this.genreCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.genreCheckbox.FlatAppearance.BorderSize = 0;
            this.genreCheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            this.genreCheckbox.Location = new System.Drawing.Point(550, 501);
            this.genreCheckbox.Name = "genreCheckbox";
            this.genreCheckbox.Size = new System.Drawing.Size(54, 16);
            this.genreCheckbox.TabIndex = 71;
            this.genreCheckbox.Text = "Genre";
            this.genreCheckbox.UseVisualStyleBackColor = true;
            this.genreCheckbox.CheckedChanged += new System.EventHandler(this.genreCheckbox_CheckedChanged);
            // 
            // releaseCheckbox
            // 
            this.releaseCheckbox.AutoSize = true;
            this.releaseCheckbox.Checked = true;
            this.releaseCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.releaseCheckbox.FlatAppearance.BorderSize = 0;
            this.releaseCheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            this.releaseCheckbox.Location = new System.Drawing.Point(453, 501);
            this.releaseCheckbox.Name = "releaseCheckbox";
            this.releaseCheckbox.Size = new System.Drawing.Size(96, 16);
            this.releaseCheckbox.TabIndex = 70;
            this.releaseCheckbox.Text = "Release Date";
            this.releaseCheckbox.UseVisualStyleBackColor = true;
            this.releaseCheckbox.CheckedChanged += new System.EventHandler(this.releaseCheckbox_CheckedChanged);
            // 
            // commentCheckbox
            // 
            this.commentCheckbox.AutoSize = true;
            this.commentCheckbox.FlatAppearance.BorderSize = 0;
            this.commentCheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            this.commentCheckbox.Location = new System.Drawing.Point(573, 527);
            this.commentCheckbox.Name = "commentCheckbox";
            this.commentCheckbox.Size = new System.Drawing.Size(66, 16);
            this.commentCheckbox.TabIndex = 78;
            this.commentCheckbox.Text = "Comment";
            this.commentCheckbox.UseVisualStyleBackColor = true;
            this.commentCheckbox.CheckedChanged += new System.EventHandler(this.commentCheckbox_CheckedChanged);
            // 
            // commentTextbox
            // 
            this.commentTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.commentTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.commentTextbox.ForeColor = System.Drawing.Color.White;
            this.commentTextbox.Location = new System.Drawing.Point(649, 525);
            this.commentTextbox.Multiline = true;
            this.commentTextbox.Name = "commentTextbox";
            this.commentTextbox.Size = new System.Drawing.Size(112, 16);
            this.commentTextbox.TabIndex = 79;
            this.commentTextbox.TextChanged += new System.EventHandler(this.commentTextbox_TextChanged);
            // 
            // imageCheckbox
            // 
            this.imageCheckbox.AutoSize = true;
            this.imageCheckbox.Checked = true;
            this.imageCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.imageCheckbox.FlatAppearance.BorderSize = 0;
            this.imageCheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            this.imageCheckbox.Location = new System.Drawing.Point(385, 527);
            this.imageCheckbox.Name = "imageCheckbox";
            this.imageCheckbox.Size = new System.Drawing.Size(78, 16);
            this.imageCheckbox.TabIndex = 80;
            this.imageCheckbox.Text = "Cover Art";
            this.imageCheckbox.UseVisualStyleBackColor = true;
            this.imageCheckbox.CheckedChanged += new System.EventHandler(this.imageCheckbox_CheckedChanged);
            // 
            // mp3Checkbox
            // 
            this.mp3Checkbox.AutoSize = true;
            this.mp3Checkbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            this.mp3Checkbox.Location = new System.Drawing.Point(246, 59);
            this.mp3Checkbox.Name = "mp3Checkbox";
            this.mp3Checkbox.Size = new System.Drawing.Size(66, 16);
            this.mp3Checkbox.TabIndex = 81;
            this.mp3Checkbox.Text = "MP3 320";
            this.mp3Checkbox.UseVisualStyleBackColor = true;
            this.mp3Checkbox.CheckedChanged += new System.EventHandler(this.mp3Checkbox_CheckedChanged);
            // 
            // flacLowCheckbox
            // 
            this.flacLowCheckbox.AutoSize = true;
            this.flacLowCheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            this.flacLowCheckbox.Location = new System.Drawing.Point(321, 59);
            this.flacLowCheckbox.Name = "flacLowCheckbox";
            this.flacLowCheckbox.Size = new System.Drawing.Size(96, 16);
            this.flacLowCheckbox.TabIndex = 82;
            this.flacLowCheckbox.Text = "FLAC 16/44.1";
            this.flacLowCheckbox.UseVisualStyleBackColor = true;
            this.flacLowCheckbox.CheckedChanged += new System.EventHandler(this.flacLowCheckbox_CheckedChanged);
            // 
            // flacMidCheckbox
            // 
            this.flacMidCheckbox.AutoSize = true;
            this.flacMidCheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            this.flacMidCheckbox.Location = new System.Drawing.Point(420, 59);
            this.flacMidCheckbox.Name = "flacMidCheckbox";
            this.flacMidCheckbox.Size = new System.Drawing.Size(84, 16);
            this.flacMidCheckbox.TabIndex = 83;
            this.flacMidCheckbox.Text = "FLAC 24/96";
            this.flacMidCheckbox.UseVisualStyleBackColor = true;
            this.flacMidCheckbox.CheckedChanged += new System.EventHandler(this.flacMidCheckbox_CheckedChanged);
            // 
            // flacHighCheckbox
            // 
            this.flacHighCheckbox.AutoSize = true;
            this.flacHighCheckbox.Checked = true;
            this.flacHighCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.flacHighCheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            this.flacHighCheckbox.Location = new System.Drawing.Point(510, 59);
            this.flacHighCheckbox.Name = "flacHighCheckbox";
            this.flacHighCheckbox.Size = new System.Drawing.Size(90, 16);
            this.flacHighCheckbox.TabIndex = 84;
            this.flacHighCheckbox.Text = "FLAC 24/192";
            this.flacHighCheckbox.UseVisualStyleBackColor = true;
            this.flacHighCheckbox.CheckedChanged += new System.EventHandler(this.flacHighCheckbox_CheckedChanged);
            // 
            // mp3WarnLabel
            // 
            this.mp3WarnLabel.AutoSize = true;
            this.mp3WarnLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            this.mp3WarnLabel.Location = new System.Drawing.Point(841, 553);
            this.mp3WarnLabel.Name = "mp3WarnLabel";
            this.mp3WarnLabel.Size = new System.Drawing.Size(107, 12);
            this.mp3WarnLabel.TabIndex = 85;
            this.mp3WarnLabel.Text = "* = 下载MP3时无效";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            this.panel1.Location = new System.Drawing.Point(18, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 1);
            this.panel1.TabIndex = 86;
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.BackColor = System.Drawing.Color.Transparent;
            this.exitLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.ForeColor = System.Drawing.Color.White;
            this.exitLabel.Location = new System.Drawing.Point(914, 10);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(20, 23);
            this.exitLabel.TabIndex = 87;
            this.exitLabel.Text = "X";
            this.exitLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exitLabel.Click += new System.EventHandler(this.exitLabel_Click);
            this.exitLabel.MouseLeave += new System.EventHandler(this.exitLabel_MouseLeave);
            this.exitLabel.MouseHover += new System.EventHandler(this.exitLabel_MouseHover);
            // 
            // minimizeLabel
            // 
            this.minimizeLabel.AutoSize = true;
            this.minimizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.minimizeLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeLabel.ForeColor = System.Drawing.Color.White;
            this.minimizeLabel.Location = new System.Drawing.Point(889, 7);
            this.minimizeLabel.Name = "minimizeLabel";
            this.minimizeLabel.Size = new System.Drawing.Size(19, 23);
            this.minimizeLabel.TabIndex = 88;
            this.minimizeLabel.Text = "_";
            this.minimizeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.minimizeLabel.Click += new System.EventHandler(this.minimizeLabel_Click);
            this.minimizeLabel.MouseLeave += new System.EventHandler(this.minimizeLabel_MouseLeave);
            this.minimizeLabel.MouseHover += new System.EventHandler(this.minimizeLabel_MouseHover);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            this.panel2.Location = new System.Drawing.Point(757, 253);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 1);
            this.panel2.TabIndex = 87;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            this.panel3.Location = new System.Drawing.Point(757, 292);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 1);
            this.panel3.TabIndex = 88;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            this.panel4.Location = new System.Drawing.Point(757, 331);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(150, 1);
            this.panel4.TabIndex = 89;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            this.panel5.Location = new System.Drawing.Point(757, 369);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(150, 1);
            this.panel5.TabIndex = 89;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            this.panel6.Location = new System.Drawing.Point(757, 408);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(150, 1);
            this.panel6.TabIndex = 89;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            this.panel7.Location = new System.Drawing.Point(757, 448);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(150, 1);
            this.panel7.TabIndex = 89;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            this.panel8.Location = new System.Drawing.Point(649, 543);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(112, 1);
            this.panel8.TabIndex = 90;
            // 
            // streamableCheckbox
            // 
            this.streamableCheckbox.AutoSize = true;
            this.streamableCheckbox.Checked = true;
            this.streamableCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.streamableCheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            this.streamableCheckbox.Location = new System.Drawing.Point(246, 41);
            this.streamableCheckbox.Name = "streamableCheckbox";
            this.streamableCheckbox.Size = new System.Drawing.Size(120, 16);
            this.streamableCheckbox.TabIndex = 91;
            this.streamableCheckbox.Text = "Streamable Check";
            this.streamableCheckbox.UseVisualStyleBackColor = true;
            this.streamableCheckbox.Visible = false;
            // 
            // secretTextbox
            // 
            this.secretTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.secretTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.secretTextbox.ForeColor = System.Drawing.Color.White;
            this.secretTextbox.Location = new System.Drawing.Point(415, 17);
            this.secretTextbox.Multiline = true;
            this.secretTextbox.Name = "secretTextbox";
            this.secretTextbox.ReadOnly = true;
            this.secretTextbox.Size = new System.Drawing.Size(179, 18);
            this.secretTextbox.TabIndex = 92;
            this.secretTextbox.Visible = false;
            this.secretTextbox.WordWrap = false;
            // 
            // displaySecretButton
            // 
            this.displaySecretButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(239)))));
            this.displaySecretButton.FlatAppearance.BorderSize = 0;
            this.displaySecretButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.displaySecretButton.ForeColor = System.Drawing.Color.White;
            this.displaySecretButton.Location = new System.Drawing.Point(306, 14);
            this.displaySecretButton.Name = "displaySecretButton";
            this.displaySecretButton.Size = new System.Drawing.Size(103, 21);
            this.displaySecretButton.TabIndex = 93;
            this.displaySecretButton.Text = "显示";
            this.displaySecretButton.UseVisualStyleBackColor = false;
            this.displaySecretButton.Visible = false;
            this.displaySecretButton.Click += new System.EventHandler(this.displaySecretButton_Click);
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Location = new System.Drawing.Point(18, 465);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(20, 18);
            this.profilePictureBox.TabIndex = 94;
            this.profilePictureBox.TabStop = false;
            // 
            // logoutLabel
            // 
            this.logoutLabel.AutoSize = true;
            this.logoutLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            this.logoutLabel.Location = new System.Drawing.Point(44, 470);
            this.logoutLabel.Name = "logoutLabel";
            this.logoutLabel.Size = new System.Drawing.Size(179, 12);
            this.logoutLabel.TabIndex = 95;
            this.logoutLabel.Text = "Logged in as %name%, Log out?";
            this.logoutLabel.Click += new System.EventHandler(this.logoutLabel_Click);
            this.logoutLabel.MouseLeave += new System.EventHandler(this.logoutLabel_MouseLeave);
            this.logoutLabel.MouseHover += new System.EventHandler(this.logoutLabel_MouseHover);
            // 
            // downloadLabelBG
            // 
            this.downloadLabelBG.DoWork += new System.ComponentModel.DoWorkEventHandler(this.downloadLabelBG_DoWork);
            // 
            // hiddenTextPanel
            // 
            this.hiddenTextPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            this.hiddenTextPanel.Location = new System.Drawing.Point(415, 36);
            this.hiddenTextPanel.Name = "hiddenTextPanel";
            this.hiddenTextPanel.Size = new System.Drawing.Size(179, 1);
            this.hiddenTextPanel.TabIndex = 87;
            this.hiddenTextPanel.Visible = false;
            // 
            // downloadFaveAlbumsBG
            // 
            this.downloadFaveAlbumsBG.DoWork += new System.ComponentModel.DoWorkEventHandler(this.downloadFaveAlbumsBG_DoWork);
            // 
            // downloadFaveArtistsBG
            // 
            this.downloadFaveArtistsBG.DoWork += new System.ComponentModel.DoWorkEventHandler(this.downloadFaveArtistsBG_DoWork);
            // 
            // artSizeSelect
            // 
            this.artSizeSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.artSizeSelect.FormattingEnabled = true;
            this.artSizeSelect.Items.AddRange(new object[] {
            "max",
            "600",
            "300",
            "150",
            "100",
            "50"});
            this.artSizeSelect.Location = new System.Drawing.Point(116, 550);
            this.artSizeSelect.Name = "artSizeSelect";
            this.artSizeSelect.Size = new System.Drawing.Size(87, 20);
            this.artSizeSelect.TabIndex = 96;
            this.artSizeSelect.SelectedIndexChanged += new System.EventHandler(this.artSizeSelect_SelectedIndexChanged);
            // 
            // artSizeLabel
            // 
            this.artSizeLabel.AutoSize = true;
            this.artSizeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            this.artSizeLabel.Location = new System.Drawing.Point(15, 553);
            this.artSizeLabel.Name = "artSizeLabel";
            this.artSizeLabel.Size = new System.Drawing.Size(317, 12);
            this.artSizeLabel.TabIndex = 97;
            this.artSizeLabel.Text = "Embedded Art Size:                                px";
            // 
            // typeCheckbox
            // 
            this.typeCheckbox.AutoSize = true;
            this.typeCheckbox.Checked = true;
            this.typeCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.typeCheckbox.FlatAppearance.BorderSize = 0;
            this.typeCheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            this.typeCheckbox.Location = new System.Drawing.Point(355, 501);
            this.typeCheckbox.Name = "typeCheckbox";
            this.typeCheckbox.Size = new System.Drawing.Size(96, 16);
            this.typeCheckbox.TabIndex = 98;
            this.typeCheckbox.Text = "Release Type";
            this.typeCheckbox.UseVisualStyleBackColor = true;
            this.typeCheckbox.CheckedChanged += new System.EventHandler(this.typeCheckbox_CheckedChanged);
            // 
            // aboutLabel
            // 
            this.aboutLabel.AutoSize = true;
            this.aboutLabel.BackColor = System.Drawing.Color.Transparent;
            this.aboutLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutLabel.ForeColor = System.Drawing.Color.White;
            this.aboutLabel.Location = new System.Drawing.Point(869, 10);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(15, 23);
            this.aboutLabel.TabIndex = 99;
            this.aboutLabel.Text = "i";
            this.aboutLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.aboutLabel.Click += new System.EventHandler(this.aboutLabel_Click);
            this.aboutLabel.MouseLeave += new System.EventHandler(this.aboutLabel_MouseLeave);
            this.aboutLabel.MouseHover += new System.EventHandler(this.aboutLabel_MouseHover);
            // 
            // enableBtnsButton
            // 
            this.enableBtnsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(239)))));
            this.enableBtnsButton.FlatAppearance.BorderSize = 0;
            this.enableBtnsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enableBtnsButton.ForeColor = System.Drawing.Color.White;
            this.enableBtnsButton.Location = new System.Drawing.Point(600, 29);
            this.enableBtnsButton.Name = "enableBtnsButton";
            this.enableBtnsButton.Size = new System.Drawing.Size(120, 21);
            this.enableBtnsButton.TabIndex = 100;
            this.enableBtnsButton.Text = "Re-Enable Buttons";
            this.enableBtnsButton.UseVisualStyleBackColor = false;
            this.enableBtnsButton.Visible = false;
            this.enableBtnsButton.Click += new System.EventHandler(this.enableBtnsButton_Click);
            // 
            // hideDebugButton
            // 
            this.hideDebugButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(239)))));
            this.hideDebugButton.FlatAppearance.BorderSize = 0;
            this.hideDebugButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hideDebugButton.ForeColor = System.Drawing.Color.White;
            this.hideDebugButton.Location = new System.Drawing.Point(246, 14);
            this.hideDebugButton.Name = "hideDebugButton";
            this.hideDebugButton.Size = new System.Drawing.Size(54, 21);
            this.hideDebugButton.TabIndex = 101;
            this.hideDebugButton.Text = "隐藏";
            this.hideDebugButton.UseVisualStyleBackColor = false;
            this.hideDebugButton.Visible = false;
            this.hideDebugButton.Click += new System.EventHandler(this.hideDebugButton_Click);
            // 
            // maxLengthLabel
            // 
            this.maxLengthLabel.AutoSize = true;
            this.maxLengthLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            this.maxLengthLabel.Location = new System.Drawing.Point(459, 555);
            this.maxLengthLabel.Name = "maxLengthLabel";
            this.maxLengthLabel.Size = new System.Drawing.Size(101, 12);
            this.maxLengthLabel.TabIndex = 102;
            this.maxLengthLabel.Text = "最大文件名长度**";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            this.panel9.Location = new System.Drawing.Point(570, 566);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(68, 1);
            this.panel9.TabIndex = 92;
            // 
            // maxLengthTextbox
            // 
            this.maxLengthTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.maxLengthTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maxLengthTextbox.ForeColor = System.Drawing.Color.White;
            this.maxLengthTextbox.Location = new System.Drawing.Point(570, 553);
            this.maxLengthTextbox.Multiline = true;
            this.maxLengthTextbox.Name = "maxLengthTextbox";
            this.maxLengthTextbox.Size = new System.Drawing.Size(68, 16);
            this.maxLengthTextbox.TabIndex = 91;
            this.maxLengthTextbox.TextChanged += new System.EventHandler(this.maxLengthTextbox_TextChanged);
            // 
            // maxLengthWarnLabel
            // 
            this.maxLengthWarnLabel.AutoSize = true;
            this.maxLengthWarnLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            this.maxLengthWarnLabel.Location = new System.Drawing.Point(845, 567);
            this.maxLengthWarnLabel.Name = "maxLengthWarnLabel";
            this.maxLengthWarnLabel.Size = new System.Drawing.Size(101, 12);
            this.maxLengthWarnLabel.TabIndex = 103;
            this.maxLengthWarnLabel.Text = "** = 最大值为110";
            // 
            // customFormatPanel
            // 
            this.customFormatPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            this.customFormatPanel.Location = new System.Drawing.Point(575, 58);
            this.customFormatPanel.Name = "customFormatPanel";
            this.customFormatPanel.Size = new System.Drawing.Size(19, 1);
            this.customFormatPanel.TabIndex = 104;
            this.customFormatPanel.Visible = false;
            // 
            // customFormatIDTextbox
            // 
            this.customFormatIDTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.customFormatIDTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customFormatIDTextbox.ForeColor = System.Drawing.Color.White;
            this.customFormatIDTextbox.Location = new System.Drawing.Point(575, 42);
            this.customFormatIDTextbox.Multiline = true;
            this.customFormatIDTextbox.Name = "customFormatIDTextbox";
            this.customFormatIDTextbox.Size = new System.Drawing.Size(19, 18);
            this.customFormatIDTextbox.TabIndex = 105;
            this.customFormatIDTextbox.Visible = false;
            this.customFormatIDTextbox.WordWrap = false;
            this.customFormatIDTextbox.TextChanged += new System.EventHandler(this.customFormatIDTextbox_TextChanged);
            // 
            // formatIDLabel
            // 
            this.formatIDLabel.AutoSize = true;
            this.formatIDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            this.formatIDLabel.Location = new System.Drawing.Point(516, 42);
            this.formatIDLabel.Name = "formatIDLabel";
            this.formatIDLabel.Size = new System.Drawing.Size(59, 12);
            this.formatIDLabel.TabIndex = 106;
            this.formatIDLabel.Text = "Format ID";
            this.formatIDLabel.Visible = false;
            // 
            // filenameTempSelect
            // 
            this.filenameTempSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filenameTempSelect.FormattingEnabled = true;
            this.filenameTempSelect.Items.AddRange(new object[] {
            "00 Trackname",
            "00 - Trackname"});
            this.filenameTempSelect.Location = new System.Drawing.Point(328, 550);
            this.filenameTempSelect.Name = "filenameTempSelect";
            this.filenameTempSelect.Size = new System.Drawing.Size(108, 20);
            this.filenameTempSelect.TabIndex = 107;
            this.filenameTempSelect.SelectedIndexChanged += new System.EventHandler(this.filenameTempSelect_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(92)))), ((int)(((byte)(102)))));
            this.label7.Location = new System.Drawing.Point(228, 553);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 12);
            this.label7.TabIndex = 108;
            this.label7.Text = "Filename Template:";
            // 
            // downloadPlaylistBG
            // 
            this.downloadPlaylistBG.DoWork += new System.ComponentModel.DoWorkEventHandler(this.downloadPlaylistBG_DoWork);
            // 
            // QobuzDownloaderX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(960, 587);
            this.Controls.Add(this.filenameTempSelect);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.formatIDLabel);
            this.Controls.Add(this.customFormatPanel);
            this.Controls.Add(this.customFormatIDTextbox);
            this.Controls.Add(this.maxLengthWarnLabel);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.maxLengthTextbox);
            this.Controls.Add(this.maxLengthLabel);
            this.Controls.Add(this.hideDebugButton);
            this.Controls.Add(this.enableBtnsButton);
            this.Controls.Add(this.aboutLabel);
            this.Controls.Add(this.typeCheckbox);
            this.Controls.Add(this.artSizeSelect);
            this.Controls.Add(this.artSizeLabel);
            this.Controls.Add(this.hiddenTextPanel);
            this.Controls.Add(this.logoutLabel);
            this.Controls.Add(this.profilePictureBox);
            this.Controls.Add(this.displaySecretButton);
            this.Controls.Add(this.secretTextbox);
            this.Controls.Add(this.streamableCheckbox);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.minimizeLabel);
            this.Controls.Add(this.exitLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mp3WarnLabel);
            this.Controls.Add(this.flacHighCheckbox);
            this.Controls.Add(this.flacMidCheckbox);
            this.Controls.Add(this.flacLowCheckbox);
            this.Controls.Add(this.mp3Checkbox);
            this.Controls.Add(this.imageCheckbox);
            this.Controls.Add(this.commentTextbox);
            this.Controls.Add(this.commentCheckbox);
            this.Controls.Add(this.explicitCheckbox);
            this.Controls.Add(this.upcCheckbox);
            this.Controls.Add(this.isrcCheckbox);
            this.Controls.Add(this.copyrightCheckbox);
            this.Controls.Add(this.composerCheckbox);
            this.Controls.Add(this.genreCheckbox);
            this.Controls.Add(this.releaseCheckbox);
            this.Controls.Add(this.albumCheckbox);
            this.Controls.Add(this.discTotalCheckbox);
            this.Controls.Add(this.discNumberCheckbox);
            this.Controls.Add(this.trackTotalCheckbox);
            this.Controls.Add(this.trackNumberCheckbox);
            this.Controls.Add(this.trackTitleCheckbox);
            this.Controls.Add(this.artistCheckbox);
            this.Controls.Add(this.albumArtistCheckbox);
            this.Controls.Add(this.tagsLabel);
            this.Controls.Add(this.openSearch);
            this.Controls.Add(this.qualityTextbox);
            this.Controls.Add(this.qualityLabel);
            this.Controls.Add(this.totalTracksTextbox);
            this.Controls.Add(this.totalTracksLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.upcTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.releaseDateTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.albumTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.albumArtistTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.albumArtPicBox);
            this.Controls.Add(this.verNumLabel);
            this.Controls.Add(this.logoBox);
            this.Controls.Add(this.imageURLTextbox);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.albumUrl);
            this.Controls.Add(this.openFolderButton);
            this.Controls.Add(this.output);
            this.Controls.Add(this.selectFolder);
            this.Controls.Add(this.testURLBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "QobuzDownloaderX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QobuzDownloaderX";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.QobuzDownloaderX_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.QobuzDownloaderX_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.albumArtPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox testURLBox;
        private System.Windows.Forms.Button selectFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TextBox output;
        private System.ComponentModel.BackgroundWorker downloadBG;
        private System.Windows.Forms.Button openFolderButton;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.TextBox albumUrl;
        private System.Windows.Forms.TextBox imageURLTextbox;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Label verNumLabel;
        private System.Windows.Forms.PictureBox albumArtPicBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox albumArtistTextBox;
        private System.Windows.Forms.TextBox albumTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox releaseDateTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox upcTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox totalTracksTextbox;
        private System.Windows.Forms.Label totalTracksLabel;
        private System.ComponentModel.BackgroundWorker getLinkTypeBG;
        private System.ComponentModel.BackgroundWorker downloadAlbumBG;
        private System.ComponentModel.BackgroundWorker downloadTrackBG;
        private System.ComponentModel.BackgroundWorker downloadDiscogBG;
        private System.Windows.Forms.TextBox qualityTextbox;
        private System.Windows.Forms.Label qualityLabel;
        private System.Windows.Forms.Button openSearch;
        private System.Windows.Forms.Label tagsLabel;
        private System.Windows.Forms.CheckBox albumArtistCheckbox;
        private System.Windows.Forms.CheckBox artistCheckbox;
        private System.Windows.Forms.CheckBox trackTitleCheckbox;
        private System.Windows.Forms.CheckBox trackNumberCheckbox;
        private System.Windows.Forms.CheckBox trackTotalCheckbox;
        private System.Windows.Forms.CheckBox discNumberCheckbox;
        private System.Windows.Forms.CheckBox discTotalCheckbox;
        private System.Windows.Forms.CheckBox albumCheckbox;
        private System.Windows.Forms.CheckBox explicitCheckbox;
        private System.Windows.Forms.CheckBox upcCheckbox;
        private System.Windows.Forms.CheckBox isrcCheckbox;
        private System.Windows.Forms.CheckBox copyrightCheckbox;
        private System.Windows.Forms.CheckBox composerCheckbox;
        private System.Windows.Forms.CheckBox genreCheckbox;
        private System.Windows.Forms.CheckBox releaseCheckbox;
        private System.Windows.Forms.CheckBox commentCheckbox;
        private System.Windows.Forms.TextBox commentTextbox;
        private System.Windows.Forms.CheckBox imageCheckbox;
        private System.Windows.Forms.CheckBox mp3Checkbox;
        private System.Windows.Forms.CheckBox flacLowCheckbox;
        private System.Windows.Forms.CheckBox flacMidCheckbox;
        private System.Windows.Forms.CheckBox flacHighCheckbox;
        private System.Windows.Forms.Label mp3WarnLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.Label minimizeLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.CheckBox streamableCheckbox;
        private System.Windows.Forms.TextBox secretTextbox;
        private System.Windows.Forms.Button displaySecretButton;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.Label logoutLabel;
        private System.ComponentModel.BackgroundWorker downloadLabelBG;
        private System.Windows.Forms.Panel hiddenTextPanel;
        private System.ComponentModel.BackgroundWorker downloadFaveAlbumsBG;
        private System.ComponentModel.BackgroundWorker downloadFaveArtistsBG;
        private System.Windows.Forms.ComboBox artSizeSelect;
        private System.Windows.Forms.Label artSizeLabel;
        private System.Windows.Forms.CheckBox typeCheckbox;
        private System.Windows.Forms.Label aboutLabel;
        private System.Windows.Forms.Button enableBtnsButton;
        private System.Windows.Forms.Button hideDebugButton;
        private System.Windows.Forms.Label maxLengthLabel;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox maxLengthTextbox;
        private System.Windows.Forms.Label maxLengthWarnLabel;
        private System.Windows.Forms.Panel customFormatPanel;
        private System.Windows.Forms.TextBox customFormatIDTextbox;
        private System.Windows.Forms.Label formatIDLabel;
        private System.Windows.Forms.ComboBox filenameTempSelect;
        private System.Windows.Forms.Label label7;
        private System.ComponentModel.BackgroundWorker downloadPlaylistBG;
    }
}

