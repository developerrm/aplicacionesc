using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace PANEL_ADO
{
    class Class1 
    {
        //conexion
        public bool validar(String user, String pass)
        {
            bool sw;
            string cadenaconexion = @"Data Source=BRYANWM-PC\MSSQLSERVER_G;Initial Catalog= ;User=" + user + " ;Password=" + pass + ";Integrated Security=False";//cadena de conexion
            String query = @"Select name from sys.databases;";
            SqlConnection conect = new SqlConnection(cadenaconexion);
            try
            {   conect.Open();
                SqlCommand cmd = new SqlCommand(query, conect);
                SqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    Console.WriteLine(dr.GetString(0));

                }

               
                sw= true;
            }
            catch (SqlException e)
            {   
                sw = false;
              
            }
            return sw ;
        }
        

    }
}
