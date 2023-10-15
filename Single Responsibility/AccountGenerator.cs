using System;

namespace Single_Responsibility {
    internal class AccountGenerator {
        public static void CreateAccount(Person user) {
            // Create a username for the person
            Console.WriteLine($"Your username is { user.FirstName[..1] }{ user.LastName }");
        }
    }
}