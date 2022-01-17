using System;
using WorkerLib;
namespace MainConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee worker1 = new Employee("Den","Novikov","Eduardovich",
              new PlaceOfWork("ISM", new TheAdress("Ukraine", "Kyiv", "Kreschatyk", 45, 34983),5,"good"),
              new Date(12,9,2021),"men",2);
            Employee worker2 = new Employee("Maks", "Ivasyk", "Petrovich",
              new PlaceOfWork("Viseven", new TheAdress("Russia", "Moskow", "Tverskaya", 14, 126485), 4, "normal"),
              new Date(13,11, 2020), "men", 1);


        }
    }
}
