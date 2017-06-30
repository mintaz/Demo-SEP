namespace Demo.GUI.Syllabus
{
    partial class GUI_Syllabus_ScheduleManager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_Syllabus_ScheduleManager));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnAdd = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnDel = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gcSchedule = new DevExpress.XtraGrid.GridControl();
            this.gvSchedule = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Periods = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ND = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAdd,
            this.btnEdit,
            this.btnDel});
            this.barManager1.MaxItemId = 3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEdit),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "Thêm";
            this.btnAdd.Glyph = ((System.Drawing.Image)(resources.GetObject("btnAdd.Glyph")));
            this.btnAdd.Id = 0;
            this.btnAdd.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnAdd.LargeGlyph")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 0);
            this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "Sửa";
            this.btnEdit.Glyph = ((System.Drawing.Image)(resources.GetObject("btnEdit.Glyph")));
            this.btnEdit.Id = 1;
            this.btnEdit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnEdit.LargeGlyph")));
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 0);
            this.btnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEdit_ItemClick);
            // 
            // btnDel
            // 
            this.btnDel.Caption = "Xóa";
            this.btnDel.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDel.Glyph")));
            this.btnDel.Id = 2;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 0);
            this.btnDel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDel_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(882, 65);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 412);
            this.barDockControlBottom.Size = new System.Drawing.Size(882, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 65);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 347);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(882, 65);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 347);
            // 
            // gcSchedule
            // 
            this.gcSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSchedule.Location = new System.Drawing.Point(0, 65);
            this.gcSchedule.MainView = this.gvSchedule;
            this.gcSchedule.MenuManager = this.barManager1;
            this.gcSchedule.Name = "gcSchedule";
            this.gcSchedule.Size = new System.Drawing.Size(882, 347);
            this.gcSchedule.TabIndex = 4;
            this.gcSchedule.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSchedule});
            // 
            // gvSchedule
            // 
            this.gvSchedule.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.DATE,
            this.Periods,
            this.ND});
            this.gvSchedule.GridControl = this.gcSchedule;
            this.gvSchedule.Name = "gvSchedule";
            this.gvSchedule.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gvSchedule.OptionsFind.AlwaysVisible = true;
            this.gvSchedule.OptionsFind.FindDelay = 250;
            this.gvSchedule.OptionsFind.FindNullPrompt = "Nhập Từ khóa để tìm kiếm...";
            this.gvSchedule.OptionsView.ShowGroupPanel = false;
            this.gvSchedule.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvSchedule_FocusedRowChanged);
            this.gvSchedule.DoubleClick += new System.EventHandler(this.gvSchedule_DoubleClick);
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "id";
            this.ID.Name = "ID";
            this.ID.OptionsColumn.AllowEdit = false;
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            // 
            // DATE
            // 
            this.DATE.Caption = "Ngày";
            this.DATE.FieldName = "Day";
            this.DATE.Name = "DATE";
            this.DATE.OptionsColumn.AllowEdit = false;
            this.DATE.Visible = true;
            this.DATE.VisibleIndex = 1;
            // 
            // Periods
            // 
            this.Periods.Caption = "Số tiết";
            this.Periods.FieldName = "NumberPeriods";
            this.Periods.Name = "Periods";
            this.Periods.OptionsColumn.AllowEdit = false;
            this.Periods.Visible = true;
            this.Periods.VisibleIndex = 2;
            // 
            // ND
            // 
            this.ND.Caption = "Nội Dung ";
            this.ND.FieldName = "LectureContent";
            this.ND.Name = "ND";
            this.ND.OptionsColumn.AllowEdit = false;
            this.ND.Visible = true;
            this.ND.VisibleIndex = 3;
            // 
            // GUI_Syllabus_ScheduleManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 412);
            this.Controls.Add(this.gcSchedule);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "GUI_Syllabus_ScheduleManager";
            this.Text = "GUI_Syllabus_ScheduleManager";
            this.Load += new System.EventHandler(this.GUI_Syllabus_ScheduleManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarLargeButtonItem btnAdd;
        private DevExpress.XtraBars.BarLargeButtonItem btnEdit;
        private DevExpress.XtraBars.BarLargeButtonItem btnDel;
        private DevExpress.XtraGrid.GridControl gcSchedule;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSchedule;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn DATE;
        private DevExpress.XtraGrid.Columns.GridColumn Periods;
        private DevExpress.XtraGrid.Columns.GridColumn ND;
    }
}