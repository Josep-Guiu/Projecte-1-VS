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
    public partial class GestionAvatarForm : Form
    {
        String Nombre;
        String Gender;
        int PuntuacionMin;
        int PuntuacionMax;
        String Ruta;
        String nombreJson = "avatares";
        BindingList<Avatar> listaMostrarAvatar = new BindingList<Avatar>();
        FileInfo file;
        
        public GestionAvatarForm()
        {
            InitializeComponent();
            ObtencionJsonsAvatar(nombreJson);
        }
        private void GestionAvatarForm_Load(object sender, EventArgs e)
        {  
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Quieres modificar este avatar?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            if (resultado == DialogResult.OK)
            {
                Avatar avatarModificar = (Avatar)dataGridViewAvatares.CurrentRow.DataBoundItem;
                List<Avatar> avataresModificar = new List<Avatar>();
                listaMostrarAvatar.Remove(avatarModificar);
                dataGridViewAvatares.DataSource = listaMostrarAvatar;

                String textoNombre = avatarModificar.Nombre;
                textBoxNombre.Text = textoNombre;
                int punMin = avatarModificar.PuntuacionMin;
                textBoxPuntuacionMin.Text = punMin.ToString();
                int punMax = avatarModificar.PuntuacionMax;
                textBoxPuntuacionMax.Text = punMax.ToString();
                String ruta = avatarModificar.Ruta;
                textBoxImagen.Text = ruta;
                

                if (avatarModificar.Gender.Equals(radioButtonRock.Text))
                {
                    radioButtonRock.Checked = true;
                    radioButtonRap.Checked = false;
                    radioButtonHeavy.Checked = false;
                    radioButtonFunk.Checked = false;
                    radioButtonPop.Checked = false;
                }
                else if (avatarModificar.Gender.Equals(radioButtonRap.Text))
                {
                    radioButtonRock.Checked = false;
                    radioButtonRap.Checked = true;
                    radioButtonHeavy.Checked = false;
                    radioButtonFunk.Checked = false;
                    radioButtonPop.Checked = false;
                }
                else if (avatarModificar.Gender.Equals(radioButtonHeavy.Text))
                {
                    radioButtonRock.Checked = false;
                    radioButtonRap.Checked = false;
                    radioButtonHeavy.Checked = true;
                    radioButtonFunk.Checked = false;
                    radioButtonPop.Checked = false;
                }
                else if (avatarModificar.Gender.Equals(radioButtonFunk.Text))
                {
                    radioButtonRock.Checked = false;
                    radioButtonRap.Checked = false;
                    radioButtonHeavy.Checked = false;
                    radioButtonFunk.Checked = true;
                    radioButtonPop.Checked = false;
                }
                else if (avatarModificar.Gender.Equals(radioButtonPop.Text))
                {
                    radioButtonRock.Checked = false;
                    radioButtonRap.Checked = false;
                    radioButtonHeavy.Checked = false;
                    radioButtonFunk.Checked = false;
                    radioButtonPop.Checked = true;
                }
                GuardarEnJsonAvatar(nombreJson);
                
            }
        }

        private void ObtencionJsonsAvatar(String a)
        {
            OpenFileDialog openFiDi = new OpenFileDialog();
            openFiDi.InitialDirectory = Application.StartupPath;
            openFiDi.Filter = "Solo Ficheros Json (*.json)|*.json";
            String ruta = @"..\..\JSON\" + a + ".json";
            JArray jarrayPreguntas = JArray.Parse(File.ReadAllText(ruta, Encoding.UTF8));
            listaMostrarAvatar = jarrayPreguntas.ToObject<BindingList<Avatar>>();
            dataGridViewAvatares.DataSource = listaMostrarAvatar;


        }

        private void GuardarEnJsonAvatar(String a)
        {
            JArray arrayPreguntas = (JArray)JToken.FromObject(listaMostrarAvatar);
            File.WriteAllText(@"..\..\JSON\" + a + ".json", arrayPreguntas.ToString());
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (DialogResult.OK == dialog.ShowDialog()) 
            {
                textBoxImagen.Text = dialog.FileName;
            }

            
           

        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            Nombre = textBoxNombre.Text.ToLower();
            PuntuacionMin = int.Parse(textBoxPuntuacionMin.Text);
            PuntuacionMax = int.Parse(textBoxPuntuacionMax.Text);

            if (radioButtonFunk.Checked)
            {
                Gender = radioButtonFunk.Text;

            }
            else if (radioButtonHeavy.Checked)
            {
                Gender = radioButtonHeavy.Text;

            }
            else if (radioButtonPop.Checked)
            {
                Gender = radioButtonPop.Text;

            }
            else if (radioButtonRap.Checked)
            {
                Gender = radioButtonRap.Text;

            }
            else if (radioButtonRock.Checked)
            {
                Gender = radioButtonRock.Text;
            }else if(radioButtonGeneral.Checked)
            {
                Gender = radioButtonGeneral.Text;
            }

            Ruta = textBoxImagen.Text;

            if (Nombre.Equals("") || textBoxPuntuacionMin.Text == null || textBoxPuntuacionMax.Text == null || Gender.Equals("") || Ruta.Equals(""))
            {
                MessageBox.Show("Hay algun campo vacio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Avatar avatar = new Avatar(Nombre, Gender, PuntuacionMin, PuntuacionMax, Ruta);

                listaMostrarAvatar.Add(avatar);
                dataGridViewAvatares.DataSource = null;
                dataGridViewAvatares.DataSource = listaMostrarAvatar;
                GuardarEnJsonAvatar(nombreJson);
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Quieres borrar este avatar?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (resultado == DialogResult.OK)
            {
                Avatar avatar = (Avatar)dataGridViewAvatares.CurrentRow.DataBoundItem;
                listaMostrarAvatar.Remove(avatar);
                dataGridViewAvatares.DataSource = listaMostrarAvatar;
                GuardarEnJsonAvatar(nombreJson);
            }
        }

        private void dataGridViewAvatares_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Avatar avatarModificar = (Avatar)dataGridViewAvatares.CurrentRow.DataBoundItem;
            List<Avatar> avataresModificar = new List<Avatar>();
            dataGridViewAvatares.DataSource = listaMostrarAvatar;

            String ruta = avatarModificar.Ruta;
            textBoxImagen.Text = ruta;
        }

        private void dataGridViewAvatares_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Avatar avatarModificar = (Avatar)dataGridViewAvatares.CurrentRow.DataBoundItem;
            List<Avatar> avataresModificar = new List<Avatar>();
            dataGridViewAvatares.DataSource = listaMostrarAvatar;

            String ruta = avatarModificar.Ruta;
            textBoxImagen.Text = ruta;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Avatar avatrModificar = (Avatar)dataGridViewAvatares.CurrentRow.DataBoundItem;
            String nombre = avatrModificar.Nombre;
            textBoxNombre.Text = nombre;

            Ruta = textBoxImagen.Text;
            String nombreImagen = textBoxNombre.Text;
            string path = Directory.GetCurrentDirectory();
            String rutaDestino = @"..\..\JSON\Resources\";

            File.Move(Ruta, Path.Combine(rutaDestino, nombreImagen + ".png"));

        }

        private void radioButtonGeneral_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonPop_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonRock_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBoxImagen_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
