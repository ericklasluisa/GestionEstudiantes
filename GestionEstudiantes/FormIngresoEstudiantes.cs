using System;
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

namespace IngresoEstudiantes
{

    public partial class FormIngresoEstudiante : Form
    {

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                MessageBox.Show("Por favor, ingrese un nombre.", "Campo vacio", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (textBox.Text.Length > 35)
            {
                MessageBox.Show("El nombre no puede superar los 50 caracteres.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
                e.Cancel = true;
            }
        }

        private void txtApellido_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                MessageBox.Show("Por favor, ingrese un apellido.", "Campo vacio", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (textBox.Text.Length > 35)
            {
                MessageBox.Show("El apellido no puede superar los 50 caracteres.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
                e.Cancel = true;
            }
        }

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
                MessageBox.Show("Por favor, ingresa notas válidas (entre 0 y 20) con dos decimales separados por coma decimal.", "Nota Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.SelectAll();
                e.Cancel = true; // Evita que el TextBox pierda el foco
            }
        }


        //funcion que coloque todos los estudiantes de la lista en el datagridview
        public void MostrarLista()
        {
            dgvLista.Rows.Clear();
            for (int i = 0; i < GlobalList.lista.Contar(); i++)
            {
                dgvLista.Rows.Add(GlobalList.lista.EncontrarPosicion(i).student.Code, GlobalList.lista.EncontrarPosicion(i).student.Name, GlobalList.lista.EncontrarPosicion(i).student.LastName, GlobalList.lista.EncontrarPosicion(i).student.Notas[0], GlobalList.lista.EncontrarPosicion(i).student.Notas[1], GlobalList.lista.EncontrarPosicion(i).student.Notas[2]);
            }
        }
        //funcion que limpie todos los txtbox
        public void LimpiarTxt()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtNota1.Text = "";
            txtNota2.Text = "";
            txtNota3.Text = "";
        }



        public FormIngresoEstudiante()
        {
            InitializeComponent();
            dgvLista.RowHeaderMouseClick += dgvLista_RowHeaderMouseClick;
            dgvLista.SelectionChanged += dgvList_SelectionChanged;
            txtNota1.Validating += txtNota_Validating;
            txtNota2.Validating += txtNota_Validating;
            txtNota3.Validating += txtNota_Validating;
            txtApellido.Validating += txtApellido_Validating;
            txtNombre.Validating += txtNombre_Validating;
            txtNombre.KeyPress += txtNombre_KeyPress;
            txtApellido.KeyPress += txtApellido_KeyPress;
            MostrarLista();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "" || txtNombre.Text == "" || txtApellido.Text == "" || txtNota1.Text == "" || txtNota2.Text == "" || txtNota3.Text == "")
            {
                MessageBox.Show("Debe llenar todos los campos");
                return;
            }

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

            //validar que el codigo no se repita
            GlobalList.lista.OrdenarCodeQuickSort(0, GlobalList.lista.Contar() - 1);
            GlobalList.lista.busquedaBinariaCode(0, GlobalList.lista.Contar() - 1, txtCodigo.Text);
            int encontrado = GlobalList.lista.busquedaBinariaPosicion(0, GlobalList.lista.Contar() - 1, txtCodigo.Text);

            if (encontrado != -1)
            {
                MessageBox.Show("El codigo ya existe");
                return;
            }
            else
            {

                bool encontrado2 = false;

                GlobalList.lista.OrdenarNombreQuickSort(0, GlobalList.lista.Contar() - 1);
                int posicion = GlobalList.lista.busquedaBinariaPosicionNombre(0, GlobalList.lista.Contar() - 1, txtNombre.Text);
                if (posicion != -1 && GlobalList.lista.EncontrarPosicion(posicion).student.LastName == txtApellido.Text)
                {
                    encontrado2 = true;
                }


                if (encontrado2 == true)
                {
                    string codigoEstudiante = GlobalList.lista.EncontrarPosicion(posicion).student.Code;

                    DialogResult result = MessageBox.Show("El estudiante " + txtNombre.Text + " " + txtApellido.Text + " ya se encuentra en la lista con el código " + codigoEstudiante + ". ¿Desea agregarlo de todas formas?",
                                                          "Estudiante Existente",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        GlobalList.lista.Insertar(txtCodigo.Text, txtNombre.Text, txtApellido.Text, notas);
                        MostrarLista();
                        MessageBox.Show("Se agrego correctamente el estudiante " + txtNombre.Text + " " + txtApellido.Text);
                        LimpiarTxt();
                        dgvLista.ClearSelection();
                        btnActualizar.Enabled = false;
                        btnIngresar.Enabled = true;
                        txtCodigo.Enabled = true;
                    }
                    else
                    {
                        LimpiarTxt();
                        MessageBox.Show("No se agrego ningun estudiante.");

                    }
                }
                else
                {
                    GlobalList.lista.Insertar(txtCodigo.Text, txtNombre.Text, txtApellido.Text, notas);
                    MostrarLista();
                    MessageBox.Show("Se agrego correctamente el estudiante " + txtNombre.Text + " " + txtApellido.Text);
                    LimpiarTxt();
                    dgvLista.ClearSelection();
                    btnActualizar.Enabled = false;
                    btnIngresar.Enabled = true;
                    txtCodigo.Enabled = true;
                }

            }

        }

