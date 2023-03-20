namespace TallerProgramacion2020.Forms
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.panelControls = new System.Windows.Forms.Panel();
            this.buttonMaximized = new System.Windows.Forms.PictureBox();
            this.buttonRestore = new System.Windows.Forms.PictureBox();
            this.buttonMinimized = new System.Windows.Forms.PictureBox();
            this.buttonClose = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelDeco7 = new System.Windows.Forms.Panel();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.panelDeco4 = new System.Windows.Forms.Panel();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.panelDeco5 = new System.Windows.Forms.Panel();
            this.panelDeco3 = new System.Windows.Forms.Panel();
            this.panelDeco2 = new System.Windows.Forms.Panel();
            this.panelDeco1 = new System.Windows.Forms.Panel();
            this.buttonAddToList = new System.Windows.Forms.Button();
            this.buttonSeeWatchList = new System.Windows.Forms.Button();
            this.buttonManageUsers = new System.Windows.Forms.Button();
            this.buttonSeeReviews = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelFormsContainer = new System.Windows.Forms.Panel();
            this.dataGridViewList = new System.Windows.Forms.DataGridView();
            this.ColumnImdbID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnImdbRating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPriority = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColumnSeeInformation = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnRate = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnAddToMyList = new System.Windows.Forms.DataGridViewLinkColumn();
            this.panelControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMaximized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonRestore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMinimized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonClose)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelFormsContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControls
            // 
            this.panelControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panelControls.Controls.Add(this.buttonMaximized);
            this.panelControls.Controls.Add(this.buttonRestore);
            this.panelControls.Controls.Add(this.buttonMinimized);
            this.panelControls.Controls.Add(this.buttonClose);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControls.Location = new System.Drawing.Point(0, 0);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(1300, 20);
            this.panelControls.TabIndex = 17;
            this.panelControls.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelControls_MouseDown);
            // 
            // buttonMaximized
            // 
            this.buttonMaximized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMaximized.Image = ((System.Drawing.Image)(resources.GetObject("buttonMaximized.Image")));
            this.buttonMaximized.Location = new System.Drawing.Point(1261, 2);
            this.buttonMaximized.Name = "buttonMaximized";
            this.buttonMaximized.Size = new System.Drawing.Size(15, 15);
            this.buttonMaximized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonMaximized.TabIndex = 27;
            this.buttonMaximized.TabStop = false;
            this.buttonMaximized.Click += new System.EventHandler(this.ButtonMaximized_Click);
            // 
            // buttonRestore
            // 
            this.buttonRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRestore.Image = ((System.Drawing.Image)(resources.GetObject("buttonRestore.Image")));
            this.buttonRestore.Location = new System.Drawing.Point(1261, 2);
            this.buttonRestore.Name = "buttonRestore";
            this.buttonRestore.Size = new System.Drawing.Size(15, 15);
            this.buttonRestore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonRestore.TabIndex = 26;
            this.buttonRestore.TabStop = false;
            this.buttonRestore.Visible = false;
            this.buttonRestore.Click += new System.EventHandler(this.ButtonRestore_Click);
            // 
            // buttonMinimized
            // 
            this.buttonMinimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimized.Image = ((System.Drawing.Image)(resources.GetObject("buttonMinimized.Image")));
            this.buttonMinimized.Location = new System.Drawing.Point(1240, 2);
            this.buttonMinimized.Name = "buttonMinimized";
            this.buttonMinimized.Size = new System.Drawing.Size(15, 15);
            this.buttonMinimized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonMinimized.TabIndex = 25;
            this.buttonMinimized.TabStop = false;
            this.buttonMinimized.Click += new System.EventHandler(this.ButtonMinimized_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.Location = new System.Drawing.Point(1282, 2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(15, 15);
            this.buttonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonClose.TabIndex = 24;
            this.buttonClose.TabStop = false;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelMenu.Controls.Add(this.panelDeco7);
            this.panelMenu.Controls.Add(this.buttonLogOut);
            this.panelMenu.Controls.Add(this.panelDeco4);
            this.panelMenu.Controls.Add(this.buttonProfile);
            this.panelMenu.Controls.Add(this.panelDeco5);
            this.panelMenu.Controls.Add(this.panelDeco3);
            this.panelMenu.Controls.Add(this.panelDeco2);
            this.panelMenu.Controls.Add(this.panelDeco1);
            this.panelMenu.Controls.Add(this.buttonAddToList);
            this.panelMenu.Controls.Add(this.buttonSeeWatchList);
            this.panelMenu.Controls.Add(this.buttonManageUsers);
            this.panelMenu.Controls.Add(this.buttonSeeReviews);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 20);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 630);
            this.panelMenu.TabIndex = 18;
            // 
            // panelDeco7
            // 
            this.panelDeco7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDeco7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panelDeco7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelDeco7.Location = new System.Drawing.Point(0, 598);
            this.panelDeco7.Name = "panelDeco7";
            this.panelDeco7.Size = new System.Drawing.Size(5, 32);
            this.panelDeco7.TabIndex = 16;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonLogOut.FlatAppearance.BorderSize = 0;
            this.buttonLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogOut.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogOut.ForeColor = System.Drawing.Color.White;
            this.buttonLogOut.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogOut.Image")));
            this.buttonLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogOut.Location = new System.Drawing.Point(0, 598);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(220, 32);
            this.buttonLogOut.TabIndex = 15;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.ButtonLogOut_Click);
            // 
            // panelDeco4
            // 
            this.panelDeco4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panelDeco4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelDeco4.Location = new System.Drawing.Point(0, 301);
            this.panelDeco4.Name = "panelDeco4";
            this.panelDeco4.Size = new System.Drawing.Size(5, 32);
            this.panelDeco4.TabIndex = 14;
            // 
            // buttonProfile
            // 
            this.buttonProfile.FlatAppearance.BorderSize = 0;
            this.buttonProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProfile.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProfile.ForeColor = System.Drawing.Color.White;
            this.buttonProfile.Image = ((System.Drawing.Image)(resources.GetObject("buttonProfile.Image")));
            this.buttonProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProfile.Location = new System.Drawing.Point(5, 301);
            this.buttonProfile.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(216, 32);
            this.buttonProfile.TabIndex = 13;
            this.buttonProfile.Text = "Profile";
            this.buttonProfile.UseVisualStyleBackColor = true;
            this.buttonProfile.Click += new System.EventHandler(this.ButtonProfile_Click);
            // 
            // panelDeco5
            // 
            this.panelDeco5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panelDeco5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelDeco5.Location = new System.Drawing.Point(0, 346);
            this.panelDeco5.Name = "panelDeco5";
            this.panelDeco5.Size = new System.Drawing.Size(5, 32);
            this.panelDeco5.TabIndex = 11;
            // 
            // panelDeco3
            // 
            this.panelDeco3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panelDeco3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelDeco3.Location = new System.Drawing.Point(0, 256);
            this.panelDeco3.Name = "panelDeco3";
            this.panelDeco3.Size = new System.Drawing.Size(5, 32);
            this.panelDeco3.TabIndex = 11;
            // 
            // panelDeco2
            // 
            this.panelDeco2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panelDeco2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelDeco2.Location = new System.Drawing.Point(0, 211);
            this.panelDeco2.Name = "panelDeco2";
            this.panelDeco2.Size = new System.Drawing.Size(5, 32);
            this.panelDeco2.TabIndex = 10;
            // 
            // panelDeco1
            // 
            this.panelDeco1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panelDeco1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelDeco1.Location = new System.Drawing.Point(0, 166);
            this.panelDeco1.Name = "panelDeco1";
            this.panelDeco1.Size = new System.Drawing.Size(5, 32);
            this.panelDeco1.TabIndex = 8;
            // 
            // buttonAddToList
            // 
            this.buttonAddToList.FlatAppearance.BorderSize = 0;
            this.buttonAddToList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonAddToList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddToList.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddToList.ForeColor = System.Drawing.Color.White;
            this.buttonAddToList.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddToList.Image")));
            this.buttonAddToList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddToList.Location = new System.Drawing.Point(5, 256);
            this.buttonAddToList.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.buttonAddToList.Name = "buttonAddToList";
            this.buttonAddToList.Size = new System.Drawing.Size(217, 32);
            this.buttonAddToList.TabIndex = 1;
            this.buttonAddToList.Text = "Search media";
            this.buttonAddToList.UseVisualStyleBackColor = true;
            this.buttonAddToList.Click += new System.EventHandler(this.ButtonAddToList_Click);
            // 
            // buttonSeeWatchList
            // 
            this.buttonSeeWatchList.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonSeeWatchList.FlatAppearance.BorderSize = 0;
            this.buttonSeeWatchList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonSeeWatchList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSeeWatchList.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSeeWatchList.ForeColor = System.Drawing.Color.White;
            this.buttonSeeWatchList.Image = ((System.Drawing.Image)(resources.GetObject("buttonSeeWatchList.Image")));
            this.buttonSeeWatchList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSeeWatchList.Location = new System.Drawing.Point(5, 166);
            this.buttonSeeWatchList.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.buttonSeeWatchList.Name = "buttonSeeWatchList";
            this.buttonSeeWatchList.Size = new System.Drawing.Size(215, 32);
            this.buttonSeeWatchList.TabIndex = 0;
            this.buttonSeeWatchList.Text = "My watch list";
            this.buttonSeeWatchList.UseVisualStyleBackColor = true;
            this.buttonSeeWatchList.Click += new System.EventHandler(this.ButtonSeeWatchList_Click);
            // 
            // buttonManageUsers
            // 
            this.buttonManageUsers.FlatAppearance.BorderSize = 0;
            this.buttonManageUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonManageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManageUsers.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManageUsers.ForeColor = System.Drawing.Color.White;
            this.buttonManageUsers.Image = ((System.Drawing.Image)(resources.GetObject("buttonManageUsers.Image")));
            this.buttonManageUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonManageUsers.Location = new System.Drawing.Point(3, 346);
            this.buttonManageUsers.Name = "buttonManageUsers";
            this.buttonManageUsers.Size = new System.Drawing.Size(219, 32);
            this.buttonManageUsers.TabIndex = 8;
            this.buttonManageUsers.Text = "Users";
            this.buttonManageUsers.UseVisualStyleBackColor = true;
            this.buttonManageUsers.Click += new System.EventHandler(this.ButtonManageUsers_Click);
            // 
            // buttonSeeReviews
            // 
            this.buttonSeeReviews.FlatAppearance.BorderSize = 0;
            this.buttonSeeReviews.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonSeeReviews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSeeReviews.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSeeReviews.ForeColor = System.Drawing.Color.White;
            this.buttonSeeReviews.Image = ((System.Drawing.Image)(resources.GetObject("buttonSeeReviews.Image")));
            this.buttonSeeReviews.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSeeReviews.Location = new System.Drawing.Point(3, 211);
            this.buttonSeeReviews.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.buttonSeeReviews.Name = "buttonSeeReviews";
            this.buttonSeeReviews.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonSeeReviews.Size = new System.Drawing.Size(217, 32);
            this.buttonSeeReviews.TabIndex = 3;
            this.buttonSeeReviews.Text = "My reviews";
            this.buttonSeeReviews.UseVisualStyleBackColor = true;
            this.buttonSeeReviews.Click += new System.EventHandler(this.ButtonSeeReviews_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panelFormsContainer
            // 
            this.panelFormsContainer.AutoSize = true;
            this.panelFormsContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelFormsContainer.Controls.Add(this.dataGridViewList);
            this.panelFormsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormsContainer.Location = new System.Drawing.Point(220, 20);
            this.panelFormsContainer.Name = "panelFormsContainer";
            this.panelFormsContainer.Size = new System.Drawing.Size(1080, 630);
            this.panelFormsContainer.TabIndex = 19;
            // 
            // dataGridViewList
            // 
            this.dataGridViewList.AllowUserToAddRows = false;
            this.dataGridViewList.AllowUserToDeleteRows = false;
            this.dataGridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnImdbID,
            this.ColumnTitle,
            this.ColumnType,
            this.ColumnReleaseDate,
            this.ColumnImdbRating,
            this.ColumnPriority,
            this.ColumnSeeInformation,
            this.ColumnRate,
            this.ColumnAddToMyList});
            this.dataGridViewList.Location = new System.Drawing.Point(51, 117);
            this.dataGridViewList.Name = "dataGridViewList";
            this.dataGridViewList.ReadOnly = true;
            this.dataGridViewList.Size = new System.Drawing.Size(663, 441);
            this.dataGridViewList.TabIndex = 2;
            // 
            // ColumnImdbID
            // 
            this.ColumnImdbID.HeaderText = "Imdb ID";
            this.ColumnImdbID.Name = "ColumnImdbID";
            this.ColumnImdbID.ReadOnly = true;
            // 
            // ColumnTitle
            // 
            this.ColumnTitle.HeaderText = "Title";
            this.ColumnTitle.Name = "ColumnTitle";
            this.ColumnTitle.ReadOnly = true;
            // 
            // ColumnType
            // 
            this.ColumnType.HeaderText = "Type";
            this.ColumnType.Name = "ColumnType";
            this.ColumnType.ReadOnly = true;
            // 
            // ColumnReleaseDate
            // 
            this.ColumnReleaseDate.HeaderText = "Release Date";
            this.ColumnReleaseDate.Name = "ColumnReleaseDate";
            this.ColumnReleaseDate.ReadOnly = true;
            // 
            // ColumnImdbRating
            // 
            this.ColumnImdbRating.HeaderText = "ImdbRating";
            this.ColumnImdbRating.Name = "ColumnImdbRating";
            this.ColumnImdbRating.ReadOnly = true;
            // 
            // ColumnPriority
            // 
            this.ColumnPriority.DisplayStyleForCurrentCellOnly = true;
            this.ColumnPriority.HeaderText = "Priority";
            this.ColumnPriority.Name = "ColumnPriority";
            this.ColumnPriority.ReadOnly = true;
            // 
            // ColumnSeeInformation
            // 
            this.ColumnSeeInformation.HeaderText = "See more information";
            this.ColumnSeeInformation.Name = "ColumnSeeInformation";
            this.ColumnSeeInformation.ReadOnly = true;
            this.ColumnSeeInformation.Text = "See more information";
            this.ColumnSeeInformation.UseColumnTextForLinkValue = true;
            // 
            // ColumnRate
            // 
            this.ColumnRate.HeaderText = "Rate";
            this.ColumnRate.Name = "ColumnRate";
            this.ColumnRate.ReadOnly = true;
            this.ColumnRate.Text = "Rate";
            this.ColumnRate.UseColumnTextForLinkValue = true;
            // 
            // ColumnAddToMyList
            // 
            this.ColumnAddToMyList.HeaderText = "Delete";
            this.ColumnAddToMyList.Name = "ColumnAddToMyList";
            this.ColumnAddToMyList.ReadOnly = true;
            this.ColumnAddToMyList.Text = "Delete";
            this.ColumnAddToMyList.UseColumnTextForLinkValue = true;
            // 
            // FormMenu
            // 
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelFormsContainer);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelControls);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.panelControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonMaximized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonRestore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMinimized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonClose)).EndInit();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelFormsContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.PictureBox buttonMaximized;
        private System.Windows.Forms.PictureBox buttonRestore;
        private System.Windows.Forms.PictureBox buttonMinimized;
        private System.Windows.Forms.PictureBox buttonClose;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelDeco4;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Panel panelDeco5;
        private System.Windows.Forms.Panel panelDeco3;
        private System.Windows.Forms.Panel panelDeco2;
        private System.Windows.Forms.Panel panelDeco1;
        private System.Windows.Forms.Button buttonAddToList;
        private System.Windows.Forms.Button buttonSeeWatchList;
        private System.Windows.Forms.Button buttonManageUsers;
        private System.Windows.Forms.Button buttonSeeReviews;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelFormsContainer;
        private System.Windows.Forms.DataGridView dataGridViewList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnImdbID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnReleaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnImdbRating;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnPriority;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnSeeInformation;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnRate;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnAddToMyList;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Panel panelDeco7;
    }
}