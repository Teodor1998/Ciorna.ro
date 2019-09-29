using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net.Http;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace ciorna
{
    public partial class MainForm : Form
    {
        class ServerResp
        {
            public int status;
            public string message;

            public ServerResp()
            {
                status = 0;
                message = "";
            }
        }

        class RegisterRequest
        {
            public string Nume_public;
            public string Email;
            public string Parola;

            public RegisterRequest(string Nume_public, string Email, string Parola)
            {
                this.Nume_public = Nume_public;
                this.Email = Email;
                this.Parola = Parola;
            }
        }

        class LoginRequest
        {
            public string Email;
            public string Parola;

            public LoginRequest(string Email, string Parola)
            {
                this.Email = Email;
                this.Parola = Parola;
            }
        }

        string myEmail = "";
        const string URL = "http://34.73.99.95:8089";
        string resp = "";

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        int TogMove = 0;
        int MValX;
        int MValY;
        public MainForm()
        {
            InitializeComponent();
            //Login.BackColor = Color.Transparent;
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            register.BackColor = System.Drawing.Color.Transparent;
            backToLogin.BackColor = System.Drawing.Color.Transparent;

            panelRegister.Visible = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void register_MouseClick(object sender, MouseEventArgs e)
        {
            panelRegister.Visible = true;
            emailBox.Text = "";
            passwordBox.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Pass1Reg.Text.Equals(Pass2Reg.Text))
            {
                if (EmailReg.Text.Equals("") == false && NameReg.Text.Equals("") == false)
                {
                    RegisterRequest req = new RegisterRequest(NameReg.Text, EmailReg.Text, Pass1Reg.Text);
                    string  data = JsonConvert.SerializeObject(req);

                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL + "/add");
                    request.Method = "POST";
                    request.ContentType = "application/json";
                    request.ContentLength = data.Length;
                    StreamWriter requestWriter = new StreamWriter(request.GetRequestStream(), System.Text.Encoding.ASCII);
                    requestWriter.Write(data);
                    requestWriter.Close();

                    

                    try
                    {
                        WebResponse webResponse = request.GetResponse();
                        Stream webStream = webResponse.GetResponseStream();
                        StreamReader responseReader = new StreamReader(webStream);
                        resp = responseReader.ReadToEnd();
                        responseReader.Close();
                        ServerResp deserializedResp = JsonConvert.DeserializeObject<ServerResp>(resp);

                        if (deserializedResp.status == 200)
                        {
                            MessageBox.Show("Contul a fost creat cu succes!");
                            //panelLogin.BringToFront();
                            panelRegister.Visible = false;
                            Pass1Reg.Text = "";
                            Pass2Reg.Text = "";
                            EmailReg.Text = "";
                            NameReg.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Data introduse nu corespund cu standardul.");
                        }
                    }
                    catch (Exception ex1)
                    {
                        MessageBox.Show("Eroare la conexiune");
                    }
                }
                else
                {
                    MessageBox.Show("Trebuie sa completati toate campurile");
                }
            }
            else
            {
                MessageBox.Show("Parola nu a fost introdusa corect în cele doua campuri");
            }

        }

        private void exitRegister_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelRegister_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void panelRegister_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void panelRegister_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void backToLogin_Click(object sender, EventArgs e)
        {
            panelRegister.Visible = false;
            Pass1Reg.Text = "";
            Pass2Reg.Text = "";
            EmailReg.Text = "";
            NameReg.Text = "";
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (emailBox.Text.Equals("") == false && passwordBox.Text.Equals("") == false)
            {
                LoginRequest req = new LoginRequest(emailBox.Text, passwordBox.Text);
                string data = JsonConvert.SerializeObject(req);

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL + "/login");
                request.Method = "POST";
                request.ContentType = "application/json";
                request.ContentLength = data.Length;
                StreamWriter requestWriter = new StreamWriter(request.GetRequestStream(), System.Text.Encoding.ASCII);
                requestWriter.Write(data);
                requestWriter.Close();


                try
                {
                    WebResponse webResponse = request.GetResponse();
                    Stream webStream = webResponse.GetResponseStream();
                    StreamReader responseReader = new StreamReader(webStream);
                    resp = responseReader.ReadToEnd();
                    responseReader.Close();
                    ServerResp deserializedResp = JsonConvert.DeserializeObject<ServerResp>(resp);

                    if (deserializedResp.status == 200)
                    {
                        myEmail = emailBox.Text;

                        MessageBox.Show(myEmail + ", v-ati autentificat cu succes!");
                        emailBox.Text = "";
                        passwordBox.Text = "";
                    }
                    else
                    {
                         MessageBox.Show("User sau parola gresita!");
                    }
                }
                catch (Exception ex1)
                {
                    MessageBox.Show("Eroare la conexiune");
                }
            }
            else
            {
                MessageBox.Show("Trebuie sa completati toate campurile");
            }
        }
    }
}
