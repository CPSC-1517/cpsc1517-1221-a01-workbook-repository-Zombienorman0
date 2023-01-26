using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHLSystemClassLibrary
{
    public class CanadianincomeTaxManager
    {
        public List<CanadianIncomeTaxData> ConvertToCanadianIncometax(List<string> lines)
        {
            List<CanadianIncomeTaxData> dataList = new List<CanadianIncomeTaxData>();
            foreach (string currentLine in lines)
            {
                string[] tokens = currentLine.Split(',');
                CanadianIncomeTaxData data = new CanadianIncomeTaxData();
                data.RegionAbbreviation = tokens[0];
                data.RegionName = tokens[1];
                data.taxYear = int.Parse(tokens[2]);
                data.StartingIncome = decimal.Parse(tokens[4]);
                data.EndingIncome = decimal.Parse(tokens[5]);
                data.taxRate = double.Parse(tokens[6]);

                data.baseTaxAmount = decimal.Parse(tokens[7]);

                dataList.Add(data);

            }
            return dataList;
        }
        public List<string> LoadFromCsvFile(string csvFilePath)
        {
            List<string> allLines = new List<string>();
            // can use StreamReader or file class to read data from
            string[] lineArray = File.ReadAllLines(csvFilePath);
            return null;
        }
    }
}
