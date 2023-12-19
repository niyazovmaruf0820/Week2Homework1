System.Console.WriteLine("Enter your FirstName : ");
string firstname = Console.ReadLine();
System.Console.WriteLine("Enter your LastName : ");
string lastname = Console.ReadLine();
System.Console.WriteLine("Enter your Age : ");
int age = Convert.ToInt32(Console.ReadLine());
Person person = new Person();
person.FirstName = firstname;
person.LastName = lastname;
person.Age = age;
System.Console.WriteLine(person.Information());

class Person
{
    public string FirstName;
    public string LastName;
    public int Age;
    public string Information()
    {
        return $"FirstName: {FirstName} \nLastName: {LastName} \nAge: {Age}";
    }
}