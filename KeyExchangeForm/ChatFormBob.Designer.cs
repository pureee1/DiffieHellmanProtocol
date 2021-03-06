﻿namespace KeyExchangeForm
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
            this.components = new System.ComponentModel.Container();
            this.KeyLbl = new System.Windows.Forms.Label();
            this.OpenBLbl = new System.Windows.Forms.Label();
            this.OpenALbl = new System.Windows.Forms.Label();
            this.BLbl = new System.Windows.Forms.Label();
            this.GLbl = new System.Windows.Forms.Label();
            this.PLbl = new System.Windows.Forms.Label();
            this.ActionTimer = new System.Windows.Forms.Timer(this.components);
            this.HashLbl = new System.Windows.Forms.Label();
            this.InputTxtBox = new System.Windows.Forms.TextBox();
            this.EncryptBtn = new System.Windows.Forms.Button();
            this.DecryptBtn = new System.Windows.Forms.Button();
            this.OutputLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // KeyLbl
            // 
            this.KeyLbl.AutoSize = true;
            this.KeyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyLbl.Location = new System.Drawing.Point(9, 307);
            this.KeyLbl.Name = "KeyLbl";
            this.KeyLbl.Size = new System.Drawing.Size(125, 16);
            this.KeyLbl.TabIndex = 10;
            this.KeyLbl.Text = "Секретный ключ : ";
            // 
            // OpenBLbl
            // 
            this.OpenBLbl.AutoSize = true;
            this.OpenBLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenBLbl.Location = new System.Drawing.Point(9, 195);
            this.OpenBLbl.Name = "OpenBLbl";
            this.OpenBLbl.Size = new System.Drawing.Size(584, 32);
            this.OpenBLbl.TabIndex = 9;
            this.OpenBLbl.Text = "Число, полученное после вычисления остатка от деления, передается в открытом виде" +
    "\r\nB: ";
            // 
            // OpenALbl
            // 
            this.OpenALbl.AutoSize = true;
            this.OpenALbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenALbl.Location = new System.Drawing.Point(9, 142);
            this.OpenALbl.Name = "OpenALbl";
            this.OpenALbl.Size = new System.Drawing.Size(710, 32);
            this.OpenALbl.TabIndex = 8;
            this.OpenALbl.Text = "Число полученное после вычисления остатка от деления, от Пользователя 1, передает" +
    "ся в открытом виде\r\nA: ";
            // 
            // BLbl
            // 
            this.BLbl.AutoSize = true;
            this.BLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BLbl.Location = new System.Drawing.Point(9, 250);
            this.BLbl.Name = "BLbl";
            this.BLbl.Size = new System.Drawing.Size(330, 32);
            this.BLbl.TabIndex = 7;
            this.BLbl.Text = "Большое случайное число, хранящееся в секрете\r\nb: ";
            // 
            // GLbl
            // 
            this.GLbl.AutoSize = true;
            this.GLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GLbl.Location = new System.Drawing.Point(9, 64);
            this.GLbl.Name = "GLbl";
            this.GLbl.Size = new System.Drawing.Size(22, 16);
            this.GLbl.TabIndex = 14;
            this.GLbl.Text = "g: ";
            // 
            // PLbl
            // 
            this.PLbl.AutoSize = true;
            this.PLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PLbl.Location = new System.Drawing.Point(9, 37);
            this.PLbl.Name = "PLbl";
            this.PLbl.Size = new System.Drawing.Size(22, 16);
            this.PLbl.TabIndex = 13;
            this.PLbl.Text = "p: ";
            // 
            // ActionTimer
            // 
            this.ActionTimer.Interval = 1500;
            this.ActionTimer.Tick += new System.EventHandler(this.ActionTime_Tick);
            // 
            // HashLbl
            // 
            this.HashLbl.AutoSize = true;
            this.HashLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HashLbl.Location = new System.Drawing.Point(9, 349);
            this.HashLbl.Name = "HashLbl";
            this.HashLbl.Size = new System.Drawing.Size(98, 16);
            this.HashLbl.TabIndex = 15;
            this.HashLbl.Text = "Хэш секрета : ";
            // 
            // InputTxtBox
            // 
            this.InputTxtBox.Location = new System.Drawing.Point(279, 8);
            this.InputTxtBox.Multiline = true;
            this.InputTxtBox.Name = "InputTxtBox";
            this.InputTxtBox.Size = new System.Drawing.Size(323, 120);
            this.InputTxtBox.TabIndex = 16;
            // 
            // EncryptBtn
            // 
            this.EncryptBtn.Location = new System.Drawing.Point(608, 76);
            this.EncryptBtn.Name = "EncryptBtn";
            this.EncryptBtn.Size = new System.Drawing.Size(167, 23);
            this.EncryptBtn.TabIndex = 17;
            this.EncryptBtn.Text = "Зашифровать и отправить";
            this.EncryptBtn.UseVisualStyleBackColor = true;
            this.EncryptBtn.Click += new System.EventHandler(this.EncryptBtn_Click);
            // 
            // DecryptBtn
            // 
            this.DecryptBtn.Location = new System.Drawing.Point(608, 105);
            this.DecryptBtn.Name = "DecryptBtn";
            this.DecryptBtn.Size = new System.Drawing.Size(105, 23);
            this.DecryptBtn.TabIndex = 18;
            this.DecryptBtn.Text = "Расшифровать";
            this.DecryptBtn.UseVisualStyleBackColor = true;
            this.DecryptBtn.Click += new System.EventHandler(this.DecryptBtn_Click);
            // 
            // OutputLbl
            // 
            this.OutputLbl.AutoSize = true;
            this.OutputLbl.Location = new System.Drawing.Point(719, 8);
            this.OutputLbl.Name = "OutputLbl";
            this.OutputLbl.Size = new System.Drawing.Size(0, 13);
            this.OutputLbl.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Пара чисел";
            // 
            // ChatFormBob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 465);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OutputLbl);
            this.Controls.Add(this.DecryptBtn);
            this.Controls.Add(this.EncryptBtn);
            this.Controls.Add(this.InputTxtBox);
            this.Controls.Add(this.HashLbl);
            this.Controls.Add(this.GLbl);
            this.Controls.Add(this.PLbl);
            this.Controls.Add(this.KeyLbl);
            this.Controls.Add(this.OpenBLbl);
            this.Controls.Add(this.OpenALbl);
            this.Controls.Add(this.BLbl);
            this.Location = new System.Drawing.Point(25, 750);
            this.Name = "ChatFormBob";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Чат-форма пользователя 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KeyLbl;
        private System.Windows.Forms.Label OpenBLbl;
        private System.Windows.Forms.Label OpenALbl;
        private System.Windows.Forms.Label BLbl;
        private System.Windows.Forms.Label GLbl;
        private System.Windows.Forms.Label PLbl;
        private System.Windows.Forms.Timer ActionTimer;
        private System.Windows.Forms.Label HashLbl;
        private System.Windows.Forms.TextBox InputTxtBox;
        private System.Windows.Forms.Button EncryptBtn;
        private System.Windows.Forms.Button DecryptBtn;
        private System.Windows.Forms.Label OutputLbl;
        private System.Windows.Forms.Label label1;
    }
}