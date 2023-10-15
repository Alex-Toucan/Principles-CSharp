using System;

namespace Dependency_Inversion {
    class Logger : ILogger {
        public void Log(string message) {
            Console.WriteLine($"Write to console: { message }");
        }
    }
}