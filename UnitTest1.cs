using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;

namespace seleniumtest
{
    [TestClass]
    public class Seleniumtest
    {
        private TestContext testContextInstance;
        private IWebDriver driver;
        private string appURL;
       [TestMethod]
    [TestCategory("Chrome")]
    public void TheBingSearchTest()
    {
      driver.Navigate().GoToUrl(appURL + "/");
     
      
    }

    /// <summary>
    ///Gets or sets the test context which provides
    ///information about and functionality for the current test run.
    ///</summary>
    public TestContext TestContext
    {
      get
      {



        return testContextInstance;
      }
      set
      {
        testContextInstance = value;
      }
    }

    [TestInitialize()]
    public void SetupTest()
    {
      appURL = "https://www.google.com/";

      string browser = "Chrome";
      switch(browser)
      {
        case "Chrome":
          driver = new ChromeDriver();
          break;
        case "Firefox":
          driver = new FirefoxDriver();
          break;
        case "IE":
          driver = new InternetExplorerDriver();
          break;
        default:
          driver = new ChromeDriver();
          break;
      }

    }

    [TestCleanup()]
    public void MyTestCleanup()
    {
      driver.Quit();
    }
    }
}
