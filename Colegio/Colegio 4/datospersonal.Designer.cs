namespace Colegio
{
    partial class datospersonal
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_personal = new System.Windows.Forms.Button();
            this.btn_datos_alumno = new System.Windows.Forms.Button();
            this.btn_tutores = new System.Windows.Forms.Button();
            this.tx_apellido = new System.Windows.Forms.TextBox();
            this.tx_telefono = new System.Windows.Forms.TextBox();
            this.tx_nombre = new System.Windows.Forms.TextBox();
            this.tx_dni = new System.Windows.Forms.TextBox();
            this.btn_ingresar_datos = new System.Windows.Forms.Button();
            this.tx_cargo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_base_tutores = new System.Windows.Forms.Button();
            this.btn_base_alumnos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 31);
            this.label4.TabIndex = 19;
            this.label4.Text = "Teléfono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 31);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(397, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 31);
            this.label2.TabIndex = 17;
            this.label2.Text = "Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(397, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "DNI:";
            // 
            // btn_personal
            // 
            this.btn_personal.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_personal.Enabled = false;
            this.btn_personal.Location = new System.Drawing.Point(89, -2);
            this.btn_personal.Name = "btn_personal";
            this.btn_personal.Size = new System.Drawing.Size(84, 44);
            this.btn_personal.TabIndex = 13;
            this.btn_personal.Text = "Personal";
            this.btn_personal.UseVisualStyleBackColor = false;
            // 
            // btn_datos_alumno
            // 
            this.btn_datos_alumno.BackColor = System.Drawing.Color.MistyRose;
            this.btn_datos_alumno.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_datos_alumno.Location = new System.Drawing.Point(-1, -2);
            this.btn_datos_alumno.Name = "btn_datos_alumno";
            this.btn_datos_alumno.Size = new System.Drawing.Size(93, 44);
            this.btn_datos_alumno.TabIndex = 12;
            this.btn_datos_alumno.Text = "Datos del Alumno";
            this.btn_datos_alumno.UseVisualStyleBackColor = false;
            this.btn_datos_alumno.Click += new System.EventHandler(this.btn_datos_alumno_Click);
            // 
            // btn_tutores
            // 
            this.btn_tutores.BackColor = System.Drawing.Color.LightCyan;
            this.btn_tutores.Location = new System.Drawing.Point(168, -2);
            this.btn_tutores.Name = "btn_tutores";
            this.btn_tutores.Size = new System.Drawing.Size(86, 44);
            this.btn_tutores.TabIndex = 20;
            this.btn_tutores.Text = "Tutores";
            this.btn_tutores.UseVisualStyleBackColor = false;
            this.btn_tutores.Click += new System.EventHandler(this.btn_tutores_Click);
            // 
            // tx_apellido
            // 
            this.tx_apellido.Location = new System.Drawing.Point(521, 97);
            this.tx_apellido.Name = "tx_apellido";
            this.tx_apellido.Size = new System.Drawing.Size(149, 20);
            this.tx_apellido.TabIndex = 21;
            // 
            // tx_telefono
            // 
            this.tx_telefono.Location = new System.Drawing.Point(168, 197);
            this.tx_telefono.Name = "tx_telefono";
            this.tx_telefono.Size = new System.Drawing.Size(181, 20);
            this.tx_telefono.TabIndex = 22;
            // 
            // tx_nombre
            // 
            this.tx_nombre.Location = new System.Drawing.Point(168, 143);
            this.tx_nombre.Name = "tx_nombre";
            this.tx_nombre.Size = new System.Drawing.Size(181, 20);
            this.tx_nombre.TabIndex = 23;
            // 
            // tx_dni
            // 
            this.tx_dni.Location = new System.Drawing.Point(521, 143);
            this.tx_dni.Name = "tx_dni";
            this.tx_dni.Size = new System.Drawing.Size(149, 20);
            this.tx_dni.TabIndex = 24;
            // 
            // btn_ingresar_datos
            // 
            this.btn_ingresar_datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ingresar_datos.Location = new System.Drawing.Point(298, 267);
            this.btn_ingresar_datos.Name = "btn_ingresar_datos";
            this.btn_ingresar_datos.Size = new System.Drawing.Size(158, 58);
            this.btn_ingresar_datos.TabIndex = 26;
            this.btn_ingresar_datos.Text = "Ingresar Datos";
            this.btn_ingresar_datos.UseVisualStyleBackColor = true;
            this.btn_ingresar_datos.Click += new System.EventHandler(this.btn_ingresar_datos_Click);
            // 
            // tx_cargo
            // 
            this.tx_cargo.Location = new System.Drawing.Point(521, 196);
            this.tx_cargo.Name = "tx_cargo";
            this.tx_cargo.Size = new System.Drawing.Size(149, 20);
            this.tx_cargo.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(397, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 31);
            this.label5.TabIndex = 28;
            this.label5.Text = "Cargo:";
            // 
            // btn_base_tutores
            // 
            this.btn_base_tutores.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_base_tutores.Location = new System.Drawing.Point(381, -2);
            this.btn_base_tutores.Name = "btn_base_tutores";
            this.btn_base_tutores.Size = new System.Drawing.Size(75, 44);
            this.btn_base_tutores.TabIndex = 41;
            this.btn_base_tutores.Text = "Base Tutores";
            this.btn_base_tutores.UseVisualStyleBackColor = false;
            this.btn_base_tutores.Click += new System.EventHandler(this.btn_base_tutores_Click);
            // 
            // btn_base_alumnos
            // 
            this.btn_base_alumnos.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_base_alumnos.Location = new System.Drawing.Point(310, -2);
            this.btn_base_alumnos.Name = "btn_base_alumnos";
            this.btn_base_alumnos.Size = new System.Drawing.Size(75, 44);
            this.btn_base_alumnos.TabIndex = 40;
            this.btn_base_alumnos.Text = "Base Alumnos";
            this.btn_base_alumnos.UseVisualStyleBackColor = false;
            this.btn_base_alumnos.Click += new System.EventHandler(this.btn_base_alumnos_Click);
            // 
            // datospersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(734, 337);
            this.Controls.Add(this.btn_base_tutores);
            this.Controls.Add(this.btn_base_alumnos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tx_cargo);
            this.Controls.Add(this.btn_ingresar_datos);
            this.Controls.Add(this.tx_dni);
            this.Controls.Add(this.tx_nombre);
            this.Controls.Add(this.tx_telefono);
            this.Controls.Add(this.tx_apellido);
            this.Controls.Add(this.btn_tutores);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_personal);
            this.Controls.Add(this.btn_datos_alumno);
            this.Name = "datospersonal";
            this.Text = " ";
            this.Load += new System.EventHandler(this.datospersonal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_personal;
        private System.Windows.Forms.Button btn_datos_alumno;
        private System.Windows.Forms.Button btn_tutores;
        private System.Windows.Forms.TextBox tx_apellido;
        private System.Windows.Forms.TextBox tx_telefono;
        private System.Windows.Forms.TextBox tx_nombre;
        private System.Windows.Forms.TextBox tx_dni;
        private System.Windows.Forms.Button btn_ingresar_datos;
        private System.Windows.Forms.TextBox tx_cargo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_base_tutores;
        private System.Windows.Forms.Button btn_base_alumnos;
    }
}