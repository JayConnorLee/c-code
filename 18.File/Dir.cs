using System;
using System.Linq;
using System.IO;

namespace _18.File
{
    public class Dir
    {
        
        




        //   public static void Dir_Main(string[] args)
        // {
        //     string directory;
        //     if (args.Length < 1)
        //         directory = ".";
        //     else
        //         directory = args[0];
            
        //     Console.WriteLine($"{directory} directory Info");
        //     Console.WriteLine("- Direcotries :");
        //     var directories = (from dir in Directory.GetDirectories(directory)
        //                         let info = new DirectoryInfo(dir)
        //                         select new{
        //                             Name = info.Name,
        //                             Attributes = info.Attributes
        //                         }).ToList();

        //     foreach (var d in directories)
        //         Console.Write($"{d.Name} : {d.Attributes}");
            
        //     Console.WriteLine("- File :");
        //     var files = (from file in Directory.GetFiles(directory)
        //                 let info = new FileInfo(file)
        //                 select new{
        //                     Name = info.Name,
        //                     FileSize = info.Length,
        //                     Attributes = info.Attributes
        //                 }).ToList();

        //     foreach (var f in files)
        //         Console.WriteLine(
        //             $"{f.Name} : {f.FileSize}, {f.Attributes}");
        // }

    }
}
