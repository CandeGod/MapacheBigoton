using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace MapacheBigoton.Connection
{
    public  class DatabaseConnection
    {
        public SqlConnection GetConnection()
        {
            //Cambiar unicamente el nombre de su servidor de la base de datos de sql y tener la bd creada
            SqlConnection connection = new SqlConnection("SERVER=STRDST;DATABASE=DB_Barberias;Integrated Security=True;TrustServerCertificate=True;");
            connection.Open();

            return connection;
        }
    }
}
