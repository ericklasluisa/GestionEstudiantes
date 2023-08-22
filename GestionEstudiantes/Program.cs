using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using IngresoEstudiantes;
using RegistroEstudiantes_GUI.NET;

namespace Proyecto
{

    public class Student
    {
        protected string code;
        protected string name;
        protected string lastName;
        protected double[] notas;

        //constructor
        public Student(string code = null, string name = null, string lastName = null, double[] notas = null)
        {
            this.code = code;
            this.name = name;
            this.notas = notas;
            this.lastName = lastName;
        }

        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public double[] Notas
        {
            get
            {
                return notas;
            }
            set
            {
                notas = value;
            }
        }




    }

    public static class GlobalList
    {
        public static Nodo lista { get; set; } = new Nodo();

    }

    public class Nodo
    {
        public Student student;
        public Nodo sig;

        //Constructor
        public Nodo(Student student = null)
        {
            this.student = student;
            this.sig = null;
        }

        //Verificar si la lista está vacía
        public bool Vacio()
        {
            {
                if (this.sig == null && this.student == null)
                    return true;
            }
            return false;
        }

        //Insertar al inicio de la lista
        public void Insertar(string code, string nombre, string apellido, double[] notas)
        {
            Nodo nuevo;
            Student student = new Student(code, nombre, apellido, notas);

            if (Vacio())
            {
                this.student = student;
            }
            else
            {

                nuevo = new Nodo(this.student);
                this.student = student;
                nuevo.sig = this.sig;
                this.sig = nuevo;

            }
            Console.WriteLine("\nLa nuevo estudiantews " + student.ToString() + " fue agregado de manera exitosa.");
        }

        public int Contar()
        {
            int numeroNodos = 1;
            Nodo puntero = this;
            if (Vacio())
            {
                return 0;
            }
            else
            {
                while (puntero.sig != null)
                {
                    puntero = puntero.sig;
                    numeroNodos++;
                }
                return numeroNodos;
            }
        }


        public void calcularPromedio(double[] notas)
        {
            int n = notas.Length;
            double sum = 0;

            for (int i = 0; i < n - 1; i++)
            {
                sum += notas[i];
            }

            double promedio = sum / 3;
            promedio = Math.Round(promedio, 2); // Truncar a 2 decimales

            notas[3] = promedio;
        }


        public Nodo EncontrarPosicion(int posicion)
        {
            Nodo puntero = this;
            int numElementos = puntero.Contar();
            if (!Vacio() && posicion < numElementos)
            {
                int contador = 0;
                while (contador < posicion)
                {
                    puntero = puntero.sig;
                    contador++;
                }
                return puntero;
            }
            return null;
        }
        public void Ver()
        {
            if (!Vacio())
            {
                Nodo puntero = this;
                int numElementos = 0;
                numElementos = puntero.Contar();

                Console.WriteLine("\nLos elementos de la lista son los siguientes: ");

                for (int i = 0; i < numElementos; i++)
                {
                    Console.Write(" " + puntero.student.ToString());
                    if (i != numElementos - 1)
                        Console.Write(" ->");
                    puntero = puntero.sig;
                }
            }
            else { Console.WriteLine("lista vacia"); }
            Console.WriteLine();
        }


        public int busquedaBinariaPosicionNombre(int ini, int fin, string nombre)
        {
            int posicion = -1;
            if (ini <= fin)
            {
                int central = (ini + fin) / 2;
                if (central < Contar() && central > -1)
                {

                    //Console.WriteLine(central);
                    if (nombre == EncontrarPosicion(central).student.Name)
                    {


                        return central;
                    }


                    if (nombre.CompareTo(EncontrarPosicion(central).student.Name) > 0)
                    {
                        posicion = busquedaBinariaPosicion(central + 1, fin, nombre);
                    }
                    else
                    {
                        posicion = busquedaBinariaPosicion(ini, central - 1, nombre);
                    }
                }
            }
            else { Console.WriteLine("\n Elemento no encontrado"); return -1; }

            return posicion;

        }

        public int UbicarPivoteNombre(int ini, int fin)
{
    while (ini < fin)
    {
        while (EncontrarPosicion(fin).student.Name.CompareTo(EncontrarPosicion(ini).student.Name) >= 0 && ini < fin)
        {
            fin--;
        }
        Intercambiar(ini, fin);
        while (EncontrarPosicion(ini).student.Name.CompareTo(EncontrarPosicion(fin).student.Name) <= 0 && ini < fin)
        {
            ini++;
        }
        Intercambiar(ini, fin);
    }
    return ini;
}

public void OrdenarNombreQuickSort(int ini, int fin)
{
    if (ini < fin)
    {
        int pivote = UbicarPivoteApellido(ini, fin);
        OrdenarPorApellidoQuickSort(ini, pivote - 1);
        OrdenarPorApellidoQuickSort(pivote + 1, fin);
    }
}


