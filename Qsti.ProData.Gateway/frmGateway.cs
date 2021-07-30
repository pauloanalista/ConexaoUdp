using prmToolkit.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qsti.ProData.Gateway
{
    public partial class frmGateway : Form
    {
        private string _ip;
        private List<int> _portaCollection = new List<int>();
        private volatile bool _executar = false;
        CancellationTokenSource _tokenSource;
        public frmGateway()
        {
            InitializeComponent();
        }

        private void frmGateway_Load(object sender, EventArgs e)
        {
            string ouvirPortas = Configuration.GetKeyAppSettings("OuvirPortas");

            _ip = Configuration.GetKeyAppSettings("OuvirIP");
            _portaCollection.AddRange(Regex.Split(ouvirPortas, ",").Select(x => Int32.Parse(x)).ToList());
            lblOuvirPorta.Text = ouvirPortas;
            lblIp.Text = _ip;

            notifyIcon.BalloonTipTitle = "Qsti.ProData.Gateway";
            notifyIcon.BalloonTipText = ouvirPortas;
        }


        public static void SetEnabledButton(Button button, bool enabled)
        {
            button.Invoke((MethodInvoker)delegate
            {
                button.Enabled = enabled;
            });
        }

        private void SetAppendTextBox(string mensagem)
        {
            if (this.txtMensagem.InvokeRequired)
            {
                this.Invoke(new Action<string>(txtMensagem.AppendText), new object[] { mensagem });
            }
            else
            {
                txtMensagem.AppendText(mensagem);
            }
        }

        private void SetTextBox(TextBox textbox, string mensagem)
        {
            textbox.Invoke((MethodInvoker)delegate
            {
                textbox.Text = mensagem;
            });
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            _executar = true;
            _tokenSource = new CancellationTokenSource();
            var token = _tokenSource.Token;

            //Abre uma Thread Principal
            Task.Factory.StartNew(() =>
            {
                _portaCollection.ForEach(porta =>
                {

                    CancellationTokenSource tokenSourceP = new CancellationTokenSource();
                    CancellationToken tokenP = tokenSourceP.Token;

                    //Abre uma Thread por Porta
                    Task.Factory.StartNew(() =>
                    {
                        try
                        {
                            UdpClient listener = new UdpClient(porta);
                            IPEndPoint conexao = new IPEndPoint(IPAddress.Parse(_ip), porta);
                            string mensagem;
                            byte[] mensagemEmBytes;

                            while (_executar == true)
                            {
                                SetEnabledButton(btnIniciar, !_executar);
                                SetEnabledButton(btnParar, _executar);
                                mensagemEmBytes = listener.Receive(ref conexao);
                                mensagem = Encoding.ASCII.GetString(mensagemEmBytes, 0, mensagemEmBytes.Length);

                                string msg = $@"{DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss")} - {mensagem}" + "\r\n";

                                SetAppendTextBox(msg);
                            }

                            listener.Close();
                            listener.Dispose();
                        }
                        catch (Exception ex)
                        {
                            SetAppendTextBox($@"PORTA: {porta} -> {ex.Message}" + "\r\n");
                            tokenSourceP.Cancel();
                        }
                    }, token);
                });
            }, token);

        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            _executar = false;
            SetEnabledButton(btnIniciar, !_executar);
            SetEnabledButton(btnParar, _executar);

            _tokenSource.Cancel();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            SetTextBox(txtMensagem, string.Empty);
        }

        private void frmGateway_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon.Visible = true;

                notifyIcon.ShowBalloonTip(1000);
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }
    }
}
