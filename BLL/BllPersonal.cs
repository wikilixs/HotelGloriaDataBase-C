using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelGloriaDataBase.DAL;

namespace HotelGloriaDataBase.BLL
{
    public class BllPersonal
    {
        public static DataTable ObtenerPersonal()
        {
            return AllPersonal.ObtenerPersonal();
        }
        
        public static void InsertarPersonal(string nombre, string primerApellido, string segundoApellido, string tipoDocumento, string numeroDocumento, string direccionPersonal, string telefono, string fechaNacimiento, string email, string contraseña)
        {
            nombre = nombre.ToUpper();
            primerApellido = primerApellido.ToUpper();
            segundoApellido = segundoApellido.ToUpper();
            tipoDocumento = tipoDocumento.ToUpper();
            direccionPersonal = direccionPersonal.ToUpper();

            email = $"{nombre[0]}{primerApellido}@hotelGloria.com".ToLower();
            contraseña = $"{numeroDocumento}.h".ToLower();

            AllPersonal.InsetarPersonal(nombre, primerApellido, segundoApellido, tipoDocumento, numeroDocumento, direccionPersonal, telefono, fechaNacimiento, email, contraseña);
                        
        }

        public static void ActualizarPersonal(string nombre, string primerApellido, string segundoApellido, string tipoDocumento, string numeroDocumento, string direccionPersonal, string telefono, string fechaNacimiento, string email, string contraseña)
        {
            
            nombre = nombre.ToUpper();
            primerApellido = primerApellido.ToUpper();
            segundoApellido = segundoApellido.ToUpper();
            tipoDocumento = tipoDocumento.ToUpper();
            direccionPersonal = direccionPersonal.ToUpper();

            email = $"{nombre[0]}{primerApellido}@hotelGloria.com".ToLower();
            contraseña = $"{numeroDocumento}.h".ToLower();

            AllPersonal.ActualizarPersonal(nombre, primerApellido, segundoApellido, tipoDocumento, numeroDocumento, direccionPersonal, telefono, fechaNacimiento, email, contraseña);
        }

        public static void EliminarPersonal(int estado)
        {
            AllPersonal.EliminarPersonal(estado);
        }
    }
}
