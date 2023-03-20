namespace TallerProgramacion2020.Forms
{
    partial class FormWatchList
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
            this.dataGridViewMedia = new System.Windows.Forms.DataGridView();
            this.ColumnPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnImdbID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnImdbRating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelRegisteredUsers = new System.Windows.Forms.Label();
            this.buttonSeeMoreInformation = new System.Windows.Forms.Button();
            this.buttonEditPriority = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonRate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedia)).BeginInit();
            this.SuspendLayout();
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
            this.ColumnPriority,
            this.ColumnImdbID,
            this.ColumnTitle,
            this.ColumnYear,
            this.ColumnType,
            this.ColumnGenre,
            this.ColumnImdbRating});
            this.dataGridViewMedia.EnableHeadersVisualStyles = false;
            this.dataGridViewMedia.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(86)))), ((int)(((byte)(115)))));
            this.dataGridViewMedia.Location = new System.Drawing.Point(26, 70);
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
            this.dataGridViewMedia.Size = new System.Drawing.Size(897, 524);
            this.dataGridViewMedia.TabIndex = 20;
            // 
            // ColumnPriority
            // 
            this.ColumnPriority.HeaderText = "Priority";
            this.ColumnPriority.MinimumWidth = 80;
            this.ColumnPriority.Name = "ColumnPriority";
            this.ColumnPriority.ReadOnly = true;
            this.ColumnPriority.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnPriority.Width = 80;
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
            // labelRegisteredUsers
            // 
            this.labelRegisteredUsers.AutoSize = true;
            this.labelRegisteredUsers.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegisteredUsers.ForeColor = System.Drawing.Color.White;
            this.labelRegisteredUsers.Location = new System.Drawing.Point(22, 27);
            this.labelRegisteredUsers.Name = "labelRegisteredUsers";
            this.labelRegisteredUsers.Size = new System.Drawing.Size(154, 23);
            this.labelRegisteredUsers.TabIndex = 29;
            this.labelRegisteredUsers.Text = "MY WATCH LIST";
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
            this.buttonSeeMoreInformation.Location = new System.Drawing.Point(929, 383);
            this.buttonSeeMoreInformation.Name = "buttonSeeMoreInformation";
            this.buttonSeeMoreInformation.Size = new System.Drawing.Size(139, 30);
            this.buttonSeeMoreInformation.TabIndex = 36;
            this.buttonSeeMoreInformation.Text = "See more info";
            this.buttonSeeMoreInformation.UseVisualStyleBackColor = false;
            this.buttonSeeMoreInformation.Click += new System.EventHandler(this.ButtonSeeMoreInformation_Click);
            // 
            // buttonEditPriority
            // 
            this.buttonEditPriority.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditPriority.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(200)))));
            this.buttonEditPriority.FlatAppearance.BorderSize = 0;
            this.buttonEditPriority.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonEditPriority.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditPriority.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditPriority.ForeColor = System.Drawing.Color.White;
            this.buttonEditPriority.Location = new System.Drawing.Point(929, 333);
            this.buttonEditPriority.Name = "buttonEditPriority";
            this.buttonEditPriority.Size = new System.Drawing.Size(139, 30);
            this.buttonEditPriority.TabIndex = 34;
            this.buttonEditPriority.Text = "Edit Priority";
            this.buttonEditPriority.UseVisualStyleBackColor = false;
            this.buttonEditPriority.Click += new System.EventHandler(this.ButtonEditPriority_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(200)))));
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(929, 228);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(139, 30);
            this.buttonDelete.TabIndex = 35;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
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
            this.buttonRate.Location = new System.Drawing.Point(929, 280);
            this.buttonRate.Name = "buttonRate";
            this.buttonRate.Size = new System.Drawing.Size(139, 30);
            this.buttonRate.TabIndex = 37;
            this.buttonRate.Text = "Rate";
            this.buttonRate.UseVisualStyleBackColor = false;
            this.buttonRate.Click += new System.EventHandler(this.ButtonRate_Click);
            // 
            // FormWatchList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1080, 630);
            this.Controls.Add(this.buttonRate);
            this.Controls.Add(this.buttonSeeMoreInformation);
            this.Controls.Add(this.buttonEditPriority);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelRegisteredUsers);
            this.Controls.Add(this.dataGridViewMedia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormWatchList";
            this.Text = "FormWatchList";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMedia;
        private System.Windows.Forms.Label labelRegisteredUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPriority;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnImdbID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnImdbRating;
        private System.Windows.Forms.Button buttonSeeMoreInformation;
        private System.Windows.Forms.Button buttonEditPriority;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonRate;
    }
}