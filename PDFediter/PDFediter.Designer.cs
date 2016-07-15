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
            this.SuspendLayout();
            // 
            // btnConverttoWord
            // 
            this.btnConverttoWord.Location = new System.Drawing.Point(21, 207);
            this.btnConverttoWord.Name = "btnConverttoWord";
            this.btnConverttoWord.Size = new System.Drawing.Size(75, 23);
            this.btnConverttoWord.TabIndex = 1;
            this.btnConverttoWord.Text = "StartConvert";
            this.btnConverttoWord.UseVisualStyleBackColor = true;
            this.btnConverttoWord.Click += new System.EventHandler(this.btnConverttoWord_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(126, 207);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "StartEdit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // PDFediter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnConverttoWord);
            this.Name = "PDFediter";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConverttoWord;
        private System.Windows.Forms.Button btnEdit;
    }
}

