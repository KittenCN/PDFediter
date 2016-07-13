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
            this.btnEditPDF = new System.Windows.Forms.Button();
            this.btnConverttoWord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEditPDF
            // 
            this.btnEditPDF.Location = new System.Drawing.Point(12, 208);
            this.btnEditPDF.Name = "btnEditPDF";
            this.btnEditPDF.Size = new System.Drawing.Size(75, 23);
            this.btnEditPDF.TabIndex = 0;
            this.btnEditPDF.Text = "StartEdit";
            this.btnEditPDF.UseVisualStyleBackColor = true;
            this.btnEditPDF.Click += new System.EventHandler(this.btnEditPDF_Click);
            // 
            // btnConverttoWord
            // 
            this.btnConverttoWord.Location = new System.Drawing.Point(93, 208);
            this.btnConverttoWord.Name = "btnConverttoWord";
            this.btnConverttoWord.Size = new System.Drawing.Size(75, 23);
            this.btnConverttoWord.TabIndex = 1;
            this.btnConverttoWord.Text = "StartConvert";
            this.btnConverttoWord.UseVisualStyleBackColor = true;
            this.btnConverttoWord.Click += new System.EventHandler(this.btnConverttoWord_Click);
            // 
            // PDFediter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnConverttoWord);
            this.Controls.Add(this.btnEditPDF);
            this.Name = "PDFediter";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEditPDF;
        private System.Windows.Forms.Button btnConverttoWord;
    }
}

