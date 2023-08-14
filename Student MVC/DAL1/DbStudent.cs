using BOL1;
using MySql.Data.MySqlClient;


namespace DAL1   
{
    public class DbStudent
    {
        public static string connstring = @"server=localhost;port=3306;user=root;password=root123;database=dotNet";

        public static List<Student> GetStudent()
        {
            List<Student>studList=new List<Student>();
            MySqlConnection conn = new MySqlConnection();

            conn.ConnectionString = connstring;
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                string query = "Select * from Student";
                cmd.CommandText = query;

                MySqlDataReader reader = cmd.ExecuteReader(); ;

                while (reader.Read())
                {
                    int id = int.Parse(reader["id"].ToString());
                    string name = reader["name"].ToString();
                    double fees = double.Parse(reader["fees"].ToString());
                    Course course = Enum.Parse<Course>(reader["course"].ToString().ToUpper());
                    DateOnly joinDate = DateOnly.FromDateTime(DateTime.Parse(reader["joinDate"].ToString()));

                    Student student = new Student(id,name, fees, course,joinDate);
                    Console.WriteLine(student);
                    studList.Add(student);

                    
                     
                }
            }catch (Exception ex) {
                
                Console.Write(ex.Message);

            }finally { 

                conn.Close();
                
            }
            
            return studList;

        }

        public static void insertStudent(Student newStudent)
        {
            MySqlConnection conn = new MySqlConnection();

            conn.ConnectionString = connstring;

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;

                string query = "insert into student values('" + newStudent.id + "','" +newStudent.name + "','" + newStudent.fees + "','" + newStudent.course + "','" + newStudent.joinDate.ToString("yyyy-MM-dd") + "')";
                cmd.CommandText = query;
                Console.WriteLine(newStudent);
                cmd.ExecuteNonQuery();
            }catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            finally { conn.Close(); }
        }
    }
}