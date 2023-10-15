namespace Dependency_Inversion {
    class Person : IPerson {
        public string FirstName { get; set; }
        public string LasName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
    }
}