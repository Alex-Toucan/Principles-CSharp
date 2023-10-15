namespace Dependency_Inversion {
    class Chore : IChore {
        readonly ILogger _logger;
        readonly IMessageSender _messageSender;

        public string ChoreName { get; set; }
        public IPerson Owner { get; set; }
        public double HoursWorked { get; private set; }
        public bool IsComplete { get; private set; }

        public Chore(ILogger logger, IMessageSender messageSender) {
            _logger = logger;
            _messageSender = messageSender;
        }

        public void PerformWork(double hours) {
            HoursWorked += hours;
            _logger.Log($"Performed work on { ChoreName }");
        }

        public void CompleteChore() {
            IsComplete = true;

            _logger.Log($"Completed { ChoreName }");

            _messageSender.SendEmail(Owner, $"The chore { ChoreName } is complete.");
        }
    }
}