using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace PRG2782_Project_2026 // IMPORTANT: Change this to match your project's namespace!
{
    public static class SummaryService
    {
        public static string Calculate(string filePath)
        {
            List<Animal> animals = new List<Animal>();

            try
            {
                if (File.Exists(filePath))
                {
                    string[] lines = File.ReadAllLines(filePath);
                    foreach (string line in lines)
                    {
                        // Split by comma (assuming standard format). Skip malformed lines.
                        string[] parts = line.Split(',');
                        if (parts.Length == 6)
                        {
                            try
                            {
                                animals.Add(new Animal
                                {
                                    AnimalID = parts[0].Trim(),
                                    Name = parts[1].Trim(),
                                    Species = parts[2].Trim(),
                                    Age = int.Parse(parts[3].Trim()),
                                    RecoveryScore = int.Parse(parts[4].Trim()),
                                    Status = parts[5].Trim()
                                });
                            }
                            catch { /* Skip malformed records */ }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return FileErrorHelper.GetFriendlyErrorMessage(ex);
            }

            // Calculate values
            int total = animals.Count;
            double avgAge = total > 0 ? animals.Average(a => a.Age) : 0;
            double avgScore = total > 0 ? animals.Average(a => a.RecoveryScore) : 0;

            int critical = animals.Count(a => a.Status == "Critical");
            int serious = animals.Count(a => a.Status == "Serious");
            int stable = animals.Count(a => a.Status == "Stable");
            int recovering = animals.Count(a => a.Status == "Recovering");
            int releaseReady = animals.Count(a => a.Status == "Release-Ready");

            // Build the report string
            string report = "";
            report += "Summary Report\n";
            report += "==============\n";
            report += "Total animals".PadRight(26) + total + "\n";
            report += "Average age (years)".PadRight(26) + (total > 0 ? avgAge.ToString("F2", CultureInfo.InvariantCulture) : "N/A") + "\n";
            report += "Average recovery score".PadRight(26) + (total > 0 ? avgScore.ToString("F2", CultureInfo.InvariantCulture) : "N/A") + "\n";
            report += "Critical".PadRight(26) + critical + "\n";
            report += "Serious".PadRight(26) + serious + "\n";
            report += "Stable".PadRight(26) + stable + "\n";
            report += "Recovering".PadRight(26) + recovering + "\n";
            report += "Release-Ready".PadRight(26) + releaseReady + "\n";

            // Save to file
            try
            {
                File.WriteAllText("summary.txt", report);
            }
            catch (Exception ex)
            {
                return FileErrorHelper.GetFriendlyErrorMessage(ex) + " (Could not save summary.txt)";
            }

            return report; // Return the string so the UI can display it in labels
        }
    }
}