        public bool busquedaBinariaCode(int ini, int fin, string searchedCode)
        {

            bool encontrado = false;
            if (ini <= fin)
            {
                int central = (ini + fin) / 2;

                if (central < Contar() && central > -1)
                {
                    if (searchedCode == EncontrarPosicion(central).student.Code)
                    {

                        Console.WriteLine(EncontrarPosicion(central).student.ToString());
                        encontrado = true;

                    }


                    if (searchedCode.CompareTo(EncontrarPosicion(central).student.Code) > 0)
                    {
                        encontrado = busquedaBinariaCode(central + 1, fin, searchedCode);
                    }
                    else
                    {
                        encontrado = busquedaBinariaCode(ini, central - 1, searchedCode);
                    }
                }


            }


            return encontrado;

        }

        public int busquedaBinariaPosicion(int ini, int fin, string searchedCode)
        {
            int posicion = -1;
            if (ini <= fin)
            {
                int central = (ini + fin) / 2;
                if (central < Contar() && central > -1)
                {

                    //Console.WriteLine(central);
                    if (searchedCode == EncontrarPosicion(central).student.Code)
                    {


                        return central;
                    }


                    if (searchedCode.CompareTo(EncontrarPosicion(central).student.Code) > 0)
                    {
                        posicion = busquedaBinariaPosicion(central + 1, fin, searchedCode);
                    }
                    else
                    {
                        posicion = busquedaBinariaPosicion(ini, central - 1, searchedCode);
                    }
                }
            }
            else { Console.WriteLine("\n Elemento no encontrado"); return -1; }

            return posicion;

        }

        public void Intercambiar(int a, int b)
        {
            Student temp = EncontrarPosicion(a).student;
            EncontrarPosicion(a).student = EncontrarPosicion(b).student;
            EncontrarPosicion(b).student = temp;
        }
        public int UbicarPivoteApellido(int ini, int fin)
        {
            while (ini < fin)
            {
                while (EncontrarPosicion(fin).student.LastName.CompareTo(EncontrarPosicion(ini).student.LastName) >= 0 && ini < fin)
                {
                    fin--;
                }
                Intercambiar(ini, fin);
                while (EncontrarPosicion(ini).student.LastName.CompareTo(EncontrarPosicion(fin).student.LastName) <= 0 && ini < fin)
                {
                    ini++;
                }
                Intercambiar(ini, fin);
            }
            return ini;
        }

        public void OrdenarPorApellidoQuickSort(int ini, int fin)
        {
            if (ini < fin)
            {
                int pivote = UbicarPivoteApellido(ini, fin);
                OrdenarPorApellidoQuickSort(ini, pivote - 1);
                OrdenarPorApellidoQuickSort(pivote + 1, fin);
            }
        }

        public int UbicarPivoteCode(int ini, int fin)
        {
            while (ini < fin)
            {
                while (EncontrarPosicion(fin).student.Code.CompareTo(EncontrarPosicion(ini).student.Code) >= 0 && ini < fin)
                {
                    fin--;
                }
                Intercambiar(ini, fin);
                while (EncontrarPosicion(ini).student.Code.CompareTo(EncontrarPosicion(fin).student.Code) <= 0 && ini < fin)
                {
                    ini++;
                }
                Intercambiar(ini, fin);
            }
            return ini;
        }


        public void OrdenarCodeQuickSort(int ini, int fin)
        {
            if (ini < fin)
            {
                int pivote = UbicarPivoteCode(ini, fin);
                OrdenarCodeQuickSort(ini, pivote - 1);
                OrdenarCodeQuickSort(pivote + 1, fin);
            }
        }

        public int UbicarPivotePromedio(int ini, int fin)
        {
            while (ini < fin)
            {
                while (EncontrarPosicion(fin).student.Notas[3] <= EncontrarPosicion(ini).student.Notas[3] && ini < fin)
                {
                    fin--;
                }
                Intercambiar(ini, fin);
                while (EncontrarPosicion(ini).student.Notas[3] >= EncontrarPosicion(fin).student.Notas[3] && ini < fin)
                {
                    ini++;
                }
                Intercambiar(ini, fin);
            }
            return ini;
        }

        public void OrdenarPromedioQuickSort(int ini, int fin)
        {
            if (ini < fin)
            {
                int pivote = UbicarPivotePromedio(ini, fin);
                OrdenarPromedioQuickSort(ini, pivote - 1);
                OrdenarPromedioQuickSort(pivote + 1, fin);
            }
        }
    }

    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormPrincipal());
        }
    }
}
