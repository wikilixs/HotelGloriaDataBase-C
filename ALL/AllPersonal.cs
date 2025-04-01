using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelGloriaDataBase.ALL;


namespace HotelGloriaDataBase.ALL
{
    public class AllPersonal
    {

        public DataTable MostrarPersonal(string BusquedaEmpleado)
        {
            using (SqlConnection conexion = connectionDB.ObtenerConexion())
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("sp_BuscarPersonal", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BusquedaEmpleado", BusquedaEmpleado); 
                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                return dt;
            }
        }

        public static void InsertarPersonal(string nombre, string primerApellido, string segundoApellido, string tipoDocumento, string numeroDocumento, string direccionPersonal, string telefono, string fechaNacimiento, string email, string contraseña, int idCargo, int idSalario, int idHorario, int idSucursal) 

        {
            using (SqlConnection conexion = connectionDB.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand("sp_IngresarPersonal", conexion)) // Corrige el nombre
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Agregar parámetros obligatorios
                    cmd.Parameters.AddWithValue("@Nombre_Personal", nombre);
                    cmd.Parameters.AddWithValue("@PrimerApellido_Personal", primerApellido);
                    cmd.Parameters.AddWithValue("@SegundoApellido_Personal", segundoApellido);
                    cmd.Parameters.AddWithValue("@TipoDocumento_Personal", tipoDocumento);
                    cmd.Parameters.AddWithValue("@NumeroDocumento_Personal", numeroDocumento);
                    cmd.Parameters.AddWithValue("@Direccion_Personal", direccionPersonal ); // Manejo de NULL
                    cmd.Parameters.AddWithValue("@Telefono_Personal", telefono);
                    cmd.Parameters.AddWithValue("@Email_Personal", email);
                    cmd.Parameters.AddWithValue("@FechaNacimiento_Personal", fechaNacimiento);
                    cmd.Parameters.AddWithValue("@Contraseña_Personal", contraseña);


                    // Parámetros opcionales con NULL si no se proporcionan
                    cmd.Parameters.AddWithValue("@ID_Cargo", idCargo > 0 ? (object)idCargo : DBNull.Value);
                    cmd.Parameters.AddWithValue("@ID_Horario", idHorario > 0 ? (object)idHorario : DBNull.Value);
                    cmd.Parameters.AddWithValue("@ID_Salario", idSalario > 0 ? (object)idSalario : DBNull.Value);
                    cmd.Parameters.AddWithValue("@ID_Sucursal", idSucursal > 0 ? (object)idSalario : DBNull.Value);

                    // Capturar el valor de retorno (ID insertado o error)
                    var resultado = cmd.ExecuteScalar();

                }
            }
        }
    }
}
