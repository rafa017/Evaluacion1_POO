using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Modelos.Mantenedor
{
    public class Empleado:Persona, IDataEntity
    {

        public int id_empleado { get; set; }
        public List<Departamento> departamento { get; set; }
        public data Data { get; set; }
        public List<Parametros> parametros { get; set; }


        public Empleado()
        {
            Data = new data();
            parametros = new List<Parametros>();
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
