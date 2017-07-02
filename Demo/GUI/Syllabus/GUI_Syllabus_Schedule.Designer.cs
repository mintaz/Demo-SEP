namespace Demo.GUI.Syllabus
{
    partial class GUI_Syllabus_Schedule
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
            this.txtcount = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.ckMid = new System.Windows.Forms.CheckBox();
            this.rtDoc = new System.Windows.Forms.RichTextBox();
            this.rtAct = new System.Windows.Forms.RichTextBox();
            this.rtContent = new System.Windows.Forms.RichTextBox();
            this.txtPeriods = new System.Windows.Forms.TextBox();
            this.dtTime = new System.Windows.Forms.DateTimePicker();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtcount);
            this.layoutControl1.Controls.Add(this.btnSave);
            this.layoutControl1.Controls.Add(this.ckMid);
            this.layoutControl1.Controls.Add(this.rtDoc);
            this.layoutControl1.Controls.Add(this.rtAct);
            this.layoutControl1.Controls.Add(this.rtContent);
            this.layoutControl1.Controls.Add(this.txtPeriods);
            this.layoutControl1.Controls.Add(this.dtTime);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(967, 617);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtcount
            // 
            this.txtcount.Location = new System.Drawing.Point(119, 60);
            this.txtcount.Name = "txtcount";
            this.txtcount.Size = new System.Drawing.Size(362, 20);
            this.txtcount.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 525);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(943, 80);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Lưu Lại";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ckMid
            // 
            this.ckMid.Location = new System.Drawing.Point(485, 36);
            this.ckMid.Name = "ckMid";
            this.ckMid.Size = new System.Drawing.Size(470, 20);
            this.ckMid.TabIndex = 9;
            this.ckMid.Text = "Thi Giữa Kỳ";
            this.ckMid.UseVisualStyleBackColor = true;
            // 
            // rtDoc
            // 
            this.rtDoc.Location = new System.Drawing.Point(119, 385);
            this.rtDoc.Name = "rtDoc";
            this.rtDoc.Size = new System.Drawing.Size(836, 136);
            this.rtDoc.TabIndex = 8;
            this.rtDoc.Text = "";
            // 
            // rtAct
            // 
            this.rtAct.Location = new System.Drawing.Point(119, 224);
            this.rtAct.Name = "rtAct";
            this.rtAct.Size = new System.Drawing.Size(836, 157);
            this.rtAct.TabIndex = 7;
            this.rtAct.Text = "";
            // 
            // rtContent
            // 
            this.rtContent.Location = new System.Drawing.Point(119, 84);
            this.rtContent.Name = "rtContent";
            this.rtContent.Size = new System.Drawing.Size(836, 136);
            this.rtContent.TabIndex = 6;
            this.rtContent.Text = "";
            // 
            // txtPeriods
            // 
            this.txtPeriods.Location = new System.Drawing.Point(119, 36);
            this.txtPeriods.Name = "txtPeriods";
            this.txtPeriods.Size = new System.Drawing.Size(362, 20);
            this.txtPeriods.TabIndex = 5;
            this.txtPeriods.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeriods_KeyPress);
            // 
            // dtTime
            // 
            this.dtTime.Location = new System.Drawing.Point(119, 12);
            this.dtTime.Name = "dtTime";
            this.dtTime.Size = new System.Drawing.Size(836, 20);
            this.dtTime.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(967, 617);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dtTime;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(947, 24);
            this.layoutControlItem1.Text = "Ngày";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(104, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtPeriods;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(473, 24);
            this.layoutControlItem2.Text = "Số Tiết";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(104, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.rtContent;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(947, 140);
            this.layoutControlItem3.Text = "Nội Dung Bài Học";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(104, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.rtAct;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 212);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(947, 161);
            this.layoutControlItem4.Text = "Hoạt Động Giảng Dạy";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(104, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.rtDoc;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 373);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(947, 140);
            this.layoutControlItem5.Text = "Tài Liệu Cần Đọc";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(104, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.ckMid;
            this.layoutControlItem6.Location = new System.Drawing.Point(473, 24);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(474, 24);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnSave;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 513);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(947, 84);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txtcount;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(473, 24);
            this.layoutControlItem8.Text = "Tổng số Tiết còn lại";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(104, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(473, 48);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(474, 24);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // GUI_Syllabus_Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 617);
            this.Controls.Add(this.layoutControl1);
            this.Name = "GUI_Syllabus_Schedule";
            this.Text = "GUI_Syllabus_Schedule";
            this.Load += new System.EventHandler(this.GUI_Syllabus_Schedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox ckMid;
        private System.Windows.Forms.RichTextBox rtDoc;
        private System.Windows.Forms.RichTextBox rtAct;
        private System.Windows.Forms.RichTextBox rtContent;
        private System.Windows.Forms.TextBox txtPeriods;
        private System.Windows.Forms.DateTimePicker dtTime;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private System.Windows.Forms.TextBox txtcount;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}