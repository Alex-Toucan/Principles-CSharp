using System;

namespace Dependency_Inversion {
    class Program {
        public static void Main(string[] args) {
            IPerson owner = Factory.CreatePerson();
            owner.FirstName = "Tim";
            owner.LasName = "Corey";
            owner.EmailAddress = "tim@iamtimcoray.com";
            owner.PhoneNumber = "555-1212";

            IChore chore = Factory.CreateChore();
            chore.ChoreName = "Take out the trash";
            chore.Owner = owner;

            chore.PerformWork(3);
            chore.PerformWork(1.5);
            chore.CompleteChore();

            Console.ReadLine();
        }
    }
}
