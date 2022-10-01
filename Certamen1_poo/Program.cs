using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace Certamen1_poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado();
            empleado.agregarEmpleado(empleado.id_empleado, empleado.Rut, empleado.Nombre, empleado.Apellido);
            empleado.id_empleado = 0;
            Console.WriteLine("Id empleado: ");

            

            Console.ReadKey();
        }

    }
}
