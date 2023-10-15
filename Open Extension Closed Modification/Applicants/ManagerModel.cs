namespace Open_Closed {
    internal class ManagerModel : IApplicantModel {
        public string FirstName { get; set; }  = "ManagerFirstName";
        public string LastName { get; set; } = "ManagerLastName";
        public IAccounts AccountProcessor { get; set; } = new ManagerAccounts();
    }
}