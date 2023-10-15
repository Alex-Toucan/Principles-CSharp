namespace Open_Closed {
    internal class StaffModel : IApplicantModel {
        public string FirstName { get; set; } = "StaffFirstName";
        public string LastName { get; set; } = "StaffLastName";
        public IAccounts AccountProcessor { get; set; } = new Accounts();
    }
}