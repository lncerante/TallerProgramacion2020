namespace TallerProgramacion2020.Forms
{
    partial class FormManageUsers
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
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonRegisterNewUser = new System.Windows.Forms.Button();
            this.buttonSeeRegistersUsers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(616, 327);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(112, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(579, 206);
            this.dataGridView1.TabIndex = 6;
            // 
            // buttonRegisterNewUser
            // 
            this.buttonRegisterNewUser.Location = new System.Drawing.Point(302, 67);
            this.buttonRegisterNewUser.Name = "buttonRegisterNewUser";
            this.buttonRegisterNewUser.Size = new System.Drawing.Size(216, 23);
            this.buttonRegisterNewUser.TabIndex = 5;
            this.buttonRegisterNewUser.Text = "Register new user";
            this.buttonRegisterNewUser.UseVisualStyleBackColor = true;
            this.buttonRegisterNewUser.Click += new System.EventHandler(this.ButtonRegisterNewUser_Click);
            // 
            // buttonSeeRegistersUsers
            // 
            this.buttonSeeRegistersUsers.Location = new System.Drawing.Point(302, 25);
            this.buttonSeeRegistersUsers.Name = "buttonSeeRegistersUsers";
            this.buttonSeeRegistersUsers.Size = new System.Drawing.Size(211, 23);
            this.buttonSeeRegistersUsers.TabIndex = 4;
            this.buttonSeeRegistersUsers.Text = "See registered users";
            this.buttonSeeRegistersUsers.UseVisualStyleBackColor = true;
            this.buttonSeeRegistersUsers.Click += new System.EventHandler(this.ButtonSeeRegistersUsers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonRegisterNewUser);
            this.Controls.Add(this.buttonSeeRegistersUsers);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonRegisterNewUser;
        private System.Windows.Forms.Button buttonSeeRegistersUsers;
    }
}