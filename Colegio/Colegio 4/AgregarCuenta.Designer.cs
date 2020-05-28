namespace Colegio
{
    partial class AgregarCuenta
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_agregar = new System.Windows.Forms.Button();
            this.tx_cargo = new System.Windows.Forms.ComboBox();
            this.tx_contraseña = new System.Windows.Forms.TextBox();
            this.tx_usuario = new System.Windows.Forms.TextBox();
            this.tx_dni = new System.Windows.Forms.TextBox();
            this.lb_usuario = new System.Windows.Forms.Label();
            this.lb_contraseña = new System.Windows.Forms.Label();
            this.lb_dni = new System.Windows.Forms.Label();
            this.lb_cargo = new System.Windows.Forms.Label();
            this.lb_autenticacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_agregar
            // 
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Location = new System.Drawing.Point(202, 131);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(126, 35);
            this.btn_agregar.TabIndex = 1;
            this.btn_agregar.Text = "AGREGAR";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // tx_cargo
            // 
            this.tx_cargo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tx_cargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_cargo.FormattingEnabled = true;
            this.tx_cargo.Items.AddRange(new object[] {
            "Director",
            "Vicedirector",
            "Secretario",
            "Profesor",
            "Docente",
            "Tareas Pasivas",
            "Suplente"});
            this.tx_cargo.Location = new System.Drawing.Point(116, 81);
            this.tx_cargo.Name = "tx_cargo";
            this.tx_cargo.Size = new System.Drawing.Size(139, 21);
            this.tx_cargo.TabIndex = 2;
            this.tx_cargo.Text = "-- Elija  --";
            // 
            // tx_contraseña
            // 
            this.tx_contraseña.Location = new System.Drawing.Point(363, 29);
            this.tx_contraseña.Name = "tx_contraseña";
            this.tx_contraseña.Size = new System.Drawing.Size(100, 20);
            this.tx_contraseña.TabIndex = 3;
            // 
            // tx_usuario
            // 
            this.tx_usuario.Location = new System.Drawing.Point(121, 29);
            this.tx_usuario.Name = "tx_usuario";
            this.tx_usuario.Size = new System.Drawing.Size(100, 20);
            this.tx_usuario.TabIndex = 4;
            // 
            // tx_dni
            // 
            this.tx_dni.Location = new System.Drawing.Point(363, 81);
            this.tx_dni.Name = "tx_dni";
            this.tx_dni.Size = new System.Drawing.Size(100, 20);
            this.tx_dni.TabIndex = 5;
            // 
            // lb_usuario
            // 
            this.lb_usuario.AutoSize = true;
            this.lb_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_usuario.Location = new System.Drawing.Point(33, 27);
            this.lb_usuario.Name = "lb_usuario";
            this.lb_usuario.Size = new System.Drawing.Size(77, 22);
            this.lb_usuario.TabIndex = 6;
            this.lb_usuario.Text = "Usuario:";
            // 
            // lb_contraseña
            // 
            this.lb_contraseña.AutoSize = true;
            this.lb_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_contraseña.Location = new System.Drawing.Point(249, 29);
            this.lb_contraseña.Name = "lb_contraseña";
            this.lb_contraseña.Size = new System.Drawing.Size(108, 22);
            this.lb_contraseña.TabIndex = 7;
            this.lb_contraseña.Text = "Contraseña:";
            // 
            // lb_dni
            // 
            this.lb_dni.AutoSize = true;
            this.lb_dni.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dni.Location = new System.Drawing.Point(312, 79);
            this.lb_dni.Name = "lb_dni";
            this.lb_dni.Size = new System.Drawing.Size(45, 22);
            this.lb_dni.TabIndex = 8;
            this.lb_dni.Text = "DNI:";
            // 
            // lb_cargo
            // 
            this.lb_cargo.AutoSize = true;
            this.lb_cargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cargo.Location = new System.Drawing.Point(46, 79);
            this.lb_cargo.Name = "lb_cargo";
            this.lb_cargo.Size = new System.Drawing.Size(64, 22);
            this.lb_cargo.TabIndex = 9;
            this.lb_cargo.Text = "Cargo:";
            // 
            // lb_autenticacion
            // 
            this.lb_autenticacion.AutoSize = true;
            this.lb_autenticacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_autenticacion.ForeColor = System.Drawing.Color.Green;
            this.lb_autenticacion.Location = new System.Drawing.Point(73, 178);
            this.lb_autenticacion.Name = "lb_autenticacion";
            this.lb_autenticacion.Size = new System.Drawing.Size(398, 39);
            this.lb_autenticacion.TabIndex = 10;
            this.lb_autenticacion.Text = "Agregado Correctamente";
            this.lb_autenticacion.Visible = false;
            this.lb_autenticacion.Click += new System.EventHandler(this.lb_autenticacion_Click);
            // 
            // AgregarCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 239);
            this.Controls.Add(this.lb_autenticacion);
            this.Controls.Add(this.lb_cargo);
            this.Controls.Add(this.lb_dni);
            this.Controls.Add(this.lb_contraseña);
            this.Controls.Add(this.lb_usuario);
            this.Controls.Add(this.tx_dni);
            this.Controls.Add(this.tx_usuario);
            this.Controls.Add(this.tx_contraseña);
            this.Controls.Add(this.tx_cargo);
            this.Controls.Add(this.btn_agregar);
            this.Name = "AgregarCuenta";
            this.Text = "Agregar Nueva Cuenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.ComboBox tx_cargo;
        private System.Windows.Forms.TextBox tx_contraseña;
        private System.Windows.Forms.TextBox tx_usuario;
        private System.Windows.Forms.TextBox tx_dni;
        private System.Windows.Forms.Label lb_usuario;
        private System.Windows.Forms.Label lb_contraseña;
        private System.Windows.Forms.Label lb_dni;
        private System.Windows.Forms.Label lb_cargo;
        private System.Windows.Forms.Label lb_autenticacion;
    }
}