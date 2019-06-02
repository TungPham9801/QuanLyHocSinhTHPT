namespace QuanLyHocSinhTHPT.GUI
{
    partial class F_QuyDinh
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
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnDongY = new DevComponents.DotNetBar.ButtonX();
            this.btnHuyBo = new DevComponents.DotNetBar.ButtonX();
            this.tabControlQuyDinh = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanelTruong = new DevComponents.DotNetBar.TabControlPanel();
            this.txtDiaChiTruong = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTenTruong = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX07 = new DevComponents.DotNetBar.LabelX();
            this.labelX06 = new DevComponents.DotNetBar.LabelX();
            this.tabItemTruong = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanelSiSo = new DevComponents.DotNetBar.TabControlPanel();
            this.txtSiSoCanTren = new DevComponents.Editors.IntegerInput();
            this.labelX02 = new DevComponents.DotNetBar.LabelX();
            this.txtSiSoCanDuoi = new DevComponents.Editors.IntegerInput();
            this.labelX01 = new DevComponents.DotNetBar.LabelX();
            this.tabItemSiSo = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanelThangDiem = new DevComponents.DotNetBar.TabControlPanel();
            this.ckbThang100 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.ckbThang10 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.labelX05 = new DevComponents.DotNetBar.LabelX();
            this.tabItemThangDiem = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanelDoTuoi = new DevComponents.DotNetBar.TabControlPanel();
            this.txtDoTuoiCanTren = new DevComponents.Editors.IntegerInput();
            this.labelX04 = new DevComponents.DotNetBar.LabelX();
            this.txtDoTuoiCanDuoi = new DevComponents.Editors.IntegerInput();
            this.labelX03 = new DevComponents.DotNetBar.LabelX();
            this.tabItemDoTuoi = new DevComponents.DotNetBar.TabItem(this.components);
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlQuyDinh)).BeginInit();
            this.tabControlQuyDinh.SuspendLayout();
            this.tabControlPanelTruong.SuspendLayout();
            this.tabControlPanelSiSo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSiSoCanTren)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSiSoCanDuoi)).BeginInit();
            this.tabControlPanelThangDiem.SuspendLayout();
            this.tabControlPanelDoTuoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDoTuoiCanTren)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDoTuoiCanDuoi)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btnDongY);
            this.panelBottom.Controls.Add(this.btnHuyBo);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 179);
            this.panelBottom.Margin = new System.Windows.Forms.Padding(4);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(458, 49);
            this.panelBottom.TabIndex = 2;
            // 
            // btnDongY
            // 
            this.btnDongY.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDongY.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDongY.Location = new System.Drawing.Point(219, 12);
            this.btnDongY.Margin = new System.Windows.Forms.Padding(4);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(93, 28);
            this.btnDongY.TabIndex = 3;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click_1);
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuyBo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHuyBo.Location = new System.Drawing.Point(320, 12);
            this.btnHuyBo.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(93, 28);
            this.btnHuyBo.TabIndex = 4;
            this.btnHuyBo.Text = "Hủy bỏ";
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click_1);
            // 
            // tabControlQuyDinh
            // 
            this.tabControlQuyDinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.tabControlQuyDinh.CanReorderTabs = true;
            this.tabControlQuyDinh.Controls.Add(this.tabControlPanelDoTuoi);
            this.tabControlQuyDinh.Controls.Add(this.tabControlPanelThangDiem);
            this.tabControlQuyDinh.Controls.Add(this.tabControlPanelTruong);
            this.tabControlQuyDinh.Controls.Add(this.tabControlPanelSiSo);
            this.tabControlQuyDinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlQuyDinh.Location = new System.Drawing.Point(0, 0);
            this.tabControlQuyDinh.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlQuyDinh.Name = "tabControlQuyDinh";
            this.tabControlQuyDinh.SelectedTabFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlQuyDinh.SelectedTabIndex = 0;
            this.tabControlQuyDinh.Size = new System.Drawing.Size(458, 179);
            this.tabControlQuyDinh.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Document;
            this.tabControlQuyDinh.TabIndex = 3;
            this.tabControlQuyDinh.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControlQuyDinh.Tabs.Add(this.tabItemSiSo);
            this.tabControlQuyDinh.Tabs.Add(this.tabItemDoTuoi);
            this.tabControlQuyDinh.Tabs.Add(this.tabItemThangDiem);
            this.tabControlQuyDinh.Tabs.Add(this.tabItemTruong);
            // 
            // tabControlPanelTruong
            // 
            this.tabControlPanelTruong.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.tabControlPanelTruong.Controls.Add(this.txtDiaChiTruong);
            this.tabControlPanelTruong.Controls.Add(this.txtTenTruong);
            this.tabControlPanelTruong.Controls.Add(this.labelX07);
            this.tabControlPanelTruong.Controls.Add(this.labelX06);
            this.tabControlPanelTruong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanelTruong.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanelTruong.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlPanelTruong.Name = "tabControlPanelTruong";
            this.tabControlPanelTruong.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanelTruong.Size = new System.Drawing.Size(458, 153);
            this.tabControlPanelTruong.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabControlPanelTruong.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanelTruong.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(157)))), ((int)(((byte)(189)))));
            this.tabControlPanelTruong.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanelTruong.Style.GradientAngle = 90;
            this.tabControlPanelTruong.TabIndex = 0;
            this.tabControlPanelTruong.TabItem = this.tabItemTruong;
            // 
            // txtDiaChiTruong
            // 
            // 
            // 
            // 
            this.txtDiaChiTruong.Border.Class = "TextBoxBorder";
            this.txtDiaChiTruong.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDiaChiTruong.Location = new System.Drawing.Point(133, 86);
            this.txtDiaChiTruong.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChiTruong.Name = "txtDiaChiTruong";
            this.txtDiaChiTruong.Size = new System.Drawing.Size(280, 22);
            this.txtDiaChiTruong.TabIndex = 2;
            // 
            // txtTenTruong
            // 
            // 
            // 
            // 
            this.txtTenTruong.Border.Class = "TextBoxBorder";
            this.txtTenTruong.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenTruong.Location = new System.Drawing.Point(133, 37);
            this.txtTenTruong.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenTruong.Name = "txtTenTruong";
            this.txtTenTruong.Size = new System.Drawing.Size(280, 22);
            this.txtTenTruong.TabIndex = 1;
            // 
            // labelX07
            // 
            this.labelX07.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX07.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX07.Location = new System.Drawing.Point(40, 86);
            this.labelX07.Margin = new System.Windows.Forms.Padding(4);
            this.labelX07.Name = "labelX07";
            this.labelX07.Size = new System.Drawing.Size(85, 25);
            this.labelX07.TabIndex = 0;
            this.labelX07.Text = "Địa chỉ:";
            // 
            // labelX06
            // 
            this.labelX06.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX06.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX06.Location = new System.Drawing.Point(40, 37);
            this.labelX06.Margin = new System.Windows.Forms.Padding(4);
            this.labelX06.Name = "labelX06";
            this.labelX06.Size = new System.Drawing.Size(85, 25);
            this.labelX06.TabIndex = 0;
            this.labelX06.Text = "Tên trường:";
            // 
            // tabItemTruong
            // 
            this.tabItemTruong.AttachedControl = this.tabControlPanelTruong;
            this.tabItemTruong.Name = "tabItemTruong";
            this.tabItemTruong.Text = "Thông tin Trường";
            // 
            // tabControlPanelSiSo
            // 
            this.tabControlPanelSiSo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.tabControlPanelSiSo.Controls.Add(this.txtSiSoCanTren);
            this.tabControlPanelSiSo.Controls.Add(this.labelX02);
            this.tabControlPanelSiSo.Controls.Add(this.txtSiSoCanDuoi);
            this.tabControlPanelSiSo.Controls.Add(this.labelX01);
            this.tabControlPanelSiSo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanelSiSo.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanelSiSo.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlPanelSiSo.Name = "tabControlPanelSiSo";
            this.tabControlPanelSiSo.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanelSiSo.Size = new System.Drawing.Size(458, 153);
            this.tabControlPanelSiSo.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabControlPanelSiSo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanelSiSo.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(157)))), ((int)(((byte)(189)))));
            this.tabControlPanelSiSo.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanelSiSo.Style.GradientAngle = 90;
            this.tabControlPanelSiSo.TabIndex = 0;
            this.tabControlPanelSiSo.TabItem = this.tabItemSiSo;
            // 
            // txtSiSoCanTren
            // 
            // 
            // 
            // 
            this.txtSiSoCanTren.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtSiSoCanTren.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSiSoCanTren.Location = new System.Drawing.Point(253, 86);
            this.txtSiSoCanTren.Margin = new System.Windows.Forms.Padding(4);
            this.txtSiSoCanTren.MaxValue = 100;
            this.txtSiSoCanTren.MinValue = 10;
            this.txtSiSoCanTren.Name = "txtSiSoCanTren";
            this.txtSiSoCanTren.ShowUpDown = true;
            this.txtSiSoCanTren.Size = new System.Drawing.Size(160, 22);
            this.txtSiSoCanTren.TabIndex = 2;
            this.txtSiSoCanTren.Value = 10;
            // 
            // labelX02
            // 
            this.labelX02.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX02.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX02.Location = new System.Drawing.Point(40, 86);
            this.labelX02.Margin = new System.Windows.Forms.Padding(4);
            this.labelX02.Name = "labelX02";
            this.labelX02.Size = new System.Drawing.Size(191, 25);
            this.labelX02.TabIndex = 0;
            this.labelX02.Text = "Sỉ số tối đa trong một lớp:";
            // 
            // txtSiSoCanDuoi
            // 
            // 
            // 
            // 
            this.txtSiSoCanDuoi.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtSiSoCanDuoi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSiSoCanDuoi.Location = new System.Drawing.Point(253, 37);
            this.txtSiSoCanDuoi.Margin = new System.Windows.Forms.Padding(4);
            this.txtSiSoCanDuoi.MaxValue = 100;
            this.txtSiSoCanDuoi.MinValue = 10;
            this.txtSiSoCanDuoi.Name = "txtSiSoCanDuoi";
            this.txtSiSoCanDuoi.ShowUpDown = true;
            this.txtSiSoCanDuoi.Size = new System.Drawing.Size(160, 22);
            this.txtSiSoCanDuoi.TabIndex = 1;
            this.txtSiSoCanDuoi.Value = 10;
            // 
            // labelX01
            // 
            this.labelX01.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX01.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX01.Location = new System.Drawing.Point(40, 37);
            this.labelX01.Margin = new System.Windows.Forms.Padding(4);
            this.labelX01.Name = "labelX01";
            this.labelX01.Size = new System.Drawing.Size(191, 25);
            this.labelX01.TabIndex = 0;
            this.labelX01.Text = "Sỉ số tối thiểu trong một lớp:";
            // 
            // tabItemSiSo
            // 
            this.tabItemSiSo.AttachedControl = this.tabControlPanelSiSo;
            this.tabItemSiSo.Name = "tabItemSiSo";
            this.tabItemSiSo.Text = "Sỉ số";
            // 
            // tabControlPanelThangDiem
            // 
            this.tabControlPanelThangDiem.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.tabControlPanelThangDiem.Controls.Add(this.ckbThang100);
            this.tabControlPanelThangDiem.Controls.Add(this.ckbThang10);
            this.tabControlPanelThangDiem.Controls.Add(this.labelX05);
            this.tabControlPanelThangDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanelThangDiem.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanelThangDiem.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlPanelThangDiem.Name = "tabControlPanelThangDiem";
            this.tabControlPanelThangDiem.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanelThangDiem.Size = new System.Drawing.Size(458, 153);
            this.tabControlPanelThangDiem.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabControlPanelThangDiem.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanelThangDiem.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(157)))), ((int)(((byte)(189)))));
            this.tabControlPanelThangDiem.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanelThangDiem.Style.GradientAngle = 90;
            this.tabControlPanelThangDiem.TabIndex = 0;
            this.tabControlPanelThangDiem.TabItem = this.tabItemThangDiem;
            // 
            // ckbThang100
            // 
            this.ckbThang100.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.ckbThang100.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ckbThang100.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.ckbThang100.Location = new System.Drawing.Point(40, 86);
            this.ckbThang100.Margin = new System.Windows.Forms.Padding(4);
            this.ckbThang100.Name = "ckbThang100";
            this.ckbThang100.Size = new System.Drawing.Size(155, 28);
            this.ckbThang100.TabIndex = 2;
            this.ckbThang100.Text = "Thang điểm 100";
            // 
            // ckbThang10
            // 
            this.ckbThang10.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.ckbThang10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ckbThang10.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.ckbThang10.Location = new System.Drawing.Point(40, 55);
            this.ckbThang10.Margin = new System.Windows.Forms.Padding(4);
            this.ckbThang10.Name = "ckbThang10";
            this.ckbThang10.Size = new System.Drawing.Size(155, 28);
            this.ckbThang10.TabIndex = 1;
            this.ckbThang10.Text = "Thang điểm 10";
            // 
            // labelX05
            // 
            this.labelX05.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX05.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX05.Location = new System.Drawing.Point(40, 25);
            this.labelX05.Margin = new System.Windows.Forms.Padding(4);
            this.labelX05.Name = "labelX05";
            this.labelX05.Size = new System.Drawing.Size(373, 25);
            this.labelX05.TabIndex = 0;
            this.labelX05.Text = "Thang điểm sử dụng để đánh giá kết quả học tập là:";
            // 
            // tabItemThangDiem
            // 
            this.tabItemThangDiem.AttachedControl = this.tabControlPanelThangDiem;
            this.tabItemThangDiem.Name = "tabItemThangDiem";
            this.tabItemThangDiem.Text = "Thang điểm";
            // 
            // tabControlPanelDoTuoi
            // 
            this.tabControlPanelDoTuoi.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.tabControlPanelDoTuoi.Controls.Add(this.txtDoTuoiCanTren);
            this.tabControlPanelDoTuoi.Controls.Add(this.labelX04);
            this.tabControlPanelDoTuoi.Controls.Add(this.txtDoTuoiCanDuoi);
            this.tabControlPanelDoTuoi.Controls.Add(this.labelX03);
            this.tabControlPanelDoTuoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanelDoTuoi.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanelDoTuoi.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlPanelDoTuoi.Name = "tabControlPanelDoTuoi";
            this.tabControlPanelDoTuoi.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanelDoTuoi.Size = new System.Drawing.Size(458, 153);
            this.tabControlPanelDoTuoi.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabControlPanelDoTuoi.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanelDoTuoi.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(157)))), ((int)(((byte)(189)))));
            this.tabControlPanelDoTuoi.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanelDoTuoi.Style.GradientAngle = 90;
            this.tabControlPanelDoTuoi.TabIndex = 0;
            this.tabControlPanelDoTuoi.TabItem = this.tabItemDoTuoi;
            // 
            // txtDoTuoiCanTren
            // 
            // 
            // 
            // 
            this.txtDoTuoiCanTren.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtDoTuoiCanTren.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDoTuoiCanTren.Location = new System.Drawing.Point(253, 86);
            this.txtDoTuoiCanTren.Margin = new System.Windows.Forms.Padding(4);
            this.txtDoTuoiCanTren.MaxValue = 40;
            this.txtDoTuoiCanTren.MinValue = 10;
            this.txtDoTuoiCanTren.Name = "txtDoTuoiCanTren";
            this.txtDoTuoiCanTren.ShowUpDown = true;
            this.txtDoTuoiCanTren.Size = new System.Drawing.Size(160, 22);
            this.txtDoTuoiCanTren.TabIndex = 2;
            this.txtDoTuoiCanTren.Value = 10;
            // 
            // labelX04
            // 
            this.labelX04.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX04.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX04.Location = new System.Drawing.Point(40, 86);
            this.labelX04.Margin = new System.Windows.Forms.Padding(4);
            this.labelX04.Name = "labelX04";
            this.labelX04.Size = new System.Drawing.Size(205, 25);
            this.labelX04.TabIndex = 0;
            this.labelX04.Text = "Độ tuổi tối đa của học sinh:";
            // 
            // txtDoTuoiCanDuoi
            // 
            // 
            // 
            // 
            this.txtDoTuoiCanDuoi.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtDoTuoiCanDuoi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDoTuoiCanDuoi.Location = new System.Drawing.Point(253, 37);
            this.txtDoTuoiCanDuoi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDoTuoiCanDuoi.MaxValue = 40;
            this.txtDoTuoiCanDuoi.MinValue = 10;
            this.txtDoTuoiCanDuoi.Name = "txtDoTuoiCanDuoi";
            this.txtDoTuoiCanDuoi.ShowUpDown = true;
            this.txtDoTuoiCanDuoi.Size = new System.Drawing.Size(160, 22);
            this.txtDoTuoiCanDuoi.TabIndex = 1;
            this.txtDoTuoiCanDuoi.Value = 10;
            // 
            // labelX03
            // 
            this.labelX03.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX03.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX03.Location = new System.Drawing.Point(40, 37);
            this.labelX03.Margin = new System.Windows.Forms.Padding(4);
            this.labelX03.Name = "labelX03";
            this.labelX03.Size = new System.Drawing.Size(205, 25);
            this.labelX03.TabIndex = 0;
            this.labelX03.Text = "Độ tuổi tối thiểu của học sinh:";
            // 
            // tabItemDoTuoi
            // 
            this.tabItemDoTuoi.AttachedControl = this.tabControlPanelDoTuoi;
            this.tabItemDoTuoi.Name = "tabItemDoTuoi";
            this.tabItemDoTuoi.Text = "Độ tuổi";
            // 
            // F_QuyDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 228);
            this.Controls.Add(this.tabControlQuyDinh);
            this.Controls.Add(this.panelBottom);
            this.Name = "F_QuyDinh";
            this.Text = "Quy Định";
            this.Load += new System.EventHandler(this.F_QuyDinh_Load);
            this.panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabControlQuyDinh)).EndInit();
            this.tabControlQuyDinh.ResumeLayout(false);
            this.tabControlPanelTruong.ResumeLayout(false);
            this.tabControlPanelSiSo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSiSoCanTren)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSiSoCanDuoi)).EndInit();
            this.tabControlPanelThangDiem.ResumeLayout(false);
            this.tabControlPanelDoTuoi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDoTuoiCanTren)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDoTuoiCanDuoi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBottom;
        private DevComponents.DotNetBar.ButtonX btnDongY;
        private DevComponents.DotNetBar.ButtonX btnHuyBo;
        private DevComponents.DotNetBar.TabControl tabControlQuyDinh;
        public DevComponents.DotNetBar.TabControlPanel tabControlPanelDoTuoi;
        private DevComponents.Editors.IntegerInput txtDoTuoiCanTren;
        private DevComponents.DotNetBar.LabelX labelX04;
        private DevComponents.Editors.IntegerInput txtDoTuoiCanDuoi;
        private DevComponents.DotNetBar.LabelX labelX03;
        private DevComponents.DotNetBar.TabItem tabItemDoTuoi;
        public DevComponents.DotNetBar.TabControlPanel tabControlPanelThangDiem;
        private DevComponents.DotNetBar.Controls.CheckBoxX ckbThang100;
        private DevComponents.DotNetBar.Controls.CheckBoxX ckbThang10;
        private DevComponents.DotNetBar.LabelX labelX05;
        private DevComponents.DotNetBar.TabItem tabItemThangDiem;
        public DevComponents.DotNetBar.TabControlPanel tabControlPanelTruong;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDiaChiTruong;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenTruong;
        private DevComponents.DotNetBar.LabelX labelX07;
        private DevComponents.DotNetBar.LabelX labelX06;
        private DevComponents.DotNetBar.TabItem tabItemTruong;
        public DevComponents.DotNetBar.TabControlPanel tabControlPanelSiSo;
        private DevComponents.Editors.IntegerInput txtSiSoCanTren;
        private DevComponents.DotNetBar.LabelX labelX02;
        private DevComponents.Editors.IntegerInput txtSiSoCanDuoi;
        private DevComponents.DotNetBar.LabelX labelX01;
        private DevComponents.DotNetBar.TabItem tabItemSiSo;
    }
}