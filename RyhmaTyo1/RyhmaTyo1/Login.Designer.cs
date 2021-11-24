
namespace RyhmaTyo1
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
            this.UserTB = new ZBobb.AlphaBlendTextBox();
            this.PassTB = new ZBobb.AlphaBlendTextBox();
            this.customButton1 = new RyhmaTyo1.CustomButton();
            this.SubButton = new RyhmaTyo1.CustomButton();
            this.SuspendLayout();
            // 
            // UserTB
            // 
            this.UserTB.BackAlpha = 55;
            this.UserTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UserTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserTB.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.UserTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserTB.ForeColor = System.Drawing.Color.White;
            this.UserTB.Location = new System.Drawing.Point(147, 260);
            this.UserTB.MaxLength = 20;
            this.UserTB.Multiline = true;
            this.UserTB.Name = "UserTB";
            this.UserTB.Size = new System.Drawing.Size(235, 34);
            this.UserTB.TabIndex = 0;
            this.UserTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UserTB.Enter += new System.EventHandler(this.UserTB_Entered);
            // 
            // PassTB
            // 
            this.PassTB.BackAlpha = 55;
            this.PassTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PassTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PassTB.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.PassTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassTB.ForeColor = System.Drawing.Color.White;
            this.PassTB.Location = new System.Drawing.Point(147, 315);
            this.PassTB.MaxLength = 20;
            this.PassTB.Multiline = true;
            this.PassTB.Name = "PassTB";
            this.PassTB.PasswordChar = '●';
            this.PassTB.Size = new System.Drawing.Size(235, 34);
            this.PassTB.TabIndex = 1;
            this.PassTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PassTB.Enter += new System.EventHandler(this.PassTB_Entered);
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.Transparent;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.ForeColor = System.Drawing.Color.Transparent;
            this.customButton1.Location = new System.Drawing.Point(485, -52);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(87, 673);
            this.customButton1.TabIndex = 3;
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // SubButton
            // 
            this.SubButton.BackColor = System.Drawing.Color.Transparent;
            this.SubButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SubButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SubButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SubButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubButton.ForeColor = System.Drawing.Color.White;
            this.SubButton.Location = new System.Drawing.Point(180, 392);
            this.SubButton.Name = "SubButton";
            this.SubButton.Size = new System.Drawing.Size(166, 38);
            this.SubButton.TabIndex = 2;
            this.SubButton.Text = "Submit";
            this.SubButton.UseVisualStyleBackColor = false;
            this.SubButton.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(563, 601);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.SubButton);
            this.Controls.Add(this.PassTB);
            this.Controls.Add(this.UserTB);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZBobb.AlphaBlendTextBox UserTB;
        private ZBobb.AlphaBlendTextBox PassTB;
        private CustomButton SubButton;
        private CustomButton customButton1;
    }
}