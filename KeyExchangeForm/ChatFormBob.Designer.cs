namespace KeyExchangeForm
{
    partial class ChatFormBob
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
            this.KeyLbl = new System.Windows.Forms.Label();
            this.OpenBLbl = new System.Windows.Forms.Label();
            this.OpenALbl = new System.Windows.Forms.Label();
            this.BLbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.GLbl = new System.Windows.Forms.Label();
            this.PLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // KeyLbl
            // 
            this.KeyLbl.AutoSize = true;
            this.KeyLbl.Location = new System.Drawing.Point(12, 159);
            this.KeyLbl.Name = "KeyLbl";
            this.KeyLbl.Size = new System.Drawing.Size(61, 13);
            this.KeyLbl.TabIndex = 10;
            this.KeyLbl.Text = "Secret key:";
            // 
            // OpenBLbl
            // 
            this.OpenBLbl.AutoSize = true;
            this.OpenBLbl.Location = new System.Drawing.Point(9, 119);
            this.OpenBLbl.Name = "OpenBLbl";
            this.OpenBLbl.Size = new System.Drawing.Size(17, 13);
            this.OpenBLbl.TabIndex = 9;
            this.OpenBLbl.Text = "B:";
            // 
            // OpenALbl
            // 
            this.OpenALbl.AutoSize = true;
            this.OpenALbl.Location = new System.Drawing.Point(9, 93);
            this.OpenALbl.Name = "OpenALbl";
            this.OpenALbl.Size = new System.Drawing.Size(17, 13);
            this.OpenALbl.TabIndex = 8;
            this.OpenALbl.Text = "A:";
            // 
            // BLbl
            // 
            this.BLbl.AutoSize = true;
            this.BLbl.Location = new System.Drawing.Point(9, 62);
            this.BLbl.Name = "BLbl";
            this.BLbl.Size = new System.Drawing.Size(16, 13);
            this.BLbl.TabIndex = 7;
            this.BLbl.Text = "b:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(336, 152);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(360, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // GLbl
            // 
            this.GLbl.AutoSize = true;
            this.GLbl.Location = new System.Drawing.Point(12, 37);
            this.GLbl.Name = "GLbl";
            this.GLbl.Size = new System.Drawing.Size(18, 13);
            this.GLbl.TabIndex = 14;
            this.GLbl.Text = "G:";
            // 
            // PLbl
            // 
            this.PLbl.AutoSize = true;
            this.PLbl.Location = new System.Drawing.Point(12, 7);
            this.PLbl.Name = "PLbl";
            this.PLbl.Size = new System.Drawing.Size(17, 13);
            this.PLbl.TabIndex = 13;
            this.PLbl.Text = "P:";
            // 
            // ChatFormBob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GLbl);
            this.Controls.Add(this.PLbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.KeyLbl);
            this.Controls.Add(this.OpenBLbl);
            this.Controls.Add(this.OpenALbl);
            this.Controls.Add(this.BLbl);
            this.Name = "ChatFormBob";
            this.Text = "ChatFormBob";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label KeyLbl;
        public System.Windows.Forms.Label OpenBLbl;
        public System.Windows.Forms.Label OpenALbl;
        public System.Windows.Forms.Label BLbl;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label GLbl;
        public System.Windows.Forms.Label PLbl;
    }
}