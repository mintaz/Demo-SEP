namespace Demo.GUI
{
    partial class GUI_Program_Outcomes_AddEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cboOutcomeType = new System.Windows.Forms.ComboBox();
            this.btnOutcomesSave = new System.Windows.Forms.Button();
            this.rcOutcomes = new System.Windows.Forms.RichTextBox();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lblOutcome = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lblOutcometype = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblOutcome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblOutcometype)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cboOutcomeType);
            this.layoutControl1.Controls.Add(this.btnOutcomesSave);
            this.layoutControl1.Controls.Add(this.rcOutcomes);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(580, 262);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cboOutcomeType
            // 
            this.cboOutcomeType.FormattingEnabled = true;
            this.cboOutcomeType.Location = new System.Drawing.Point(73, 12);
            this.cboOutcomeType.Name = "cboOutcomeType";
            this.cboOutcomeType.Size = new System.Drawing.Size(495, 21);
            this.cboOutcomeType.TabIndex = 6;
            // 
            // btnOutcomesSave
            // 
            this.btnOutcomesSave.Location = new System.Drawing.Point(12, 165);
            this.btnOutcomesSave.Name = "btnOutcomesSave";
            this.btnOutcomesSave.Size = new System.Drawing.Size(556, 51);
            this.btnOutcomesSave.TabIndex = 5;
            this.btnOutcomesSave.Text = "Lưu Lại";
            this.btnOutcomesSave.UseVisualStyleBackColor = true;
            // 
            // rcOutcomes
            // 
            this.rcOutcomes.Location = new System.Drawing.Point(73, 37);
            this.rcOutcomes.Name = "rcOutcomes";
            this.rcOutcomes.Size = new System.Drawing.Size(495, 87);
            this.rcOutcomes.TabIndex = 4;
            this.rcOutcomes.Text = "";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.lblOutcome,
            this.layoutControlItem1,
            this.emptySpaceItem2,
            this.lblOutcometype});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(580, 262);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 208);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(560, 34);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lblOutcome
            // 
            this.lblOutcome.Control = this.rcOutcomes;
            this.lblOutcome.Location = new System.Drawing.Point(0, 25);
            this.lblOutcome.Name = "lblOutcome";
            this.lblOutcome.Size = new System.Drawing.Size(560, 91);
            this.lblOutcome.Text = "Nội Dung";
            this.lblOutcome.TextSize = new System.Drawing.Size(58, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnOutcomesSave;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 153);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(560, 55);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 116);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(560, 37);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lblOutcometype
            // 
            this.lblOutcometype.Control = this.cboOutcomeType;
            this.lblOutcometype.Location = new System.Drawing.Point(0, 0);
            this.lblOutcometype.Name = "lblOutcometype";
            this.lblOutcometype.Size = new System.Drawing.Size(560, 25);
            this.lblOutcometype.Text = "Loại Đầu Ra";
            this.lblOutcometype.TextSize = new System.Drawing.Size(58, 13);
            // 
            // GUI_Program_Outcomes_AddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 262);
            this.Controls.Add(this.layoutControl1);
            this.Name = "GUI_Program_Outcomes_AddEdit";
            this.Text = "GUI_Program_Outcomes_AddEdit";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblOutcome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblOutcometype)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.Button btnOutcomesSave;
        private System.Windows.Forms.RichTextBox rcOutcomes;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem lblOutcome;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private System.Windows.Forms.ComboBox cboOutcomeType;
        private DevExpress.XtraLayout.LayoutControlItem lblOutcometype;
    }
}