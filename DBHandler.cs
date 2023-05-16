using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    public class DBHandler
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        private string connectString;
    
        public string MyConnection()
        {
            connectString = "Data Source=DESKTOP-61OOJ8F\\SQLEXPRESS;Initial Catalog=DBlabproject;Integrated Security=True;MultipleActiveResultSets=true";
            return connectString;
        }
    }
}