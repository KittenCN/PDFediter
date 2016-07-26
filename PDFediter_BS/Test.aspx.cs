using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GenHelper;

namespace PDFediter_BS
{   
    public partial class Test : System.Web.UI.Page
    {
        public static string strDownLoadFileName = "";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnFileInput_Click(object sender, EventArgs e)
        {
            if(FileInput.PostedFile!=null && FileInput.PostedFile.ContentLength>0)
            {
                string strFileName = System.IO.Path.GetFileName(FileInput.PostedFile.FileName);
                string strUploadFile = Server.MapPath("Upload") + "\\" + strFileName;
                try
                {
                    FileInput.PostedFile.SaveAs(strUploadFile);
                    if(ProcessPDF(strUploadFile))
                    {
                        btnFileDownload.Enabled = true;
                        ShowMsgHelper.Alter("Upload Success!");
                    }
                    else
                    {
                        ShowMsgHelper.Alter("Upload Error!");
                    }
                }
                catch(Exception ex)
                {
                    ShowMsgHelper.Alter("Errot: " + ex.ToString());
                }
            }
            else
            {
                ShowMsgHelper.Alter("Please select a file to upload!");
            }
        }

        private Boolean ProcessPDF(string strFileInput)
        {
            Boolean boolResult = false;
            string strFileName = System.IO.Path.GetFileNameWithoutExtension(strFileInput);
            strDownLoadFileName = strFileName;
            string strDownloadFolder = Server.MapPath("Download");
            try
            {
                PDFHelper.ConvertPDFtoDOCX(strFileInput, strDownloadFolder);
                boolResult = true;
            }
            catch(Exception ex)
            {
                boolResult = false;
            }
            return boolResult;
        }

        protected void btnFileDownload_Click(object sender, EventArgs e)
        {
            Response.ContentType = "application/x-zip-compressed";
            Response.AddHeader("Content-Disposition", "attachment;filename=" + strDownLoadFileName + ".docx");
            string filename = Server.MapPath("Download") + "\\" + strDownLoadFileName + ".docx";
            Response.TransmitFile(filename);
        }
    }
}