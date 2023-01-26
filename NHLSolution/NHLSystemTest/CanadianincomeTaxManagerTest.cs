using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHLSystemTest
{
    [TestClass]
    public class CanadianincomeTaxManagerTest
    {
        [TestMethod]
        [DataRow(@"..\..\..\data\CanadianPersonalIncomeTaxRates.csv", 439)]
        public void LoadFromCsvFile_RowCount_CorrectCount(string csvFilePath, int expectedCount)
        {
            //arrange - create an object to test
            ////CanadianincomeTaxManager dataManager1= new CanadianincomeTaxManager();
            var dataManager = new CanadianincomeTaxManager();
            //act - perform some tasks with the object
            //List<string> allLinesFromFile = dataManager.LoadFromCsvFile(@"C:\\Users\\zbylhouwer1\\Downloads\CanadianPersonalincomeTaxRates.csv");
            List<string> allLinesFromFile = dataManager.LoadFromCsvFile(csvFilePath);
            //assert - call an assert method
            //verify that there are 440 records
            Assert.AreEqual(expectedCount, allLinesFromFile.Count);
        }

        [TestMethod]
        [DataRow(@"..\..\..\data\CanadianPersonalIncomeTaxRates.csv", 439)]
        public void ConvertToCanadianIncomeTax_CorrectConversion_ExpectedResult(string csvFilePath, int expectedCount)
        {
            var dataManager = new CanadianincomeTaxManager();
            List<string> allLinesFromFile = dataManager.LoadFromCsvFile(csvFilePath);
            List<CanadianIncomeTaxData> incomeTaxDatas = dataManager.ConvertToCanadianIncometax(allLinesFromFile);

            Assert.AreEqual(expectedCount, incomeTaxDatas.Count);
            int firstIndex = 0;
            int lastIndex = incomeTaxDatas.Count - 1;
            Assert.AreEqual("CAN", incomeTaxDatas[firstIndex].RegionAbbreviation);
            Assert.AreEqual(2023, incomeTaxDatas[firstIndex].taxYear);
            Assert.AreEqual("NU", incomeTaxDatas[lastIndex].RegionAbbreviation);
            Assert.AreEqual(2015, incomeTaxDatas[lastIndex].taxYear);
        }
        
    }
}
