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
            this.buttonSeeWatchList = new System.Windows.Forms.Button();
            this.buttonAddToList = new System.Windows.Forms.Button();
            this.dataGridViewList = new System.Windows.Forms.DataGridView();
            this.buttonSeeReviews = new System.Windows.Forms.Button();
            this.labelListTitle = new System.Windows.Forms.Label();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.columId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnProfilePhoto = new System.Windows.Forms.DataGridViewImageColumn();
            this.columnDelete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.buttonRegisterNewUser = new System.Windows.Forms.Button();
            this.buttonSeeRegistersUsers = new System.Windows.Forms.Button();
            this.ColumnImdbID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnImdbRating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPriority = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColumnSeeInformation = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnRate = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnAddToMyList = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSeeWatchList
            // 
            this.buttonSeeWatchList.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonSeeWatchList.Location = new System.Drawing.Point(307, 19);
            this.buttonSeeWatchList.Name = "buttonSeeWatchList";
            this.buttonSeeWatchList.Size = new System.Drawing.Size(211, 23);
            this.buttonSeeWatchList.TabIndex = 0;
            this.buttonSeeWatchList.Text = "See my watch list";
            this.buttonSeeWatchList.UseVisualStyleBackColor = true;
            this.buttonSeeWatchList.Click += new System.EventHandler(this.ButtonSeeWatchList_Click);
            // 
            // buttonAddToList
            // 
            this.buttonAddToList.Location = new System.Drawing.Point(307, 77);
            this.buttonAddToList.Name = "buttonAddToList";
            this.buttonAddToList.Size = new System.Drawing.Size(211, 23);
            this.buttonAddToList.TabIndex = 1;
            this.buttonAddToList.Text = "Add a movie or serie to my list";
            this.buttonAddToList.UseVisualStyleBackColor = true;
            this.buttonAddToList.Click += new System.EventHandler(this.ButtonAddToList_Click);
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
            this.dataGridViewList.Location = new System.Drawing.Point(50, 214);
            this.dataGridViewList.Name = "dataGridViewList";
            this.dataGridViewList.ReadOnly = true;
            this.dataGridViewList.Size = new System.Drawing.Size(692, 224);
            this.dataGridViewList.TabIndex = 2;
            this.dataGridViewList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewList_CellContentClick);
            // 
            // buttonSeeReviews
            // 
            this.buttonSeeReviews.Location = new System.Drawing.Point(307, 48);
            this.buttonSeeReviews.Name = "buttonSeeReviews";
            this.buttonSeeReviews.Size = new System.Drawing.Size(211, 23);
            this.buttonSeeReviews.TabIndex = 3;
            this.buttonSeeReviews.Text = "See my reviews";
            this.buttonSeeReviews.UseVisualStyleBackColor = true;
            this.buttonSeeReviews.Click += new System.EventHandler(this.ButtonSeeReviews_Click);
            // 
            // labelListTitle
            // 
            this.labelListTitle.AutoSize = true;
            this.labelListTitle.Location = new System.Drawing.Point(47, 181);
            this.labelListTitle.Name = "labelListTitle";
            this.labelListTitle.Size = new System.Drawing.Size(0, 13);
            this.labelListTitle.TabIndex = 4;
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columId,
            this.columUsername,
            this.columnPassword,
            this.columnaFullName,
            this.columnProfilePhoto,
            this.columnDelete});
            this.dataGridViewUsers.Location = new System.Drawing.Point(67, 214);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.Size = new System.Drawing.Size(644, 206);
            this.dataGridViewUsers.TabIndex = 7;
            this.dataGridViewUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewUsers_CellContentClick);
            // 
            // columId
            // 
            this.columId.HeaderText = "Id";
            this.columId.Name = "columId";
            this.columId.ReadOnly = true;
            // 
            // columUsername
            // 
            this.columUsername.HeaderText = "Username";
            this.columUsername.Name = "columUsername";
            this.columUsername.ReadOnly = true;
            // 
            // columnPassword
            // 
            this.columnPassword.HeaderText = "Password";
            this.columnPassword.Name = "columnPassword";
            this.columnPassword.ReadOnly = true;
            // 
            // columnaFullName
            // 
            this.columnaFullName.HeaderText = "Full Name";
            this.columnaFullName.Name = "columnaFullName";
            this.columnaFullName.ReadOnly = true;
            // 
            // columnProfilePhoto
            // 
            this.columnProfilePhoto.HeaderText = "Profile Photo";
            this.columnProfilePhoto.Name = "columnProfilePhoto";
            this.columnProfilePhoto.ReadOnly = true;
            // 
            // columnDelete
            // 
            this.columnDelete.HeaderText = "Delete";
            this.columnDelete.Name = "columnDelete";
            this.columnDelete.ReadOnly = true;
            this.columnDelete.Text = "Delete";
            this.columnDelete.UseColumnTextForLinkValue = true;
            // 
            // buttonRegisterNewUser
            // 
            this.buttonRegisterNewUser.Location = new System.Drawing.Point(307, 136);
            this.buttonRegisterNewUser.Name = "buttonRegisterNewUser";
            this.buttonRegisterNewUser.Size = new System.Drawing.Size(211, 23);
            this.buttonRegisterNewUser.TabIndex = 9;
            this.buttonRegisterNewUser.Text = "Register new user";
            this.buttonRegisterNewUser.UseVisualStyleBackColor = true;
            this.buttonRegisterNewUser.Click += new System.EventHandler(this.ButtonRegisterNewUser_Click);
            // 
            // buttonSeeRegistersUsers
            // 
            this.buttonSeeRegistersUsers.Location = new System.Drawing.Point(307, 107);
            this.buttonSeeRegistersUsers.Name = "buttonSeeRegistersUsers";
            this.buttonSeeRegistersUsers.Size = new System.Drawing.Size(211, 23);
            this.buttonSeeRegistersUsers.TabIndex = 8;
            this.buttonSeeRegistersUsers.Text = "See registered users";
            this.buttonSeeRegistersUsers.UseVisualStyleBackColor = true;
            this.buttonSeeRegistersUsers.Click += new System.EventHandler(this.ButtonSeeRegistersUsers_Click);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRegisterNewUser);
            this.Controls.Add(this.buttonSeeRegistersUsers);
            this.Controls.Add(this.dataGridViewUsers);
            this.Controls.Add(this.labelListTitle);
            this.Controls.Add(this.buttonSeeReviews);
            this.Controls.Add(this.dataGridViewList);
            this.Controls.Add(this.buttonAddToList);
            this.Controls.Add(this.buttonSeeWatchList);
            this.Name = "FormMenu";
            this.Text = "FormManageWatchList";
            this.Load += new System.EventHandler(this.FormManageLists_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSeeWatchList;
        private System.Windows.Forms.Button buttonAddToList;
        private System.Windows.Forms.DataGridView dataGridViewList;
        private System.Windows.Forms.Button buttonSeeReviews;
        private System.Windows.Forms.Label labelListTitle;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn columId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaFullName;
        private System.Windows.Forms.DataGridViewImageColumn columnProfilePhoto;
        private System.Windows.Forms.DataGridViewLinkColumn columnDelete;
        private System.Windows.Forms.Button buttonRegisterNewUser;
        private System.Windows.Forms.Button buttonSeeRegistersUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnImdbID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnReleaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnImdbRating;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnPriority;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnSeeInformation;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnRate;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnAddToMyList;
    }
}