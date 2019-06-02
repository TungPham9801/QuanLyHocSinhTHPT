namespace QuanLyHocSinhTHPT.GUI
{
    partial class F_PhanLop
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
            this.cmbKhoiLopMoi = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.lVLopCu = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.colMaHSCu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHoTenCu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageListPhanLop = new System.Windows.Forms.ImageList(this.components);
            this.cmbLopMoi = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.groupPanelLopMoi = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cmbNamHocMoi = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.panelConTren = new System.Windows.Forms.Panel();
            this.groupPanelLopCu = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cmbLopCu = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbKhoiLopCu = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbNamHocCu = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.colHoTenMoi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaHSMoi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lVLopMoi = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.btnLuu = new DevComponents.DotNetBar.ButtonX();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.btnChuyen = new DevComponents.DotNetBar.ButtonX();
            this.panelConPhai = new System.Windows.Forms.Panel();
            this.panelChaTrai = new System.Windows.Forms.Panel();
            this.splitContainerPhanLop = new System.Windows.Forms.SplitContainer();
            this.groupPanelLopMoi.SuspendLayout();
            this.panelConTren.SuspendLayout();
            this.groupPanelLopCu.SuspendLayout();
            this.panelConPhai.SuspendLayout();
            this.panelChaTrai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPhanLop)).BeginInit();
            this.splitContainerPhanLop.Panel1.SuspendLayout();
            this.splitContainerPhanLop.Panel2.SuspendLayout();
            this.splitContainerPhanLop.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbKhoiLopMoi
            // 
            this.cmbKhoiLopMoi.DisplayMember = "Text";
            this.cmbKhoiLopMoi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKhoiLopMoi.FormattingEnabled = true;
            this.cmbKhoiLopMoi.ItemHeight = 14;
            this.cmbKhoiLopMoi.Location = new System.Drawing.Point(160, 49);
            this.cmbKhoiLopMoi.Margin = new System.Windows.Forms.Padding(4);
            this.cmbKhoiLopMoi.Name = "cmbKhoiLopMoi";
            this.cmbKhoiLopMoi.Size = new System.Drawing.Size(160, 20);
            this.cmbKhoiLopMoi.TabIndex = 2;
            this.cmbKhoiLopMoi.SelectedIndexChanged += new System.EventHandler(this.cmbKhoiLopMoi_SelectedIndexChanged);
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(67, 12);
            this.labelX4.Margin = new System.Windows.Forms.Padding(4);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(76, 25);
            this.labelX4.TabIndex = 0;
            this.labelX4.Text = "Năm học:";
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(67, 86);
            this.labelX6.Margin = new System.Windows.Forms.Padding(4);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(76, 23);
            this.labelX6.TabIndex = 0;
            this.labelX6.Text = "Lớp:";
            // 
            // lVLopCu
            // 
            // 
            // 
            // 
            this.lVLopCu.Border.Class = "ListViewBorder";
            this.lVLopCu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lVLopCu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaHSCu,
            this.colHoTenCu});
            this.lVLopCu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lVLopCu.FullRowSelect = true;
            this.lVLopCu.Location = new System.Drawing.Point(0, 148);
            this.lVLopCu.Margin = new System.Windows.Forms.Padding(4);
            this.lVLopCu.Name = "lVLopCu";
            this.lVLopCu.Size = new System.Drawing.Size(489, 437);
            this.lVLopCu.SmallImageList = this.imageListPhanLop;
            this.lVLopCu.TabIndex = 2;
            this.lVLopCu.UseCompatibleStateImageBehavior = false;
            this.lVLopCu.View = System.Windows.Forms.View.Details;
            // 
            // colMaHSCu
            // 
            this.colMaHSCu.Text = "Mã học sinh";
            this.colMaHSCu.Width = 216;
            // 
            // colHoTenCu
            // 
            this.colHoTenCu.Text = "Họ và tên";
            this.colHoTenCu.Width = 267;
            // 
            // imageListPhanLop
            // 
            this.imageListPhanLop.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListPhanLop.ImageSize = new System.Drawing.Size(1, 18);
            this.imageListPhanLop.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // cmbLopMoi
            // 
            this.cmbLopMoi.DisplayMember = "Text";
            this.cmbLopMoi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLopMoi.FormattingEnabled = true;
            this.cmbLopMoi.ItemHeight = 14;
            this.cmbLopMoi.Location = new System.Drawing.Point(160, 86);
            this.cmbLopMoi.Margin = new System.Windows.Forms.Padding(4);
            this.cmbLopMoi.Name = "cmbLopMoi";
            this.cmbLopMoi.Size = new System.Drawing.Size(160, 20);
            this.cmbLopMoi.TabIndex = 3;
            this.cmbLopMoi.SelectedIndexChanged += new System.EventHandler(this.cmbLopMoi_SelectedIndexChanged);
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(67, 49);
            this.labelX5.Margin = new System.Windows.Forms.Padding(4);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(76, 28);
            this.labelX5.TabIndex = 0;
            this.labelX5.Text = "Khối lớp:";
            // 
            // groupPanelLopMoi
            // 
            this.groupPanelLopMoi.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelLopMoi.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelLopMoi.Controls.Add(this.cmbLopMoi);
            this.groupPanelLopMoi.Controls.Add(this.labelX5);
            this.groupPanelLopMoi.Controls.Add(this.cmbKhoiLopMoi);
            this.groupPanelLopMoi.Controls.Add(this.labelX4);
            this.groupPanelLopMoi.Controls.Add(this.cmbNamHocMoi);
            this.groupPanelLopMoi.Controls.Add(this.labelX6);
            this.groupPanelLopMoi.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelLopMoi.Location = new System.Drawing.Point(0, 0);
            this.groupPanelLopMoi.Margin = new System.Windows.Forms.Padding(4);
            this.groupPanelLopMoi.Name = "groupPanelLopMoi";
            this.groupPanelLopMoi.Size = new System.Drawing.Size(490, 148);
            // 
            // 
            // 
            this.groupPanelLopMoi.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelLopMoi.Style.BackColorGradientAngle = 90;
            this.groupPanelLopMoi.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelLopMoi.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelLopMoi.Style.BorderBottomWidth = 1;
            this.groupPanelLopMoi.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelLopMoi.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelLopMoi.Style.BorderLeftWidth = 1;
            this.groupPanelLopMoi.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelLopMoi.Style.BorderRightWidth = 1;
            this.groupPanelLopMoi.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelLopMoi.Style.BorderTopWidth = 1;
            this.groupPanelLopMoi.Style.CornerDiameter = 4;
            this.groupPanelLopMoi.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelLopMoi.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelLopMoi.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelLopMoi.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanelLopMoi.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanelLopMoi.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanelLopMoi.TabIndex = 4;
            this.groupPanelLopMoi.Text = "Thông tin lớp mới";
            // 
            // cmbNamHocMoi
            // 
            this.cmbNamHocMoi.DisplayMember = "Text";
            this.cmbNamHocMoi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNamHocMoi.FormattingEnabled = true;
            this.cmbNamHocMoi.ItemHeight = 14;
            this.cmbNamHocMoi.Location = new System.Drawing.Point(160, 12);
            this.cmbNamHocMoi.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNamHocMoi.Name = "cmbNamHocMoi";
            this.cmbNamHocMoi.Size = new System.Drawing.Size(160, 20);
            this.cmbNamHocMoi.TabIndex = 1;
            this.cmbNamHocMoi.SelectedIndexChanged += new System.EventHandler(this.cmbNamHocMoi_SelectedIndexChanged);
            // 
            // panelConTren
            // 
            this.panelConTren.Controls.Add(this.groupPanelLopCu);
            this.panelConTren.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelConTren.Location = new System.Drawing.Point(0, 0);
            this.panelConTren.Margin = new System.Windows.Forms.Padding(4);
            this.panelConTren.Name = "panelConTren";
            this.panelConTren.Size = new System.Drawing.Size(489, 148);
            this.panelConTren.TabIndex = 0;
            // 
            // groupPanelLopCu
            // 
            this.groupPanelLopCu.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelLopCu.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelLopCu.Controls.Add(this.cmbLopCu);
            this.groupPanelLopCu.Controls.Add(this.cmbKhoiLopCu);
            this.groupPanelLopCu.Controls.Add(this.cmbNamHocCu);
            this.groupPanelLopCu.Controls.Add(this.labelX3);
            this.groupPanelLopCu.Controls.Add(this.labelX2);
            this.groupPanelLopCu.Controls.Add(this.labelX1);
            this.groupPanelLopCu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanelLopCu.Location = new System.Drawing.Point(0, 0);
            this.groupPanelLopCu.Margin = new System.Windows.Forms.Padding(4);
            this.groupPanelLopCu.Name = "groupPanelLopCu";
            this.groupPanelLopCu.Size = new System.Drawing.Size(489, 148);
            // 
            // 
            // 
            this.groupPanelLopCu.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelLopCu.Style.BackColorGradientAngle = 90;
            this.groupPanelLopCu.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelLopCu.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelLopCu.Style.BorderBottomWidth = 1;
            this.groupPanelLopCu.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelLopCu.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelLopCu.Style.BorderLeftWidth = 1;
            this.groupPanelLopCu.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelLopCu.Style.BorderRightWidth = 1;
            this.groupPanelLopCu.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelLopCu.Style.BorderTopWidth = 1;
            this.groupPanelLopCu.Style.CornerDiameter = 4;
            this.groupPanelLopCu.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelLopCu.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelLopCu.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelLopCu.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanelLopCu.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanelLopCu.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanelLopCu.TabIndex = 1;
            this.groupPanelLopCu.Text = "Thông tin lớp cũ";
            // 
            // cmbLopCu
            // 
            this.cmbLopCu.DisplayMember = "Text";
            this.cmbLopCu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLopCu.FormattingEnabled = true;
            this.cmbLopCu.ItemHeight = 14;
            this.cmbLopCu.Location = new System.Drawing.Point(160, 86);
            this.cmbLopCu.Margin = new System.Windows.Forms.Padding(4);
            this.cmbLopCu.Name = "cmbLopCu";
            this.cmbLopCu.Size = new System.Drawing.Size(160, 20);
            this.cmbLopCu.TabIndex = 3;
            this.cmbLopCu.SelectedIndexChanged += new System.EventHandler(this.cmbLopCu_SelectedIndexChanged);
            // 
            // cmbKhoiLopCu
            // 
            this.cmbKhoiLopCu.DisplayMember = "Text";
            this.cmbKhoiLopCu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKhoiLopCu.FormattingEnabled = true;
            this.cmbKhoiLopCu.ItemHeight = 14;
            this.cmbKhoiLopCu.Location = new System.Drawing.Point(160, 49);
            this.cmbKhoiLopCu.Margin = new System.Windows.Forms.Padding(4);
            this.cmbKhoiLopCu.Name = "cmbKhoiLopCu";
            this.cmbKhoiLopCu.Size = new System.Drawing.Size(160, 20);
            this.cmbKhoiLopCu.TabIndex = 2;
            this.cmbKhoiLopCu.SelectedIndexChanged += new System.EventHandler(this.cmbKhoiLopCu_SelectedIndexChanged);
            // 
            // cmbNamHocCu
            // 
            this.cmbNamHocCu.DisplayMember = "Text";
            this.cmbNamHocCu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNamHocCu.FormattingEnabled = true;
            this.cmbNamHocCu.ItemHeight = 14;
            this.cmbNamHocCu.Location = new System.Drawing.Point(160, 12);
            this.cmbNamHocCu.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNamHocCu.Name = "cmbNamHocCu";
            this.cmbNamHocCu.Size = new System.Drawing.Size(160, 20);
            this.cmbNamHocCu.TabIndex = 1;
            this.cmbNamHocCu.SelectedIndexChanged += new System.EventHandler(this.cmbNamHocCu_SelectedIndexChanged);
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(67, 86);
            this.labelX3.Margin = new System.Windows.Forms.Padding(4);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(76, 23);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "Lớp:";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(67, 49);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(76, 28);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Khối lớp:";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(67, 12);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(76, 25);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Năm học:";
            // 
            // colHoTenMoi
            // 
            this.colHoTenMoi.Text = "Họ và tên";
            this.colHoTenMoi.Width = 267;
            // 
            // colMaHSMoi
            // 
            this.colMaHSMoi.Text = "Mã học sinh";
            this.colMaHSMoi.Width = 220;
            // 
            // lVLopMoi
            // 
            // 
            // 
            // 
            this.lVLopMoi.Border.Class = "ListViewBorder";
            this.lVLopMoi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lVLopMoi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaHSMoi,
            this.colHoTenMoi});
            this.lVLopMoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lVLopMoi.FullRowSelect = true;
            this.lVLopMoi.Location = new System.Drawing.Point(0, 148);
            this.lVLopMoi.Margin = new System.Windows.Forms.Padding(4);
            this.lVLopMoi.Name = "lVLopMoi";
            this.lVLopMoi.Size = new System.Drawing.Size(490, 437);
            this.lVLopMoi.SmallImageList = this.imageListPhanLop;
            this.lVLopMoi.TabIndex = 5;
            this.lVLopMoi.UseCompatibleStateImageBehavior = false;
            this.lVLopMoi.View = System.Windows.Forms.View.Details;
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThoat.Image = global::QuanLyHocSinhTHPT.Properties.Resources.closephanlop;
            this.btnThoat.Location = new System.Drawing.Point(12, 455);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(73, 68);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Tooltip = "Đóng bảng phân lớp";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLuu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLuu.Image = global::QuanLyHocSinhTHPT.Properties.Resources.luuchuyenlop;
            this.btnLuu.Location = new System.Drawing.Point(12, 369);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(73, 68);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Tooltip = "Lưu bảng phân lớp";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoa.Image = global::QuanLyHocSinhTHPT.Properties.Resources.xoachuyenlop;
            this.btnXoa.Location = new System.Drawing.Point(12, 283);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(73, 68);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Tooltip = "Xóa học sinh khỏi lớp mới";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnChuyen
            // 
            this.btnChuyen.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnChuyen.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnChuyen.Image = global::QuanLyHocSinhTHPT.Properties.Resources.chuyenlop;
            this.btnChuyen.Location = new System.Drawing.Point(12, 197);
            this.btnChuyen.Margin = new System.Windows.Forms.Padding(4);
            this.btnChuyen.Name = "btnChuyen";
            this.btnChuyen.Size = new System.Drawing.Size(73, 68);
            this.btnChuyen.TabIndex = 1;
            this.btnChuyen.Tooltip = "Chuyển lớp";
            this.btnChuyen.Click += new System.EventHandler(this.btnChuyen_Click);
            // 
            // panelConPhai
            // 
            this.panelConPhai.Controls.Add(this.btnThoat);
            this.panelConPhai.Controls.Add(this.btnLuu);
            this.panelConPhai.Controls.Add(this.btnXoa);
            this.panelConPhai.Controls.Add(this.btnChuyen);
            this.panelConPhai.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelConPhai.Location = new System.Drawing.Point(489, 0);
            this.panelConPhai.Margin = new System.Windows.Forms.Padding(4);
            this.panelConPhai.Name = "panelConPhai";
            this.panelConPhai.Size = new System.Drawing.Size(93, 585);
            this.panelConPhai.TabIndex = 3;
            // 
            // panelChaTrai
            // 
            this.panelChaTrai.Controls.Add(this.lVLopCu);
            this.panelChaTrai.Controls.Add(this.panelConTren);
            this.panelChaTrai.Controls.Add(this.panelConPhai);
            this.panelChaTrai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChaTrai.Location = new System.Drawing.Point(0, 0);
            this.panelChaTrai.Margin = new System.Windows.Forms.Padding(4);
            this.panelChaTrai.Name = "panelChaTrai";
            this.panelChaTrai.Size = new System.Drawing.Size(582, 585);
            this.panelChaTrai.TabIndex = 0;
            // 
            // splitContainerPhanLop
            // 
            this.splitContainerPhanLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerPhanLop.Location = new System.Drawing.Point(0, 0);
            this.splitContainerPhanLop.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainerPhanLop.Name = "splitContainerPhanLop";
            // 
            // splitContainerPhanLop.Panel1
            // 
            this.splitContainerPhanLop.Panel1.Controls.Add(this.panelChaTrai);
            // 
            // splitContainerPhanLop.Panel2
            // 
            this.splitContainerPhanLop.Panel2.Controls.Add(this.lVLopMoi);
            this.splitContainerPhanLop.Panel2.Controls.Add(this.groupPanelLopMoi);
            this.splitContainerPhanLop.Size = new System.Drawing.Size(1077, 585);
            this.splitContainerPhanLop.SplitterDistance = 582;
            this.splitContainerPhanLop.SplitterWidth = 5;
            this.splitContainerPhanLop.TabIndex = 1;
            // 
            // F_PhanLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 585);
            this.Controls.Add(this.splitContainerPhanLop);
            this.Name = "F_PhanLop";
            this.Text = "Phân Lớp";
            this.Load += new System.EventHandler(this.F_PhanLop_Load);
            this.groupPanelLopMoi.ResumeLayout(false);
            this.panelConTren.ResumeLayout(false);
            this.groupPanelLopCu.ResumeLayout(false);
            this.panelConPhai.ResumeLayout(false);
            this.panelChaTrai.ResumeLayout(false);
            this.splitContainerPhanLop.Panel1.ResumeLayout(false);
            this.splitContainerPhanLop.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPhanLop)).EndInit();
            this.splitContainerPhanLop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbKhoiLopMoi;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.ListViewEx lVLopCu;
        private System.Windows.Forms.ColumnHeader colMaHSCu;
        private System.Windows.Forms.ColumnHeader colHoTenCu;
        private System.Windows.Forms.ImageList imageListPhanLop;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbLopMoi;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelLopMoi;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbNamHocMoi;
        private System.Windows.Forms.Panel panelConTren;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelLopCu;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbLopCu;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbKhoiLopCu;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbNamHocCu;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.ColumnHeader colHoTenMoi;
        private System.Windows.Forms.ColumnHeader colMaHSMoi;
        private DevComponents.DotNetBar.Controls.ListViewEx lVLopMoi;
        private DevComponents.DotNetBar.ButtonX btnThoat;
        private DevComponents.DotNetBar.ButtonX btnLuu;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private DevComponents.DotNetBar.ButtonX btnChuyen;
        private System.Windows.Forms.Panel panelConPhai;
        private System.Windows.Forms.Panel panelChaTrai;
        private System.Windows.Forms.SplitContainer splitContainerPhanLop;
    }
}