using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace SmokeTestRobot.Generics {
    public partial class frmMain : Form {
        //private int childFormNumber = 0;
        private AuxClass.Configuration objConfiguration = null;
        private string confFilePath = string.Empty;
        private string errMsg = string.Empty;
        private Stopwatch stopWatch = new Stopwatch();
        private int testCount = 0;

        public frmMain() {
            InitializeComponent();
            toolStripStatusLabelTestCount.Text = "Test Count: 0 ";
        }
                
        #region Not Used
        private void ShowNewForm(object sender, EventArgs e) {
            //Form childForm = new Form();
            //childForm.MdiParent = this;
            //childForm.Text = "Window " + childFormNumber++;
            //childForm.Show();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e) {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if(saveFileDialog.ShowDialog(this) == DialogResult.OK) {
                string FileName = saveFileDialog.FileName;
            }
        }
        private void ExitToolsStripMenuItem_Click( object sender, EventArgs e ) {
            this.Close();
        }

        private void CutToolStripMenuItem_Click( object sender, EventArgs e ) {
        }

        private void CopyToolStripMenuItem_Click( object sender, EventArgs e ) {
        }

        private void PasteToolStripMenuItem_Click( object sender, EventArgs e ) {
        }

        private void ToolBarToolStripMenuItem_Click( object sender, EventArgs e ) {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click( object sender, EventArgs e ) {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click( object sender, EventArgs e ) {
            LayoutMdi( MdiLayout.Cascade );
        }

        private void TileVerticalToolStripMenuItem_Click( object sender, EventArgs e ) {
            LayoutMdi( MdiLayout.TileVertical );
        }

        private void TileHorizontalToolStripMenuItem_Click( object sender, EventArgs e ) {
            LayoutMdi( MdiLayout.TileHorizontal );
        }

        private void ArrangeIconsToolStripMenuItem_Click( object sender, EventArgs e ) {
            LayoutMdi( MdiLayout.ArrangeIcons );
        }

        private void CloseAllToolStripMenuItem_Click( object sender, EventArgs e ) {
            foreach ( Form childForm in MdiChildren ) {
                childForm.Close();
            }
        }

        private void iFDsBNCRToolStripMenuItem_Click( object sender, EventArgs e ) {
            openBNCR();
        }

        

        private void newBNCR_Click( object sender, EventArgs e ) {
            openBNCR();
        }

        

        private void openBNCR() {

            if ( !isFormAlreadyOpen( "IFDs Para el BNCR" ) ) {
               
            }
        }

        private bool isFormAlreadyOpen(string windowTitle) {
            bool IsOpen = false;

            foreach ( Form f in Application.OpenForms ) {
                if ( f.Text == windowTitle ) {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            return IsOpen;
        }

        

        private void contentsToolStripMenuItem_Click( object sender, EventArgs e ) {
            About.AboutBox childForm = new About.AboutBox();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void ShowHelp() {
            //string filePath = Directory.GetCurrentDirectory() + "\\IFD Helper.chm";

            //try {
            //    //Check if already exists before making
            //    if ( !File.Exists( filePath ) ) {
            //        var data = Properties.Resources.IFD_Helper;
            //        using ( var stream = new FileStream( "IFD Helper.chm", FileMode.Create ) ) {
            //            stream.Write( data, 0, data.Length );
            //            stream.Flush();
            //        }
            //    }
            //} catch {
            //    MessageBox.Show( "Error creando la ayuda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            //}
            //Help.ShowHelp( this, filePath, HelpNavigator.Find, "IFD" );
        }
        #endregion

        private void newBCC_Click(object sender, EventArgs e) {
            //CallOpenTest(sender, e);
            OpenTestAsync(sender, e);
        }

        private void OpenFile(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            #region GetInitialDirectory
            string initialDirectory = AuxClass.General.GetDirectoryPath() + "\\ConfigFiles\\";
            if(!System.IO.Directory.Exists(initialDirectory)) {
                initialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            }
            #endregion
            openFileDialog.InitialDirectory = initialDirectory;
            openFileDialog.Filter = "JSon File (*.json)|*.json|All Files (*.*)|*.*";
            if(openFileDialog.ShowDialog(this) == DialogResult.OK) {
                confFilePath = openFileDialog.FileName;
            }
        }

        private void webTestToolStripMenuItem_Click(object sender, EventArgs e) {
            //CallOpenTest(sender, e);
            //OpenTestAsync(sender, e);
            OpenFrmConfSeleniumWebTest(sender, e);
        }

        private void OpenFrmConfSeleniumWebTest(object sender, EventArgs e) {
            Configuration.frmConfSeleniumWebTest childForm = new Configuration.frmConfSeleniumWebTest();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void OpenTestAsync(object sender, EventArgs e) {
            errMsg = string.Empty;
            confFilePath = string.Empty;
            objConfiguration = null;
            OpenFile(sender, e);

            if(confFilePath.Trim().Length > 0) {
                BackgroundWorker bg = new BackgroundWorker();
                bg.DoWork += new DoWorkEventHandler(OpenTest);
                bg.RunWorkerCompleted += new RunWorkerCompletedEventHandler(TestCompleted);
                stopWatch.Start();
                testCount++;
                toolStripStatusLabelTestCount.Text = "Test Count: "+ testCount.ToString();
                bg.RunWorkerAsync();
            }
        }

        private void CallOpenTest(object sender, EventArgs e) {
            errMsg = string.Empty;
            confFilePath = string.Empty;
            objConfiguration = null;
            OpenFile(sender, e);
            OpenTest(sender, e);
        }

        private void OpenTest(object sender, EventArgs e) {
            if(confFilePath.Trim().Length > 0) {
                try {
                    objConfiguration = AuxClass.General.GetConfigurationFromJsonFile(confFilePath);
                    if(objConfiguration != null) {
                        if(AuxClass.Validations.ConfigurationFileValidation(objConfiguration, out errMsg)) {
                            if(!CallTest(objConfiguration)) {
                                throw new Exception(errMsg);
                            }
                        } else {
                            throw new Exception(errMsg);
                        }
                    } 
                } catch(Exception ex) {
                    MessageBox.Show(ex.Message, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }        

        private bool CallTest(AuxClass.Configuration configObject) {
            bool ret = false;

            switch(configObject.driver.ToLower().Trim()) {
                case "selenium":
                    ret = CallSelenium(configObject);                   
                    break;
                default:
                    throw new Exception("Driver " + configObject.driver + " Not Implemented");                    
            }
            return ret;
        }

        private bool CallSelenium(AuxClass.Configuration configObject) {
            bool ret = false;

            switch(configObject.driverType.Trim().ToLower()) {
                case "web":
                    switch(configObject.driverName.Trim().ToLower()) {
                        case "internetexplorerdriver":
                            errMsg = AuxClass.SeleniumIEDriver.WebTest(configObject);
                            ret = errMsg.Trim().Length == 0 ? true : false;
                            break;
                        default:
                            throw new Exception("DriverName " + configObject.driverName + " Not Implemented");
                    }

                    break;
                default:
                    throw new Exception("DriverType " + configObject.driverType + " Not Implemented");
            }
            return ret;
        }

        private void winFormsAppTestToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Not Implemented", "Information.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TestCompleted(object sender, RunWorkerCompletedEventArgs e) {

            try {
                TimeSpan ts = stopWatch.Elapsed;
                // Format and display the TimeSpan value.
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
                MessageBox.Show("RunTime: " + elapsedTime, "Test Completed.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch(Exception) { }            
        }

    }
}
