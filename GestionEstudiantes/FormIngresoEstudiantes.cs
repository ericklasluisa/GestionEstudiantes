using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto;

namespace IngresoEstudiantes
{

    


        public partial class FormIngresoEstudiante : Form
    {

        

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
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "" || txtNombre.Text == "" || txtApellido.Text == "" || txtNota1.Text == "" || txtNota2.Text == "" || txtNota3.Text == "")
            {
                MessageBox.Show("Debe llenar todos los campos");
                return;
            }

            double[] notas = new double[4];
            notas[0] = double.Parse(txtNota1.Text);
            notas[1] = double.Parse(txtNota2.Text);
            notas[2] = double.Parse(txtNota3.Text);
            notas[3] = 0.0;


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

                    // Mostrar un MessageBox personalizado
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
            GlobalList.lista.busquedaBinariaCode(0, GlobalList.lista.Contar() , searchedCode);
            int posicion = GlobalList.lista.busquedaBinariaPosicion(0, GlobalList.lista.Contar() - 1, searchedCode);
            Console.WriteLine(posicion);
            if (posicion != -1)
            {
                double[] notas = new double[3];
                notas[0] = double.Parse(txtNota1.Text);
                notas[1] = double.Parse(txtNota2.Text);
                notas[2] = double.Parse(txtNota3.Text);

                GlobalList.lista.EncontrarPosicion(posicion).student.Notas = notas;
                GlobalList.lista.EncontrarPosicion(posicion).student.Name =txtNombre.Text;
                GlobalList.lista.EncontrarPosicion(posicion).student.LastName = txtApellido.Text;
                GlobalList.lista.EncontrarPosicion(posicion).student.Code = txtCodigo.Text;

                
                MostrarLista();
                dgvLista.ClearSelection();
                btnActualizar.Enabled = false;
                btnIngresar.Enabled = true;
                txtCodigo.Enabled = true;
                MessageBox.Show("Se actualizo correctamente el estudiante " + txtNombre.Text + " " + txtApellido.Text);
                LimpiarTxt();
            }
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
