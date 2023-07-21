using System.Runtime.CompilerServices;

namespace BOL
{
    public class Student
    {
        private int id;
        private string name;
        private int age;
        private DateOnly bDate;
        private string course;
        private double fees;

        public Student() { }

        public Student(int id, string name, int age, DateOnly bDate, string course, double fees)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.bDate = bDate;
            this.course = course;
            this.fees = fees;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateOnly BDate { get; set;}
        public string Course { get; set;}
    
        public double Fees { get; set;}

        public override string ToString()
        {
            return String.Format("{0},{1},{2},{3},{4},{5}",id,name,age,bDate,course,fees);
        }
    }
}