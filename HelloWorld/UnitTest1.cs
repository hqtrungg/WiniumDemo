using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Winium;

namespace HelloWorld
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WriteHelloWorldOnNotepad()
        {
            DesktopOptions options = new DesktopOptions();
            options.ApplicationPath = @"C:\Windows\System32\notepad.exe";//link to nodepad.exe path

            WiniumDriver driver = new WiniumDriver(@"C:\Users\Ch4initus\Desktop", options);//define a new WiniumDriver, first param link to WiniumDesktopDriver downloaded before
            driver.FindElementByClassName("Edit").SendKeys("Hello World!!!");//open inspect.exe in Window Kits to get the Classname of notepad, SendKeys is used for writing in notepad

            
        }
    }
}
