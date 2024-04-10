namespace empleados.src.Vista
{
    partial class Tabla
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_title = new System.Windows.Forms.Label();
            this.dataGridView_empleados = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HrsTrb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HrsExt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalHor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTrans = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desAFP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desEPS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalNet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_nuevoEmpleado = new System.Windows.Forms.Panel();
            this.button_eliminar = new System.Windows.Forms.Button();
            this.button_aceptar = new System.Windows.Forms.Button();
            this.textBox_empleadoSubTrans = new System.Windows.Forms.TextBox();
            this.textBox_empleadoHrsExt = new System.Windows.Forms.TextBox();
            this.textBox_empeladoHrsTrb = new System.Windows.Forms.TextBox();
            this.textBox_empleadoApellido = new System.Windows.Forms.TextBox();
            this.textBox_empleadoNombre = new System.Windows.Forms.TextBox();
            this.label_empeladoSubTrans = new System.Windows.Forms.Label();
            this.label_empleadoHrsExt = new System.Windows.Forms.Label();
            this.label_empleadoHrsTrb = new System.Windows.Forms.Label();
            this.label_empleadoApellido = new System.Windows.Forms.Label();
            this.label_empleadoNombre = new System.Windows.Forms.Label();
            this.label_tituloEmpleado = new System.Windows.Forms.Label();
            this.panel_configuracion = new System.Windows.Forms.Panel();
            this.button_guardar = new System.Windows.Forms.Button();
            this.textBox_desEPS = new System.Windows.Forms.TextBox();
            this.textBox_desAFP = new System.Windows.Forms.TextBox();
            this.textBox_salario = new System.Windows.Forms.TextBox();
            this.label_desEPS = new System.Windows.Forms.Label();
            this.label_descAFP = new System.Windows.Forms.Label();
            this.label_salarioMinimo = new System.Windows.Forms.Label();
            this.label_tituloConfiguracion = new System.Windows.Forms.Label();
            this.button_actualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_empleados)).BeginInit();
            this.panel_nuevoEmpleado.SuspendLayout();
            this.panel_configuracion.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(12, 9);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(161, 33);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Empelados";
            // 
            // dataGridView_empleados
            // 
            this.dataGridView_empleados.AllowUserToAddRows = false;
            this.dataGridView_empleados.AllowUserToDeleteRows = false;
            this.dataGridView_empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_empleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Apellido,
            this.HrsTrb,
            this.HrsExt,
            this.SalHor,
            this.SubTrans,
            this.desAFP,
            this.desEPS,
            this.TotalNet,
            this.TotalFin});
            this.dataGridView_empleados.Location = new System.Drawing.Point(18, 45);
            this.dataGridView_empleados.Name = "dataGridView_empleados";
            this.dataGridView_empleados.ReadOnly = true;
            this.dataGridView_empleados.Size = new System.Drawing.Size(991, 223);
            this.dataGridView_empleados.TabIndex = 1;
            this.dataGridView_empleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_empleados_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // HrsTrb
            // 
            this.HrsTrb.HeaderText = "Horas Trabajadas";
            this.HrsTrb.Name = "HrsTrb";
            this.HrsTrb.ReadOnly = true;
            // 
            // HrsExt
            // 
            this.HrsExt.HeaderText = "Horas Extra";
            this.HrsExt.Name = "HrsExt";
            this.HrsExt.ReadOnly = true;
            // 
            // SalHor
            // 
            this.SalHor.HeaderText = "Salario/Hora";
            this.SalHor.Name = "SalHor";
            this.SalHor.ReadOnly = true;
            // 
            // SubTrans
            // 
            this.SubTrans.HeaderText = "Subsidio Transporte";
            this.SubTrans.Name = "SubTrans";
            this.SubTrans.ReadOnly = true;
            // 
            // desAFP
            // 
            this.desAFP.HeaderText = "Descuento AFP";
            this.desAFP.Name = "desAFP";
            this.desAFP.ReadOnly = true;
            // 
            // desEPS
            // 
            this.desEPS.HeaderText = "Descuento EPS";
            this.desEPS.Name = "desEPS";
            this.desEPS.ReadOnly = true;
            // 
            // TotalNet
            // 
            this.TotalNet.HeaderText = "Total Neto";
            this.TotalNet.Name = "TotalNet";
            this.TotalNet.ReadOnly = true;
            // 
            // TotalFin
            // 
            this.TotalFin.HeaderText = "Total Final";
            this.TotalFin.Name = "TotalFin";
            this.TotalFin.ReadOnly = true;
            // 
            // panel_nuevoEmpleado
            // 
            this.panel_nuevoEmpleado.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel_nuevoEmpleado.Controls.Add(this.button_eliminar);
            this.panel_nuevoEmpleado.Controls.Add(this.button_aceptar);
            this.panel_nuevoEmpleado.Controls.Add(this.textBox_empleadoSubTrans);
            this.panel_nuevoEmpleado.Controls.Add(this.textBox_empleadoHrsExt);
            this.panel_nuevoEmpleado.Controls.Add(this.textBox_empeladoHrsTrb);
            this.panel_nuevoEmpleado.Controls.Add(this.textBox_empleadoApellido);
            this.panel_nuevoEmpleado.Controls.Add(this.textBox_empleadoNombre);
            this.panel_nuevoEmpleado.Controls.Add(this.label_empeladoSubTrans);
            this.panel_nuevoEmpleado.Controls.Add(this.label_empleadoHrsExt);
            this.panel_nuevoEmpleado.Controls.Add(this.label_empleadoHrsTrb);
            this.panel_nuevoEmpleado.Controls.Add(this.label_empleadoApellido);
            this.panel_nuevoEmpleado.Controls.Add(this.label_empleadoNombre);
            this.panel_nuevoEmpleado.Controls.Add(this.label_tituloEmpleado);
            this.panel_nuevoEmpleado.Location = new System.Drawing.Point(18, 274);
            this.panel_nuevoEmpleado.Name = "panel_nuevoEmpleado";
            this.panel_nuevoEmpleado.Size = new System.Drawing.Size(503, 297);
            this.panel_nuevoEmpleado.TabIndex = 2;
            // 
            // button_eliminar
            // 
            this.button_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_eliminar.Location = new System.Drawing.Point(149, 240);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(126, 40);
            this.button_eliminar.TabIndex = 16;
            this.button_eliminar.Text = "Eliminar";
            this.button_eliminar.UseVisualStyleBackColor = true;
            this.button_eliminar.Click += new System.EventHandler(this.button_eliminar_Click);
            // 
            // button_aceptar
            // 
            this.button_aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_aceptar.Location = new System.Drawing.Point(298, 240);
            this.button_aceptar.Name = "button_aceptar";
            this.button_aceptar.Size = new System.Drawing.Size(126, 40);
            this.button_aceptar.TabIndex = 15;
            this.button_aceptar.Text = "button1";
            this.button_aceptar.UseVisualStyleBackColor = true;
            this.button_aceptar.Click += new System.EventHandler(this.button_aceptar_Click);
            // 
            // textBox_empleadoSubTrans
            // 
            this.textBox_empleadoSubTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_empleadoSubTrans.Location = new System.Drawing.Point(149, 199);
            this.textBox_empleadoSubTrans.Name = "textBox_empleadoSubTrans";
            this.textBox_empleadoSubTrans.Size = new System.Drawing.Size(275, 35);
            this.textBox_empleadoSubTrans.TabIndex = 14;
            // 
            // textBox_empleadoHrsExt
            // 
            this.textBox_empleadoHrsExt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_empleadoHrsExt.Location = new System.Drawing.Point(149, 158);
            this.textBox_empleadoHrsExt.Name = "textBox_empleadoHrsExt";
            this.textBox_empleadoHrsExt.Size = new System.Drawing.Size(275, 35);
            this.textBox_empleadoHrsExt.TabIndex = 13;
            // 
            // textBox_empeladoHrsTrb
            // 
            this.textBox_empeladoHrsTrb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_empeladoHrsTrb.Location = new System.Drawing.Point(149, 118);
            this.textBox_empeladoHrsTrb.Name = "textBox_empeladoHrsTrb";
            this.textBox_empeladoHrsTrb.Size = new System.Drawing.Size(275, 35);
            this.textBox_empeladoHrsTrb.TabIndex = 12;
            // 
            // textBox_empleadoApellido
            // 
            this.textBox_empleadoApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_empleadoApellido.Location = new System.Drawing.Point(149, 77);
            this.textBox_empleadoApellido.Name = "textBox_empleadoApellido";
            this.textBox_empleadoApellido.Size = new System.Drawing.Size(275, 35);
            this.textBox_empleadoApellido.TabIndex = 11;
            // 
            // textBox_empleadoNombre
            // 
            this.textBox_empleadoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_empleadoNombre.Location = new System.Drawing.Point(149, 36);
            this.textBox_empleadoNombre.Name = "textBox_empleadoNombre";
            this.textBox_empleadoNombre.Size = new System.Drawing.Size(275, 35);
            this.textBox_empleadoNombre.TabIndex = 10;
            // 
            // label_empeladoSubTrans
            // 
            this.label_empeladoSubTrans.AutoSize = true;
            this.label_empeladoSubTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_empeladoSubTrans.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_empeladoSubTrans.Location = new System.Drawing.Point(5, 205);
            this.label_empeladoSubTrans.Name = "label_empeladoSubTrans";
            this.label_empeladoSubTrans.Size = new System.Drawing.Size(124, 29);
            this.label_empeladoSubTrans.TabIndex = 9;
            this.label_empeladoSubTrans.Text = "Sub Trans";
            // 
            // label_empleadoHrsExt
            // 
            this.label_empleadoHrsExt.AutoSize = true;
            this.label_empleadoHrsExt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_empleadoHrsExt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_empleadoHrsExt.Location = new System.Drawing.Point(5, 164);
            this.label_empleadoHrsExt.Name = "label_empleadoHrsExt";
            this.label_empleadoHrsExt.Size = new System.Drawing.Size(116, 29);
            this.label_empleadoHrsExt.TabIndex = 8;
            this.label_empleadoHrsExt.Text = "Horas Ext";
            // 
            // label_empleadoHrsTrb
            // 
            this.label_empleadoHrsTrb.AutoSize = true;
            this.label_empleadoHrsTrb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_empleadoHrsTrb.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_empleadoHrsTrb.Location = new System.Drawing.Point(5, 121);
            this.label_empleadoHrsTrb.Name = "label_empleadoHrsTrb";
            this.label_empleadoHrsTrb.Size = new System.Drawing.Size(134, 29);
            this.label_empleadoHrsTrb.TabIndex = 7;
            this.label_empleadoHrsTrb.Text = "Horas Trab";
            // 
            // label_empleadoApellido
            // 
            this.label_empleadoApellido.AutoSize = true;
            this.label_empleadoApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_empleadoApellido.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_empleadoApellido.Location = new System.Drawing.Point(5, 83);
            this.label_empleadoApellido.Name = "label_empleadoApellido";
            this.label_empleadoApellido.Size = new System.Drawing.Size(102, 29);
            this.label_empleadoApellido.TabIndex = 6;
            this.label_empleadoApellido.Text = "Apellido";
            // 
            // label_empleadoNombre
            // 
            this.label_empleadoNombre.AutoSize = true;
            this.label_empleadoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_empleadoNombre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_empleadoNombre.Location = new System.Drawing.Point(5, 42);
            this.label_empleadoNombre.Name = "label_empleadoNombre";
            this.label_empleadoNombre.Size = new System.Drawing.Size(101, 29);
            this.label_empleadoNombre.TabIndex = 5;
            this.label_empleadoNombre.Text = "Nombre";
            // 
            // label_tituloEmpleado
            // 
            this.label_tituloEmpleado.AutoSize = true;
            this.label_tituloEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tituloEmpleado.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_tituloEmpleado.Location = new System.Drawing.Point(3, 0);
            this.label_tituloEmpleado.Name = "label_tituloEmpleado";
            this.label_tituloEmpleado.Size = new System.Drawing.Size(146, 33);
            this.label_tituloEmpleado.TabIndex = 4;
            this.label_tituloEmpleado.Text = "Empelado";
            // 
            // panel_configuracion
            // 
            this.panel_configuracion.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel_configuracion.Controls.Add(this.button_guardar);
            this.panel_configuracion.Controls.Add(this.textBox_desEPS);
            this.panel_configuracion.Controls.Add(this.textBox_desAFP);
            this.panel_configuracion.Controls.Add(this.textBox_salario);
            this.panel_configuracion.Controls.Add(this.label_desEPS);
            this.panel_configuracion.Controls.Add(this.label_descAFP);
            this.panel_configuracion.Controls.Add(this.label_salarioMinimo);
            this.panel_configuracion.Controls.Add(this.label_tituloConfiguracion);
            this.panel_configuracion.Location = new System.Drawing.Point(527, 274);
            this.panel_configuracion.Name = "panel_configuracion";
            this.panel_configuracion.Size = new System.Drawing.Size(482, 297);
            this.panel_configuracion.TabIndex = 3;
            // 
            // button_guardar
            // 
            this.button_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_guardar.Location = new System.Drawing.Point(304, 165);
            this.button_guardar.Name = "button_guardar";
            this.button_guardar.Size = new System.Drawing.Size(126, 40);
            this.button_guardar.TabIndex = 17;
            this.button_guardar.Text = "Guardar";
            this.button_guardar.UseVisualStyleBackColor = true;
            this.button_guardar.Click += new System.EventHandler(this.button_guardar_Click);
            // 
            // textBox_desEPS
            // 
            this.textBox_desEPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_desEPS.Location = new System.Drawing.Point(155, 124);
            this.textBox_desEPS.Name = "textBox_desEPS";
            this.textBox_desEPS.Size = new System.Drawing.Size(275, 35);
            this.textBox_desEPS.TabIndex = 21;
            // 
            // textBox_desAFP
            // 
            this.textBox_desAFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_desAFP.Location = new System.Drawing.Point(155, 83);
            this.textBox_desAFP.Name = "textBox_desAFP";
            this.textBox_desAFP.Size = new System.Drawing.Size(275, 35);
            this.textBox_desAFP.TabIndex = 20;
            // 
            // textBox_salario
            // 
            this.textBox_salario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_salario.Location = new System.Drawing.Point(155, 39);
            this.textBox_salario.Name = "textBox_salario";
            this.textBox_salario.Size = new System.Drawing.Size(275, 35);
            this.textBox_salario.TabIndex = 17;
            // 
            // label_desEPS
            // 
            this.label_desEPS.AutoSize = true;
            this.label_desEPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_desEPS.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_desEPS.Location = new System.Drawing.Point(4, 124);
            this.label_desEPS.Name = "label_desEPS";
            this.label_desEPS.Size = new System.Drawing.Size(116, 29);
            this.label_desEPS.TabIndex = 19;
            this.label_desEPS.Text = "DescEPS";
            // 
            // label_descAFP
            // 
            this.label_descAFP.AutoSize = true;
            this.label_descAFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_descAFP.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_descAFP.Location = new System.Drawing.Point(4, 80);
            this.label_descAFP.Name = "label_descAFP";
            this.label_descAFP.Size = new System.Drawing.Size(114, 29);
            this.label_descAFP.TabIndex = 18;
            this.label_descAFP.Text = "DescAFP";
            // 
            // label_salarioMinimo
            // 
            this.label_salarioMinimo.AutoSize = true;
            this.label_salarioMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_salarioMinimo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_salarioMinimo.Location = new System.Drawing.Point(4, 42);
            this.label_salarioMinimo.Name = "label_salarioMinimo";
            this.label_salarioMinimo.Size = new System.Drawing.Size(134, 29);
            this.label_salarioMinimo.TabIndex = 17;
            this.label_salarioMinimo.Text = "Salario Min";
            // 
            // label_tituloConfiguracion
            // 
            this.label_tituloConfiguracion.AutoSize = true;
            this.label_tituloConfiguracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tituloConfiguracion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_tituloConfiguracion.Location = new System.Drawing.Point(3, 0);
            this.label_tituloConfiguracion.Name = "label_tituloConfiguracion";
            this.label_tituloConfiguracion.Size = new System.Drawing.Size(195, 33);
            this.label_tituloConfiguracion.TabIndex = 5;
            this.label_tituloConfiguracion.Text = "Configuracion";
            // 
            // button_actualizar
            // 
            this.button_actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_actualizar.Location = new System.Drawing.Point(446, 577);
            this.button_actualizar.Name = "button_actualizar";
            this.button_actualizar.Size = new System.Drawing.Size(161, 40);
            this.button_actualizar.TabIndex = 17;
            this.button_actualizar.Text = "Actualizar";
            this.button_actualizar.UseVisualStyleBackColor = true;
            this.button_actualizar.Click += new System.EventHandler(this.button_actualizar_Click);
            // 
            // Tabla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 639);
            this.Controls.Add(this.button_actualizar);
            this.Controls.Add(this.panel_configuracion);
            this.Controls.Add(this.panel_nuevoEmpleado);
            this.Controls.Add(this.dataGridView_empleados);
            this.Controls.Add(this.label_title);
            this.Name = "Tabla";
            this.Text = "Tabla";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_empleados)).EndInit();
            this.panel_nuevoEmpleado.ResumeLayout(false);
            this.panel_nuevoEmpleado.PerformLayout();
            this.panel_configuracion.ResumeLayout(false);
            this.panel_configuracion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.DataGridView dataGridView_empleados;
        private System.Windows.Forms.Panel panel_nuevoEmpleado;
        private System.Windows.Forms.Panel panel_configuracion;
        private System.Windows.Forms.Label label_tituloEmpleado;
        private System.Windows.Forms.Label label_tituloConfiguracion;
        private System.Windows.Forms.Label label_empleadoApellido;
        private System.Windows.Forms.Label label_empleadoNombre;
        private System.Windows.Forms.Label label_empleadoHrsExt;
        private System.Windows.Forms.Label label_empleadoHrsTrb;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn HrsTrb;
        private System.Windows.Forms.DataGridViewTextBoxColumn HrsExt;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalHor;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTrans;
        private System.Windows.Forms.DataGridViewTextBoxColumn desAFP;
        private System.Windows.Forms.DataGridViewTextBoxColumn desEPS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalNet;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalFin;
        private System.Windows.Forms.TextBox textBox_empleadoNombre;
        private System.Windows.Forms.Label label_empeladoSubTrans;
        private System.Windows.Forms.TextBox textBox_empleadoSubTrans;
        private System.Windows.Forms.TextBox textBox_empleadoHrsExt;
        private System.Windows.Forms.TextBox textBox_empeladoHrsTrb;
        private System.Windows.Forms.TextBox textBox_empleadoApellido;
        private System.Windows.Forms.Button button_eliminar;
        private System.Windows.Forms.Button button_aceptar;
        private System.Windows.Forms.Button button_guardar;
        private System.Windows.Forms.TextBox textBox_desEPS;
        private System.Windows.Forms.TextBox textBox_desAFP;
        private System.Windows.Forms.TextBox textBox_salario;
        private System.Windows.Forms.Label label_desEPS;
        private System.Windows.Forms.Label label_descAFP;
        private System.Windows.Forms.Label label_salarioMinimo;
        private System.Windows.Forms.Button button_actualizar;
    }
}