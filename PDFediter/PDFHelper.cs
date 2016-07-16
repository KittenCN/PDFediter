using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Aspose.Pdf;

namespace PDFediter
{
    class PDFHelper
    {
        public static void PDFReplacePIC(string strInAddress,int intIndex,string strPicAddress,string strOutAddress)
        {
            IO.checkDir(Path.GetDirectoryName(strOutAddress).ToString());
            string inname = Path.GetFileNameWithoutExtension(strInAddress);
            string outputFileedit = strOutAddress.ToString() + "\\" + inname + ".pdf";

            Document pdfDocument = new Document(strInAddress);
            FileStream fs = new FileStream(strPicAddress, FileMode.Open);
            pdfDocument.Pages[1].Resources.Images.Replace(intIndex, fs);
            pdfDocument.Save(outputFileedit);
            fs.Close();
        }

        public static void ConvertPDFtoDOCX(string strInAddress, string strOutAddress)
        {
            IO.checkDir(Path.GetDirectoryName(strOutAddress).ToString());
            string inname = Path.GetFileNameWithoutExtension(strInAddress);
            string outputFile = strOutAddress.ToString() + "\\" + inname + ".docx";

            Document pdfDocument = new Document(strInAddress);
            pdfDocument.Save(outputFile, SaveFormat.DocX);
        }
    }
}
