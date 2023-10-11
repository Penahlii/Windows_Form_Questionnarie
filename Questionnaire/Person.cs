using System.Security.Policy;

namespace Questionnaire;

public class Person
{
    public string Name { get; set; } 
    public string Surname { get; set; }
    public string FathersName { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public string Gender { get; set; }
    public DateTime birthday { get; set; }

    public Person() { }
    public Person(string name, string surname, string fathersName, string phone, string email, string country, string city, string gender)
    {
        Name = name;
        Surname = surname;
        FathersName = fathersName;
        Phone = phone;
        Email = email;
        Country = country;
        City = city;
        Gender = gender;
    }
}