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
using Spire.Pdf;
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
            // Show save file dialog box
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                string name = ofd.SafeFileName.ToString().Substring(0, ofd.SafeFileName.ToString().LastIndexOf("."));
                string outputFile = System.IO.Directory.GetCurrentDirectory() + @"\tempPDF\" + name + ".doc";
                string outputFileedit = System.IO.Directory.GetCurrentDirectory() + @"\tempPDF\" + name + "_edit.doc";
                string cmdFile = System.IO.Directory.GetCurrentDirectory() + @"\CMD\" + "pdftohtml.exe ";
                try
                {
                    PdfDocument pdf = new PdfDocument();
                    pdf.LoadFromFile(ofd.FileName.ToString());
                    pdf.SaveToFile(outputFile, FileFormat.DOC);

                    //Spire.Doc.Document doc = new Spire.Doc.Document();
                    //doc.LoadFromFile(outputFile, Spire.Doc.FileFormat.Doc);
                    //doc.Replace("保誠", "XX", false, false);
                    //doc.SaveToFile(outputFileedit, Spire.Doc.FileFormat.Doc);

                    System.Diagnostics.Process.Start(outputFileedit);
                }
                catch(Exception ex)
                {

                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "doc(*.doc)|*.doc";
            // Show save file dialog box
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                string name = ofd.SafeFileName.ToString().Substring(0, ofd.SafeFileName.ToString().LastIndexOf("."));
                //string outputFile = System.IO.Directory.GetCurrentDirectory() + @"\tempPDF\" + name + ".doc";
                string outputFileedit = System.IO.Directory.GetCurrentDirectory() + @"\tempPDF\" + name + "_edit.doc";
                //string cmdFile = System.IO.Directory.GetCurrentDirectory() + @"\CMD\" + "pdftohtml.exe ";
                try
                {
                    Spire.Doc.Document doc = new Spire.Doc.Document();
                    doc.LoadFromFile(ofd.FileName.ToString(), Spire.Doc.FileFormat.Doc);
                    doc.Replace("保誠", "XX", false, false);
                    doc.SaveToFile(outputFileedit, Spire.Doc.FileFormat.Doc);
                    System.Diagnostics.Process.Start(outputFileedit);
                }
                catch (Exception ex)
                {
                    
                }
            }
        }
    }
}
