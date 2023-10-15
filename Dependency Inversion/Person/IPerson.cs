namespace Dependency_Inversion {
    public interface IPerson {
        string FirstName { get; set; }
        string LasName { get; set; }
        string EmailAddress { get; set; }
        string PhoneNumber { get; set; }
    }
}