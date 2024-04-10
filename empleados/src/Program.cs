using empleados.src.BaseDatos;
using empleados.src.Modelo;
using empleados.src.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace empleados
{
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

            // iniciar objetos
            Global.configuracion.Salario = 1300000;
            Global.configuracion.DescAFP = 9;
            Global.configuracion.DescEPS = 4;            

            Application.Run(new Tabla());
        }
    }
}
