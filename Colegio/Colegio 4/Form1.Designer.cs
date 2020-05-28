namespace Colegio
{
    partial class form_inicio
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
            this.lb_inicio = new System.Windows.Forms.Label();
            this.lb_usuario = new System.Windows.Forms.Label();
            this.lb_contraseña = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.btn_tutores = new System.Windows.Forms.Button();
            this.btn_personal = new System.Windows.Forms.Button();
            this.btn_datos_alumnos = new System.Windows.Forms.Button();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.dgv_usuario = new System.Windows.Forms.DataGridView();
            this.dgv_contraseña = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_DNI = new System.Windows.Forms.TextBox();
            this.btn_registrarse = new System.Windows.Forms.Button();
            this.btn_base_alumnos = new System.Windows.Forms.Button();
            this.btn_base_tutores = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_contraseña)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_inicio
            // 
            this.lb_inicio.AutoSize = true;
            this.lb_inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_inicio.Location = new System.Drawing.Point(190, 53);
            this.lb_inicio.Name = "lb_inicio";
            this.lb_inicio.Size = new System.Drawing.Size(104, 42);
            this.lb_inicio.TabIndex = 4;
            this.lb_inicio.Text = "Inicio";
            // 
            // lb_usuario
            // 
            this.lb_usuario.AutoSize = true;
            this.lb_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_usuario.Location = new System.Drawing.Point(81, 173);
            this.lb_usuario.Name = "lb_usuario";
            this.lb_usuario.Size = new System.Drawing.Size(157, 42);
            this.lb_usuario.TabIndex = 5;
            this.lb_usuario.Text = "Usuario:";
            // 
            // lb_contraseña
            // 
            this.lb_contraseña.AutoSize = true;
            this.lb_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_contraseña.Location = new System.Drawing.Point(16, 215);
            this.lb_contraseña.Name = "lb_contraseña";
            this.lb_contraseña.Size = new System.Drawing.Size(222, 42);
            this.lb_contraseña.TabIndex = 6;
            this.lb_contraseña.Text = "Contraseña:";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(249, 184);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(162, 20);
            this.txt_usuario.TabIndex = 7;
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Location = new System.Drawing.Point(249, 230);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(162, 20);
            this.txt_contraseña.TabIndex = 8;
            this.txt_contraseña.UseSystemPasswordChar = true;
            // 
            // btn_tutores
            // 
            this.btn_tutores.BackColor = System.Drawing.Color.LightCyan;
            this.btn_tutores.Location = new System.Drawing.Point(166, -3);
            this.btn_tutores.Name = "btn_tutores";
            this.btn_tutores.Size = new System.Drawing.Size(86, 44);
            this.btn_tutores.TabIndex = 18;
            this.btn_tutores.Text = "Tutores";
            this.btn_tutores.UseVisualStyleBackColor = false;
            this.btn_tutores.Visible = false;
            this.btn_tutores.Click += new System.EventHandler(this.btn_tutores_Click);
            // 
            // btn_personal
            // 
            this.btn_personal.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_personal.Location = new System.Drawing.Point(86, -3);
            this.btn_personal.Name = "btn_personal";
            this.btn_personal.Size = new System.Drawing.Size(84, 44);
            this.btn_personal.TabIndex = 17;
            this.btn_personal.Text = "Personal";
            this.btn_personal.UseVisualStyleBackColor = false;
            this.btn_personal.Visible = false;
            this.btn_personal.Click += new System.EventHandler(this.btn_personal_Click);
            // 
            // btn_datos_alumnos
            // 
            this.btn_datos_alumnos.BackColor = System.Drawing.Color.MistyRose;
            this.btn_datos_alumnos.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_datos_alumnos.Location = new System.Drawing.Point(-3, -3);
            this.btn_datos_alumnos.Name = "btn_datos_alumnos";
            this.btn_datos_alumnos.Size = new System.Drawing.Size(93, 44);
            this.btn_datos_alumnos.TabIndex = 16;
            this.btn_datos_alumnos.Text = "Datos del Alumno";
            this.btn_datos_alumnos.UseVisualStyleBackColor = false;
            this.btn_datos_alumnos.Visible = false;
            this.btn_datos_alumnos.Click += new System.EventHandler(this.btn_datos_alumnos_Click);
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ingresar.Location = new System.Drawing.Point(139, 286);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(131, 48);
            this.btn_ingresar.TabIndex = 20;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.UseVisualStyleBackColor = true;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // dgv_usuario
            // 
            this.dgv_usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usuario.Location = new System.Drawing.Point(644, 41);
            this.dgv_usuario.Name = "dgv_usuario";
            this.dgv_usuario.Size = new System.Drawing.Size(240, 150);
            this.dgv_usuario.TabIndex = 21;
            // 
            // dgv_contraseña
            // 
            this.dgv_contraseña.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_contraseña.Location = new System.Drawing.Point(644, 198);
            this.dgv_contraseña.Name = "dgv_contraseña";
            this.dgv_contraseña.Size = new System.Drawing.Size(240, 150);
            this.dgv_contraseña.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 42);
            this.label1.TabIndex = 23;
            this.label1.Text = "DNI:";
            // 
            // tb_DNI
            // 
            this.tb_DNI.Location = new System.Drawing.Point(249, 132);
            this.tb_DNI.Name = "tb_DNI";
            this.tb_DNI.Size = new System.Drawing.Size(162, 20);
            this.tb_DNI.TabIndex = 24;
            this.tb_DNI.TextChanged += new System.EventHandler(this.tb_DNI_TextChanged);
            // 
            // btn_registrarse
            // 
            this.btn_registrarse.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_registrarse.Location = new System.Drawing.Point(451, -3);
            this.btn_registrarse.Name = "btn_registrarse";
            this.btn_registrarse.Size = new System.Drawing.Size(75, 44);
            this.btn_registrarse.TabIndex = 25;
            this.btn_registrarse.Text = "Registrarse";
            this.btn_registrarse.UseVisualStyleBackColor = false;
            this.btn_registrarse.Click += new System.EventHandler(this.btn_registrarse_Click);
            // 
            // btn_base_alumnos
            // 
            this.btn_base_alumnos.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_base_alumnos.Location = new System.Drawing.Point(288, -3);
            this.btn_base_alumnos.Name = "btn_base_alumnos";
            this.btn_base_alumnos.Size = new System.Drawing.Size(75, 44);
            this.btn_base_alumnos.TabIndex = 26;
            this.btn_base_alumnos.Text = "Base Alumnos";
            this.btn_base_alumnos.UseVisualStyleBackColor = false;
            this.btn_base_alumnos.Visible = false;
            this.btn_base_alumnos.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_base_tutores
            // 
            this.btn_base_tutores.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_base_tutores.Location = new System.Drawing.Point(359, -3);
            this.btn_base_tutores.Name = "btn_base_tutores";
            this.btn_base_tutores.Size = new System.Drawing.Size(75, 44);
            this.btn_base_tutores.TabIndex = 27;
            this.btn_base_tutores.Text = "Base Tutores";
            this.btn_base_tutores.UseVisualStyleBackColor = false;
            this.btn_base_tutores.Visible = false;
            this.btn_base_tutores.Click += new System.EventHandler(this.button2_Click);
            // 
            // form_inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 348);
            this.Controls.Add(this.btn_base_tutores);
            this.Controls.Add(this.btn_base_alumnos);
            this.Controls.Add(this.btn_registrarse);
            this.Controls.Add(this.tb_DNI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_contraseña);
            this.Controls.Add(this.dgv_usuario);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.btn_tutores);
            this.Controls.Add(this.btn_personal);
            this.Controls.Add(this.btn_datos_alumnos);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.lb_contraseña);
            this.Controls.Add(this.lb_usuario);
            this.Controls.Add(this.lb_inicio);
            this.Name = "form_inicio";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_contraseña)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_inicio;
        private System.Windows.Forms.Label lb_usuario;
        private System.Windows.Forms.Label lb_contraseña;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.Button btn_tutores;
        private System.Windows.Forms.Button btn_personal;
        private System.Windows.Forms.Button btn_datos_alumnos;
        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.DataGridView dgv_usuario;
        private System.Windows.Forms.DataGridView dgv_contraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_DNI;
        private System.Windows.Forms.Button btn_registrarse;
        private System.Windows.Forms.Button btn_base_alumnos;
        private System.Windows.Forms.Button btn_base_tutores;
    }
}

