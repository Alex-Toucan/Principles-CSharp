using System;

namespace Liskov_Substitution {
    class Program {
        static void Main(string[] args) {
            IManager accountVIP = new CEO {
                FirstName = "Emma",
                LastName = "Stone"
            };
            accountVIP.CalculatePerHourRate(4);

            Employee emp = new Manager {
                FirstName = "Tim",
                LastName = "Corey"
            };
            emp.AssignManager(accountVIP);
            emp.CalculatePerHourRate(2);

            Console.WriteLine($"{ emp.FirstName }'s sallary is ${ emp.Salary }/hour.");

            Console.ReadLine();
        }
    }
}
