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
            this.panel_nuevoEmpleado = new System.Windows.Forms.Panel();
            this.panel_configuracion = new System.Windows.Forms.Panel();
            this.label_tituloEmpleado = new System.Windows.Forms.Label();
            this.label_tituloConfiguracion = new System.Windows.Forms.Label();
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
            this.dataGridView_empleados.Location = new System.Drawing.Point(18, 45);
            this.dataGridView_empleados.Name = "dataGridView_empleados";
            this.dataGridView_empleados.ReadOnly = true;
            this.dataGridView_empleados.Size = new System.Drawing.Size(770, 223);
            this.dataGridView_empleados.TabIndex = 1;
            // 
            // panel_nuevoEmpleado
            // 
            this.panel_nuevoEmpleado.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel_nuevoEmpleado.Controls.Add(this.label_tituloEmpleado);
            this.panel_nuevoEmpleado.Location = new System.Drawing.Point(18, 274);
            this.panel_nuevoEmpleado.Name = "panel_nuevoEmpleado";
            this.panel_nuevoEmpleado.Size = new System.Drawing.Size(373, 164);
            this.panel_nuevoEmpleado.TabIndex = 2;
            // 
            // panel_configuracion
            // 
            this.panel_configuracion.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel_configuracion.Controls.Add(this.label_tituloConfiguracion);
            this.panel_configuracion.Location = new System.Drawing.Point(397, 274);
            this.panel_configuracion.Name = "panel_configuracion";
            this.panel_configuracion.Size = new System.Drawing.Size(391, 164);
            this.panel_configuracion.TabIndex = 3;
            // 
            // label_tituloEmpleado
            // 
            this.label_tituloEmpleado.AutoSize = true;
            this.label_tituloEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tituloEmpleado.Location = new System.Drawing.Point(3, 0);
            this.label_tituloEmpleado.Name = "label_tituloEmpleado";
            this.label_tituloEmpleado.Size = new System.Drawing.Size(146, 33);
            this.label_tituloEmpleado.TabIndex = 4;
            this.label_tituloEmpleado.Text = "Empelado";
            this.label_tituloEmpleado.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_tituloConfiguracion
            // 
            this.label_tituloConfiguracion.AutoSize = true;
            this.label_tituloConfiguracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tituloConfiguracion.Location = new System.Drawing.Point(3, 0);
            this.label_tituloConfiguracion.Name = "label_tituloConfiguracion";
            this.label_tituloConfiguracion.Size = new System.Drawing.Size(195, 33);
            this.label_tituloConfiguracion.TabIndex = 5;
            this.label_tituloConfiguracion.Text = "Configuracion";
            // 
            // Tabla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}