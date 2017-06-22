namespace Demo.GUI
{
    partial class GUI_Program_CreateProgram
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
            this.cboProgramMaster = new System.Windows.Forms.ComboBox();
            this.btnProgramSave = new System.Windows.Forms.Button();
            this.txtProgramName = new System.Windows.Forms.TextBox();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lblProgramName = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lblProgramMaster = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblProgramName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblProgramMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cboProgramMaster);
            this.layoutControl1.Controls.Add(this.btnProgramSave);
            this.layoutControl1.Controls.Add(this.txtProgramName);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(544, 63, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(457, 187);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cboProgramMaster
            // 
            this.cboProgramMaster.FormattingEnabled = true;
            this.cboProgramMaster.Location = new System.Drawing.Point(145, 36);
            this.cboProgramMaster.Name = "cboProgramMaster";
            this.cboProgramMaster.Size = new System.Drawing.Size(300, 21);
            this.cboProgramMaster.TabIndex = 12;
            // 
            // btnProgramSave
            // 
            this.btnProgramSave.Location = new System.Drawing.Point(12, 106);
            this.btnProgramSave.Name = "btnProgramSave";
            this.btnProgramSave.Size = new System.Drawing.Size(433, 40);
            this.btnProgramSave.TabIndex = 11;
            this.btnProgramSave.Text = "Lưu Lại";
            this.btnProgramSave.UseVisualStyleBackColor = true;
            this.btnProgramSave.Click += new System.EventHandler(this.btnProgramSave_Click);
            // 
            // txtProgramName
            // 
            this.txtProgramName.Location = new System.Drawing.Point(145, 12);
            this.txtProgramName.Name = "txtProgramName";
            this.txtProgramName.Size = new System.Drawing.Size(300, 20);
            this.txtProgramName.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.lblProgramName,
            this.layoutControlItem1,
            this.emptySpaceItem5,
            this.lblProgramMaster});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(457, 187);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 138);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(437, 29);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lblProgramName
            // 
            this.lblProgramName.Control = this.txtProgramName;
            this.lblProgramName.Location = new System.Drawing.Point(0, 0);
            this.lblProgramName.Name = "lblProgramName";
            this.lblProgramName.Size = new System.Drawing.Size(437, 24);
            this.lblProgramName.Text = "Tên Chương Trình Đào Tạo";
            this.lblProgramName.TextSize = new System.Drawing.Size(130, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnProgramSave;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 94);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(437, 44);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(0, 49);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(437, 45);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lblProgramMaster
            // 
            this.lblProgramMaster.Control = this.cboProgramMaster;
            this.lblProgramMaster.Location = new System.Drawing.Point(0, 24);
            this.lblProgramMaster.Name = "lblProgramMaster";
            this.lblProgramMaster.Size = new System.Drawing.Size(437, 25);
            this.lblProgramMaster.Text = "Trưởng Ban Biên Soạn";
            this.lblProgramMaster.TextSize = new System.Drawing.Size(130, 13);
            // 
            // GUI_Program_CreateProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 187);
            this.Controls.Add(this.layoutControl1);
            this.Name = "GUI_Program_CreateProgram";
            this.Text = "Tạo Chương Trình Đào Tạo";
            this.Load += new System.EventHandler(this.GUI_Program_CreateProgram_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblProgramName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblProgramMaster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.ComboBox cboProgramMaster;
        private System.Windows.Forms.Button btnProgramSave;
        private System.Windows.Forms.TextBox txtProgramName;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem lblProgramName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraLayout.LayoutControlItem lblProgramMaster;
    }
}