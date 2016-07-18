using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Aspose.Words;
using Aspose.Words.Drawing;

namespace PDFediter
{
    class WordHelper
    {
        public static void ReplaceText(string strInAddress, string SourceText, string ReplaceText, string strOutAddress)
        {
            string outputFile = "";
            IO.checkDir(Path.GetDirectoryName(strOutAddress).ToString());
            string inname = Path.GetFileNameWithoutExtension(strInAddress);
            //string outputFile = strOutAddress.ToString() + "\\" + inname + ".docx";
            if (strOutAddress.Substring(strOutAddress.Length - 1, 1).ToString() != "\\")
            {
                outputFile = strOutAddress.ToString() + "\\" + inname + ".docx";
            }
            else
            {
                outputFile = strOutAddress.ToString() + inname + ".docx";
            }

            Document doc = new Document(strInAddress.ToString());
            doc.Range.Replace(SourceText, ReplaceText, false, false);
            doc.Save(outputFile.ToString(), SaveFormat.Docx);
        }

        public static void ReplacePIC(string strInAddress, int intIndex, string strPicAddress, string strOutAddress)
        {
            string outputFileedit = "";
            IO.checkDir(Path.GetDirectoryName(strOutAddress).ToString());
            string inname = Path.GetFileNameWithoutExtension(strInAddress);
            //string outputFileedit = strOutAddress.ToString() + "\\" + inname + ".docx";
            if (strOutAddress.Substring(strOutAddress.Length - 1, 1).ToString() != "\\")
            {
                outputFileedit = strOutAddress.ToString() + "\\" + inname + ".docx";
            }
            else
            {
                outputFileedit = strOutAddress.ToString() + inname + ".docx";
            }
            Document doc = new Document(strInAddress);
            DocumentBuilder builder = new DocumentBuilder(doc);
            NodeCollection shapes = doc.GetChildNodes(NodeType.Shape, true);
            int i = 0;
            foreach (Shape nshape in shapes)
            {
                i++;
                if (i == intIndex)
                {
                    nshape.ImageData.SetImage(strPicAddress);
                }
            }
            doc.Save(outputFileedit, SaveFormat.Docx);
        }

        public static void ReplacePICtoText(string strInAddress, int intIndex, string ReplaceText, string strOutAddress)
        {
            string outputFileedit = "";
            IO.checkDir(Path.GetDirectoryName(strOutAddress).ToString());
            string inname = Path.GetFileNameWithoutExtension(strInAddress);
            //string outputFileedit = strOutAddress.ToString() + "\\" + inname + ".docx";
            if (strOutAddress.Substring(strOutAddress.Length - 1, 1).ToString() != "\\")
            {
                outputFileedit = strOutAddress.ToString() + "\\" + inname + ".docx";
            }
            else
            {
                outputFileedit = strOutAddress.ToString() + inname + ".docx";
            }
            Document doc = new Document(strInAddress);
            DocumentBuilder builder = new DocumentBuilder(doc);

            NodeCollection shapes = doc.GetChildNodes(NodeType.Shape, true);
            int i = 1;
            foreach (Shape shape in shapes)
            {
                if (shape.ShapeType == ShapeType.Image && i == intIndex)
                {
                    builder.MoveTo(shape);
                    builder.Write(ReplaceText);
                }
                i++;
            }
            shapes.Clear();
            doc.Save(outputFileedit, SaveFormat.Docx);
        }

        public static void ConvertDOCXtoPDF(string strInAddress, string strOutAddress)
        {
            string outputFileedit = "";
            IO.checkDir(Path.GetDirectoryName(strOutAddress).ToString());
            string inname = Path.GetFileNameWithoutExtension(strInAddress);
            //string outputFileedit = strOutAddress.ToString() + "\\" + inname + ".pdf";
            if (strOutAddress.Substring(strOutAddress.Length - 1, 1).ToString() != "\\")
            {
                outputFileedit = strOutAddress.ToString() + "\\" + inname + ".pdf";
            }
            else
            {
                outputFileedit = strOutAddress.ToString() + inname + ".pdf";
            }
            Document doc = new Document(strInAddress);
            doc.Save(outputFileedit, SaveFormat.Pdf);
        }

        public static void TestPIC(string strInAddress, string strPicAddress, string strOutAddress)
        {
            string outputFileedit = "";
            IO.checkDir(Path.GetDirectoryName(strOutAddress).ToString());
            string inname = Path.GetFileNameWithoutExtension(strInAddress);
            string strTestPICAddress = "";
            //string outputFileedit = strOutAddress.ToString() + "\\" + inname + ".docx";
            if (strOutAddress.Substring(strOutAddress.Length - 1, 1).ToString() != "\\")
            {
                outputFileedit = strOutAddress.ToString() + "\\" + inname + ".docx";
            }
            else
            {
                outputFileedit = strOutAddress.ToString() + inname + ".docx";
            }
            Document doc = new Document(strInAddress);
            DocumentBuilder builder = new DocumentBuilder(doc);
            NodeCollection shapes = doc.GetChildNodes(NodeType.Shape, true);
            int i = 0;
            foreach (Shape nshape in shapes)
            {
                i++;
                if(i==10)
                {
                    i = 0;
                }
                strTestPICAddress = strPicAddress + i + ".jpg";
                nshape.ImageData.SetImage(strTestPICAddress);
            }
            doc.Save(outputFileedit, SaveFormat.Docx);
        }
    }
}
