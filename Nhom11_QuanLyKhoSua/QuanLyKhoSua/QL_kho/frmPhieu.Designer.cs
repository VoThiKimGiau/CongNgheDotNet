namespace QL_kho
{
    partial class frmPhieu
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
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.tabLayout = new System.Windows.Forms.TableLayoutPanel();
            this.txtTT = new System.Windows.Forms.TextBox();
            this.labDay = new System.Windows.Forms.Label();
            this.labMLP = new System.Windows.Forms.Label();
            this.txtMLP = new System.Windows.Forms.TextBox();
            this.labMP = new System.Windows.Forms.Label();
            this.txtMP = new System.Windows.Forms.TextBox();
            this.labTT = new System.Windows.Forms.Label();
            this.mktDay = new System.Windows.Forms.MaskedTextBox();
            this.dgvPhieu = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.tabLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPrint.Location = new System.Drawing.Point(480, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(93, 46);
            this.btnPrint.TabIndex = 40;
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
            this.btnClose.TabIndex = 39;
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
            this.btnSave.TabIndex = 38;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUpdate.Location = new System.Drawing.Point(251, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(93, 46);
            this.btnUpdate.TabIndex = 37;
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
            this.btnDelete.TabIndex = 36;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnInsert.Location = new System.Drawing.Point(12, 12);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(93, 46);
            this.btnInsert.TabIndex = 35;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // tabLayout
            // 
            this.tabLayout.ColumnCount = 4;
            this.tabLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.93413F));
            this.tabLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.06586F));
            this.tabLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 137F));
            this.tabLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 246F));
            this.tabLayout.Controls.Add(this.txtTT, 3, 1);
            this.tabLayout.Controls.Add(this.labDay, 0, 1);
            this.tabLayout.Controls.Add(this.labMLP, 2, 0);
            this.tabLayout.Controls.Add(this.txtMLP, 3, 0);
            this.tabLayout.Controls.Add(this.labMP, 0, 0);
            this.tabLayout.Controls.Add(this.txtMP, 1, 0);
            this.tabLayout.Controls.Add(this.labTT, 2, 1);
            this.tabLayout.Controls.Add(this.mktDay, 1, 1);
            this.tabLayout.Location = new System.Drawing.Point(12, 96);
            this.tabLayout.Name = "tabLayout";
            this.tabLayout.RowCount = 2;
            this.tabLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabLayout.Size = new System.Drawing.Size(679, 113);
            this.tabLayout.TabIndex = 41;
            // 
            // txtTT
            // 
            this.txtTT.Location = new System.Drawing.Point(435, 59);
            this.txtTT.Name = "txtTT";
            this.txtTT.Size = new System.Drawing.Size(185, 29);
            this.txtTT.TabIndex = 7;
            // 
            // labDay
            // 
            this.labDay.AutoSize = true;
            this.labDay.Location = new System.Drawing.Point(3, 56);
            this.labDay.Name = "labDay";
            this.labDay.Size = new System.Drawing.Size(49, 21);
            this.labDay.TabIndex = 5;
            this.labDay.Text = "Ngày";
            // 
            // labMLP
            // 
            this.labMLP.AutoSize = true;
            this.labMLP.Location = new System.Drawing.Point(298, 0);
            this.labMLP.Name = "labMLP";
            this.labMLP.Size = new System.Drawing.Size(110, 21);
            this.labMLP.TabIndex = 3;
            this.labMLP.Text = "Mã loại phiếu";
            // 
            // txtMLP
            // 
            this.txtMLP.Location = new System.Drawing.Point(435, 3);
            this.txtMLP.Name = "txtMLP";
            this.txtMLP.Size = new System.Drawing.Size(185, 29);
            this.txtMLP.TabIndex = 4;
            // 
            // labMP
            // 
            this.labMP.AutoSize = true;
            this.labMP.Location = new System.Drawing.Point(3, 0);
            this.labMP.Name = "labMP";
            this.labMP.Size = new System.Drawing.Size(79, 21);
            this.labMP.TabIndex = 0;
            this.labMP.Text = "Mã phiếu";
            // 
            // txtMP
            // 
            this.txtMP.Location = new System.Drawing.Point(100, 3);
            this.txtMP.Name = "txtMP";
            this.txtMP.Size = new System.Drawing.Size(163, 29);
            this.txtMP.TabIndex = 1;
            // 
            // labTT
            // 
            this.labTT.AutoSize = true;
            this.labTT.Location = new System.Drawing.Point(298, 56);
            this.labTT.Name = "labTT";
            this.labTT.Size = new System.Drawing.Size(81, 21);
            this.labTT.TabIndex = 6;
            this.labTT.Text = "Tổng tiền";
            // 
            // mktDay
            // 
            this.mktDay.Location = new System.Drawing.Point(100, 59);
            this.mktDay.Mask = "00/00/0000";
            this.mktDay.Name = "mktDay";
            this.mktDay.Size = new System.Drawing.Size(100, 29);
            this.mktDay.TabIndex = 2;
            this.mktDay.ValidatingType = typeof(System.DateTime);
            // 
            // dgvPhieu
            // 
            this.dgvPhieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieu.Location = new System.Drawing.Point(12, 231);
            this.dgvPhieu.Name = "dgvPhieu";
            this.dgvPhieu.Size = new System.Drawing.Size(678, 217);
            this.dgvPhieu.TabIndex = 42;
            this.dgvPhieu.SelectionChanged += new System.EventHandler(this.dgvPhieu_SelectionChanged);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // frmPhieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(837, 508);
            this.Controls.Add(this.dgvPhieu);
            this.Controls.Add(this.tabLayout);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmPhieu";
            this.Text = "Phiếu";
            this.Load += new System.EventHandler(this.frmPhieu_Load);
            this.tabLayout.ResumeLayout(false);
            this.tabLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TableLayoutPanel tabLayout;
        private System.Windows.Forms.TextBox txtTT;
        private System.Windows.Forms.Label labDay;
        private System.Windows.Forms.Label labMLP;
        private System.Windows.Forms.TextBox txtMLP;
        private System.Windows.Forms.Label labMP;
        private System.Windows.Forms.TextBox txtMP;
        private System.Windows.Forms.Label labTT;
        private System.Windows.Forms.MaskedTextBox mktDay;
        private System.Windows.Forms.DataGridView dgvPhieu;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}

