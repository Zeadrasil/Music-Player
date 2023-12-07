namespace Music_Player
{
    partial class GetStringForm
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
            textBox = new TextBox();
            label = new Label();
            cancelButton = new Button();
            confirmButton = new Button();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.BackColor = SystemColors.ActiveCaptionText;
            textBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox.ForeColor = SystemColors.ButtonFace;
            textBox.Location = new Point(12, 63);
            textBox.Name = "textBox";
            textBox.Size = new Size(479, 45);
            textBox.TabIndex = 0;
            textBox.KeyDown += textBox_KeyDown;
            // 
            // label
            // 
            label.BackColor = SystemColors.ActiveCaptionText;
            label.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label.ForeColor = SystemColors.ButtonFace;
            label.Location = new Point(12, 9);
            label.Name = "label";
            label.Size = new Size(479, 38);
            label.TabIndex = 1;
            label.Text = "Enter new song name here";
            label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = SystemColors.ActiveCaptionText;
            cancelButton.ForeColor = Color.Red;
            cancelButton.Location = new Point(12, 128);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(161, 53);
            cancelButton.TabIndex = 2;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            // 
            // confirmButton
            // 
            confirmButton.BackColor = SystemColors.ActiveCaptionText;
            confirmButton.ForeColor = Color.LawnGreen;
            confirmButton.Location = new Point(330, 124);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(161, 50);
            confirmButton.TabIndex = 3;
            confirmButton.Text = "Confirm";
            confirmButton.UseVisualStyleBackColor = false;
            confirmButton.Click += confirmButton_Click;
            // 
            // GetStringForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(503, 193);
            Controls.Add(confirmButton);
            Controls.Add(cancelButton);
            Controls.Add(label);
            Controls.Add(textBox);
            Name = "GetStringForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox;
        private Label label;
        private Button cancelButton;
        private Button confirmButton;
    }
}