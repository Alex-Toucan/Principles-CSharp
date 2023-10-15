namespace Liskov_Substitution {
    interface IManaged : IEmployee {
        IEmployee Manager { get; set; }
        void AssignManager(IEmployee manager);
    }
}