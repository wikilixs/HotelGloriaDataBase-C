using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using HotelGloriaDataBase.ALL;


namespace HotelGloriaDataBase.DAL
{
    public class AllPersonal
    {
        public static DataTable ObtenerPersonal()
        {
            using (SqlConnection conexion = connectionDB.ObtenerConexion())
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_ObtenerPersonal", conexion);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static void InsetarPersonal(string nombre, string primerApellido, string segundoApellido, string tipoDocumento, string numeroDocumento, string direccionPersonal, string telefono, string fechaNacimiento, string email, string contraseña) 

        {
            using (SqlConnection conexion = connectionDB.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_InsertarPesonal", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@primerApellido", primerApellido);
                cmd.Parameters.AddWithValue("@segundoApellido", segundoApellido);
                cmd.Parameters.AddWithValue("@tipoDocumento", tipoDocumento);  
                cmd.Parameters.AddWithValue("@numeroDocumento", numeroDocumento);
                cmd.Parameters.AddWithValue("@direccionPersonal", direccionPersonal);
                cmd.Parameters.AddWithValue("@telefono", telefono); 
                cmd.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@contraseña", contraseña);
                cmd.ExecuteNonQuery();
            }
        }

        public static void ActualizarPersonal(string nombre, string primerApellido, string segundoApellido, string tipoDocumento, string numeroDocumento, string direccionPersonal, string telefono, string fechaNacimiento, string email, string contraseña)
        {
            using (SqlConnection conexion = connectionDB.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_ActualizarPersonal", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@primerApellido", primerApellido);
                cmd.Parameters.AddWithValue("@segundoApellido", segundoApellido);
                cmd.Parameters.AddWithValue("@tipoDocumento", tipoDocumento);
                cmd.Parameters.AddWithValue("@numeroDocumento", numeroDocumento);
                cmd.Parameters.AddWithValue("@direccionPersonal", direccionPersonal);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento);
                cmd.Parameters.AddWithValue("@email", email);   
                cmd.Parameters.AddWithValue("@contraseña", contraseña);

                cmd.ExecuteNonQuery();
            }
        }
        public static void EliminarPersonal(int estado)
        {
            using (SqlConnection conexion = connectionDB.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_EliminarPersonalLodico", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Estado", estado);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
