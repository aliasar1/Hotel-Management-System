namespace Hotel_Management_System.Screens
{
    partial class ShowDefaultScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowDefaultScreen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.passwordTextField = new Guna.UI2.WinForms.Guna2TextBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.usernameTextField = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(208, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(38, 41);
            this.panel1.TabIndex = 46;
            // 
            // passwordTextField
            // 
            this.passwordTextField.BackColor = System.Drawing.Color.Transparent;
            this.passwordTextField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.passwordTextField.BorderRadius = 20;
            this.passwordTextField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTextField.DefaultText = "";
            this.passwordTextField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordTextField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordTextField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTextField.DisabledState.Parent = this.passwordTextField;
            this.passwordTextField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTextField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTextField.FocusedState.Parent = this.passwordTextField;
            this.passwordTextField.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTextField.HoverState.Parent = this.passwordTextField;
            this.passwordTextField.IconLeft = ((System.Drawing.Image)(resources.GetObject("passwordTextField.IconLeft")));
            this.passwordTextField.Location = new System.Drawing.Point(118, 169);
            this.passwordTextField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordTextField.Name = "passwordTextField";
            this.passwordTextField.PasswordChar = '\0';
            this.passwordTextField.PlaceholderText = "";
            this.passwordTextField.ReadOnly = true;
            this.passwordTextField.SelectedText = "";
            this.passwordTextField.ShadowDecoration.Parent = this.passwordTextField;
            this.passwordTextField.Size = new System.Drawing.Size(218, 39);
            this.passwordTextField.TabIndex = 45;
            this.passwordTextField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(57, 218);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(344, 15);
            this.errorLabel.TabIndex = 44;
            this.errorLabel.Text = "Make sure to change your password when you log in first time.";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 25;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.guna2Button1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(133, 245);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 43;
            this.guna2Button1.Text = "OK";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // usernameTextField
            // 
            this.usernameTextField.BackColor = System.Drawing.Color.Transparent;
            this.usernameTextField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.usernameTextField.BorderRadius = 20;
            this.usernameTextField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTextField.DefaultText = "";
            this.usernameTextField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameTextField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameTextField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTextField.DisabledState.Parent = this.usernameTextField;
            this.usernameTextField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTextField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTextField.FocusedState.Parent = this.usernameTextField;
            this.usernameTextField.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTextField.HoverState.Parent = this.usernameTextField;
            this.usernameTextField.IconLeft = ((System.Drawing.Image)(resources.GetObject("usernameTextField.IconLeft")));
            this.usernameTextField.Location = new System.Drawing.Point(118, 120);
            this.usernameTextField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.usernameTextField.Name = "usernameTextField";
            this.usernameTextField.PasswordChar = '\0';
            this.usernameTextField.PlaceholderText = "";
            this.usernameTextField.ReadOnly = true;
            this.usernameTextField.SelectedText = "";
            this.usernameTextField.ShadowDecoration.Parent = this.usernameTextField;
            this.usernameTextField.Size = new System.Drawing.Size(218, 39);
            this.usernameTextField.TabIndex = 42;
            this.usernameTextField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.label1.Location = new System.Drawing.Point(124, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 27);
            this.label1.TabIndex = 41;
            this.label1.Text = "Account Details";
            // 
            // ShowDefaultScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(453, 302);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.passwordTextField);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.usernameTextField);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowDefaultScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowDefaultScreen";
            this.Load += new System.EventHandler(this.ShowDefaultScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox passwordTextField;
        private System.Windows.Forms.Label errorLabel;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox usernameTextField;
        private System.Windows.Forms.Label label1;
    }
}