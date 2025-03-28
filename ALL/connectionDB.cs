using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelGloriaDataBase.ALL
{
    public class connectionDB
    {
        private static string cadenaConexion = "Data Source=WIKIILXS;Initial Catalog=DBHotelGloria;Integrated Security=True";

        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();
            return conexion;
        }

    }
}
