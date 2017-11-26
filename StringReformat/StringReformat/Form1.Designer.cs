namespace StringReformat
{
    partial class Form1
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
            this.OriginalBox = new System.Windows.Forms.TextBox();
            this.ReformattedBox = new System.Windows.Forms.TextBox();
            this.OriginalLabel = new System.Windows.Forms.Label();
            this.ReformattedLabel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OriginalBox
            // 
            this.OriginalBox.Location = new System.Drawing.Point(82, 12);
            this.OriginalBox.Name = "OriginalBox";
            this.OriginalBox.Size = new System.Drawing.Size(242, 20);
            this.OriginalBox.TabIndex = 0;
            // 
            // ReformattedBox
            // 
            this.ReformattedBox.Location = new System.Drawing.Point(82, 38);
            this.ReformattedBox.Name = "ReformattedBox";
            this.ReformattedBox.Size = new System.Drawing.Size(242, 20);
            this.ReformattedBox.TabIndex = 1;
            // 
            // OriginalLabel
            // 
            this.OriginalLabel.AutoSize = true;
            this.OriginalLabel.Location = new System.Drawing.Point(12, 15);
            this.OriginalLabel.Name = "OriginalLabel";
            this.OriginalLabel.Size = new System.Drawing.Size(42, 13);
            this.OriginalLabel.TabIndex = 2;
            this.OriginalLabel.Text = "Original";
            // 
            // ReformattedLabel
            // 
            this.ReformattedLabel.AutoSize = true;
            this.ReformattedLabel.Location = new System.Drawing.Point(12, 41);
            this.ReformattedLabel.Name = "ReformattedLabel";
            this.ReformattedLabel.Size = new System.Drawing.Size(65, 13);
            this.ReformattedLabel.TabIndex = 3;
            this.ReformattedLabel.Text = "Reformatted";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(331, 11);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 4;
            this.SubmitButton.Text = "Reformat";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 71);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.ReformattedLabel);
            this.Controls.Add(this.OriginalLabel);
            this.Controls.Add(this.ReformattedBox);
            this.Controls.Add(this.OriginalBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OriginalBox;
        private System.Windows.Forms.TextBox ReformattedBox;
        private System.Windows.Forms.Label OriginalLabel;
        private System.Windows.Forms.Label ReformattedLabel;
        private System.Windows.Forms.Button SubmitButton;
    }
}

