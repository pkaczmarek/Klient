using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using komunikaty;
using System.Net.Sockets;
using System.IO;
using System.Net;

namespace Klient
{
    public partial class frmKlient : Form
    {
        private TcpListener listener = null;
        private TcpClient klient = null;
        private bool czypoloczono = false;
        //zmienne r i w służą do odczytu i zapisu do strumienia .... 
        private BinaryReader r = null;
        private BinaryWriter w = null;
        private Stream stream;

        public frmKlient()
        {
            InitializeComponent();
        }

        private void frmKlient_Load(object sender, EventArgs e)
        {

        }


        //public void wyswietl(RichTextBox o, string tekst)
        //{
        //    //txtLog.Focus();
        //    //txtLog.AppendText(tekst);
        //    //txtLog.ScrollToCaret();
        //    //txtWysyłanie.Focus();

        //}
        delegate void WyswietlInvoker(RichTextBox o, string tekst);
        public void wyswietl(RichTextBox o, string tekst)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new WyswietlInvoker(wyswietl), new object[] {o, tekst});
                return;
            }
            else
            {
                o.Focus();
                o.AppendText(tekst);
                o.ScrollToCaret();
                txtWysyłanie.Focus();
            }
        }

        delegate void ZmienEnableInvoker(Button o, string onoff);
        public void ZmienEnable(Button o,string onoff)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new ZmienEnableInvoker(ZmienEnable), new object[] { o, onoff });
                return;
            }
            else
            {
                if(onoff =="on")   o.Enabled = true;
            }
        }




        private void Polaczenie_DoWork(object sender, DoWorkEventArgs e)
        {
            klient = new TcpClient();
            //wyswietl(txtLog, "próbuję się połączyć\n");
            klient.Connect(IPAddress.Parse(txtIP.Text), int.Parse(txtNrPortu.Text));
            wyswietl(txtLog, "Połączenie nawiązane\nŻądam zezwolenia\n");
            NetworkStream stream = klient.GetStream();
            w = new BinaryWriter(stream);
            r = new BinaryReader(stream);

            w.Write(KomunikatyKlienta.Zadaj);
            if (r.ReadString() == KomunikatySerwera.OK)
            {
                wyswietl(txtLog, "Połączono\n");
                czypoloczono = true;


                ZmienEnable(cmdWyślij, "on");
                //cmdWyślij.Enabled = true;
                Odbieranie.RunWorkerAsync();

            }
            else
            {
                wyswietl(txtLog, "Brak odpowiedzi\nRozlaczono\n");
                czypoloczono = false;
                cmdPlacz.Text = "Połącz";
                if (klient != null) klient.Close();

            }
        }

        private void cmdWyślij_Click(object sender, EventArgs e)
        {
            string tekst = txtWysyłanie.Text;
            if (tekst == "") { txtWysyłanie.Focus(); return; }
            if (tekst[tekst.Length - 1] == '\n')
                tekst = tekst.TrimEnd('\n');
            w.Write(tekst);
            wyswietl(txtOdbieranie, "===== Ja =====\n" + tekst + '\n');
            txtWysyłanie.Text = "";
        }

        private void txtWysyłanie_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmdWyślij.Enabled && e.KeyChar == (char)13)
                cmdWyślij_Click(sender, e);
        }

        private void cmdPlacz_Click(object sender, EventArgs e)
        {
            if(cmdPlacz.Text == "Połącz")
            {
                Polaczenie.RunWorkerAsync();
                cmdPlacz.Text = "Rozłącz";

            }
            else
            {
                if (czypoloczono)
                {
                    w.Write(KomunikatyKlienta.Rozlacz);
                    klient.Close();
                    czypoloczono = false;

                }
                cmdPlacz.Text = "Połącz";
                cmdWyślij.Enabled = false;
                wyswietl(txtLog, "Rozlaczono\n");
            }
        }

        private void frmKlient_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (czypoloczono)
            {
                w.Write(KomunikatyKlienta.Rozlacz);
                klient.Close();
                czypoloczono = false;

            }
            Polaczenie.CancelAsync();
            Odbieranie.CancelAsync();
        }

        delegate void ZmienTekstInvoker(Button o, string tekst);
        public void ZmienTekst(Button o, string tekst)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new ZmienTekstInvoker(ZmienEnable), new object[] { o, tekst });
                return;
            }
            else
            {
                o.Text = tekst;
            }
        }

        private void Odbieranie_DoWork(object sender, DoWorkEventArgs e)
        {
            string tekst;
            while ((tekst = r.ReadString()) != KomunikatyKlienta.Rozlacz)
            {
                wyswietl(txtOdbieranie, "===== Rozmówca =====\n" + tekst + '\n');
            }
            wyswietl(txtLog, "Rozlaczono\n");
            czypoloczono = false;
            klient.Close();
            listener.Stop();

            ZmienTekst(cmdWyślij,"Czekaj na połaczenie");
        }
    }
}
