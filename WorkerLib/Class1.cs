using System;

namespace WorkerLib
{
    public class Employee
    {
        public string Name { set; get; }
        public string FirstName { set; get; }
        public string Surname { set; get; }
        public string Place { set; get; }
        public Date Date { set; get; }
        public string Sex { set; get; }
        public string NumberOfPeopleInTheFamily { set; get; }
       
    }
    public class Date
    {
        public int Day { set; get; }
        public int Mounth { set; get; }
        public int Year { set; get; }
    }
}
