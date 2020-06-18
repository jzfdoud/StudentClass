using System;

namespace StudentClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var Jada = new Student();
            Jada.Name = "Jada";
            Jada.ID = 1;
            Jada.GPA = 3.5;
            Jada.SAT = 1600;
            Jada.TimesTardy = 112;
            Console.WriteLine($"Jada's name is {Jada.Name}");
            Console.WriteLine($"Jada's BC score is {Jada.BC(2)}");


            var Steve = new Student();
            Steve.Name = "Steve";
            Steve.ID = 2;
            Steve.GPA = 4.0;
            Steve.SAT = 1599;
            Steve.TimesTardy = 0;
            var steveString = Steve.GetValues();
            Console.WriteLine($"Steve: {steveString}");
            // calls the BC method for steve's instance
            Console.WriteLine($"Steve's BC score is {Steve.BC(2)}");

            var Dave = new Student("Dave",100, 1250, 3.5, 2);
        

        }   
    }

}
