﻿namespace QuanLyHocSinhTHPT.GUI
{
    partial class F_DanToc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_DanToc));
            this.groupBoxDanhSach = new System.Windows.Forms.GroupBox();
            this.dGVDanToc = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colMaDanToc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDanToc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorDanToc = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorExitItem = new System.Windows.Forms.ToolStripButton();
            this.groupBoxDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDanToc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorDanToc)).BeginInit();
            this.bindingNavigatorDanToc.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDanhSach
            // 
            this.groupBoxDanhSach.Controls.Add(this.dGVDanToc);
            this.groupBoxDanhSach.Controls.Add(this.bindingNavigatorDanToc);
            this.groupBoxDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDanhSach.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDanhSach.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxDanhSach.Name = "groupBoxDanhSach";
            this.groupBoxDanhSach.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxDanhSach.Size = new System.Drawing.Size(456, 449);
            this.groupBoxDanhSach.TabIndex = 2;
            this.groupBoxDanhSach.TabStop = false;
            this.groupBoxDanhSach.Text = "Danh sách dân tộc";
            // 
            // dGVDanToc
            // 
            this.dGVDanToc.AllowUserToAddRows = false;
            this.dGVDanToc.AllowUserToResizeColumns = false;
            this.dGVDanToc.AllowUserToResizeRows = false;
            this.dGVDanToc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dGVDanToc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dGVDanToc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaDanToc,
            this.colTenDanToc});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVDanToc.DefaultCellStyle = dataGridViewCellStyle1;
            this.dGVDanToc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVDanToc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dGVDanToc.Location = new System.Drawing.Point(4, 62);
            this.dGVDanToc.Margin = new System.Windows.Forms.Padding(4);
            this.dGVDanToc.Name = "dGVDanToc";
            this.dGVDanToc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dGVDanToc.Size = new System.Drawing.Size(448, 383);
            this.dGVDanToc.TabIndex = 3;
            // 
            // colMaDanToc
            // 
            this.colMaDanToc.DataPropertyName = "MaDanToc";
            this.colMaDanToc.HeaderText = "Mã dân tộc";
            this.colMaDanToc.MaxInputLength = 6;
            this.colMaDanToc.Name = "colMaDanToc";
            this.colMaDanToc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colTenDanToc
            // 
            this.colTenDanToc.DataPropertyName = "TenDanToc";
            this.colTenDanToc.HeaderText = "Tên dân tộc";
            this.colTenDanToc.MaxInputLength = 30;
            this.colTenDanToc.Name = "colTenDanToc";
            this.colTenDanToc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colTenDanToc.Width = 210;
            // 
            // bindingNavigatorDanToc
            // 
            this.bindingNavigatorDanToc.AddNewItem = null;
            this.bindingNavigatorDanToc.AutoSize = false;
            this.bindingNavigatorDanToc.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorDanToc.CountItemFormat = "của {0}";
            this.bindingNavigatorDanToc.DeleteItem = null;
            this.bindingNavigatorDanToc.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigatorDanToc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorSaveItem,
            this.bindingNavigatorExitItem});
            this.bindingNavigatorDanToc.Location = new System.Drawing.Point(4, 19);
            this.bindingNavigatorDanToc.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorDanToc.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorDanToc.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorDanToc.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorDanToc.Name = "bindingNavigatorDanToc";
            this.bindingNavigatorDanToc.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorDanToc.Size = new System.Drawing.Size(448, 43);
            this.bindingNavigatorDanToc.TabIndex = 2;
            this.bindingNavigatorDanToc.RefreshItems += new System.EventHandler(this.bindingNavigatorDanToc_RefreshItems);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 40);
            this.bindingNavigatorCountItem.Text = "của {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Tổng số dòng trong danh sách";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 43);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Vị trí hiện tại";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 43);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 40);
            this.bindingNavigatorMoveFirstItem.Text = "Đến đầu danh sách";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 40);
            this.bindingNavigatorMovePreviousItem.Text = "Trở lại dòng trước";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 40);
            this.bindingNavigatorMoveNextItem.Text = "Tới dòng kế tiếp";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 40);
            this.bindingNavigatorMoveLastItem.Text = "Đến cuối danh sách";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 40);
            this.bindingNavigatorAddNewItem.Text = "Thêm";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click_1);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 40);
            this.bindingNavigatorDeleteItem.Text = "Xóa";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click_1);
            // 
            // bindingNavigatorSaveItem
            // 
            this.bindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorSaveItem.Image")));
            this.bindingNavigatorSaveItem.Name = "bindingNavigatorSaveItem";
            this.bindingNavigatorSaveItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 40);
            this.bindingNavigatorSaveItem.Text = "Lưu";
            this.bindingNavigatorSaveItem.Click += new System.EventHandler(this.bindingNavigatorSaveItem_Click_1);
            // 
            // bindingNavigatorExitItem
            // 
            this.bindingNavigatorExitItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorExitItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorExitItem.Image")));
            this.bindingNavigatorExitItem.Name = "bindingNavigatorExitItem";
            this.bindingNavigatorExitItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorExitItem.Size = new System.Drawing.Size(24, 40);
            this.bindingNavigatorExitItem.Text = "Thoát";
            this.bindingNavigatorExitItem.Click += new System.EventHandler(this.bindingNavigatorExitItem_Click_1);
            // 
            // F_DanToc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 449);
            this.Controls.Add(this.groupBoxDanhSach);
            this.Name = "F_DanToc";
            this.Text = "DÂN TỘC";
            this.Load += new System.EventHandler(this.F_DanToc_Load);
            this.groupBoxDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVDanToc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorDanToc)).EndInit();
            this.bindingNavigatorDanToc.ResumeLayout(false);
            this.bindingNavigatorDanToc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDanhSach;
        private DevComponents.DotNetBar.Controls.DataGridViewX dGVDanToc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDanToc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDanToc;
        private System.Windows.Forms.BindingNavigator bindingNavigatorDanToc;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorExitItem;
    }
}