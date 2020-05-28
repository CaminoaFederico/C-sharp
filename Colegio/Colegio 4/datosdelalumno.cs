using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Colegio
{
    public partial class datosdelalumno : Form
    {

        public datosdelalumno()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form datospersonal = new datospersonal();
            datospersonal.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form datostutores = new datostutores();
            datostutores.Show();
            this.Hide();
        }

        private void btn_ingreso_datos_Click(object sender, EventArgs e)
        {

            int dni = Convert.ToInt32(tx_dni.Text);
            int responsable = Convert.ToInt32(tx_responsable.Text);
            int grado = Convert.ToInt32(tx_grado.Text);
            string domicilio = tx_domicilio.Text;
            string nombre = tx_nombre.Text;
            string apellido = tx_apellido.Text;
            string division = tx_division.Text;
            string fecha = tx_nacimiento_fecha.Text;
            string lugar = tx_nacimiento_lugar.Text;
            string nacionalidad = tx_nacion.Text;

            
            string consulta = "(`DNI`, `Apellido`, `Nombre`, `Grado`, `Domicilio`, `Fecha_de_nacimiento`, `Lugar_de_nacimiento`, `Nacionalidad`, `Responsable`) VALUES ('"+dni+ "', '" + apellido + "', '"+nombre+"', '"+grado+"', '"+domicilio+"', '"+fecha+"', '"+lugar+"', '"+nacionalidad+"', '"+responsable+"');";

            string consulta2;

            switch (grado)
            {
                default:
                    consulta2 = "";
                    break;
                case 1:
                    consulta2 = "INSERT INTO `1º(primer grado)` ";
                    break;
                case 2:
                    consulta2 = "INSERT INTO `2º(segundo grado)` ";
                    break;
                case 3:
                    consulta2 = "INSERT INTO `3º(tercer grado)` ";
                    break;
                case 4:
                    consulta2 = "INSERT INTO `4º(cuarto grado)` ";
                    break;
                case 5:
                    consulta2 = "INSERT INTO `5º(quinto grado)` ";
                    break;
                case 6:
                    consulta2 = "INSERT INTO `6º(sexto grado)` ";
                    break;
                case 7:
                    consulta2 = "INSERT INTO `7º(septimo grado)` ";
                    break;
            }

            string consulta_final = consulta2 + consulta;

            Ingreso ingreso = new Ingreso(consulta_final);

            if(tx_dni.Text == "" || tx_responsable.Text == "" || tx_grado.Text == "" || tx_domicilio.Text == "" || tx_apellido.Text == "" ||tx_nombre.Text == "" || tx_division.Text == "" || tx_nacion.Text == "" || tx_nacimiento_fecha.Text == "" || tx_nacimiento_lugar.Text == "" )
            {
                DialogResult error = MessageBox.Show("ERROR", "Complete todos los campos");
            }
            else
            {
                DialogResult mensajito = MessageBox.Show("¡Datos ingresados correctamente!", "¡Correcto!");
            }
            
        }

        private void btn_base_alumnos_Click(object sender, EventArgs e)
        {
            Form BaseAlumnos = new BaseAlumnos();
            BaseAlumnos.Show();
            this.Hide();
        }

        private void btn_base_tutores_Click(object sender, EventArgs e)
        {
            Form BaseTutores = new BaseTutores();
            BaseTutores.Show();
            this.Hide();
        }
    }
}
