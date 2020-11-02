
using MergeConsole;

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            try
            {
                var csvPath = CsvTools.MergeExportCSV();

                CsvTools.OpenExploreCSV(csvPath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
