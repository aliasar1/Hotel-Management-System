namespace Hotel_Management_System.Screens
{
    partial class ResetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPassword));
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.answerField = new Guna.UI2.WinForms.Guna2TextBox();
            this.secQCMBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.verifyBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.confirmPassField = new Guna.UI2.WinForms.Guna2TextBox();
            this.newPassField = new Guna.UI2.WinForms.Guna2TextBox();
            this.changeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ImageRadioButton1 = new Guna.UI2.WinForms.Guna2ImageRadioButton();
            this.SuspendLayout();
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton1.BackgroundImage")));
            this.guna2CircleButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.guna2CircleButton1.BorderThickness = 2;
            this.guna2CircleButton1.CheckedState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.CustomImages.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.HoverState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Location = new System.Drawing.Point(359, 30);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.ShadowDecoration.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Size = new System.Drawing.Size(61, 62);
            this.guna2CircleButton1.TabIndex = 99;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.label2.Location = new System.Drawing.Point(307, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 21);
            this.label2.TabIndex = 97;
            this.label2.Text = "Reset Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.label1.Location = new System.Drawing.Point(553, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 103;
            this.label1.Text = "Answer";
            // 
            // answerField
            // 
            this.answerField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.answerField.DefaultText = "";
            this.answerField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.answerField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.answerField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.answerField.DisabledState.Parent = this.answerField;
            this.answerField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.answerField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.answerField.FocusedState.Parent = this.answerField;
            this.answerField.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.answerField.HoverState.Parent = this.answerField;
            this.answerField.Location = new System.Drawing.Point(557, 166);
            this.answerField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.answerField.Name = "answerField";
            this.answerField.PasswordChar = '\0';
            this.answerField.PlaceholderText = "";
            this.answerField.SelectedText = "";
            this.answerField.ShadowDecoration.Parent = this.answerField;
            this.answerField.Size = new System.Drawing.Size(185, 36);
            this.answerField.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.answerField.TabIndex = 102;
            // 
            // secQCMBox
            // 
            this.secQCMBox.BackColor = System.Drawing.Color.Transparent;
            this.secQCMBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.secQCMBox.BorderRadius = 20;
            this.secQCMBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.secQCMBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.secQCMBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.secQCMBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.secQCMBox.FocusedState.Parent = this.secQCMBox;
            this.secQCMBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.secQCMBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.secQCMBox.HoverState.Parent = this.secQCMBox;
            this.secQCMBox.ItemHeight = 30;
            this.secQCMBox.Items.AddRange(new object[] {
            "What city did you meet your spouse?",
            "When did you graduate in highschool?",
            "What was the model of the car you owned first?",
            "What is your favourite pet?",
            "Which street did you grow up as a kid?",
            "What is the name of the main character in your favourite movie?"});
            this.secQCMBox.ItemsAppearance.Parent = this.secQCMBox;
            this.secQCMBox.Location = new System.Drawing.Point(51, 165);
            this.secQCMBox.Name = "secQCMBox";
            this.secQCMBox.ShadowDecoration.Parent = this.secQCMBox;
            this.secQCMBox.Size = new System.Drawing.Size(462, 36);
            this.secQCMBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.secQCMBox.TabIndex = 101;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.label10.Location = new System.Drawing.Point(47, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(220, 19);
            this.label10.TabIndex = 100;
            this.label10.Text = "Select a security question.";
            // 
            // verifyBtn
            // 
            this.verifyBtn.BackColor = System.Drawing.Color.Transparent;
            this.verifyBtn.BorderColor = System.Drawing.Color.Transparent;
            this.verifyBtn.BorderRadius = 25;
            this.verifyBtn.CheckedState.Parent = this.verifyBtn;
            this.verifyBtn.CustomImages.Parent = this.verifyBtn;
            this.verifyBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.verifyBtn.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifyBtn.ForeColor = System.Drawing.Color.White;
            this.verifyBtn.HoverState.Parent = this.verifyBtn;
            this.verifyBtn.Location = new System.Drawing.Point(310, 218);
            this.verifyBtn.Name = "verifyBtn";
            this.verifyBtn.ShadowDecoration.Parent = this.verifyBtn;
            this.verifyBtn.Size = new System.Drawing.Size(180, 45);
            this.verifyBtn.TabIndex = 104;
            this.verifyBtn.Text = "Verify";
            this.verifyBtn.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.label4.Location = new System.Drawing.Point(199, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 19);
            this.label4.TabIndex = 108;
            this.label4.Text = "Confirm Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.label3.Location = new System.Drawing.Point(232, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 19);
            this.label3.TabIndex = 107;
            this.label3.Text = "New Password";
            // 
            // confirmPassField
            // 
            this.confirmPassField.BackColor = System.Drawing.Color.Transparent;
            this.confirmPassField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.confirmPassField.BorderRadius = 20;
            this.confirmPassField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.confirmPassField.DefaultText = "";
            this.confirmPassField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.confirmPassField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.confirmPassField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.confirmPassField.DisabledState.Parent = this.confirmPassField;
            this.confirmPassField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.confirmPassField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.confirmPassField.FocusedState.Parent = this.confirmPassField;
            this.confirmPassField.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPassField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.confirmPassField.HoverState.Parent = this.confirmPassField;
            this.confirmPassField.IconLeft = ((System.Drawing.Image)(resources.GetObject("confirmPassField.IconLeft")));
            this.confirmPassField.IconRight = ((System.Drawing.Image)(resources.GetObject("confirmPassField.IconRight")));
            this.confirmPassField.Location = new System.Drawing.Point(380, 330);
            this.confirmPassField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.confirmPassField.Name = "confirmPassField";
            this.confirmPassField.PasswordChar = '\0';
            this.confirmPassField.PlaceholderText = "";
            this.confirmPassField.SelectedText = "";
            this.confirmPassField.ShadowDecoration.Parent = this.confirmPassField;
            this.confirmPassField.Size = new System.Drawing.Size(218, 39);
            this.confirmPassField.TabIndex = 106;
            this.confirmPassField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.confirmPassField.UseSystemPasswordChar = true;
            this.confirmPassField.IconRightClick += new System.EventHandler(this.confirmPassField_IconRightClick);
            // 
            // newPassField
            // 
            this.newPassField.BackColor = System.Drawing.Color.Transparent;
            this.newPassField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.newPassField.BorderRadius = 20;
            this.newPassField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newPassField.DefaultText = "";
            this.newPassField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.newPassField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.newPassField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.newPassField.DisabledState.Parent = this.newPassField;
            this.newPassField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.newPassField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.newPassField.FocusedState.Parent = this.newPassField;
            this.newPassField.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPassField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.newPassField.HoverState.Parent = this.newPassField;
            this.newPassField.IconLeft = ((System.Drawing.Image)(resources.GetObject("newPassField.IconLeft")));
            this.newPassField.IconRight = ((System.Drawing.Image)(resources.GetObject("newPassField.IconRight")));
            this.newPassField.Location = new System.Drawing.Point(380, 281);
            this.newPassField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newPassField.Name = "newPassField";
            this.newPassField.PasswordChar = '\0';
            this.newPassField.PlaceholderText = "";
            this.newPassField.SelectedText = "";
            this.newPassField.ShadowDecoration.Parent = this.newPassField;
            this.newPassField.Size = new System.Drawing.Size(218, 39);
            this.newPassField.TabIndex = 105;
            this.newPassField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.newPassField.UseSystemPasswordChar = true;
            this.newPassField.IconRightClick += new System.EventHandler(this.newPassField_IconRightClick);
            // 
            // changeBtn
            // 
            this.changeBtn.BackColor = System.Drawing.Color.Transparent;
            this.changeBtn.BorderColor = System.Drawing.Color.Transparent;
            this.changeBtn.BorderRadius = 25;
            this.changeBtn.CheckedState.Parent = this.changeBtn;
            this.changeBtn.CustomImages.Parent = this.changeBtn;
            this.changeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.changeBtn.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeBtn.ForeColor = System.Drawing.Color.White;
            this.changeBtn.HoverState.Parent = this.changeBtn;
            this.changeBtn.Location = new System.Drawing.Point(317, 377);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.ShadowDecoration.Parent = this.changeBtn;
            this.changeBtn.Size = new System.Drawing.Size(180, 45);
            this.changeBtn.TabIndex = 109;
            this.changeBtn.Text = "Change Password";
            this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click);
            // 
            // guna2ImageRadioButton1
            // 
            this.guna2ImageRadioButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageRadioButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2ImageRadioButton1.BackgroundImage")));
            this.guna2ImageRadioButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.guna2ImageRadioButton1.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageRadioButton1.CheckedState.Image")));
            this.guna2ImageRadioButton1.CheckedState.Parent = this.guna2ImageRadioButton1;
            this.guna2ImageRadioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ImageRadioButton1.HoverState.Parent = this.guna2ImageRadioButton1;
            this.guna2ImageRadioButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageRadioButton1.Image")));
            this.guna2ImageRadioButton1.IndicateFocus = false;
            this.guna2ImageRadioButton1.Location = new System.Drawing.Point(764, 12);
            this.guna2ImageRadioButton1.Name = "guna2ImageRadioButton1";
            this.guna2ImageRadioButton1.PressedState.Parent = this.guna2ImageRadioButton1;
            this.guna2ImageRadioButton1.Size = new System.Drawing.Size(24, 24);
            this.guna2ImageRadioButton1.TabIndex = 110;
            this.guna2ImageRadioButton1.CheckedChanged += new System.EventHandler(this.guna2ImageRadioButton1_CheckedChanged);
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2ImageRadioButton1);
            this.Controls.Add(this.changeBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.confirmPassField);
            this.Controls.Add(this.newPassField);
            this.Controls.Add(this.verifyBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.answerField);
            this.Controls.Add(this.secQCMBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.guna2CircleButton1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResetPassword";
            this.Load += new System.EventHandler(this.ResetPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox answerField;
        private Guna.UI2.WinForms.Guna2ComboBox secQCMBox;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2Button verifyBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox confirmPassField;
        private Guna.UI2.WinForms.Guna2TextBox newPassField;
        private Guna.UI2.WinForms.Guna2Button changeBtn;
        private Guna.UI2.WinForms.Guna2ImageRadioButton guna2ImageRadioButton1;
    }
}