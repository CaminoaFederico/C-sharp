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
    public partial class datospersonal : Form
    {
        public datospersonal()
        {
            InitializeComponent();
        }

        private void btn_datos_alumno_Click(object sender, EventArgs e)
        {
            Form datosdelalumno = new datosdelalumno();
           datosdelalumno.Show();
            this.Hide();
        }

        private void btn_tutores_Click(object sender, EventArgs e)
        {
            Form datostutores = new datostutores();
            datostutores.Show();
            this.Hide();
        }

        private void btn_ingresar_datos_Click(object sender, EventArgs e)
        {

            int telefono = Convert.ToInt32(tx_telefono.Text);
            int dni = Convert.ToInt32(tx_dni.Text);
            string nombre = tx_nombre.Text;
            string apellido = tx_apellido.Text;
            string cargo = tx_cargo.Text;


            string consulta = "INSERT INTO `colegio`.`personal` (`DNI`, `Nombre`, `Apellido`, `Teléfono`, `Cargo`) VALUES ('" + dni + "', '" + nombre + "', '" + apellido + "', '" + telefono + "', '" + cargo + "');";

            Ingreso nuevo = new Ingreso(consulta);

            if(tx_telefono.Text == "" || tx_dni.Text == "" || tx_nombre.Text == "" || tx_apellido.Text == "" || tx_cargo.Text == "")
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

        private void datospersonal_Load(object sender, EventArgs e)
        {

        }
    }
}
