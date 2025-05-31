using System.ComponentModel.DataAnnotations;

namespace RazorPage;

    public class Person
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }

        public Person(string firstName, string lastName, DateTime birthDate, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Email = email;
        }

        public string GetInfo()
        {
            return $"Имя: {FirstName} {LastName}\nДата рождения: {BirthDate.ToShortDateString()}\nEmail: {Email}";
        }
    }




