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

namespace Colegio
{
    public partial class form_inicio : Form
    {

        TCuentas cuenta = null;


        public form_inicio()
        {
            InitializeComponent();
        }

        private void btn_datos_alumnos_Click(object sender, EventArgs e)
        {
            Form datosdelalumno = new datosdelalumno();
            datosdelalumno.Show();
            this.Hide();
        }

        private void btn_personal_Click(object sender, EventArgs e)
        {
            //btn_personal
            Form datospersonal = new datospersonal();
            datospersonal.Show();
            this.Hide();

        }

        private void btn_tutores_Click(object sender, EventArgs e)
        {
            Form datostutores = new datostutores();
            datostutores.Show();
            this.Hide();

        }

        
        void btn_ingresar_Click(object sender, EventArgs e)
        {

            if(!(txt_usuario.Text == "" || txt_contraseña.Text == "" || tb_DNI.Text == ""))
            {

                cuenta = new TCuentas(tb_DNI.Text);



                string Usuario = cuenta.respuestas[0][1].ToString();
                string Password = cuenta.respuestas[0][2].ToString();

                txt_contraseña.Text = cuenta.respuestas[0][2].ToString();


                if (txt_contraseña.Text == Password && txt_usuario.Text == Usuario)
                {
                    btn_datos_alumnos.Visible = true;
                    btn_personal.Visible = true;
                    btn_tutores.Visible = true;
                    btn_base_alumnos.Visible = true;
                    btn_base_tutores.Visible = true;
                }
                else
                {
                    DialogResult mensaje12 = MessageBox.Show("Ingrese el usuario o la contraseña correctamente", "¡¡Problema!!");
                }
                
                //TCuentas hola = new TCuentas(tb_DNI.Text);
            }
            else
            {
                DialogResult mensaje1 = MessageBox.Show("Complete TODOS los campos", "¡¡Problema!!");
            }
            
               

        }

        private void tb_DNI_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_registrarse_Click(object sender, EventArgs e)
        {
            Form AgregarCuenta = new AgregarCuenta();
            AgregarCuenta.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form BaseAlumnos = new BaseAlumnos();
            BaseAlumnos.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form BaseTutores = new BaseTutores();
            BaseTutores.Show();
            this.Hide();
        }
    }
}
