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
using Domain;


namespace SqlMs
{
    public partial class LoginTela : Form
    {
        public LoginTela()
        {
            InitializeComponent();
        }

        //para poder arrastar a pagina ------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void LoginTela_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //------------------------------------------------------------------------------------

        //fechar
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //minimizar
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //efeito para desaparecer com o texto da textbox usuario
        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Usuario:")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.LightGray;
            }
        }
      
        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Usuario:";
                txtUser.ForeColor = Color.DimGray;
            }
        }
     

        //efeito para desaparecer com o texto da textbox senha
        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (txtSenha.Text == "Senha:")
            {
                txtSenha.Text = "";
                txtSenha.ForeColor = Color.LightGray;
                txtSenha.UseSystemPasswordChar = true;
            }
        }
        //ao tirar o mouse
        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if(txtSenha.Text == "")
            {
                txtSenha.Text = "Senha:";
                txtSenha.ForeColor = Color.DimGray;
                txtSenha.UseSystemPasswordChar = false;
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //Acesso e validaçao de email
            if (txtUser.Text != "Usuario:")
            {
                if (txtSenha.Text != "Senha:")
                {
                    UserModel user = new UserModel();
                    var validaLogin=user.LoginUser(txtUser.Text,txtSenha.Text);
                    if (validaLogin == true)
                    {
                        TelaInicial mainmenu = new TelaInicial();
                        mainmenu.Show();
                        mainmenu.FormClosed += logout;
                        this.Hide();
                    }
                    else
                    {
                        msgError("Username ou Senha incorreto");
                        txtSenha.Text = "Senha:";
                        txtUser.Focus();
                    }
                }
                    else msgError("Digite a senha");
            }
                    else msgError("Digite o username");
        }
        private void msgError(string msg)
        {
            lbErrorMenssagem.Text = "     " + msg;
            lbErrorMenssagem.Visible = true;
        }

        //logout
        private void logout(object sender, FormClosedEventArgs e)
        {
            txtSenha.Text = "Senha:";
            txtSenha.UseSystemPasswordChar = false;
            txtUser.Text = "Usuario:";
            lbErrorMenssagem.Visible = false;
            this.Show();
        }
    }
}
