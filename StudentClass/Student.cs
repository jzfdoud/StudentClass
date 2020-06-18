using System;
using System.Collections.Generic;
using System.Text;

namespace StudentClass
{
    class Student
    {
        public double GPA;
        public int SAT;
        public int TimesTardy;
        public string Name;
        public int ID;

        private double SecretNumberCalculation(double Bnumber, int SecretNumber)
        {
            return Bnumber / SecretNumber;
        }

        public double BC(int SecretNumber)
        {
            var dblsat = SAT * 2;
            var b = dblsat * GPA;
            var bc = SecretNumberCalculation(b, SecretNumber);
            return bc;
        }

        public string GetValues()
        {
            //what to do when this is actually called = {}
            return $"{ID}|{Name}|{SAT}|{GPA}|{TimesTardy}";
        }

        public Student()
        {// default constructor, takes no parameters. Contructors exist in oder to initialize
        }
        public Student(string Name, int ID, int SAT, double GPA, int TimesTardy)
        {
            this.Name = Name;
            this.ID = ID;
            this.SAT = SAT;
            this.GPA = GPA;
            this.TimesTardy = TimesTardy;

        // <this.> allows the system know that the variable 'name' is a parameter and not a property
        }

    }
}
