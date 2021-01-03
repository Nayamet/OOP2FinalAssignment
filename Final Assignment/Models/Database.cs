using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Final_Assignment.Models
{
    public class Database
    {
        public Books Books { get; set; }
        public Database()
        {
            string connString = "Server=DISHAN\\SQLEXPRESS;Database=oop2;User Id=sa;Password=Nayamet@19392;";
            SqlConnection conn = new SqlConnection(connString);
            Books = new Books(conn);
        }
    }
}
