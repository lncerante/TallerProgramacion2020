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
            this.ColumnImdbID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnImdbRating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.labelRegisteredUsers = new System.Windows.Forms.Label();
            this.panelDecoTitle = new System.Windows.Forms.Panel();
            this.panelDecoGenre = new System.Windows.Forms.Panel();
            this.buttonRate = new System.Windows.Forms.Button();
            this.buttonAddToMyList = new System.Windows.Forms.Button();
            this.buttonSeeMoreInformation = new System.Windows.Forms.Button();
            this.panelForm = new System.Windows.Forms.Panel();
            this.pictureBoxSearchIcon = new System.Windows.Forms.PictureBox();
            this.labelErrorMessage = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedia)).BeginInit();
            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchIcon)).BeginInit();
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
            this.comboBoxType.Location = new System.Drawing.Point(81, 116);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(118, 25);
            this.comboBoxType.Sorted = true;
            this.comboBoxType.TabIndex = 17;
            // 
            // textBoxSearchTitle
            // 
            this.textBoxSearchTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(86)))), ((int)(((byte)(115)))));
            this.textBoxSearchTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearchTitle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchTitle.ForeColor = System.Drawing.Color.White;
            this.textBoxSearchTitle.Location = new System.Drawing.Point(81, 78);
            this.textBoxSearchTitle.MaxLength = 100;
            this.textBoxSearchTitle.Name = "textBoxSearchTitle";
            this.textBoxSearchTitle.Size = new System.Drawing.Size(344, 16);
            this.textBoxSearchTitle.TabIndex = 16;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(15, 78);
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
            this.labelGenre.Location = new System.Drawing.Point(216, 121);
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
            this.labelType.Location = new System.Drawing.Point(15, 121);
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
            this.dataGridViewMedia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewMedia.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dataGridViewMedia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMedia.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewMedia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(86)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(86)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMedia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMedia.ColumnHeadersHeight = 40;
            this.dataGridViewMedia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewMedia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnImdbID,
            this.ColumnTitle,
            this.ColumnYear,
            this.ColumnType,
            this.ColumnGenre,
            this.ColumnImdbRating});
            this.dataGridViewMedia.EnableHeadersVisualStyles = false;
            this.dataGridViewMedia.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(86)))), ((int)(((byte)(115)))));
            this.dataGridViewMedia.Location = new System.Drawing.Point(28, 211);
            this.dataGridViewMedia.MultiSelect = false;
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
            this.dataGridViewMedia.Size = new System.Drawing.Size(1010, 344);
            this.dataGridViewMedia.TabIndex = 19;
            // 
            // ColumnImdbID
            // 
            this.ColumnImdbID.HeaderText = "Imdb ID";
            this.ColumnImdbID.MinimumWidth = 90;
            this.ColumnImdbID.Name = "ColumnImdbID";
            this.ColumnImdbID.ReadOnly = true;
            this.ColumnImdbID.Width = 90;
            // 
            // ColumnTitle
            // 
            this.ColumnTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnTitle.HeaderText = "Title";
            this.ColumnTitle.Name = "ColumnTitle";
            this.ColumnTitle.ReadOnly = true;
            // 
            // ColumnYear
            // 
            this.ColumnYear.HeaderText = "Year";
            this.ColumnYear.Name = "ColumnYear";
            this.ColumnYear.ReadOnly = true;
            this.ColumnYear.Width = 59;
            // 
            // ColumnType
            // 
            this.ColumnType.HeaderText = "Type";
            this.ColumnType.Name = "ColumnType";
            this.ColumnType.ReadOnly = true;
            this.ColumnType.Width = 59;
            // 
            // ColumnGenre
            // 
            this.ColumnGenre.HeaderText = "Genre";
            this.ColumnGenre.Name = "ColumnGenre";
            this.ColumnGenre.ReadOnly = true;
            this.ColumnGenre.Width = 70;
            // 
            // ColumnImdbRating
            // 
            this.ColumnImdbRating.HeaderText = "Imdb Rating";
            this.ColumnImdbRating.MinimumWidth = 120;
            this.ColumnImdbRating.Name = "ColumnImdbRating";
            this.ColumnImdbRating.ReadOnly = true;
            this.ColumnImdbRating.Width = 120;
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(86)))), ((int)(((byte)(115)))));
            this.textBoxGenre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxGenre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGenre.ForeColor = System.Drawing.Color.White;
            this.textBoxGenre.Location = new System.Drawing.Point(282, 125);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(166, 16);
            this.textBoxGenre.TabIndex = 20;
            // 
            // labelRegisteredUsers
            // 
            this.labelRegisteredUsers.AutoSize = true;
            this.labelRegisteredUsers.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegisteredUsers.ForeColor = System.Drawing.Color.White;
            this.labelRegisteredUsers.Location = new System.Drawing.Point(15, 19);
            this.labelRegisteredUsers.Name = "labelRegisteredUsers";
            this.labelRegisteredUsers.Size = new System.Drawing.Size(269, 23);
            this.labelRegisteredUsers.TabIndex = 27;
            this.labelRegisteredUsers.Text = "SEARCH MOVIES OR SERIES";
            // 
            // panelDecoTitle
            // 
            this.panelDecoTitle.BackColor = System.Drawing.Color.White;
            this.panelDecoTitle.Location = new System.Drawing.Point(81, 95);
            this.panelDecoTitle.Name = "panelDecoTitle";
            this.panelDecoTitle.Size = new System.Drawing.Size(367, 1);
            this.panelDecoTitle.TabIndex = 28;
            // 
            // panelDecoGenre
            // 
            this.panelDecoGenre.BackColor = System.Drawing.Color.White;
            this.panelDecoGenre.Location = new System.Drawing.Point(282, 140);
            this.panelDecoGenre.Name = "panelDecoGenre";
            this.panelDecoGenre.Size = new System.Drawing.Size(166, 1);
            this.panelDecoGenre.TabIndex = 30;
            // 
            // buttonRate
            // 
            this.buttonRate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(200)))));
            this.buttonRate.FlatAppearance.BorderSize = 0;
            this.buttonRate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRate.ForeColor = System.Drawing.Color.White;
            this.buttonRate.Location = new System.Drawing.Point(28, 588);
            this.buttonRate.Name = "buttonRate";
            this.buttonRate.Size = new System.Drawing.Size(185, 30);
            this.buttonRate.TabIndex = 31;
            this.buttonRate.Text = "Rate";
            this.buttonRate.UseVisualStyleBackColor = false;
            this.buttonRate.Visible = false;
            this.buttonRate.Click += new System.EventHandler(this.ButtonRate_Click);
            // 
            // buttonAddToMyList
            // 
            this.buttonAddToMyList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddToMyList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(200)))));
            this.buttonAddToMyList.FlatAppearance.BorderSize = 0;
            this.buttonAddToMyList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonAddToMyList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddToMyList.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddToMyList.ForeColor = System.Drawing.Color.White;
            this.buttonAddToMyList.Location = new System.Drawing.Point(853, 588);
            this.buttonAddToMyList.Name = "buttonAddToMyList";
            this.buttonAddToMyList.Size = new System.Drawing.Size(185, 30);
            this.buttonAddToMyList.TabIndex = 32;
            this.buttonAddToMyList.Text = "Add to my watch list";
            this.buttonAddToMyList.UseVisualStyleBackColor = false;
            this.buttonAddToMyList.Visible = false;
            this.buttonAddToMyList.Click += new System.EventHandler(this.ButtonAddToMyList_Click);
            // 
            // buttonSeeMoreInformation
            // 
            this.buttonSeeMoreInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSeeMoreInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(200)))));
            this.buttonSeeMoreInformation.FlatAppearance.BorderSize = 0;
            this.buttonSeeMoreInformation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonSeeMoreInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSeeMoreInformation.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSeeMoreInformation.ForeColor = System.Drawing.Color.White;
            this.buttonSeeMoreInformation.Location = new System.Drawing.Point(433, 588);
            this.buttonSeeMoreInformation.Name = "buttonSeeMoreInformation";
            this.buttonSeeMoreInformation.Size = new System.Drawing.Size(185, 30);
            this.buttonSeeMoreInformation.TabIndex = 33;
            this.buttonSeeMoreInformation.Text = "See more information";
            this.buttonSeeMoreInformation.UseVisualStyleBackColor = false;
            this.buttonSeeMoreInformation.Visible = false;
            this.buttonSeeMoreInformation.Click += new System.EventHandler(this.ButtonSeeMoreInformation_Click);
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(86)))), ((int)(((byte)(115)))));
            this.panelForm.Controls.Add(this.pictureBoxSearchIcon);
            this.panelForm.Controls.Add(this.labelErrorMessage);
            this.panelForm.Controls.Add(this.buttonSearch);
            this.panelForm.Controls.Add(this.labelRegisteredUsers);
            this.panelForm.Controls.Add(this.labelType);
            this.panelForm.Controls.Add(this.panelDecoGenre);
            this.panelForm.Controls.Add(this.labelGenre);
            this.panelForm.Controls.Add(this.labelTitle);
            this.panelForm.Controls.Add(this.panelDecoTitle);
            this.panelForm.Controls.Add(this.textBoxSearchTitle);
            this.panelForm.Controls.Add(this.comboBoxType);
            this.panelForm.Controls.Add(this.textBoxGenre);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelForm.Location = new System.Drawing.Point(0, 0);
            this.panelForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(1080, 188);
            this.panelForm.TabIndex = 43;
            // 
            // pictureBoxSearchIcon
            // 
            this.pictureBoxSearchIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSearchIcon.Image")));
            this.pictureBoxSearchIcon.Location = new System.Drawing.Point(423, 69);
            this.pictureBoxSearchIcon.Name = "pictureBoxSearchIcon";
            this.pictureBoxSearchIcon.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxSearchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSearchIcon.TabIndex = 42;
            this.pictureBoxSearchIcon.TabStop = false;
            // 
            // labelErrorMessage
            // 
            this.labelErrorMessage.AutoSize = true;
            this.labelErrorMessage.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorMessage.ForeColor = System.Drawing.Color.DarkGray;
            this.labelErrorMessage.Image = ((System.Drawing.Image)(resources.GetObject("labelErrorMessage.Image")));
            this.labelErrorMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelErrorMessage.Location = new System.Drawing.Point(16, 158);
            this.labelErrorMessage.Name = "labelErrorMessage";
            this.labelErrorMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelErrorMessage.Size = new System.Drawing.Size(99, 17);
            this.labelErrorMessage.TabIndex = 41;
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
            this.buttonSearch.Location = new System.Drawing.Point(513, 95);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(147, 30);
            this.buttonSearch.TabIndex = 34;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // FormSearchMoviesOrSeries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1080, 630);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.dataGridViewMedia);
            this.Controls.Add(this.buttonSeeMoreInformation);
            this.Controls.Add(this.buttonRate);
            this.Controls.Add(this.buttonAddToMyList);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSearchMoviesOrSeries";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormSearchMoviesOrSeries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedia)).EndInit();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox textBoxSearchTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.DataGridView dataGridViewMedia;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.Label labelRegisteredUsers;
        private System.Windows.Forms.Panel panelDecoTitle;
        private System.Windows.Forms.Panel panelDecoGenre;
        private System.Windows.Forms.Button buttonRate;
        private System.Windows.Forms.Button buttonAddToMyList;
        private System.Windows.Forms.Button buttonSeeMoreInformation;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.PictureBox pictureBoxSearchIcon;
        private System.Windows.Forms.Label labelErrorMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnImdbID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnImdbRating;
    }
}