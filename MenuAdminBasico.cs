using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjecteGrup
{
    public partial class MenuAdminBasico : Form
    {
        Administrador sergio;
        String reconocimiento;
        public MenuAdminBasico()
        {
            InitializeComponent();
        }
        public MenuAdminBasico(Administrador normal)
        {
            InitializeComponent();
            DateTime fechaEntrada = DateTime.UtcNow;
            labelSesion2.Text = Convert.ToString(fechaEntrada);
            this.sergio = normal;
            reconocimiento = sergio.Name + " " + sergio.Surname;
            labelUser2.Text = "Admin " + reconocimiento;
        }

        private void MenuAdminBasico_Load(object sender, EventArgs e)
        {

        }

        private void buttonAceptarJuego2_Click(object sender, EventArgs e)
        {
            JuegoAdmin q = new JuegoAdmin();
            q.ShowDialog();
        }

        private void buttonCerrarSesion2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSalir2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void juegoToolStripMenuItemPrimero_Click(object sender, EventArgs e)
        {
            JuegoAdmin q = new JuegoAdmin();
            q.ShowDialog();
            
        }

        private void salirToolStripMenuItemPrimero_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cerrarSesionToolStripMenuItemPrimer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAceptarAvatar2_Click(object sender, EventArgs e)
        {
            GestionAvatarForm gestionavatarform = new GestionAvatarForm();
            gestionavatarform.ShowDialog();
            
        }
    }
}
