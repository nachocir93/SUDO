using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace PagoElectronico.Dominio
{
    class Rol
    {
        private int idRol;
        public String nombreRol { get; set; }
        public bool estado { get; set; }

        public Rol(SqlDataReader reader) 
        {           
            idRol = Convert.ToInt32(reader["idRol"].ToString());
            nombreRol = reader["nombreRol"].ToString();
            estado = Boolean.Parse(reader["estado"].ToString());            
        }

        public Rol(String id, String nombre, String est)
        {
            idRol = Convert.ToInt32(id);
            nombreRol = nombre;
            estado = Boolean.Parse(est);
        }

        public int getId() 
        {
            return idRol;
        }
    }
}


