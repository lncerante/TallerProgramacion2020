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
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.textBoxSearchTitle = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelType = new System.Windows.Forms.Label();
            this.dataGridViewMedia = new System.Windows.Forms.DataGridView();
            this.ColumnImdbID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRuntime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDirector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnWriter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPoster = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnOrigin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnImdbRating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRate = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnAddToMyList = new System.Windows.Forms.DataGridViewLinkColumn();
            this.SuspendLayout();
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Items.AddRange(new object[] {
            "All genres",
            "Drama",
            "Comedy",
            "Mystery",
            "Romance",
            "Action",
            "Crime",
            "Thriller",
            "Adventure",
            "Western",
            "Fantasy",
            "Horror",
            "Sci-Fi"});
            this.comboBoxGenre.Location = new System.Drawing.Point(469, 107);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(227, 21);
            this.comboBoxGenre.TabIndex = 18;
            this.comboBoxGenre.SelectedIndex = 0;
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "All",
            "Movie",
            "Serie"});
            this.comboBoxType.Location = new System.Drawing.Point(469, 71);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(227, 21);
            this.comboBoxType.Sorted = true;
            this.comboBoxType.TabIndex = 17;
            this.comboBoxType.SelectedIndex = 0;
            // 
            // textBoxSearchTitle
            // 
            this.textBoxSearchTitle.Location = new System.Drawing.Point(469, 40);
            this.textBoxSearchTitle.Name = "textBoxSearchTitle";
            this.textBoxSearchTitle.Size = new System.Drawing.Size(227, 20);
            this.textBoxSearchTitle.TabIndex = 16;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(410, 40);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(30, 13);
            this.labelTitle.TabIndex = 15;
            this.labelTitle.Text = "Title:";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(405, 110);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(39, 13);
            this.labelGenre.TabIndex = 14;
            this.labelGenre.Text = "Genre:";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(535, 153);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 13;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(410, 74);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(34, 13);
            this.labelType.TabIndex = 12;
            this.labelType.Text = "Type:";
            // 
            // dataGridViewMedia
            // 
            this.dataGridViewMedia.AllowUserToAddRows = false;
            this.dataGridViewMedia.AllowUserToDeleteRows = false;
            this.dataGridViewMedia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMedia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnImdbID,
            this.ColumnTitle,
            this.ColumnType,
            this.ColumnGenre,
            this.ColumnReleaseDate,
            this.ColumnRuntime,
            this.ColumnDirector,
            this.ColumnWriter,
            this.ColumnCast,
            this.ColumnPoster,
            this.ColumnOrigin,
            this.ColumnImdbRating,
            this.ColumnRate,
            this.ColumnAddToMyList});
            this.dataGridViewMedia.Location = new System.Drawing.Point(12, 214);
            this.dataGridViewMedia.Name = "dataGridViewMedia";
            this.dataGridViewMedia.ReadOnly = true;
            this.dataGridViewMedia.Size = new System.Drawing.Size(1058, 224);
            this.dataGridViewMedia.TabIndex = 19;
            this.dataGridViewMedia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewMedia_CellContentClick);
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
            // ColumnGenre
            // 
            this.ColumnGenre.HeaderText = "Genre";
            this.ColumnGenre.Name = "ColumnGenre";
            this.ColumnGenre.ReadOnly = true;
            // 
            // ColumnReleaseDate
            // 
            this.ColumnReleaseDate.HeaderText = "Release Date";
            this.ColumnReleaseDate.Name = "ColumnReleaseDate";
            this.ColumnReleaseDate.ReadOnly = true;
            // 
            // ColumnRuntime
            // 
            this.ColumnRuntime.HeaderText = "Runtime (min)";
            this.ColumnRuntime.Name = "ColumnRuntime";
            this.ColumnRuntime.ReadOnly = true;
            // 
            // ColumnDirector
            // 
            this.ColumnDirector.HeaderText = "Director";
            this.ColumnDirector.Name = "ColumnDirector";
            this.ColumnDirector.ReadOnly = true;
            // 
            // ColumnWriter
            // 
            this.ColumnWriter.HeaderText = "Writer";
            this.ColumnWriter.Name = "ColumnWriter";
            this.ColumnWriter.ReadOnly = true;
            // 
            // ColumnCast
            // 
            this.ColumnCast.HeaderText = "Cast";
            this.ColumnCast.Name = "ColumnCast";
            this.ColumnCast.ReadOnly = true;
            // 
            // ColumnPoster
            // 
            this.ColumnPoster.HeaderText = "Poster";
            this.ColumnPoster.Name = "ColumnPoster";
            this.ColumnPoster.ReadOnly = true;
            // 
            // ColumnOrigin
            // 
            this.ColumnOrigin.HeaderText = "Origin";
            this.ColumnOrigin.Name = "ColumnOrigin";
            this.ColumnOrigin.ReadOnly = true;
            // 
            // ColumnImdbRating
            // 
            this.ColumnImdbRating.HeaderText = "ImdbRating";
            this.ColumnImdbRating.Name = "ColumnImdbRating";
            this.ColumnImdbRating.ReadOnly = true;
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
            this.ColumnAddToMyList.HeaderText = "Add to my wach list";
            this.ColumnAddToMyList.Name = "ColumnAddToMyList";
            this.ColumnAddToMyList.ReadOnly = true;
            this.ColumnAddToMyList.Text = "Add";
            this.ColumnAddToMyList.UseColumnTextForLinkValue = true;
            // 
            // FormSearchMoviesOrSeries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 450);
            this.Controls.Add(this.dataGridViewMedia);
            this.Controls.Add(this.comboBoxGenre);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.textBoxSearchTitle);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelType);
            this.Name = "FormSearchMoviesOrSeries";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormSearchMoviesOrSeries_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxGenre;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox textBoxSearchTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.DataGridView dataGridViewMedia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnImdbID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnReleaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRuntime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDirector;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnWriter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCast;
        private System.Windows.Forms.DataGridViewImageColumn ColumnPoster;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOrigin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnImdbRating;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnRate;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnAddToMyList;
    }
}