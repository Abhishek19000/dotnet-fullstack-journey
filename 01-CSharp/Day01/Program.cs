Person p1= new Person();

p1.Name="Abhishek";

Person p2 = p1;

p2.Name="Rahul";

Console.WriteLine($"p1.Name = {p1.Name}");
Console.WriteLine($"p2.Name = {p2.Name}");

class Person
{
       public string? Name {get;set;}
}
