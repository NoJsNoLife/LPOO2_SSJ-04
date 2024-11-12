using ClaseBase;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesBase
{
    public class TrabajarAtleta
    {
        public static bool existe_atleta(string dni)
        {
            string conexion = DataBaseConfig.DB_CONN;
            SqlConnection cnn = new SqlConnection(conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM Atleta WHERE Atl_DNI = @dni";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dni", dni);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static void alta_atleta(string dni, string apellido, string nombre, string nacionalidad, string entrenador,
     string genero, double altura, double peso, DateTime nacimiento, string direccion, string email)
        {
            string conexion = DataBaseConfig.DB_CONN;
            SqlConnection cnn = new SqlConnection(conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "INSERT INTO Atleta " +
                "(Atl_DNI, Atl_Apellido, Atl_Nombre, Atl_Nacionalidad, Atl_Entrenador, Atl_Genero, Atl_Altura, Atl_Peso, Atl_FechaNac, Atl_Direccion, Atl_email) " +
                "VALUES (@dni, @apellido, @nombre, @nacionalidad, @entrenador, @genero, @altura, @peso, @nacimiento, @direccion, @email)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dni", dni);
            cmd.Parameters.AddWithValue("@apellido", apellido);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@nacionalidad", nacionalidad);
            cmd.Parameters.AddWithValue("@entrenador", entrenador);
            cmd.Parameters.AddWithValue("@genero", genero);
            cmd.Parameters.AddWithValue("@altura", altura);
            cmd.Parameters.AddWithValue("@peso", peso);
            cmd.Parameters.AddWithValue("@nacimiento", nacimiento);
            cmd.Parameters.AddWithValue("@direccion", direccion);
            cmd.Parameters.AddWithValue("@email", email);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static Atleta traer_atleta_por_id(int id)
        {
            string conexion = DataBaseConfig.DB_CONN;
            SqlConnection cnn = new SqlConnection(conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM Atleta WHERE Atl_ID = @id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@id", id);

            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            Atleta atleta = null;
            if (reader.Read())
            {
                atleta = new Atleta
                {
                    Atl_ID = (int)reader["Atl_ID"],
                    Atl_DNI = reader["Atl_DNI"].ToString(),
                    Atl_Apellido = reader["Atl_Apellido"].ToString(),
                    Atl_Nombre = reader["Atl_Nombre"].ToString(),
                    Atl_Nacionalidad = reader["Atl_Nacionalidad"].ToString(),
                    Atl_Entrenador = reader["Atl_Entrenador"].ToString(),
                    Atl_Genero = reader["Atl_Genero"].ToString() == "Masculino" ? 'M' : reader["Atl_Genero"].ToString() == "Femenino" ? 'F' : reader["Atl_Genero"].ToString() == "No Binario" ? 'N'  : 'P', // Default to 'U' or any other default value,
                    Atl_Altura = Convert.ToDouble(reader["Atl_Altura"]),
                    Atl_Peso = Convert.ToDouble(reader["Atl_Peso"]),
                    Atl_FechaNac = Convert.ToDateTime(reader["Atl_FechaNac"]),
                    Atl_Direccion = reader["Atl_Direccion"].ToString(),
                    Atl_email = reader["Atl_email"].ToString()
                };
            }

            reader.Close();
            cnn.Close();

            return atleta;
        }

        public static void ActualizarAtleta(Atleta atleta)
        {
            string conexion = DataBaseConfig.DB_CONN;
            using (SqlConnection cnn = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand
                {
                    CommandText = @"UPDATE Atleta SET Atl_DNI = @dni, Atl_Apellido = @apellido, Atl_Nombre = @nombre,
                            Atl_Nacionalidad = @nacionalidad, Atl_Entrenador = @entrenador, Atl_Genero = @genero,
                            Atl_Altura = @altura, Atl_Peso = @peso, Atl_FechaNac = @fechaNac,
                            Atl_Direccion = @direccion, Atl_email = @email
                            WHERE Atl_ID = @id",
                    CommandType = CommandType.Text,
                    Connection = cnn
                };

                // Convertir el valor del género de char a string
                string genero = atleta.Atl_Genero == 'M' ? "Masculino" :
                                atleta.Atl_Genero == 'F' ? "Femenino" :
                                atleta.Atl_Genero == 'N' ? "No Binario" : "Prefiero no decirlo";

                cmd.Parameters.AddWithValue("@dni", atleta.Atl_DNI);
                cmd.Parameters.AddWithValue("@apellido", atleta.Atl_Apellido);
                cmd.Parameters.AddWithValue("@nombre", atleta.Atl_Nombre);
                cmd.Parameters.AddWithValue("@nacionalidad", atleta.Atl_Nacionalidad);
                cmd.Parameters.AddWithValue("@entrenador", atleta.Atl_Entrenador);
                cmd.Parameters.AddWithValue("@genero", genero);
                cmd.Parameters.AddWithValue("@altura", atleta.Atl_Altura);
                cmd.Parameters.AddWithValue("@peso", atleta.Atl_Peso);
                cmd.Parameters.AddWithValue("@fechaNac", atleta.Atl_FechaNac);
                cmd.Parameters.AddWithValue("@direccion", atleta.Atl_Direccion);
                cmd.Parameters.AddWithValue("@email", atleta.Atl_email);
                cmd.Parameters.AddWithValue("@id", atleta.Atl_ID);

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

    }
}
