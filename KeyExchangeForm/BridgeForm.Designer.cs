namespace KeyExchangeForm
{
    partial class BridgeForm
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
            this.LogPnl = new System.Windows.Forms.Panel();
            this.LogLbl = new System.Windows.Forms.Label();
            this.LogPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogPnl
            // 
            this.LogPnl.AutoScroll = true;
            this.LogPnl.Controls.Add(this.LogLbl);
            this.LogPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogPnl.Location = new System.Drawing.Point(0, 0);
            this.LogPnl.Margin = new System.Windows.Forms.Padding(4);
            this.LogPnl.Name = "LogPnl";
            this.LogPnl.Size = new System.Drawing.Size(934, 346);
            this.LogPnl.TabIndex = 0;
            // 
            // LogLbl
            // 
            this.LogLbl.AutoSize = true;
            this.LogLbl.Location = new System.Drawing.Point(8, 7);
            this.LogLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LogLbl.Name = "LogLbl";
            this.LogLbl.Size = new System.Drawing.Size(0, 19);
            this.LogLbl.TabIndex = 0;
            // 
            // BridgeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 346);
            this.Controls.Add(this.LogPnl);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BridgeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Канал связи";
            this.LogPnl.ResumeLayout(false);
            this.LogPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LogPnl;
        public System.Windows.Forms.Label LogLbl;
    }
}