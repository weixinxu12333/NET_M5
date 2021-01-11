using System;

namespace NET_M6_EMPLEATS
{
    class Program
    {
        static void Main(string[] args)
        {
            double souBase = 1000;

            Console.WriteLine($"Sou base: {souBase}");

            Base empleat = new Boss(souBase);
            Console.WriteLine("Sou de Boss: "  + empleat.SouBrutMensual);
            empleat = new Employee(souBase);
            Console.WriteLine("Sou de Employee: " + empleat.SouBrutMensual);
            empleat = new Manager(souBase);
            Console.WriteLine("Sou de Manager: " + empleat.SouBrutMensual);
            empleat = new Volunteer();
            Console.WriteLine("Sou de Volunteer: " + empleat.SouBrutMensual);



        }
    }
}
