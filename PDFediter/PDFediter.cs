using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//using Spire.Pdf;
//using Aspose.Pdf;
//using Aspose.Words;
using System.Diagnostics;

namespace PDFediter
{
    public partial class PDFediter : Form
    {
        public PDFediter()
        {
            InitializeComponent();
        }

        private void btnConverttoWord_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PDF文件(*.pdf)|*.pdf";
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    //Aspose.Pdf.Document pdfDocument = new Aspose.Pdf.Document(ofd.FileName.ToString());
                    //pdfDocument.Save(outputFile, Aspose.Pdf.SaveFormat.DocX);
                    string output = "";
                    FolderBrowserDialog dilog = new FolderBrowserDialog();
                    dilog.Description = "请输出文件夹";
                    if (dilog.ShowDialog() == DialogResult.OK || dilog.ShowDialog() == DialogResult.Yes)
                    {
                        output = dilog.SelectedPath;
                    }
                    PDFHelper.ConvertPDFtoDOCX(ofd.FileName.ToString(), output);

                    //System.Diagnostics.Process.Start(outputFile);
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "doc(*.docx)|*.docx";
            // Show save file dialog box
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    //Aspose.Words.Document doc = new Aspose.Words.Document(ofd.FileName.ToString());
                    //doc.Range.Replace("保誠", "XX", false, false);
                    //doc.Save(ofd.FileName.ToString(), Aspose.Words.SaveFormat.Docx); 
                    string output = "";
                    FolderBrowserDialog dilog = new FolderBrowserDialog();
                    dilog.Description = "请输出文件夹";
                    if (dilog.ShowDialog() == DialogResult.OK || dilog.ShowDialog() == DialogResult.Yes)
                    {
                        output = dilog.SelectedPath;
                    }
                    WordHelper.ReplaceText(ofd.FileName.ToString(), "保誠", "XX", output);

                    //System.Diagnostics.Process.Start(ofd.FileName.ToString());
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void btnReplacePIC_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PDF文件(*.pdf)|*.pdf";
            // Show save file dialog box
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    OpenFileDialog ofgIm = new OpenFileDialog();
                    ofgIm.Filter = ".JPG(*.JPG)|*.jpg";
                    DialogResult ofgresult = ofgIm.ShowDialog();
                    if (ofgresult == DialogResult.OK)
                    {
                        //Aspose.Pdf.Document pdfDocument = new Aspose.Pdf.Document(ofd.FileName.ToString());
                        //pdfDocument.Pages[1].Resources.Images.Replace(1, new FileStream(ofgIm.FileName.ToString(), FileMode.Open));
                        //pdfDocument.Save(outputFileedit);
                        //System.Diagnostics.Process.Start(outputFileedit);
                        string output = "";
                        FolderBrowserDialog dilog = new FolderBrowserDialog();
                        dilog.Description = "请输出文件夹";
                        if (dilog.ShowDialog() == DialogResult.OK || dilog.ShowDialog() == DialogResult.Yes)
                        {
                            output = dilog.SelectedPath;
                        }
                        PDFHelper.PDFReplacePIC(ofd.FileName.ToString(), 2, ofgIm.FileName.ToString(), output);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnReplacePICfromWord_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "doc(*.docx)|*.docx";
            // Show save file dialog box
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    OpenFileDialog ofgIm = new OpenFileDialog();
                    ofgIm.Filter = ".JPG(*.JPG)|*.jpg";
                    DialogResult ofgresult = ofgIm.ShowDialog();
                    if (ofgresult == DialogResult.OK)
                    {
                        string output = "";
                        FolderBrowserDialog dilog = new FolderBrowserDialog();
                        dilog.Description = "请输出文件夹";
                        if (dilog.ShowDialog() == DialogResult.OK || dilog.ShowDialog() == DialogResult.Yes)
                        {
                            output = dilog.SelectedPath;
                        }
                        WordHelper.ReplacePIC(ofd.FileName.ToString(), 1, ofgIm.FileName.ToString(), output);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnPICtoText_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "doc(*.docx)|*.docx";
            // Show save file dialog box
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    string output = "";
                    FolderBrowserDialog dilog = new FolderBrowserDialog();
                    dilog.Description = "请输出文件夹";
                    if (dilog.ShowDialog() == DialogResult.OK || dilog.ShowDialog() == DialogResult.Yes)
                    {
                        output = dilog.SelectedPath;
                    }
                    WordHelper.ReplacePICtoText(ofd.FileName.ToString(), 1, "[xxxx]", output);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnDOCXtoPDF_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "doc(*.docx)|*.docx";
            // Show save file dialog box
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    string output = "";
                    FolderBrowserDialog dilog = new FolderBrowserDialog();
                    dilog.Description = "请输出文件夹";
                    if (dilog.ShowDialog() == DialogResult.OK || dilog.ShowDialog() == DialogResult.Yes)
                    {
                        output = dilog.SelectedPath;
                    }
                    WordHelper.ConvertDOCXtoPDF(ofd.FileName.ToString(), output);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
