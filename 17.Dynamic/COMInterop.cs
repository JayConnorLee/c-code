using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;

namespace _17.Dynamic
{
  
    class COMInterop
    {
        public static void OldWay(string[,] data, string savePath)
        {
            Excel.Application excelApp = new Excel.Application();
            excelApp.Workbooks.Add(Type.Missing);

            Excel.Worksheet workSheet = (Excel.Worksheet)excelApp.ActiveSheet;

            for (int i = 0; i < data.GetLength(0); i++)
            {
                // ((Excel.Range)(workSheet.Cells[i + 1, 1]).Value2 = data[i, 0];
                ((Excel.Range)(workSheet.Cells[i + 1, 1])).Value2 = data[i, 0];
                ((Excel.Range)(workSheet.Cells[i + 1, 2])).Value2 = data[i, 1];
            }

            workSheet.SaveAs(savePath + "\\shpark-book-old.xlsx",
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing
            );

            excelApp.Quit();

            
        }

        public static void NewWay(string[,] data, string savePath)
        {
            Excel.Application xlApp = new Excel.Application();

            xlApp.Workbooks.Add();

            Excel._Worksheet workSheet = (Excel._Worksheet)xlApp.ActiveSheet;

            for (int i= 0; i< data.GetLength(0); i++)
            {
                workSheet.Cells[i + 1, 1 ] = data[i, 0];
                workSheet.Cells[i + 1, 2 ] = data[i, 1];
            }

            workSheet.SaveAs(savePath + "\\shpark-book-dynamic.xlsx");
            xlApp.Quit();


        }
   static void Main(string[] args)
        {
            dynamic[] arr = new dynamic[] {new Duck(), new Mallard(), new Robot()};

            foreach(dynamic duck in arr)
            {
                Console.WriteLine(duck.GetType());
                duck.Walk();
                duck.Swim();
                duck.Quack();

                Console.WriteLine();
            }



            string savePath = System.IO.Directory.GetCurrentDirectory();
            string[,] array = new string[,]
            {
                {"asotnehusnaoheu", "2333"},
                {"asotnehusnaoheu", "2333"},
                {"asotnehusnaoheu", "2333"},
                {"asotnehusnaoheu", "2333"},
                {"asotnehusnaoheu", "2333"}
            };

            Console.WriteLine("Creating Excel document in old way...");
            
            // COMInterop com = new COMInterop();
            // COMInterop.OldWay(array, savePath);
            COMInterop.NewWay(array, savePath);
            


        }
    }
}
