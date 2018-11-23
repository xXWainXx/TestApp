using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace TestApp.Tests
{
    public class SimpleTest
    {
        IWebDriver driver;

        [Fact]
        public void SimpleTestMethod()
        {
            driver = new ChromeDriver(@"/home/alex/Documents/Projects/TestApp/Tests");
            driver.Navigate().GoToUrl(@"http://localhost:5000");
            Thread.Sleep(5000);
            driver.Quit();
        }
    }
}