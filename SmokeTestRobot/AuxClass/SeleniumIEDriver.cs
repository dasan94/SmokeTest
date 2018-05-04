using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Remote;

namespace SmokeTestRobot.AuxClass {
    public class SeleniumIEDriver {

        public static string WebTest(AuxClass.Configuration configObject) {

            int reTrayLimit = 1000;
            string ret = string.Empty;
            IWebDriver driver = null;
            string parentWindowHandler = string.Empty;

            try {
                InternetExplorerOptions op = new InternetExplorerOptions();
                op.IgnoreZoomLevel = true;
                op.IntroduceInstabilityByIgnoringProtectedModeSettings = true;

                InternetExplorerDriverService service = InternetExplorerDriverService.CreateDefaultService();
                service.SuppressInitialDiagnosticInformation = true;
                service.HideCommandPromptWindow = true;
                service.LibraryExtractionPath = General.GetDirectoryPath();

                driver = new InternetExplorerDriver(service, op);
                driver.Navigate().GoToUrl(configObject.driverUrl);

                parentWindowHandler = driver.CurrentWindowHandle; // Store parent window

                for (int j = 0; j < int.Parse(configObject.iterationCount); j++) {
                    foreach(Step s in configObject.stepsList) {
                        if(s.stepStatus == "1") {
                            switch(s.objectType.Trim().ToLower()) {
                                case "element":
                                    #region Case Element
                                    IWebElement element = null;
                                    #region FindElement
                                    try {
                                        element = driver.FindElement(By.Name(s.objectName.Trim()));
                                    } catch(Exception) {
                                        try {
                                            element = driver.FindElement(By.Id(s.objectName.Trim()));
                                        } catch(Exception) {
                                            try {
                                                element = driver.FindElement(By.ClassName(s.objectName.Trim()));
                                            } catch(Exception) {
                                                try {
                                                    element = driver.FindElement(By.LinkText(s.objectName.Trim()));
                                                } catch(Exception) {
                                                    try {
                                                        element = driver.FindElement(By.TagName(s.objectName.Trim()));
                                                    } catch(Exception) {
                                                        try {
                                                            element = driver.FindElement(By.PartialLinkText(s.objectName.Trim()));
                                                        } catch(Exception) {
                                                            try {
                                                                element = driver.FindElement(By.CssSelector(s.objectName.Trim()));
                                                            } catch(Exception) {
                                                                try {
                                                                    element = driver.FindElement(By.XPath("//span[contains(text(),'" + s.objectName.Trim() + "')]"));                                                                    
                                                                } catch (Exception) {
                                                                    try {
                                                                        element = driver.FindElement(By.XPath("//td[contains(text(),'" + s.objectName.Trim() + "')]"));
                                                                    } catch (Exception) {
                                                                        try {
                                                                            element = driver.FindElement(By.XPath("//a[contains(text(),'" + s.objectName.Trim() + "')]"));
                                                                        } catch (Exception ex) {
                                                                            string msg = "Step: " + s.stepName + ". " + s.objectName.Trim() + " no encontrado.";
                                                                            throw new Exception(msg, ex);
                                                                        }
                                                                    }                                                                    
                                                                }                                                                
                                                            }

                                                        }
                                                    }

                                                }
                                            }
                                        }
                                    }
                                    #endregion
                                    
                                    if(element != null) {
                                        #region Perform Action
                                        for (int k = 0; k < int.Parse(s.stepIterationCount); k++) {
                                            switch (s.actionName.Trim().ToLower()) {
                                                case "clear":
                                                    element.Clear();
                                                    break;
                                                case "click":
                                                    element.Click();                                                    
                                                    break;
                                                case "sendkeyboardkey":
                                                    string keyToSend = string.Empty;
                                                    keyToSend = AuxClass.General.KeyList()[s.actionParam.Trim().ToLower()];
                                                    if (keyToSend.Trim().Length > 0) {
                                                        element.SendKeys(keyToSend);
                                                    }
                                                    break;
                                                case "sendkeys":
                                                    if (s.actionParam != null && s.actionParam.Trim().Length > 0) {
                                                        element.SendKeys(s.actionParam.Trim());
                                                    }
                                                    break;
                                                case "submit":
                                                    element.Submit();
                                                    break;                                                
                                            }
                                        }                                        
                                        #endregion
                                    }
                                    #endregion
                                    break;
                                case "program":
                                    #region Case Program
                                    for (int k = 0; k < int.Parse(s.stepIterationCount); k++) {
                                        switch (s.actionName.Trim().ToLower()) {
                                            case "switchalert":
                                                if (s.actionParam != null && s.actionParam.Trim().Length > 0) {
                                                    switch (s.actionParam.Trim().ToLower()) {
                                                        case "dismiss":
                                                            driver.SwitchTo().Alert().Dismiss();
                                                            break;
                                                        case "accept":
                                                            driver.SwitchTo().Alert().Accept();
                                                            break;
                                                    }
                                                }
                                                break;
                                            case "switchchildwindows":

                                                string subWindowHandler = string.Empty;
                                                int reTray = 0;
                                                do {
                                                    reTray++;
                                                    var handles = driver.WindowHandles;
                                                    foreach (string a in handles) {
                                                        subWindowHandler = a;
                                                        if (subWindowHandler != parentWindowHandler) {
                                                            driver.SwitchTo().Window(subWindowHandler);
                                                            if (s.actionParam != null && s.actionParam.Trim().Length > 0) {
                                                                switch (s.actionParam.Trim().ToLower()) {
                                                                    case "close":
                                                                        driver.Close();
                                                                        driver.SwitchTo().Window(parentWindowHandler);
                                                                        reTray = reTrayLimit * 2;
                                                                        break;

                                                                }
                                                            }
                                                        }
                                                    }
                                                } while (driver.WindowHandles.Count == 1 && reTray <= reTrayLimit);                                                
                                                
                                                break;

                                            case "switchparentwindow":
                                                driver.SwitchTo().Window(parentWindowHandler);
                                                break;

                                            case "wait":
                                                int d = 0;
                                                int.TryParse(s.actionParam.Trim().ToLower(), out d);
                                                if(d > 0) {
                                                    System.Threading.Thread.Sleep((d * 1000));
                                                }                                                
                                                break;
                                        }
                                    }
                                    #endregion
                                    break;
                            }
                        }                        
                    }
                }
                
            } catch(Exception e) {
                ret = "SeleniumIEDriver.WebTest" + Environment.NewLine;
                ret += "Ex: " + e.Message + Environment.NewLine;
                if(e.InnerException != null) {
                    ret += "InEx: " + e.InnerException.Message + Environment.NewLine;
                }                
                //ret += "StkTr: " + e.StackTrace;
            } finally {
                if(driver != null) {
                    driver.Quit();
                    driver.Dispose();
                }                
            }
            return ret;
        }
    }
}
