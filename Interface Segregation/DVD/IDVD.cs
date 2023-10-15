using System.Collections.Generic;

namespace Interface_Segregation {
    interface IDVD : ILibraryItem {
        List<string> Actors { get; set; }
        int RuntimeInMinutes { get; set; }
    }
}