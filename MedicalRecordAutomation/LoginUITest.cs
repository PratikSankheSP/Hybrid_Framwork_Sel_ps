using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThomsonReuters.MedicalRecordAutomation
{
    public class LoginUITest

    {
        [Test]
        public void TitleTest()
        {
            IWebDriver driver=new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(20);
            

            driver.Navigate().GoToUrl("https://demo.openemr.io/b/openemr");

            string actualTitle = driver.Title;
            Assert.That(actualTitle, Is.EqualTo("OpenEMR Login"));


        }

        [Test]
        public void ApplnDescriptionTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);


            driver.Navigate().GoToUrl("https://demo.openemr.io/b/openemr");

            string actualdescription = driver.FindElement(By.XPath("//p[contains(text(),'open-source Electronic Health')]")).Text;

            Assert.That(actualdescription, Is.EqualTo("The most popular open-source Electronic Health Record and Medical Practice Management solution."));


        }

    }
}
