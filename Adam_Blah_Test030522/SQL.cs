using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adam_Blah_Test030522
{
    class SQL
    {
        private string conn_string = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Test_Adam_Blaha;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        
        private SqlConnection connection;
        
        public SQL()
        {

        }

        public List<Info> GetAll()
        {
            connection = new SqlConnection(conn_string);
            List<Info> listed = new List<Info>();
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = @"SELECT * FROM Faktury";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                var info = new Info()
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    datum = reader["datum"].ToString(),
                    cislo = Convert.ToInt32(reader["cislo"]),
                    odberatel = reader["odberatel"].ToString(),
                    nazev = reader["nazev"].ToString(),
                    pocet = reader["pocet"].ToString(),
                    cenazakus = Convert.ToInt32(reader["cenazakus"]),
                    celkovacena = Convert.ToInt32(reader["celkovacena"]),
                    DPH = Convert.ToInt32(reader["DPH"]),
                    cenasDPH = Convert.ToInt32(reader["cenasDPH"]),
                };
                listed.Add(info);
            }

            return listed;
        }
    }
}
