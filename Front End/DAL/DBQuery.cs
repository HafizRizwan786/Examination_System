using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Front_End.DAL
{
    class DBQuery
    {
        public static SqlConnection CreateConnection()
        {
            string str = @"Data Source = DESKTOP-35F36QH\SQLEXPRESS; Initial Catalog=OOP_DB_PROJECT; Integrated Security=True";
            SqlConnection connection = new SqlConnection(str);
            try
            {
                connection.Open();
            }
            catch (SqlException)
            {
                MessageBox.Show("Error in Connecting!!!");
            }
            return connection;

        }
        public static DataSet DisconnectedLayer()
        {
            SqlConnection connection = CreateConnection();
            DataSet ds = new DataSet();

            // Table List
            string[] tables = {
        "CLASS", "STUDENT_T", "SUBJECT_T", "FACULTY", "TEST",
        "StdSub", "FAC_SUB", "TESTSTD", "RESULT", "ClassSec", "ClassSub","Schedule"
    };

            foreach (string tableName in tables)
            {
                string qry = $"SELECT * FROM {tableName}";
                SqlCommand command = new SqlCommand(qry, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(ds, tableName); // Using tableName as DataTable name
            }

            return ds;
        }
        public static string VerifyEmail(string email)
        {
            string qry = "Select Email From FACULTY Where Email=@email";
            SqlConnection connection = CreateConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.Parameters.AddWithValue("@email", email);

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            object result = command.ExecuteScalar();
            //connection.Close();

            if (result != null && result != DBNull.Value)
                return result.ToString(); // Email exists, return it
            else
                return null; // Email does not exist

        }
        public static void UpdatePassword(string email,string Password)
        {
            string qry = "Update FACULTY Set FPassword = @Password Where Email= @email";
            SqlConnection connection = CreateConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@email", email);
            command.ExecuteNonQuery();

        }
        public static bool VerifyLogin(string email,string Password)
        {
            string qry = "Select count(*) From FACULTY Where Email=@email AND FPassword=@Password";
            SqlConnection connection = CreateConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@Password", Password);

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
               
            int count = (int)command.ExecuteScalar();
            connection.Close();

            return count > 0; // true if login is valid
        }
        public static SqlDataReader AddSec(int Cname)
        {
            string qry = "Select Sec From CLASS inner join ClassSec ON CLASS.CID=ClassSec.CID Where CName=@Cname";
            SqlConnection connection = CreateConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.Parameters.AddWithValue("@Cname", Cname);
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            return command.ExecuteReader();
        }
        public static SqlDataReader AddSub(int Cname,string sec)
        {
            string qry = "Select SubName From ClassSub inner join SUBJECT_T ON ClassSub.SubID=SUBJECT_T.SubID Where CID=(Select CID From CLASS wHERE CName=@Cname) AND Sec=@sec";
            SqlConnection connection = CreateConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.Parameters.AddWithValue("@Cname", Cname);
            command.Parameters.AddWithValue("@sec", sec);
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            return command.ExecuteReader();
        }
        public static SqlDataReader AddTest(int Cname)
        {
            string qry = "Select tName From(CLASS inner join ClassTest ON CLASS.CID= ClassTest.CID) inner join TEST ON TEST.Test_ID=ClassTest.TestID" +
                " Where CName=@Cname";
            SqlConnection connection = CreateConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.Parameters.AddWithValue("@Cname", Cname);
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            return command.ExecuteReader();
        }
        public static void AddSchedule(string cname,string sec,string sub,string tname,string date,int tmark,int pmark)
        {
            string qry = "Insert Into Schedule Values(@cname,@sec,@tname,@sub,@tmark,@pmark,@date)";
            SqlConnection connection = CreateConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.Parameters.AddWithValue("@cname", cname);
            command.Parameters.AddWithValue("@sec", sec);
            command.Parameters.AddWithValue("@sub", sub);
            command.Parameters.AddWithValue("@tname", tname);
            command.Parameters.AddWithValue("@tmark", tmark);
            command.Parameters.AddWithValue("@pmark", pmark);
            command.Parameters.AddWithValue("@date", date);
            command.ExecuteNonQuery();

        }
        public static SqlDataReader ListBox(string cname,string sec,string test)
        {
            string qry = "SELECT * FROM Schedule WHERE Class = @cname AND Section = @sec AND Test_Name = @test";
            SqlConnection connection = CreateConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.Parameters.AddWithValue("@cname", cname);
            command.Parameters.AddWithValue("@sec", sec);
            command.Parameters.AddWithValue("@test", test);
            return command.ExecuteReader();
        }
        public static void DelSchedule(string cname, string sec, string test, string subject, string date)
        {
            string qry = @"DELETE FROM Schedule WHERE Class = @cname AND Section = @sec AND Test_Name = @test AND Subject_Name = @subject AND S_Date = @date";

            SqlConnection connection = CreateConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.Parameters.AddWithValue("@cname", cname);
            command.Parameters.AddWithValue("@sec", sec);
            command.Parameters.AddWithValue("@test", test);
            command.Parameters.AddWithValue("@subject", subject);
            command.Parameters.AddWithValue("@date", date);
            command.ExecuteNonQuery();
        }
        public static void UpdateFullSchedule(string oldClass, string oldSec, string oldTest,string newClass, string newSec, string newTest,string subject, int totalMarks, int passingMarks, string date)
        {
            string qry = @"UPDATE Schedule 
                   SET 
                       Class = @newClass,
                       Section = @newSec,
                       Test_Name = @newTest,
                       Subject_Name = @subject,
                       Total_Marks = @total,
                       Passing_Marks = @passing,
                       S_Date = @date
                   WHERE 
                       Class = @oldClass AND 
                       Section = @oldSec AND 
                       Test_Name = @oldTest";

            using (SqlConnection connection = CreateConnection())
            {
                SqlCommand command = new SqlCommand(qry, connection);

                // New values
                command.Parameters.AddWithValue("@newClass", newClass);
                command.Parameters.AddWithValue("@newSec", newSec);
                command.Parameters.AddWithValue("@newTest", newTest);
                command.Parameters.AddWithValue("@subject", subject);
                command.Parameters.AddWithValue("@total", totalMarks);
                command.Parameters.AddWithValue("@passing", passingMarks);
                command.Parameters.AddWithValue("@date", date);

                // Old values for WHERE
                command.Parameters.AddWithValue("@oldClass", oldClass);
                command.Parameters.AddWithValue("@oldSec", oldSec);
                command.Parameters.AddWithValue("@oldTest", oldTest);

                command.ExecuteNonQuery();
            }
        }
        public static DataTable GetScheduleData(string cname, string sec, string test)
        {
            string qry = @"SELECT * FROM Schedule WHERE Class = @cname AND Section = @sec AND Test_Name = @test";

            SqlConnection connection = CreateConnection();
                SqlCommand command = new SqlCommand(qry, connection);
                command.Parameters.AddWithValue("@cname", cname);
                command.Parameters.AddWithValue("@sec", sec);
                command.Parameters.AddWithValue("@test", test);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
        }
        public static string teacherName(string email)
        {
            string qry = "Select fName From FACULTY Where Email=@email";
            SqlConnection connection = CreateConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.Parameters.AddWithValue("@email", email);
            object name = command.ExecuteScalar();
            return name.ToString();
        }
        public static SqlDataReader Tsub(string tname)
        {
            string qry = "SELECT DISTINCT S.SubName FROM SUBJECT_T S WHERE S.SubID IN( SELECT FS.SubID FROM FAC_SUB FS INNER JOIN FACULTY F ON F.EmpID = FS.EmpID WHERE F.fName = @tname)";

            SqlConnection connection = CreateConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.Parameters.AddWithValue("@tname", tname);
            return command.ExecuteReader();
        }
        public static bool checkSchedule(int Class,string sec,string test,string sub,int tmarks)
        {
            string qry = "Select count(*) From Schedule where Class=@Class AND Section=@sec AND Subject_Name=@sub AND Test_Name=@test AND Total_Marks=@tmarks";
            SqlConnection connection = CreateConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.Parameters.AddWithValue("@Class", Class);
            command.Parameters.AddWithValue("@sec",sec);
            command.Parameters.AddWithValue("@sub", sub);
            command.Parameters.AddWithValue("@test", test);
            command.Parameters.AddWithValue("@tmarks", tmarks);

            object a = command.ExecuteScalar();

            if (Convert.ToInt16(a) != 0)
            {
                return true;
            }
            else
            {

                return false;
            }
        }
        public static bool checkStudent(int id,string name)
        {
            string qry = "Select count(*) From STUDENT_T where St_ID=@id AND SName=@name";
            SqlConnection connection = CreateConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@name", name);
            int count = Convert.ToInt32(command.ExecuteScalar());
            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;

            }
        }
        public static void  Result(int id,string name,int Class,string sec,string sub,string test,int tmark,int gmark,string per,string status)
        {
            string qry = "Insert into RESULT Values(@id,@name,@Class,@sec,@sub,@test,@tmark,@gmark,@per,@status)";
            SqlConnection connection = CreateConnection();
            SqlCommand command = new SqlCommand(qry,connection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@Class", Class);
            command.Parameters.AddWithValue("@sec", sec);
            command.Parameters.AddWithValue("@sub", sub);
            command.Parameters.AddWithValue("@test", test);
            command.Parameters.AddWithValue("@tmark", tmark);
            command.Parameters.AddWithValue("@gmark", gmark);
            command.Parameters.AddWithValue("@per", per);
            command.Parameters.AddWithValue("@status", status);
            command.ExecuteNonQuery();
        }
        public static DataTable GetResultData(int Class,string sec,string sub,string test)
        {
            string qry = "SELECT * FROM RESULT Where Class=@Class AND Section=@sec AND Subject_Name=@sub AND Test_Name = @test";
            SqlConnection connection = CreateConnection();
                SqlCommand command = new SqlCommand(qry, connection);
            command.Parameters.AddWithValue("@Class", Class);
            command.Parameters.AddWithValue("@sec", sec);
            command.Parameters.AddWithValue("@sub", sub);
            command.Parameters.AddWithValue("@test", test);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
        }
        public static void DeleteResult(int studentId, string testName, string subjectName)
        {
            string qry = "DELETE FROM RESULT WHERE Student_ID = @sid AND Test_Name = @test AND Subject_Name = @sub";
            using (SqlConnection connection = CreateConnection())
            {
                SqlCommand cmd = new SqlCommand(qry, connection);
                cmd.Parameters.AddWithValue("@sid", studentId);
                cmd.Parameters.AddWithValue("@test", testName);
                cmd.Parameters.AddWithValue("@sub", subjectName);
                cmd.ExecuteNonQuery();
            }
        }
        public static void UpdateResult(int oldSid, string oldTest, string oldSub,int sid, string name, int cname, string sec, string sub, string test, int pmarks, int gmarks, string percent, string status)
        {
            string qry = @"UPDATE RESULT 
                   SET Student_ID = @sid,
                       Student_Name = @name,
                       Class = @class,
                       Section = @sec,
                       Subject_Name = @sub,
                       Test_Name = @test,
                       Passing_Marks = @pmarks,
                       Gain_Marks = @gmarks,
                       Percentage = @percent,
                       Status = @status
                   WHERE Student_ID = @oldSid AND Test_Name = @oldTest AND Subject_Name = @oldSub";

            using (SqlConnection connection = CreateConnection())
            {
                SqlCommand cmd = new SqlCommand(qry, connection);
                cmd.Parameters.AddWithValue("@sid", sid);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@class", cname);
                cmd.Parameters.AddWithValue("@sec", sec);
                cmd.Parameters.AddWithValue("@sub", sub);
                cmd.Parameters.AddWithValue("@test", test);
                cmd.Parameters.AddWithValue("@pmarks", pmarks);
                cmd.Parameters.AddWithValue("@gmarks", gmarks);
                cmd.Parameters.AddWithValue("@percent", percent);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@oldSid", oldSid);
                cmd.Parameters.AddWithValue("@oldTest", oldTest);
                cmd.Parameters.AddWithValue("@oldSub", oldSub);

                cmd.ExecuteNonQuery();
            }
        }


    }
}
