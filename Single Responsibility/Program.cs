namespace Single_Responsibility {
    class Program {
        static void Main(string[] args) {
            StandardMessages.Welcome();

            Person user = PersonDataCapture.Capture();

            bool isValid = PersonValidator.Validate(user);

            if (!isValid) {
                StandardMessages.EndApplication();
                return;
            }

            AccountGenerator.CreateAccount(user);
        
            StandardMessages.EndApplication();
        }
    }
}
