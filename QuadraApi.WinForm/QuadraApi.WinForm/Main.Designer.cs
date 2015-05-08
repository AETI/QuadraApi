namespace QuadraApi.WinForm
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.loginPanel = new System.Windows.Forms.Panel();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.quadraUrlLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.quadraUrlTextBox = new System.Windows.Forms.TextBox();
            this.dataPanel = new System.Windows.Forms.Panel();
            this.itemsButton = new System.Windows.Forms.Button();
            this.vehiclesButton = new System.Windows.Forms.Button();
            this.structuresButton = new System.Windows.Forms.Button();
            this.otherButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.responseTypeComboBox = new System.Windows.Forms.ComboBox();
            this.dataTypeLabel = new System.Windows.Forms.Label();
            this.loginPanel.SuspendLayout();
            this.dataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.loginButton);
            this.loginPanel.Controls.Add(this.passwordLabel);
            this.loginPanel.Controls.Add(this.userNameLabel);
            this.loginPanel.Controls.Add(this.quadraUrlLabel);
            this.loginPanel.Controls.Add(this.passwordTextBox);
            this.loginPanel.Controls.Add(this.userNameTextBox);
            this.loginPanel.Controls.Add(this.quadraUrlTextBox);
            this.loginPanel.Location = new System.Drawing.Point(12, 12);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(660, 87);
            this.loginPanel.TabIndex = 7;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(555, 40);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 13;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(379, 23);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 12;
            this.passwordLabel.Text = "Password";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(207, 23);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(60, 13);
            this.userNameLabel.TabIndex = 11;
            this.userNameLabel.Text = "User Name";
            // 
            // quadraUrlLabel
            // 
            this.quadraUrlLabel.AutoSize = true;
            this.quadraUrlLabel.Location = new System.Drawing.Point(30, 23);
            this.quadraUrlLabel.Name = "quadraUrlLabel";
            this.quadraUrlLabel.Size = new System.Drawing.Size(58, 13);
            this.quadraUrlLabel.TabIndex = 10;
            this.quadraUrlLabel.Text = "Quadra Url";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(382, 42);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(151, 20);
            this.passwordTextBox.TabIndex = 9;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(210, 42);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(145, 20);
            this.userNameTextBox.TabIndex = 8;
            // 
            // quadraUrlTextBox
            // 
            this.quadraUrlTextBox.Location = new System.Drawing.Point(30, 42);
            this.quadraUrlTextBox.Name = "quadraUrlTextBox";
            this.quadraUrlTextBox.Size = new System.Drawing.Size(155, 20);
            this.quadraUrlTextBox.TabIndex = 7;
            this.quadraUrlTextBox.Text = "http://quadradev.aeti-inc.com";
            // 
            // dataPanel
            // 
            this.dataPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataPanel.Controls.Add(this.dataTypeLabel);
            this.dataPanel.Controls.Add(this.responseTypeComboBox);
            this.dataPanel.Controls.Add(this.itemsButton);
            this.dataPanel.Controls.Add(this.vehiclesButton);
            this.dataPanel.Controls.Add(this.structuresButton);
            this.dataPanel.Controls.Add(this.otherButton);
            this.dataPanel.Controls.Add(this.dataGridView);
            this.dataPanel.Location = new System.Drawing.Point(0, 0);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(692, 483);
            this.dataPanel.TabIndex = 8;
            this.dataPanel.Visible = false;
            // 
            // itemsButton
            // 
            this.itemsButton.Location = new System.Drawing.Point(12, 13);
            this.itemsButton.Name = "itemsButton";
            this.itemsButton.Size = new System.Drawing.Size(92, 23);
            this.itemsButton.TabIndex = 7;
            this.itemsButton.Text = "Get Items";
            this.itemsButton.UseVisualStyleBackColor = true;
            this.itemsButton.Click += new System.EventHandler(this.itemsButton_Click);
            // 
            // vehiclesButton
            // 
            this.vehiclesButton.Location = new System.Drawing.Point(306, 13);
            this.vehiclesButton.Name = "vehiclesButton";
            this.vehiclesButton.Size = new System.Drawing.Size(92, 23);
            this.vehiclesButton.TabIndex = 5;
            this.vehiclesButton.Text = "Get Vehicles";
            this.vehiclesButton.UseVisualStyleBackColor = true;
            this.vehiclesButton.Click += new System.EventHandler(this.vehiclesButton_Click);
            // 
            // structuresButton
            // 
            this.structuresButton.Location = new System.Drawing.Point(208, 13);
            this.structuresButton.Name = "structuresButton";
            this.structuresButton.Size = new System.Drawing.Size(92, 23);
            this.structuresButton.TabIndex = 4;
            this.structuresButton.Text = "Get Structures";
            this.structuresButton.UseVisualStyleBackColor = true;
            this.structuresButton.Click += new System.EventHandler(this.structuresButton_Click);
            // 
            // otherButton
            // 
            this.otherButton.Location = new System.Drawing.Point(110, 13);
            this.otherButton.Name = "otherButton";
            this.otherButton.Size = new System.Drawing.Size(92, 23);
            this.otherButton.TabIndex = 3;
            this.otherButton.Text = "Get Others";
            this.otherButton.UseVisualStyleBackColor = true;
            this.otherButton.Click += new System.EventHandler(this.otherButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 56);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(668, 415);
            this.dataGridView.TabIndex = 1;
            // 
            // responseTypeComboBox
            // 
            this.responseTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.responseTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.responseTypeComboBox.FormattingEnabled = true;
            this.responseTypeComboBox.Items.AddRange(new object[] {
            "JSON",
            "XML"});
            this.responseTypeComboBox.Location = new System.Drawing.Point(615, 15);
            this.responseTypeComboBox.Name = "responseTypeComboBox";
            this.responseTypeComboBox.Size = new System.Drawing.Size(65, 21);
            this.responseTypeComboBox.TabIndex = 8;
            // 
            // dataTypeLabel
            // 
            this.dataTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataTypeLabel.AutoSize = true;
            this.dataTypeLabel.Location = new System.Drawing.Point(538, 18);
            this.dataTypeLabel.Name = "dataTypeLabel";
            this.dataTypeLabel.Size = new System.Drawing.Size(71, 13);
            this.dataTypeLabel.TabIndex = 9;
            this.dataTypeLabel.Text = "Content Type";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 483);
            this.Controls.Add(this.dataPanel);
            this.Controls.Add(this.loginPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Quadra API";
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.dataPanel.ResumeLayout(false);
            this.dataPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label quadraUrlLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox quadraUrlTextBox;
        private System.Windows.Forms.Panel dataPanel;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button vehiclesButton;
        private System.Windows.Forms.Button structuresButton;
        private System.Windows.Forms.Button otherButton;
        private System.Windows.Forms.Button itemsButton;
        private System.Windows.Forms.ComboBox responseTypeComboBox;
        private System.Windows.Forms.Label dataTypeLabel;

    }
}

