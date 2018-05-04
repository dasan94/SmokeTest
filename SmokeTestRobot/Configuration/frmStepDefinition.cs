using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmokeTestRobot.Configuration {
    public partial class frmStepDefinition : Form {

        private AuxClass.Step step = null;
        private int Index;
        DataGridView _dg;

        public frmStepDefinition(DataGridView dg, int idx) {
            InitializeComponent();
            Index = idx;
            step = new AuxClass.Step();
            _dg = dg;
        }

        private void frmStepDefinition_Load(object sender, EventArgs e) {
            this.ShowDialog();
        }
        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void stepType_TextChanged(object sender, EventArgs e) {
            this.stepAction.Items.Clear();
            this.stepNameType.Clear();
            this.label4.Text = "Action Parameter";
            if (this.stepType.Text == "Program") {                
                this.stepAction.Items.Add("Switchalert");
                this.stepAction.Items.Add("Switchchildwindows");
                this.stepAction.Items.Add("Switchparentwindow");
                this.stepAction.Items.Add("Wait");
                this.stepNameType.ReadOnly = true;
            } else {
                this.stepAction.Items.Add("Sendkeyboardkey");
                this.stepAction.Items.Add("Sendkeys");
                this.stepNameType.ReadOnly = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            AuxClass.Step s = new AuxClass.Step();
            s.objectType = stepType.Text;
            s.objectName = stepNameType.Text;
            s.actionName = stepAction.Text;
            if (stepActionParamText.Text != "") {
                s.actionParam = stepActionParamText.Text;
            } else {
                s.actionParam = stepActionParam.Text;
            }

            step = s;            
            _dg[4 ,Index].Value = AuxClass.General.SerializeObject(step);
            this.Close();
        }
        private void mostrarConfiguracion(AuxClass.Step s) {
            stepType.Text = s.objectType;
            stepNameType.Text = s.objectName;
            stepAction.Text = s.actionName;
            if (stepActionParamText.Text != null) {
                s.actionParam = stepActionParamText.Text;
            } else {
                s.actionParam = stepActionParam.Text;
            }
        }

        private void stepActionParam_SelectedIndexChanged(object sender, EventArgs e) {
           
        }

        private void stepAction_SelectedIndexChanged(object sender, EventArgs e) {
            this.stepActionParam.Items.Clear();
            this.label4.Text = "Action Parameter";
            this.stepActionParam.Visible = true;
            this.label4.Visible = true;
            if (this.stepAction.Text == "Switchalert") {
                this.stepActionParam.Items.Add("Accept");
                this.stepActionParam.Items.Add("Dismiss");
            } else if (this.stepAction.Text == "Switchchildwindows") {
                this.stepActionParam.Items.Add("Close");
            } else if (this.stepAction.Text == "Switchparentwindow") {
                this.stepActionParam.Visible = false;
                this.stepActionParamText.Visible = false;
                this.label4.Visible = false;
            } else if (this.stepAction.Text == "Sendkeyboardkey") {
                this.stepActionParam.Items.Add("F12");
                this.stepActionParam.Items.Add("Space");
                this.stepActionParam.Items.Add("Tab");
                this.stepActionParam.Items.Add("ArrowDown");
            } else if (this.stepAction.Text == "Sendkeys") {
                this.stepActionParam.Visible = false;
                this.stepActionParamText.ReadOnly = false;
                this.stepActionParamText.Visible = true;
                this.stepActionParam.Visible = false;
            } else {
                this.stepActionParam.Visible = false;
                this.stepActionParamText.ReadOnly = false;
                this.stepActionParamText.Visible = true;
                this.stepActionParam.Visible = false;
                this.label4.Text = "Waiting Time";
            }
        }
    }
}
