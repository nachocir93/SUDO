﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace PagoElectronico.Dominio
{
    class Roles
    {
        public SortedList roles = new SortedList();

        public Roles(SqlDataReader reader)
        {
            List<string> auxList = new List<string>();
            List<string> auxList2 = new List<string>();

            for (; reader.Read(); auxList.Add(reader["nombreRol"].ToString()), auxList2.Add(reader["nombreFuncionalidad"].ToString())) ;

            string auxAnt;
            int i;
            List<string> funcionalidades;

            for (i = 0, funcionalidades = new List<string>(), auxAnt = auxList[i]; i < auxList.Count ; auxAnt = auxList[i],i++)
            {
                if(auxAnt != auxList[i])
                {
                    roles.Add(auxAnt, funcionalidades);
                    funcionalidades = new List<string>();
                }
                funcionalidades.Add(auxList2[i]);
            }
            roles.Add(auxAnt, funcionalidades);
        }
    }
}





