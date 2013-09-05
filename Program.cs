using System;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            IQueue colaPrueba = new Cola();

            Console.WriteLine("Esta vacia: " + colaPrueba.IsEmpty);
            Console.WriteLine("Tamaño: " + colaPrueba.Size);
            colaPrueba.Add(1);
            colaPrueba.Add(2);            

            Console.WriteLine("Esta vacia: " + colaPrueba.IsEmpty);
            Console.WriteLine("Tamaño: " + colaPrueba.Size);

            Console.WriteLine("Elemento: " + colaPrueba.Top);
            colaPrueba.Remove();
            Console.WriteLine("Elemento: " + colaPrueba.Top);
            colaPrueba.Remove();            

            try
            {
                Console.WriteLine("Elemento: " + colaPrueba.Top);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Funciona exception top");
            }

            try
            {
                colaPrueba.Remove();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Funciona exception remove");
            }

            //eleccion = Console.ReadLine();
            //sucesion_elegida = Int32.Parse(eleccion);

            Console.ReadLine();
        }
    }
}
