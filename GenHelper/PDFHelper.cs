using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Aspose.Pdf;

namespace GenHelper
{
    public class PDFHelper
    {
        public static void PDFReplacePIC(string strInAddress,int intIndex,string strPicAddress,string strOutAddress)
        {
            string outputFileedit = "";
            IO.checkDir(Path.GetDirectoryName(strOutAddress).ToString());
            string inname = Path.GetFileNameWithoutExtension(strInAddress);
            if (strOutAddress.Substring(strOutAddress.Length - 1, 1).ToString() != "\\")
            {
                outputFileedit = strOutAddress.ToString() + "\\" + inname + ".pdf";
            }
            else
            {
                outputFileedit = strOutAddress.ToString() + inname + ".pdf";
            }
            //string outputFileedit = strOutAddress.ToString() + "\\" + inname + ".pdf";

            Document pdfDocument = new Document(strInAddress);
            FileStream fs = new FileStream(strPicAddress, FileMode.Open);
            pdfDocument.Pages[1].Resources.Images.Replace(intIndex, fs);
            pdfDocument.Save(outputFileedit);
            fs.Close();
        }

        public static void ConvertPDFtoDOCX(string strInAddress, string strOutAddress)
        {
            string outputFile = "";
            IO.checkDir(Path.GetDirectoryName(strOutAddress).ToString());
            string inname = Path.GetFileNameWithoutExtension(strInAddress);
            if(strOutAddress.Substring(strOutAddress.Length-1,1).ToString()!="\\")
            {
                outputFile = strOutAddress.ToString() + "\\" + inname + ".docx";
            }
            else
            {
                outputFile = strOutAddress.ToString() + inname + ".docx";
            }
            Document pdfDocument = new Document(strInAddress);
            pdfDocument.Save(outputFile, SaveFormat.DocX);
        }
    }
}
