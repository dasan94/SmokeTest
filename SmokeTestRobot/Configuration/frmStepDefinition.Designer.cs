using System.Windows.Forms;

namespace SmokeTestRobot.Configuration {
    partial class frmStepDefinition {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox stepType;
        private ComboBox stepAction;
        private ComboBox stepActionParam;
        private TextBox stepNameType; 
        private TextBox stepActionParamText;
        private Button btnSave;
        private Button btnCancel;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStepDefinition));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.stepType = new System.Windows.Forms.ComboBox();
            this.stepAction = new System.Windows.Forms.ComboBox();
            this.stepActionParam = new System.Windows.Forms.ComboBox();
            this.stepNameType = new System.Windows.Forms.TextBox();
            this.stepActionParamText = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Element Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Field Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Action Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Action Parameter";
            // 
            // stepType
            // 
            this.stepType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stepType.FormattingEnabled = true;
            this.stepType.Items.AddRange(new object[] {
            "Program",
            "Element"});
            this.stepType.Location = new System.Drawing.Point(150, 35);
            this.stepType.Name = "stepType";
            this.stepType.Size = new System.Drawing.Size(200, 21);
            this.stepType.TabIndex = 4;
            this.stepType.SelectedIndexChanged += new System.EventHandler(this.stepType_TextChanged);
            this.stepType.TextChanged += new System.EventHandler(this.stepType_TextChanged);
            // 
            // stepAction
            // 
            this.stepAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stepAction.FormattingEnabled = true;
            this.stepAction.Items.AddRange(new object[] {
            ""});
            this.stepAction.Location = new System.Drawing.Point(150, 105);
            this.stepAction.Name = "stepAction";
            this.stepAction.Size = new System.Drawing.Size(200, 21);
            this.stepAction.TabIndex = 4;
            this.stepAction.SelectedIndexChanged += new System.EventHandler(this.stepAction_SelectedIndexChanged);
            // 
            // stepActionParam
            // 
            this.stepActionParam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stepActionParam.FormattingEnabled = true;
            this.stepActionParam.Items.AddRange(new object[] {
            ""});
            this.stepActionParam.Location = new System.Drawing.Point(150, 137);
            this.stepActionParam.Name = "stepActionParam";
            this.stepActionParam.Size = new System.Drawing.Size(200, 21);
            this.stepActionParam.TabIndex = 4;
            this.stepActionParam.SelectedIndexChanged += new System.EventHandler(this.stepActionParam_SelectedIndexChanged);
            // 
            // stepNameType
            // 
            this.stepNameType.Location = new System.Drawing.Point(150, 70);
            this.stepNameType.Name = "stepNameType";
            this.stepNameType.ReadOnly = true;
            this.stepNameType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.stepNameType.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.stepNameType.Size = new System.Drawing.Size(200, 20);
            this.stepNameType.TabIndex = 7;
            // 
            // stepActionParamText
            // 
            this.stepActionParamText.Location = new System.Drawing.Point(150, 137);
            this.stepActionParamText.Name = "stepActionParamText";
            this.stepActionParamText.ReadOnly = true;
            this.stepActionParamText.Size = new System.Drawing.Size(200, 20);
            this.stepActionParamText.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(150, 211);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(250, 211);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmStepDefinition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 296);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stepType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stepNameType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stepAction);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.stepActionParam);
            this.Controls.Add(this.stepActionParamText);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStepDefinition";
            this.Text = "STEP DETAIL";
            this.Load += new System.EventHandler(this.frmStepDefinition_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}