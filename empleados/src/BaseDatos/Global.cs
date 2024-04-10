using empleados.src.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empleados.src.BaseDatos
{
    internal class Global
    {
        public static configuracionModel configuracion;
        public static List<empleadosModel> empleados;
        public static empleadosModel empleado;

        static Global()
        {
            configuracion = new configuracionModel();
            empleados = new List<empleadosModel>();
            empleado = new empleadosModel();
        }
    }
}
