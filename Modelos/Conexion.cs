﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace Modelos
{
    public class Conexion
    {
        private static string servidor = "RICARDO\\SQLEXPRESS";
        private static string baseDeDatos = "crud";

        public static SqlConnection Conectar()
        {
            string cadena = 
                $"Data Source={servidor}; " +
                $"Initial Catalog={baseDeDatos}; " +
                $"Integrated Security= true;";

            SqlConnection con = new SqlConnection(cadena);

            con.Open();

            return con;
        }

    }
}