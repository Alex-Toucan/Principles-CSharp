namespace Open_Closed {
    internal class Accounts : IAccounts {
        public EmployeeModel Create(IApplicantModel person) {
            EmployeeModel output = new EmployeeModel {
                FirstName = person.FirstName,
                LastName = person.LastName,
                EmailAddress = $"{person.FirstName[..1]}{person.LastName}@acme.com"
            };

            return output;
        }
    }
}