namespace WinFormsApp1
{
    partial class WarframeTracker
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarframeTracker));
            this.WarframesButton = new System.Windows.Forms.Button();
            this.PrimaryWeaponsButton = new System.Windows.Forms.Button();
            this.SecondaryWeaponsButton = new System.Windows.Forms.Button();
            this.MeleeWeaponsButton = new System.Windows.Forms.Button();
            this.RelicsButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // WarframesButton
            // 
            this.WarframesButton.Location = new System.Drawing.Point(12, 419);
            this.WarframesButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.WarframesButton.Name = "WarframesButton";
            this.WarframesButton.Size = new System.Drawing.Size(149, 31);
            this.WarframesButton.TabIndex = 6;
            this.WarframesButton.Text = "Warframes";
            this.WarframesButton.UseVisualStyleBackColor = true;
            this.WarframesButton.Click += new System.EventHandler(this.ShowWarframeButton_Click);
            // 
            // PrimaryWeaponsButton
            // 
            this.PrimaryWeaponsButton.Location = new System.Drawing.Point(204, 419);
            this.PrimaryWeaponsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PrimaryWeaponsButton.Name = "PrimaryWeaponsButton";
            this.PrimaryWeaponsButton.Size = new System.Drawing.Size(133, 31);
            this.PrimaryWeaponsButton.TabIndex = 7;
            this.PrimaryWeaponsButton.Text = "Primary Weapons";
            this.PrimaryWeaponsButton.UseVisualStyleBackColor = true;
            this.PrimaryWeaponsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SecondaryWeaponsButton
            // 
            this.SecondaryWeaponsButton.Location = new System.Drawing.Point(381, 419);
            this.SecondaryWeaponsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SecondaryWeaponsButton.Name = "SecondaryWeaponsButton";
            this.SecondaryWeaponsButton.Size = new System.Drawing.Size(185, 31);
            this.SecondaryWeaponsButton.TabIndex = 8;
            this.SecondaryWeaponsButton.Text = "Secondary Weapons";
            this.SecondaryWeaponsButton.UseVisualStyleBackColor = true;
            this.SecondaryWeaponsButton.Click += new System.EventHandler(this.SecondaryWeaponsButton_Click);
            // 
            // MeleeWeaponsButton
            // 
            this.MeleeWeaponsButton.Location = new System.Drawing.Point(616, 419);
            this.MeleeWeaponsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MeleeWeaponsButton.Name = "MeleeWeaponsButton";
            this.MeleeWeaponsButton.Size = new System.Drawing.Size(127, 31);
            this.MeleeWeaponsButton.TabIndex = 9;
            this.MeleeWeaponsButton.Text = "Melee Weapons";
            this.MeleeWeaponsButton.UseVisualStyleBackColor = true;
            this.MeleeWeaponsButton.Click += new System.EventHandler(this.MeleeWeaponsButton_Click);
            // 
            // RelicsButton
            // 
            this.RelicsButton.Location = new System.Drawing.Point(792, 419);
            this.RelicsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RelicsButton.Name = "RelicsButton";
            this.RelicsButton.Size = new System.Drawing.Size(110, 31);
            this.RelicsButton.TabIndex = 10;
            this.RelicsButton.Text = "Relics";
            this.RelicsButton.UseVisualStyleBackColor = true;
            this.RelicsButton.Click += new System.EventHandler(this.RelicsButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(890, 380);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // WarframeTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 474);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RelicsButton);
            this.Controls.Add(this.MeleeWeaponsButton);
            this.Controls.Add(this.SecondaryWeaponsButton);
            this.Controls.Add(this.PrimaryWeaponsButton);
            this.Controls.Add(this.WarframesButton);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "WarframeTracker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button WarframesButton;
        private Button PrimaryWeaponsButton;
        private Button SecondaryWeaponsButton;
        private Button MeleeWeaponsButton;
        private Button RelicsButton;
        private PictureBox pictureBox1;
    }
}