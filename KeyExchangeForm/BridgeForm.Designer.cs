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
            this.SuspendLayout();
            // 
            // LogPnl
            // 
            this.LogPnl.AutoScroll = true;
            this.LogPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogPnl.Location = new System.Drawing.Point(0, 0);
            this.LogPnl.Name = "LogPnl";
            this.LogPnl.Size = new System.Drawing.Size(800, 450);
            this.LogPnl.TabIndex = 0;
            // 
            // BridgeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LogPnl);
            this.Name = "BridgeForm";
            this.Text = "BridgeForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LogPnl;
    }
}