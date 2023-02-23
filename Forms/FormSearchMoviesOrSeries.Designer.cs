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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.radioButtonSerie = new System.Windows.Forms.RadioButton();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.radioButtonMovie = new System.Windows.Forms.RadioButton();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.textBoxSearchTitle = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
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
            this.listBox1.Location = new System.Drawing.Point(518, 100);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(70, 82);
            this.listBox1.TabIndex = 23;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 188);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(733, 150);
            this.dataGridView1.TabIndex = 22;
            // 
            // radioButtonSerie
            // 
            this.radioButtonSerie.AutoSize = true;
            this.radioButtonSerie.Location = new System.Drawing.Point(591, 65);
            this.radioButtonSerie.Name = "radioButtonSerie";
            this.radioButtonSerie.Size = new System.Drawing.Size(49, 17);
            this.radioButtonSerie.TabIndex = 21;
            this.radioButtonSerie.TabStop = true;
            this.radioButtonSerie.Text = "Serie";
            this.radioButtonSerie.UseVisualStyleBackColor = true;
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Location = new System.Drawing.Point(651, 65);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(36, 17);
            this.radioButtonAll.TabIndex = 20;
            this.radioButtonAll.TabStop = true;
            this.radioButtonAll.Text = "All";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            // 
            // radioButtonMovie
            // 
            this.radioButtonMovie.AutoSize = true;
            this.radioButtonMovie.Location = new System.Drawing.Point(531, 65);
            this.radioButtonMovie.Name = "radioButtonMovie";
            this.radioButtonMovie.Size = new System.Drawing.Size(54, 17);
            this.radioButtonMovie.TabIndex = 19;
            this.radioButtonMovie.TabStop = true;
            this.radioButtonMovie.Text = "Movie";
            this.radioButtonMovie.UseVisualStyleBackColor = true;
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Items.AddRange(new object[] {
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
            this.comboBoxGenre.Location = new System.Drawing.Point(285, 100);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(227, 21);
            this.comboBoxGenre.TabIndex = 18;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "All",
            "Movie",
            "Serie"});
            this.comboBoxType.Location = new System.Drawing.Point(285, 64);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(227, 21);
            this.comboBoxType.Sorted = true;
            this.comboBoxType.TabIndex = 17;
            // 
            // textBoxSearchTitle
            // 
            this.textBoxSearchTitle.Location = new System.Drawing.Point(285, 33);
            this.textBoxSearchTitle.Name = "textBoxSearchTitle";
            this.textBoxSearchTitle.Size = new System.Drawing.Size(227, 20);
            this.textBoxSearchTitle.TabIndex = 16;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(226, 33);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(30, 13);
            this.labelTitle.TabIndex = 15;
            this.labelTitle.Text = "Title:";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(221, 103);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(39, 13);
            this.labelGenre.TabIndex = 14;
            this.labelGenre.Text = "Genre:";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(351, 146);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 13;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(226, 67);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(34, 13);
            this.labelType.TabIndex = 12;
            this.labelType.Text = "Type:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.radioButtonSerie);
            this.Controls.Add(this.radioButtonAll);
            this.Controls.Add(this.radioButtonMovie);
            this.Controls.Add(this.comboBoxGenre);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.textBoxSearchTitle);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelType);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton radioButtonSerie;
        private System.Windows.Forms.RadioButton radioButtonAll;
        private System.Windows.Forms.RadioButton radioButtonMovie;
        private System.Windows.Forms.ComboBox comboBoxGenre;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox textBoxSearchTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelType;
    }
}