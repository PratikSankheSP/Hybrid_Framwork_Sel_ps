using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThomsonReuters.MedicalRecordAutomation.Utilities
{
    public class DataSource
    {
        /// <summary>
        /// Test Data For ValidLoginTest
        /// </summary>
        /// <returns></returns>
        public static object[] ValLoginData()
        {
            //test case1
            String[] dataset1 = new string[3];
            dataset1[0] = "admin";
            dataset1[1] = "pass";
            dataset1[2] = "OpenEmr";

            //test case2
            String[] dataset2 = new string[3];
            dataset2[0] = "accountant";
            dataset2[1] = "accountant";
            dataset2[2] = "OpenEmr";

            object[] finalData = new object[2];
            finalData[0] = dataset1;
            finalData[1] = dataset2;

            return finalData;

        }

        public static object[] ValidLoginDataExcel()
        {
            object[] finalData = ExcelSource.GetSheetIntoObjectArray
            (@"C:\Users\6124596\OneDrive - Thomson Reuters Incorporated\iSquad\Selenium Training\Day1_SourceCodes\AutomationFrameworkSolution\MedicalRecordAutomation\TestData\OpenEmr_DataSet.xlsx", "ValidLoginTest");
             
            return finalData;
        }

        public static object[] InvalidLoginDataExcel()
        {
            object[] finalData = ExcelSource.GetSheetIntoObjectArray
            (@"C:\Users\6124596\OneDrive - Thomson Reuters Incorporated\iSquad\Selenium Training\Day1_SourceCodes\AutomationFrameworkSolution\MedicalRecordAutomation\TestData\OpenEmr_DataSet.xlsx", "InvalidLoginTest");

            return finalData;
        }

    }
}
