using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto;

namespace RegistroEstudiantes_GUI.NET
{

    public partial class FormBuscarEstudiante : Form
    {

        public static bool EsNumeroDecimalValido(string texto)
        {
            // Configura la cultura regional para usar la coma como separador decimal
            CultureInfo cultura = new CultureInfo("es-ES");

            // Utiliza TryParse para verificar si el texto es un número decimal válido
            if (double.TryParse(texto, NumberStyles.AllowDecimalPoint, cultura, out double resultado))
            {
                // Verifica si el valor está en el rango de notas válidas (por ejemplo, de 0 a 20)
                if (resultado >= 0 && resultado <= 20)
                {
                    // Verificar que tenga máximo dos decimales
                    string[] partes = texto.Split(',');
                    if (partes.Length == 1 || partes[1].Length <= 2)
                    {
                        return true; // Es un número decimal válido en el rango de notas con máximo dos decimales
                    }
                }
            }
            return false; // No es un número decimal válido o está fuera del rango de notas o tiene más de dos decimales
        }

        private void txtNota_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EsNumeroDecimalValido(textBox.Text))
            {
                MessageBox.Show("Por favor, ingresa una nota válida (entre 0 y 20 con máximo dos decimales).", "Nota Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.SelectAll();
                e.Cancel = true; // Evita que el TextBox pierda el foco
            }
        }

        public FormBuscarEstudiante()
        {
            InitializeComponent();    
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtNota1.Enabled = false;
            txtNota2.Enabled = false;
            txtNota3.Enabled = false;
            txtPromedio.Enabled = false;
            btnActualizar.Enabled = false;
            btnLimpiar.Enabled = false;
            txtPosicion.Enabled = false;
            btnCalcularPromedio.Enabled = false;
            txtNota1.Validating += txtNota_Validating;
            txtNota2.Validating += txtNota_Validating;
            txtNota3.Validating += txtNota_Validating;
        }
 
        public void LimpiarTxt()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtNota1.Text = "";
            txtNota2.Text = "";
            txtNota3.Text = "";
            txtPromedio.Text = "";
            txtPosicion.Text = "";
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string searchedCode = txtCodigo.Text;
            Console.WriteLine(searchedCode);
            GlobalList.lista.OrdenarCodeQuickSort(0, GlobalList.lista.Contar() - 1);
            //lista.busquedaBinariaCode(0, lista.Contar(), searchedCode);
            int posicion = GlobalList.lista.busquedaBinariaPosicion(0, GlobalList.lista.Contar() - 1, searchedCode);
            Console.WriteLine(posicion);
            if (posicion != -1)
            {
                Nodo stdBuscado = GlobalList.lista.EncontrarPosicion(posicion);
                txtPosicion.Text = posicion.ToString();
                double[] notasStd = stdBuscado.student.Notas;
                txtNota1.Text = notasStd[0].ToString();
                txtNota2.Text = notasStd[1].ToString();
                txtNota3.Text = notasStd[2].ToString();
                txtPromedio.Text = notasStd[3].ToString();
                txtNombre.Text = stdBuscado.student.Name;
                txtApellido.Text = stdBuscado.student.LastName;
                txtCodigo.Text = stdBuscado.student.Code;

                txtNota1.Enabled = true;
                txtNota2.Enabled = true;
                txtNota3.Enabled = true;

                txtCodigo.Enabled = false;
                btnLimpiar.Enabled = true;
                btnActualizar.Enabled = true;
                btnCalcularPromedio.Enabled = true;
               
                btnBuscar.Enabled = false;
                MessageBox.Show("Estudiante con codigo" + txtCodigo.Text + " encontrado. " + "\nUsted puede actualizar los datos.");
            }
            else { MessageBox.Show("No se encontro el estudiante " + txtCodigo.Text); }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {


            int posicion = Convert.ToInt32(txtPosicion.Text.ToString());

            if (posicion != -1)
            {
                string Nota1 = txtNota1.Text.Replace(",", ".");
                string Nota2 = txtNota2.Text.Replace(",", ".");
                string Nota3 = txtNota3.Text.Replace(",", ".");

                double.TryParse(Nota1, out double nota1);
                double.TryParse(Nota2, out double nota2);
                double.TryParse(Nota3, out double nota3);

                double[] notas = new double[4];
                notas[0] = nota1;
                notas[1] = nota2;
                notas[2] = nota3;
                notas[3] = 0.0;

                if (!double.TryParse(Nota1, NumberStyles.Float, CultureInfo.InvariantCulture, out notas[0]) ||
                    !double.TryParse(Nota2, NumberStyles.Float, CultureInfo.InvariantCulture, out notas[1]) ||
                    !double.TryParse(Nota3, NumberStyles.Float, CultureInfo.InvariantCulture, out notas[2]))
                {
                    MessageBox.Show("Por favor, ingresa notas válidas (entre 0 y 20) con coma decimal.", "Notas Inválidas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                GlobalList.lista.EncontrarPosicion(posicion).student.Notas = notas;

                GlobalList.lista.calcularPromedio(GlobalList.lista.EncontrarPosicion(posicion).student.Notas);
                txtPromedio.Text = GlobalList.lista.EncontrarPosicion(posicion).student.Notas[3].ToString();
      
                GlobalList.lista.EncontrarPosicion(posicion).student.Name = txtNombre.Text;
                GlobalList.lista.EncontrarPosicion(posicion).student.LastName = txtApellido.Text;
                GlobalList.lista.EncontrarPosicion(posicion).student.Code = txtCodigo.Text;


                MessageBox.Show("Se actualizo correctamente el estudiante " + txtNombre.Text + " " + txtApellido.Text);
                
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTxt();
            btnBuscar.Enabled = true;
            txtCodigo.Enabled = true;
            btnActualizar.Enabled = false;
        }

        private void btnCalcularPromedio_Click(object sender, EventArgs e)
        {

            string Nota1 = txtNota1.Text.Replace(",", ".");
            string Nota2 = txtNota2.Text.Replace(",", ".");
            string Nota3 = txtNota3.Text.Replace(",", ".");

            double.TryParse(Nota1, out double nota1);
            double.TryParse(Nota2, out double nota2);
            double.TryParse(Nota3, out double nota3);

            double[] notas = new double[4];
            notas[0] = nota1;
            notas[1] = nota2;
            notas[2] = nota3;
            notas[3] = 0.0;

            if (!double.TryParse(Nota1, NumberStyles.Float, CultureInfo.InvariantCulture, out notas[0]) ||
                !double.TryParse(Nota2, NumberStyles.Float, CultureInfo.InvariantCulture, out notas[1]) ||
                !double.TryParse(Nota3, NumberStyles.Float, CultureInfo.InvariantCulture, out notas[2]))
            {
                MessageBox.Show("Por favor, ingresa notas válidas (entre 0 y 20) con coma decimal.", "Notas Inválidas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtPromedio.Text = Math.Round(( (notas[0] + notas[1] + notas[2]) / 3),2).ToString();

        }

        private void panelBuscarEstudiante_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GlobalList.lista.EncontrarPosicion(0).student.LastName);
        }

        private void txtNota3_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TextBox_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtNota1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
