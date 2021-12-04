using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace RE_Cafeteria.Modelo
{
    class BDUsuario
    {
        public void mostrar(ref DataTable DT) {

            Conexion conn = new Conexion();

            try
            {
                conn.abrir();
                SqlDataAdapter DA = new SqlDataAdapter("mostrar_todos", conn.conectar);
                DA.Fill(DT);

            }
            catch (Exception ex)
            {

            }
            finally {
                conn.cerrar();
            }

        
        }

    
    
    }
}
