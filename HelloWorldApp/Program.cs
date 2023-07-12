using System.Reflection;
using Maths;
using tfllib;
using Drawing;
using System.Collections.Generic;
using LMS;
using PMS;
using Specifications;
using Catalog;
using CRM;


// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int result=56;
bool status=false;
string fullName="Ravi Tambade";
String cdac="iacsd";
DateTime currentTime=DateTime.Now;
Console.WriteLine(currentTime);

DateTime regDate=new DateTime(2023,04,18);
DateTime birthDate=new DateTime(1999,07,1);
Student std1=new Student(76, "pgdac", regDate, 
                   "Parag","Pande","parag.pande@gmail.com",
                   "9881735801",birthDate);

Console.WriteLine(std1);




 // Get the currently executing assembly.
Assembly currentAssem = Assembly.GetExecutingAssembly();
Console.WriteLine("Currently executing assembly:");
Console.WriteLine("   {0}\n", currentAssem.FullName);


int resultAddition=MathEngine.Addition(56,56);
Console.WriteLine("Result= "+ resultAddition);

Complex c1=new Complex(34,56);
Complex c2=new Complex(45,99);

Complex c3=c1 + c2;
Console.WriteLine(c3);
const double PI=3.14;

Point startPoint1=new Point(1,12);
Point endPoint1=new Point(30,10);

Point startPoint2=new Point(5,112);
Point endPoint2=new Point(30,20);

Point startPoint3=new Point(15,12);
Point endPoint3=new Point(150,120);

Shape l1=new Line(startPoint1, endPoint1, 5, "red");
Shape l2=new Line(startPoint2, endPoint2, 3, "blue");
Shape l3=new Line(startPoint3, endPoint3, 1, "green");

List<Shape> allShapes=new List<Shape>();
allShapes.Add(l1);
allShapes.Add(l2);
allShapes.Add(l3);

foreach( Shape s in allShapes){
    s.Draw();
}

int num1=67;
int num2=89;

object obj1=(object) num1;
object obj2=(object) num2;

//MathEngine.Swap(ref obj1, ref obj2);
MathEngine.Swap( ref obj1, ref obj2);



double area=0;
double circumference=0;

Console.WriteLine("Area={0}",area);
Console.WriteLine("Circumference={0}",circumference);

MathEngine.Calculate(25,out area,out circumference);

Console.WriteLine("After Calculation ...");
Console.WriteLine("Area={0}",area);
Console.WriteLine("Circumference={0}",circumference);

Profile myProfile=new Profile();
myProfile.firstName="Ravi";
myProfile.lastName="Tambade";

myProfile.qualification="B.E. comp";
myProfile.grade="firstclass";

myProfile.company="Transflower Learning Pvt. Ltd.";
myProfile.experience=25;

Console.WriteLine(myProfile);

Printing.Printer printer=new Printing.Printer();
printer.PrintObjects(23,56,76,78);
printer.PrintObjects("Prashant","Rohit", "Narendra", "Sonali");
printer.PrintObjects(c1,c2);



Product p1=new Product(23,"Rose","Valentine Flower",150,5000);
Product p2=new Product(24,"Jasmine","Smelling Flower",1,85000);

/*ISellable ps1=p1;
ps1.Test();
ps1.Promote();
ps1.Sell();

*/

ISellable service1=new Service("Mentoring Service","Transflower",true);
ISellable service2=new Service("Placement Service","cdac",true);

List<ISellable> items=new List<ISellable>();
items.Add(p1);
items.Add(p2);
items.Add(service1);
items.Add(service2);

foreach(ISellable item in items){
    item.Test();
    item.Promote();
    item.Sell();
}
