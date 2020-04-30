using System;
using System.Runtime.CompilerServices;
using System.IO;
using functions;

namespace _16.Reflection
{
    
    public static class Trace
    {
        public static void WriteLine(string message,
            [CallerFilePath] string file = "",
            [CallerLineNumber] int line = 0,
            [CallerMemberName] string member = ""
        )
        {
            Console.WriteLine($"{file}(Line:{line}) {member}: {message}");
        }
    }

    class CallerInfo
    {

        static void Main2(string[] args)
        {
            Trace.WriteLine("Happy Time!");

            // string path = @"C:\Users\Connor\Dropbox\Dev\Workspace\C#\Book\data.txt";
            string path = @"C:\Users\Connor\Dropbox\Dev\Workspace\C#\Book\data.txt";
            string ee ="toehusna,.dntaoenithasnteh";

            System.IO.File.WriteAllText(path, ee);

            string[] lines = {"old falcon", "deep forest", "golden ring"};
            System.IO.File.AppendAllLines(path, lines);
            // File.WriteAllLines(path, lines);
            
            fn.ToTxt(path, lines);

            string s = fn.FromTxt(path);

            Console.WriteLine(s);            
      
            s = File.ReadAllText(path);

            Console.WriteLine(s);

            File.AppendAllText(path, "snteasntintaoeinsta,.i\noenias,n.dsnaoei\na,einasedina,sni\nsonedsn\n\n");

            s = File.ReadAllText(path);

            Console.WriteLine(s);


            // Console.WriteLine("lines written to file");
        }

    }
 
}
