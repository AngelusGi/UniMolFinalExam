﻿using CsvHelper;

using System;
using System.Globalization;
using System.IO;
using System.Linq;

namespace CsvManager
{
    public class CsvTools
    {
        /// <summary>
        /// questa classe fornisce due metodi
        /// il primo per la lettura e l'esplorazione di un file
        /// il secondo per fare il merge e l'export di più file all'interno della path
        /// </summary>

        private static readonly string basePath = @"%USERPROFILE%\GitHub\UniMolFinalExam\Dataset";


        public static void OpenExploreCSV(string csvPath)
        {

            Console.WriteLine(csvPath);

            using var reader = new StreamReader(csvPath);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

            var records = csv.GetRecords<CsvModel>();

            Console.WriteLine($"numero di elementi -> {records.ToList().Count}");

        }

        public static string MergeExportCSV(string inputFolder = "Final\\", string outputFileName = "Final_Dataset", string fileExtension = "csv")
        {
            var csvPath = Environment.ExpandEnvironmentVariables(basePath);
            string sourceFolder = @$"{csvPath}\{inputFolder}";

            string destinationFile = @$"{csvPath}\{outputFileName}.{fileExtension}";

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

            Console.WriteLine($"{nameof(sourceFolder)}: {sourceFolder}\n {nameof(destinationFile)}: {destinationFile}");

            return destinationFile;
        }



    }
}
