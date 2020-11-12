using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax.
             *
             * HINT: Use the List of Methods defined in the Lecture Material Google Doc ***********
             *
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //Print the Sum and Average of numbers
            int sum = numbers.Sum();
            Console.WriteLine($"Sum = {sum}.");
            double avg = numbers.Average();
            Console.WriteLine($"Average = {avg}.");
            Console.WriteLine("..........................");

            //Order numbers in ascending order and decsending order. Print each to console.
            var ascend = numbers.OrderBy(x => x);
            foreach(var i in ascend)
            {
                Console.WriteLine(i);
            }
            var descend = numbers.OrderByDescending(x => x);
            foreach(var x in descend)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine(".........................");

            //Print to the console only the numbers greater than 6
            var greater = numbers.Where(x => x > 6);
            foreach(var x in greater)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("............................");

            //Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
            var onlyFour = numbers.OrderByDescending(x => x).Take(4);
            foreach(var i in onlyFour)
            {
                Console.WriteLine(i);
            }

            //Change the value at index 4 to your age, then print the numbers in decsending order
            numbers[4] = 23;
            Console.WriteLine("........................");

            // List of employees ***Do not remove this***
            var employees = CreateEmployees();

            //Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S.
            var csNames = employees.Where(x => x.FirstName[0] == 'C' || x.FirstName[0] == 'S');
            foreach(var cs in csNames)
            {
                Console.WriteLine(cs);
            }

            //Order this in acesnding order by FirstName.
            var acsendFirst = employees.OrderBy(x => x.FirstName);
            Console.WriteLine($"{ascend}");
            Console.WriteLine("...........................");

            //Print all the employees' FullName and Age who are over the age 26 to the console.
            //Order this by Age first and then by FirstName in the same result.
            var nameAge = employees.Where(x => x.Age > 26).OrderByDescending(x => x.Age ).ThenBy(x => x.FullName);
            foreach(var na in nameAge)
            {
                Console.WriteLine(na.FullName);
            }

            //Print the Sum and then the Average of the employees' YearsOfExperience
            //if their YOE is less than or equal to 10 AND Age is greater than 35
            var sumAvg1 = employees.Sum(x => x.YearsOfExperience);
            Console.WriteLine(sumAvg1);
            var sumAvg2 = employees.Average(x => x.YearsOfExperience);
            Console.WriteLine(sumAvg2);



            //Add an employee to the end of the list without using employees.Add()


            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
