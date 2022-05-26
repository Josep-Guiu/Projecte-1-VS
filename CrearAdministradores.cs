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
    public partial class CrearAdministradores : Form
    {
        BindingList<Administrador> ListaAdmins = new BindingList<Administrador>();
        Administrador a;
        public CrearAdministradores()
        {
            InitializeComponent();
            ObtencionDeAdmins();
        }
        private void ObtencionDeAdmins()
        {
            OpenFileDialog openFiDi = new OpenFileDialog();
            openFiDi.InitialDirectory = Application.StartupPath;
            openFiDi.Filter = "Solo Ficheros Json (*.json)|*.json";
            String Ruta = @"..\..\JSON\Aministrador.json";

            JArray jarrayAdmins = JArray.Parse(File.ReadAllText(Ruta, Encoding.Default));
            ListaAdmins = jarrayAdmins.ToObject<BindingList<Administrador>>();
            dataGridViewAdmins.DataSource = ListaAdmins;

        }

        private void GuardarEnJson()
        {
            JArray arrayAdmins = (JArray)JToken.FromObject(ListaAdmins);
            File.WriteAllText(@"..\..\JSON\Aministrador.json", arrayAdmins.ToString());
        }

        private void buttonAnadirAdmin_Click(object sender, EventArgs e)
        {
            String name = textBoxNombreAdmin.Text;
            String surName = textBoxApellidoAdmin.Text;
            String userName = textBoxUserNameAdmin.Text;
            String password = textBoxPasswordAdmin.Text;
            bool control = true;

            control = ControlNombreUsuario(userName, control);

            if (name.Equals("") || surName.Equals("") || userName.Equals("") || password.Equals(""))
            {
                MessageBox.Show("No has insertado ningún campo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (password.Equals(name))
            {
                MessageBox.Show("No se puede introducir el nombre como contraseña", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!control)
            {
                MessageBox.Show("Este nombre de usuario ya existe", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AnadirAdminsALista(name, surName, userName, password);
                dataGridViewAdmins.DataSource = ListaAdmins;
                LimpiarFormsAdministrador();
                GuardarEnJson();
            }

        }

        private void AnadirAdminsALista(string name, string surName, string userName, string password)
        {
            a = new Administrador(name, surName, password, userName);
            ListaAdmins.Add(a);
        }

        private bool ControlNombreUsuario(string userName, bool control)
        {
            foreach (Administrador item in ListaAdmins)
            {
                String userNameLista = item.UserName;
                if (userNameLista.Equals(userName))
                {
                    control = false;
                }
            }

            return control;
        }

        private void LimpiarFormsAdministrador()
        {
            textBoxNombreAdmin.Text = "";
            textBoxApellidoAdmin.Text = "";
            textBoxUserNameAdmin.Text = "";
            textBoxPasswordAdmin.Text = "";
        }

        private void CrearAdministradores_Load(object sender, EventArgs e)
        {

        }

        private void buttonSalirAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonBorrarAdmin_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Quieres borrarlo?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (resultado == DialogResult.OK)
            {
                Administrador adminBorrar = (Administrador)dataGridViewAdmins.CurrentRow.DataBoundItem;
                ListaAdmins.Remove(adminBorrar);
                dataGridViewAdmins.DataSource = ListaAdmins;
                GuardarEnJson();
            }
        }

        private void buttonModificarAdmin_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Quieres modificarlo?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (resultado == DialogResult.OK)
            {
                Administrador adminModificar = (Administrador)dataGridViewAdmins.CurrentRow.DataBoundItem;
                ListaAdmins.Remove(adminModificar);
                dataGridViewAdmins.DataSource = ListaAdmins;                

                String a = adminModificar.Name;
                String b = adminModificar.Surname;
                String c = adminModificar.UserName;
                String d = adminModificar.Password;                

                textBoxNombreAdmin.Text = a;
                textBoxApellidoAdmin.Text = b;
                textBoxUserNameAdmin.Text = c;
                textBoxPasswordAdmin.Text = d;
                adminModificar.Name = textBoxNombreAdmin.Text;
                adminModificar.Surname = textBoxApellidoAdmin.Text;
                adminModificar.UserName = textBoxUserNameAdmin.Text;
                adminModificar.Password = textBoxPasswordAdmin.Text;
                GuardarEnJson();
            }
        }
    }
}
