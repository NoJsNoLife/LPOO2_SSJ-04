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
    public class TrabajarDisciplina
    {
        public static void alta_disciplina(string nombre, string descripcion)
        {
            string conexion = DataBaseConfig.DB_CONN;
            SqlConnection cnn = new SqlConnection(conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "AltaDisciplina";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlParameter disciplinaNombre = new SqlParameter("@nombre", SqlDbType.VarChar, 50);
            disciplinaNombre.Value = nombre;
            cmd.Parameters.Add(disciplinaNombre);

            SqlParameter disciplinaDescripcion = new SqlParameter("@descripcion", SqlDbType.VarChar, 50);
            disciplinaDescripcion.Value = descripcion;
            cmd.Parameters.Add(disciplinaDescripcion);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
