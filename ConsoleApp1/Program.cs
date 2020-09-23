using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ChromeOptions Options = new ChromeOptions();
            List<string> ls = new List<string>();
            ls.Add("enable-automation");
            Options.AddArguments("--disable-notifications");
            Options.AddUserProfilePreference("intl.accept_languages", "en-US");
            Options.AddExcludedArguments(ls);
            IWebDriver Driver = new ChromeDriver(Options);
            Driver.Navigate().GoToUrl("http://www.google.com");
            Driver.FindElement(By.Name("q")).SendKeys("Learn Automation"+ Keys.Return);            
        }
    }
}
