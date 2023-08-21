using System;
using System.Text;
using System.Windows.Forms;
using Proyecto;
using RegistroEstudiantes_GUI.NET;

namespace Proyecto
{

    public partial class FormVerEstudiantes : Form
    {


        public FormVerEstudiantes()
        {
            InitializeComponent();
            formatoListViewEstudiantes();
            btnCalcularPromedios.Enabled  = false;
            btnOrdenarPorApellido.Enabled = false;
            btnOrdenarPorPromedio.Enabled = false;
        }

        public void formatoListViewEstudiantes()
        {
            listViewEstudiantes.View = View.Details;
            listViewEstudiantes.GridLines = true;
            listViewEstudiantes.FullRowSelect = true;
            listViewEstudiantes.Columns.Add("Código", 100);
            listViewEstudiantes.Columns.Add("Nombre", 150);
            listViewEstudiantes.Columns.Add("Apellido", 150);
            listViewEstudiantes.Columns.Add("Nota 1", 70);
            listViewEstudiantes.Columns.Add("Nota 2", 70);
            listViewEstudiantes.Columns.Add("Nota 3", 70);
            listViewEstudiantes.Columns.Add("Promedio", 70);
        }

   
    double[] notas = { 4, 3, 4, 0 };
        double[] notas2 = { 7, 8, 9, 0 };

        public void verEstudiantes()
        {
            if (!GlobalList.lista.Vacio())
            {
                Nodo puntero = GlobalList.lista.EncontrarPosicion(0);

                int numElementos = 0;
                numElementos = puntero.Contar();

               

                for (int i = 0; i < numElementos; i++)
                {
                   
                    ListViewItem item = new ListViewItem(puntero.student.Code);
                    item.SubItems.Add(puntero.student.Name);
                    item.SubItems.Add(puntero.student.LastName);
                    item.SubItems.Add(puntero.student.Notas[0].ToString());
                    item.SubItems.Add(puntero.student.Notas[1].ToString());
                    item.SubItems.Add(puntero.student.Notas[2].ToString());
                    item.SubItems.Add(puntero.student.Notas[3].ToString());

                    listViewEstudiantes.Items.Add(item);
                    puntero = puntero.sig;
                }

                btnCalcularPromedios.Enabled = true;
                btnOrdenarPorApellido.Enabled = true;
            }
            else
            {
                MessageBox.Show("La lista no contiene elementos.", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          
        }

       
        private void btnVerEstudiantes_Click(object sender, EventArgs e)
        {
            listViewEstudiantes.Clear();
            formatoListViewEstudiantes();
            verEstudiantes();
         
        }

        private void btnCalcularPromedios_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < GlobalList.lista.Contar(); i++)
            {
                GlobalList.lista.calcularPromedio(GlobalList.lista.EncontrarPosicion(i).student.Notas);
            }
            
            listViewEstudiantes.Clear();
            formatoListViewEstudiantes();
            verEstudiantes();
            btnOrdenarPorPromedio.Enabled = true;

            MessageBox.Show("Promedios Calculados","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void listViewEstudiantes_Click(object sender, EventArgs e)
        {
            if (listViewEstudiantes.SelectedItems.Count > 0)
            {
                StringBuilder selectedItemData = new StringBuilder();

                foreach (ListViewItem.ListViewSubItem subItem in listViewEstudiantes.SelectedItems[0].SubItems)
                {
                    selectedItemData.Append(subItem.Text);
                    selectedItemData.Append("\t"); // Agregar tabulación entre columnas
                }

                Clipboard.SetText(selectedItemData.ToString());
            }
        }

        private void btnOrdenarPorPromedio_Click(object sender, EventArgs e)
        {

            GlobalList.lista.OrdenarPromedioQuickSort(0, GlobalList.lista.Contar() - 1);
            listViewEstudiantes.Clear();
            formatoListViewEstudiantes();
            verEstudiantes();


        }

        private void btnOrdenarPorApellido_Click(object sender, EventArgs e)
        {

            GlobalList.lista.OrdenarPorApellidoQuickSort(0,GlobalList.lista.Contar()-1);
            listViewEstudiantes.Clear();
            formatoListViewEstudiantes();
            verEstudiantes();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFormBuscar_Click(object sender, EventArgs e)
        {
            FormBuscarEstudiante form2 = new FormBuscarEstudiante(); 
            form2.ShowDialog();    
            this.Enabled = false;
        }
    }
}
