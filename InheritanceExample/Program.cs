// See https://aka.ms/new-console-template for more information
using InheritanceExample;

Console.WriteLine("Hello, World!");

//Person on abstract, joten siitä ei voi luoda oliota
//Person person = new Person();
Student student = new Student();
Teacher teacher = new Teacher();
student.CreditPoints = 55;
teacher.Salary = 2500;
student.SayHello("Tampereelta");
teacher.SayHello("Turusta");