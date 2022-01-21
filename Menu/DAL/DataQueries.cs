using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menu.BAL;

namespace Menu.DAL
{
    class DataQueries
    {
        public static SqlConnection GetConnection()
        {
            //Add Connection to your SQL Server
            string str = "Data Source = MAYO ; Initial Catalog=Students; Integrated Security = true;";
            SqlConnection connection = new SqlConnection(str);
            try
            {
                connection.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("DataBase Not Connected!");
            }
            return connection;
        }
        public static DataSet GetDataThroughReader()
        {
            string qry = "SELECT * FROM Student;";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = CommandType.Text;
            SqlDataAdapter reader = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            reader.Fill(ds, "Student");
            return ds;
        }
        public static void AddRecord(Student student)
        {
            string qry = "INSERT INTO Student VALUES(@StudentName,@RegNo,@Quizzes,@Mids,@Finals,@TotalMarks);";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@StudentName", student.Name);
            command.Parameters.AddWithValue("@RegNo", student.RegNo);
            command.Parameters.AddWithValue("@Quizzes", student.Quizzes);
            command.Parameters.AddWithValue("@Mids", student.MidsMarks);
            command.Parameters.AddWithValue("@Finals", student.FinalsMarks);
            command.Parameters.AddWithValue("@TotalMarks", student.TotalMarks());
            command.ExecuteNonQuery();
        }
        public static void DeleteRecord(string regNo)
        {
            string qry = "DELETE FROM Student WHERE RegNo = @RegNo;";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@RegNo", regNo);
            command.ExecuteNonQuery();
        }
        public static void UpdateRecord(string regNo,Student student)
        {
            string qry = "UPDATE Student SET StudentName = @StudentName,RegNo =@RegNo,Quizzes=@Quizzes,Mids=@Mids,Finals=@Finals,TotalMarks=@TotalMarks WHERE RegNo="+regNo+";";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@StudentName", student.Name);
            command.Parameters.AddWithValue("@RegNo", student.RegNo);
            command.Parameters.AddWithValue("@Quizzes", student.Quizzes);
            command.Parameters.AddWithValue("@Mids", student.MidsMarks);
            command.Parameters.AddWithValue("@Finals", student.FinalsMarks);
            command.Parameters.AddWithValue("@TotalMarks", student.TotalMarks());
            command.ExecuteNonQuery();
        }
        public static SqlDataReader GetRegNo()
        {
            string qry = "SELECT RegNo FROM Student;";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = CommandType.Text;
            return command.ExecuteReader();
        }
        public static SqlDataReader SelectedRegNo(string regNo)
        {
            string qry = "SELECT * FROM Student WHERE RegNo = @RegNo;";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@RegNo", regNo);
            return command.ExecuteReader();
        }
        public static DataSet Search(string regNo)
        {
            string qry = "SELECT * FROM Student WHERE RegNo LIKE  '"+regNo+"%'";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Student");
            return ds;
        }
        public static SqlDataReader MinimumMarks()
        {
            string qry = "SELECT MIN(TotalMarks) FROM Student;";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = CommandType.Text;
            return command.ExecuteReader();
        }
        public static SqlDataReader MaximumMarks()
        {
            string qry = "SELECT MAX(TotalMarks) AS Maximum FROM Student;";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = CommandType.Text;
            return command.ExecuteReader();
        }
    }
}
