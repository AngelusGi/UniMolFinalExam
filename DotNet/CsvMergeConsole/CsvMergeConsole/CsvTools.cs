using ConsoleApp1;

using CsvHelper;

using System;
using System.Globalization;
using System.IO;
using System.Linq;

namespace MergeConsole
{
    class CsvTools
    {

        private static readonly string basePath = @"%USERPROFILE%\GitHub\UniMolFinalExam\Dataset";
        

        public static void OpenExploreCSV(string csvPath)
        { 

            Console.WriteLine(csvPath);

            using var reader = new StreamReader(csvPath);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

            var records = csv.GetRecords<CsvModel>();

            //foreach (var record in records)
            //{
            //    Console.WriteLine(record.GpsTime);
            //}

            Console.WriteLine($"numero di elementi -> {records.ToList().Count}");

        }

        public static string MergeExportCSV()
        {
            var csvPath = Environment.ExpandEnvironmentVariables(basePath);
            string sourceFolder = @$"{csvPath}\Final\";

            string destinationFile = @$"{csvPath}\Final_Combined_Dataset.csv";

            // Specify wildcard search to match CSV files that will be combined
            string[] filePaths = Directory.GetFiles(sourceFolder, "*.csv");
            StreamWriter fileDest = new StreamWriter(destinationFile, true);

            int i;
            for (i = 0; i < filePaths.Length; i++)
            {
                string file = filePaths[i];

                string[] lines = File.ReadAllLines(file);

                if (i > 0)
                {
                    lines = lines.Skip(1).ToArray(); // Skip header row for all but first file
                }

                foreach (string line in lines)
                {
                    fileDest.WriteLine(line);
                }
            }

            fileDest.Close();

            return destinationFile;
        }



    }
}
