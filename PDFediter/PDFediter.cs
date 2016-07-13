using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Spire.Pdf;
using org.apache.pdfbox.pdmodel;
using org.apache.pdfbox.util;
using Novacode;
using System.Diagnostics;

namespace PDFediter
{
    public partial class PDFediter : Form
    {
        public PDFediter()
        {
            InitializeComponent();
        }

        private void btnEditPDF_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PDF文件(*.pdf)|*.pdf";
            // Show save file dialog box
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                BaseFont bf = BaseFont.createFont("c:\\windows\\fonts\\msyh.ttc,1", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                //iTextSharp.text.Font FontChinese = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.NORMAL);
                //PdfReader reader = new PdfReader(ofd.FileName.ToString());
                //Document document = new Document(reader.getPageSize(1));
                //string pdfname = System.IO.Directory.GetCurrentDirectory() + @"\tempPDF\" + ofd.SafeFileName.ToString();
                //PdfWriter writer = PdfWriter.getInstance(document, new FileStream(pdfname, FileMode.Create));
                //document.Open();
                //PdfContentByte cb = new PdfContentByte(writer);
                //int pageNumber = 1;
                //PdfImportedPage page1 = writer.getImportedPage(reader, pageNumber);
                //cb.addTemplate(page1, 1f, 0, 0, 1f, reader.getPageSizeWithRotation(pageNumber).Width,reader.getPageSizeWithRotation(pageNumber).Height);
                ////cb.beginText();
                ////cb.setFontAndSize(bf, 12);
                ////cb.setTextMatrix(1, 1);
                ////cb.showText("jljljljljljkljl");
                ////cb.endText();
                //document.Close();
                //MessageBox.Show("ok!");
                // get input document
                PdfReader inputPdf = new PdfReader(ofd.FileName.ToString());
                // retrieve the total number of pages
                int pageCount = inputPdf.NumberOfPages;
                // load the input document
                Document inputDoc =
                    new Document(inputPdf.getPageSizeWithRotation(1));
                // create the filestream
                string outputFile = System.IO.Directory.GetCurrentDirectory() + @"\tempPDF\" + ofd.SafeFileName.ToString();
                using (FileStream fs = new FileStream(outputFile, FileMode.Create))
                {
                    int i = 3;
                    // create the output writer
                    PdfWriter outputWriter = PdfWriter.getInstance(inputDoc, fs);
                    inputDoc.Open();                
                    PdfContentByte cb1 = outputWriter.DirectContent;
                    // copy pages from input to output document
                    inputDoc.setPageSize(inputPdf.getPageSizeWithRotation(1));
                    inputDoc.newPage();
                    PdfImportedPage page =
                        outputWriter.getImportedPage(inputPdf, i);
                    int rotation = inputPdf.getPageRotation(i);
                    cb1.addTemplate(page, 1f, 0, 0, 1f, 0, 0);
                    cb1.beginText();
                    cb1.setFontAndSize(bf, 12);
                    cb1.setTextMatrix(1, 1);
                    cb1.showText("jljljljljljkljl");
                    cb1.endText();
                    inputDoc.Close();
                }
            }
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
                string outputFile = System.IO.Directory.GetCurrentDirectory() + @"\tempPDF\" + name + ".docx";
                PDDocument doc = null;
                doc = PDDocument.load(ofd.FileName.ToString());
                PDFTextStripper textStrip = new PDFTextStripper();
                string strPDFText = textStrip.getText(doc);
                doc.close();
                var wordDoc = DocX.Create(outputFile);
                wordDoc.InsertParagraph(strPDFText);
                wordDoc.Save();
            }
        }
    }
}
