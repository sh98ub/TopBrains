using System;
using System.Data.SqlClient;

namespace ParameterizedQuery
{
    internal class Parameter
    {
        string constring = "Data Source=PARADOX\\SQLEXPRESS;Initial Catalog=sms;Integrated Security=True;";

        public void AddNewStudent(int id, string name, int marks)
        {
            string sqlCmd = "INSERT INTO Students (StudentID, Name, Marks) VALUES (@Id, @Name, @Marks)";

            SqlConnection sqlConnection = new SqlConnection(constring);
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand(sqlCmd, sqlConnection);

            sqlCommand.Parameters.AddWithValue("@Id", id);
            sqlCommand.Parameters.AddWithValue("@Name", name);
            sqlCommand.Parameters.AddWithValue("@Marks", marks);

            int count = sqlCommand.ExecuteNonQuery();   // ✅ EXECUTE ONLY ONCE

            if (count > 0)
                Console.WriteLine("Inserted Successfully");
            else
                Console.WriteLine("Insert Failed");

            sqlConnection.Close();
        }
    }
}