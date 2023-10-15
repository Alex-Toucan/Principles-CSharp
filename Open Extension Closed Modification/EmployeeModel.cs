namespace Open_Closed {
    internal class EmployeeModel {
        public string FirstName { get; set; } = "DefaultFirstName";
        public string LastName { get; set; } = "DefaultLastName";
        public string EmailAddress { get; set; } = "DefaultEmailAddress";
        public bool IsManager { get; set; } = false;
        public bool IsExecutive { get; set; } = false;
    }
}