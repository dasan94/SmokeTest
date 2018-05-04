using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmokeTestRobot.AuxClass {
    public class Configuration {
        public string driver;
        public string driverType;
        public string driverName;
        public string driverUrl;
        public string iterationCount;
        public List<Step> stepsList;
    }
    public class Step {
        public string stepName;
        public string stepStatus;
        public string objectType;
        public string objectName;
        public string actionName;
        public string actionParam;
        public string stepIterationCount;
    }

    public static class Validations {
        public static bool ConfigurationFileValidation(AuxClass.Configuration configObject, out string errMsg) {
            bool ret = true;
            string s = string.Empty;
            errMsg = string.Empty;
            try {
                #region driver
                s = "driver ";
                if(configObject.driver == null || configObject.driver.Trim().Length == 0) {
                    throw new Exception();
                }
                #endregion
                #region driverName
                s = "driverName ";
                if(configObject.driverName == null || configObject.driverName.Trim().Length == 0) {
                    throw new Exception();
                }
                #endregion
                #region driverType
                s = "driverType ";
                if(configObject.driverType == null || configObject.driverType.Trim().Length == 0) {
                    throw new Exception();
                }
                #endregion
                #region driverUrl
                s = "driverUrl ";
                if(configObject.driverUrl == null || configObject.driverUrl.Trim().Length == 0) {
                    throw new Exception();
                }
                #endregion
                #region iterationCount
                s = "iterationCount ";                
                int a = 0;
                int.TryParse(configObject.iterationCount.Trim(), out a);
                configObject.iterationCount = (a == 0 ? (a + 1).ToString() : a.ToString());
                #endregion                
                #region stepList
                s = "stepsList ";
                if(configObject.stepsList == null) {
                    throw new Exception();
                }

                #region step
                for(int i = 0; i < configObject.stepsList.Count; i++) {
                    #region stepName
                    s = "stepsList(" + (i + 1).ToString() + ").stepName ";
                    if(configObject.stepsList[i].stepName == null || configObject.stepsList[i].stepName.Trim().Length == 0) {
                        throw new Exception();
                    }
                    #endregion
                    #region stepStatus
                    s = "stepsList(" + (i + 1).ToString() + ").stepStatus ";
                    a = 0;
                    int.TryParse(configObject.stepsList[i].stepStatus.Trim(), out a);
                    configObject.stepsList[i].stepStatus = (a > 1 || a < 0) ? "0" : a.ToString();
                    #endregion
                    #region objectType
                    s = "stepsList(" + (i + 1).ToString() + ").objectType ";
                    if(configObject.stepsList[i].objectType == null || configObject.stepsList[i].objectType.Trim().Length == 0) {
                        throw new Exception();
                    } else {
                        switch(configObject.stepsList[i].objectType.Trim().ToLower()) {
                            case "element":
                            case "program":
                                break;
                            default:
                                throw new Exception();
                        }
                    }
                    #endregion
                    #region actionName
                    s = "StepName: " + configObject.stepsList[i].stepName + Environment.NewLine + "stepsList(" + (i + 1).ToString() + ").actionName ";
                    if(configObject.stepsList[i].actionName == null || configObject.stepsList[i].actionName.Trim().Length == 0) {
                        throw new Exception();
                    } else {
                        switch(configObject.stepsList[i].actionName.Trim().ToLower()) {
                            case "clear":
                            case "click":
                            case "sendkeyboardkey":
                            case "sendkeys":
                            case "submit":
                            case "switchalert":
                            case "switchchildwindows":
                            case "switchparentwindow":
                            case "wait":
                                break;
                            default:
                                throw new Exception();
                        }
                    }
                    #endregion
                    #region stepIterationCount
                    s = "stepIterationCount ";
                    if (configObject.stepsList[i].stepIterationCount == null) {
                        configObject.stepsList[i].stepIterationCount = "1";
                    } else {
                        a = 0;
                        int.TryParse(configObject.stepsList[i].stepIterationCount.Trim(), out a);
                        configObject.stepsList[i].stepIterationCount = ((a < 0) ? "0" : a.ToString());
                    }                        
                    #endregion
                }
                #endregion
                #endregion
            } catch(Exception) {
                errMsg = "Archivo de configuracion no valido." + Environment.NewLine + "Parametro: " + s;
                ret = false;
            }
            return ret;
        }
    }
}
