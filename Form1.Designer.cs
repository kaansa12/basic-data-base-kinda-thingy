namespace Simple_DBase
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
            this.add_TB = new System.Windows.Forms.TextBox();
            this.last_Added_ID_LB = new System.Windows.Forms.Label();
            this.add_BT = new System.Windows.Forms.Button();
            this.get_BT = new System.Windows.Forms.Button();
            this.get_TB = new System.Windows.Forms.TextBox();
            this.list_Box = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.sign_in_BT = new System.Windows.Forms.Button();
            this.sign_out_BT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add_TB
            // 
            this.add_TB.Location = new System.Drawing.Point(66, 212);
            this.add_TB.Name = "add_TB";
            this.add_TB.Size = new System.Drawing.Size(100, 20);
            this.add_TB.TabIndex = 0;
            this.add_TB.TextChanged += new System.EventHandler(this.add_TB_TextChanged);
            // 
            // last_Added_ID_LB
            // 
            this.last_Added_ID_LB.AutoSize = true;
            this.last_Added_ID_LB.Location = new System.Drawing.Point(93, 271);
            this.last_Added_ID_LB.Name = "last_Added_ID_LB";
            this.last_Added_ID_LB.Size = new System.Drawing.Size(35, 13);
            this.last_Added_ID_LB.TabIndex = 1;
            this.last_Added_ID_LB.Text = "label1";
            // 
            // add_BT
            // 
            this.add_BT.Location = new System.Drawing.Point(77, 311);
            this.add_BT.Name = "add_BT";
            this.add_BT.Size = new System.Drawing.Size(75, 23);
            this.add_BT.TabIndex = 2;
            this.add_BT.Text = "add";
            this.add_BT.UseVisualStyleBackColor = true;
            this.add_BT.Click += new System.EventHandler(this.add_BT_Click);
            // 
            // get_BT
            // 
            this.get_BT.Location = new System.Drawing.Point(631, 311);
            this.get_BT.Name = "get_BT";
            this.get_BT.Size = new System.Drawing.Size(75, 23);
            this.get_BT.TabIndex = 4;
            this.get_BT.Text = "get";
            this.get_BT.UseVisualStyleBackColor = true;
            this.get_BT.Click += new System.EventHandler(this.get_BT_Click);
            // 
            // get_TB
            // 
            this.get_TB.Location = new System.Drawing.Point(621, 212);
            this.get_TB.Name = "get_TB";
            this.get_TB.Size = new System.Drawing.Size(100, 20);
            this.get_TB.TabIndex = 3;
            this.get_TB.TextChanged += new System.EventHandler(this.get_TB_TextChanged);
            // 
            // list_Box
            // 
            this.list_Box.FormattingEnabled = true;
            this.list_Box.Location = new System.Drawing.Point(289, 103);
            this.list_Box.Name = "list_Box";
            this.list_Box.Size = new System.Drawing.Size(191, 290);
            this.list_Box.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(348, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "list all";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sign_in_BT
            // 
            this.sign_in_BT.Location = new System.Drawing.Point(610, 35);
            this.sign_in_BT.Name = "sign_in_BT";
            this.sign_in_BT.Size = new System.Drawing.Size(75, 23);
            this.sign_in_BT.TabIndex = 8;
            this.sign_in_BT.Text = "Sign In";
            this.sign_in_BT.UseVisualStyleBackColor = true;
            this.sign_in_BT.Click += new System.EventHandler(this.sign_in_BT_Click);
            // 
            // sign_out_BT
            // 
            this.sign_out_BT.Location = new System.Drawing.Point(713, 35);
            this.sign_out_BT.Name = "sign_out_BT";
            this.sign_out_BT.Size = new System.Drawing.Size(75, 23);
            this.sign_out_BT.TabIndex = 9;
            this.sign_out_BT.Text = "Sign Out";
            this.sign_out_BT.UseVisualStyleBackColor = true;
            this.sign_out_BT.Click += new System.EventHandler(this.sign_out_BT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sign_out_BT);
            this.Controls.Add(this.sign_in_BT);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.list_Box);
            this.Controls.Add(this.get_BT);
            this.Controls.Add(this.get_TB);
            this.Controls.Add(this.add_BT);
            this.Controls.Add(this.last_Added_ID_LB);
            this.Controls.Add(this.add_TB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox add_TB;
        private System.Windows.Forms.Label last_Added_ID_LB;
        private System.Windows.Forms.Button add_BT;
        private System.Windows.Forms.Button get_BT;
        private System.Windows.Forms.TextBox get_TB;
        private System.Windows.Forms.ListBox list_Box;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button sign_in_BT;
        private System.Windows.Forms.Button sign_out_BT;
    }
}

