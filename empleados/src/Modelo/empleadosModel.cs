using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empleados.src.Modelo
{
    internal class empleadosModel
    {
        private int id;
        private string nombre;
        private string apellido;
        private int hrsTrb;
        private int hrsExt;
        private int subTrans;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre 
        { 
            get { return nombre; } 
            set { nombre = value; } 
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public int HrsTrb
        {
            get { return hrsTrb; }
            set { hrsTrb = value; }
        }

        public int HrsExt
        {
            get { return hrsExt; }
            set { hrsExt = value; }
        }

        public int SubTrans
        {
            get { return subTrans; }
            set { subTrans = value; }
        }

        public empleadosModel(int id , string nombre , string apellido , int hrsTrb , int hrsExt , int subTrans )
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.hrsTrb = hrsTrb;
            this.hrsExt = hrsExt;
            this.subTrans = subTrans;

        }

        public empleadosModel()
        {

        }

    }

    
}
