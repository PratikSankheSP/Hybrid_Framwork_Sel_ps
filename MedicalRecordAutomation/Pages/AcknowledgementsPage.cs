using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThomsonReuters.MedicalRecordAutomation.Pages
{
    public class AcknowledgementsPage
    {
        private IWebDriver driver;

        public AcknowledgementsPage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
