namespace ScanAnalyzer
{
    partial class FindSampleGame
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
            this.NewGameButton = new System.Windows.Forms.Button();
            this.SubGuessButton = new System.Windows.Forms.Button();
            this.gridLabel = new System.Windows.Forms.Label();
            this.guessLabel = new System.Windows.Forms.Label();
            this.guessTextBoxRows = new System.Windows.Forms.TextBox();
            this.gridsizeTextBoxRow = new System.Windows.Forms.TextBox();
            this.labelRow = new System.Windows.Forms.Label();
            this.labelColumn = new System.Windows.Forms.Label();
            this.gridsizeTextBoxColumn = new System.Windows.Forms.TextBox();
            this.guessTextBoxColumn = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.counterLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewGameButton
            // 
            this.NewGameButton.Location = new System.Drawing.Point(90, 150);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(143, 27);
            this.NewGameButton.TabIndex = 0;
            this.NewGameButton.Text = "Start New Game";
            this.NewGameButton.UseVisualStyleBackColor = true;
            this.NewGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // SubGuessButton
            // 
            this.SubGuessButton.Location = new System.Drawing.Point(348, 150);
            this.SubGuessButton.Name = "SubGuessButton";
            this.SubGuessButton.Size = new System.Drawing.Size(141, 27);
            this.SubGuessButton.TabIndex = 1;
            this.SubGuessButton.Text = "Submit Guess";
            this.SubGuessButton.UseVisualStyleBackColor = true;
            this.SubGuessButton.Click += new System.EventHandler(this.SubGuessButton_Click);
            // 
            // gridLabel
            // 
            this.gridLabel.AutoSize = true;
            this.gridLabel.Location = new System.Drawing.Point(61, 50);
            this.gridLabel.Name = "gridLabel";
            this.gridLabel.Size = new System.Drawing.Size(105, 15);
            this.gridLabel.TabIndex = 2;
            this.gridLabel.Text = "Enter the Grid Size";
            // 
            // guessLabel
            // 
            this.guessLabel.AutoSize = true;
            this.guessLabel.Location = new System.Drawing.Point(61, 108);
            this.guessLabel.Name = "guessLabel";
            this.guessLabel.Size = new System.Drawing.Size(85, 15);
            this.guessLabel.TabIndex = 3;
            this.guessLabel.Text = "Enter a Guess?";
            // 
            // guessTextBoxRows
            // 
            this.guessTextBoxRows.Location = new System.Drawing.Point(269, 105);
            this.guessTextBoxRows.Name = "guessTextBoxRows";
            this.guessTextBoxRows.Size = new System.Drawing.Size(67, 24);
            this.guessTextBoxRows.TabIndex = 4;
            // 
            // gridsizeTextBoxRow
            // 
            this.gridsizeTextBoxRow.Location = new System.Drawing.Point(269, 42);
            this.gridsizeTextBoxRow.Name = "gridsizeTextBoxRow";
            this.gridsizeTextBoxRow.Size = new System.Drawing.Size(67, 24);
            this.gridsizeTextBoxRow.TabIndex = 5;
            // 
            // labelRow
            // 
            this.labelRow.AutoSize = true;
            this.labelRow.Location = new System.Drawing.Point(287, 9);
            this.labelRow.Name = "labelRow";
            this.labelRow.Size = new System.Drawing.Size(29, 15);
            this.labelRow.TabIndex = 6;
            this.labelRow.Text = "Row";
            // 
            // labelColumn
            // 
            this.labelColumn.AutoSize = true;
            this.labelColumn.Location = new System.Drawing.Point(418, 9);
            this.labelColumn.Name = "labelColumn";
            this.labelColumn.Size = new System.Drawing.Size(50, 15);
            this.labelColumn.TabIndex = 7;
            this.labelColumn.Text = "Column";
            // 
            // gridsizeTextBoxColumn
            // 
            this.gridsizeTextBoxColumn.Location = new System.Drawing.Point(406, 42);
            this.gridsizeTextBoxColumn.Name = "gridsizeTextBoxColumn";
            this.gridsizeTextBoxColumn.Size = new System.Drawing.Size(73, 24);
            this.gridsizeTextBoxColumn.TabIndex = 8;
            // 
            // guessTextBoxColumn
            // 
            this.guessTextBoxColumn.Location = new System.Drawing.Point(406, 105);
            this.guessTextBoxColumn.Name = "guessTextBoxColumn";
            this.guessTextBoxColumn.Size = new System.Drawing.Size(73, 24);
            this.guessTextBoxColumn.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(616, 50);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 362);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "1. Enter the Grid Size \r\n2. Click Start New Game\r\n3. You have 2 samples to find\r\n" +
    "3. Enter a Guess\r\n4. If your guess is right \'X\' will appear, if not hints will a" +
    "ppear\r\n\r\nGOOD LUCK!\r\n";
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Location = new System.Drawing.Point(652, 21);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(168, 15);
            this.instructionsLabel.TabIndex = 12;
            this.instructionsLabel.Text = "Instructions to play the GAME ";
            // 
            // counterLabel
            // 
            this.counterLabel.AutoSize = true;
            this.counterLabel.Location = new System.Drawing.Point(521, 10);
            this.counterLabel.Name = "counterLabel";
            this.counterLabel.Size = new System.Drawing.Size(51, 15);
            this.counterLabel.TabIndex = 13;
            this.counterLabel.Text = "Counter";
            // 
            // FindSampleGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 485);
            this.Controls.Add(this.counterLabel);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.guessTextBoxColumn);
            this.Controls.Add(this.gridsizeTextBoxColumn);
            this.Controls.Add(this.labelColumn);
            this.Controls.Add(this.labelRow);
            this.Controls.Add(this.gridsizeTextBoxRow);
            this.Controls.Add(this.guessTextBoxRows);
            this.Controls.Add(this.guessLabel);
            this.Controls.Add(this.gridLabel);
            this.Controls.Add(this.SubGuessButton);
            this.Controls.Add(this.NewGameButton);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FindSampleGame";
            this.Text = "ScanAnalyzer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewGameButton;
        private System.Windows.Forms.Button SubGuessButton;
        private System.Windows.Forms.Label gridLabel;
        private System.Windows.Forms.Label guessLabel;
        private System.Windows.Forms.TextBox guessTextBoxRows;
        private System.Windows.Forms.Label labelRow;
        private System.Windows.Forms.Label labelColumn;
        private System.Windows.Forms.TextBox guessTextBoxColumn;
        public System.Windows.Forms.TextBox gridsizeTextBoxRow;
        public System.Windows.Forms.TextBox gridsizeTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Label counterLabel;
    }
}

