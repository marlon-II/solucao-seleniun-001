using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace ConsoleSelenium.Script
{
    public class PrimeiroScript
    {
        public static void Automatizar_Envio_texto_ComSucesso()
        {
            IWebDriver driver = new EdgeDriver();
            
            driver.Navigate().GoToUrl("https://www.selenium.dev/selenium/web/web-form.html");

            var titulo = driver.Title;
            Console.WriteLine(titulo);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            var textoBox = driver.FindElement(By.Name("my-text"));
            textoBox.SendKeys("Marlon Bartoli");

            var subimitButton = driver.FindElement(By.TagName("button"));
            subimitButton.Click();
            
            
            Console.ReadLine();
            driver.Quit();
        }
    }
}