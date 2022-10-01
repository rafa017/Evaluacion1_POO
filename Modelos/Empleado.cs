using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Empleado:Persona
    {

        public int id_empleado { get; set; }
        public List<Departamento> departamento { get; set; }

        public Empleado()
        {
            departamento = new List<Departamento>();
        }
        
        public void agregarDepartamento(Departamento depto)
        {
            departamento.Add(depto);
        }
        public void agregarEmpleado(int id_empleado, string rut, string nombre, string apellido)
        {
            /*Console.WriteLine("Se creara un nuevo empleado");
            Console.WriteLine("Id empleado: "+ id_empleado);
            Console.WriteLine("Rut empleado: "+rut);
            Console.WriteLine("Nombre empleado: "+nombre);
            Console.WriteLine("Apellido empleado: "+apellido);  */
       
        }
    }
}
