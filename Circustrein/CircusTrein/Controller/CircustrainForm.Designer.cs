namespace AlgoritmiekProject
{
    partial class CircustrainForm
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
            this.AnimalNameListBox = new System.Windows.Forms.ListBox();
            this.AnimalComboBox = new System.Windows.Forms.ComboBox();
            this.AnimalSelectLabel = new System.Windows.Forms.Label();
            this.SizeSelectionListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AnimalEatingLabel = new System.Windows.Forms.Label();
            this.TypeSelectionListBox = new System.Windows.Forms.ListBox();
            this.AddAnimalToTrainButton = new System.Windows.Forms.Button();
            this.AnimalsLabel = new System.Windows.Forms.Label();
            this.WagonLabel = new System.Windows.Forms.Label();
            this.WagonListBox = new System.Windows.Forms.ListBox();
            this.FillWagonsButton = new System.Windows.Forms.Button();
            this.AnimalTypeListBox = new System.Windows.Forms.ListBox();
            this.AnimalSizeListBox = new System.Windows.Forms.ListBox();
            this.AnimalsInWagonListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // AnimalNameListBox
            // 
            this.AnimalNameListBox.FormattingEnabled = true;
            this.AnimalNameListBox.Location = new System.Drawing.Point(295, 30);
            this.AnimalNameListBox.Name = "AnimalNameListBox";
            this.AnimalNameListBox.Size = new System.Drawing.Size(83, 186);
            this.AnimalNameListBox.TabIndex = 1;
            // 
            // AnimalComboBox
            // 
            this.AnimalComboBox.FormattingEnabled = true;
            this.AnimalComboBox.Location = new System.Drawing.Point(21, 30);
            this.AnimalComboBox.Name = "AnimalComboBox";
            this.AnimalComboBox.Size = new System.Drawing.Size(121, 21);
            this.AnimalComboBox.TabIndex = 2;
            // 
            // AnimalSelectLabel
            // 
            this.AnimalSelectLabel.AutoSize = true;
            this.AnimalSelectLabel.Location = new System.Drawing.Point(18, 12);
            this.AnimalSelectLabel.Name = "AnimalSelectLabel";
            this.AnimalSelectLabel.Size = new System.Drawing.Size(66, 13);
            this.AnimalSelectLabel.TabIndex = 5;
            this.AnimalSelectLabel.Text = "New Animal:";
            // 
            // SizeSelectionListBox
            // 
            this.SizeSelectionListBox.FormattingEnabled = true;
            this.SizeSelectionListBox.Items.AddRange(new object[] {
            "Small (1)",
            "Medium (3)",
            "Large (5)"});
            this.SizeSelectionListBox.Location = new System.Drawing.Point(21, 79);
            this.SizeSelectionListBox.Name = "SizeSelectionListBox";
            this.SizeSelectionListBox.Size = new System.Drawing.Size(120, 43);
            this.SizeSelectionListBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Animal Size:";
            // 
            // AnimalEatingLabel
            // 
            this.AnimalEatingLabel.AutoSize = true;
            this.AnimalEatingLabel.Location = new System.Drawing.Point(18, 138);
            this.AnimalEatingLabel.Name = "AnimalEatingLabel";
            this.AnimalEatingLabel.Size = new System.Drawing.Size(68, 13);
            this.AnimalEatingLabel.TabIndex = 9;
            this.AnimalEatingLabel.Text = "Animal Type:";
            // 
            // TypeSelectionListBox
            // 
            this.TypeSelectionListBox.FormattingEnabled = true;
            this.TypeSelectionListBox.Items.AddRange(new object[] {
            "Herbivore",
            "Carnivore"});
            this.TypeSelectionListBox.Location = new System.Drawing.Point(21, 154);
            this.TypeSelectionListBox.Name = "TypeSelectionListBox";
            this.TypeSelectionListBox.Size = new System.Drawing.Size(120, 30);
            this.TypeSelectionListBox.TabIndex = 8;
            // 
            // AddAnimalToTrainButton
            // 
            this.AddAnimalToTrainButton.Location = new System.Drawing.Point(21, 193);
            this.AddAnimalToTrainButton.Name = "AddAnimalToTrainButton";
            this.AddAnimalToTrainButton.Size = new System.Drawing.Size(121, 23);
            this.AddAnimalToTrainButton.TabIndex = 10;
            this.AddAnimalToTrainButton.Text = "Add Animal";
            this.AddAnimalToTrainButton.UseVisualStyleBackColor = true;
            this.AddAnimalToTrainButton.Click += new System.EventHandler(this.AddAnimalButton_Click);
            // 
            // AnimalsLabel
            // 
            this.AnimalsLabel.AutoSize = true;
            this.AnimalsLabel.Location = new System.Drawing.Point(162, 12);
            this.AnimalsLabel.Name = "AnimalsLabel";
            this.AnimalsLabel.Size = new System.Drawing.Size(46, 13);
            this.AnimalsLabel.TabIndex = 11;
            this.AnimalsLabel.Text = "Animals:";
            // 
            // WagonLabel
            // 
            this.WagonLabel.AutoSize = true;
            this.WagonLabel.Location = new System.Drawing.Point(394, 63);
            this.WagonLabel.Name = "WagonLabel";
            this.WagonLabel.Size = new System.Drawing.Size(50, 13);
            this.WagonLabel.TabIndex = 12;
            this.WagonLabel.Text = "Wagons:";
            // 
            // WagonListBox
            // 
            this.WagonListBox.FormattingEnabled = true;
            this.WagonListBox.Location = new System.Drawing.Point(397, 82);
            this.WagonListBox.Name = "WagonListBox";
            this.WagonListBox.Size = new System.Drawing.Size(151, 134);
            this.WagonListBox.TabIndex = 13;
            this.WagonListBox.SelectedIndexChanged += new System.EventHandler(this.WagonListBox_SelectedIndexChanged);
            // 
            // FillWagonsButton
            // 
            this.FillWagonsButton.Location = new System.Drawing.Point(397, 30);
            this.FillWagonsButton.Name = "FillWagonsButton";
            this.FillWagonsButton.Size = new System.Drawing.Size(151, 23);
            this.FillWagonsButton.TabIndex = 14;
            this.FillWagonsButton.Text = "Fill Wagons";
            this.FillWagonsButton.UseVisualStyleBackColor = true;
            this.FillWagonsButton.Click += new System.EventHandler(this.FillWagonsButton_Click);
            // 
            // AnimalTypeListBox
            // 
            this.AnimalTypeListBox.FormattingEnabled = true;
            this.AnimalTypeListBox.Location = new System.Drawing.Point(165, 30);
            this.AnimalTypeListBox.Name = "AnimalTypeListBox";
            this.AnimalTypeListBox.Size = new System.Drawing.Size(74, 186);
            this.AnimalTypeListBox.TabIndex = 15;
            // 
            // AnimalSizeListBox
            // 
            this.AnimalSizeListBox.FormattingEnabled = true;
            this.AnimalSizeListBox.Location = new System.Drawing.Point(235, 30);
            this.AnimalSizeListBox.Name = "AnimalSizeListBox";
            this.AnimalSizeListBox.Size = new System.Drawing.Size(74, 186);
            this.AnimalSizeListBox.TabIndex = 16;
            // 
            // AnimalsInWagonListBox
            // 
            this.AnimalsInWagonListBox.FormattingEnabled = true;
            this.AnimalsInWagonListBox.Location = new System.Drawing.Point(554, 82);
            this.AnimalsInWagonListBox.Name = "AnimalsInWagonListBox";
            this.AnimalsInWagonListBox.Size = new System.Drawing.Size(145, 69);
            this.AnimalsInWagonListBox.TabIndex = 17;
            // 
            // CircustrainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 236);
            this.Controls.Add(this.AnimalNameListBox);
            this.Controls.Add(this.AnimalsInWagonListBox);
            this.Controls.Add(this.AnimalSizeListBox);
            this.Controls.Add(this.AnimalTypeListBox);
            this.Controls.Add(this.FillWagonsButton);
            this.Controls.Add(this.WagonListBox);
            this.Controls.Add(this.WagonLabel);
            this.Controls.Add(this.AnimalsLabel);
            this.Controls.Add(this.AddAnimalToTrainButton);
            this.Controls.Add(this.AnimalEatingLabel);
            this.Controls.Add(this.TypeSelectionListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SizeSelectionListBox);
            this.Controls.Add(this.AnimalSelectLabel);
            this.Controls.Add(this.AnimalComboBox);
            this.Name = "CircustrainForm";
            this.Text = "Circustrain Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox AnimalNameListBox;
        private System.Windows.Forms.ComboBox AnimalComboBox;
        private System.Windows.Forms.Label AnimalSelectLabel;
        private System.Windows.Forms.ListBox SizeSelectionListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label AnimalEatingLabel;
        private System.Windows.Forms.ListBox TypeSelectionListBox;
        private System.Windows.Forms.Button AddAnimalToTrainButton;
        private System.Windows.Forms.Label AnimalsLabel;
        private System.Windows.Forms.Label WagonLabel;
        private System.Windows.Forms.ListBox WagonListBox;
        private System.Windows.Forms.Button FillWagonsButton;
        private System.Windows.Forms.ListBox AnimalTypeListBox;
        private System.Windows.Forms.ListBox AnimalSizeListBox;
        private System.Windows.Forms.ListBox AnimalsInWagonListBox;
    }
}

