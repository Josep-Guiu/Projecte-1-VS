using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjecteGrup
{
    public partial class LoginAdmin : Form
    {
        public LoginAdmin()
        {
            InitializeComponent();
            ObtencionDeAdmins();
            ObtencionSuperAdmin();
        }
        SuperAdministrador pepe;
        List<Administrador> listaAdministradores = new List<Administrador>();
        private void buttonSignup_Click(object sender, EventArgs e)
        {
            if(textBoxUser.Text.Equals("") ||  textBoxPassword.Text.Equals(""))
            {
                MessageBox.Show("Debes poner un nombre y una contraseña", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MostrarIconosError();
            }
            if (textBoxUser.Text.Equals(pepe.UserName) && !textBoxPassword.Text.Equals(pepe.Password)) {
                MessageBox.Show("El nombre de usuario o contraseña no es correcto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MostrarIconosError();
            }
            //else
            //{
            //    MostrarIconosError();
            //}



            foreach (Administrador admin in listaAdministradores)
            {
                if (textBoxUser.Text.Equals(admin.UserName) && !textBoxPassword.Text.Equals(admin.Password))
                {
                    MessageBox.Show("El nombre de usuario o contraseña no es correcto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MostrarIconosError();
                }
                
                else if (textBoxUser.Text.Equals(admin.UserName) && textBoxPassword.Text.Equals(admin.Password))
                {
                    MessageBox.Show("Bienvenido, " + admin.Name, "Mensaje", MessageBoxButtons.OK);
                    NoMostrarIconosError();
                    LimpiarLogin();
                    MenuAdminBasico a = new MenuAdminBasico(admin);
                    a.ShowDialog();
                    
                }
                
            }

            if (textBoxUser.Text.Equals(pepe.UserName) && textBoxPassword.Text.Equals(pepe.Password))
            {
                MessageBox.Show("Bienvenido, " + pepe.Name, "Mensaje", MessageBoxButtons.OK);
                NoMostrarIconosError();
                LimpiarLogin();
                MenuAdmin a = new MenuAdmin(pepe);
                a.ShowDialog();
            }

        }

        private void ObtencionDeAdmins()
        {
            OpenFileDialog openFiDi = new OpenFileDialog();
            openFiDi.InitialDirectory = Application.StartupPath;
            openFiDi.Filter = "Solo Ficheros Json (*.json)|*.json";
            String ruta = @"..\..\JSON\Aministrador.json";
                
                JArray jarrayAdmins = JArray.Parse(File.ReadAllText(ruta, Encoding.Default));
                listaAdministradores = jarrayAdmins.ToObject<List<Administrador>>();   
        }

        private void ObtencionSuperAdmin()
        {
            OpenFileDialog openFiDi = new OpenFileDialog();
            openFiDi.InitialDirectory = Application.StartupPath;
            openFiDi.Filter = "Solo Ficheros Json (*.json)|*.json";
            String ruta = @"..\..\JSON\SuperAdmin.json";

            JObject jobtectPepe = JObject.Parse(File.ReadAllText(ruta, Encoding.Default));
            pepe = jobtectPepe.ToObject<SuperAdministrador>();
        }

        private void LimpiarLogin()
        {
            textBoxUser.Text = "";
            textBoxPassword.Text = "";
        }

        private void NoMostrarIconosError()
        {
            pictureBoxExclamacion1.Visible = false;
            pictureBoxExclamacion2.Visible = false;
            pictureBoxExclamacion3.Visible = false;
            labelError.Visible = false;
        }

        private void MostrarIconosError()
        {
            pictureBoxExclamacion1.Visible = true;
            pictureBoxExclamacion2.Visible = true;
            pictureBoxExclamacion3.Visible = true;
            labelError.Visible = true;
        }

        
   

        private void checkBoxPassword_Click(object sender, EventArgs e)
        {
            if (checkBoxPassword.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxPassword_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LoginAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
