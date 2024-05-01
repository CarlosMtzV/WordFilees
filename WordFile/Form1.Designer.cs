namespace WordFile
{
    partial class Form1
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
            btnInsert = new Button();
            txtFile = new TextBox();
            SuspendLayout();
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(65, 295);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(102, 45);
            btnInsert.TabIndex = 0;
            btnInsert.Text = "Insert in Word File";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // txtFile
            // 
            txtFile.Location = new Point(48, 74);
            txtFile.Multiline = true;
            txtFile.Name = "txtFile";
            txtFile.Size = new Size(393, 151);
            txtFile.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtFile);
            Controls.Add(btnInsert);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInsert;
        private TextBox txtFile;
    }
}
