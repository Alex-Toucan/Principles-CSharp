namespace Interface_Segregation {
    interface IBook : ILibraryItem {
        string Author { get; set; }
        int Pages { get; set; }
    }
}