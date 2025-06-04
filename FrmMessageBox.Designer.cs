namespace WindowsFormsApp1
{
    partial class FrmMessageBox
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
            this.ShowMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShowMessage
            // 
            this.ShowMessage.Location = new System.Drawing.Point(227, 73);
            this.ShowMessage.Name = "ShowMessage";
            this.ShowMessage.Size = new System.Drawing.Size(179, 60);
            this.ShowMessage.TabIndex = 0;
            this.ShowMessage.Text = "show msg";
            this.ShowMessage.UseVisualStyleBackColor = true;
            this.ShowMessage.Click += new System.EventHandler(this.ShowMessage_Click);
            // 
            // FrmMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShowMessage);
            this.Name = "FrmMessageBox";
            this.Text = "FrmMessageBox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ShowMessage;
    }
}