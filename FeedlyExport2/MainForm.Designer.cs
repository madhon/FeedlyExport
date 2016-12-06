namespace FeedlyExport2
{
    partial class MainForm
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
            this.RetrieveButton = new System.Windows.Forms.Button();
            this.ContinuationtextBox = new System.Windows.Forms.TextBox();
            this.ContinuationLabel = new System.Windows.Forms.Label();
            this.CountLabel = new System.Windows.Forms.Label();
            this.CountTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RetrieveButton
            // 
            this.RetrieveButton.Location = new System.Drawing.Point(75, 80);
            this.RetrieveButton.Name = "RetrieveButton";
            this.RetrieveButton.Size = new System.Drawing.Size(75, 23);
            this.RetrieveButton.TabIndex = 0;
            this.RetrieveButton.Text = "Retrieve";
            this.RetrieveButton.UseVisualStyleBackColor = true;
            this.RetrieveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ContinuationtextBox
            // 
            this.ContinuationtextBox.Location = new System.Drawing.Point(101, 15);
            this.ContinuationtextBox.Name = "ContinuationtextBox";
            this.ContinuationtextBox.Size = new System.Drawing.Size(100, 20);
            this.ContinuationtextBox.TabIndex = 1;
            // 
            // ContinuationLabel
            // 
            this.ContinuationLabel.AutoSize = true;
            this.ContinuationLabel.Location = new System.Drawing.Point(12, 18);
            this.ContinuationLabel.Name = "ContinuationLabel";
            this.ContinuationLabel.Size = new System.Drawing.Size(83, 13);
            this.ContinuationLabel.TabIndex = 2;
            this.ContinuationLabel.Text = "Continuation ID:";
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Location = new System.Drawing.Point(12, 51);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(38, 13);
            this.CountLabel.TabIndex = 3;
            this.CountLabel.Text = "Count:";
            // 
            // CountTextBox
            // 
            this.CountTextBox.Location = new System.Drawing.Point(101, 44);
            this.CountTextBox.Name = "CountTextBox";
            this.CountTextBox.Size = new System.Drawing.Size(100, 20);
            this.CountTextBox.TabIndex = 4;
            this.CountTextBox.Text = "500";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 127);
            this.Controls.Add(this.CountTextBox);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.ContinuationLabel);
            this.Controls.Add(this.ContinuationtextBox);
            this.Controls.Add(this.RetrieveButton);
            this.Name = "MainForm";
            this.Text = "Feedly Export";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RetrieveButton;
        private System.Windows.Forms.TextBox ContinuationtextBox;
        private System.Windows.Forms.Label ContinuationLabel;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.TextBox CountTextBox;
    }
}

