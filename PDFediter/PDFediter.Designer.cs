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
            this.SuspendLayout();
            // 
            // btnConverttoWord
            // 
            this.btnConverttoWord.Location = new System.Drawing.Point(90, 12);
            this.btnConverttoWord.Name = "btnConverttoWord";
            this.btnConverttoWord.Size = new System.Drawing.Size(88, 23);
            this.btnConverttoWord.TabIndex = 1;
            this.btnConverttoWord.Text = "ConvertTOdoc";
            this.btnConverttoWord.UseVisualStyleBackColor = true;
            this.btnConverttoWord.Click += new System.EventHandler(this.btnConverttoWord_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(5, 181);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "ReplaceText";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnReplacePIC
            // 
            this.btnReplacePIC.Location = new System.Drawing.Point(9, 12);
            this.btnReplacePIC.Name = "btnReplacePIC";
            this.btnReplacePIC.Size = new System.Drawing.Size(75, 23);
            this.btnReplacePIC.TabIndex = 3;
            this.btnReplacePIC.Text = "ReplacePIC";
            this.btnReplacePIC.UseVisualStyleBackColor = true;
            this.btnReplacePIC.Click += new System.EventHandler(this.btnReplacePIC_Click);
            // 
            // btnReplacePICfromWord
            // 
            this.btnReplacePICfromWord.Location = new System.Drawing.Point(96, 181);
            this.btnReplacePICfromWord.Name = "btnReplacePICfromWord";
            this.btnReplacePICfromWord.Size = new System.Drawing.Size(85, 23);
            this.btnReplacePICfromWord.TabIndex = 4;
            this.btnReplacePICfromWord.Text = "ReplacePIC";
            this.btnReplacePICfromWord.UseVisualStyleBackColor = true;
            this.btnReplacePICfromWord.Click += new System.EventHandler(this.btnReplacePICfromWord_Click);
            // 
            // btnPICtoText
            // 
            this.btnPICtoText.Location = new System.Drawing.Point(187, 181);
            this.btnPICtoText.Name = "btnPICtoText";
            this.btnPICtoText.Size = new System.Drawing.Size(85, 23);
            this.btnPICtoText.TabIndex = 5;
            this.btnPICtoText.Text = "PICtoText";
            this.btnPICtoText.UseVisualStyleBackColor = true;
            this.btnPICtoText.Click += new System.EventHandler(this.btnPICtoText_Click);
            // 
            // btnDOCXtoPDF
            // 
            this.btnDOCXtoPDF.Location = new System.Drawing.Point(5, 210);
            this.btnDOCXtoPDF.Name = "btnDOCXtoPDF";
            this.btnDOCXtoPDF.Size = new System.Drawing.Size(85, 23);
            this.btnDOCXtoPDF.TabIndex = 6;
            this.btnDOCXtoPDF.Text = "DocxTOpdf";
            this.btnDOCXtoPDF.UseVisualStyleBackColor = true;
            this.btnDOCXtoPDF.Click += new System.EventHandler(this.btnDOCXtoPDF_Click);
            // 
            // PDFediter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnDOCXtoPDF);
            this.Controls.Add(this.btnPICtoText);
            this.Controls.Add(this.btnReplacePICfromWord);
            this.Controls.Add(this.btnReplacePIC);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnConverttoWord);
            this.Name = "PDFediter";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConverttoWord;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnReplacePIC;
        private System.Windows.Forms.Button btnReplacePICfromWord;
        private System.Windows.Forms.Button btnPICtoText;
        private System.Windows.Forms.Button btnDOCXtoPDF;
    }
}

