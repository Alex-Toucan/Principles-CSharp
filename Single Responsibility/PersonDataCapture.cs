using System;

namespace Single_Responsibility {
    internal class PersonDataCapture {
        public static Person Capture() {
            // Ask for user information
            Person output = new Person();

            Console.Write("What's your first name: ");
            output.FirstName = Console.ReadLine() ?? string.Empty;

            Console.Write("What's your last name: ");
            output.LastName = Console.ReadLine() ?? string.Empty;

            return output;
        }
    }
}