﻿using System;
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
        public static void ReplaceText(string strInAddress,string SourceText,string ReplaceText,string strOutAddress)
        {
            IO.checkDir(Path.GetDirectoryName(strOutAddress).ToString());
            string inname = Path.GetFileNameWithoutExtension(strInAddress);
            string outputFile = strOutAddress.ToString() + "\\" + inname + ".docx";

            Document doc = new Document(strInAddress.ToString());
            doc.Range.Replace(SourceText, ReplaceText, false, false);
            doc.Save(outputFile.ToString(), SaveFormat.Docx);
        }

        public static void ReplacePIC(string strInAddress, int intIndex, string strPicAddress, string strOutAddress)
        {
            IO.checkDir(Path.GetDirectoryName(strOutAddress).ToString());
            string inname = Path.GetFileNameWithoutExtension(strInAddress);
            string outputFileedit = strOutAddress.ToString() + "\\" + inname + ".docx";

            Document doc = new Document(strInAddress);
            DocumentBuilder builder = new DocumentBuilder(doc);
            NodeCollection shapes = doc.GetChildNodes(NodeType.Shape, true);
            int i = 0;
            foreach (Shape nshape in shapes)
            {
                i++;
                if(i==intIndex)
                {
                    nshape.ImageData.SetImage(strPicAddress);
                } 
            }
            doc.Save(outputFileedit, SaveFormat.Docx);
        }

        public static void ReplacePICtoText(string strInAddress, int intIndex ,string ReplaceText,string strOutAddress)
        {
            IO.checkDir(Path.GetDirectoryName(strOutAddress).ToString());
            string inname = Path.GetFileNameWithoutExtension(strInAddress);
            string outputFileedit = strOutAddress.ToString() + "\\" + inname + ".docx";

            Document doc = new Document(strInAddress);
            DocumentBuilder builder = new DocumentBuilder(doc);

            NodeCollection shapes = doc.GetChildNodes(NodeType.Shape, true);
            int i = 1;
            foreach(Shape shape in shapes)
            {
                if(shape.ShapeType==ShapeType.Image && i==intIndex)
                {
                    builder.MoveTo(shape);
                    builder.Write(ReplaceText);
                }
                i++;
            }
            shapes.Clear();
            doc.Save(outputFileedit, SaveFormat.Docx);
        }

        public static void ConvertDOCXtoPDF(string strInAddress,string strOutAddress)
        {
            IO.checkDir(Path.GetDirectoryName(strOutAddress).ToString());
            string inname = Path.GetFileNameWithoutExtension(strInAddress);
            string outputFileedit = strOutAddress.ToString() + "\\" + inname + ".pdf";

            Document doc = new Document(strInAddress);
            doc.Save(outputFileedit, SaveFormat.Pdf);
        }
    }
}