namespace Open_Closed {
    
    internal interface IApplicantModel {
        string FirstName { get; set; }
        string LastName { get; set; }
        IAccounts AccountProcessor { get; set; }
    }
}