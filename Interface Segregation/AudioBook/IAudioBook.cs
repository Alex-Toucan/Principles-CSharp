namespace Interface_Segregation {
    interface IAudioBook : ILibraryItem {
        int RuntimeInMinutes { get; set; }
    }
}