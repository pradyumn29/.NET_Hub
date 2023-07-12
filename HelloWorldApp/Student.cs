using HR;
namespace LMS;
public class Student:Person{
    //member variables
    private int prnNumber;
    private string course;
    private DateTime registrationDate;
   //member functions
   public Student(){
    count++;
   }

    public Student(int prn, string course, DateTime date, 
                   string fName, string lName, string email,
                   string contact,DateTime bDate)
                   :base(fName,lName,contact,email,bDate){
        this.prnNumber=prn;
        this.course=course;
        this.registrationDate=date;
        count++;


    }
   public override string ToString(){
    string data=base.ToString();
    return data + this.prnNumber + " " + this.course+ " "+ this.registrationDate;
   }
    public static int count;
    public static int GetCount(){
        return count;

    }
}