using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace _3_25_19class.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
    public class PersonManager
    {
        private string _connectionString;
        public PersonManager(string connectionString)
        {
            _connectionString = connectionString;
        }
        public int AddPerson(Person p)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "insert into people (  firstname,lastname,age) values(@firstname,@lastname,@age); select scope_identity()";
            cmd.Parameters.AddWithValue("@firstname", p.FirstName);
            cmd.Parameters.AddWithValue("@lastname", p.LastName);
            cmd.Parameters.AddWithValue("@age", p.Age);
            connection.Open();
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

    }
}