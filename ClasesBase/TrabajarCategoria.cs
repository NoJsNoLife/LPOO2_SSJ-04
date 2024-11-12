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
    public class TrabajarCategoria
    {
        private static string connectionString = DataBaseConfig.DB_CONN; // Asegúrate de reemplazar esto con tu cadena de conexión

        public static void altaCategoria(string nombre, string descripcion)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("AltaCategoria", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Cat_Nombre", nombre);
                cmd.Parameters.AddWithValue("@Cat_Descripcion", descripcion);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
