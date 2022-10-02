using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    internal class Program
    {
        public static void aguinaldo(float nuevosalario)
        {
            nuevosalario *= 12;
            Console.WriteLine("El aguinaldo del trabajador es:{0}", nuevosalario);
        }
        static void Main(string[] args)
        {
            String nombre;
            double sueldo;
            int empleado;



            Console.WriteLine("Bienvenido al sistema de empleados");
            Console.WriteLine("¿Cuantos trabajadores desea ingresar?");
            empleado = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < empleado; i++)
            {
                Console.WriteLine("Digite el nombre del trabajador que desea ingresar: ");
                nombre = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Digite el sueldo del trabajador: ");
                var salario = float.Parse(Console.ReadLine());

                aguinaldo(salario);
                Console.WriteLine($"El salario del trabajador es: {salario}");
                Console.WriteLine("El nombre del trabajador es: " + nombre);


            }
            Console.WriteLine("Muchas gracias por usar nuestro sistema");
            Console.ReadLine();


        }
    }
}
