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
            this.GLbl = new System.Windows.Forms.Label();
            this.PLbl = new System.Windows.Forms.Label();
            this.KeyLbl = new System.Windows.Forms.Label();
            this.OpenBLbl = new System.Windows.Forms.Label();
            this.OpenALbl = new System.Windows.Forms.Label();
            this.ALbl = new System.Windows.Forms.Label();
            this.ActionTimer = new System.Windows.Forms.Timer(this.components);
            this.OutputLbl = new System.Windows.Forms.Label();
            this.DecryptBtn = new System.Windows.Forms.Button();
            this.EncryptBtn = new System.Windows.Forms.Button();
            this.InputTxtBox = new System.Windows.Forms.TextBox();
            this.HashLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GLbl
            // 
            this.GLbl.AutoSize = true;
            this.GLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GLbl.Location = new System.Drawing.Point(7, 62);
            this.GLbl.Name = "GLbl";
            this.GLbl.Size = new System.Drawing.Size(22, 16);
            this.GLbl.TabIndex = 25;
            this.GLbl.Text = "g: ";
            // 
            // PLbl
            // 
            this.PLbl.AutoSize = true;
            this.PLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PLbl.Location = new System.Drawing.Point(7, 35);
            this.PLbl.Name = "PLbl";
            this.PLbl.Size = new System.Drawing.Size(22, 16);
            this.PLbl.TabIndex = 24;
            this.PLbl.Text = "p: ";
            // 
            // KeyLbl
            // 
            this.KeyLbl.AutoSize = true;
            this.KeyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyLbl.Location = new System.Drawing.Point(7, 334);
            this.KeyLbl.Name = "KeyLbl";
            this.KeyLbl.Size = new System.Drawing.Size(125, 16);
            this.KeyLbl.TabIndex = 23;
            this.KeyLbl.Text = "Секретный ключ : ";
            // 
            // OpenBLbl
            // 
            this.OpenBLbl.AutoSize = true;
            this.OpenBLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenBLbl.Location = new System.Drawing.Point(7, 218);
            this.OpenBLbl.Name = "OpenBLbl";
            this.OpenBLbl.Size = new System.Drawing.Size(710, 32);
            this.OpenBLbl.TabIndex = 22;
            this.OpenBLbl.Text = "Число полученное после вычисления остатка от деления, от Пользователя 2, передает" +
    "ся в открытом виде\r\n B: ";
            // 
            // OpenALbl
            // 
            this.OpenALbl.AutoSize = true;
            this.OpenALbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenALbl.Location = new System.Drawing.Point(7, 156);
            this.OpenALbl.Name = "OpenALbl";
            this.OpenALbl.Size = new System.Drawing.Size(584, 32);
            this.OpenALbl.TabIndex = 21;
            this.OpenALbl.Text = "Число, полученное после вычисления остатка от деления, передается в открытом виде" +
    "\r\nA: ";
            // 
            // ALbl
            // 
            this.ALbl.AutoSize = true;
            this.ALbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ALbl.Location = new System.Drawing.Point(7, 275);
            this.ALbl.Name = "ALbl";
            this.ALbl.Size = new System.Drawing.Size(330, 32);
            this.ALbl.TabIndex = 20;
            this.ALbl.Text = "Большое случайное число, хранящееся в секрете\r\n a: ";
            // 
            // ActionTimer
            // 
            this.ActionTimer.Interval = 1500;
            this.ActionTimer.Tick += new System.EventHandler(this.ActionTimer_Tick);
            // 
            // OutputLbl
            // 
            this.OutputLbl.AutoSize = true;
            this.OutputLbl.Location = new System.Drawing.Point(773, 15);
            this.OutputLbl.Name = "OutputLbl";
            this.OutputLbl.Size = new System.Drawing.Size(0, 13);
            this.OutputLbl.TabIndex = 30;
            // 
            // DecryptBtn
            // 
            this.DecryptBtn.Location = new System.Drawing.Point(606, 109);
            this.DecryptBtn.Name = "DecryptBtn";
            this.DecryptBtn.Size = new System.Drawing.Size(105, 23);
            this.DecryptBtn.TabIndex = 29;
            this.DecryptBtn.Text = "Расшифровать";
            this.DecryptBtn.UseVisualStyleBackColor = true;
            this.DecryptBtn.Click += new System.EventHandler(this.DecryptBtn_Click);
            // 
            // EncryptBtn
            // 
            this.EncryptBtn.Location = new System.Drawing.Point(606, 80);
            this.EncryptBtn.Name = "EncryptBtn";
            this.EncryptBtn.Size = new System.Drawing.Size(167, 23);
            this.EncryptBtn.TabIndex = 28;
            this.EncryptBtn.Text = "Зашифровать и отправить";
            this.EncryptBtn.UseVisualStyleBackColor = true;
            this.EncryptBtn.Click += new System.EventHandler(this.EncryptBtn_Click);
            // 
            // InputTxtBox
            // 
            this.InputTxtBox.Location = new System.Drawing.Point(277, 12);
            this.InputTxtBox.Multiline = true;
            this.InputTxtBox.Name = "InputTxtBox";
            this.InputTxtBox.Size = new System.Drawing.Size(323, 120);
            this.InputTxtBox.TabIndex = 27;
            // 
            // HashLbl
            // 
            this.HashLbl.AutoSize = true;
            this.HashLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HashLbl.Location = new System.Drawing.Point(7, 376);
            this.HashLbl.Name = "HashLbl";
            this.HashLbl.Size = new System.Drawing.Size(98, 16);
            this.HashLbl.TabIndex = 26;
            this.HashLbl.Text = "Хэш секрета : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Пара чисел";
            // 
            // ChatFormAlice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 457);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GLbl);
            this.Controls.Add(this.PLbl);
            this.Controls.Add(this.KeyLbl);
            this.Controls.Add(this.OpenBLbl);
            this.Controls.Add(this.OpenALbl);
            this.Controls.Add(this.ALbl);
            this.Controls.Add(this.OutputLbl);
            this.Controls.Add(this.DecryptBtn);
            this.Controls.Add(this.EncryptBtn);
            this.Controls.Add(this.InputTxtBox);
            this.Controls.Add(this.HashLbl);
            this.Location = new System.Drawing.Point(25, 25);
            this.Name = "ChatFormAlice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Чат-форма пользователя 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GLbl;
        private System.Windows.Forms.Label PLbl;
        private System.Windows.Forms.Label KeyLbl;
        private System.Windows.Forms.Label OpenBLbl;
        private System.Windows.Forms.Label OpenALbl;
        private System.Windows.Forms.Label ALbl;
        private System.Windows.Forms.Timer ActionTimer;
        private System.Windows.Forms.Label OutputLbl;
        private System.Windows.Forms.Button DecryptBtn;
        private System.Windows.Forms.Button EncryptBtn;
        private System.Windows.Forms.TextBox InputTxtBox;
        private System.Windows.Forms.Label HashLbl;
        private System.Windows.Forms.Label label1;
    }
}

