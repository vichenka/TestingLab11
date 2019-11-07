using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        ChromeDriver chromeDriver;
        [TestMethod]
        public void TestMethod1()
        {
            chromeDriver = new ChromeDriver();
            chromeDriver.Navigate().GoToUrl("http://www.google.com/");
            chromeDriver.FindElement(By.XPath("//*[@id=\"tsf\"]/div[2]/div[1]/div[1]/div/div[2]/input")).SendKeys("iTechArt");
            chromeDriver.FindElement(By.XPath("//*[@id=\"tsf\"]/div[2]/div[1]/div[1]/div/div[2]/input")).SendKeys(Keys.Enter);
            Assert.IsTrue(chromeDriver.FindElement(By.XPath("//*[@id=\"rso\"]/div[1]")).Text.Contains("iTechArt"));
            Assert.IsTrue(chromeDriver.Title.Contains("iTechArt"));
        }
        
    }
}
