using empleados.src.BaseDatos;
using empleados.src.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace empleados.src.Vista
{
    public partial class Tabla : Form
    {
        public Tabla()
        {
            InitializeComponent();
          
            refrescar();
        }

        // Configuracion

        private void refrescar()
        {
            // cargar configuracion
            textBox_salario.Text = Global.configuracion.Salario.ToString();
            textBox_desAFP.Text = Global.configuracion.DescAFP.ToString();
            textBox_desEPS.Text = Global.configuracion.DescEPS.ToString();

            // vaciar formulario empleado
            casoFomularioEmplado(0);

            // cargar tabla
            dataGridView_empleados.Rows.Clear();

            // TODO : Variables
            double Salario;
            int subTrans;
            double desAFP;
            double desEPS;
            double totNet;
            double total;
            double SalarHr;
            int hrsTot;

            foreach (empleadosModel empleado in Global.empleados)
            {
                DataGridViewRow row = new DataGridViewRow();

                // Campo id
                DataGridViewCell cellId = new DataGridViewTextBoxCell();
                cellId.Value = empleado.Id;
                row.Cells.Add(cellId);

                // campo nombre                
                DataGridViewCell cellnombre = new DataGridViewTextBoxCell();
                cellnombre.Value = empleado.Nombre;
                row.Cells.Add(cellnombre);

                DataGridViewCell cellapellido = new DataGridViewTextBoxCell();
                cellapellido.Value = empleado.Apellido;
                row.Cells.Add(cellapellido);

                DataGridViewCell cellhrsTrb = new DataGridViewTextBoxCell();
                cellhrsTrb.Value = empleado.HrsTrb;
                row.Cells.Add(cellhrsTrb);

                DataGridViewCell cellhrsExt = new DataGridViewTextBoxCell();
                cellhrsExt.Value = empleado.HrsExt;
                row.Cells.Add(cellhrsExt);

                DataGridViewCell cellSalHor = new DataGridViewTextBoxCell();
                SalarHr = (Global.configuracion.Salario / 209);
                hrsTot = (empleado.HrsTrb + empleado.HrsExt);
                Salario = (SalarHr * hrsTot);
                cellSalHor.Value = SalarHr;
                row.Cells.Add(cellSalHor);

                DataGridViewCell cellsubTrans = new DataGridViewTextBoxCell();
                cellsubTrans.Value = empleado.SubTrans;
                row.Cells.Add(cellsubTrans);

                DataGridViewCell celldesAFP = new DataGridViewTextBoxCell();
                desAFP = ((Salario / 100) * Global.configuracion.DescAFP);
                celldesAFP.Value = desAFP;
                row.Cells.Add(celldesAFP);

                DataGridViewCell celldesEPS = new DataGridViewTextBoxCell();
                desEPS = ((Salario / 100) * Global.configuracion.DescEPS);
                celldesEPS.Value = desEPS;
                row.Cells.Add(celldesEPS);

                DataGridViewCell celltotNet = new DataGridViewTextBoxCell();
                totNet = (Salario + empleado.SubTrans);
                celltotNet.Value = totNet;
                row.Cells.Add(celltotNet);

                DataGridViewCell celltot = new DataGridViewTextBoxCell();
                total = (totNet - desAFP);
                total = (total - desEPS);
                celltot.Value = total;
                row.Cells.Add(celltot);

                dataGridView_empleados.Rows.Add(row); // nueva fila
            }

        }

        private void button_guardar_Click(object sender, EventArgs e)
        {
            int salario;
            int descAFP;
            int descEPS;

            int.TryParse(textBox_salario.Text, out salario);
            int.TryParse(textBox_desAFP.Text , out descAFP);
            int.TryParse(textBox_desEPS.Text , out descEPS);    


            Global.configuracion.Salario = salario;
            Global.configuracion.DescAFP = descAFP;
            Global.configuracion.DescEPS = descEPS;

            refrescar();
        }


        // Empleados

        private void casoFomularioEmplado(int caso)
        {

            if ( caso == 0 )
            {
                // modo : nuevo empleado
                button_eliminar.Visible = false; // ocultar boton eliminar
                label_tituloEmpleado.Text = "Nuevo Empleado"; // cambiar titulo

                //vaciar formulario
                textBox_empleadoNombre.Text = "";
                textBox_empleadoApellido.Text = "";
                textBox_empeladoHrsTrb.Text = "";
                textBox_empleadoHrsExt.Text = "";
                textBox_empleadoSubTrans.Text = "";

                // cambiar titulo al boton
                button_aceptar.Text = "Crear";
            }
            else
            {
                button_aceptar.Visible = false;
                button_eliminar.Visible = true; // mostrar boton eliminar
                label_tituloEmpleado.Text = "Ver Empleado"; // cambiar titulo

                Global.empleado = Global.empleados.FirstOrDefault(emp => emp.Id == caso);

                textBox_empleadoNombre.Text = Global.empleado.Nombre;
                textBox_empleadoApellido.Text = Global.empleado.Apellido;
                textBox_empeladoHrsTrb.Text = Global.empleado.HrsTrb.ToString();
                textBox_empleadoHrsExt.Text = Global.empleado.HrsExt.ToString();
                textBox_empleadoSubTrans.Text = Global.empleado.SubTrans.ToString();
            }            
        }

        private void button_aceptar_Click(object sender, EventArgs e)
        {
            int id;
            int hrsTrb;
            int hrsExt;
            int subTrans;

            string nombre = textBox_empleadoNombre.Text;
            string apellido = textBox_empleadoApellido.Text;
            int.TryParse(textBox_empeladoHrsTrb.Text, out hrsTrb);
            int.TryParse(textBox_empleadoHrsExt.Text, out hrsExt);
            int.TryParse(textBox_empleadoSubTrans.Text, out subTrans);

            empleadosModel empleado;

            if (Global.empleados.Count > 0)
            {
                empleado = Global.empleados[Global.empleados.Count - 1];
                id = empleado.Id + 1;
            }
            else
            {
                empleado = new empleadosModel();
                id = 1;
                empleado.Id = id;
            }


            empleado.Nombre = nombre;
            empleado.Apellido = apellido;
            empleado.HrsTrb = hrsTrb;
            empleado.HrsExt = hrsExt;
            empleado.SubTrans = subTrans;

            Global.empleados.Add(empleado);


            refrescar();
        }

        private void button_actualizar_Click(object sender, EventArgs e)
        {
            refrescar();
        }

        private void dataGridView_empleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView_empleados.Rows[e.RowIndex];

            int id = (int)row.Cells[0].Value;
            casoFomularioEmplado(id);    
        }

        private void button_eliminar_Click(object sender, EventArgs e)
        {
            Global.empleados.Remove(Global.empleado);
            refrescar();
        }
    }
}
