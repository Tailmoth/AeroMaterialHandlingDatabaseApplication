namespace AeroMaterialHandlingDatabaseApplication
{
    partial class fLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogIn));
            this.btlogin = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPasswordErrorLogIn = new System.Windows.Forms.Label();
            this.btLoginExit = new System.Windows.Forms.Button();
            this.tbUserNameLogIn = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbPasswordLogIn = new System.Windows.Forms.TextBox();
            this.lblUserErrorLogIn = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btlogin
            // 
            this.btlogin.BackColor = System.Drawing.Color.Yellow;
            this.btlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btlogin.Location = new System.Drawing.Point(231, 159);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(84, 32);
            this.btlogin.TabIndex = 0;
            this.btlogin.Text = "Login";
            this.btlogin.UseVisualStyleBackColor = false;
            this.btlogin.Click += new System.EventHandler(this.btlogin_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblUser.Location = new System.Drawing.Point(204, 30);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(83, 20);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Username";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPasswordErrorLogIn
            // 
            this.lblPasswordErrorLogIn.AutoSize = true;
            this.lblPasswordErrorLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordErrorLogIn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblPasswordErrorLogIn.Location = new System.Drawing.Point(145, 259);
            this.lblPasswordErrorLogIn.Name = "lblPasswordErrorLogIn";
            this.lblPasswordErrorLogIn.Size = new System.Drawing.Size(201, 20);
            this.lblPasswordErrorLogIn.TabIndex = 4;
            this.lblPasswordErrorLogIn.Text = "Error: Password is incorrect";
            this.lblPasswordErrorLogIn.Visible = false;
            // 
            // btLoginExit
            // 
            this.btLoginExit.BackColor = System.Drawing.Color.Yellow;
            this.btLoginExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btLoginExit.Location = new System.Drawing.Point(332, 159);
            this.btLoginExit.Name = "btLoginExit";
            this.btLoginExit.Size = new System.Drawing.Size(79, 32);
            this.btLoginExit.TabIndex = 5;
            this.btLoginExit.Text = "Exit ";
            this.btLoginExit.UseVisualStyleBackColor = false;
            this.btLoginExit.Click += new System.EventHandler(this.btLoginExit_Click);
            // 
            // tbUserNameLogIn
            // 
            this.tbUserNameLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserNameLogIn.Location = new System.Drawing.Point(208, 53);
            this.tbUserNameLogIn.Name = "tbUserNameLogIn";
            this.tbUserNameLogIn.Size = new System.Drawing.Size(219, 29);
            this.tbUserNameLogIn.TabIndex = 6;
            this.tbUserNameLogIn.TextChanged += new System.EventHandler(this.tbUserNameLogIn_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPassword.Location = new System.Drawing.Point(204, 89);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(82, 20);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password ";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPasswordLogIn
            // 
            this.tbPasswordLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPasswordLogIn.Location = new System.Drawing.Point(208, 112);
            this.tbPasswordLogIn.Name = "tbPasswordLogIn";
            this.tbPasswordLogIn.PasswordChar = '*';
            this.tbPasswordLogIn.Size = new System.Drawing.Size(219, 29);
            this.tbPasswordLogIn.TabIndex = 9;
            // 
            // lblUserErrorLogIn
            // 
            this.lblUserErrorLogIn.AutoSize = true;
            this.lblUserErrorLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserErrorLogIn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblUserErrorLogIn.Location = new System.Drawing.Point(134, 225);
            this.lblUserErrorLogIn.Name = "lblUserErrorLogIn";
            this.lblUserErrorLogIn.Size = new System.Drawing.Size(212, 20);
            this.lblUserErrorLogIn.TabIndex = 10;
            this.lblUserErrorLogIn.Text = "Error: User Name is incorrect";
            this.lblUserErrorLogIn.Visible = false;
            this.lblUserErrorLogIn.Click += new System.EventHandler(this.lblUserError_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::AeroMaterialHandlingDatabaseApplication.Properties.Resources.Logo_Complete_Short_Hook_Transparent_300dpi_405_;
            this.pbLogo.Location = new System.Drawing.Point(24, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(164, 139);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 12;
            this.pbLogo.TabStop = false;
            // 
            // fLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(466, 208);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lblUserErrorLogIn);
            this.Controls.Add(this.tbPasswordLogIn);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.tbUserNameLogIn);
            this.Controls.Add(this.btLoginExit);
            this.Controls.Add(this.lblPasswordErrorLogIn);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btlogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.fLogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btlogin;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPasswordErrorLogIn;
        private System.Windows.Forms.Button btLoginExit;
        private System.Windows.Forms.TextBox tbUserNameLogIn;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbPasswordLogIn;
        private System.Windows.Forms.Label lblUserErrorLogIn;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}

