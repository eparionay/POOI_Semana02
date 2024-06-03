using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace POOI_Semana02
{
    internal class Program
    {
        static void Main(string[] args)
        {


            
            List<Empleado> lista = new List<Empleado>();
            lista.Add(new Empleado() { codigo = 1, nombre = "p", edad = 18 });
            try
            {
                bool existe = lista.Exists(x => x.codigo == 5);
                if (existe)
                {
                    Console.WriteLine("Resultado : " + existe);
                }
                else
                {
                    throw new EmpleadoCodigoZeroException("Ocurrio un error al buscar");
                }
            }catch (Exception ex)
            {
                Console.WriteLine("Error Mensaje : " + ex.Message);
                Console.WriteLine("Nombre Error  : " + ex.GetType().Name);
                Console.WriteLine("Ubicacion Metodo : " + ex.TargetSite);
            }


            /*
            try
            {
                //int numerador = 12;
                //int denominador = 0;
                //int resultado;
                //Exception Division Entre Cero
                //resultado = numerador / denominador;
                //Console.WriteLine("Resultado : " + resultado);
                //Exception Formateo
                //resultado = Convert.ToInt32("hola");

                // Exception Fuera de Rango
                //List<Empleado> lista = new List<Empleado>();
                //lista.Add(new Empleado() { codigo = 1, nombre = "Erick", edad = 30 });
                //Console.WriteLine(lista[1].nombre );
                // Saldra error porque la lista solo tiene un objeto agregado
                // que corresponde al indice 0

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
                Console.WriteLine("Metodo de Error : " + ex.TargetSite);
                Console.WriteLine("Tipo de Error : " + ex.GetType().Name);
            }
            finally
            {
                Console.WriteLine("Este bloque se ejecutara");
            }
            Console.WriteLine("Este linea se mostrara");


            
            */










            Console.ReadKey();
        }

        public static void probarListadoEmpleado()
        {

            List<Empleado> lista = new List<Empleado>();
            lista.Add(new Empleado() { codigo = 1, nombre = "Erick", edad = 30 });
            lista.Add(new Empleado() { codigo = 2, nombre = "Pedro", edad = 50 });
            lista.Add(new Empleado() { codigo = 3, nombre = "miguel", edad = 10 });
            lista.Add(new Empleado() { codigo = 4, nombre = "david", edad = 15 });
            lista.Add(new Empleado() { codigo = 5, nombre = "robert", edad = 32 });
            lista.Add(new Empleado() { codigo = 6, nombre = "marcos", edad = 57 });
            lista.Add(new Empleado() { codigo = 7, nombre = "sait", edad = 89 });
            lista.Add(new Empleado() { codigo = 8, nombre = "Hanss", edad = 8 });
            lista.Add(new Empleado() { codigo = 9, nombre = "Alex", edad = 5 });
            lista.Add(new Empleado() { codigo = 10, nombre = "Alexa", edad = 33 });
            lista.Add(new Empleado() { codigo = 11, nombre = "Juan", edad = 38 });

            mostrarArregloLista(lista);
            Console.WriteLine("***************************");
            // Ordenar de forma ascendente (Por la edad)
            List<Empleado> listaOrde = lista.OrderBy(x => x.edad).ToList();
            mostrarArregloLista(listaOrde);
            Console.WriteLine("*************************");
            // Ordenar de forma descendente
            List<Empleado> listaOrdenDesc = lista.OrderByDescending(x => x.edad).ToList();
            mostrarArregloLista(listaOrdenDesc);
            Console.WriteLine("Tamano : " + listaOrdenDesc.Count);
            Console.WriteLine("************************************");
            // Eliminar el codigo 5

            lista.RemoveAll(x => x.codigo == 5);
            mostrarArregloLista(lista);
            Console.WriteLine("************************************");

            Empleado objEmpleado = lista.Where(x => x.codigo == 1).First();

            Console.WriteLine(
                        "Empleado Codigo : " + objEmpleado.codigo + " - " +
                        "Empleado Nombre : " + objEmpleado.nombre
                            );

            Console.WriteLine("****************ee********************");
            // Seleccionar las personas que tengan edad mayor a 30
            List<Empleado> listaPersonas =
                lista.Where(x => x.edad > 30).ToList();
            mostrarArregloLista(listaPersonas);
            // Seleccionar las personas que tengan edad mayor a 40 y menor a 50
            Console.WriteLine("************************************");

            List<Empleado> listaPersona1 =
                lista.Where(x => x.edad > 30 && x.edad < 50).ToList();
            mostrarArregloLista(listaPersona1);
            Console.WriteLine("************************************");

        }

        public static void mostrarArregloLista(List<Empleado> lista)
        {
            foreach (var x in lista)
            {
                Console.WriteLine(" Codigo : "+ x.codigo +
                                  "- Nombre : " + x.nombre + 
                                  "- Edad   : " + x.edad);
            }
        }

        public static void mostrarArreglo(List<int> listado)
        {
            foreach (var i in listado)
            {
                Console.WriteLine(i);
            }
        }

        public static void probarListado()
        {
            List<int> listado = new List<int>();
            listado.Add(10);
            listado.Add(20);
            listado.Add(15);
            listado.Add(45);
            listado.Add(120);
            listado.Add(90);
            mostrarArreglo(listado);
            Console.WriteLine("******************");
            listado.Sort();
            mostrarArreglo(listado);
            Console.WriteLine("******************");
            listado.Reverse();
            mostrarArreglo(listado);
            Console.WriteLine("******************");
            listado.Remove(20);
            mostrarArreglo(listado);
            Console.WriteLine("******************");
            listado.RemoveAt(3);
            mostrarArreglo(listado);
            Console.WriteLine("******************");
            listado.Insert(2, 150);
            mostrarArreglo(listado);
            Console.WriteLine("******************");
            listado.RemoveAll(x => x % 2 == 1);
            mostrarArreglo(listado);
            Console.WriteLine("********************");
            int posicion = listado.IndexOf(120);
            Console.WriteLine("Pos : " + posicion);
            Console.WriteLine("********************");
            bool encontro = listado.Exists(x => x == 120);
            Console.WriteLine("Existe : " + encontro);
            Console.WriteLine("**********************");
            int numero = listado.First();
            Console.WriteLine("Numero : " + numero);
            Console.WriteLine("**********************");
            int num = listado.FirstOrDefault(x => x == 150);
            Console.WriteLine("Num Def : " + num);
            Console.WriteLine("********************");
            listado.Clear();
            mostrarArreglo(listado);

        }

    }
}
