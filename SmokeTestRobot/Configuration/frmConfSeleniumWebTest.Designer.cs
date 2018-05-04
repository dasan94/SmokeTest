namespace SmokeTestRobot.Configuration {
    partial class frmConfSeleniumWebTest {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfSeleniumWebTest));
            this.cbDriver = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDriverType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDriverName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.tbIteractionCount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvSteps = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.StepDetailTxt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stepDetail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.stepStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.stepIterationCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stepName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSteps)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbDriver
            // 
            this.cbDriver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDriver.FormattingEnabled = true;
            this.cbDriver.Items.AddRange(new object[] {
            "Selenium"});
            this.cbDriver.Location = new System.Drawing.Point(73, 33);
            this.cbDriver.Name = "cbDriver";
            this.cbDriver.Size = new System.Drawing.Size(121, 21);
            this.cbDriver.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Driver";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Type";
            // 
            // cbDriverType
            // 
            this.cbDriverType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDriverType.FormattingEnabled = true;
            this.cbDriverType.Items.AddRange(new object[] {
            "Web"});
            this.cbDriverType.Location = new System.Drawing.Point(73, 71);
            this.cbDriverType.Name = "cbDriverType";
            this.cbDriverType.Size = new System.Drawing.Size(121, 21);
            this.cbDriverType.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // cbDriverName
            // 
            this.cbDriverName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDriverName.FormattingEnabled = true;
            this.cbDriverName.Items.AddRange(new object[] {
            "InternetExplorerDriver"});
            this.cbDriverName.Location = new System.Drawing.Point(254, 33);
            this.cbDriverName.Name = "cbDriverName";
            this.cbDriverName.Size = new System.Drawing.Size(155, 21);
            this.cbDriverName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Url";
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(254, 71);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(400, 20);
            this.tbUrl.TabIndex = 7;
            this.tbUrl.Text = "http://";
            // 
            // tbIteractionCount
            // 
            this.tbIteractionCount.Location = new System.Drawing.Point(533, 33);
            this.tbIteractionCount.MaxLength = 3;
            this.tbIteractionCount.Name = "tbIteractionCount";
            this.tbIteractionCount.Size = new System.Drawing.Size(121, 20);
            this.tbIteractionCount.TabIndex = 9;
            this.tbIteractionCount.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(437, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Iteraction Count";
            // 
            // dgvSteps
            // 
            this.dgvSteps.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSteps.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSteps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSteps.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stepName,
            this.stepIterationCount,
            this.stepStatus,
            this.stepDetail,
            this.StepDetailTxt});
            this.dgvSteps.Location = new System.Drawing.Point(17, 19);
            this.dgvSteps.Name = "dgvSteps";
            this.dgvSteps.Size = new System.Drawing.Size(618, 273);
            this.dgvSteps.TabIndex = 10;
            this.dgvSteps.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSteps_CellClick);
            this.dgvSteps.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSteps_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(19, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(659, 99);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvSteps);
            this.groupBox2.Location = new System.Drawing.Point(19, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(659, 304);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Steps";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(82, 454);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(533, 454);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // StepDetailTxt
            // 
            this.StepDetailTxt.HeaderText = "Detail";
            this.StepDetailTxt.Name = "StepDetailTxt";
            this.StepDetailTxt.Visible = false;
            // 
            // stepDetail
            // 
            this.stepDetail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.stepDetail.HeaderText = "Detail";
            this.stepDetail.Name = "stepDetail";
            this.stepDetail.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.stepDetail.Text = "See Detail";
            this.stepDetail.ToolTipText = "Step detail definition";
            this.stepDetail.UseColumnTextForButtonValue = true;
            // 
            // stepStatus
            // 
            this.stepStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.stepStatus.FalseValue = "0";
            this.stepStatus.HeaderText = "Status";
            this.stepStatus.Name = "stepStatus";
            this.stepStatus.TrueValue = "1";
            // 
            // stepIterationCount
            // 
            this.stepIterationCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.stepIterationCount.HeaderText = "Replay Count";
            this.stepIterationCount.MaxInputLength = 3;
            this.stepIterationCount.Name = "stepIterationCount";
            this.stepIterationCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // stepName
            // 
            this.stepName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stepName.HeaderText = "Name";
            this.stepName.MaxInputLength = 50;
            this.stepName.Name = "stepName";
            this.stepName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frmConfSeleniumWebTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 507);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbIteractionCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbDriverName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbDriverType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDriver);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConfSeleniumWebTest";
            this.Text = "Selenium Web Test Configuration Manager";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSteps)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDriver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDriverType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDriverName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.TextBox tbIteractionCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvSteps;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn stepName;
        private System.Windows.Forms.DataGridViewTextBoxColumn stepIterationCount;
        private System.Windows.Forms.DataGridViewCheckBoxColumn stepStatus;
        private System.Windows.Forms.DataGridViewButtonColumn stepDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn StepDetailTxt;
    }
}