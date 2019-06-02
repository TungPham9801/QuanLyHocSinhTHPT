namespace QuanLyHocSinhTHPT.GUI
{
    partial class F_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Main));
            this.ribbonControl = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanel3 = new DevComponents.DotNetBar.RibbonPanel();
            this.rbbQuyDinh = new DevComponents.DotNetBar.RibbonBar();
            this.btnQuyDinh = new DevComponents.DotNetBar.ButtonItem();
            this.rbbTCHocSinh = new DevComponents.DotNetBar.RibbonBar();
            this.btnTCHocSinh = new DevComponents.DotNetBar.ButtonItem();
            this.rbbTCGiaoVien = new DevComponents.DotNetBar.RibbonBar();
            this.btnTCGiaoVien = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.rbbKhac = new DevComponents.DotNetBar.RibbonBar();
            this.btnDanToc = new DevComponents.DotNetBar.ButtonItem();
            this.btnTonGiao = new DevComponents.DotNetBar.ButtonItem();
            this.btnNgheNghiep = new DevComponents.DotNetBar.ButtonItem();
            this.rbbHocSinhGV = new DevComponents.DotNetBar.RibbonBar();
            this.btnHocSinh = new DevComponents.DotNetBar.ButtonItem();
            this.btnGiaoVien = new DevComponents.DotNetBar.ButtonItem();
            this.btnPhanCong = new DevComponents.DotNetBar.ButtonItem();
            this.btnPhanLop = new DevComponents.DotNetBar.ButtonItem();
            this.rbbMonHoc = new DevComponents.DotNetBar.RibbonBar();
            this.btnMonHoc = new DevComponents.DotNetBar.ButtonItem();
            this.btnDiem = new DevComponents.DotNetBar.ButtonItem();
            this.btnLoaiDiem = new DevComponents.DotNetBar.ButtonItem();
            this.rbbNamHoc = new DevComponents.DotNetBar.RibbonBar();
            this.btnHocKy = new DevComponents.DotNetBar.ButtonItem();
            this.btnNamHoc = new DevComponents.DotNetBar.ButtonItem();
            this.rbbLop = new DevComponents.DotNetBar.RibbonBar();
            this.btnLopHoc = new DevComponents.DotNetBar.ButtonItem();
            this.btnKhoiLop = new DevComponents.DotNetBar.ButtonItem();
            this.buttonFile1 = new DevComponents.DotNetBar.Office2007StartButton();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer2 = new DevComponents.DotNetBar.ItemContainer();
            this.btnDangNhap = new DevComponents.DotNetBar.ButtonItem();
            this.btnDangXuat = new DevComponents.DotNetBar.ButtonItem();
            this.btnDoiMatKhau = new DevComponents.DotNetBar.ButtonItem();
            this.btnQLNguoiDung = new DevComponents.DotNetBar.ButtonItem();
            this.btnThoat = new DevComponents.DotNetBar.ButtonItem();
            this.ribtapQuanLy = new DevComponents.DotNetBar.RibbonTabItem();
            this.rbtTraCuu = new DevComponents.DotNetBar.RibbonTabItem();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.qatCustomizeItem1 = new DevComponents.DotNetBar.QatCustomizeItem();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.tabStrip1 = new DevComponents.DotNetBar.TabStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabItem1 = new DevComponents.DotNetBar.TabItem(this.components);
            this.ribbonControl.SuspendLayout();
            this.ribbonPanel3.SuspendLayout();
            this.ribbonPanel1.SuspendLayout();
            this.tabStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            // 
            // 
            // 
            this.ribbonControl.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonControl.CaptionVisible = true;
            this.ribbonControl.Controls.Add(this.ribbonPanel3);
            this.ribbonControl.Controls.Add(this.ribbonPanel1);
            this.ribbonControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonFile1,
            this.ribtapQuanLy,
            this.rbtTraCuu});
            this.ribbonControl.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControl.Location = new System.Drawing.Point(5, 1);
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.ribbonControl.QuickToolbarItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1,
            this.qatCustomizeItem1});
            this.ribbonControl.Size = new System.Drawing.Size(1096, 194);
            this.ribbonControl.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonControl.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.ribbonControl.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.ribbonControl.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.ribbonControl.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.ribbonControl.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.ribbonControl.SystemText.QatDialogAddButton = "&Add >>";
            this.ribbonControl.SystemText.QatDialogCancelButton = "Cancel";
            this.ribbonControl.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.ribbonControl.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.ribbonControl.SystemText.QatDialogOkButton = "OK";
            this.ribbonControl.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl.SystemText.QatDialogRemoveButton = "&Remove";
            this.ribbonControl.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.ribbonControl.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.ribbonControl.TabGroupHeight = 14;
            this.ribbonControl.TabIndex = 0;
            this.ribbonControl.Text = "QUẢN LÝ HỌC SINH TRUNG HỌC PHỔ THÔNG";
            this.ribbonControl.Click += new System.EventHandler(this.ribbonControl_Click);
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel3.Controls.Add(this.rbbQuyDinh);
            this.ribbonPanel3.Controls.Add(this.rbbTCHocSinh);
            this.ribbonPanel3.Controls.Add(this.rbbTCGiaoVien);
            this.ribbonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel3.Location = new System.Drawing.Point(0, 53);
            this.ribbonPanel3.Name = "ribbonPanel3";
            this.ribbonPanel3.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel3.Size = new System.Drawing.Size(1096, 138);
            // 
            // 
            // 
            this.ribbonPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel3.TabIndex = 3;
            // 
            // rbbQuyDinh
            // 
            this.rbbQuyDinh.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.rbbQuyDinh.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rbbQuyDinh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rbbQuyDinh.ContainerControlProcessDialogKey = true;
            this.rbbQuyDinh.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbbQuyDinh.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnQuyDinh});
            this.rbbQuyDinh.Location = new System.Drawing.Point(385, 0);
            this.rbbQuyDinh.Name = "rbbQuyDinh";
            this.rbbQuyDinh.Size = new System.Drawing.Size(185, 135);
            this.rbbQuyDinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.rbbQuyDinh.TabIndex = 2;
            this.rbbQuyDinh.Text = "Quy Định";
            // 
            // 
            // 
            this.rbbQuyDinh.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rbbQuyDinh.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnQuyDinh
            // 
            this.btnQuyDinh.FixedSize = new System.Drawing.Size(160, 130);
            this.btnQuyDinh.Image = global::QuanLyHocSinhTHPT.Properties.Resources.qddotuoi;
            this.btnQuyDinh.ImageFixedSize = new System.Drawing.Size(60, 60);
            this.btnQuyDinh.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnQuyDinh.Name = "btnQuyDinh";
            this.btnQuyDinh.SubItemsExpandWidth = 14;
            this.btnQuyDinh.Click += new System.EventHandler(this.btnQuyDinh_Click);
            // 
            // rbbTCHocSinh
            // 
            this.rbbTCHocSinh.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.rbbTCHocSinh.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rbbTCHocSinh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rbbTCHocSinh.ContainerControlProcessDialogKey = true;
            this.rbbTCHocSinh.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbbTCHocSinh.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnTCHocSinh});
            this.rbbTCHocSinh.Location = new System.Drawing.Point(196, 0);
            this.rbbTCHocSinh.Name = "rbbTCHocSinh";
            this.rbbTCHocSinh.Size = new System.Drawing.Size(189, 135);
            this.rbbTCHocSinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.rbbTCHocSinh.TabIndex = 1;
            this.rbbTCHocSinh.Text = "Học Sinh";
            // 
            // 
            // 
            this.rbbTCHocSinh.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rbbTCHocSinh.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnTCHocSinh
            // 
            this.btnTCHocSinh.FixedSize = new System.Drawing.Size(160, 130);
            this.btnTCHocSinh.Image = global::QuanLyHocSinhTHPT.Properties.Resources.tracuuhocsinh;
            this.btnTCHocSinh.ImageFixedSize = new System.Drawing.Size(60, 60);
            this.btnTCHocSinh.Name = "btnTCHocSinh";
            this.btnTCHocSinh.SubItemsExpandWidth = 14;
            this.btnTCHocSinh.Click += new System.EventHandler(this.btnTCHocSinh_Click);
            // 
            // rbbTCGiaoVien
            // 
            this.rbbTCGiaoVien.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.rbbTCGiaoVien.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rbbTCGiaoVien.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rbbTCGiaoVien.ContainerControlProcessDialogKey = true;
            this.rbbTCGiaoVien.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbbTCGiaoVien.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnTCGiaoVien});
            this.rbbTCGiaoVien.Location = new System.Drawing.Point(3, 0);
            this.rbbTCGiaoVien.Name = "rbbTCGiaoVien";
            this.rbbTCGiaoVien.Size = new System.Drawing.Size(193, 135);
            this.rbbTCGiaoVien.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.rbbTCGiaoVien.TabIndex = 0;
            this.rbbTCGiaoVien.Text = "Giáo Viên";
            // 
            // 
            // 
            this.rbbTCGiaoVien.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rbbTCGiaoVien.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnTCGiaoVien
            // 
            this.btnTCGiaoVien.FixedSize = new System.Drawing.Size(160, 130);
            this.btnTCGiaoVien.Image = global::QuanLyHocSinhTHPT.Properties.Resources.tracuugiaovien;
            this.btnTCGiaoVien.ImageFixedSize = new System.Drawing.Size(60, 60);
            this.btnTCGiaoVien.Name = "btnTCGiaoVien";
            this.btnTCGiaoVien.SubItemsExpandWidth = 14;
            this.btnTCGiaoVien.Click += new System.EventHandler(this.btnTCGiaoVien_Click);
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel1.Controls.Add(this.rbbKhac);
            this.ribbonPanel1.Controls.Add(this.rbbHocSinhGV);
            this.ribbonPanel1.Controls.Add(this.rbbMonHoc);
            this.ribbonPanel1.Controls.Add(this.rbbNamHoc);
            this.ribbonPanel1.Controls.Add(this.rbbLop);
            this.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel1.Location = new System.Drawing.Point(0, 53);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel1.Size = new System.Drawing.Size(1096, 138);
            // 
            // 
            // 
            this.ribbonPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel1.TabIndex = 1;
            this.ribbonPanel1.Visible = false;
            // 
            // rbbKhac
            // 
            this.rbbKhac.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.rbbKhac.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rbbKhac.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rbbKhac.ContainerControlProcessDialogKey = true;
            this.rbbKhac.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbbKhac.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnDanToc,
            this.btnTonGiao,
            this.btnNgheNghiep});
            this.rbbKhac.Location = new System.Drawing.Point(851, 0);
            this.rbbKhac.Name = "rbbKhac";
            this.rbbKhac.Size = new System.Drawing.Size(241, 135);
            this.rbbKhac.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.rbbKhac.TabIndex = 4;
            this.rbbKhac.Text = "Khác";
            // 
            // 
            // 
            this.rbbKhac.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rbbKhac.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnDanToc
            // 
            this.btnDanToc.FixedSize = new System.Drawing.Size(70, 90);
            this.btnDanToc.Image = global::QuanLyHocSinhTHPT.Properties.Resources.dantoc;
            this.btnDanToc.ImageFixedSize = new System.Drawing.Size(35, 35);
            this.btnDanToc.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDanToc.Name = "btnDanToc";
            this.btnDanToc.SubItemsExpandWidth = 14;
            this.btnDanToc.Text = "<br/>Dân Tộc";
            this.btnDanToc.Click += new System.EventHandler(this.btnDanToc_Click);
            // 
            // btnTonGiao
            // 
            this.btnTonGiao.FixedSize = new System.Drawing.Size(70, 90);
            this.btnTonGiao.Image = global::QuanLyHocSinhTHPT.Properties.Resources.tongiao;
            this.btnTonGiao.ImageFixedSize = new System.Drawing.Size(35, 35);
            this.btnTonGiao.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnTonGiao.Name = "btnTonGiao";
            this.btnTonGiao.SubItemsExpandWidth = 14;
            this.btnTonGiao.Text = "<br/>Tôn Giáo";
            this.btnTonGiao.Click += new System.EventHandler(this.btnTonGiao_Click);
            // 
            // btnNgheNghiep
            // 
            this.btnNgheNghiep.FixedSize = new System.Drawing.Size(70, 90);
            this.btnNgheNghiep.Image = global::QuanLyHocSinhTHPT.Properties.Resources.nghenghiep;
            this.btnNgheNghiep.ImageFixedSize = new System.Drawing.Size(35, 35);
            this.btnNgheNghiep.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnNgheNghiep.Name = "btnNgheNghiep";
            this.btnNgheNghiep.SubItemsExpandWidth = 14;
            this.btnNgheNghiep.Text = "<br/>Nghề nghiệp";
            this.btnNgheNghiep.Click += new System.EventHandler(this.btnNgheNghiep_Click);
            // 
            // rbbHocSinhGV
            // 
            this.rbbHocSinhGV.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.rbbHocSinhGV.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rbbHocSinhGV.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rbbHocSinhGV.ContainerControlProcessDialogKey = true;
            this.rbbHocSinhGV.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbbHocSinhGV.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnHocSinh,
            this.btnGiaoVien,
            this.btnPhanCong,
            this.btnPhanLop});
            this.rbbHocSinhGV.Location = new System.Drawing.Point(550, 0);
            this.rbbHocSinhGV.Name = "rbbHocSinhGV";
            this.rbbHocSinhGV.Size = new System.Drawing.Size(301, 135);
            this.rbbHocSinhGV.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.rbbHocSinhGV.TabIndex = 3;
            this.rbbHocSinhGV.Text = "Học Sinh - Giáo Viên";
            // 
            // 
            // 
            this.rbbHocSinhGV.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rbbHocSinhGV.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnHocSinh
            // 
            this.btnHocSinh.FixedSize = new System.Drawing.Size(70, 90);
            this.btnHocSinh.Image = global::QuanLyHocSinhTHPT.Properties.Resources.pupils;
            this.btnHocSinh.ImageFixedSize = new System.Drawing.Size(35, 35);
            this.btnHocSinh.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnHocSinh.Name = "btnHocSinh";
            this.btnHocSinh.SubItemsExpandWidth = 14;
            this.btnHocSinh.Text = "<br/>Học Sinh";
            this.btnHocSinh.Click += new System.EventHandler(this.btnHocSinh_Click);
            // 
            // btnGiaoVien
            // 
            this.btnGiaoVien.FixedSize = new System.Drawing.Size(70, 90);
            this.btnGiaoVien.Image = global::QuanLyHocSinhTHPT.Properties.Resources.giaovien;
            this.btnGiaoVien.ImageFixedSize = new System.Drawing.Size(35, 35);
            this.btnGiaoVien.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnGiaoVien.Name = "btnGiaoVien";
            this.btnGiaoVien.SubItemsExpandWidth = 14;
            this.btnGiaoVien.Text = "<br/>Giáo Viên";
            this.btnGiaoVien.Click += new System.EventHandler(this.btnGiaoVien_Click);
            // 
            // btnPhanCong
            // 
            this.btnPhanCong.FixedSize = new System.Drawing.Size(70, 90);
            this.btnPhanCong.Image = global::QuanLyHocSinhTHPT.Properties.Resources.phancong;
            this.btnPhanCong.ImageFixedSize = new System.Drawing.Size(35, 35);
            this.btnPhanCong.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnPhanCong.Name = "btnPhanCong";
            this.btnPhanCong.SubItemsExpandWidth = 14;
            this.btnPhanCong.Text = "<br/>Phân Công";
            this.btnPhanCong.Click += new System.EventHandler(this.btnPhanCong_Click);
            // 
            // btnPhanLop
            // 
            this.btnPhanLop.FixedSize = new System.Drawing.Size(70, 90);
            this.btnPhanLop.Image = global::QuanLyHocSinhTHPT.Properties.Resources.phanlop;
            this.btnPhanLop.ImageFixedSize = new System.Drawing.Size(35, 35);
            this.btnPhanLop.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnPhanLop.Name = "btnPhanLop";
            this.btnPhanLop.SubItemsExpandWidth = 14;
            this.btnPhanLop.Text = "<br/>Phân Lớp";
            this.btnPhanLop.Click += new System.EventHandler(this.btnPhanLop_Click);
            // 
            // rbbMonHoc
            // 
            this.rbbMonHoc.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.rbbMonHoc.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rbbMonHoc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rbbMonHoc.ContainerControlProcessDialogKey = true;
            this.rbbMonHoc.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbbMonHoc.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnMonHoc,
            this.btnDiem,
            this.btnLoaiDiem});
            this.rbbMonHoc.Location = new System.Drawing.Point(313, 0);
            this.rbbMonHoc.Name = "rbbMonHoc";
            this.rbbMonHoc.Size = new System.Drawing.Size(237, 135);
            this.rbbMonHoc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.rbbMonHoc.TabIndex = 2;
            this.rbbMonHoc.Text = "Môn Học";
            // 
            // 
            // 
            this.rbbMonHoc.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rbbMonHoc.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnMonHoc
            // 
            this.btnMonHoc.FixedSize = new System.Drawing.Size(70, 90);
            this.btnMonHoc.Image = global::QuanLyHocSinhTHPT.Properties.Resources.monhoc;
            this.btnMonHoc.ImageFixedSize = new System.Drawing.Size(35, 35);
            this.btnMonHoc.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnMonHoc.Name = "btnMonHoc";
            this.btnMonHoc.SubItemsExpandWidth = 14;
            this.btnMonHoc.Text = "<br/>Môn Học";
            this.btnMonHoc.Click += new System.EventHandler(this.btnMonHoc_Click);
            // 
            // btnDiem
            // 
            this.btnDiem.FixedSize = new System.Drawing.Size(70, 90);
            this.btnDiem.Image = global::QuanLyHocSinhTHPT.Properties.Resources.diem;
            this.btnDiem.ImageFixedSize = new System.Drawing.Size(35, 35);
            this.btnDiem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDiem.Name = "btnDiem";
            this.btnDiem.SubItemsExpandWidth = 14;
            this.btnDiem.Text = "<br/>  Điểm";
            this.btnDiem.Click += new System.EventHandler(this.btnDiem_Click);
            // 
            // btnLoaiDiem
            // 
            this.btnLoaiDiem.FixedSize = new System.Drawing.Size(70, 90);
            this.btnLoaiDiem.Image = global::QuanLyHocSinhTHPT.Properties.Resources.kqcnamtheomon;
            this.btnLoaiDiem.ImageFixedSize = new System.Drawing.Size(35, 35);
            this.btnLoaiDiem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnLoaiDiem.Name = "btnLoaiDiem";
            this.btnLoaiDiem.SubItemsExpandWidth = 14;
            this.btnLoaiDiem.Text = "<br/>Loại Điểm";
            this.btnLoaiDiem.Click += new System.EventHandler(this.btnLoaiDiem_Click);
            // 
            // rbbNamHoc
            // 
            this.rbbNamHoc.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.rbbNamHoc.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rbbNamHoc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rbbNamHoc.ContainerControlProcessDialogKey = true;
            this.rbbNamHoc.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbbNamHoc.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnHocKy,
            this.btnNamHoc});
            this.rbbNamHoc.Location = new System.Drawing.Point(156, 0);
            this.rbbNamHoc.Name = "rbbNamHoc";
            this.rbbNamHoc.Size = new System.Drawing.Size(157, 135);
            this.rbbNamHoc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.rbbNamHoc.TabIndex = 1;
            this.rbbNamHoc.Text = "Năm Học";
            // 
            // 
            // 
            this.rbbNamHoc.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rbbNamHoc.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnHocKy
            // 
            this.btnHocKy.FixedSize = new System.Drawing.Size(70, 90);
            this.btnHocKy.Image = global::QuanLyHocSinhTHPT.Properties.Resources.hocky;
            this.btnHocKy.ImageFixedSize = new System.Drawing.Size(35, 35);
            this.btnHocKy.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnHocKy.Name = "btnHocKy";
            this.btnHocKy.SubItemsExpandWidth = 14;
            this.btnHocKy.Text = "<br/>Học Kỳ";
            this.btnHocKy.Click += new System.EventHandler(this.btnHocKy_Click);
            // 
            // btnNamHoc
            // 
            this.btnNamHoc.FixedSize = new System.Drawing.Size(70, 90);
            this.btnNamHoc.Image = global::QuanLyHocSinhTHPT.Properties.Resources.namhoc;
            this.btnNamHoc.ImageFixedSize = new System.Drawing.Size(35, 35);
            this.btnNamHoc.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnNamHoc.Name = "btnNamHoc";
            this.btnNamHoc.SubItemsExpandWidth = 14;
            this.btnNamHoc.Text = "<br/>Năm Học";
            this.btnNamHoc.Click += new System.EventHandler(this.btnNamHoc_Click);
            // 
            // rbbLop
            // 
            this.rbbLop.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.rbbLop.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rbbLop.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rbbLop.ContainerControlProcessDialogKey = true;
            this.rbbLop.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbbLop.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnLopHoc,
            this.btnKhoiLop});
            this.rbbLop.Location = new System.Drawing.Point(3, 0);
            this.rbbLop.Name = "rbbLop";
            this.rbbLop.Size = new System.Drawing.Size(153, 135);
            this.rbbLop.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.rbbLop.TabIndex = 0;
            this.rbbLop.Text = "Lớp - Khối Lớp";
            // 
            // 
            // 
            this.rbbLop.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rbbLop.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnLopHoc
            // 
            this.btnLopHoc.FixedSize = new System.Drawing.Size(70, 90);
            this.btnLopHoc.Image = global::QuanLyHocSinhTHPT.Properties.Resources.lophoc;
            this.btnLopHoc.ImageFixedSize = new System.Drawing.Size(35, 35);
            this.btnLopHoc.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnLopHoc.Name = "btnLopHoc";
            this.btnLopHoc.SubItemsExpandWidth = 14;
            this.btnLopHoc.Text = "<br/>Lớp Học";
            this.btnLopHoc.Click += new System.EventHandler(this.btnLopHoc_Click);
            // 
            // btnKhoiLop
            // 
            this.btnKhoiLop.FixedSize = new System.Drawing.Size(70, 90);
            this.btnKhoiLop.Image = global::QuanLyHocSinhTHPT.Properties.Resources.khoilop;
            this.btnKhoiLop.ImageFixedSize = new System.Drawing.Size(35, 35);
            this.btnKhoiLop.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnKhoiLop.Name = "btnKhoiLop";
            this.btnKhoiLop.SubItemsExpandWidth = 14;
            this.btnKhoiLop.Text = "<br/>Khối Lớp";
            this.btnKhoiLop.Click += new System.EventHandler(this.btnKhoiLop_Click);
            // 
            // buttonFile1
            // 
            this.buttonFile1.AutoExpandOnClick = true;
            this.buttonFile1.CanCustomize = false;
            this.buttonFile1.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
            this.buttonFile1.Image = global::QuanLyHocSinhTHPT.Properties.Resources.start;
            this.buttonFile1.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.buttonFile1.ImagePaddingHorizontal = 0;
            this.buttonFile1.ImagePaddingVertical = 0;
            this.buttonFile1.Name = "buttonFile1";
            this.buttonFile1.NotificationMarkPosition = DevComponents.DotNetBar.eNotificationMarkPosition.TopLeft;
            this.buttonFile1.ShowSubItems = false;
            this.buttonFile1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer1});
            this.buttonFile1.Tooltip = "Nút điều khiển chương trình";
            // 
            // itemContainer1
            // 
            // 
            // 
            // 
            this.itemContainer1.BackgroundStyle.Class = "RibbonFileMenuContainer";
            this.itemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer1.Name = "itemContainer1";
            this.itemContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer2});
            // 
            // 
            // 
            this.itemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // itemContainer2
            // 
            // 
            // 
            // 
            this.itemContainer2.BackgroundStyle.Class = "RibbonFileMenuColumnOneContainer";
            this.itemContainer2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer2.ItemSpacing = 5;
            this.itemContainer2.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer2.MinimumSize = new System.Drawing.Size(120, 0);
            this.itemContainer2.Name = "itemContainer2";
            this.itemContainer2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnDangNhap,
            this.btnDangXuat,
            this.btnDoiMatKhau,
            this.btnQLNguoiDung,
            this.btnThoat});
            // 
            // 
            // 
            this.itemContainer2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnDangNhap.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnDangNhap.Image = global::QuanLyHocSinhTHPT.Properties.Resources.dangnhap;
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.SubItemsExpandWidth = 24;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnDangXuat.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnDangXuat.Image = global::QuanLyHocSinhTHPT.Properties.Resources.dangxuat;
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.SubItemsExpandWidth = 24;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.BeginGroup = true;
            this.btnDoiMatKhau.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnDoiMatKhau.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnDoiMatKhau.Image = global::QuanLyHocSinhTHPT.Properties.Resources.doimatkhau;
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.SubItemsExpandWidth = 24;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // btnQLNguoiDung
            // 
            this.btnQLNguoiDung.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnQLNguoiDung.Image = global::QuanLyHocSinhTHPT.Properties.Resources.quanlynguoidung;
            this.btnQLNguoiDung.Name = "btnQLNguoiDung";
            this.btnQLNguoiDung.SubItemsExpandWidth = 24;
            this.btnQLNguoiDung.Text = "Quản lý người dùng";
            this.btnQLNguoiDung.Click += new System.EventHandler(this.btnQLNguoiDung_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BeginGroup = true;
            this.btnThoat.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnThoat.Image = global::QuanLyHocSinhTHPT.Properties.Resources.thoat;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.SubItemsExpandWidth = 24;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // ribtapQuanLy
            // 
            this.ribtapQuanLy.Name = "ribtapQuanLy";
            this.ribtapQuanLy.Panel = this.ribbonPanel1;
            this.ribtapQuanLy.Text = "Quản Lý";
            // 
            // rbtTraCuu
            // 
            this.rbtTraCuu.Checked = true;
            this.rbtTraCuu.Name = "rbtTraCuu";
            this.rbtTraCuu.Panel = this.ribbonPanel3;
            this.rbtTraCuu.Text = "Tra Cứu";
            // 
            // buttonItem1
            // 
            this.buttonItem1.Name = "buttonItem1";
            // 
            // qatCustomizeItem1
            // 
            this.qatCustomizeItem1.Name = "qatCustomizeItem1";
            this.qatCustomizeItem1.Visible = false;
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // tabStrip1
            // 
            this.tabStrip1.AutoSelectAttachedControl = true;
            this.tabStrip1.CanReorderTabs = true;
            this.tabStrip1.CloseButtonVisible = true;
            this.tabStrip1.Controls.Add(this.panel1);
            this.tabStrip1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabStrip1.Location = new System.Drawing.Point(5, 195);
            this.tabStrip1.Name = "tabStrip1";
            this.tabStrip1.SelectedTab = this.tabItem1;
            this.tabStrip1.Size = new System.Drawing.Size(1010, 49);
            this.tabStrip1.Style = DevComponents.DotNetBar.eTabStripStyle.VS2005;
            this.tabStrip1.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Right;
            this.tabStrip1.TabIndex = 1;
            this.tabStrip1.Tabs.Add(this.tabItem1);
            this.tabStrip1.Text = "tabStrip1";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1091, 460);
            this.panel1.TabIndex = 0;
            // 
            // tabItem1
            // 
            this.tabItem1.Name = "tabItem1";
            this.tabItem1.Text = "";
            // 
            // F_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1106, 669);
            this.Controls.Add(this.tabStrip1);
            this.Controls.Add(this.ribbonControl);
            this.HelpButton = true;
            this.Name = "F_Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "                          QUẢN LÝ HỌC SINH TRUNG HỌC PHỔ THÔNG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.F_Main_Load);
            this.ribbonControl.ResumeLayout(false);
            this.ribbonControl.PerformLayout();
            this.ribbonPanel3.ResumeLayout(false);
            this.ribbonPanel1.ResumeLayout(false);
            this.tabStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonControl ribbonControl;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel1;
        private DevComponents.DotNetBar.RibbonBar rbbLop;
        private DevComponents.DotNetBar.RibbonTabItem ribtapQuanLy;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.QatCustomizeItem qatCustomizeItem1;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.Office2007StartButton buttonFile1;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.ItemContainer itemContainer2;
        private DevComponents.DotNetBar.ButtonItem btnDangNhap;
        private DevComponents.DotNetBar.ButtonItem btnDangXuat;
        private DevComponents.DotNetBar.ButtonItem btnDoiMatKhau;
        private DevComponents.DotNetBar.ButtonItem btnQLNguoiDung;
        private DevComponents.DotNetBar.ButtonItem btnThoat;
        private DevComponents.DotNetBar.RibbonBar rbbKhac;
        private DevComponents.DotNetBar.ButtonItem btnDanToc;
        private DevComponents.DotNetBar.RibbonBar rbbHocSinhGV;
        private DevComponents.DotNetBar.ButtonItem btnHocSinh;
        private DevComponents.DotNetBar.ButtonItem btnGiaoVien;
        private DevComponents.DotNetBar.ButtonItem btnPhanCong;
        private DevComponents.DotNetBar.RibbonBar rbbMonHoc;
        private DevComponents.DotNetBar.ButtonItem btnMonHoc;
        private DevComponents.DotNetBar.ButtonItem btnDiem;
        private DevComponents.DotNetBar.RibbonBar rbbNamHoc;
        private DevComponents.DotNetBar.ButtonItem btnHocKy;
        private DevComponents.DotNetBar.ButtonItem btnNamHoc;
        private DevComponents.DotNetBar.ButtonItem btnLopHoc;
        private DevComponents.DotNetBar.ButtonItem btnKhoiLop;
        private DevComponents.DotNetBar.ButtonItem btnTonGiao;
        private DevComponents.DotNetBar.ButtonItem btnNgheNghiep;
        private DevComponents.DotNetBar.ButtonItem btnLoaiDiem;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel3;
        private DevComponents.DotNetBar.RibbonBar rbbTCHocSinh;
        private DevComponents.DotNetBar.RibbonBar rbbTCGiaoVien;
        private DevComponents.DotNetBar.RibbonTabItem rbtTraCuu;
        private DevComponents.DotNetBar.ButtonItem btnTCHocSinh;
        private DevComponents.DotNetBar.ButtonItem btnTCGiaoVien;
        private DevComponents.DotNetBar.TabStrip tabStrip1;
        private DevComponents.DotNetBar.TabItem tabItem1;
        private DevComponents.DotNetBar.ButtonItem btnPhanLop;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.RibbonBar rbbQuyDinh;
        private DevComponents.DotNetBar.ButtonItem btnQuyDinh;
    }
}