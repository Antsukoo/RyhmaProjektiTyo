namespace Projekti
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.usernameTB = new ZBobb.AlphaBlendTextBox();
            this.passwordTB = new ZBobb.AlphaBlendTextBox();
            this.KirjauduBtn = new Projekti.CustomButton();
            this.SuspendLayout();
            // 
            // usernameTB
            // 
            this.usernameTB.BackAlpha = 30;
            this.usernameTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.usernameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTB.ForeColor = System.Drawing.Color.Black;
            this.usernameTB.Location = new System.Drawing.Point(169, 316);
            this.usernameTB.MaxLength = 30;
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(264, 34);
            this.usernameTB.TabIndex = 4;
            this.usernameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passwordTB
            // 
            this.passwordTB.BackAlpha = 30;
            this.passwordTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.passwordTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTB.ForeColor = System.Drawing.Color.Black;
            this.passwordTB.Location = new System.Drawing.Point(169, 366);
            this.passwordTB.MaxLength = 30;
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '●';
            this.passwordTB.Size = new System.Drawing.Size(264, 34);
            this.passwordTB.TabIndex = 5;
            this.passwordTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KirjauduBtn
            // 
            this.KirjauduBtn.BackColor = System.Drawing.Color.Transparent;
            this.KirjauduBtn.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.KirjauduBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Olive;
            this.KirjauduBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.KirjauduBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KirjauduBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KirjauduBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.KirjauduBtn.Location = new System.Drawing.Point(219, 446);
            this.KirjauduBtn.Name = "KirjauduBtn";
            this.KirjauduBtn.Size = new System.Drawing.Size(173, 54);
            this.KirjauduBtn.TabIndex = 3;
            this.KirjauduBtn.Text = "Kirjaudu";
            this.KirjauduBtn.UseVisualStyleBackColor = false;
            this.KirjauduBtn.Click += new System.EventHandler(this.kirjauduBtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(631, 708);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.usernameTB);
            this.Controls.Add(this.KirjauduBtn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomButton KirjauduBtn;
        private ZBobb.AlphaBlendTextBox usernameTB;
        private ZBobb.AlphaBlendTextBox passwordTB;
    }
}