namespace Klient
{
    partial class frmKlient
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
            this.txtOdbieranie = new System.Windows.Forms.RichTextBox();
            this.txtNrPortu = new System.Windows.Forms.TextBox();
            this.lblNrPortu = new System.Windows.Forms.Label();
            this.cmdPlacz = new System.Windows.Forms.Button();
            this.cmdWyślij = new System.Windows.Forms.Button();
            this.txtWysyłanie = new System.Windows.Forms.RichTextBox();
            this.lblLog = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.lblAdresIP = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.Polaczenie = new System.ComponentModel.BackgroundWorker();
            this.Odbieranie = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // txtOdbieranie
            // 
            this.txtOdbieranie.Location = new System.Drawing.Point(-2, -2);
            this.txtOdbieranie.Name = "txtOdbieranie";
            this.txtOdbieranie.ReadOnly = true;
            this.txtOdbieranie.Size = new System.Drawing.Size(652, 235);
            this.txtOdbieranie.TabIndex = 1;
            this.txtOdbieranie.Text = "Odbieranie";
            // 
            // txtNrPortu
            // 
            this.txtNrPortu.Location = new System.Drawing.Point(725, 52);
            this.txtNrPortu.Name = "txtNrPortu";
            this.txtNrPortu.Size = new System.Drawing.Size(123, 22);
            this.txtNrPortu.TabIndex = 9;
            this.txtNrPortu.Text = "8000";
            // 
            // lblNrPortu
            // 
            this.lblNrPortu.AutoSize = true;
            this.lblNrPortu.Location = new System.Drawing.Point(658, 55);
            this.lblNrPortu.Name = "lblNrPortu";
            this.lblNrPortu.Size = new System.Drawing.Size(61, 17);
            this.lblNrPortu.TabIndex = 8;
            this.lblNrPortu.Text = "Nr Portu";
            // 
            // cmdPlacz
            // 
            this.cmdPlacz.Location = new System.Drawing.Point(656, 80);
            this.cmdPlacz.Name = "cmdPlacz";
            this.cmdPlacz.Size = new System.Drawing.Size(86, 68);
            this.cmdPlacz.TabIndex = 10;
            this.cmdPlacz.Text = "Połącz";
            this.cmdPlacz.UseVisualStyleBackColor = true;
            this.cmdPlacz.Click += new System.EventHandler(this.cmdPlacz_Click);
            // 
            // cmdWyślij
            // 
            this.cmdWyślij.Enabled = false;
            this.cmdWyślij.Location = new System.Drawing.Point(656, 242);
            this.cmdWyślij.Name = "cmdWyślij";
            this.cmdWyślij.Size = new System.Drawing.Size(86, 68);
            this.cmdWyślij.TabIndex = 12;
            this.cmdWyślij.Text = "Wyślij";
            this.cmdWyślij.UseVisualStyleBackColor = true;
            this.cmdWyślij.Click += new System.EventHandler(this.cmdWyślij_Click);
            // 
            // txtWysyłanie
            // 
            this.txtWysyłanie.Location = new System.Drawing.Point(-2, 239);
            this.txtWysyłanie.Name = "txtWysyłanie";
            this.txtWysyłanie.Size = new System.Drawing.Size(652, 218);
            this.txtWysyłanie.TabIndex = 11;
            this.txtWysyłanie.Text = "Wysyłanie";
            this.txtWysyłanie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWysyłanie_KeyPress);
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(-5, 460);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(32, 17);
            this.lblLog.TabIndex = 14;
            this.lblLog.Text = "Log";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(-2, 480);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(652, 63);
            this.txtLog.TabIndex = 13;
            this.txtLog.Text = "Log";
            // 
            // lblAdresIP
            // 
            this.lblAdresIP.AutoSize = true;
            this.lblAdresIP.Location = new System.Drawing.Point(658, 20);
            this.lblAdresIP.Name = "lblAdresIP";
            this.lblAdresIP.Size = new System.Drawing.Size(61, 17);
            this.lblAdresIP.TabIndex = 15;
            this.lblAdresIP.Text = "Adres IP";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(726, 20);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(122, 22);
            this.txtIP.TabIndex = 16;
            // 
            // Polaczenie
            // 
            this.Polaczenie.WorkerSupportsCancellation = true;
            this.Polaczenie.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Polaczenie_DoWork);
            // 
            // Odbieranie
            // 
            this.Odbieranie.WorkerSupportsCancellation = true;
            this.Odbieranie.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Odbieranie_DoWork);
            // 
            // frmKlient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 551);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.lblAdresIP);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.cmdWyślij);
            this.Controls.Add(this.txtWysyłanie);
            this.Controls.Add(this.cmdPlacz);
            this.Controls.Add(this.txtNrPortu);
            this.Controls.Add(this.lblNrPortu);
            this.Controls.Add(this.txtOdbieranie);
            this.Name = "frmKlient";
            this.Text = "Klient";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmKlient_FormClosed);
            this.Load += new System.EventHandler(this.frmKlient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtOdbieranie;
        private System.Windows.Forms.TextBox txtNrPortu;
        private System.Windows.Forms.Label lblNrPortu;
        private System.Windows.Forms.Button cmdPlacz;
        private System.Windows.Forms.Button cmdWyślij;
        private System.Windows.Forms.RichTextBox txtWysyłanie;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Label lblAdresIP;
        private System.Windows.Forms.TextBox txtIP;
        private System.ComponentModel.BackgroundWorker Polaczenie;
        private System.ComponentModel.BackgroundWorker Odbieranie;
    }
}

