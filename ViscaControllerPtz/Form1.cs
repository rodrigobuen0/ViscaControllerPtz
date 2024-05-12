using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Net;
using System.Threading;
using WebSocketSharp.Server;
using WebSocketSharp;
using ViscaControllerPtz.Properties;

namespace ViscaControllerPtz
{
    public partial class Form1 : Form
    {
        private HttpListener _listener;
        private Thread _serverThread;
        private NotifyIcon _notifyIcon;
        private ContextMenuStrip _contextMenuStrip;

        public Form1()
        {
            string[] availablePorts = SerialPort.GetPortNames();

            InitializeComponent();
            _notifyIcon = new NotifyIcon();
            _notifyIcon.Icon = Properties.Resources.icon1;
            _notifyIcon.Text = "Ptz Controller";
            _notifyIcon.Visible = true;

            _contextMenuStrip = new ContextMenuStrip();
            _contextMenuStrip.Items.Add("Abrir", null, NotifyIcon_MouseDoubleClick);
            _contextMenuStrip.Items.Add("Finalizar", null, CloseMenuItem_Click);

            _notifyIcon.ContextMenuStrip = _contextMenuStrip;
            _notifyIcon.MouseDoubleClick += NotifyIcon_MouseDoubleClick;

            _listener = new HttpListener();
            var wssv = new WebSocketServer("ws://127.0.0.1:8081");
            wssv.AddWebSocketService<MyWebSocketService>("/Commands");
            wssv.Start();
            _listener.Prefixes.Add("http://localhost:8080/");
            this.comboBox1.Items.AddRange(availablePorts);
            if (!string.IsNullOrEmpty(Properties.Settings.Default.PortaCom))
            {
                loadData();
                if (this.serialPort1.IsOpen == false)
                {
                    try
                    {
                        this.serialPort1.StopBits = StopBits.One;
                        this.serialPort1.DataBits = 8;
                        this.serialPort1.BaudRate = 9600;
                        this.serialPort1.PortName = this.comboBox1.Text;
                        this.serialPort1.Open();
                        this.button1.Text = "Fechar porta serial";
                    }
                    catch (UnauthorizedAccessException)
                    {
                        MessageBox.Show("Acesso negado à porta!");
                    }
                    catch (InvalidOperationException)
                    {
                        MessageBox.Show("A porta especificada já está aberta!");
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Esta porta está em um estado inválido");
                    }
                }
                else
                {
                    this.serialPort1.Close();
                    this.button1.Text = "Abrir porta serial";
                }
            }


        }
        public class MyWebSocketService : WebSocketBehavior
        {
            protected override void OnMessage(MessageEventArgs e)
            {
                try
                {
                    byte[] bytesRecebidos = e.RawData;
                    string jsonString = Encoding.UTF8.GetString(bytesRecebidos);

                    Form1 form = Application.OpenForms["Form1"] as Form1;
                    if (form != null)
                        form.ProcessarMensagem(jsonString);
                }
                catch (Exception ex)
                {
                    Context.WebSocket.Close();
                    MessageBox.Show($"ERRO: {ex.Message}");
                    Context.WebSocket.Close();
                }
            }
        }
        private void CloseMenuItem_Click(object sender, EventArgs e)
        {
            if (_listener != null && _listener.IsListening)
            {
                _listener.Stop();
            }
            Environment.Exit(0);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;

            this.Hide();
        }
        private void NotifyIcon_MouseDoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }
        public void ProcessarMensagem(string mensagem)
        {
            switch (mensagem)
            {
                case "stop":
                    {
                        ExecuteOnUIThread(() => PararMovimento());
                    }
                    break;
                case "stopzoom":
                    {
                        ExecuteOnUIThread(() => PararMovimentoZoom());
                    }
                    break;
                case "up":
                    ExecuteOnUIThread(() => btnUp_MouseDown(null, null));
                    break;
                case "down":
                    ExecuteOnUIThread(() => btnDown_MouseDown(null, null));
                    break;
                case "left":
                    ExecuteOnUIThread(() => btnLeft_MouseDown(null, null));
                    break;
                case "right":
                    ExecuteOnUIThread(() => btnRight_MouseDown(null, null));
                    break;
                case "home":
                    ExecuteOnUIThread(() => button23_Click(null, null));
                    break;
                case "preset1":
                    ExecuteOnUIThread(() => button13_Click(null, null));
                    break;
                case "preset2":
                    ExecuteOnUIThread(() => button16_Click(null, null));
                    break;
                case "preset3":
                    ExecuteOnUIThread(() => button15_Click(null, null));
                    break;
                case "preset4":
                    ExecuteOnUIThread(() => button14_Click(null, null));
                    break;
                case "preset5":
                    ExecuteOnUIThread(() => button20_Click(null, null));
                    break;
                case "preset6":
                    ExecuteOnUIThread(() => button17_Click(null, null));
                    break;
                case "preset7":
                    ExecuteOnUIThread(() => button18_Click(null, null));
                    break;
                case "preset8":
                    ExecuteOnUIThread(() => button19_Click(null, null));
                    break;
                case "zoomin":
                    ExecuteOnUIThread(() => btnZoomMais_MouseDown(null, null));
                    break;
                case "zoomout":
                    ExecuteOnUIThread(() => btnZoomMenos_MouseDown(null, null));
                    break;
            }
        }
        private void ExecuteOnUIThread(Action action)
        {
            if (InvokeRequired)
            {
                Invoke(action);
            }
            else
            {
                action();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _serverThread = new Thread(StartServer);
            _serverThread.Start();
        }

        private void StartServer()
        {
            try
            {
                _listener.Start();
                while (_listener.IsListening)
                {
                    HttpListenerContext context = _listener.GetContext();
                    ProcessRequest(context);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao iniciar o servidor: " + ex.Message);
            }
        }

        

        private void ProcessRequest(HttpListenerContext context)
        {
            string responseString = Properties.Resources.HTMLPage1;
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
            context.Response.ContentType = "text/html";
            context.Response.ContentLength64 = buffer.Length;
            context.Response.OutputStream.Write(buffer, 0, buffer.Length);
            context.Response.OutputStream.Close();
        }
        private void loadData()
        {
            this.comboBox1.Text = Properties.Settings.Default.PortaCom;
            this.trackBar1.Value = int.Parse(Properties.Settings.Default.PanSpeed);
            this.trackBar2.Value = int.Parse(Properties.Settings.Default.TiltSpeed);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.serialPort1.IsOpen == false)
            {
                try
                {
                    this.serialPort1.StopBits = StopBits.One;
                    this.serialPort1.DataBits = 8;
                    this.serialPort1.BaudRate = 9600;
                    this.serialPort1.PortName = this.comboBox1.Text;
                    this.serialPort1.Open();
                    this.button1.Text = "Fechar porta serial";
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("Acesso negado à porta!");
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("A porta especificada já está aberta!");
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Esta porta está em um estado inválido");
                }
            }
            else
            {
                this.serialPort1.Close();
                this.button1.Text = "Abrir porta serial";
            }

        }

        private void btnUp_MouseDown(object sender, MouseEventArgs e)
        {
            EnviarComandoContinuo(new byte[] { 0x81, 0x01, 0x06, 0x01, 0x00, Convert.ToByte(trackBar2.Value.ToString()), 0x03, 0x01, 0xff });
        }

        private async void btnUp_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                await Task.Delay(100);
                PararMovimento();
            }

        }

        private void btnDown_MouseDown(object sender, MouseEventArgs e)
        {
            EnviarComandoContinuo(new byte[] { 0x81, 0x01, 0x06, 0x01, 0x00, Convert.ToByte(trackBar2.Value.ToString()), 0x03, 0x02, 0xff });
        }

        private async void btnDown_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                await Task.Delay(100);
                PararMovimento();
            }
        }

        private void btnLeft_MouseDown(object sender, MouseEventArgs e)
        {
            EnviarComandoContinuo(new byte[] { 0x81, 0x01, 0x06, 0x01, Convert.ToByte(trackBar1.Value.ToString()), 0x00, 0x01, 0x03, 0xff });
        }

        private async void btnLeft_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                await Task.Delay(100);
                PararMovimento();
            }
        }

        private void btnRight_MouseDown(object sender, MouseEventArgs e)
        {
            EnviarComandoContinuo(new byte[] { 0x81, 0x01, 0x06, 0x01, Convert.ToByte(trackBar1.Value.ToString()), 0x00, 0x02, 0x03, 0xff });
        }

        private async void btnRight_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                await Task.Delay(100);
                PararMovimento();
            }
        }

        private void EnviarComandoContinuo(byte[] comando)
        {
            this.serialPort1.Write(comando, 0, comando.Length);
        }

        private void PararMovimento()
        {
            byte[] buff_stop = { 0x81, 0x01, 0x06, 0x01, 0x00, 0x05, 0x03, 0x03, 0xff };
            this.serialPort1.Write(buff_stop, 0, buff_stop.Length);
            this.textBox1.Text = "Parado";
        }
        private void PararMovimentoZoom()
        {
            byte[] buff_stop = { 0x81, 0x01, 0x04, 0x07, 0x00, 0xff };
            this.serialPort1.Write(buff_stop, 0, buff_stop.Length);
            this.textBox1.Text = "Parado";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            byte[] buff_stop = { 0x81, 0x01, 0x06, 0x01, 0x00, 0x05, 0x03, 0x03, 0xff };
            this.serialPort1.Write(buff_stop, 0, buff_stop.Length);
            this.textBox1.Text = "Dados enviados com sucesso";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            byte[] buff_poweron = { 0x81, 0x01, 0x04, 0x00, 0x02, 0xff };
            this.serialPort1.Write(buff_poweron, 0, buff_poweron.Length);
            this.textBox1.Text = "Dados enviados com sucesso";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            byte[] buff_poweroff = { 0x81, 0x01, 0x04, 0x00, 0x03, 0xff };
            this.serialPort1.Write(buff_poweroff, 0, buff_poweroff.Length);
            this.textBox1.Text = "Dados enviados com sucesso";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            byte[] buff = { 0x81, 0x09, 0x06, 0x12, 0xff };
            this.serialPort1.Write(buff, 0, buff.Length);
            this.textBox1.Text = "Dados enviados com sucesso";
        }

        private void OnRevData(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] inputBuff = new byte[20];
            try
            {
                for (int ii = 0; ii < 20; ii++)
                {

                    inputBuff[ii] = (byte)this.serialPort1.ReadByte();
                    if (inputBuff[ii] == 0xff)
                    {
                        this.serialPort1.DiscardInBuffer();
                        this.Invoke((MethodInvoker)delegate
                        {
                            this.textBox1.Text = "Dados recebidos com sucesso!";
                            this.textBox1.Text = byteToHexStr(inputBuff);
                        });
                        return;
                    }

                }
            }
            catch (TimeoutException)
            {
                this.textBox1.Text = "Tempo limite de recebimento!";
            }
        }

        public static string byteToHexStr(byte[] bytes)
        {
            string returnStr = "";
            if (bytes != null)
            {
                for (int i = 0; i < bytes.Length; i++)
                {
                    returnStr += bytes[i].ToString("X2");
                    if (bytes[i] == 0xff) return returnStr;
                    returnStr += " ";
                }
            }
            return returnStr;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            byte[] buff = { 0x81, 0x01, 0x04, 0x07, 0x00, 0xff };
            this.serialPort1.Write(buff, 0, buff.Length);
            this.textBox1.Text = "Dados enviados com sucesso";
        }

        private void btnZoomMais_MouseDown(object sender, MouseEventArgs e)
        {
            EnviarComandoContinuo(new byte[] { 0x81, 0x01, 0x04, 0x07, 0x24, 0xff });
        }

        private async void btnZoomMais_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                await Task.Delay(100);
                byte[] buff = { 0x81, 0x01, 0x04, 0x07, 0x00, 0xff };
                this.serialPort1.Write(buff, 0, buff.Length);
            }
        }
        private void btnZoomMenos_MouseDown(object sender, MouseEventArgs e)
        {
            EnviarComandoContinuo(new byte[] { 0x81, 0x01, 0x04, 0x07, 0x34, 0xff });
        }

        private async void btnZoomMenos_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                await Task.Delay(100);
                byte[] buff = { 0x81, 0x01, 0x04, 0x07, 0x00, 0xff };
                this.serialPort1.Write(buff, 0, buff.Length);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            byte[] buff = { 0x81, 0x01, 0x04, 0x3F, 0x02, 0x01, 0xFF };
            this.serialPort1.Write(buff, 0, buff.Length);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            byte[] buff = { 0x81, 0x01, 0x04, 0x3F, 0x02, 0x02, 0xFF };
            this.serialPort1.Write(buff, 0, buff.Length);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            byte[] buff = { 0x81, 0x01, 0x04, 0x3F, 0x02, 0x03, 0xFF };
            this.serialPort1.Write(buff, 0, buff.Length);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            byte[] buff = { 0x81, 0x01, 0x04, 0x3F, 0x02, 0x04, 0xFF };
            this.serialPort1.Write(buff, 0, buff.Length);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            byte[] buff = { 0x81, 0x01, 0x04, 0x3F, 0x02, 0x05, 0xFF };
            this.serialPort1.Write(buff, 0, buff.Length);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            byte[] buff = { 0x81, 0x01, 0x04, 0x3F, 0x02, 0x06, 0xFF };
            this.serialPort1.Write(buff, 0, buff.Length);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            byte[] buff = { 0x81, 0x01, 0x04, 0x3F, 0x02, 0x07, 0xFF };
            this.serialPort1.Write(buff, 0, buff.Length);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            byte[] buff = { 0x81, 0x01, 0x04, 0x3F, 0x02, 0x08, 0xFF };
            this.serialPort1.Write(buff, 0, buff.Length);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //comboBox2.SelectedText;
            //SALVAR PRESET
            byte[] buff = { 0x81, 0x01, 0x04, 0x3F, 0x01, Convert.ToByte(comboBox2.SelectedItem.ToString()), 0xFF };
            this.serialPort1.Write(buff, 0, buff.Length);
            comboBox2.SelectedIndex = -1;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            //EXCLUIR PRESET
            byte[] buff = { 0x81, 0x01, 0x04, 0x3F, 0x00, Convert.ToByte(comboBox2.SelectedItem.ToString()), 0xFF };
            this.serialPort1.Write(buff, 0, buff.Length);
            comboBox2.SelectedIndex = -1;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            byte[] buff = { 0x81, 0x01, 0x06, 0x04, 0xFF };
            this.serialPort1.Write(buff, 0, buff.Length);
        }

        private void btnTopRight_Click(object sender, EventArgs e)
        {
            byte[] buff = { 0x81, 0x01, 0x06, 0x01, Convert.ToByte(trackBar1.Value.ToString()), Convert.ToByte(trackBar2.Value.ToString()), 0x02, 0x01, 0xFF };
            this.serialPort1.Write(buff, 0, buff.Length);

        }

        private void btnDownRight_Click(object sender, EventArgs e)
        {
            byte[] buff = { 0x81, 0x01, 0x06, 0x01, Convert.ToByte(trackBar1.Value.ToString()), Convert.ToByte(trackBar2.Value.ToString()), 0x02, 0x02, 0xFF };
            this.serialPort1.Write(buff, 0, buff.Length);
        }

        private void btnTopLeft_Click(object sender, EventArgs e)
        {
            byte[] buff = { 0x81, 0x01, 0x06, 0x01, Convert.ToByte(trackBar1.Value.ToString()), Convert.ToByte(trackBar2.Value.ToString()), 0x01, 0x01, 0xFF };
            this.serialPort1.Write(buff, 0, buff.Length);
        }

        private void btnDownLeft_Click(object sender, EventArgs e)
        {
            byte[] buff = { 0x81, 0x01, 0x06, 0x01, Convert.ToByte(trackBar1.Value.ToString()), Convert.ToByte(trackBar2.Value.ToString()), 0x01, 0x02, 0xFF };
            this.serialPort1.Write(buff, 0, buff.Length);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default["PortaCom"] = comboBox1.SelectedItem.ToString();
            Properties.Settings.Default.Save();
        }

        private void trackBar1_MouseLeave(object sender, EventArgs e)
        {
            Properties.Settings.Default["PanSpeed"] = trackBar1.Value.ToString();
            Properties.Settings.Default.Save();
        }

        private void trackBar2_MouseLeave(object sender, EventArgs e)
        {
            Properties.Settings.Default["TiltSpeed"] = trackBar2.Value.ToString();
            Properties.Settings.Default.Save();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            byte[] buff = { 0x81, 0x01, 0x06, 0x06, 0x02, 0xFF };
            this.serialPort1.Write(buff, 0, buff.Length);
        }

        private void btnFocusAuto_Click(object sender, EventArgs e)
        {
            byte[] buff = { 0x81, 0x01, 0x04, 0x38, 0x02, 0xFF };
            this.serialPort1.Write(buff, 0, buff.Length);
        }

        private void btnFocusNear_Click(object sender, EventArgs e)
        {
            byte[] buff = { 0x81, 0x01, 0x04, 0x08, 0x03, 0xFF };
            this.serialPort1.Write(buff, 0, buff.Length);
        }

        private void btnFocusFar_Click(object sender, EventArgs e)
        {
            byte[] buff = { 0x81, 0x01, 0x04, 0x08, 0x02, 0xFF };
            this.serialPort1.Write(buff, 0, buff.Length);
        }
    }
}
