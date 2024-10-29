namespace UE3_Schulenote
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
            label1 = new Label();
            lblNote = new Label();
            numNote = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numNote).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(474, 205);
            label1.Name = "label1";
            label1.Size = new Size(72, 32);
            label1.TabIndex = 0;
            label1.Text = "Note:";
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNote.Location = new Point(838, 203);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(34, 45);
            lblNote.TabIndex = 1;
            lblNote.Text = "?";
            lblNote.Click += lblNote_Click;
            // 
            // numNote
            // 
            numNote.Location = new Point(596, 203);
            numNote.Name = "numNote";
            numNote.Size = new Size(200, 39);
            numNote.TabIndex = 2;
            numNote.ValueChanged += numNote_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1353, 761);
            Controls.Add(numNote);
            Controls.Add(lblNote);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numNote).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblNote;
        private NumericUpDown numNote;
    }
}
