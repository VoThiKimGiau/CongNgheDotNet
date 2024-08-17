namespace QL_kho
{
    partial class frmChiTiet
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
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.labMSP = new System.Windows.Forms.Label();
            this.txtMSP = new System.Windows.Forms.TextBox();
            this.labSL = new System.Windows.Forms.Label();
            this.labMCT = new System.Windows.Forms.Label();
            this.txtMCT = new System.Windows.Forms.TextBox();
            this.txtMP = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.labMP = new System.Windows.Forms.Label();
            this.labDG = new System.Windows.Forms.Label();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            this.tabLayout = new System.Windows.Forms.TableLayoutPanel();
            this.txtDG = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            this.tabLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUpdate.Location = new System.Drawing.Point(251, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(93, 46);
            this.btnUpdate.TabIndex = 61;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDelete.Location = new System.Drawing.Point(130, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 46);
            this.btnDelete.TabIndex = 60;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // labMSP
            // 
            this.labMSP.AutoSize = true;
            this.labMSP.Location = new System.Drawing.Point(3, 56);
            this.labMSP.Name = "labMSP";
            this.labMSP.Size = new System.Drawing.Size(110, 21);
            this.labMSP.TabIndex = 8;
            this.labMSP.Text = "Mã sản phẩm";
            // 
            // txtMSP
            // 
            this.txtMSP.Location = new System.Drawing.Point(147, 59);
            this.txtMSP.Name = "txtMSP";
            this.txtMSP.Size = new System.Drawing.Size(128, 29);
            this.txtMSP.TabIndex = 9;
            // 
            // labSL
            // 
            this.labSL.AutoSize = true;
            this.labSL.Location = new System.Drawing.Point(281, 56);
            this.labSL.Name = "labSL";
            this.labSL.Size = new System.Drawing.Size(78, 21);
            this.labSL.TabIndex = 5;
            this.labSL.Text = "Số lượng";
            // 
            // labMCT
            // 
            this.labMCT.AutoSize = true;
            this.labMCT.Location = new System.Drawing.Point(3, 0);
            this.labMCT.Name = "labMCT";
            this.labMCT.Size = new System.Drawing.Size(88, 21);
            this.labMCT.TabIndex = 0;
            this.labMCT.Text = "Mã chi tiết";
            // 
            // txtMCT
            // 
            this.txtMCT.Location = new System.Drawing.Point(147, 3);
            this.txtMCT.Name = "txtMCT";
            this.txtMCT.Size = new System.Drawing.Size(128, 29);
            this.txtMCT.TabIndex = 1;
            // 
            // txtMP
            // 
            this.txtMP.Location = new System.Drawing.Point(559, 3);
            this.txtMP.Name = "txtMP";
            this.txtMP.Size = new System.Drawing.Size(100, 29);
            this.txtMP.TabIndex = 4;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPrint.Location = new System.Drawing.Point(480, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(93, 46);
            this.btnPrint.TabIndex = 64;
            this.btnPrint.Text = "In";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnClose.Location = new System.Drawing.Point(598, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(93, 46);
            this.btnClose.TabIndex = 63;
            this.btnClose.Text = "Home";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSave.Location = new System.Drawing.Point(371, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 46);
            this.btnSave.TabIndex = 62;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labMP
            // 
            this.labMP.AutoSize = true;
            this.labMP.Location = new System.Drawing.Point(463, 0);
            this.labMP.Name = "labMP";
            this.labMP.Size = new System.Drawing.Size(79, 21);
            this.labMP.TabIndex = 3;
            this.labMP.Text = "Mã phiếu";
            // 
            // labDG
            // 
            this.labDG.AutoSize = true;
            this.labDG.Location = new System.Drawing.Point(463, 56);
            this.labDG.Name = "labDG";
            this.labDG.Size = new System.Drawing.Size(69, 21);
            this.labDG.TabIndex = 6;
            this.labDG.Text = "Đơn giá";
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(366, 59);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(87, 29);
            this.txtSL.TabIndex = 10;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // dgvChiTiet
            // 
            this.dgvChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTiet.Location = new System.Drawing.Point(12, 231);
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.Size = new System.Drawing.Size(678, 217);
            this.dgvChiTiet.TabIndex = 66;
            this.dgvChiTiet.SelectionChanged += new System.EventHandler(this.dgvChiTiet_SelectionChanged);
            // 
            // tabLayout
            // 
            this.tabLayout.ColumnCount = 6;
            this.tabLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.72414F));
            this.tabLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.27586F));
            this.tabLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tabLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tabLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tabLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tabLayout.Controls.Add(this.labMSP, 0, 1);
            this.tabLayout.Controls.Add(this.txtMSP, 0, 1);
            this.tabLayout.Controls.Add(this.labSL, 0, 1);
            this.tabLayout.Controls.Add(this.labMCT, 0, 0);
            this.tabLayout.Controls.Add(this.txtMCT, 1, 0);
            this.tabLayout.Controls.Add(this.txtMP, 5, 0);
            this.tabLayout.Controls.Add(this.labMP, 4, 0);
            this.tabLayout.Controls.Add(this.labDG, 4, 1);
            this.tabLayout.Controls.Add(this.txtSL, 3, 1);
            this.tabLayout.Controls.Add(this.txtDG, 5, 1);
            this.tabLayout.Location = new System.Drawing.Point(12, 96);
            this.tabLayout.Name = "tabLayout";
            this.tabLayout.RowCount = 2;
            this.tabLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabLayout.Size = new System.Drawing.Size(679, 113);
            this.tabLayout.TabIndex = 65;
            // 
            // txtDG
            // 
            this.txtDG.Location = new System.Drawing.Point(559, 59);
            this.txtDG.Name = "txtDG";
            this.txtDG.Size = new System.Drawing.Size(100, 29);
            this.txtDG.TabIndex = 7;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnInsert.Location = new System.Drawing.Point(12, 12);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(93, 46);
            this.btnInsert.TabIndex = 59;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // frmChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(905, 464);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvChiTiet);
            this.Controls.Add(this.tabLayout);
            this.Controls.Add(this.btnInsert);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmChiTiet";
            this.Text = "frmChiTiet";
            this.Load += new System.EventHandler(this.frmChiTiet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            this.tabLayout.ResumeLayout(false);
            this.tabLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label labMSP;
        private System.Windows.Forms.TextBox txtMSP;
        private System.Windows.Forms.Label labSL;
        private System.Windows.Forms.Label labMCT;
        private System.Windows.Forms.TextBox txtMCT;
        private System.Windows.Forms.TextBox txtMP;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label labMP;
        private System.Windows.Forms.Label labDG;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.DataGridView dgvChiTiet;
        private System.Windows.Forms.TableLayoutPanel tabLayout;
        private System.Windows.Forms.TextBox txtDG;
        private System.Windows.Forms.Button btnInsert;
    }
}