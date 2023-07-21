using BOL;
using MySql.Data.MySqlClient;
using System.Transactions;

namespace DAL
{
    public class DBManager
    {
        public static string coString = @"server=localhost;port=3306;user=root;password=root123;database=test";

        public static List<Student> getAllStudents()//add dependency MYsql.data from dependency nuggets
        {
            List<Student> stud=new List<Student> ();

            MySqlConnection con = new MySqlConnection();//connection object
            con.ConnectionString = coString;

            try
            {
                //open the connecction
                con.Open ();

                //firequery to database
                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = con;
                string query = "select * from Student";
                cmd.CommandText = query;//
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    /* private string id;
                      private string name;
                      private int age;
                      private DateOnly bDate;
                      private string course;
                      private double fees;*/

                    int id = int.Parse(reader["Id"].ToString());
                 /*   Console.WriteLine(id);*/
                    string name = reader["Name"].ToString();
                    int age = int.Parse(reader["Age"].ToString());
                    string course = reader["Course"].ToString();
                  //  Console.WriteLine (course);
                    double fees = double.Parse(reader["Fees"].ToString());
                    DateOnly bDate = DateOnly.Parse(reader["BDate"].ToString().Substring(0,10));

                    Student student = new Student(id,name,age,bDate,course,fees);
                    //{
                    //    Id = id,
                    //    Name = name,
                    //    Age = age,
                    //    BDate = bDate,
                    //    Course = course,
                    //    Fees = fees
                    //};

                    stud.Add(student);
               
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { con.Close (); }
            return stud;
        }


        public static Student getStudentById(int id)
        {
            Student student = null;
            MySqlConnection con=new MySqlConnection();
            con.ConnectionString = coString;
            try
            {
                string query = "SELECT * FROM student where id=" + id;
                con.Open();
                MySqlCommand command = new MySqlCommand(query, con);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    id = int.Parse(reader["id"].ToString());
                    string name = reader["Name"].ToString();
                    int age = int.Parse(reader["Age"].ToString());
                    string course = reader["Course"].ToString();
                   
                    double fees = double.Parse(reader["Fees"].ToString());
                    DateOnly bDate = DateOnly.Parse(reader["BDate"].ToString().Substring(0, 10));
                    student = new Student(id, name, age, bDate, course, fees);

                }
            }catch (Exception ex) { 
                Console.WriteLine(ex.Message);
            }
            finally { 
                con.Close (); 
            }
            return student;

        }

        public static Student AddStudent(Student student)
        {
            string query = "insert into student values('" + student.Id + "','" + student.Name + "','" 
                                                       + student.Age + "','" + student.BDate + "','" 
                                                       + student.Course + "','" + student.Fees + "')";
            MySqlConnection connection = new MySqlConnection(); 
            connection.ConnectionString = coString;

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.ExecuteNonQuery();
            }catch (Exception ex) {
                Console.WriteLine(ex.Message);
                    }
            finally { 
                connection.Close();
            }
            return student;
        }

        

    }
}