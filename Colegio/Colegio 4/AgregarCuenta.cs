using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Colegio
{
    public partial class AgregarCuenta : Form
    {
        public AgregarCuenta()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {


            int DNI = Convert.ToInt16(tx_dni.Text);
            string usuario = tx_usuario.Text;
            string contraseña = tx_contraseña.Text;
            string cargo = tx_cargo.Text;


            string consulta = "INSERT INTO `colegio`.`cuentas` (`DNI`, `Usuario`, `Contraseña`, `Cargo`) VALUES ('"+DNI+"', '"+usuario+"', '"+contraseña+"', '"+cargo+"');";


            try{
            Ingreso nuevo = new Ingreso(consulta);
            }
            catch{
            }

            if(tx_dni.Text == "" || tx_usuario.Text == "" || tx_contraseña.Text == "" || tx_cargo.Text == "")
            {
                DialogResult error = MessageBox.Show("ERROR", "Complete todos los campos");
            }
            else
            {
                lb_autenticacion.Visible = true;
                DialogResult mensajito = MessageBox.Show("¡Datos ingresados correctamente!", "¡Correcto!");
            }
        }

        private void lb_autenticacion_Click(object sender, EventArgs e)
        {

        }
    }
}
