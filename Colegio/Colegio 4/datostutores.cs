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
    public partial class datostutores : Form
    {
        public datostutores()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            form_inicio.ActiveForm.Show();          
        }

        private void btn_datos_alumnos_Click(object sender, EventArgs e)
        {
            Form datosdelalumno = new datosdelalumno();
            datosdelalumno.Show();
            this.Hide();
        }

        private void btn_personal_Click(object sender, EventArgs e)
        {
            Form datospersonal = new datospersonal();
            datospersonal.Show();
            this.Hide();
        }

        private void Ingresar_Click_1(object sender, EventArgs e)
        {


            int dni = Convert.ToInt16(tx_dni.Text);
            int telefono = Convert.ToInt16(tx_tel_telefono.Text);
            int celular = Convert.ToInt16(tx_tel_celular.Text);
            int nro_trabajo = Convert.ToInt16(tx_tel_trabajo.Text);
            string nombre = tx_nombre.Text;
            string apellido = tx_apellido.Text;
            string domicilio = tx_domicilo.Text;
            string lugar_nacimiento = tx_nacimiento_lugar.Text;
            string fecha_nacimiento = tx_nacimiento_fecha.Text;
            string nacionalidad = tx_nacionalidad.Text;


            string consulta = "INSERT INTO `tutores` ('DNI', 'Nombre', 'Apellido', 'Domicilio', 'Fecha_de_nacimiento', 'Nacionalidad', 'Lugar_de_nacimiento', 'Telefono', 'Celular', 'Numero_de_Trabajo') VALUES('"+dni+"', '"+nombre+"', '"+apellido+"', '"+domicilio+"', '"+fecha_nacimiento+"', '"+nacionalidad+"', '"+lugar_nacimiento+"', '"+telefono+"', '"+celular+"', '"+nro_trabajo+"');";



            Ingreso guardar_datos = new Ingreso(consulta);

            if(tx_dni.Text == "" || tx_tel_telefono.Text == "" || tx_tel_celular.Text == "" || tx_tel_trabajo.Text == "" || tx_nombre.Text == "" || tx_apellido.Text == "" || tx_domicilo.Text == "" || tx_nacimiento_lugar.Text == "" || tx_nacimiento_fecha.Text == "" || tx_nacionalidad.Text == "")
            {
                DialogResult error = MessageBox.Show("Complete todos los campos");
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
