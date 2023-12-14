using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ReadingAndWritingToAnCSVFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Ages = "C:\\Users\\User\\source\\repos\\ReadingAndWritingToAnCSVFile\\ReadingAndWritingToAnCSVFile\\Sample_Data_Age.csv";
            string AgesTo = "C:\\Users\\User\\source\\repos\\ReadingAndWritingToAnCSVFile\\ReadingAndWritingToAnCSVFile\\Numbers.csv";

            string[] lines = File.ReadAllLines(Ages);

            foreach (string line in lines)
            {
                string[] values = line.Split(',');

                foreach (string value in values)
                {
                    if (double.TryParse(value, out double numericValue) && numericValue > 65)
                    {
                        File.AppendAllText(AgesTo, line + Environment.NewLine);
                    }
                }
            }
        }
    }
}