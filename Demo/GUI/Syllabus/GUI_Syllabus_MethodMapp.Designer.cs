namespace Demo.GUI.Syllabus
{
    partial class GUI_Syllabus_MethodMapp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_Syllabus_MethodMapp));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnEdit = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnDel = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gcMethodMap = new DevExpress.XtraGrid.GridControl();
            this.gvMethodMap = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SYSOUT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SYSPRO = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMethodMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMethodMap)).BeginInit();
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEdit),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "Cập Nhập";
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
            this.barDockControlTop.Size = new System.Drawing.Size(882, 67);
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
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 67);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 345);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(882, 67);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 345);
            // 
            // gcMethodMap
            // 
            this.gcMethodMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcMethodMap.Location = new System.Drawing.Point(0, 67);
            this.gcMethodMap.MainView = this.gvMethodMap;
            this.gcMethodMap.MenuManager = this.barManager1;
            this.gcMethodMap.Name = "gcMethodMap";
            this.gcMethodMap.Size = new System.Drawing.Size(882, 345);
            this.gcMethodMap.TabIndex = 4;
            this.gcMethodMap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMethodMap});
            // 
            // gvMethodMap
            // 
            this.gvMethodMap.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.SYSOUT,
            this.SYSPRO});
            this.gvMethodMap.GridControl = this.gcMethodMap;
            this.gvMethodMap.Name = "gvMethodMap";
            this.gvMethodMap.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gvMethodMap.OptionsFind.AlwaysVisible = true;
            this.gvMethodMap.OptionsFind.FindDelay = 250;
            this.gvMethodMap.OptionsFind.FindNullPrompt = "Nhập Từ Khóa để tìm kiếm...";
            this.gvMethodMap.OptionsView.ShowGroupPanel = false;
            this.gvMethodMap.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvMethodMap_FocusedRowChanged);
            this.gvMethodMap.DoubleClick += new System.EventHandler(this.gvMethodMap_DoubleClick);
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
            // SYSOUT
            // 
            this.SYSOUT.Caption = "Chuẩn đầu ra Môn học";
            this.SYSOUT.FieldName = "SyllabusOutcome";
            this.SYSOUT.Name = "SYSOUT";
            this.SYSOUT.OptionsColumn.AllowEdit = false;
            this.SYSOUT.Visible = true;
            this.SYSOUT.VisibleIndex = 1;
            // 
            // SYSPRO
            // 
            this.SYSPRO.Caption = "Chuẩn đầu ra Chương trình đào tạo";
            this.SYSPRO.FieldName = "ProgramOutcome";
            this.SYSPRO.Name = "SYSPRO";
            this.SYSPRO.OptionsColumn.AllowEdit = false;
            this.SYSPRO.Visible = true;
            this.SYSPRO.VisibleIndex = 2;
            // 
            // GUI_Syllabus_MethodMapp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 412);
            this.Controls.Add(this.gcMethodMap);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "GUI_Syllabus_MethodMapp";
            this.Text = "GUI_Syllabus_MethodMapp";
            this.Load += new System.EventHandler(this.GUI_Syllabus_MethodMapp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMethodMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMethodMap)).EndInit();
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
        private DevExpress.XtraBars.BarLargeButtonItem btnEdit;
        private DevExpress.XtraBars.BarLargeButtonItem btnDel;
        private DevExpress.XtraGrid.GridControl gcMethodMap;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMethodMap;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn SYSOUT;
        private DevExpress.XtraGrid.Columns.GridColumn SYSPRO;
    }
}