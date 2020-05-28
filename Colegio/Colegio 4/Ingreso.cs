using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Colegio
{
    class Ingreso
    {

        public Ingreso(string consulta)
        {

            string cadena = "DataBase = colegio; DataSource = 127.0.0.1:15515 ; User id = root; Password = '';";
            MySqlConnection conexion = null;
            MySqlDataReader reader = null;
            MySqlCommand cmd = null;

            try
            {
                conexion = new MySqlConnection(cadena);
                conexion.Open();

                cmd = new MySqlCommand(consulta, conexion);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);

            }

            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }

            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }

                if (conexion != null)
                {
                    conexion.Close();
                }

            }

        }


    }
}
