namespace Simple_DBase
{
    partial class Form2
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
            this.username = new System.Windows.Forms.TextBox();
            this.passcode = new System.Windows.Forms.TextBox();
            this.done_bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(300, 152);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(165, 20);
            this.username.TabIndex = 0;
            // 
            // passcode
            // 
            this.passcode.Location = new System.Drawing.Point(302, 219);
            this.passcode.Name = "passcode";
            this.passcode.Size = new System.Drawing.Size(163, 20);
            this.passcode.TabIndex = 1;
            // 
            // done_bt
            // 
            this.done_bt.Location = new System.Drawing.Point(351, 289);
            this.done_bt.Name = "done_bt";
            this.done_bt.Size = new System.Drawing.Size(75, 23);
            this.done_bt.TabIndex = 2;
            this.done_bt.Text = "Sign in";
            this.done_bt.UseVisualStyleBackColor = true;
            this.done_bt.Click += new System.EventHandler(this.done_bt_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.done_bt);
            this.Controls.Add(this.passcode);
            this.Controls.Add(this.username);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox passcode;
        private System.Windows.Forms.Button done_bt;
    }
}