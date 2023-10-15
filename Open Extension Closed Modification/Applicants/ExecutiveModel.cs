namespace Open_Closed {
    internal class ExecutiveModel : IApplicantModel {
        public string FirstName { get; set; } = "ExecutiveFirstName";
        public string LastName { get; set; } = "ExecutiveLastName";
        public IAccounts AccountProcessor { get; set; } = new ExecutiveAccounts();
    }
}