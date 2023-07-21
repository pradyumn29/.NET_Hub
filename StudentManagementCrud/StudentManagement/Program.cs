// See https://aka.ms/new-console-template for more information
using DAL;
using BOL;

List<Student> students = DBManager.getAllStudents();

foreach(var stud in students)
{
    Console.WriteLine(stud);
}

Student student =DBManager.getStudentById(1);
Console.WriteLine(student);

Student student=new Student(2,"sushant",23,"01/01/2020","QSpider",30000)