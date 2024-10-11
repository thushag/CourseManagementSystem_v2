using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_v2
{
    public class CourseRepository
    {
        private readonly string _connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=CourseManagement;Trusted_Connection=true;TrustServerCertificate=true;";


        public void AddCourses()
        {
            try
            {
               using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    var command = connection.CreateCommand();

                }
            }
        }


    }
}
