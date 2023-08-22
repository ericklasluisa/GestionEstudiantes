using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IngresoEstudiantes;
using RegistroEstudiantes_GUI.NET;

namespace Proyecto
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            AbrirFormulario(new FormInicio());
        }

        private void AbrirFormulario(Form formulario)
        {
            if (this.panelVentanas.Controls.Count > 0)
                this.panelVentanas.Controls.RemoveAt(0);
            Form fh = formulario as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelVentanas.Controls.Add(fh);
            this.panelVentanas.Tag = fh;
            fh.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonVentanaIngresar_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormIngresoEstudiante());
        }

        private void buttonMenuOpciones_Click(object sender, EventArgs e)
        {
            if (panelBarraLateral.Visible == true)
            {
                panelBarraLateral.Visible = false;
                panelLateral.Size = new Size(80, 460);
                panelVentanas.Size = new Size(920, 460);
            }
            else
            {
                panelBarraLateral.Visible = true;
                panelVentanas.Dock = DockStyle.Right;
                panelLateral.Size = new Size(250, 460);
                panelVentanas.Size = new Size(750, 460);
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            if (ActiveForm != null)
            {
                ActiveForm.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            if (ActiveForm != null)
            {
                ActiveForm.Close();
            }
        }

        private void buttonVentanaPresentar_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormVerEstudiantes());
        }

        private void buttonVentanaBuscar_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormBuscarEstudiante());
        }

        private void buttonInicio_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormInicio());
        }
    }
}
