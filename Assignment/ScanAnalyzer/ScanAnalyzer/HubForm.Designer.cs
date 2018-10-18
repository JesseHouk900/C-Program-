namespace ScanAnalyzer
{
    partial class HubForm
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
            this.FingerPrintButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FingerPrintButton
            // 
            this.FingerPrintButton.Location = new System.Drawing.Point(43, 287);
            this.FingerPrintButton.Name = "FingerPrintButton";
            this.FingerPrintButton.Size = new System.Drawing.Size(155, 27);
            this.FingerPrintButton.TabIndex = 0;
            this.FingerPrintButton.Text = "Finger Print Analyzer";
            this.FingerPrintButton.UseVisualStyleBackColor = true;
            this.FingerPrintButton.Click += new System.EventHandler(this.FingerPrintButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(236, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 27);
            this.button2.TabIndex = 1;
            this.button2.Text = "DNA Analyzer";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(380, 287);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 27);
            this.button3.TabIndex = 2;
            this.button3.Text = "Fiber Analyzer";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(380, 61);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 27);
            this.button4.TabIndex = 3;
            this.button4.Text = "Evidence Collection";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // HubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 407);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.FingerPrintButton);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "HubForm";
            this.Text = "HubForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FingerPrintButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}