        private void dgvList_SelectionChanged(object sender, EventArgs e)
        {
            // Verificar si hay al menos una fila seleccionada
            if (dgvLista.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = dgvLista.SelectedRows[0];
                if (selectedRow.Cells["colCodigo"].Value == null)
                {
                    btnIngresar.Enabled = true; // Habilitar el botón "Ingresar"
                    btnActualizar.Enabled = false; // Deshabilitar el botón "Actualizar"
                    return;
                }
                else
                {
                    // Acceder a los valores de las celdas y asignarlos a los TextBoxes
                    txtNombre.Text = selectedRow.Cells["colNombre"].Value.ToString();
                    txtApellido.Text = selectedRow.Cells["colApellido"].Value.ToString();
                    txtCodigo.Text = selectedRow.Cells["colCodigo"].Value.ToString();
                    txtNota1.Text = selectedRow.Cells["colNota1"].Value.ToString();
                    txtNota2.Text = selectedRow.Cells["colNota2"].Value.ToString();
                    txtNota3.Text = selectedRow.Cells["colNota3"].Value.ToString();

                    btnIngresar.Enabled = false; // Deshabilitar el botón "Ingresar"
                    btnActualizar.Enabled = true; // Habilitar el botón "Actualizar"
                    txtCodigo.Enabled = false;

                }

            }
        }

        private void dgvLista_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0) // Verificar que se haya hecho clic en una fila (no en los encabezados)
            {
                DataGridViewRow selectedRow = dgvLista.Rows[e.RowIndex];

                // Si la fila ya estaba seleccionada
                if (selectedRow.Selected)
                {
                    dgvLista.ClearSelection(); // Desmarcar la fila seleccionada
                    LimpiarTxt(); // Limpia los TextBoxes
                    btnIngresar.Enabled = true; // Habilitar el botón "Ingresar"
                    btnActualizar.Enabled = false; // Deshabilitar el botón "Actualizar"
                }
                else
                {
                    // Obtener los valores de la fila seleccionada
                    if (selectedRow.Cells["colCodigo"].Value == null)
                    {
                        return;
                    }
                    else
                    {
                        // Acceder a los valores de las celdas y asignarlos a los TextBoxes
                        txtNombre.Text = selectedRow.Cells["colNombre"].Value.ToString();
                        txtApellido.Text = selectedRow.Cells["colApellido"].Value.ToString();
                        txtCodigo.Text = selectedRow.Cells["colCodigo"].Value.ToString();
                        txtNota1.Text = selectedRow.Cells["colNota1"].Value.ToString();
                        txtNota2.Text = selectedRow.Cells["colNota2"].Value.ToString();
                        txtNota3.Text = selectedRow.Cells["colNota3"].Value.ToString();

                        btnIngresar.Enabled = false; // Deshabilitar el botón "Ingresar"
                        btnActualizar.Enabled = true; // Habilitar el botón "Actualizar"
                        txtCodigo.Enabled = false;

                    }
                }
            }
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string searchedCode = txtCodigo.Text;
            Console.WriteLine(searchedCode);
            GlobalList.lista.OrdenarCodeQuickSort(0, GlobalList.lista.Contar() - 1);
            GlobalList.lista.busquedaBinariaCode(0, GlobalList.lista.Contar(), searchedCode);
            int posicion = GlobalList.lista.busquedaBinariaPosicion(0, GlobalList.lista.Contar() - 1, searchedCode);
            Console.WriteLine(posicion);
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
                GlobalList.lista.EncontrarPosicion(posicion).student.Name = txtNombre.Text;
                GlobalList.lista.EncontrarPosicion(posicion).student.LastName = txtApellido.Text;
                GlobalList.lista.EncontrarPosicion(posicion).student.Code = txtCodigo.Text;

                MessageBox.Show("Se actualizo correctamente el estudiante " + txtNombre.Text + " " + txtApellido.Text);
                MostrarLista();
                dgvLista.ClearSelection();
                btnActualizar.Enabled = false;
                btnIngresar.Enabled = true;
                txtCodigo.Enabled = true;
                LimpiarTxt();
            }

        }
      
    }
}