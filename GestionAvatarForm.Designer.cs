
namespace ProjecteGrup
{
    partial class GestionAvatarForm
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
            this.labelMenu = new System.Windows.Forms.Label();
            this.dataGridViewAvatares = new System.Windows.Forms.DataGridView();
            this.textBoxPuntuacionMax = new System.Windows.Forms.TextBox();
            this.textBoxPuntuacionMin = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.buttonCargar = new System.Windows.Forms.Button();
            this.labelPuntuacionMaxima = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPuntuacionMin = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.groupBoxGeneros = new System.Windows.Forms.GroupBox();
            this.radioButtonGeneral = new System.Windows.Forms.RadioButton();
            this.radioButtonPop = new System.Windows.Forms.RadioButton();
            this.radioButtonRap = new System.Windows.Forms.RadioButton();
            this.radioButtonFunk = new System.Windows.Forms.RadioButton();
            this.radioButtonHeavy = new System.Windows.Forms.RadioButton();
            this.radioButtonRock = new System.Windows.Forms.RadioButton();
            this.textBoxImagen = new System.Windows.Forms.TextBox();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvatares)).BeginInit();
            this.groupBoxGeneros.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMenu
            // 
            this.labelMenu.BackColor = System.Drawing.SystemColors.Control;
            this.labelMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelMenu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelMenu.Location = new System.Drawing.Point(12, 9);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(570, 19);
            this.labelMenu.TabIndex = 0;
            this.labelMenu.Text = "MENÚ DE AVATARES";
            this.labelMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridViewAvatares
            // 
            this.dataGridViewAvatares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAvatares.Location = new System.Drawing.Point(12, 206);
            this.dataGridViewAvatares.Name = "dataGridViewAvatares";
            this.dataGridViewAvatares.RowHeadersWidth = 62;
            this.dataGridViewAvatares.Size = new System.Drawing.Size(570, 232);
            this.dataGridViewAvatares.TabIndex = 1;
            this.dataGridViewAvatares.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewAvatares_CellMouseClick);
            this.dataGridViewAvatares.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewAvatares_RowHeaderMouseClick);
            // 
            // textBoxPuntuacionMax
            // 
            this.textBoxPuntuacionMax.Location = new System.Drawing.Point(352, 94);
            this.textBoxPuntuacionMax.Name = "textBoxPuntuacionMax";
            this.textBoxPuntuacionMax.Size = new System.Drawing.Size(233, 20);
            this.textBoxPuntuacionMax.TabIndex = 21;
            // 
            // textBoxPuntuacionMin
            // 
            this.textBoxPuntuacionMin.Location = new System.Drawing.Point(349, 50);
            this.textBoxPuntuacionMin.Name = "textBoxPuntuacionMin";
            this.textBoxPuntuacionMin.Size = new System.Drawing.Size(233, 20);
            this.textBoxPuntuacionMin.TabIndex = 20;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(63, 50);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(190, 20);
            this.textBoxNombre.TabIndex = 19;
            // 
            // buttonCargar
            // 
            this.buttonCargar.Location = new System.Drawing.Point(349, 150);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(87, 22);
            this.buttonCargar.TabIndex = 18;
            this.buttonCargar.Text = "Cargar Imagen";
            this.buttonCargar.UseVisualStyleBackColor = true;
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // labelPuntuacionMaxima
            // 
            this.labelPuntuacionMaxima.AutoSize = true;
            this.labelPuntuacionMaxima.Location = new System.Drawing.Point(262, 97);
            this.labelPuntuacionMaxima.Name = "labelPuntuacionMaxima";
            this.labelPuntuacionMaxima.Size = new System.Drawing.Size(84, 13);
            this.labelPuntuacionMaxima.TabIndex = 17;
            this.labelPuntuacionMaxima.Text = "Puntuacion Max";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Imagen";
            // 
            // labelPuntuacionMin
            // 
            this.labelPuntuacionMin.AutoSize = true;
            this.labelPuntuacionMin.Location = new System.Drawing.Point(262, 53);
            this.labelPuntuacionMin.Name = "labelPuntuacionMin";
            this.labelPuntuacionMin.Size = new System.Drawing.Size(81, 13);
            this.labelPuntuacionMin.TabIndex = 15;
            this.labelPuntuacionMin.Text = "Puntuacion Min";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(13, 53);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 13;
            this.labelNombre.Text = "Nombre";
            // 
            // buttonCrear
            // 
            this.buttonCrear.Location = new System.Drawing.Point(510, 150);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(75, 23);
            this.buttonCrear.TabIndex = 24;
            this.buttonCrear.Text = "Crear";
            this.buttonCrear.UseVisualStyleBackColor = true;
            this.buttonCrear.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(445, 444);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(137, 23);
            this.buttonSalir.TabIndex = 25;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(12, 444);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(137, 23);
            this.buttonModificar.TabIndex = 26;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // groupBoxGeneros
            // 
            this.groupBoxGeneros.Controls.Add(this.radioButtonGeneral);
            this.groupBoxGeneros.Controls.Add(this.radioButtonPop);
            this.groupBoxGeneros.Controls.Add(this.radioButtonRap);
            this.groupBoxGeneros.Controls.Add(this.radioButtonFunk);
            this.groupBoxGeneros.Controls.Add(this.radioButtonHeavy);
            this.groupBoxGeneros.Controls.Add(this.radioButtonRock);
            this.groupBoxGeneros.Location = new System.Drawing.Point(16, 76);
            this.groupBoxGeneros.Name = "groupBoxGeneros";
            this.groupBoxGeneros.Size = new System.Drawing.Size(237, 96);
            this.groupBoxGeneros.TabIndex = 27;
            this.groupBoxGeneros.TabStop = false;
            this.groupBoxGeneros.Text = "Generos";
            // 
            // radioButtonGeneral
            // 
            this.radioButtonGeneral.AutoSize = true;
            this.radioButtonGeneral.Location = new System.Drawing.Point(126, 65);
            this.radioButtonGeneral.Name = "radioButtonGeneral";
            this.radioButtonGeneral.Size = new System.Drawing.Size(62, 17);
            this.radioButtonGeneral.TabIndex = 30;
            this.radioButtonGeneral.TabStop = true;
            this.radioButtonGeneral.Text = "General";
            this.radioButtonGeneral.UseVisualStyleBackColor = true;
            this.radioButtonGeneral.CheckedChanged += new System.EventHandler(this.radioButtonGeneral_CheckedChanged);
            // 
            // radioButtonPop
            // 
            this.radioButtonPop.AutoSize = true;
            this.radioButtonPop.Location = new System.Drawing.Point(126, 42);
            this.radioButtonPop.Name = "radioButtonPop";
            this.radioButtonPop.Size = new System.Drawing.Size(44, 17);
            this.radioButtonPop.TabIndex = 4;
            this.radioButtonPop.Text = "Pop";
            this.radioButtonPop.UseVisualStyleBackColor = true;
            this.radioButtonPop.CheckedChanged += new System.EventHandler(this.radioButtonPop_CheckedChanged);
            // 
            // radioButtonRap
            // 
            this.radioButtonRap.AutoSize = true;
            this.radioButtonRap.Location = new System.Drawing.Point(126, 19);
            this.radioButtonRap.Name = "radioButtonRap";
            this.radioButtonRap.Size = new System.Drawing.Size(45, 17);
            this.radioButtonRap.TabIndex = 3;
            this.radioButtonRap.Text = "Rap";
            this.radioButtonRap.UseVisualStyleBackColor = true;
            // 
            // radioButtonFunk
            // 
            this.radioButtonFunk.AutoSize = true;
            this.radioButtonFunk.Location = new System.Drawing.Point(15, 65);
            this.radioButtonFunk.Name = "radioButtonFunk";
            this.radioButtonFunk.Size = new System.Drawing.Size(49, 17);
            this.radioButtonFunk.TabIndex = 2;
            this.radioButtonFunk.Text = "Funk";
            this.radioButtonFunk.UseVisualStyleBackColor = true;
            // 
            // radioButtonHeavy
            // 
            this.radioButtonHeavy.AutoSize = true;
            this.radioButtonHeavy.Location = new System.Drawing.Point(15, 42);
            this.radioButtonHeavy.Name = "radioButtonHeavy";
            this.radioButtonHeavy.Size = new System.Drawing.Size(56, 17);
            this.radioButtonHeavy.TabIndex = 1;
            this.radioButtonHeavy.Text = "Heavy";
            this.radioButtonHeavy.UseVisualStyleBackColor = true;
            // 
            // radioButtonRock
            // 
            this.radioButtonRock.AutoSize = true;
            this.radioButtonRock.Checked = true;
            this.radioButtonRock.Location = new System.Drawing.Point(15, 19);
            this.radioButtonRock.Name = "radioButtonRock";
            this.radioButtonRock.Size = new System.Drawing.Size(51, 17);
            this.radioButtonRock.TabIndex = 0;
            this.radioButtonRock.TabStop = true;
            this.radioButtonRock.Text = "Rock";
            this.radioButtonRock.UseVisualStyleBackColor = true;
            this.radioButtonRock.CheckedChanged += new System.EventHandler(this.radioButtonRock_CheckedChanged);
            // 
            // textBoxImagen
            // 
            this.textBoxImagen.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxImagen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxImagen.Location = new System.Drawing.Point(352, 128);
            this.textBoxImagen.Name = "textBoxImagen";
            this.textBoxImagen.ReadOnly = true;
            this.textBoxImagen.Size = new System.Drawing.Size(233, 13);
            this.textBoxImagen.TabIndex = 22;
            this.textBoxImagen.TextChanged += new System.EventHandler(this.textBoxImagen_TextChanged);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(155, 444);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(137, 23);
            this.buttonEliminar.TabIndex = 28;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(510, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Mover Imagen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GestionAvatarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 487);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.textBoxImagen);
            this.Controls.Add(this.groupBoxGeneros);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonCrear);
            this.Controls.Add(this.labelMenu);
            this.Controls.Add(this.textBoxPuntuacionMax);
            this.Controls.Add(this.textBoxPuntuacionMin);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.buttonCargar);
            this.Controls.Add(this.labelPuntuacionMaxima);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelPuntuacionMin);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.dataGridViewAvatares);
            this.Name = "GestionAvatarForm";
            this.Text = "GestionAvatarForm";
            this.Load += new System.EventHandler(this.GestionAvatarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvatares)).EndInit();
            this.groupBoxGeneros.ResumeLayout(false);
            this.groupBoxGeneros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.DataGridView dataGridViewAvatares;
        private System.Windows.Forms.TextBox textBoxPuntuacionMax;
        private System.Windows.Forms.TextBox textBoxPuntuacionMin;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.Label labelPuntuacionMaxima;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPuntuacionMin;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Button buttonCrear;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.GroupBox groupBoxGeneros;
        private System.Windows.Forms.RadioButton radioButtonPop;
        private System.Windows.Forms.RadioButton radioButtonRap;
        private System.Windows.Forms.RadioButton radioButtonFunk;
        private System.Windows.Forms.RadioButton radioButtonHeavy;
        private System.Windows.Forms.RadioButton radioButtonRock;
        private System.Windows.Forms.TextBox textBoxImagen;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.RadioButton radioButtonGeneral;
        private System.Windows.Forms.Button button1;
    }
}