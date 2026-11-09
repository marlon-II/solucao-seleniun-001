using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace ConsoleSelenium.Tests.test
{
    [TestClass]
    public class PrimeiroScriptTest
    {
        [TestMethod]

        public void TestAutomacao_Envio_Texto_ComSucesso()
        {
            IWebDriver driver = new EdgeDriver();
            
            driver.Navigate().GoToUrl("https://www.selenium.dev/selenium/web/web-form.html");

            var titulo = driver.Title;
            Assert.AreEqual("Web form", titulo);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            var textoBox = driver.FindElement(By.Name("my-text"));
            textoBox.SendKeys("Marlon Bartoli");

            var subimitButton = driver.FindElement(By.TagName("button"));
            subimitButton.Click();

            var mensageSucesso = driver.FindElement(By.Id("message"));
            Assert.AreEqual("Received!", mensageSucesso.Text);
            
            
            
            driver.Quit();
        }
    }
}