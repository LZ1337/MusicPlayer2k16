namespace Music_Player_2k16_Independed
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitleBar = new System.Windows.Forms.Label();
            this.imgTitleIcon = new System.Windows.Forms.PictureBox();
            this.panelResize = new System.Windows.Forms.Panel();
            this.panelPlaylists = new System.Windows.Forms.Panel();
            this.textBoxPlaylistname = new System.Windows.Forms.TextBox();
            this.listBoxPlaylists = new System.Windows.Forms.ListBox();
            this.contextMenuStripPlaylists = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.playlistAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.playlistDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAddPlaylist = new System.Windows.Forms.Button();
            this.panelPlaylistsLbl = new System.Windows.Forms.Panel();
            this.buttonBrowseForPlaylist = new System.Windows.Forms.Button();
            this.labelPlaylists = new System.Windows.Forms.Label();
            this.panelTracks = new System.Windows.Forms.Panel();
            this.listBoxTracks = new System.Windows.Forms.ListBox();
            this.contextMenuStripTracks = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemAddTrack = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRemoveTrack = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemClear = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonZip = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.textBoxSearchTrack = new System.Windows.Forms.TextBox();
            this.buttonDeleteTrack = new System.Windows.Forms.Button();
            this.buttonAddTrack = new System.Windows.Forms.Button();
            this.labelTracks = new System.Windows.Forms.Label();
            this.panelPlayer = new System.Windows.Forms.Panel();
            this.labelPlayerStats = new System.Windows.Forms.Label();
            this.pictureBoxRepeat = new System.Windows.Forms.PictureBox();
            this.pictureBoxShuffle = new System.Windows.Forms.PictureBox();
            this.trackBarCurPos = new System.Windows.Forms.TrackBar();
            this.trackBarVol = new System.Windows.Forms.TrackBar();
            this.pictureBoxNextTrack = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlay = new System.Windows.Forms.PictureBox();
            this.pictureBoxPreviousTrack = new System.Windows.Forms.PictureBox();
            this.lblTrackTime = new System.Windows.Forms.Label();
            this.lblTrackAlbum = new System.Windows.Forms.Label();
            this.lblTrackTitle = new System.Windows.Forms.Label();
            this.pictureBoxCover = new System.Windows.Forms.PictureBox();
            this.openFileDialogTracks = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogOpenPlaylist = new System.Windows.Forms.OpenFileDialog();
            this.timerUpdateContent = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialogPlaylist = new System.Windows.Forms.SaveFileDialog();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitleIcon)).BeginInit();
            this.panelPlaylists.SuspendLayout();
            this.contextMenuStripPlaylists.SuspendLayout();
            this.panelPlaylistsLbl.SuspendLayout();
            this.panelTracks.SuspendLayout();
            this.contextMenuStripTracks.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRepeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShuffle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCurPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNextTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreviousTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTitleBar.BackColor = System.Drawing.Color.White;
            this.panelTitleBar.Controls.Add(this.btnMin);
            this.panelTitleBar.Controls.Add(this.btnExit);
            this.panelTitleBar.Controls.Add(this.panel2);
            this.panelTitleBar.Controls.Add(this.lblTitleBar);
            this.panelTitleBar.Controls.Add(this.imgTitleIcon);
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(853, 41);
            this.panelTitleBar.TabIndex = 0;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.Location = new System.Drawing.Point(765, 3);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(36, 35);
            this.btnMin.TabIndex = 2;
            this.btnMin.Text = "_";
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(807, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(36, 35);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(914, 10);
            this.panel2.TabIndex = 1;
            // 
            // lblTitleBar
            // 
            this.lblTitleBar.AutoSize = true;
            this.lblTitleBar.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(64)))));
            this.lblTitleBar.Location = new System.Drawing.Point(47, 6);
            this.lblTitleBar.Name = "lblTitleBar";
            this.lblTitleBar.Size = new System.Drawing.Size(208, 32);
            this.lblTitleBar.TabIndex = 1;
            this.lblTitleBar.Text = "Music Player 2k16";
            this.lblTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitleBar_MouseDown);
            // 
            // imgTitleIcon
            // 
            this.imgTitleIcon.Image = global::Music_Player_2k16_Independed.Properties.Resources.playIconv2;
            this.imgTitleIcon.Location = new System.Drawing.Point(0, 0);
            this.imgTitleIcon.Name = "imgTitleIcon";
            this.imgTitleIcon.Size = new System.Drawing.Size(41, 41);
            this.imgTitleIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgTitleIcon.TabIndex = 0;
            this.imgTitleIcon.TabStop = false;
            // 
            // panelResize
            // 
            this.panelResize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelResize.BackColor = System.Drawing.Color.Transparent;
            this.panelResize.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.panelResize.Location = new System.Drawing.Point(843, 437);
            this.panelResize.Name = "panelResize";
            this.panelResize.Size = new System.Drawing.Size(10, 10);
            this.panelResize.TabIndex = 1;
            this.panelResize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelResize_MouseDown);
            this.panelResize.MouseLeave += new System.EventHandler(this.panelResize_MouseLeave);
            this.panelResize.MouseHover += new System.EventHandler(this.panelResize_MouseHover);
            this.panelResize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelResize_MouseMove);
            // 
            // panelPlaylists
            // 
            this.panelPlaylists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(64)))));
            this.panelPlaylists.Controls.Add(this.textBoxPlaylistname);
            this.panelPlaylists.Controls.Add(this.listBoxPlaylists);
            this.panelPlaylists.Controls.Add(this.buttonAddPlaylist);
            this.panelPlaylists.Controls.Add(this.panelPlaylistsLbl);
            this.panelPlaylists.Location = new System.Drawing.Point(9, 55);
            this.panelPlaylists.Margin = new System.Windows.Forms.Padding(0);
            this.panelPlaylists.Name = "panelPlaylists";
            this.panelPlaylists.Size = new System.Drawing.Size(180, 301);
            this.panelPlaylists.TabIndex = 2;
            // 
            // textBoxPlaylistname
            // 
            this.textBoxPlaylistname.Location = new System.Drawing.Point(11, 276);
            this.textBoxPlaylistname.Name = "textBoxPlaylistname";
            this.textBoxPlaylistname.Size = new System.Drawing.Size(136, 20);
            this.textBoxPlaylistname.TabIndex = 5;
            // 
            // listBoxPlaylists
            // 
            this.listBoxPlaylists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(64)))));
            this.listBoxPlaylists.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxPlaylists.ContextMenuStrip = this.contextMenuStripPlaylists;
            this.listBoxPlaylists.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPlaylists.ForeColor = System.Drawing.Color.White;
            this.listBoxPlaylists.FormattingEnabled = true;
            this.listBoxPlaylists.HorizontalScrollbar = true;
            this.listBoxPlaylists.ItemHeight = 17;
            this.listBoxPlaylists.Location = new System.Drawing.Point(11, 33);
            this.listBoxPlaylists.Name = "listBoxPlaylists";
            this.listBoxPlaylists.Size = new System.Drawing.Size(155, 221);
            this.listBoxPlaylists.TabIndex = 4;
            this.listBoxPlaylists.SelectedValueChanged += new System.EventHandler(this.listBoxPlaylists_SelectedValueChanged);
            // 
            // contextMenuStripPlaylists
            // 
            this.contextMenuStripPlaylists.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playlistAdd,
            this.playlistDelete,
            this.clearToolStripMenuItem});
            this.contextMenuStripPlaylists.Name = "contextMenuStripPlaylists";
            this.contextMenuStripPlaylists.Size = new System.Drawing.Size(148, 70);
            // 
            // playlistAdd
            // 
            this.playlistAdd.Name = "playlistAdd";
            this.playlistAdd.Size = new System.Drawing.Size(147, 22);
            this.playlistAdd.Text = "Add Playlist";
            this.playlistAdd.Click += new System.EventHandler(this.playlistAdd_Click);
            // 
            // playlistDelete
            // 
            this.playlistDelete.Name = "playlistDelete";
            this.playlistDelete.Size = new System.Drawing.Size(147, 22);
            this.playlistDelete.Text = "Delete Playlist";
            this.playlistDelete.Click += new System.EventHandler(this.playlistDelete_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // buttonAddPlaylist
            // 
            this.buttonAddPlaylist.FlatAppearance.BorderSize = 0;
            this.buttonAddPlaylist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(64)))));
            this.buttonAddPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddPlaylist.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddPlaylist.ForeColor = System.Drawing.Color.White;
            this.buttonAddPlaylist.Location = new System.Drawing.Point(145, 266);
            this.buttonAddPlaylist.Name = "buttonAddPlaylist";
            this.buttonAddPlaylist.Size = new System.Drawing.Size(35, 35);
            this.buttonAddPlaylist.TabIndex = 1;
            this.buttonAddPlaylist.Text = "+";
            this.buttonAddPlaylist.UseVisualStyleBackColor = true;
            this.buttonAddPlaylist.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelPlaylistsLbl
            // 
            this.panelPlaylistsLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(64)))));
            this.panelPlaylistsLbl.Controls.Add(this.buttonBrowseForPlaylist);
            this.panelPlaylistsLbl.Controls.Add(this.labelPlaylists);
            this.panelPlaylistsLbl.ForeColor = System.Drawing.Color.White;
            this.panelPlaylistsLbl.Location = new System.Drawing.Point(0, 0);
            this.panelPlaylistsLbl.Margin = new System.Windows.Forms.Padding(0);
            this.panelPlaylistsLbl.Name = "panelPlaylistsLbl";
            this.panelPlaylistsLbl.Size = new System.Drawing.Size(165, 35);
            this.panelPlaylistsLbl.TabIndex = 3;
            // 
            // buttonBrowseForPlaylist
            // 
            this.buttonBrowseForPlaylist.FlatAppearance.BorderSize = 0;
            this.buttonBrowseForPlaylist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(64)))));
            this.buttonBrowseForPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrowseForPlaylist.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrowseForPlaylist.Location = new System.Drawing.Point(0, 0);
            this.buttonBrowseForPlaylist.Name = "buttonBrowseForPlaylist";
            this.buttonBrowseForPlaylist.Size = new System.Drawing.Size(35, 35);
            this.buttonBrowseForPlaylist.TabIndex = 2;
            this.buttonBrowseForPlaylist.Text = "...";
            this.buttonBrowseForPlaylist.UseVisualStyleBackColor = true;
            this.buttonBrowseForPlaylist.Click += new System.EventHandler(this.buttonBrowseForPlaylist_Click);
            // 
            // labelPlaylists
            // 
            this.labelPlaylists.AutoSize = true;
            this.labelPlaylists.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlaylists.Location = new System.Drawing.Point(44, 5);
            this.labelPlaylists.Name = "labelPlaylists";
            this.labelPlaylists.Size = new System.Drawing.Size(81, 25);
            this.labelPlaylists.TabIndex = 0;
            this.labelPlaylists.Text = "Playlists";
            // 
            // panelTracks
            // 
            this.panelTracks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(64)))));
            this.panelTracks.Controls.Add(this.listBoxTracks);
            this.panelTracks.Controls.Add(this.panel3);
            this.panelTracks.Location = new System.Drawing.Point(192, 55);
            this.panelTracks.Name = "panelTracks";
            this.panelTracks.Size = new System.Drawing.Size(649, 301);
            this.panelTracks.TabIndex = 3;
            // 
            // listBoxTracks
            // 
            this.listBoxTracks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(64)))));
            this.listBoxTracks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxTracks.ContextMenuStrip = this.contextMenuStripTracks;
            this.listBoxTracks.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTracks.ForeColor = System.Drawing.Color.White;
            this.listBoxTracks.FormattingEnabled = true;
            this.listBoxTracks.ItemHeight = 17;
            this.listBoxTracks.Location = new System.Drawing.Point(6, 34);
            this.listBoxTracks.Name = "listBoxTracks";
            this.listBoxTracks.Size = new System.Drawing.Size(641, 255);
            this.listBoxTracks.TabIndex = 1;
            this.listBoxTracks.Click += new System.EventHandler(this.listBoxTracks_Click);
            // 
            // contextMenuStripTracks
            // 
            this.contextMenuStripTracks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAddTrack,
            this.toolStripMenuItemRemoveTrack,
            this.toolStripMenuItemClear});
            this.contextMenuStripTracks.Name = "contextMenuStripTracks";
            this.contextMenuStripTracks.Size = new System.Drawing.Size(147, 70);
            // 
            // toolStripMenuItemAddTrack
            // 
            this.toolStripMenuItemAddTrack.Name = "toolStripMenuItemAddTrack";
            this.toolStripMenuItemAddTrack.Size = new System.Drawing.Size(146, 22);
            this.toolStripMenuItemAddTrack.Text = "Add track";
            this.toolStripMenuItemAddTrack.Click += new System.EventHandler(this.toolStripMenuItemAddTrack_Click);
            // 
            // toolStripMenuItemRemoveTrack
            // 
            this.toolStripMenuItemRemoveTrack.Name = "toolStripMenuItemRemoveTrack";
            this.toolStripMenuItemRemoveTrack.Size = new System.Drawing.Size(146, 22);
            this.toolStripMenuItemRemoveTrack.Text = "Remove track";
            this.toolStripMenuItemRemoveTrack.Click += new System.EventHandler(this.toolStripMenuItemRemoveTrack_Click);
            // 
            // toolStripMenuItemClear
            // 
            this.toolStripMenuItemClear.Name = "toolStripMenuItemClear";
            this.toolStripMenuItemClear.Size = new System.Drawing.Size(146, 22);
            this.toolStripMenuItemClear.Text = "Clear";
            this.toolStripMenuItemClear.Click += new System.EventHandler(this.toolStripMenuItemClear_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.buttonSave);
            this.panel3.Controls.Add(this.buttonZip);
            this.panel3.Controls.Add(this.buttonSettings);
            this.panel3.Controls.Add(this.textBoxSearchTrack);
            this.panel3.Controls.Add(this.buttonDeleteTrack);
            this.panel3.Controls.Add(this.buttonAddTrack);
            this.panel3.Controls.Add(this.labelTracks);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(662, 35);
            this.panel3.TabIndex = 0;
            // 
            // buttonSave
            // 
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(64)))));
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(372, 0);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(64, 35);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonZip
            // 
            this.buttonZip.FlatAppearance.BorderSize = 0;
            this.buttonZip.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(64)))));
            this.buttonZip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZip.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.buttonZip.ForeColor = System.Drawing.Color.White;
            this.buttonZip.Location = new System.Drawing.Point(436, 1);
            this.buttonZip.Margin = new System.Windows.Forms.Padding(0);
            this.buttonZip.Name = "buttonZip";
            this.buttonZip.Size = new System.Drawing.Size(44, 35);
            this.buttonZip.TabIndex = 9;
            this.buttonZip.Text = "ZIP Playlist";
            this.buttonZip.UseVisualStyleBackColor = true;
            // 
            // buttonSettings
            // 
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(64)))));
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.buttonSettings.ForeColor = System.Drawing.Color.White;
            this.buttonSettings.Location = new System.Drawing.Point(296, 0);
            this.buttonSettings.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(80, 35);
            this.buttonSettings.TabIndex = 8;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // textBoxSearchTrack
            // 
            this.textBoxSearchTrack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(86)))), ((int)(((byte)(54)))));
            this.textBoxSearchTrack.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearchTrack.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchTrack.ForeColor = System.Drawing.Color.White;
            this.textBoxSearchTrack.Location = new System.Drawing.Point(483, 9);
            this.textBoxSearchTrack.Name = "textBoxSearchTrack";
            this.textBoxSearchTrack.Size = new System.Drawing.Size(163, 22);
            this.textBoxSearchTrack.TabIndex = 7;
            this.textBoxSearchTrack.Text = "Search a  bit...";
            this.textBoxSearchTrack.TextChanged += new System.EventHandler(this.textBoxSearchTrack_TextChanged);
            // 
            // buttonDeleteTrack
            // 
            this.buttonDeleteTrack.FlatAppearance.BorderSize = 0;
            this.buttonDeleteTrack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(64)))));
            this.buttonDeleteTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteTrack.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.buttonDeleteTrack.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteTrack.Location = new System.Drawing.Point(205, 0);
            this.buttonDeleteTrack.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDeleteTrack.Name = "buttonDeleteTrack";
            this.buttonDeleteTrack.Size = new System.Drawing.Size(92, 35);
            this.buttonDeleteTrack.TabIndex = 6;
            this.buttonDeleteTrack.Text = "Remove";
            this.buttonDeleteTrack.UseVisualStyleBackColor = true;
            this.buttonDeleteTrack.Click += new System.EventHandler(this.buttonDeleteTrack_Click);
            // 
            // buttonAddTrack
            // 
            this.buttonAddTrack.FlatAppearance.BorderSize = 0;
            this.buttonAddTrack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(64)))));
            this.buttonAddTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddTrack.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.buttonAddTrack.ForeColor = System.Drawing.Color.White;
            this.buttonAddTrack.Location = new System.Drawing.Point(150, 0);
            this.buttonAddTrack.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAddTrack.Name = "buttonAddTrack";
            this.buttonAddTrack.Size = new System.Drawing.Size(55, 35);
            this.buttonAddTrack.TabIndex = 2;
            this.buttonAddTrack.Text = " Add";
            this.buttonAddTrack.UseVisualStyleBackColor = true;
            this.buttonAddTrack.Click += new System.EventHandler(this.buttonAddTrack_Click);
            // 
            // labelTracks
            // 
            this.labelTracks.AutoSize = true;
            this.labelTracks.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelTracks.ForeColor = System.Drawing.Color.White;
            this.labelTracks.Location = new System.Drawing.Point(4, 6);
            this.labelTracks.Name = "labelTracks";
            this.labelTracks.Size = new System.Drawing.Size(143, 25);
            this.labelTracks.TabIndex = 0;
            this.labelTracks.Text = "Current Playlist";
            // 
            // panelPlayer
            // 
            this.panelPlayer.BackColor = System.Drawing.Color.White;
            this.panelPlayer.Controls.Add(this.labelPlayerStats);
            this.panelPlayer.Controls.Add(this.pictureBoxRepeat);
            this.panelPlayer.Controls.Add(this.pictureBoxShuffle);
            this.panelPlayer.Controls.Add(this.trackBarCurPos);
            this.panelPlayer.Controls.Add(this.trackBarVol);
            this.panelPlayer.Controls.Add(this.pictureBoxNextTrack);
            this.panelPlayer.Controls.Add(this.pictureBoxPlay);
            this.panelPlayer.Controls.Add(this.pictureBoxPreviousTrack);
            this.panelPlayer.Controls.Add(this.lblTrackTime);
            this.panelPlayer.Controls.Add(this.lblTrackAlbum);
            this.panelPlayer.Controls.Add(this.lblTrackTitle);
            this.panelPlayer.Controls.Add(this.pictureBoxCover);
            this.panelPlayer.Location = new System.Drawing.Point(9, 362);
            this.panelPlayer.Name = "panelPlayer";
            this.panelPlayer.Size = new System.Drawing.Size(833, 75);
            this.panelPlayer.TabIndex = 4;
            // 
            // labelPlayerStats
            // 
            this.labelPlayerStats.AutoSize = true;
            this.labelPlayerStats.Location = new System.Drawing.Point(619, 52);
            this.labelPlayerStats.Name = "labelPlayerStats";
            this.labelPlayerStats.Size = new System.Drawing.Size(35, 13);
            this.labelPlayerStats.TabIndex = 11;
            this.labelPlayerStats.Text = "label1";
            // 
            // pictureBoxRepeat
            // 
            this.pictureBoxRepeat.Image = global::Music_Player_2k16_Independed.Properties.Resources.repeatv2;
            this.pictureBoxRepeat.Location = new System.Drawing.Point(724, 13);
            this.pictureBoxRepeat.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxRepeat.Name = "pictureBoxRepeat";
            this.pictureBoxRepeat.Size = new System.Drawing.Size(35, 35);
            this.pictureBoxRepeat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRepeat.TabIndex = 10;
            this.pictureBoxRepeat.TabStop = false;
            this.pictureBoxRepeat.Click += new System.EventHandler(this.pictureBoxRepeat_Click);
            // 
            // pictureBoxShuffle
            // 
            this.pictureBoxShuffle.Image = global::Music_Player_2k16_Independed.Properties.Resources.shuffle2;
            this.pictureBoxShuffle.Location = new System.Drawing.Point(759, 13);
            this.pictureBoxShuffle.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxShuffle.Name = "pictureBoxShuffle";
            this.pictureBoxShuffle.Size = new System.Drawing.Size(35, 35);
            this.pictureBoxShuffle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxShuffle.TabIndex = 9;
            this.pictureBoxShuffle.TabStop = false;
            this.pictureBoxShuffle.Click += new System.EventHandler(this.pictureBoxShuffle_Click);
            // 
            // trackBarCurPos
            // 
            this.trackBarCurPos.Location = new System.Drawing.Point(183, 13);
            this.trackBarCurPos.Maximum = 100;
            this.trackBarCurPos.Name = "trackBarCurPos";
            this.trackBarCurPos.Size = new System.Drawing.Size(418, 45);
            this.trackBarCurPos.TabIndex = 8;
            this.trackBarCurPos.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBarCurPos_MouseUp);
            // 
            // trackBarVol
            // 
            this.trackBarVol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarVol.Location = new System.Drawing.Point(796, 0);
            this.trackBarVol.Name = "trackBarVol";
            this.trackBarVol.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarVol.Size = new System.Drawing.Size(45, 75);
            this.trackBarVol.TabIndex = 7;
            this.trackBarVol.Scroll += new System.EventHandler(this.trackBarVol_Scroll);
            this.trackBarVol.ValueChanged += new System.EventHandler(this.trackBarVol_ValueChanged);
            // 
            // pictureBoxNextTrack
            // 
            this.pictureBoxNextTrack.Image = global::Music_Player_2k16_Independed.Properties.Resources.forward2;
            this.pictureBoxNextTrack.Location = new System.Drawing.Point(689, 13);
            this.pictureBoxNextTrack.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxNextTrack.Name = "pictureBoxNextTrack";
            this.pictureBoxNextTrack.Size = new System.Drawing.Size(35, 35);
            this.pictureBoxNextTrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNextTrack.TabIndex = 6;
            this.pictureBoxNextTrack.TabStop = false;
            this.pictureBoxNextTrack.Click += new System.EventHandler(this.pictureBoxNextTrack_Click);
            // 
            // pictureBoxPlay
            // 
            this.pictureBoxPlay.Image = global::Music_Player_2k16_Independed.Properties.Resources.play2;
            this.pictureBoxPlay.Location = new System.Drawing.Point(654, 13);
            this.pictureBoxPlay.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxPlay.Name = "pictureBoxPlay";
            this.pictureBoxPlay.Size = new System.Drawing.Size(35, 35);
            this.pictureBoxPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPlay.TabIndex = 5;
            this.pictureBoxPlay.TabStop = false;
            this.pictureBoxPlay.Click += new System.EventHandler(this.pictureBoxPlay_Click);
            // 
            // pictureBoxPreviousTrack
            // 
            this.pictureBoxPreviousTrack.Image = global::Music_Player_2k16_Independed.Properties.Resources.backward2;
            this.pictureBoxPreviousTrack.Location = new System.Drawing.Point(619, 13);
            this.pictureBoxPreviousTrack.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxPreviousTrack.Name = "pictureBoxPreviousTrack";
            this.pictureBoxPreviousTrack.Size = new System.Drawing.Size(35, 35);
            this.pictureBoxPreviousTrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPreviousTrack.TabIndex = 4;
            this.pictureBoxPreviousTrack.TabStop = false;
            this.pictureBoxPreviousTrack.Click += new System.EventHandler(this.pictureBoxPreviousTrack_Click);
            // 
            // lblTrackTime
            // 
            this.lblTrackTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTrackTime.AutoSize = true;
            this.lblTrackTime.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(64)))));
            this.lblTrackTime.Location = new System.Drawing.Point(79, 42);
            this.lblTrackTime.Name = "lblTrackTime";
            this.lblTrackTime.Size = new System.Drawing.Size(78, 17);
            this.lblTrackTime.TabIndex = 3;
            this.lblTrackTime.Text = "00:00:/00:00";
            // 
            // lblTrackAlbum
            // 
            this.lblTrackAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTrackAlbum.AutoSize = true;
            this.lblTrackAlbum.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackAlbum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(64)))));
            this.lblTrackAlbum.Location = new System.Drawing.Point(79, 21);
            this.lblTrackAlbum.Name = "lblTrackAlbum";
            this.lblTrackAlbum.Size = new System.Drawing.Size(77, 17);
            this.lblTrackAlbum.TabIndex = 2;
            this.lblTrackAlbum.Text = "Trackalbum";
            // 
            // lblTrackTitle
            // 
            this.lblTrackTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTrackTitle.AutoSize = true;
            this.lblTrackTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(64)))));
            this.lblTrackTitle.Location = new System.Drawing.Point(78, 0);
            this.lblTrackTitle.Name = "lblTrackTitle";
            this.lblTrackTitle.Size = new System.Drawing.Size(88, 21);
            this.lblTrackTitle.TabIndex = 1;
            this.lblTrackTitle.Text = "Trackname";
            // 
            // pictureBoxCover
            // 
            this.pictureBoxCover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(64)))));
            this.pictureBoxCover.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxCover.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.Size = new System.Drawing.Size(75, 75);
            this.pictureBoxCover.TabIndex = 0;
            this.pictureBoxCover.TabStop = false;
            // 
            // openFileDialogTracks
            // 
            this.openFileDialogTracks.Filter = "MP3-Files|*.mp3";
            this.openFileDialogTracks.Multiselect = true;
            this.openFileDialogTracks.Title = "Choose some tracks";
            // 
            // openFileDialogOpenPlaylist
            // 
            this.openFileDialogOpenPlaylist.Filter = "Playlist |*.pl| All files |*.*";
            this.openFileDialogOpenPlaylist.Title = "Open a existing playlist";
            // 
            // timerUpdateContent
            // 
            this.timerUpdateContent.Enabled = true;
            this.timerUpdateContent.Interval = 500;
            this.timerUpdateContent.Tick += new System.EventHandler(this.timerUpdateContent_Tick);
            // 
            // saveFileDialogPlaylist
            // 
            this.saveFileDialogPlaylist.Filter = "Playlist|*.pl|All files|*.*";
            this.saveFileDialogPlaylist.Title = "Save playlist under";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(851, 446);
            this.Controls.Add(this.panelPlayer);
            this.Controls.Add(this.panelTracks);
            this.Controls.Add(this.panelPlaylists);
            this.Controls.Add(this.panelResize);
            this.Controls.Add(this.panelTitleBar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Player 2k16";
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitleIcon)).EndInit();
            this.panelPlaylists.ResumeLayout(false);
            this.panelPlaylists.PerformLayout();
            this.contextMenuStripPlaylists.ResumeLayout(false);
            this.panelPlaylistsLbl.ResumeLayout(false);
            this.panelPlaylistsLbl.PerformLayout();
            this.panelTracks.ResumeLayout(false);
            this.contextMenuStripTracks.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelPlayer.ResumeLayout(false);
            this.panelPlayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRepeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShuffle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCurPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNextTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreviousTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.PictureBox imgTitleIcon;
        private System.Windows.Forms.Label lblTitleBar;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Panel panelResize;
        private System.Windows.Forms.Panel panelPlaylists;
        private System.Windows.Forms.Panel panelPlaylistsLbl;
        private System.Windows.Forms.Label labelPlaylists;
        private System.Windows.Forms.Button buttonAddPlaylist;
        private System.Windows.Forms.Panel panelTracks;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelPlayer;
        private System.Windows.Forms.ListBox listBoxPlaylists;
        private System.Windows.Forms.PictureBox pictureBoxCover;
        private System.Windows.Forms.Label labelTracks;
        private System.Windows.Forms.PictureBox pictureBoxPreviousTrack;
        private System.Windows.Forms.PictureBox pictureBoxNextTrack;
        private System.Windows.Forms.PictureBox pictureBoxPlay;
        private System.Windows.Forms.TrackBar trackBarVol;
        private System.Windows.Forms.TrackBar trackBarCurPos;
        private System.Windows.Forms.PictureBox pictureBoxRepeat;
        private System.Windows.Forms.PictureBox pictureBoxShuffle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripPlaylists;
        private System.Windows.Forms.ToolStripMenuItem playlistAdd;
        private System.Windows.Forms.ToolStripMenuItem playlistDelete;
        private System.Windows.Forms.ListBox listBoxTracks;
        private System.Windows.Forms.Button buttonDeleteTrack;
        private System.Windows.Forms.Button buttonAddTrack;
        private System.Windows.Forms.TextBox textBoxSearchTrack;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonZip;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTracks;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddTrack;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRemoveTrack;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemClear;
        private System.Windows.Forms.OpenFileDialog openFileDialogTracks;
        private System.Windows.Forms.Button buttonBrowseForPlaylist;
        private System.Windows.Forms.OpenFileDialog openFileDialogOpenPlaylist;
        private System.Windows.Forms.Label labelPlayerStats;
        private System.Windows.Forms.Timer timerUpdateContent;
        public System.Windows.Forms.Label lblTrackTitle;
        public System.Windows.Forms.Label lblTrackAlbum;
        public System.Windows.Forms.Label lblTrackTime;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxPlaylistname;
        private System.Windows.Forms.SaveFileDialog saveFileDialogPlaylist;
    }
}

