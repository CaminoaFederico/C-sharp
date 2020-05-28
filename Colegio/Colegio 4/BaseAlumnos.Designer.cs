namespace Colegio
{
    partial class BaseAlumnos
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
            this.rtb_alumnos = new System.Windows.Forms.RichTextBox();
            this.lb_domicilio = new System.Windows.Forms.Label();
            this.lb_dni = new System.Windows.Forms.Label();
            this.lb_fecha_nacimiento = new System.Windows.Forms.Label();
            this.lb_lugar_nacimiento = new System.Windows.Forms.Label();
            this.lb_nacionalidad = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.btn_tutores = new System.Windows.Forms.Button();
            this.cb_año = new System.Windows.Forms.ComboBox();
            this.cb_division = new System.Windows.Forms.ComboBox();
            this.lb_alumno = new System.Windows.Forms.Label();
            this.btn_volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtb_alumnos
            // 
            this.rtb_alumnos.Location = new System.Drawing.Point(29, 115);
            this.rtb_alumnos.Name = "rtb_alumnos";
            this.rtb_alumnos.Size = new System.Drawing.Size(115, 397);
            this.rtb_alumnos.TabIndex = 0;
            this.rtb_alumnos.Text = "1\n2\n3\n4\n5\n6\n7\n8\n9\n10\n11\n12\n13\n14\n15\n16\n17\n18\n19\n20\n21\n22\n23\n24\n25\n26\n27\n28\n29\n30";
            this.rtb_alumnos.TextChanged += new System.EventHandler(this.rtb_alumnos_TextChanged);
            // 
            // lb_domicilio
            // 
            this.lb_domicilio.AutoSize = true;
            this.lb_domicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_domicilio.Location = new System.Drawing.Point(287, 87);
            this.lb_domicilio.Name = "lb_domicilio";
            this.lb_domicilio.Size = new System.Drawing.Size(64, 16);
            this.lb_domicilio.TabIndex = 2;
            this.lb_domicilio.Text = "Domicilio";
            this.lb_domicilio.Click += new System.EventHandler(this.lb_domicilio_Click);
            // 
            // lb_dni
            // 
            this.lb_dni.AutoSize = true;
            this.lb_dni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dni.Location = new System.Drawing.Point(420, 87);
            this.lb_dni.Name = "lb_dni";
            this.lb_dni.Size = new System.Drawing.Size(31, 16);
            this.lb_dni.TabIndex = 3;
            this.lb_dni.Text = "DNI";
            this.lb_dni.Click += new System.EventHandler(this.lb_dni_Click);
            // 
            // lb_fecha_nacimiento
            // 
            this.lb_fecha_nacimiento.AutoSize = true;
            this.lb_fecha_nacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fecha_nacimiento.Location = new System.Drawing.Point(492, 87);
            this.lb_fecha_nacimiento.Name = "lb_fecha_nacimiento";
            this.lb_fecha_nacimiento.Size = new System.Drawing.Size(122, 15);
            this.lb_fecha_nacimiento.TabIndex = 4;
            this.lb_fecha_nacimiento.Text = "Fecha de nacimiento";
            this.lb_fecha_nacimiento.Click += new System.EventHandler(this.lb_fecha_nacimiento_Click);
            // 
            // lb_lugar_nacimiento
            // 
            this.lb_lugar_nacimiento.AutoSize = true;
            this.lb_lugar_nacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_lugar_nacimiento.Location = new System.Drawing.Point(627, 87);
            this.lb_lugar_nacimiento.Name = "lb_lugar_nacimiento";
            this.lb_lugar_nacimiento.Size = new System.Drawing.Size(120, 15);
            this.lb_lugar_nacimiento.TabIndex = 5;
            this.lb_lugar_nacimiento.Text = "Lugar de nacimiento";
            this.lb_lugar_nacimiento.Click += new System.EventHandler(this.lb_lugar_nacimiento_Click);
            // 
            // lb_nacionalidad
            // 
            this.lb_nacionalidad.AutoSize = true;
            this.lb_nacionalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nacionalidad.Location = new System.Drawing.Point(762, 87);
            this.lb_nacionalidad.Name = "lb_nacionalidad";
            this.lb_nacionalidad.Size = new System.Drawing.Size(89, 16);
            this.lb_nacionalidad.TabIndex = 6;
            this.lb_nacionalidad.Text = "Nacionalidad";
            this.lb_nacionalidad.Click += new System.EventHandler(this.lb_nacionalidad_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(252, 115);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(115, 397);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(373, 115);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(116, 397);
            this.richTextBox2.TabIndex = 8;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(619, 115);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(117, 397);
            this.richTextBox3.TabIndex = 9;
            this.richTextBox3.Text = "";
            this.richTextBox3.TextChanged += new System.EventHandler(this.richTextBox3_TextChanged);
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(495, 115);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(118, 397);
            this.richTextBox4.TabIndex = 10;
            this.richTextBox4.Text = "";
            this.richTextBox4.TextChanged += new System.EventHandler(this.richTextBox4_TextChanged);
            // 
            // richTextBox5
            // 
            this.richTextBox5.Location = new System.Drawing.Point(742, 115);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(114, 397);
            this.richTextBox5.TabIndex = 11;
            this.richTextBox5.Text = "";
            this.richTextBox5.TextChanged += new System.EventHandler(this.richTextBox5_TextChanged);
            // 
            // btn_tutores
            // 
            this.btn_tutores.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_tutores.Location = new System.Drawing.Point(41, 12);
            this.btn_tutores.Name = "btn_tutores";
            this.btn_tutores.Size = new System.Drawing.Size(90, 46);
            this.btn_tutores.TabIndex = 12;
            this.btn_tutores.Text = "Tutores";
            this.btn_tutores.UseVisualStyleBackColor = false;
            this.btn_tutores.Click += new System.EventHandler(this.btn_tutores_Click);
            // 
            // cb_año
            // 
            this.cb_año.FormattingEnabled = true;
            this.cb_año.Location = new System.Drawing.Point(492, 12);
            this.cb_año.Name = "cb_año";
            this.cb_año.Size = new System.Drawing.Size(121, 21);
            this.cb_año.TabIndex = 13;
            this.cb_año.Text = "Año";
            this.cb_año.SelectedIndexChanged += new System.EventHandler(this.cb_año_SelectedIndexChanged);
            // 
            // cb_division
            // 
            this.cb_division.FormattingEnabled = true;
            this.cb_division.Location = new System.Drawing.Point(700, 12);
            this.cb_division.Name = "cb_division";
            this.cb_division.Size = new System.Drawing.Size(121, 21);
            this.cb_division.TabIndex = 14;
            this.cb_division.Text = "División";
            this.cb_division.SelectedIndexChanged += new System.EventHandler(this.cb_division_SelectedIndexChanged);
            // 
            // lb_alumno
            // 
            this.lb_alumno.AutoSize = true;
            this.lb_alumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_alumno.Location = new System.Drawing.Point(56, 88);
            this.lb_alumno.Name = "lb_alumno";
            this.lb_alumno.Size = new System.Drawing.Size(59, 16);
            this.lb_alumno.TabIndex = 15;
            this.lb_alumno.Text = "Alumno";
            this.lb_alumno.Click += new System.EventHandler(this.lb_alumno_Click);
            // 
            // btn_volver
            // 
            this.btn_volver.BackColor = System.Drawing.Color.Gold;
            this.btn_volver.Location = new System.Drawing.Point(162, 12);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(77, 46);
            this.btn_volver.TabIndex = 16;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // BaseAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(880, 526);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.lb_alumno);
            this.Controls.Add(this.cb_division);
            this.Controls.Add(this.cb_año);
            this.Controls.Add(this.btn_tutores);
            this.Controls.Add(this.richTextBox5);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lb_nacionalidad);
            this.Controls.Add(this.lb_lugar_nacimiento);
            this.Controls.Add(this.lb_fecha_nacimiento);
            this.Controls.Add(this.lb_dni);
            this.Controls.Add(this.lb_domicilio);
            this.Controls.Add(this.rtb_alumnos);
            this.Name = "BaseAlumnos";
            this.Text = "BaseAlumnos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_alumnos;
        private System.Windows.Forms.Label lb_domicilio;
        private System.Windows.Forms.Label lb_dni;
        private System.Windows.Forms.Label lb_fecha_nacimiento;
        private System.Windows.Forms.Label lb_lugar_nacimiento;
        private System.Windows.Forms.Label lb_nacionalidad;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.Button btn_tutores;
        private System.Windows.Forms.ComboBox cb_año;
        private System.Windows.Forms.ComboBox cb_division;
        private System.Windows.Forms.Label lb_alumno;
        private System.Windows.Forms.Button btn_volver;
    }
}