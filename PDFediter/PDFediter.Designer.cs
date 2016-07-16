namespace PDFediter
{
    partial class PDFediter
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConverttoWord = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnReplacePIC = new System.Windows.Forms.Button();
            this.btnReplacePICfromWord = new System.Windows.Forms.Button();
            this.btnPICtoText = new System.Windows.Forms.Button();
            this.btnDOCXtoPDF = new System.Windows.Forms.Button();
            this.gb_test = new System.Windows.Forms.GroupBox();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.操作类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.源地址 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.目标地址 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.图片地址 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.图片索引 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.源字段 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.替换字段 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FLag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbOperationType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbInAddress = new System.Windows.Forms.TextBox();
            this.tbOutAddress = new System.Windows.Forms.TextBox();
            this.tbPicAddress = new System.Windows.Forms.TextBox();
            this.tbIntIndex = new System.Windows.Forms.TextBox();
            this.tbSourceText = new System.Windows.Forms.TextBox();
            this.tbReplaceText = new System.Windows.Forms.TextBox();
            this.btnInAddress = new System.Windows.Forms.Button();
            this.btnOutAddress = new System.Windows.Forms.Button();
            this.btnPicAddress = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.gb_test.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConverttoWord
            // 
            this.btnConverttoWord.Location = new System.Drawing.Point(91, 20);
            this.btnConverttoWord.Name = "btnConverttoWord";
            this.btnConverttoWord.Size = new System.Drawing.Size(88, 23);
            this.btnConverttoWord.TabIndex = 1;
            this.btnConverttoWord.Text = "ConvertTOdoc";
            this.btnConverttoWord.UseVisualStyleBackColor = true;
            this.btnConverttoWord.Click += new System.EventHandler(this.btnConverttoWord_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(10, 102);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "ReplaceText";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnReplacePIC
            // 
            this.btnReplacePIC.Location = new System.Drawing.Point(10, 20);
            this.btnReplacePIC.Name = "btnReplacePIC";
            this.btnReplacePIC.Size = new System.Drawing.Size(75, 23);
            this.btnReplacePIC.TabIndex = 3;
            this.btnReplacePIC.Text = "ReplacePIC";
            this.btnReplacePIC.UseVisualStyleBackColor = true;
            this.btnReplacePIC.Click += new System.EventHandler(this.btnReplacePIC_Click);
            // 
            // btnReplacePICfromWord
            // 
            this.btnReplacePICfromWord.Location = new System.Drawing.Point(101, 102);
            this.btnReplacePICfromWord.Name = "btnReplacePICfromWord";
            this.btnReplacePICfromWord.Size = new System.Drawing.Size(85, 23);
            this.btnReplacePICfromWord.TabIndex = 4;
            this.btnReplacePICfromWord.Text = "ReplacePIC";
            this.btnReplacePICfromWord.UseVisualStyleBackColor = true;
            this.btnReplacePICfromWord.Click += new System.EventHandler(this.btnReplacePICfromWord_Click);
            // 
            // btnPICtoText
            // 
            this.btnPICtoText.Location = new System.Drawing.Point(192, 102);
            this.btnPICtoText.Name = "btnPICtoText";
            this.btnPICtoText.Size = new System.Drawing.Size(85, 23);
            this.btnPICtoText.TabIndex = 5;
            this.btnPICtoText.Text = "PICtoText";
            this.btnPICtoText.UseVisualStyleBackColor = true;
            this.btnPICtoText.Click += new System.EventHandler(this.btnPICtoText_Click);
            // 
            // btnDOCXtoPDF
            // 
            this.btnDOCXtoPDF.Location = new System.Drawing.Point(10, 131);
            this.btnDOCXtoPDF.Name = "btnDOCXtoPDF";
            this.btnDOCXtoPDF.Size = new System.Drawing.Size(85, 23);
            this.btnDOCXtoPDF.TabIndex = 6;
            this.btnDOCXtoPDF.Text = "DocxTOpdf";
            this.btnDOCXtoPDF.UseVisualStyleBackColor = true;
            this.btnDOCXtoPDF.Click += new System.EventHandler(this.btnDOCXtoPDF_Click);
            // 
            // gb_test
            // 
            this.gb_test.Controls.Add(this.btnReplacePIC);
            this.gb_test.Controls.Add(this.btnDOCXtoPDF);
            this.gb_test.Controls.Add(this.btnConverttoWord);
            this.gb_test.Controls.Add(this.btnPICtoText);
            this.gb_test.Controls.Add(this.btnEdit);
            this.gb_test.Controls.Add(this.btnReplacePICfromWord);
            this.gb_test.Location = new System.Drawing.Point(12, 442);
            this.gb_test.Name = "gb_test";
            this.gb_test.Size = new System.Drawing.Size(306, 163);
            this.gb_test.TabIndex = 7;
            this.gb_test.TabStop = false;
            this.gb_test.Text = "TestGroup";
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.操作类型,
            this.源地址,
            this.目标地址,
            this.图片地址,
            this.图片索引,
            this.源字段,
            this.替换字段,
            this.FLag,
            this.id});
            this.dgvMain.Location = new System.Drawing.Point(13, 13);
            this.dgvMain.MultiSelect = false;
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowTemplate.Height = 23;
            this.dgvMain.Size = new System.Drawing.Size(748, 402);
            this.dgvMain.TabIndex = 8;
            this.dgvMain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellContentClick);
            // 
            // 操作类型
            // 
            this.操作类型.DataPropertyName = "OperationType";
            this.操作类型.HeaderText = "操作类型";
            this.操作类型.Name = "操作类型";
            this.操作类型.ReadOnly = true;
            // 
            // 源地址
            // 
            this.源地址.DataPropertyName = "InAddress";
            this.源地址.HeaderText = "源地址";
            this.源地址.Name = "源地址";
            this.源地址.ReadOnly = true;
            // 
            // 目标地址
            // 
            this.目标地址.DataPropertyName = "OutAddress";
            this.目标地址.HeaderText = "目标地址";
            this.目标地址.Name = "目标地址";
            this.目标地址.ReadOnly = true;
            // 
            // 图片地址
            // 
            this.图片地址.DataPropertyName = "PicAddress";
            this.图片地址.HeaderText = "图片地址";
            this.图片地址.Name = "图片地址";
            this.图片地址.ReadOnly = true;
            // 
            // 图片索引
            // 
            this.图片索引.DataPropertyName = "IntIndex";
            this.图片索引.HeaderText = "图片索引";
            this.图片索引.Name = "图片索引";
            this.图片索引.ReadOnly = true;
            // 
            // 源字段
            // 
            this.源字段.DataPropertyName = "SourceText";
            this.源字段.HeaderText = "源字段";
            this.源字段.Name = "源字段";
            this.源字段.ReadOnly = true;
            // 
            // 替换字段
            // 
            this.替换字段.DataPropertyName = "ReplaceText";
            this.替换字段.HeaderText = "替换字段";
            this.替换字段.Name = "替换字段";
            this.替换字段.ReadOnly = true;
            // 
            // FLag
            // 
            this.FLag.DataPropertyName = "Flag";
            this.FLag.HeaderText = "Flag";
            this.FLag.Name = "FLag";
            this.FLag.ReadOnly = true;
            this.FLag.Visible = false;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // cbOperationType
            // 
            this.cbOperationType.FormattingEnabled = true;
            this.cbOperationType.Location = new System.Drawing.Point(869, 38);
            this.cbOperationType.Name = "cbOperationType";
            this.cbOperationType.Size = new System.Drawing.Size(171, 20);
            this.cbOperationType.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(792, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "操作类型:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(792, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "源地址:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(792, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "目标地址:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(792, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "图片地址:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(792, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "图片索引:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(792, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "源字段:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(792, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "替换字段:";
            // 
            // tbInAddress
            // 
            this.tbInAddress.Location = new System.Drawing.Point(869, 64);
            this.tbInAddress.Name = "tbInAddress";
            this.tbInAddress.Size = new System.Drawing.Size(171, 21);
            this.tbInAddress.TabIndex = 17;
            // 
            // tbOutAddress
            // 
            this.tbOutAddress.Location = new System.Drawing.Point(869, 91);
            this.tbOutAddress.Name = "tbOutAddress";
            this.tbOutAddress.Size = new System.Drawing.Size(171, 21);
            this.tbOutAddress.TabIndex = 18;
            // 
            // tbPicAddress
            // 
            this.tbPicAddress.Location = new System.Drawing.Point(869, 118);
            this.tbPicAddress.Name = "tbPicAddress";
            this.tbPicAddress.Size = new System.Drawing.Size(171, 21);
            this.tbPicAddress.TabIndex = 19;
            // 
            // tbIntIndex
            // 
            this.tbIntIndex.Location = new System.Drawing.Point(869, 145);
            this.tbIntIndex.Name = "tbIntIndex";
            this.tbIntIndex.Size = new System.Drawing.Size(171, 21);
            this.tbIntIndex.TabIndex = 20;
            // 
            // tbSourceText
            // 
            this.tbSourceText.Location = new System.Drawing.Point(869, 169);
            this.tbSourceText.Name = "tbSourceText";
            this.tbSourceText.Size = new System.Drawing.Size(171, 21);
            this.tbSourceText.TabIndex = 21;
            // 
            // tbReplaceText
            // 
            this.tbReplaceText.Location = new System.Drawing.Point(869, 196);
            this.tbReplaceText.Name = "tbReplaceText";
            this.tbReplaceText.Size = new System.Drawing.Size(171, 21);
            this.tbReplaceText.TabIndex = 22;
            // 
            // btnInAddress
            // 
            this.btnInAddress.Location = new System.Drawing.Point(1047, 62);
            this.btnInAddress.Name = "btnInAddress";
            this.btnInAddress.Size = new System.Drawing.Size(33, 23);
            this.btnInAddress.TabIndex = 23;
            this.btnInAddress.Text = "...";
            this.btnInAddress.UseVisualStyleBackColor = true;
            this.btnInAddress.Click += new System.EventHandler(this.btnInAddress_Click);
            // 
            // btnOutAddress
            // 
            this.btnOutAddress.Location = new System.Drawing.Point(1047, 89);
            this.btnOutAddress.Name = "btnOutAddress";
            this.btnOutAddress.Size = new System.Drawing.Size(33, 23);
            this.btnOutAddress.TabIndex = 24;
            this.btnOutAddress.Text = "...";
            this.btnOutAddress.UseVisualStyleBackColor = true;
            this.btnOutAddress.Click += new System.EventHandler(this.btnOutAddress_Click);
            // 
            // btnPicAddress
            // 
            this.btnPicAddress.Location = new System.Drawing.Point(1047, 116);
            this.btnPicAddress.Name = "btnPicAddress";
            this.btnPicAddress.Size = new System.Drawing.Size(33, 23);
            this.btnPicAddress.TabIndex = 25;
            this.btnPicAddress.Text = "...";
            this.btnPicAddress.UseVisualStyleBackColor = true;
            this.btnPicAddress.Click += new System.EventHandler(this.btnPicAddress_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(843, 265);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 26;
            this.btnInsert.Text = "添加";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(924, 265);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1005, 265);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(1005, 318);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 29;
            this.btnRun.Text = "执行";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // PDFediter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 427);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnPicAddress);
            this.Controls.Add(this.btnOutAddress);
            this.Controls.Add(this.btnInAddress);
            this.Controls.Add(this.tbReplaceText);
            this.Controls.Add(this.tbSourceText);
            this.Controls.Add(this.tbIntIndex);
            this.Controls.Add(this.tbPicAddress);
            this.Controls.Add(this.tbOutAddress);
            this.Controls.Add(this.tbInAddress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbOperationType);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.gb_test);
            this.Name = "PDFediter";
            this.Text = "forPDFediter";
            this.Load += new System.EventHandler(this.PDFediter_Load);
            this.gb_test.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConverttoWord;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnReplacePIC;
        private System.Windows.Forms.Button btnReplacePICfromWord;
        private System.Windows.Forms.Button btnPICtoText;
        private System.Windows.Forms.Button btnDOCXtoPDF;
        private System.Windows.Forms.GroupBox gb_test;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.ComboBox cbOperationType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbInAddress;
        private System.Windows.Forms.TextBox tbOutAddress;
        private System.Windows.Forms.TextBox tbPicAddress;
        private System.Windows.Forms.TextBox tbIntIndex;
        private System.Windows.Forms.TextBox tbSourceText;
        private System.Windows.Forms.TextBox tbReplaceText;
        private System.Windows.Forms.Button btnInAddress;
        private System.Windows.Forms.Button btnOutAddress;
        private System.Windows.Forms.Button btnPicAddress;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.DataGridViewTextBoxColumn 操作类型;
        private System.Windows.Forms.DataGridViewTextBoxColumn 源地址;
        private System.Windows.Forms.DataGridViewTextBoxColumn 目标地址;
        private System.Windows.Forms.DataGridViewTextBoxColumn 图片地址;
        private System.Windows.Forms.DataGridViewTextBoxColumn 图片索引;
        private System.Windows.Forms.DataGridViewTextBoxColumn 源字段;
        private System.Windows.Forms.DataGridViewTextBoxColumn 替换字段;
        private System.Windows.Forms.DataGridViewTextBoxColumn FLag;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}

