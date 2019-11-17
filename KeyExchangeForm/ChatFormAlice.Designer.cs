namespace KeyExchangeForm
{
    partial class ChatFormAlice
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.PLbl = new System.Windows.Forms.Label();
            this.GLbl = new System.Windows.Forms.Label();
            this.ALbl = new System.Windows.Forms.Label();
            this.OpenALbl = new System.Windows.Forms.Label();
            this.OpenBLbl = new System.Windows.Forms.Label();
            this.KeyLbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ActionTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(655, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PLbl
            // 
            this.PLbl.AutoSize = true;
            this.PLbl.Location = new System.Drawing.Point(12, 9);
            this.PLbl.Name = "PLbl";
            this.PLbl.Size = new System.Drawing.Size(17, 13);
            this.PLbl.TabIndex = 1;
            this.PLbl.Text = "P:";
            // 
            // GLbl
            // 
            this.GLbl.AutoSize = true;
            this.GLbl.Location = new System.Drawing.Point(12, 39);
            this.GLbl.Name = "GLbl";
            this.GLbl.Size = new System.Drawing.Size(18, 13);
            this.GLbl.TabIndex = 2;
            this.GLbl.Text = "G:";
            // 
            // ALbl
            // 
            this.ALbl.AutoSize = true;
            this.ALbl.Location = new System.Drawing.Point(12, 68);
            this.ALbl.Name = "ALbl";
            this.ALbl.Size = new System.Drawing.Size(16, 13);
            this.ALbl.TabIndex = 3;
            this.ALbl.Text = "a:";
            // 
            // OpenALbl
            // 
            this.OpenALbl.AutoSize = true;
            this.OpenALbl.Location = new System.Drawing.Point(12, 99);
            this.OpenALbl.Name = "OpenALbl";
            this.OpenALbl.Size = new System.Drawing.Size(17, 13);
            this.OpenALbl.TabIndex = 4;
            this.OpenALbl.Text = "A:";
            // 
            // OpenBLbl
            // 
            this.OpenBLbl.AutoSize = true;
            this.OpenBLbl.Location = new System.Drawing.Point(12, 125);
            this.OpenBLbl.Name = "OpenBLbl";
            this.OpenBLbl.Size = new System.Drawing.Size(17, 13);
            this.OpenBLbl.TabIndex = 5;
            this.OpenBLbl.Text = "B:";
            // 
            // KeyLbl
            // 
            this.KeyLbl.AutoSize = true;
            this.KeyLbl.Location = new System.Drawing.Point(15, 165);
            this.KeyLbl.Name = "KeyLbl";
            this.KeyLbl.Size = new System.Drawing.Size(61, 13);
            this.KeyLbl.TabIndex = 6;
            this.KeyLbl.Text = "Secret key:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(579, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // ActionTimer
            // 
            this.ActionTimer.Tick += new System.EventHandler(this.ActionTimer_Tick);
            // 
            // ChatFormAlice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.KeyLbl);
            this.Controls.Add(this.OpenBLbl);
            this.Controls.Add(this.OpenALbl);
            this.Controls.Add(this.ALbl);
            this.Controls.Add(this.GLbl);
            this.Controls.Add(this.PLbl);
            this.Controls.Add(this.button1);
            this.Name = "ChatFormAlice";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label PLbl;
        private System.Windows.Forms.Label GLbl;
        private System.Windows.Forms.Label ALbl;
        private System.Windows.Forms.Label OpenALbl;
        private System.Windows.Forms.Label OpenBLbl;
        private System.Windows.Forms.Label KeyLbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer ActionTimer;
    }
}

