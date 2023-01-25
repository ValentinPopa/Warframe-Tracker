namespace WinFormsApp1
{
    partial class Warframes
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
            this.WarframeShowGridView = new System.Windows.Forms.DataGridView();
            this.ShowPartsWarframeButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.CraftedCheckBox = new System.Windows.Forms.CheckBox();
            this.WarframeNameTextBox = new System.Windows.Forms.TextBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.BackToWarframeTrackerFromWarframeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WarframeShowGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // WarframeShowGridView
            // 
            this.WarframeShowGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.WarframeShowGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WarframeShowGridView.Location = new System.Drawing.Point(12, 13);
            this.WarframeShowGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.WarframeShowGridView.MultiSelect = false;
            this.WarframeShowGridView.Name = "WarframeShowGridView";
            this.WarframeShowGridView.RowHeadersWidth = 51;
            this.WarframeShowGridView.RowTemplate.Height = 25;
            this.WarframeShowGridView.Size = new System.Drawing.Size(880, 347);
            this.WarframeShowGridView.TabIndex = 0;
            // 
            // ShowPartsWarframeButton
            // 
            this.ShowPartsWarframeButton.Location = new System.Drawing.Point(740, 411);
            this.ShowPartsWarframeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShowPartsWarframeButton.Name = "ShowPartsWarframeButton";
            this.ShowPartsWarframeButton.Size = new System.Drawing.Size(121, 31);
            this.ShowPartsWarframeButton.TabIndex = 1;
            this.ShowPartsWarframeButton.Text = "Show Parts";
            this.ShowPartsWarframeButton.UseVisualStyleBackColor = true;
            this.ShowPartsWarframeButton.Click += new System.EventHandler(this.ShowPartsWarframeButton_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(12, 429);
            this.CreateButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(86, 31);
            this.CreateButton.TabIndex = 2;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click_1);
            // 
            // CraftedCheckBox
            // 
            this.CraftedCheckBox.AutoSize = true;
            this.CraftedCheckBox.Location = new System.Drawing.Point(263, 385);
            this.CraftedCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CraftedCheckBox.Name = "CraftedCheckBox";
            this.CraftedCheckBox.Size = new System.Drawing.Size(80, 24);
            this.CraftedCheckBox.TabIndex = 3;
            this.CraftedCheckBox.Text = "Crafted";
            this.CraftedCheckBox.UseVisualStyleBackColor = true;
            // 
            // WarframeNameTextBox
            // 
            this.WarframeNameTextBox.Location = new System.Drawing.Point(12, 385);
            this.WarframeNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.WarframeNameTextBox.Name = "WarframeNameTextBox";
            this.WarframeNameTextBox.Size = new System.Drawing.Size(245, 27);
            this.WarframeNameTextBox.TabIndex = 4;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(257, 429);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(86, 31);
            this.UpdateButton.TabIndex = 5;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(426, 411);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(86, 31);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // BackToWarframeTrackerFromWarframeButton
            // 
            this.BackToWarframeTrackerFromWarframeButton.Location = new System.Drawing.Point(576, 411);
            this.BackToWarframeTrackerFromWarframeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BackToWarframeTrackerFromWarframeButton.Name = "BackToWarframeTrackerFromWarframeButton";
            this.BackToWarframeTrackerFromWarframeButton.Size = new System.Drawing.Size(86, 31);
            this.BackToWarframeTrackerFromWarframeButton.TabIndex = 7;
            this.BackToWarframeTrackerFromWarframeButton.Text = "Back";
            this.BackToWarframeTrackerFromWarframeButton.UseVisualStyleBackColor = true;
            this.BackToWarframeTrackerFromWarframeButton.Click += new System.EventHandler(this.BackToWarframeTrackerFromWarframeButton_Click);
            // 
            // Warframes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 479);
            this.Controls.Add(this.BackToWarframeTrackerFromWarframeButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.WarframeNameTextBox);
            this.Controls.Add(this.CraftedCheckBox);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.ShowPartsWarframeButton);
            this.Controls.Add(this.WarframeShowGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Warframes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WarframeShow";
            ((System.ComponentModel.ISupportInitialize)(this.WarframeShowGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button ShowPartsWarframeButton;
        private Button CreateButton;
        private CheckBox CraftedCheckBox;
        private TextBox WarframeNameTextBox;
        private Button UpdateButton;
        private Button DeleteButton;
        private DataGridView WarframeShowGridView;
        private Button BackToWarframeTrackerFromWarframeButton;
    }
}