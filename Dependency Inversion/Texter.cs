using System;

namespace Dependency_Inversion {
    class Texter : IMessageSender {
        public void SendEmail(IPerson person, string message) {
            Console.WriteLine($"I am texting { person.FirstName } to say { message }");
        }
    }
}