namespace RatingRover.Presentation
{
    partial class VerifyDelete
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
            this.label1 = new System.Windows.Forms.Label();
            this.ConfirmDeleteButton = new System.Windows.Forms.Button();
            this.CancelDeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Are you sure you wish the delete this movie?";
            // 
            // ConfirmDeleteButton
            // 
            this.ConfirmDeleteButton.Location = new System.Drawing.Point(17, 62);
            this.ConfirmDeleteButton.Name = "ConfirmDeleteButton";
            this.ConfirmDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmDeleteButton.TabIndex = 1;
            this.ConfirmDeleteButton.Text = "Confirm";
            this.ConfirmDeleteButton.UseVisualStyleBackColor = true;
            this.ConfirmDeleteButton.Click += new System.EventHandler(this.ConfirmDeleteButton_Click);
            // 
            // CancelDeleteButton
            // 
            this.CancelDeleteButton.Location = new System.Drawing.Point(332, 62);
            this.CancelDeleteButton.Name = "CancelDeleteButton";
            this.CancelDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.CancelDeleteButton.TabIndex = 2;
            this.CancelDeleteButton.Text = "Cancel";
            this.CancelDeleteButton.UseVisualStyleBackColor = true;
            this.CancelDeleteButton.Click += new System.EventHandler(this.CancelDeleteButton_Click);
            // 
            // VerifyDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 97);
            this.Controls.Add(this.CancelDeleteButton);
            this.Controls.Add(this.ConfirmDeleteButton);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(435, 136);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(435, 136);
            this.Name = "VerifyDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VerifyDelete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ConfirmDeleteButton;
        private System.Windows.Forms.Button CancelDeleteButton;
    }
}