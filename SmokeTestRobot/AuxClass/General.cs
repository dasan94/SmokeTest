using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace SmokeTestRobot.AuxClass {
    public class General {

        public enum CallerOption {
            BCC,
            BNCR,
        }

        public static bool[] initializeBoolArr( bool[] Arr ) {
            for ( int i = 0 ; i < Arr.Length ; i++ ) {
                Arr[i] = false;
            }
            return Arr;
        }

        public static bool IsAlphaNumeric( String strToCheck ) {
            Regex objAlphaNumericPattern = new Regex( "[^a-zA-Z0-9_]" );
            return !objAlphaNumericPattern.IsMatch( strToCheck );
        }

        public static byte[] StrToByteArray( string str ) {
            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
            return encoding.GetBytes( str );
        }

        public static bool SaveIfdToFile( string ifdDest ) {

            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            bool ret = false;

            saveFileDialog1.Filter = "Unisys Input Format Definition Files (*.ifd)|*.ifd|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 0;
            saveFileDialog1.RestoreDirectory = true;

            if ( saveFileDialog1.ShowDialog() == DialogResult.OK ) {
                if ( ( myStream = saveFileDialog1.OpenFile() ) != null ) {
                    //myStream.Write( Generics.StrToByteArray( this.tbIFDDest.Text ), 0, this.tbIFDDest.Text.Length );
                    myStream.Write( AuxClass.General.StrToByteArray( ifdDest ), 0, ifdDest.Length );
                    myStream.Close();
                    ret = true;
                }
            }
            return ret;
        }

        public static string GetDirectoryPath() {
            return System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        }

        public static Dictionary<string, string> KeyList() {
            var keys = new Dictionary<string, string>();
            keys.Add("f12", OpenQA.Selenium.Keys.F12);
            keys.Add("f4", OpenQA.Selenium.Keys.F4);
            keys.Add("enter", OpenQA.Selenium.Keys.Enter);
            keys.Add("arrowdown", OpenQA.Selenium.Keys.ArrowDown);
            keys.Add("space", OpenQA.Selenium.Keys.Space);
            keys.Add("tab", OpenQA.Selenium.Keys.Tab);
            return keys;
        }

        public static Configuration GetConfigurationFromJsonFile(string path) {
            Configuration ret = null;
            using(StreamReader r = new StreamReader(path)) {
                string json = r.ReadToEnd();
                ret = JsonConvert.DeserializeObject<AuxClass.Configuration>(json);
            }

            if(ret != null) {
                return ret;
            } else {
                throw new Exception("Archivo de configuracion no valido");
            }
        }

        public static AuxClass.Step DeserializeStep(string strObj) {
            AuxClass.Step objRet = null;
            try {
                objRet = JsonConvert.DeserializeObject<AuxClass.Step>(strObj);
            } catch (Exception) { }
            return objRet;
        }

        public static string SerializeObject(object conf) {
            string sRet = "[]";
            try {
                sRet = JsonConvert.SerializeObject(conf);
            } catch (Exception) { }
            
            return sRet;
        }
    }
}
