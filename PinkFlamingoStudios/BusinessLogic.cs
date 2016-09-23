using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace PinkFlamingoStudios
{
    public class BusinessLogic
    {
        SqlConnection pfCon = new SqlConnection("Data Source=(localdb//V12.0;Initial Catalog=PinkFlamingos;Integrated Security=True");

        public void connect()
        {
            pfCon.Open();

        }
    }
}