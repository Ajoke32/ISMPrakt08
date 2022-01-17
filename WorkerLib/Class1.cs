using System;

namespace WorkerLib
{
    public class Employee
    {
        public string Name { set; get; }
        public string FirstName { set; get; }
        public string Surname { set; get; }
        public PlaceOfWork Place { set; get; }
        public Date Date { set; get; }
        public string Sex { set; get; }
        public string NumberOfPeopleInTheFamily { set; get; }
        public Employee(string name, string firstname, string surname,
            PlaceOfWork place, Date date, string sex, string nameofPF)
        {
            Name = name;
            FirstName = firstname;
            Surname = surname;
            Place = place;
            Date = date;
            Sex = sex;
            NumberOfPeopleInTheFamily = nameofPF;
        }
        public Employee(string name, string firstname, string surname)
        {
            Name = name;
            FirstName = firstname;
            Surname = surname;
        }
        public Employee(Employee obj)
        {
            Name = obj.Name;
            FirstName = obj.FirstName;
            Surname = obj.Surname;
            Place = obj.Place;
            Date = obj.Date;
            Sex = obj.Sex;
            NumberOfPeopleInTheFamily = obj.NumberOfPeopleInTheFamily;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Name:{Name}\nFirst:{FirstName}\nSurname:{Surname}\nPlace:{Place}" +
                $"\nDate:{Date}\nSex:{Sex}Number of people in the family:{NumberOfPeopleInTheFamily}");
        }
    }
    public class Date
    {
        public int Day { set; get; }
        public int Mounth { set; get; }
        public int Year { set; get; }
    }
    public class TheAdress
    {
        public string Country { set; get; }
        public string City { set; get; }
        public string Street { set; get; }
        public int NumberHouse { set; get; }
        public int Index { set; get; }
        public TheAdress(string country, string city, string street,
            int nubmerhouse, int index)
        {
            Country = country;
            City = city;
            Street = street;
            NumberHouse = nubmerhouse;
            Index = index;
        }

    }
    public class PlaceOfWork
    {
        public string CompanyName { set; get; }
        public TheAdress Adress { set; get; }
        public int JobEvaluation { set; get; }
        public string FeedbackAboutTheJob { set; get; }
    }
}
