namespace BOL1
{

    public enum Course { CDAC,DBDA,DITISS}
    public class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public double fees { get; set; }
        public Course course { get; set; }
        public DateOnly joinDate { get; set; } 

        public Student()
        {

        }

        public Student(int id, string name, double fees, Course course, DateOnly joinDate)
        {
            this.id = id;
            this.name = name;
            this.fees = fees;
            this.course = course;
            this.joinDate = joinDate;
        }

   /*     public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Fees
        {
            get { return fees; }
            set { fees = value; }
        }

        public Course Course
        {
            get { return course; }
            set { course = value; }
        }

        public DateOnly JoinDate
        {
            get { return joinDate; }
            set { joinDate = value; }
        }*/

        public override string ToString()
        {
            return $"{this.id}{this.name}{this.fees}{this.course}{this.joinDate}";
        }
    }
}