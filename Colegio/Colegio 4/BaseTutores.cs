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
    public partial class BaseTutores : Form
    {
        public BaseTutores()
        {
            InitializeComponent();
        }

        private void btn_alumnos_Click(object sender, EventArgs e)
        {
            Form BaseAlumnos = new BaseAlumnos();
            BaseAlumnos.Show();
            this.Hide();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            Form Form1 = new form_inicio();
            Form1.Show();
            this.Hide();
        }
    }
}
