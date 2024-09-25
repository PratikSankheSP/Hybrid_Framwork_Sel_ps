using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThomsonReuters.MedicalRecordAutomation.Base;

namespace MedicalRecordAutomation
{
    public class LoginValidations:AutomationWrapper
    {
        [Test]
        [TestCase ("admin","pass","OpenEmr")]

        [TestCase("accountant", "accountant", "OpenEmr")]


        public void ValLogin(string un,string pass, string expectedValue)
        {
            driver.FindElement(By.Id("authUser")).SendKeys(un);

            driver.FindElement(By.Id("clearPass")).SendKeys(pass);

            driver.FindElement(By.XPath("//button[@type='submit']")).Click();

            string title_log = driver.Title;


            Assert.That(title_log, Is.EqualTo(expectedValue));
        }

        [Test]
        [TestCase ("adm","pas","Invalid username or password")]
        public void InValLogin(string un, string pass, string expectedValue)
        {
            driver.FindElement(By.Id("authUser")).SendKeys(un);

            driver.FindElement(By.Id("clearPass")).SendKeys(pass);

            driver.FindElement(By.XPath("//button[@type='submit']")).Click();

            string actual_Error = driver.FindElement(By.XPath("//p[contains(text(),'Invalid username or password')]")).Text;

            Assert.That(actual_Error, Is.EqualTo(expectedValue));
        }
    }
}
