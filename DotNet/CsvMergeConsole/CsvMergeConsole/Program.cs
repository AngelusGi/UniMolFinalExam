using CsvManager;

using System;

namespace MergeConsole
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
