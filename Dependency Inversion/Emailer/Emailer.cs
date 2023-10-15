using System;

namespace Dependency_Inversion {
    class Emailer : IMessageSender {
        public void SendEmail(IPerson person, string message) {
            Console.WriteLine($"Similating sending an message to { person.EmailAddress }");
        }
    }
}