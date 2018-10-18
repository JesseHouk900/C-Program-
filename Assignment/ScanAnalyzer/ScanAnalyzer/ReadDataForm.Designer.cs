namespace ScanAnalyzer
{
    partial class ReadDataForm
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
            this.FileNameTextBox = new System.Windows.Forms.TextBox();
            this.DataFileLabel = new System.Windows.Forms.Label();
            this.StartGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FileNameTextBox
            // 
            this.FileNameTextBox.Location = new System.Drawing.Point(273, 188);
            this.FileNameTextBox.Name = "FileNameTextBox";
            this.FileNameTextBox.Size = new System.Drawing.Size(116, 24);
            this.FileNameTextBox.TabIndex = 0;
            this.FileNameTextBox.Text = "text.txt";
            // 
            // DataFileLabel
            // 
            this.DataFileLabel.AutoSize = true;
            this.DataFileLabel.Location = new System.Drawing.Point(187, 125);
            this.DataFileLabel.Name = "DataFileLabel";
            this.DataFileLabel.Size = new System.Drawing.Size(289, 15);
            this.DataFileLabel.TabIndex = 1;
            this.DataFileLabel.Text = "Enter the name of the data file you want to read from";
            // 
            // StartGameButton
            // 
            this.StartGameButton.Location = new System.Drawing.Point(286, 298);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new System.Drawing.Size(87, 27);
            this.StartGameButton.TabIndex = 2;
            this.StartGameButton.Text = "Start Game";
            this.StartGameButton.UseVisualStyleBackColor = true;
            this.StartGameButton.Click += new System.EventHandler(this.StartGameButton_Click);
            // 
            // ReadDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 420);
            this.Controls.Add(this.StartGameButton);
            this.Controls.Add(this.DataFileLabel);
            this.Controls.Add(this.FileNameTextBox);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ReadDataForm";
            this.Text = "ReadDataForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FileNameTextBox;
        private System.Windows.Forms.Label DataFileLabel;
        private System.Windows.Forms.Button StartGameButton;
    }
}