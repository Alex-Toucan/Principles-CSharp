using System;

namespace Single_Responsibility {
    internal class StandardMessages {
        public static void Welcome() {
            Console.WriteLine("Welcome to my application!");
        }

        public static void EndApplication() {
            Console.Write("Press enter to close...");
            Console.ReadLine();
        }

        public static void DisplayValidationError(string fieldName) {
            Console.WriteLine($"You did not give us a valid last { fieldName }!");
        }
    }
}