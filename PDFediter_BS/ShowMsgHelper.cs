using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace PDFediter_BS
{
    public class ShowMsgHelper
    {
        public static void ExecuteScript(string scriptBody)
        {
            string scriptKey = "Somekey";
            Page p = HttpContext.Current.Handler as Page;
            p.ClientScript.RegisterStartupScript(typeof(string), scriptKey, scriptBody, true);
        }
        public static void AlterMsg(string message)
        {
            ExecuteScript(string.Format("showTipsMsg('{0}','2500','4');top.main.windowload();OpenClose;", message));
        }
        public static void Alter_Error(string message)
        {
            ExecuteScript(string.Format("showTipsMsg('{0}','5000','5');", message));
        }
        public static void Alter(string message)
        {
            System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE language='JaveScript'>alert('" + message + "')</SCRIPT>");
        }
    }
}