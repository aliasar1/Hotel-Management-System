namespace Hotel_Management_System.Screens
{
    partial class DiscountScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiscountScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.discountTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.discountIdField = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameField = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.detailsFIeld = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rateCMBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.searchButton = new Guna.UI2.WinForms.Guna2Button();
            this.updateButton = new Guna.UI2.WinForms.Guna2Button();
            this.deleteButton = new Guna.UI2.WinForms.Guna2Button();
            this.addButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CircleButton2 = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.discountTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 27);
            this.label1.TabIndex = 35;
            this.label1.Text = "Discounts";
            // 
            // discountTable
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.discountTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.discountTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.discountTable.BackgroundColor = System.Drawing.Color.White;
            this.discountTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.discountTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.discountTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.discountTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.discountTable.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.discountTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.discountTable.EnableHeadersVisualStyles = false;
            this.discountTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.discountTable.Location = new System.Drawing.Point(12, 48);
            this.discountTable.Name = "discountTable";
            this.discountTable.ReadOnly = true;
            this.discountTable.RowHeadersVisible = false;
            this.discountTable.RowTemplate.Height = 35;
            this.discountTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.discountTable.Size = new System.Drawing.Size(535, 423);
            this.discountTable.TabIndex = 116;
            this.discountTable.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.discountTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.discountTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.discountTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.discountTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.discountTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.discountTable.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.discountTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.discountTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.discountTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.discountTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.discountTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.discountTable.ThemeStyle.HeaderStyle.Height = 40;
            this.discountTable.ThemeStyle.ReadOnly = true;
            this.discountTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.discountTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.discountTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.discountTable.ThemeStyle.RowsStyle.Height = 35;
            this.discountTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.discountTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.discountTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.discountTable_CellContentClick);
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.BorderThickness = 2;
            this.guna2CircleButton1.CheckedState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.CustomImages.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.HoverState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton1.Image")));
            this.guna2CircleButton1.Location = new System.Drawing.Point(672, 92);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.ShadowDecoration.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Size = new System.Drawing.Size(40, 35);
            this.guna2CircleButton1.TabIndex = 119;
            this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // discountIdField
            // 
            this.discountIdField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.discountIdField.DefaultText = "";
            this.discountIdField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.discountIdField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.discountIdField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.discountIdField.DisabledState.Parent = this.discountIdField;
            this.discountIdField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.discountIdField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.discountIdField.FocusedState.Parent = this.discountIdField;
            this.discountIdField.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountIdField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.discountIdField.HoverState.Parent = this.discountIdField;
            this.discountIdField.Location = new System.Drawing.Point(572, 97);
            this.discountIdField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.discountIdField.Name = "discountIdField";
            this.discountIdField.PasswordChar = '\0';
            this.discountIdField.PlaceholderText = "";
            this.discountIdField.ReadOnly = true;
            this.discountIdField.SelectedText = "";
            this.discountIdField.ShadowDecoration.Parent = this.discountIdField;
            this.discountIdField.Size = new System.Drawing.Size(71, 26);
            this.discountIdField.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.discountIdField.TabIndex = 118;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.label2.Location = new System.Drawing.Point(571, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 117;
            this.label2.Text = "Discount Id";
            // 
            // nameField
            // 
            this.nameField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameField.DefaultText = "";
            this.nameField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nameField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nameField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameField.DisabledState.Parent = this.nameField;
            this.nameField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameField.FocusedState.Parent = this.nameField;
            this.nameField.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameField.HoverState.Parent = this.nameField;
            this.nameField.Location = new System.Drawing.Point(572, 176);
            this.nameField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameField.Name = "nameField";
            this.nameField.PasswordChar = '\0';
            this.nameField.PlaceholderText = "";
            this.nameField.SelectedText = "";
            this.nameField.ShadowDecoration.Parent = this.nameField;
            this.nameField.Size = new System.Drawing.Size(205, 26);
            this.nameField.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.nameField.TabIndex = 121;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.label3.Location = new System.Drawing.Point(568, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 19);
            this.label3.TabIndex = 120;
            this.label3.Text = "Discount Offer Name";
            // 
            // detailsFIeld
            // 
            this.detailsFIeld.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.detailsFIeld.DefaultText = "";
            this.detailsFIeld.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.detailsFIeld.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.detailsFIeld.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.detailsFIeld.DisabledState.Parent = this.detailsFIeld;
            this.detailsFIeld.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.detailsFIeld.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.detailsFIeld.FocusedState.Parent = this.detailsFIeld;
            this.detailsFIeld.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsFIeld.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.detailsFIeld.HoverState.Parent = this.detailsFIeld;
            this.detailsFIeld.Location = new System.Drawing.Point(572, 247);
            this.detailsFIeld.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.detailsFIeld.Name = "detailsFIeld";
            this.detailsFIeld.PasswordChar = '\0';
            this.detailsFIeld.PlaceholderText = "";
            this.detailsFIeld.SelectedText = "";
            this.detailsFIeld.ShadowDecoration.Parent = this.detailsFIeld;
            this.detailsFIeld.Size = new System.Drawing.Size(205, 29);
            this.detailsFIeld.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.detailsFIeld.TabIndex = 123;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.label4.Location = new System.Drawing.Point(568, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 19);
            this.label4.TabIndex = 122;
            this.label4.Text = "Discount Details";
            // 
            // rateCMBox
            // 
            this.rateCMBox.BackColor = System.Drawing.Color.Transparent;
            this.rateCMBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.rateCMBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rateCMBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rateCMBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rateCMBox.FocusedState.Parent = this.rateCMBox;
            this.rateCMBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rateCMBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.rateCMBox.HoverState.Parent = this.rateCMBox;
            this.rateCMBox.ItemHeight = 30;
            this.rateCMBox.Items.AddRange(new object[] {
            "5",
            "10",
            "20",
            "25",
            "30",
            "40"});
            this.rateCMBox.ItemsAppearance.Parent = this.rateCMBox;
            this.rateCMBox.Location = new System.Drawing.Point(572, 323);
            this.rateCMBox.Name = "rateCMBox";
            this.rateCMBox.ShadowDecoration.Parent = this.rateCMBox;
            this.rateCMBox.Size = new System.Drawing.Size(136, 36);
            this.rateCMBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.rateCMBox.TabIndex = 125;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.label10.Location = new System.Drawing.Point(571, 303);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 19);
            this.label10.TabIndex = 124;
            this.label10.Text = "Rate (%)";
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Transparent;
            this.searchButton.BorderRadius = 17;
            this.searchButton.BorderThickness = 1;
            this.searchButton.CheckedState.Parent = this.searchButton;
            this.searchButton.CustomImages.Parent = this.searchButton;
            this.searchButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.searchButton.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.searchButton.HoverState.Parent = this.searchButton;
            this.searchButton.Location = new System.Drawing.Point(572, 436);
            this.searchButton.Name = "searchButton";
            this.searchButton.ShadowDecoration.Parent = this.searchButton;
            this.searchButton.Size = new System.Drawing.Size(90, 35);
            this.searchButton.TabIndex = 129;
            this.searchButton.Text = "CLEAR";
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.Transparent;
            this.updateButton.BorderRadius = 17;
            this.updateButton.BorderThickness = 1;
            this.updateButton.CheckedState.Parent = this.updateButton;
            this.updateButton.CustomImages.Parent = this.updateButton;
            this.updateButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.updateButton.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.updateButton.HoverState.Parent = this.updateButton;
            this.updateButton.Location = new System.Drawing.Point(698, 385);
            this.updateButton.Name = "updateButton";
            this.updateButton.ShadowDecoration.Parent = this.updateButton;
            this.updateButton.Size = new System.Drawing.Size(96, 35);
            this.updateButton.TabIndex = 128;
            this.updateButton.Text = "UPDATE";
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteButton.BorderRadius = 17;
            this.deleteButton.BorderThickness = 1;
            this.deleteButton.CheckedState.Parent = this.deleteButton;
            this.deleteButton.CustomImages.Parent = this.deleteButton;
            this.deleteButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.deleteButton.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.deleteButton.HoverState.Parent = this.deleteButton;
            this.deleteButton.Location = new System.Drawing.Point(698, 436);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.ShadowDecoration.Parent = this.deleteButton;
            this.deleteButton.Size = new System.Drawing.Size(96, 35);
            this.deleteButton.TabIndex = 127;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Transparent;
            this.addButton.BorderRadius = 17;
            this.addButton.BorderThickness = 1;
            this.addButton.CheckedState.Parent = this.addButton;
            this.addButton.CustomImages.Parent = this.addButton;
            this.addButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.addButton.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addButton.HoverState.Parent = this.addButton;
            this.addButton.Location = new System.Drawing.Point(572, 385);
            this.addButton.Name = "addButton";
            this.addButton.ShadowDecoration.Parent = this.addButton;
            this.addButton.Size = new System.Drawing.Size(90, 35);
            this.addButton.TabIndex = 126;
            this.addButton.Text = "ADD";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // guna2CircleButton2
            // 
            this.guna2CircleButton2.BorderColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton2.BorderThickness = 2;
            this.guna2CircleButton2.CheckedState.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.CustomImages.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.FillColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton2.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton2.HoverState.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton2.Image")));
            this.guna2CircleButton2.Location = new System.Drawing.Point(781, 9);
            this.guna2CircleButton2.Name = "guna2CircleButton2";
            this.guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton2.ShadowDecoration.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.Size = new System.Drawing.Size(29, 24);
            this.guna2CircleButton2.TabIndex = 130;
            this.guna2CircleButton2.Click += new System.EventHandler(this.guna2CircleButton2_Click);
            // 
            // DiscountScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(816, 483);
            this.Controls.Add(this.guna2CircleButton2);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.rateCMBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.detailsFIeld);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guna2CircleButton1);
            this.Controls.Add(this.discountIdField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.discountTable);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DiscountScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DiscountScreen";
            this.Load += new System.EventHandler(this.DiscountScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.discountTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView discountTable;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2TextBox discountIdField;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox nameField;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox detailsFIeld;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox rateCMBox;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2Button searchButton;
        private Guna.UI2.WinForms.Guna2Button updateButton;
        private Guna.UI2.WinForms.Guna2Button deleteButton;
        private Guna.UI2.WinForms.Guna2Button addButton;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton2;
    }
}