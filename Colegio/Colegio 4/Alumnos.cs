using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Colegio
{
    class Alumnos
    {

        public List<List<string>> respuestas = new List<List<string>>();
        public string cadena = "DataBase = colegio; DataSource = 127.0.0.1 ; User id = root; Password = '';";

        public MySqlConnection conexion = null;
        public MySqlDataReader reader = null;
        public MySqlCommand cmd = null;


        public Alumnos(string DNI)
        {

            try
            {
                conexion = new MySqlConnection(cadena);
                conexion.Open();


                string consulta = ("SELECT * FROM 1°(primer grado), 2°(segundo grado), 3°(tercer grado), 4°(cuarto grado), 5°(quinto grado), 6°(sexto grado), 7°(septimo grado) WHERE DNI = '" + DNI + "' "); //aca hay que cambiar la tabla
                cmd = new MySqlCommand(consulta, conexion);
                reader = cmd.ExecuteReader();

                int confirmacion = 0;

                while (reader.Read())
                {
                    int aux = 9; //cambiar en cada formulario dependiendo del numero de columnas de la tabla
                    List<string> respuesta = new List<string>();

                    for (int a = 0; a < aux; a++)
                    {
                        respuesta.Add(reader.GetString(a));
                    }

                    respuestas.Add(respuesta);

                    confirmacion += 1;

                }

                if (confirmacion == 0)
                {

                }

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
