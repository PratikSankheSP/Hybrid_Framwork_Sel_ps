using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalRecordAutomation
{
    public class ZClassDemo
    { 
        /// <summary>
    /// Logic Building class for ExcelSource.cs class Refere it!!
    /// </summary>
        [Test]
       public void ReadExcelTest()
        {
            XLWorkbook book= new XLWorkbook(@"C:\Users\6124596\OneDrive - Thomson Reuters Incorporated\iSquad\Selenium Training\Day1_SourceCodes\AutomationFrameworkSolution\MedicalRecordAutomation\TestData\OpenEmr_DataSet.xlsx");
            IXLWorksheet sheet = book.Worksheet("ValidLoginTest");
            IXLRange range= sheet.RangeUsed();

            for (int r = 1; r <= 3; r++)
            {
                for (int c = 1; c <= 3; c++)
                {
                    string value = range.Cell(r, c).GetString();
                    Console.WriteLine(value);
                }
            }
            IXLWorksheet sheet1 = book.Worksheet("InvalidLoginTest");
            IXLRange range1 = sheet.RangeUsed();

            for (int r = 1; r <= 3; r++)
            {
                for (int c = 1; c <= 3; c++)
                {
                    string value = range.Cell(r, c).GetString();
                    Console.WriteLine(value);
                }
            }




            book.Dispose();


        }

    }
}
