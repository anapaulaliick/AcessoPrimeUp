using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class AcessarPrimeUpTest {
  private IWebDriver driver;
  [SetUp]
  public void SetUp() {
    driver = new ChromeDriver();
  }
  [TearDown]
  protected void TearDown() {
    driver.Quit();
  }
  [Test]
  public void acessarPrimeUp() {
    driver.Navigate().GoToUrl("http://www.primeup.com.br/");
    driver.Manage().Window.Maximize();
    driver.FindElement(By.XPath("//span[contains(.,\'Vagas\')]")).Click();
  }
}
