namespace Colegio
{
    partial class datostutores
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
            this.btn_tutores = new System.Windows.Forms.Button();
            this.btn_personal = new System.Windows.Forms.Button();
            this.btn_datos_alumnos = new System.Windows.Forms.Button();
            this.tx_nacimiento_fecha = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tx_dni = new System.Windows.Forms.TextBox();
            this.tx_tel_telefono = new System.Windows.Forms.TextBox();
            this.tx_domicilo = new System.Windows.Forms.TextBox();
            this.tx_nacimiento_lugar = new System.Windows.Forms.TextBox();
            this.tx_nombre = new System.Windows.Forms.TextBox();
            this.tx_apellido = new System.Windows.Forms.TextBox();
            this.tx_tel_celular = new System.Windows.Forms.TextBox();
            this.tx_tel_trabajo = new System.Windows.Forms.TextBox();
            this.tx_nacionalidad = new System.Windows.Forms.CheckedListBox();
            this.Ingresar = new System.Windows.Forms.Button();
            this.btn_base_tutores = new System.Windows.Forms.Button();
            this.btn_base_alumnos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_tutores
            // 
            this.btn_tutores.BackColor = System.Drawing.Color.LightCyan;
            this.btn_tutores.Enabled = false;
            this.btn_tutores.Location = new System.Drawing.Point(164, -1);
            this.btn_tutores.Name = "btn_tutores";
            this.btn_tutores.Size = new System.Drawing.Size(86, 44);
            this.btn_tutores.TabIndex = 22;
            this.btn_tutores.Text = "Tutores";
            this.btn_tutores.UseVisualStyleBackColor = false;
            // 
            // btn_personal
            // 
            this.btn_personal.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_personal.Location = new System.Drawing.Point(85, -1);
            this.btn_personal.Name = "btn_personal";
            this.btn_personal.Size = new System.Drawing.Size(84, 44);
            this.btn_personal.TabIndex = 21;
            this.btn_personal.Text = "Personal";
            this.btn_personal.UseVisualStyleBackColor = false;
            this.btn_personal.Click += new System.EventHandler(this.btn_personal_Click);
            // 
            // btn_datos_alumnos
            // 
            this.btn_datos_alumnos.BackColor = System.Drawing.Color.MistyRose;
            this.btn_datos_alumnos.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_datos_alumnos.Location = new System.Drawing.Point(-3, -1);
            this.btn_datos_alumnos.Name = "btn_datos_alumnos";
            this.btn_datos_alumnos.Size = new System.Drawing.Size(93, 44);
            this.btn_datos_alumnos.TabIndex = 20;
            this.btn_datos_alumnos.Text = "Datos del Alumno";
            this.btn_datos_alumnos.UseVisualStyleBackColor = false;
            this.btn_datos_alumnos.Click += new System.EventHandler(this.btn_datos_alumnos_Click);
            // 
            // tx_nacimiento_fecha
            // 
            this.tx_nacimiento_fecha.Location = new System.Drawing.Point(321, 273);
            this.tx_nacimiento_fecha.Name = "tx_nacimiento_fecha";
            this.tx_nacimiento_fecha.Size = new System.Drawing.Size(200, 20);
            this.tx_nacimiento_fecha.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(596, 390);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(245, 31);
            this.label10.TabIndex = 33;
            this.label10.Text = "Número de trabajo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(569, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 31);
            this.label9.TabIndex = 32;
            this.label9.Text = "Nacionalidad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(42, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(266, 31);
            this.label8.TabIndex = 31;
            this.label8.Text = "Lugar de nacimiento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(273, 31);
            this.label7.TabIndex = 30;
            this.label7.Text = "Fecha de nacimiento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 31);
            this.label6.TabIndex = 29;
            this.label6.Text = "Domicilio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(344, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 31);
            this.label5.TabIndex = 28;
            this.label5.Text = "Celular:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 31);
            this.label4.TabIndex = 27;
            this.label4.Text = "Teléfono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 31);
            this.label3.TabIndex = 26;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(435, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 31);
            this.label2.TabIndex = 25;
            this.label2.Text = "Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 31);
            this.label1.TabIndex = 24;
            this.label1.Text = "DNI:";
            // 
            // tx_dni
            // 
            this.tx_dni.Location = new System.Drawing.Point(160, 95);
            this.tx_dni.Name = "tx_dni";
            this.tx_dni.Size = new System.Drawing.Size(146, 20);
            this.tx_dni.TabIndex = 35;
            // 
            // tx_tel_telefono
            // 
            this.tx_tel_telefono.Location = new System.Drawing.Point(175, 402);
            this.tx_tel_telefono.Name = "tx_tel_telefono";
            this.tx_tel_telefono.Size = new System.Drawing.Size(126, 20);
            this.tx_tel_telefono.TabIndex = 36;
            // 
            // tx_domicilo
            // 
            this.tx_domicilo.Location = new System.Drawing.Point(180, 210);
            this.tx_domicilo.Name = "tx_domicilo";
            this.tx_domicilo.Size = new System.Drawing.Size(332, 20);
            this.tx_domicilo.TabIndex = 37;
            // 
            // tx_nacimiento_lugar
            // 
            this.tx_nacimiento_lugar.Location = new System.Drawing.Point(305, 338);
            this.tx_nacimiento_lugar.Name = "tx_nacimiento_lugar";
            this.tx_nacimiento_lugar.Size = new System.Drawing.Size(159, 20);
            this.tx_nacimiento_lugar.TabIndex = 38;
            // 
            // tx_nombre
            // 
            this.tx_nombre.Location = new System.Drawing.Point(164, 149);
            this.tx_nombre.Name = "tx_nombre";
            this.tx_nombre.Size = new System.Drawing.Size(142, 20);
            this.tx_nombre.TabIndex = 39;
            // 
            // tx_apellido
            // 
            this.tx_apellido.Location = new System.Drawing.Point(559, 149);
            this.tx_apellido.Name = "tx_apellido";
            this.tx_apellido.Size = new System.Drawing.Size(151, 20);
            this.tx_apellido.TabIndex = 41;
            // 
            // tx_tel_celular
            // 
            this.tx_tel_celular.Location = new System.Drawing.Point(459, 402);
            this.tx_tel_celular.Name = "tx_tel_celular";
            this.tx_tel_celular.Size = new System.Drawing.Size(100, 20);
            this.tx_tel_celular.TabIndex = 42;
            // 
            // tx_tel_trabajo
            // 
            this.tx_tel_trabajo.Location = new System.Drawing.Point(848, 402);
            this.tx_tel_trabajo.Name = "tx_tel_trabajo";
            this.tx_tel_trabajo.Size = new System.Drawing.Size(155, 20);
            this.tx_tel_trabajo.TabIndex = 43;
            // 
            // tx_nacionalidad
            // 
            this.tx_nacionalidad.FormattingEnabled = true;
            this.tx_nacionalidad.Items.AddRange(new object[] {
            "Argentina",
            "Uruguaya",
            "Peruana",
            "Boliviana ",
            "Otra"});
            this.tx_nacionalidad.Location = new System.Drawing.Point(754, 264);
            this.tx_nacionalidad.Name = "tx_nacionalidad";
            this.tx_nacionalidad.Size = new System.Drawing.Size(152, 79);
            this.tx_nacionalidad.TabIndex = 44;
            // 
            // Ingresar
            // 
            this.Ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ingresar.Location = new System.Drawing.Point(369, 457);
            this.Ingresar.Name = "Ingresar";
            this.Ingresar.Size = new System.Drawing.Size(235, 63);
            this.Ingresar.TabIndex = 45;
            this.Ingresar.Text = "Ingresar Valores";
            this.Ingresar.UseVisualStyleBackColor = true;
            this.Ingresar.Click += new System.EventHandler(this.Ingresar_Click_1);
            // 
            // btn_base_tutores
            // 
            this.btn_base_tutores.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_base_tutores.Location = new System.Drawing.Point(441, -1);
            this.btn_base_tutores.Name = "btn_base_tutores";
            this.btn_base_tutores.Size = new System.Drawing.Size(75, 44);
            this.btn_base_tutores.TabIndex = 47;
            this.btn_base_tutores.Text = "Base Tutores";
            this.btn_base_tutores.UseVisualStyleBackColor = false;
            this.btn_base_tutores.Click += new System.EventHandler(this.btn_base_tutores_Click);
            // 
            // btn_base_alumnos
            // 
            this.btn_base_alumnos.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_base_alumnos.Location = new System.Drawing.Point(370, -1);
            this.btn_base_alumnos.Name = "btn_base_alumnos";
            this.btn_base_alumnos.Size = new System.Drawing.Size(75, 44);
            this.btn_base_alumnos.TabIndex = 46;
            this.btn_base_alumnos.Text = "Base Alumnos";
            this.btn_base_alumnos.UseVisualStyleBackColor = false;
            this.btn_base_alumnos.Click += new System.EventHandler(this.btn_base_alumnos_Click);
            // 
            // datostutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1025, 528);
            this.Controls.Add(this.btn_base_tutores);
            this.Controls.Add(this.btn_base_alumnos);
            this.Controls.Add(this.Ingresar);
            this.Controls.Add(this.tx_nacionalidad);
            this.Controls.Add(this.tx_tel_trabajo);
            this.Controls.Add(this.tx_tel_celular);
            this.Controls.Add(this.tx_apellido);
            this.Controls.Add(this.tx_nombre);
            this.Controls.Add(this.tx_nacimiento_lugar);
            this.Controls.Add(this.tx_domicilo);
            this.Controls.Add(this.tx_tel_telefono);
            this.Controls.Add(this.tx_dni);
            this.Controls.Add(this.tx_nacimiento_fecha);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_tutores);
            this.Controls.Add(this.btn_personal);
            this.Controls.Add(this.btn_datos_alumnos);
            this.Name = "datostutores";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_tutores;
        private System.Windows.Forms.Button btn_personal;
        private System.Windows.Forms.Button btn_datos_alumnos;
        private System.Windows.Forms.DateTimePicker tx_nacimiento_fecha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tx_dni;
        private System.Windows.Forms.TextBox tx_tel_telefono;
        private System.Windows.Forms.TextBox tx_domicilo;
        private System.Windows.Forms.TextBox tx_nacimiento_lugar;
        private System.Windows.Forms.TextBox tx_nombre;
        private System.Windows.Forms.TextBox tx_apellido;
        private System.Windows.Forms.TextBox tx_tel_celular;
        private System.Windows.Forms.TextBox tx_tel_trabajo;
        private System.Windows.Forms.CheckedListBox tx_nacionalidad;
        private System.Windows.Forms.Button Ingresar;
        private System.Windows.Forms.Button btn_base_tutores;
        private System.Windows.Forms.Button btn_base_alumnos;
    }
}