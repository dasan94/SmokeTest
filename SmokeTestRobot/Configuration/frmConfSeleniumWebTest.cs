using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmokeTestRobot.Configuration {
    public partial class frmConfSeleniumWebTest : Form {

        public AuxClass.Configuration c = new AuxClass.Configuration();
        
        public frmConfSeleniumWebTest() {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void dgvSteps_CellClick(object sender, DataGridViewCellEventArgs e) {
            // Ignore clicks that are not on button cells. 
            if(e.RowIndex < 0 || e.ColumnIndex != this.dgvSteps.Columns[3].Index)
                return;

            if(this.dgvSteps[0, e.RowIndex].Value != null && this.dgvSteps[1, e.RowIndex].Value != null) {
                if (this.dgvSteps[4, 0].Value != null) {
                    MessageBox.Show(this.dgvSteps[4, 0].Value.ToString());
                }
                Configuration.frmStepDefinition childForm = new Configuration.frmStepDefinition(this.dgvSteps, e.RowIndex);
                childForm.MdiParent = this.ParentForm;
                childForm.Show();
            } else {
                MessageBox.Show("Debe primero definir nombre y tipo para el mensaje " + (e.RowIndex + 1).ToString(), "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.dgvSteps.Rows[e.RowIndex].Selected = true;
            }

        }

        private void dgvSteps_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            
        }

        private void btnSave_Click(object sender, EventArgs e) {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text files (*.json)|*.json|All files (*.*)|*.*";
            c.driver = cbDriver.Text;
            c.driverName = cbDriverName.Text;
            c.driverType = cbDriverType.Text;
            c.driverUrl = tbUrl.Text;
            c.iterationCount = tbIteractionCount.Text;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                StreamWriter writer = new StreamWriter(saveFileDialog1.OpenFile());
                for (int i = 0; i < dgvSteps.RowCount; i++) {
                    if (c.stepsList != null) {
                        // c.stepsList.Clear();
                    } else {
                        c.stepsList = new List<AuxClass.Step>();
                    }

                    if (dgvSteps[0, i].Value != null) {

                        AuxClass.Step temp = new AuxClass.Step();
                        temp = AuxClass.General.DeserializeStep(dgvSteps[4, i].Value.ToString());

                        temp.stepName = dgvSteps[0, i].Value.ToString();
                        temp.stepIterationCount = dgvSteps[1, i].Value.ToString();
                        temp.stepStatus = dgvSteps[2, i].Value.ToString();

                        c.stepsList.Add(temp);
                    }
                }
                String json = AuxClass.General.SerializeObject(c);
                writer.WriteLine(json);
                writer.Dispose();
                writer.Close();
                this.Close();
            }
        }
    }
}
