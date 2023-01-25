namespace WinFormsApp1.Forms
{
    partial class Relics
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
            this.CreateRelicButton = new System.Windows.Forms.Button();
            this.UpdateRelicButton = new System.Windows.Forms.Button();
            this.DeleteRelicButton = new System.Windows.Forms.Button();
            this.BackToWarframeTrackerFromRelicsButton = new System.Windows.Forms.Button();
            this.ShowRelicsGridView = new System.Windows.Forms.DataGridView();
            this.SearchButton = new System.Windows.Forms.Button();
            this.InputForSearchTextBox = new System.Windows.Forms.TextBox();
            this.RelicNameTextBox = new System.Windows.Forms.TextBox();
            this.Common2TextBox = new System.Windows.Forms.TextBox();
            this.Common3TextBox = new System.Windows.Forms.TextBox();
            this.Uncommon2TextBox = new System.Windows.Forms.TextBox();
            this.Rare1TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Common1TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Uncommon1TextBox = new System.Windows.Forms.TextBox();
            this.ImportPartsButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ShowRelicsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateRelicButton
            // 
            this.CreateRelicButton.Location = new System.Drawing.Point(275, 508);
            this.CreateRelicButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CreateRelicButton.Name = "CreateRelicButton";
            this.CreateRelicButton.Size = new System.Drawing.Size(86, 31);
            this.CreateRelicButton.TabIndex = 0;
            this.CreateRelicButton.Text = "Create";
            this.CreateRelicButton.UseVisualStyleBackColor = true;
            this.CreateRelicButton.Click += new System.EventHandler(this.CreateRelicButton_Click);
            // 
            // UpdateRelicButton
            // 
            this.UpdateRelicButton.Location = new System.Drawing.Point(440, 508);
            this.UpdateRelicButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UpdateRelicButton.Name = "UpdateRelicButton";
            this.UpdateRelicButton.Size = new System.Drawing.Size(86, 31);
            this.UpdateRelicButton.TabIndex = 1;
            this.UpdateRelicButton.Text = "Update";
            this.UpdateRelicButton.UseVisualStyleBackColor = true;
            this.UpdateRelicButton.Click += new System.EventHandler(this.UpdateRelicButton_Click);
            // 
            // DeleteRelicButton
            // 
            this.DeleteRelicButton.Location = new System.Drawing.Point(612, 414);
            this.DeleteRelicButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeleteRelicButton.Name = "DeleteRelicButton";
            this.DeleteRelicButton.Size = new System.Drawing.Size(86, 31);
            this.DeleteRelicButton.TabIndex = 2;
            this.DeleteRelicButton.Text = "Delete";
            this.DeleteRelicButton.UseVisualStyleBackColor = true;
            this.DeleteRelicButton.Click += new System.EventHandler(this.DeleteRelicButton_Click);
            // 
            // BackToWarframeTrackerFromRelicsButton
            // 
            this.BackToWarframeTrackerFromRelicsButton.Location = new System.Drawing.Point(704, 505);
            this.BackToWarframeTrackerFromRelicsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BackToWarframeTrackerFromRelicsButton.Name = "BackToWarframeTrackerFromRelicsButton";
            this.BackToWarframeTrackerFromRelicsButton.Size = new System.Drawing.Size(86, 31);
            this.BackToWarframeTrackerFromRelicsButton.TabIndex = 3;
            this.BackToWarframeTrackerFromRelicsButton.Text = "Back";
            this.BackToWarframeTrackerFromRelicsButton.UseVisualStyleBackColor = true;
            this.BackToWarframeTrackerFromRelicsButton.Click += new System.EventHandler(this.BackToWarframeTrackerFromRelicsButton_Click);
            // 
            // ShowRelicsGridView
            // 
            this.ShowRelicsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ShowRelicsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowRelicsGridView.Location = new System.Drawing.Point(14, 16);
            this.ShowRelicsGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShowRelicsGridView.Name = "ShowRelicsGridView";
            this.ShowRelicsGridView.RowHeadersWidth = 51;
            this.ShowRelicsGridView.RowTemplate.Height = 25;
            this.ShowRelicsGridView.Size = new System.Drawing.Size(1260, 289);
            this.ShowRelicsGridView.TabIndex = 4;
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchButton.Location = new System.Drawing.Point(1078, 427);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(137, 31);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // InputForSearchTextBox
            // 
            this.InputForSearchTextBox.Location = new System.Drawing.Point(1004, 392);
            this.InputForSearchTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InputForSearchTextBox.Name = "InputForSearchTextBox";
            this.InputForSearchTextBox.Size = new System.Drawing.Size(270, 27);
            this.InputForSearchTextBox.TabIndex = 6;
            // 
            // RelicNameTextBox
            // 
            this.RelicNameTextBox.Location = new System.Drawing.Point(14, 333);
            this.RelicNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RelicNameTextBox.Name = "RelicNameTextBox";
            this.RelicNameTextBox.Size = new System.Drawing.Size(252, 27);
            this.RelicNameTextBox.TabIndex = 7;
            // 
            // Common2TextBox
            // 
            this.Common2TextBox.Location = new System.Drawing.Point(14, 451);
            this.Common2TextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Common2TextBox.Name = "Common2TextBox";
            this.Common2TextBox.Size = new System.Drawing.Size(252, 27);
            this.Common2TextBox.TabIndex = 8;
            // 
            // Common3TextBox
            // 
            this.Common3TextBox.Location = new System.Drawing.Point(14, 509);
            this.Common3TextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Common3TextBox.Name = "Common3TextBox";
            this.Common3TextBox.Size = new System.Drawing.Size(252, 27);
            this.Common3TextBox.TabIndex = 9;
            // 
            // Uncommon2TextBox
            // 
            this.Uncommon2TextBox.Location = new System.Drawing.Point(273, 392);
            this.Uncommon2TextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Uncommon2TextBox.Name = "Uncommon2TextBox";
            this.Uncommon2TextBox.Size = new System.Drawing.Size(252, 27);
            this.Uncommon2TextBox.TabIndex = 10;
            // 
            // Rare1TextBox
            // 
            this.Rare1TextBox.Location = new System.Drawing.Point(273, 449);
            this.Rare1TextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Rare1TextBox.Name = "Rare1TextBox";
            this.Rare1TextBox.Size = new System.Drawing.Size(252, 27);
            this.Rare1TextBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Common1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 427);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Common2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 485);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Common3";
            // 
            // Common1TextBox
            // 
            this.Common1TextBox.Location = new System.Drawing.Point(14, 392);
            this.Common1TextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Common1TextBox.Name = "Common1TextBox";
            this.Common1TextBox.Size = new System.Drawing.Size(252, 27);
            this.Common1TextBox.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Relic Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Uncommon1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(273, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Uncommon2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(273, 425);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Rare1";
            // 
            // Uncommon1TextBox
            // 
            this.Uncommon1TextBox.Location = new System.Drawing.Point(273, 332);
            this.Uncommon1TextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Uncommon1TextBox.Name = "Uncommon1TextBox";
            this.Uncommon1TextBox.Size = new System.Drawing.Size(252, 27);
            this.Uncommon1TextBox.TabIndex = 21;
            // 
            // ImportPartsButton
            // 
            this.ImportPartsButton.Location = new System.Drawing.Point(704, 414);
            this.ImportPartsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ImportPartsButton.Name = "ImportPartsButton";
            this.ImportPartsButton.Size = new System.Drawing.Size(86, 31);
            this.ImportPartsButton.TabIndex = 22;
            this.ImportPartsButton.Text = "Import";
            this.ImportPartsButton.UseVisualStyleBackColor = true;
            this.ImportPartsButton.Click += new System.EventHandler(this.ImportPartsButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(613, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(269, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Press Import to enter data in text boxes";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(796, 414);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(86, 31);
            this.ClearButton.TabIndex = 24;
            this.ClearButton.Text = "Clear Text";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Relics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 600);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ImportPartsButton);
            this.Controls.Add(this.Uncommon1TextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Common1TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Rare1TextBox);
            this.Controls.Add(this.Uncommon2TextBox);
            this.Controls.Add(this.Common3TextBox);
            this.Controls.Add(this.Common2TextBox);
            this.Controls.Add(this.RelicNameTextBox);
            this.Controls.Add(this.InputForSearchTextBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ShowRelicsGridView);
            this.Controls.Add(this.BackToWarframeTrackerFromRelicsButton);
            this.Controls.Add(this.DeleteRelicButton);
            this.Controls.Add(this.UpdateRelicButton);
            this.Controls.Add(this.CreateRelicButton);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Relics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relics";
            ((System.ComponentModel.ISupportInitialize)(this.ShowRelicsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CreateRelicButton;
        private Button UpdateRelicButton;
        private Button DeleteRelicButton;
        private Button BackToWarframeTrackerFromRelicsButton;
        private DataGridView ShowRelicsGridView;
        private Button SearchButton;
        private TextBox InputForSearchTextBox;
        private TextBox RelicNameTextBox;
        private TextBox Common2TextBox;
        private TextBox Common3TextBox;
        private TextBox Uncommon2TextBox;
        private TextBox Rare1TextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Common1TextBox;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox Uncommon1TextBox;
        private Button ImportPartsButton;
        private Label label8;
        private Button ClearButton;
    }
}