namespace Dependency_Inversion {
    interface IMessageSender {
        void SendEmail(IPerson person, string message);
    }
}