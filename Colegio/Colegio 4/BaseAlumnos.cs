using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colegio
{
    public partial class BaseAlumnos : Form
    {
        public BaseAlumnos()
        {
            InitializeComponent();
        }

        private void lb_nom_ape_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_tutores_Click(object sender, EventArgs e)
        {
            Form BaseTutores = new BaseTutores();
            BaseTutores.Show();
            this.Hide();
        }

        private void cb_division_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_año_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lb_alumno_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_nacionalidad_Click(object sender, EventArgs e)
        {

        }

        private void lb_lugar_nacimiento_Click(object sender, EventArgs e)
        {

        }

        private void lb_fecha_nacimiento_Click(object sender, EventArgs e)
        {

        }

        private void lb_dni_Click(object sender, EventArgs e)
        {

        }

        private void lb_domicilio_Click(object sender, EventArgs e)
        {

        }

        private void rtb_alumnos_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            Form Form1 = new form_inicio();
            Form1.Show();
            this.Hide();
        }
    }
}
