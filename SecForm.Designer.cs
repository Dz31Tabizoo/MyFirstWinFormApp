namespace WindowsFormsApp1
{
    partial class SecForm
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
            this.BtnShowpart1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnShowpart1
            // 
            this.BtnShowpart1.Location = new System.Drawing.Point(88, 59);
            this.BtnShowpart1.Name = "BtnShowpart1";
            this.BtnShowpart1.Size = new System.Drawing.Size(147, 61);
            this.BtnShowpart1.TabIndex = 0;
            this.BtnShowpart1.Text = "Form.Show();";
            this.BtnShowpart1.UseVisualStyleBackColor = true;
            this.BtnShowpart1.Click += new System.EventHandler(this.BtnShowpart1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 61);
            this.button1.TabIndex = 1;
            this.button1.Text = "Form.Showdialog()";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SecForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnShowpart1);
            this.Name = "SecForm";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnShowpart1;
        private System.Windows.Forms.Button button1;
    }
}