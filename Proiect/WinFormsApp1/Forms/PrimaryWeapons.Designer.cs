namespace WinFormsApp1.Forms
{
    partial class PrimaryWeapons
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
            this.CreatePrimaryWeaponsButton = new System.Windows.Forms.Button();
            this.UpdatePrimaryWeaponsButton = new System.Windows.Forms.Button();
            this.DeletePrimaryWeaponsButton = new System.Windows.Forms.Button();
            this.CraftedPrimaryWeaponsCheckBox = new System.Windows.Forms.CheckBox();
            this.NamePrimaryWeaponsTextBox = new System.Windows.Forms.TextBox();
            this.PrimaryWeaponsGridView = new System.Windows.Forms.DataGridView();
            this.BackToWarframeTrackerFromPrimaryWeaponsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PrimaryWeaponsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CreatePrimaryWeaponsButton
            // 
            this.CreatePrimaryWeaponsButton.Location = new System.Drawing.Point(14, 448);
            this.CreatePrimaryWeaponsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CreatePrimaryWeaponsButton.Name = "CreatePrimaryWeaponsButton";
            this.CreatePrimaryWeaponsButton.Size = new System.Drawing.Size(86, 31);
            this.CreatePrimaryWeaponsButton.TabIndex = 0;
            this.CreatePrimaryWeaponsButton.Text = "Create";
            this.CreatePrimaryWeaponsButton.UseVisualStyleBackColor = true;
            this.CreatePrimaryWeaponsButton.Click += new System.EventHandler(this.CreatePrimaryWeaponsButton_Click);
            // 
            // UpdatePrimaryWeaponsButton
            // 
            this.UpdatePrimaryWeaponsButton.Location = new System.Drawing.Point(248, 448);
            this.UpdatePrimaryWeaponsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UpdatePrimaryWeaponsButton.Name = "UpdatePrimaryWeaponsButton";
            this.UpdatePrimaryWeaponsButton.Size = new System.Drawing.Size(86, 31);
            this.UpdatePrimaryWeaponsButton.TabIndex = 1;
            this.UpdatePrimaryWeaponsButton.Text = "Update";
            this.UpdatePrimaryWeaponsButton.UseVisualStyleBackColor = true;
            this.UpdatePrimaryWeaponsButton.Click += new System.EventHandler(this.UpdatePrimaryWeaponsButton_Click);
            // 
            // DeletePrimaryWeaponsButton
            // 
            this.DeletePrimaryWeaponsButton.Location = new System.Drawing.Point(489, 416);
            this.DeletePrimaryWeaponsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeletePrimaryWeaponsButton.Name = "DeletePrimaryWeaponsButton";
            this.DeletePrimaryWeaponsButton.Size = new System.Drawing.Size(86, 31);
            this.DeletePrimaryWeaponsButton.TabIndex = 2;
            this.DeletePrimaryWeaponsButton.Text = "Delete";
            this.DeletePrimaryWeaponsButton.UseVisualStyleBackColor = true;
            this.DeletePrimaryWeaponsButton.Click += new System.EventHandler(this.DeletePrimaryWeaponsButton_Click);
            // 
            // CraftedPrimaryWeaponsCheckBox
            // 
            this.CraftedPrimaryWeaponsCheckBox.AutoSize = true;
            this.CraftedPrimaryWeaponsCheckBox.Location = new System.Drawing.Point(254, 394);
            this.CraftedPrimaryWeaponsCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CraftedPrimaryWeaponsCheckBox.Name = "CraftedPrimaryWeaponsCheckBox";
            this.CraftedPrimaryWeaponsCheckBox.Size = new System.Drawing.Size(80, 24);
            this.CraftedPrimaryWeaponsCheckBox.TabIndex = 4;
            this.CraftedPrimaryWeaponsCheckBox.Text = "Crafted";
            this.CraftedPrimaryWeaponsCheckBox.UseVisualStyleBackColor = true;
            // 
            // NamePrimaryWeaponsTextBox
            // 
            this.NamePrimaryWeaponsTextBox.Location = new System.Drawing.Point(14, 391);
            this.NamePrimaryWeaponsTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NamePrimaryWeaponsTextBox.Name = "NamePrimaryWeaponsTextBox";
            this.NamePrimaryWeaponsTextBox.Size = new System.Drawing.Size(234, 27);
            this.NamePrimaryWeaponsTextBox.TabIndex = 5;
            // 
            // PrimaryWeaponsGridView
            // 
            this.PrimaryWeaponsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrimaryWeaponsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrimaryWeaponsGridView.Location = new System.Drawing.Point(14, 16);
            this.PrimaryWeaponsGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PrimaryWeaponsGridView.MultiSelect = false;
            this.PrimaryWeaponsGridView.Name = "PrimaryWeaponsGridView";
            this.PrimaryWeaponsGridView.RowHeadersWidth = 51;
            this.PrimaryWeaponsGridView.RowTemplate.Height = 25;
            this.PrimaryWeaponsGridView.Size = new System.Drawing.Size(887, 353);
            this.PrimaryWeaponsGridView.TabIndex = 6;
            // 
            // BackToWarframeTrackerFromPrimaryWeaponsButton
            // 
            this.BackToWarframeTrackerFromPrimaryWeaponsButton.Location = new System.Drawing.Point(713, 416);
            this.BackToWarframeTrackerFromPrimaryWeaponsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BackToWarframeTrackerFromPrimaryWeaponsButton.Name = "BackToWarframeTrackerFromPrimaryWeaponsButton";
            this.BackToWarframeTrackerFromPrimaryWeaponsButton.Size = new System.Drawing.Size(86, 31);
            this.BackToWarframeTrackerFromPrimaryWeaponsButton.TabIndex = 7;
            this.BackToWarframeTrackerFromPrimaryWeaponsButton.Text = "Back";
            this.BackToWarframeTrackerFromPrimaryWeaponsButton.UseVisualStyleBackColor = true;
            this.BackToWarframeTrackerFromPrimaryWeaponsButton.Click += new System.EventHandler(this.BackToWarframeTrackerFromPrimaryWeaponsButton_Click);
            // 
            // PrimaryWeapons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 488);
            this.Controls.Add(this.BackToWarframeTrackerFromPrimaryWeaponsButton);
            this.Controls.Add(this.PrimaryWeaponsGridView);
            this.Controls.Add(this.NamePrimaryWeaponsTextBox);
            this.Controls.Add(this.CraftedPrimaryWeaponsCheckBox);
            this.Controls.Add(this.DeletePrimaryWeaponsButton);
            this.Controls.Add(this.UpdatePrimaryWeaponsButton);
            this.Controls.Add(this.CreatePrimaryWeaponsButton);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PrimaryWeapons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrimaryWeapons";
            ((System.ComponentModel.ISupportInitialize)(this.PrimaryWeaponsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CreatePrimaryWeaponsButton;
        private Button UpdatePrimaryWeaponsButton;
        private Button DeletePrimaryWeaponsButton;
        private CheckBox CraftedPrimaryWeaponsCheckBox;
        private TextBox NamePrimaryWeaponsTextBox;
        private DataGridView PrimaryWeaponsGridView;
        private Button BackToWarframeTrackerFromPrimaryWeaponsButton;
    }
}