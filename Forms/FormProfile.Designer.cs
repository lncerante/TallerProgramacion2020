namespace TallerProgramacion2020.Forms
{
    partial class FormProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProfile));
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panelUsername = new System.Windows.Forms.Panel();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.labelErrorMessage = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.panelFullName = new System.Windows.Forms.Panel();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonUploadPicture = new System.Windows.Forms.Button();
            this.labelFullName = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelProfilePicture = new System.Windows.Forms.Label();
            this.labelRegisterOrEdit = new System.Windows.Forms.Label();
            this.openFileDialogUploadPicture = new System.Windows.Forms.OpenFileDialog();
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            this.labelUserUsername = new System.Windows.Forms.Label();
            this.labelUserPassword = new System.Windows.Forms.Label();
            this.labelUserFullName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxProfile.InitialImage")));
            this.pictureBoxProfile.Location = new System.Drawing.Point(23, 43);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(232, 222);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProfile.TabIndex = 0;
            this.pictureBoxProfile.TabStop = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(200)))));
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(509, 312);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(121, 35);
            this.buttonCancel.TabIndex = 57;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Visible = false;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // panelUsername
            // 
            this.panelUsername.BackColor = System.Drawing.Color.White;
            this.panelUsername.Location = new System.Drawing.Point(410, 66);
            this.panelUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelUsername.Name = "panelUsername";
            this.panelUsername.Size = new System.Drawing.Size(220, 1);
            this.panelUsername.TabIndex = 56;
            this.panelUsername.Visible = false;
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(200)))));
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(294, 312);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(121, 35);
            this.buttonEdit.TabIndex = 52;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // labelErrorMessage
            // 
            this.labelErrorMessage.AutoSize = true;
            this.labelErrorMessage.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorMessage.ForeColor = System.Drawing.Color.DarkGray;
            this.labelErrorMessage.Image = ((System.Drawing.Image)(resources.GetObject("labelErrorMessage.Image")));
            this.labelErrorMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelErrorMessage.Location = new System.Drawing.Point(291, 267);
            this.labelErrorMessage.Name = "labelErrorMessage";
            this.labelErrorMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelErrorMessage.Size = new System.Drawing.Size(99, 17);
            this.labelErrorMessage.TabIndex = 55;
            this.labelErrorMessage.Text = "Error Message:";
            this.labelErrorMessage.Visible = false;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(293, 42);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(3, 40, 3, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(87, 20);
            this.labelUsername.TabIndex = 44;
            this.labelUsername.Text = "Username:";
            // 
            // panelFullName
            // 
            this.panelFullName.BackColor = System.Drawing.Color.White;
            this.panelFullName.Location = new System.Drawing.Point(410, 187);
            this.panelFullName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelFullName.Name = "panelFullName";
            this.panelFullName.Size = new System.Drawing.Size(220, 1);
            this.panelFullName.TabIndex = 54;
            this.panelFullName.Visible = false;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.White;
            this.labelPassword.Location = new System.Drawing.Point(293, 102);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(3, 40, 3, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(83, 20);
            this.labelPassword.TabIndex = 45;
            this.labelPassword.Text = "Password:";
            // 
            // buttonUploadPicture
            // 
            this.buttonUploadPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(200)))));
            this.buttonUploadPicture.FlatAppearance.BorderSize = 0;
            this.buttonUploadPicture.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonUploadPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUploadPicture.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUploadPicture.ForeColor = System.Drawing.Color.White;
            this.buttonUploadPicture.Location = new System.Drawing.Point(410, 222);
            this.buttonUploadPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUploadPicture.Name = "buttonUploadPicture";
            this.buttonUploadPicture.Size = new System.Drawing.Size(220, 26);
            this.buttonUploadPicture.TabIndex = 53;
            this.buttonUploadPicture.Text = "Upload Picture";
            this.buttonUploadPicture.UseVisualStyleBackColor = false;
            this.buttonUploadPicture.Visible = false;
            this.buttonUploadPicture.Click += new System.EventHandler(this.ButtonUploadPicture_Click);
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFullName.ForeColor = System.Drawing.Color.White;
            this.labelFullName.Location = new System.Drawing.Point(293, 162);
            this.labelFullName.Margin = new System.Windows.Forms.Padding(3, 40, 3, 0);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(83, 20);
            this.labelFullName.TabIndex = 46;
            this.labelFullName.Text = "Full Name:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsername.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.ForeColor = System.Drawing.Color.White;
            this.textBoxUsername.Location = new System.Drawing.Point(410, 43);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUsername.MaxLength = 15;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(220, 19);
            this.textBoxUsername.TabIndex = 47;
            this.textBoxUsername.Visible = false;
            // 
            // panelPassword
            // 
            this.panelPassword.BackColor = System.Drawing.Color.White;
            this.panelPassword.Location = new System.Drawing.Point(410, 126);
            this.panelPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(220, 1);
            this.panelPassword.TabIndex = 51;
            this.panelPassword.Visible = false;
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.textBoxFullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFullName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFullName.ForeColor = System.Drawing.Color.White;
            this.textBoxFullName.Location = new System.Drawing.Point(410, 163);
            this.textBoxFullName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxFullName.MaxLength = 50;
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(220, 19);
            this.textBoxFullName.TabIndex = 48;
            this.textBoxFullName.Visible = false;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.White;
            this.textBoxPassword.Location = new System.Drawing.Point(410, 103);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPassword.MaxLength = 8;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(220, 19);
            this.textBoxPassword.TabIndex = 49;
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.Visible = false;
            // 
            // labelProfilePicture
            // 
            this.labelProfilePicture.AutoSize = true;
            this.labelProfilePicture.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfilePicture.ForeColor = System.Drawing.Color.White;
            this.labelProfilePicture.Location = new System.Drawing.Point(290, 222);
            this.labelProfilePicture.Margin = new System.Windows.Forms.Padding(3, 40, 3, 0);
            this.labelProfilePicture.Name = "labelProfilePicture";
            this.labelProfilePicture.Size = new System.Drawing.Size(113, 20);
            this.labelProfilePicture.TabIndex = 50;
            this.labelProfilePicture.Text = "Profile Picture:";
            this.labelProfilePicture.Visible = false;
            // 
            // labelRegisterOrEdit
            // 
            this.labelRegisterOrEdit.AutoSize = true;
            this.labelRegisterOrEdit.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegisterOrEdit.ForeColor = System.Drawing.Color.White;
            this.labelRegisterOrEdit.Location = new System.Drawing.Point(216, 50);
            this.labelRegisterOrEdit.Name = "labelRegisterOrEdit";
            this.labelRegisterOrEdit.Size = new System.Drawing.Size(122, 23);
            this.labelRegisterOrEdit.TabIndex = 58;
            this.labelRegisterOrEdit.Text = "MY PROFILE";
            this.labelRegisterOrEdit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // openFileDialogUploadPicture
            // 
            this.openFileDialogUploadPicture.FileName = "openFileDialogUploadPicture";
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(200)))));
            this.buttonSaveChanges.FlatAppearance.BorderSize = 0;
            this.buttonSaveChanges.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveChanges.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveChanges.ForeColor = System.Drawing.Color.White;
            this.buttonSaveChanges.Location = new System.Drawing.Point(294, 312);
            this.buttonSaveChanges.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(149, 35);
            this.buttonSaveChanges.TabIndex = 59;
            this.buttonSaveChanges.Text = "Save Changes";
            this.buttonSaveChanges.UseVisualStyleBackColor = false;
            this.buttonSaveChanges.Visible = false;
            this.buttonSaveChanges.Click += new System.EventHandler(this.ButtonSaveChanges_Click);
            // 
            // labelUserUsername
            // 
            this.labelUserUsername.AutoSize = true;
            this.labelUserUsername.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserUsername.ForeColor = System.Drawing.Color.White;
            this.labelUserUsername.Location = new System.Drawing.Point(415, 43);
            this.labelUserUsername.Margin = new System.Windows.Forms.Padding(3, 40, 3, 0);
            this.labelUserUsername.Name = "labelUserUsername";
            this.labelUserUsername.Size = new System.Drawing.Size(0, 20);
            this.labelUserUsername.TabIndex = 60;
            // 
            // labelUserPassword
            // 
            this.labelUserPassword.AutoSize = true;
            this.labelUserPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserPassword.ForeColor = System.Drawing.Color.White;
            this.labelUserPassword.Location = new System.Drawing.Point(415, 104);
            this.labelUserPassword.Margin = new System.Windows.Forms.Padding(3, 40, 3, 0);
            this.labelUserPassword.Name = "labelUserPassword";
            this.labelUserPassword.Size = new System.Drawing.Size(0, 20);
            this.labelUserPassword.TabIndex = 61;
            // 
            // labelUserFullName
            // 
            this.labelUserFullName.AutoSize = true;
            this.labelUserFullName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserFullName.ForeColor = System.Drawing.Color.White;
            this.labelUserFullName.Location = new System.Drawing.Point(415, 164);
            this.labelUserFullName.Margin = new System.Windows.Forms.Padding(3, 40, 3, 0);
            this.labelUserFullName.Name = "labelUserFullName";
            this.labelUserFullName.Size = new System.Drawing.Size(0, 20);
            this.labelUserFullName.TabIndex = 62;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.panel1.Controls.Add(this.labelUserFullName);
            this.panel1.Controls.Add(this.pictureBoxProfile);
            this.panel1.Controls.Add(this.buttonEdit);
            this.panel1.Controls.Add(this.labelUserPassword);
            this.panel1.Controls.Add(this.labelUserUsername);
            this.panel1.Controls.Add(this.labelUsername);
            this.panel1.Controls.Add(this.labelProfilePicture);
            this.panel1.Controls.Add(this.buttonSaveChanges);
            this.panel1.Controls.Add(this.panelUsername);
            this.panel1.Controls.Add(this.panelFullName);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(this.panelPassword);
            this.panel1.Controls.Add(this.textBoxFullName);
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.textBoxUsername);
            this.panel1.Controls.Add(this.labelFullName);
            this.panel1.Controls.Add(this.buttonUploadPicture);
            this.panel1.Controls.Add(this.labelErrorMessage);
            this.panel1.Controls.Add(this.labelPassword);
            this.panel1.Location = new System.Drawing.Point(217, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 368);
            this.panel1.TabIndex = 63;
            // 
            // FormProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1080, 630);
            this.Controls.Add(this.labelRegisterOrEdit);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProfile";
            this.Text = "FormProfile";
            this.Load += new System.EventHandler(this.FormProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Panel panelUsername;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label labelErrorMessage;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Panel panelFullName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonUploadPicture;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelProfilePicture;
        private System.Windows.Forms.Label labelRegisterOrEdit;
        private System.Windows.Forms.OpenFileDialog openFileDialogUploadPicture;
        private System.Windows.Forms.Button buttonSaveChanges;
        private System.Windows.Forms.Label labelUserUsername;
        private System.Windows.Forms.Label labelUserPassword;
        private System.Windows.Forms.Label labelUserFullName;
        private System.Windows.Forms.Panel panel1;
    }
}