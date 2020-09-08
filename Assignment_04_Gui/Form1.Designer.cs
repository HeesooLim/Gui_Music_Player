namespace Gui_Music_Player
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pcPicture = new System.Windows.Forms.PictureBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lstMusic = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblYourMusic = new System.Windows.Forms.Label();
            this.btnMusicTab = new System.Windows.Forms.Button();
            this.btnHistoryTab = new System.Windows.Forms.Button();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.tmSplash = new System.Windows.Forms.Timer(this.components);
            this.pnPlayer = new System.Windows.Forms.Panel();
            this.gridViewMusics = new System.Windows.Forms.DataGridView();
            this.pcSplash = new System.Windows.Forms.PictureBox();
            this.btnX = new System.Windows.Forms.Button();
            this.pnBkgProgress = new System.Windows.Forms.Panel();
            this.pnProgress = new System.Windows.Forms.Panel();
            this.pnPlayBar = new System.Windows.Forms.Panel();
            this.pnPlayBarCurrent = new System.Windows.Forms.Panel();
            this.lblLoading = new System.Windows.Forms.Label();
            this.lblPlayMusic = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnSplash = new System.Windows.Forms.Panel();
            this.btnMusicList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcPicture)).BeginInit();
            this.pnPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMusics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcSplash)).BeginInit();
            this.pnBkgProgress.SuspendLayout();
            this.pnPlayBar.SuspendLayout();
            this.pnSplash.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcPicture
            // 
            this.pcPicture.Location = new System.Drawing.Point(21, 130);
            this.pcPicture.Name = "pcPicture";
            this.pcPicture.Size = new System.Drawing.Size(620, 414);
            this.pcPicture.TabIndex = 0;
            this.pcPicture.TabStop = false;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevious.Image")));
            this.btnPrevious.Location = new System.Drawing.Point(254, 564);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(30, 30);
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Location = new System.Drawing.Point(313, 560);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(38, 38);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnNext
            // 
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(374, 564);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(30, 30);
            this.btnNext.TabIndex = 5;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lstMusic
            // 
            this.lstMusic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.lstMusic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstMusic.Font = new System.Drawing.Font("Arial", 13F);
            this.lstMusic.ForeColor = System.Drawing.SystemColors.Menu;
            this.lstMusic.FormattingEnabled = true;
            this.lstMusic.ItemHeight = 25;
            this.lstMusic.Location = new System.Drawing.Point(29, 170);
            this.lstMusic.Name = "lstMusic";
            this.lstMusic.Size = new System.Drawing.Size(227, 200);
            this.lstMusic.TabIndex = 11;
            this.lstMusic.SelectedIndexChanged += new System.EventHandler(this.lstMusic_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(61)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(29, 395);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(227, 56);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Cornsilk;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 9F);
            this.btnDelete.Location = new System.Drawing.Point(146, 458);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 51);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblYourMusic
            // 
            this.lblYourMusic.AutoSize = true;
            this.lblYourMusic.BackColor = System.Drawing.Color.Transparent;
            this.lblYourMusic.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourMusic.ForeColor = System.Drawing.Color.White;
            this.lblYourMusic.Location = new System.Drawing.Point(46, 64);
            this.lblYourMusic.Name = "lblYourMusic";
            this.lblYourMusic.Size = new System.Drawing.Size(193, 38);
            this.lblYourMusic.TabIndex = 10;
            this.lblYourMusic.Text = "Your Musics";
            // 
            // btnMusicTab
            // 
            this.btnMusicTab.BackColor = System.Drawing.Color.Black;
            this.btnMusicTab.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMusicTab.FlatAppearance.BorderSize = 0;
            this.btnMusicTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusicTab.Font = new System.Drawing.Font("Arial", 16F);
            this.btnMusicTab.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnMusicTab.Image = ((System.Drawing.Image)(resources.GetObject("btnMusicTab.Image")));
            this.btnMusicTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusicTab.Location = new System.Drawing.Point(225, 0);
            this.btnMusicTab.Name = "btnMusicTab";
            this.btnMusicTab.Size = new System.Drawing.Size(222, 89);
            this.btnMusicTab.TabIndex = 1;
            this.btnMusicTab.Text = "Player";
            this.btnMusicTab.UseVisualStyleBackColor = false;
            this.btnMusicTab.Click += new System.EventHandler(this.btnMusicTab_Click);
            // 
            // btnHistoryTab
            // 
            this.btnHistoryTab.BackColor = System.Drawing.Color.Black;
            this.btnHistoryTab.FlatAppearance.BorderSize = 0;
            this.btnHistoryTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistoryTab.Font = new System.Drawing.Font("Arial", 16F);
            this.btnHistoryTab.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnHistoryTab.Image = ((System.Drawing.Image)(resources.GetObject("btnHistoryTab.Image")));
            this.btnHistoryTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistoryTab.Location = new System.Drawing.Point(453, 0);
            this.btnHistoryTab.Name = "btnHistoryTab";
            this.btnHistoryTab.Size = new System.Drawing.Size(201, 89);
            this.btnHistoryTab.TabIndex = 2;
            this.btnHistoryTab.Text = "History";
            this.btnHistoryTab.UseVisualStyleBackColor = false;
            this.btnHistoryTab.Click += new System.EventHandler(this.btnHistoryTab_Click);
            // 
            // cboCategory
            // 
            this.cboCategory.BackColor = System.Drawing.Color.Azure;
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.Font = new System.Drawing.Font("Arial", 13.2F);
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(29, 123);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(227, 33);
            this.cboCategory.TabIndex = 6;
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.Cornsilk;
            this.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSort.Font = new System.Drawing.Font("Arial", 9F);
            this.btnSort.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSort.Location = new System.Drawing.Point(30, 458);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(110, 51);
            this.btnSort.TabIndex = 8;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.Info;
            this.btnExit.Location = new System.Drawing.Point(830, 560);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 38);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tmSplash
            // 
            this.tmSplash.Tick += new System.EventHandler(this.tmSplash_Tick);
            // 
            // pnPlayer
            // 
            this.pnPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.pnPlayer.Controls.Add(this.gridViewMusics);
            this.pnPlayer.Controls.Add(this.lblYourMusic);
            this.pnPlayer.Controls.Add(this.cboCategory);
            this.pnPlayer.Controls.Add(this.lstMusic);
            this.pnPlayer.Controls.Add(this.btnAdd);
            this.pnPlayer.Controls.Add(this.btnSort);
            this.pnPlayer.Controls.Add(this.btnDelete);
            this.pnPlayer.Location = new System.Drawing.Point(661, 0);
            this.pnPlayer.Name = "pnPlayer";
            this.pnPlayer.Size = new System.Drawing.Size(288, 618);
            this.pnPlayer.TabIndex = 19;
            // 
            // gridViewMusics
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.gridViewMusics.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridViewMusics.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewMusics.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridViewMusics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewMusics.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridViewMusics.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.gridViewMusics.Location = new System.Drawing.Point(13, 123);
            this.gridViewMusics.Name = "gridViewMusics";
            this.gridViewMusics.RowHeadersWidth = 51;
            this.gridViewMusics.RowTemplate.Height = 27;
            this.gridViewMusics.Size = new System.Drawing.Size(259, 414);
            this.gridViewMusics.TabIndex = 27;
            // 
            // pcSplash
            // 
            this.pcSplash.BackColor = System.Drawing.Color.Transparent;
            this.pcSplash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcSplash.Image = ((System.Drawing.Image)(resources.GetObject("pcSplash.Image")));
            this.pcSplash.Location = new System.Drawing.Point(0, 0);
            this.pcSplash.Margin = new System.Windows.Forms.Padding(0);
            this.pcSplash.Name = "pcSplash";
            this.pcSplash.Size = new System.Drawing.Size(949, 619);
            this.pcSplash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcSplash.TabIndex = 23;
            this.pcSplash.TabStop = false;
            this.pcSplash.WaitOnLoad = true;
            // 
            // btnX
            // 
            this.btnX.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnX.BackgroundImage")));
            this.btnX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnX.FlatAppearance.BorderSize = 0;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.Location = new System.Drawing.Point(921, 12);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(16, 17);
            this.btnX.TabIndex = 24;
            this.btnX.TabStop = false;
            this.btnX.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnX_Click_1);
            // 
            // pnBkgProgress
            // 
            this.pnBkgProgress.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pnBkgProgress.Controls.Add(this.pnProgress);
            this.pnBkgProgress.Location = new System.Drawing.Point(0, 504);
            this.pnBkgProgress.Name = "pnBkgProgress";
            this.pnBkgProgress.Size = new System.Drawing.Size(949, 41);
            this.pnBkgProgress.TabIndex = 25;
            // 
            // pnProgress
            // 
            this.pnProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(201)))), ((int)(((byte)(56)))));
            this.pnProgress.Location = new System.Drawing.Point(0, 0);
            this.pnProgress.Name = "pnProgress";
            this.pnProgress.Size = new System.Drawing.Size(10, 41);
            this.pnProgress.TabIndex = 0;
            // 
            // pnPlayBar
            // 
            this.pnPlayBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnPlayBar.Controls.Add(this.pnPlayBarCurrent);
            this.pnPlayBar.Location = new System.Drawing.Point(21, 533);
            this.pnPlayBar.Name = "pnPlayBar";
            this.pnPlayBar.Size = new System.Drawing.Size(620, 11);
            this.pnPlayBar.TabIndex = 26;
            this.pnPlayBar.Click += new System.EventHandler(this.pnPlayBar_Click);
            // 
            // pnPlayBarCurrent
            // 
            this.pnPlayBarCurrent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(61)))));
            this.pnPlayBarCurrent.Location = new System.Drawing.Point(0, 0);
            this.pnPlayBarCurrent.Name = "pnPlayBarCurrent";
            this.pnPlayBarCurrent.Size = new System.Drawing.Size(16, 11);
            this.pnPlayBarCurrent.TabIndex = 0;
            this.pnPlayBarCurrent.Click += new System.EventHandler(this.pnPlayBarCurrent_Click);
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(82)))));
            this.lblLoading.Font = new System.Drawing.Font("Malgun Gothic Semilight", 15F);
            this.lblLoading.ForeColor = System.Drawing.Color.Gold;
            this.lblLoading.Location = new System.Drawing.Point(6, 458);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Padding = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.lblLoading.Size = new System.Drawing.Size(172, 43);
            this.lblLoading.TabIndex = 27;
            this.lblLoading.Text = "Loading ...    ";
            this.lblLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayMusic
            // 
            this.lblPlayMusic.AutoSize = true;
            this.lblPlayMusic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(82)))));
            this.lblPlayMusic.Font = new System.Drawing.Font("Malgun Gothic Semilight", 14F);
            this.lblPlayMusic.ForeColor = System.Drawing.Color.Gold;
            this.lblPlayMusic.Location = new System.Drawing.Point(376, 325);
            this.lblPlayMusic.Name = "lblPlayMusic";
            this.lblPlayMusic.Padding = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.lblPlayMusic.Size = new System.Drawing.Size(226, 40);
            this.lblPlayMusic.TabIndex = 28;
            this.lblPlayMusic.Text = "Play your music!    ";
            this.lblPlayMusic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(82)))));
            this.lblLogo.Font = new System.Drawing.Font("Perpetua Titling MT", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.Gold;
            this.lblLogo.Location = new System.Drawing.Point(171, 221);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Padding = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.lblLogo.Size = new System.Drawing.Size(607, 104);
            this.lblLogo.TabIndex = 29;
            this.lblLogo.Text = "  theMusic  ";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnSplash
            // 
            this.pnSplash.Controls.Add(this.btnX);
            this.pnSplash.Controls.Add(this.lblLogo);
            this.pnSplash.Controls.Add(this.lblPlayMusic);
            this.pnSplash.Controls.Add(this.lblLoading);
            this.pnSplash.Controls.Add(this.pnBkgProgress);
            this.pnSplash.Controls.Add(this.pcSplash);
            this.pnSplash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSplash.Location = new System.Drawing.Point(0, 0);
            this.pnSplash.Name = "pnSplash";
            this.pnSplash.Size = new System.Drawing.Size(949, 619);
            this.pnSplash.TabIndex = 12;
            // 
            // btnMusicList
            // 
            this.btnMusicList.BackColor = System.Drawing.Color.Black;
            this.btnMusicList.FlatAppearance.BorderSize = 0;
            this.btnMusicList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusicList.Font = new System.Drawing.Font("Arial", 16F);
            this.btnMusicList.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnMusicList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusicList.Location = new System.Drawing.Point(-1, 0);
            this.btnMusicList.Name = "btnMusicList";
            this.btnMusicList.Size = new System.Drawing.Size(220, 89);
            this.btnMusicList.TabIndex = 27;
            this.btnMusicList.Text = "Musics";
            this.btnMusicList.UseVisualStyleBackColor = false;
            this.btnMusicList.Click += new System.EventHandler(this.btnMusicList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(949, 619);
            this.Controls.Add(this.pnSplash);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.pnPlayBar);
            this.Controls.Add(this.pcPicture);
            this.Controls.Add(this.pnPlayer);
            this.Controls.Add(this.btnMusicTab);
            this.Controls.Add(this.btnHistoryTab);
            this.Controls.Add(this.btnMusicList);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(380, 170);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcPicture)).EndInit();
            this.pnPlayer.ResumeLayout(false);
            this.pnPlayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMusics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcSplash)).EndInit();
            this.pnBkgProgress.ResumeLayout(false);
            this.pnPlayBar.ResumeLayout(false);
            this.pnSplash.ResumeLayout(false);
            this.pnSplash.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcPicture;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ListBox lstMusic;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblYourMusic;
        private System.Windows.Forms.Button btnMusicTab;
        private System.Windows.Forms.Button btnHistoryTab;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Timer tmSplash;
        private System.Windows.Forms.Panel pnPlayer;
        private System.Windows.Forms.PictureBox pcSplash;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Panel pnBkgProgress;
        private System.Windows.Forms.Panel pnProgress;
        private System.Windows.Forms.Panel pnPlayBar;
        private System.Windows.Forms.Panel pnPlayBarCurrent;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Label lblPlayMusic;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel pnSplash;
        private System.Windows.Forms.Button btnMusicList;
        private System.Windows.Forms.DataGridView gridViewMusics;
    }
}

