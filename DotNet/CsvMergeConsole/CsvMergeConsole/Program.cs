using CsvManager;

using System;

namespace MergeConsole
{
    class Program
    {

        private static void VerifyInput(string inputFolder, string outputFile, string extension)
        {
            try
            {
                string csvPath;


                if (string.IsNullOrEmpty(inputFolder) && string.IsNullOrEmpty(outputFile) && string.IsNullOrEmpty(extension))
                {
                    csvPath = CsvTools.MergeExportCSV();

                }
                else if (string.IsNullOrEmpty(inputFolder) && string.IsNullOrEmpty(outputFile))
                {
                    csvPath = CsvTools.MergeExportCSV(extension);

                }
                else if (string.IsNullOrEmpty(inputFolder) && string.IsNullOrEmpty(extension))
                {
                    csvPath = CsvTools.MergeExportCSV(outputFile);

                }
                else if (string.IsNullOrEmpty(outputFile) && string.IsNullOrEmpty(extension))
                {
                    csvPath = CsvTools.MergeExportCSV(inputFolder);

                }
                else if (string.IsNullOrEmpty(outputFile))
                {
                    csvPath = CsvTools.MergeExportCSV(extension, inputFolder);

                }
                else if (string.IsNullOrEmpty(extension))
                {
                    csvPath = CsvTools.MergeExportCSV(outputFile, inputFolder);

                }
                else if (string.IsNullOrEmpty(inputFolder))
                {
                    csvPath = CsvTools.MergeExportCSV(outputFile, extension);

                }
                else
                {
                    csvPath = CsvTools.MergeExportCSV(inputFolder, outputFile, extension);
                }

                CsvTools.OpenExploreCSV(csvPath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        static void Main()
        {

            Console.WriteLine("Inserire il nome della cartella di input (se vuota verranno inseriti i valori di default): ");
            var inputFolder = Console.ReadLine();

            Console.WriteLine("Inserire il nome del file di output (se vuota verranno inseriti i valori di default): ");
            var outputFile = Console.ReadLine();

            Console.WriteLine("Inserire il nome dell'estensione del file di output (se vuota verranno inseriti i valori di default): ");
            var extension = Console.ReadLine();

            VerifyInput(inputFolder, outputFile, extension);
            

        }
    }
}
