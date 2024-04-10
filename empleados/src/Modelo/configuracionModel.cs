using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empleados.src.Modelo
{
    internal class configuracionModel
    {

        private int salario;
        private int descAFP;
        private int descEPS;

        public int Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public int DescAFP
        {
            get { return descAFP; }
            set { descAFP = value; }
        }

        public int DescEPS
        {
            get { return descEPS; }
            set { descEPS = value; }
        }

        public configuracionModel(int salario , int descAFP , int descEPS)
        {
            this.salario = salario;
            this.descAFP = descAFP;
            this.descEPS = descEPS;
        }

        public configuracionModel()
        {
            
        }

    }
}
