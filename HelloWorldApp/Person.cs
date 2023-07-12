namespace HR;
public class Person{
    private string firstName;
    private string lastName;
    private readonly  DateTime birthDate;
    private string contactNumber;
    private string email;
    public void SetFirstName(string name){
        this.firstName=name;
    }
    public string  GetLastName(){
        return this.firstName;
    }

    //Property syntax
    public string FirstName{
        get{return this.firstName;}
        set{this.firstName=value;}
    }

    //constuctor overloading
    public Person(){}
    public Person(string fName, string lName, string contact, string email,
    DateTime bDate){
        this.firstName=fName;
        this.lastName=lName;
        this.birthDate=bDate;
        this.email=email;
        this.contactNumber=contact;
    }
    
    //GC calles destructor
    ~Person(){

    }

    public override string ToString(){
       string data= base.ToString();
       Console.WriteLine(data + "\n");
        return data + this.firstName + " "+ this.lastName+ " "+ this.email +
               this.contactNumber + " "+ this.birthDate;

    }
}