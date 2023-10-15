using System;
using System.Collections.Generic;

namespace Open_Closed {
    class Program {
        static void Main(string[] args) {
            List<IApplicantModel> applicants = new List<IApplicantModel> {
                new StaffModel { FirstName = "Tim", LastName = "Corey" },
                new ManagerModel { FirstName = "Sue", LastName = "Storm" },
                new ExecutiveModel { FirstName = "Nancy", LastName = "Roman" }
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();

            foreach (var person in applicants) {
                employees.Add(person.AccountProcessor.Create(person));
            }

            foreach (var emp in employees) {
                Console.WriteLine($"{ emp.FirstName } { emp.LastName }: { emp.EmailAddress } IsManager: { emp.IsManager } IsExecutive: { emp.IsExecutive }");
            }

            Console.ReadLine();
        }
    }
}
