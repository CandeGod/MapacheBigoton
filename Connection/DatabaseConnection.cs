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
<<<<<<< HEAD
            SqlConnection connection = new SqlConnection("SERVER=DESKTOP-9F2DS3R;DATABASE=DB_Barberias;Integrated Security=True;TrustServerCertificate=True;");
=======
            SqlConnection connection = new SqlConnection("SERVER=DESKTOP-K55C42J;DATABASE=DB_Barberias;Integrated Security=True;TrustServerCertificate=True;");
>>>>>>> 0fc55d862322200006ec64e62c581b7fb56a46af
            connection.Open();

            return connection;
        }
    }
}
