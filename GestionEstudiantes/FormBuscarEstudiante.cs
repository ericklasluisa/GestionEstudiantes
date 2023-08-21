using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto;

namespace RegistroEstudiantes_GUI.NET
{

    public partial class FormBuscarEstudiante : Form
    {
        public FormBuscarEstudiante()
        {
            InitializeComponent();
           // ingresarStudentsRandoms();
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
        }


        //public void ingresarStudentsRandoms()
        //{
        //    //Datos de prueba
        //    lista.Insertar("1006", "Leonardo", "Yaranga", notas);
        //    lista.Insertar("1005", "Pardo", "Wax", notas2);
        //    lista.Insertar("1000", "Leonardo", "Yaranga", notas);
        //    lista.Insertar("1001", "Leo", "Yaranga", notas2);
        //    lista.Insertar("1002", "Paco", "Web", notas);
        //    lista.Insertar("1003", "Pipe", "Bueno", notas);
        //    lista.Insertar("1004", "Waza", "Izzq", notas2);
        //    //
        //}
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

                txtNombre.Enabled = true;
                txtApellido.Enabled = true;
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
                
                double[] notas = new double[4];
                notas[0] = double.Parse(txtNota1.Text);
                notas[1] = double.Parse(txtNota2.Text);
                notas[2] = double.Parse(txtNota3.Text);

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
                     
            double[] notas = new double[4];
            notas[0] = double.Parse(txtNota1.Text);
            notas[1] = double.Parse(txtNota2.Text);
            notas[2] = double.Parse(txtNota3.Text);

            txtPromedio.Text =( (notas[0] + notas[1] + notas[2]) / 3).ToString();

        }

        private void panelBuscarEstudiante_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GlobalList.lista.EncontrarPosicion(0).student.LastName);
        }
    }
}
