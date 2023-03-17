namespace TallerProgramacion2020.Forms
{
    partial class FormSearchMoviesOrSeries
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSearchMoviesOrSeries));
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.textBoxSearchTitle = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.dataGridViewMedia = new System.Windows.Forms.DataGridView();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.labelErrorMessage = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelRegisteredUsers = new System.Windows.Forms.Label();
            this.panelUsername = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ColumnImdbID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRate = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnMoreInfo = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnAddToMyList = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxType
            // 
            this.comboBoxType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxType.ForeColor = System.Drawing.Color.White;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "All",
            "Movie",
            "Serie"});
            this.comboBoxType.Location = new System.Drawing.Point(440, 95);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(154, 25);
            this.comboBoxType.Sorted = true;
            this.comboBoxType.TabIndex = 17;
            // 
            // textBoxSearchTitle
            // 
            this.textBoxSearchTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.textBoxSearchTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearchTitle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchTitle.ForeColor = System.Drawing.Color.White;
            this.textBoxSearchTitle.Location = new System.Drawing.Point(440, 55);
            this.textBoxSearchTitle.MaxLength = 100;
            this.textBoxSearchTitle.Name = "textBoxSearchTitle";
            this.textBoxSearchTitle.Size = new System.Drawing.Size(388, 16);
            this.textBoxSearchTitle.TabIndex = 16;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(395, 55);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(39, 20);
            this.labelTitle.TabIndex = 15;
            this.labelTitle.Text = "Title:";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenre.ForeColor = System.Drawing.Color.White;
            this.labelGenre.Location = new System.Drawing.Point(607, 100);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(60, 20);
            this.labelGenre.TabIndex = 14;
            this.labelGenre.Text = "Genre:";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.ForeColor = System.Drawing.Color.White;
            this.labelType.Location = new System.Drawing.Point(395, 100);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(46, 20);
            this.labelType.TabIndex = 12;
            this.labelType.Text = "Type:";
            // 
            // dataGridViewMedia
            // 
            this.dataGridViewMedia.AllowUserToAddRows = false;
            this.dataGridViewMedia.AllowUserToDeleteRows = false;
            this.dataGridViewMedia.AllowUserToResizeColumns = false;
            this.dataGridViewMedia.AllowUserToResizeRows = false;
            this.dataGridViewMedia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMedia.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dataGridViewMedia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMedia.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridViewMedia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(86)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(86)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMedia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMedia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMedia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnImdbID,
            this.ColumnTitle,
            this.ColumnType,
            this.ColumnGenre,
            this.ColumnRate,
            this.ColumnMoreInfo,
            this.ColumnAddToMyList});
            this.dataGridViewMedia.EnableHeadersVisualStyles = false;
            this.dataGridViewMedia.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(86)))), ((int)(((byte)(115)))));
            this.dataGridViewMedia.Location = new System.Drawing.Point(12, 212);
            this.dataGridViewMedia.Name = "dataGridViewMedia";
            this.dataGridViewMedia.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMedia.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMedia.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewMedia.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewMedia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMedia.Size = new System.Drawing.Size(1044, 406);
            this.dataGridViewMedia.TabIndex = 19;
            this.dataGridViewMedia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewMedia_CellContentClick);
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.textBoxGenre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxGenre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGenre.ForeColor = System.Drawing.Color.White;
            this.textBoxGenre.Location = new System.Drawing.Point(673, 98);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(181, 16);
            this.textBoxGenre.TabIndex = 20;
            // 
            // labelErrorMessage
            // 
            this.labelErrorMessage.AutoSize = true;
            this.labelErrorMessage.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorMessage.ForeColor = System.Drawing.Color.DarkGray;
            this.labelErrorMessage.Image = ((System.Drawing.Image)(resources.GetObject("labelErrorMessage.Image")));
            this.labelErrorMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelErrorMessage.Location = new System.Drawing.Point(90, 133);
            this.labelErrorMessage.Name = "labelErrorMessage";
            this.labelErrorMessage.Size = new System.Drawing.Size(99, 17);
            this.labelErrorMessage.TabIndex = 25;
            this.labelErrorMessage.Text = "Error Message:";
            this.labelErrorMessage.Visible = false;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(200)))));
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(175, 125);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(185, 30);
            this.buttonSearch.TabIndex = 26;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // labelRegisteredUsers
            // 
            this.labelRegisteredUsers.AutoSize = true;
            this.labelRegisteredUsers.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegisteredUsers.ForeColor = System.Drawing.Color.White;
            this.labelRegisteredUsers.Location = new System.Drawing.Point(12, 9);
            this.labelRegisteredUsers.Name = "labelRegisteredUsers";
            this.labelRegisteredUsers.Size = new System.Drawing.Size(269, 23);
            this.labelRegisteredUsers.TabIndex = 27;
            this.labelRegisteredUsers.Text = "SEARCH MOVIES OR SERIES";
            // 
            // panelUsername
            // 
            this.panelUsername.BackColor = System.Drawing.Color.White;
            this.panelUsername.Location = new System.Drawing.Point(440, 74);
            this.panelUsername.Name = "panelUsername";
            this.panelUsername.Size = new System.Drawing.Size(414, 1);
            this.panelUsername.TabIndex = 28;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(834, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(673, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 1);
            this.panel1.TabIndex = 30;
            // 
            // ColumnImdbID
            // 
            this.ColumnImdbID.HeaderText = "Imdb ID";
            this.ColumnImdbID.Name = "ColumnImdbID";
            this.ColumnImdbID.ReadOnly = true;
            // 
            // ColumnTitle
            // 
            this.ColumnTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
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
            // ColumnGenre
            // 
            this.ColumnGenre.HeaderText = "Genre";
            this.ColumnGenre.Name = "ColumnGenre";
            this.ColumnGenre.ReadOnly = true;
            // 
            // ColumnRate
            // 
            this.ColumnRate.HeaderText = "Rate";
            this.ColumnRate.Name = "ColumnRate";
            this.ColumnRate.ReadOnly = true;
            this.ColumnRate.Text = "Rate";
            this.ColumnRate.UseColumnTextForLinkValue = true;
            // 
            // ColumnMoreInfo
            // 
            this.ColumnMoreInfo.HeaderText = "More Info";
            this.ColumnMoreInfo.Name = "ColumnMoreInfo";
            this.ColumnMoreInfo.ReadOnly = true;
            this.ColumnMoreInfo.Text = "More Info";
            this.ColumnMoreInfo.UseColumnTextForLinkValue = true;
            // 
            // ColumnAddToMyList
            // 
            this.ColumnAddToMyList.HeaderText = "Add to my wach list";
            this.ColumnAddToMyList.MinimumWidth = 120;
            this.ColumnAddToMyList.Name = "ColumnAddToMyList";
            this.ColumnAddToMyList.ReadOnly = true;
            this.ColumnAddToMyList.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnAddToMyList.Width = 120;
            // 
            // FormSearchMoviesOrSeries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1080, 630);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelUsername);
            this.Controls.Add(this.labelRegisteredUsers);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelErrorMessage);
            this.Controls.Add(this.textBoxGenre);
            this.Controls.Add(this.dataGridViewMedia);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.textBoxSearchTitle);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.labelType);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSearchMoviesOrSeries";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormSearchMoviesOrSeries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox textBoxSearchTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.DataGridView dataGridViewMedia;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.Label labelErrorMessage;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelRegisteredUsers;
        private System.Windows.Forms.Panel panelUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnImdbID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGenre;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnRate;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnMoreInfo;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnAddToMyList;
    }
}