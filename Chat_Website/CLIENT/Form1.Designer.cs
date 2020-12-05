namespace CLIENT
{
    partial class frmCLIENT
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
            this.btnSend = new System.Windows.Forms.Button();
            this.lsvMessage = new System.Windows.Forms.ListView();
            this.txbMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSend.Location = new System.Drawing.Point(360, 257);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(57, 45);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Gửi";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lsvMessage
            // 
            this.lsvMessage.Location = new System.Drawing.Point(28, 24);
            this.lsvMessage.Name = "lsvMessage";
            this.lsvMessage.Size = new System.Drawing.Size(389, 215);
            this.lsvMessage.TabIndex = 2;
            this.lsvMessage.UseCompatibleStateImageBehavior = false;
            this.lsvMessage.View = System.Windows.Forms.View.List;
            // 
            // txbMessage
            // 
            this.txbMessage.Location = new System.Drawing.Point(28, 257);
            this.txbMessage.Multiline = true;
            this.txbMessage.Name = "txbMessage";
            this.txbMessage.Size = new System.Drawing.Size(326, 45);
            this.txbMessage.TabIndex = 3;
            // 
            // frmCLIENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 329);
            this.Controls.Add(this.txbMessage);
            this.Controls.Add(this.lsvMessage);
            this.Controls.Add(this.btnSend);
            this.Name = "frmCLIENT";
            this.Text = "CLIENT";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCLIENT_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ListView lsvMessage;
        private System.Windows.Forms.TextBox txbMessage;
    }
}

