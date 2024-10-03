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

    }
}
