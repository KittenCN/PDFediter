﻿using System;
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
        public static string DBfile = ".\\DB\\BaseData.mdb";
        public static int intCurrentRow = 0;
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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            AccessHelper ah = new AccessHelper(DBfile);
            string strSQL = "insert into tabOperation(OperationType,InAddress,OutAddress,Flag) ";
            strSQL = strSQL + " values('" + cbOperationType.SelectedIndex.ToString() + "','" + tbInAddress.Text + "','" + tbOutAddress.Text +  "','1') ";
            ah.ExecuteNonQuery(strSQL);
            FlashData();
        }

        private void PDFediter_Load(object sender, EventArgs e)
        {
            btnADAdd.Enabled = false;
            btnADEdit.Enabled = false;
            btnADDelete.Enabled = false;

            cbOperationType.Items.Add("替换图片");
            cbOperationType.Items.Add("替换文字");

            tbIntIndex.KeyPress += tbIntIndex_KeyPress;
            cbOperationType.SelectedIndexChanged += CbOperationType_SelectedIndexChanged;
            dgvMain.SelectionChanged += DgvMain_SelectionChanged;
            
            dgvActionDetail.SelectionChanged += DgvActionDetail_SelectionChanged;

            cbOperationType.SelectedIndex = 0;

            FlashData();
        }

        private void DgvActionDetail_SelectionChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            if(dgvActionDetail.SelectedRows.Count!=0 && dgvActionDetail.CurrentRow.Cells["Oid"].Value.ToString()!=null && dgvActionDetail.CurrentRow.Cells["Oid"].Value.ToString()!="")
            {
                tbPicAddress.Text = dgvActionDetail.CurrentRow.Cells["图片地址"].Value.ToString();
                tbIntIndex.Text = dgvActionDetail.CurrentRow.Cells["图片索引"].Value.ToString();
                tbSourceText.Text = dgvActionDetail.CurrentRow.Cells["源字段"].Value.ToString();
                tbReplaceText.Text = dgvActionDetail.CurrentRow.Cells["替换字段"].Value.ToString();
                btnADAdd.Enabled = true;
                btnADEdit.Enabled = true;
                btnADDelete.Enabled = true;
            }
        }

        private void DgvMain_SelectionChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            if(dgvMain.SelectedRows.Count!=0 && dgvMain.CurrentRow.Cells["id"].Value.ToString() != null && dgvMain.CurrentRow.Cells["id"].Value.ToString() != "")
            {
                int RowIndex = dgvMain.CurrentRow.Index;
                intCurrentRow = RowIndex;
                tbInAddress.Text = dgvMain.CurrentRow.Cells["源地址"].Value.ToString();
                tbOutAddress.Text= dgvMain.CurrentRow.Cells["目标地址"].Value.ToString();
                switch (dgvMain.CurrentRow.Cells["操作类型"].Value.ToString())
                {
                    case "替换图片":
                        cbOperationType.SelectedIndex = 0;
                        tbPicAddress.Text = "";
                        tbIntIndex.Text = "";
                        tbSourceText.Text = "";
                        tbReplaceText.Text = "";
                        tbPicAddress.Enabled = true;
                        btnPicAddress.Enabled = true;
                        tbIntIndex.Enabled = true;
                        tbSourceText.Enabled = false;
                        tbReplaceText.Enabled = false;
                        btnADAdd.Enabled = true;
                        btnADEdit.Enabled = false;
                        btnADDelete.Enabled = false;
                        break;
                    case "替换文字":
                        cbOperationType.SelectedIndex = 1;
                        tbPicAddress.Text = "";
                        tbIntIndex.Text = "";
                        tbSourceText.Text = "";
                        tbReplaceText.Text = "";
                        tbPicAddress.Enabled = false;
                        btnPicAddress.Enabled = false;
                        tbIntIndex.Enabled = false;
                        tbSourceText.Enabled = true;
                        tbReplaceText.Enabled = true;
                        btnADAdd.Enabled = true;
                        btnADEdit.Enabled = false;
                        btnADDelete.Enabled = false;
                        break;
                    default:
                        tbPicAddress.Text = "";
                        tbIntIndex.Text = "";
                        tbSourceText.Text = "";
                        tbReplaceText.Text = "";
                        tbPicAddress.Enabled = false;
                        btnPicAddress.Enabled = false;
                        tbIntIndex.Enabled = false;
                        tbSourceText.Enabled = false;
                        tbReplaceText.Enabled = false;
                        btnADAdd.Enabled = false;
                        btnADEdit.Enabled = false;
                        btnADDelete.Enabled = false;
                        break;
                }
                AccessHelper ah = new AccessHelper(DBfile);
                string strSQL = "select ID,OID,PicAddress,IntIndex,SourceText,ReplaceText,OFlag from tabActionDetail where oflag='1' and oid=" + int.Parse(dgvMain.CurrentRow.Cells["id"].Value.ToString());
                DataTable dtSQL = ah.ReturnDataTable(strSQL);
                dgvActionDetail.DataSource = dtSQL;
                dgvActionDetail.Columns[0].Visible = false;
            }
        }

        private void CbOperationType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            switch (cbOperationType.SelectedIndex)
            {
                case 0:
                    tbPicAddress.Text = "";
                    tbIntIndex.Text = "";
                    tbSourceText.Text = "";
                    tbReplaceText.Text = "";
                    tbPicAddress.Enabled = true;
                    btnPicAddress.Enabled = true;
                    tbIntIndex.Enabled = true;
                    tbSourceText.Enabled = false;
                    tbReplaceText.Enabled = false;
                    break;
                case 1:
                    tbPicAddress.Text = "";
                    tbIntIndex.Text = "";
                    tbSourceText.Text = "";
                    tbReplaceText.Text = "";
                    tbPicAddress.Enabled = false;
                    btnPicAddress.Enabled = false;
                    tbIntIndex.Enabled = false;
                    tbSourceText.Enabled = true;
                    tbReplaceText.Enabled = true;
                    break;
                default:
                    tbPicAddress.Text = "";
                    tbIntIndex.Text = "";
                    tbSourceText.Text = "";
                    tbReplaceText.Text = "";
                    tbPicAddress.Enabled = false;
                    btnPicAddress.Enabled = false;
                    tbIntIndex.Enabled = false;
                    tbSourceText.Enabled = false;
                    tbReplaceText.Enabled = false;
                    break;
            }
        }

        private void FlashData()
        {
            AccessHelper ah = new AccessHelper(DBfile);
            string strSQL = "select id,OperationType,InAddress,OutAddress from tabOperation where Flag='1' order by id";
            DataTable dtSQL = ah.ReturnDataTable(strSQL);
            for (int i = 0; i < dtSQL.Rows.Count; i++)
            {
                switch (dtSQL.Rows[i]["OperationType"].ToString())
                {
                    case "0":
                        dtSQL.Rows[i]["OperationType"] = "替换图片";
                        break;
                    case "1":
                        dtSQL.Rows[i]["OperationType"] = "替换文字";
                        break;
                    default:
                        dtSQL.Rows[i]["OperationType"] = "--";
                        break;
                }
            }
            dgvMain.DataSource = dtSQL;
            strSQL = "select ID,OID,PicAddress,IntIndex,SourceText,ReplaceText,OFlag from tabActionDetail where oflag='1' and oid=" + int.Parse(dgvMain.CurrentRow.Cells["id"].Value.ToString());
            dtSQL = ah.ReturnDataTable(strSQL);
            dgvActionDetail.DataSource = dtSQL;
            dgvActionDetail.Columns[0].Visible = false;

            dgvMain.Rows[intCurrentRow].Selected = true;
        }

        private void btnInAddress_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dilog = new FolderBrowserDialog();
            dilog.Description = "请选择文件夹";
            if (dilog.ShowDialog() == DialogResult.OK || dilog.ShowDialog() == DialogResult.Yes)
            {
                tbInAddress.Text = dilog.SelectedPath;
            }
        }

        private void btnOutAddress_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dilog = new FolderBrowserDialog();
            dilog.Description = "请选择文件夹";
            if (dilog.ShowDialog() == DialogResult.OK || dilog.ShowDialog() == DialogResult.Yes)
            {
                tbOutAddress.Text = dilog.SelectedPath;
            }
        }

        private void btnPicAddress_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All Files(*.*)|*.*";
            // Show save file dialog box
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbPicAddress.Text = ofd.FileName.ToString();
            }
        }

        private void tbIntIndex_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void dgvMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DgvMain_SelectionChanged(null, null);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvMain.SelectedRows.Count != 0 && dgvMain.CurrentRow.Cells["id"].Value.ToString() != null && dgvMain.CurrentRow.Cells["id"].Value.ToString() != "")
            {
                AccessHelper ah = new AccessHelper(DBfile);
                //(OperationType,InAddress,OutAddress,PicAddress,IntIndex,SourceText,ReplaceText,Flag)
                string strSQL = "update tabOperation set ";
                strSQL = strSQL + " OperationType='" + cbOperationType.SelectedIndex.ToString() + "',InAddress='" + tbInAddress.Text + "',OutAddress='" + tbOutAddress.Text + "' ";
                strSQL = strSQL + " where flag='1' and id=" + dgvMain.CurrentRow.Cells["id"].Value.ToString();
                ah.ExecuteNonQuery(strSQL);
                FlashData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMain.SelectedRows.Count != 0 && dgvMain.CurrentRow.Cells["id"].Value.ToString() != null && dgvMain.CurrentRow.Cells["id"].Value.ToString() != "")
            {
                AccessHelper ah = new AccessHelper(DBfile);
                //(OperationType,InAddress,OutAddress,PicAddress,IntIndex,SourceText,ReplaceText,Flag)
                string strSQL = "update tabOperation set ";
                //strSQL = strSQL + " OperationType='" + cbOperationType.SelectedIndex.ToString() + "',InAddress='" + tbInAddress.Text + "',OutAddress='" + tbOutAddress.Text + "',PicAddress='" + tbPicAddress.Text + "',IntIndex='" + tbIntIndex.Text + "',SourceText='" + tbSourceText.Text + "',ReplaceText='" + tbReplaceText.Text + "' ";
                strSQL = strSQL + " Flag='0' where id=" + dgvMain.CurrentRow.Cells["id"].Value.ToString();
                ah.ExecuteNonQuery(strSQL);
                FlashData();
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string strInAddress = "";
            string strOutAddress = "";
            string strPicAddress = "";
            string strIntIndex = "";
            string strSourceText = "";
            string strReplaceText = "";
            string strTempAddress = "";
            for(int x=0;x<dgvMain.Rows.Count;x++)
            {
                AccessHelper ah = new AccessHelper(DBfile);
                string strSQL = "select * from tabActionDetail where oflag='1' and oid=" + dgvMain.Rows[x].Cells["id"].Value.ToString();
                DataTable dtSQL = ah.ReturnDataTable(strSQL);
                dgvActionDetail.DataSource = dtSQL;
                if(dtSQL.Rows.Count>0)
                {
                    for(int y=0;y<dtSQL.Rows.Count;y++)
                    {
                        switch (dgvMain.Rows[x].Cells["操作类型"].Value.ToString())
                        {
                            case "替换图片":
                                {
                                    strInAddress = dgvMain.Rows[x].Cells["源地址"].Value.ToString();
                                    strOutAddress = dgvMain.Rows[x].Cells["目标地址"].Value.ToString();
                                    strPicAddress = dgvActionDetail.Rows[y].Cells["图片地址"].Value.ToString();
                                    strIntIndex = dgvActionDetail.Rows[y].Cells["图片索引"].Value.ToString();
                                    strTempAddress = strInAddress + @"\tempout\";
                                    IO.checkDir(strInAddress);
                                    DirectoryInfo dir = new DirectoryInfo(strInAddress);
                                    FileInfo[] inf = dir.GetFiles();
                                    foreach (FileInfo finf in inf)
                                    {
                                        if (finf.Extension.Equals(".pdf"))
                                        {
                                            string inname = Path.GetFileNameWithoutExtension(finf.FullName.ToString());
                                            string docxFile = strTempAddress + inname + ".docx";
                                            PDFHelper.ConvertPDFtoDOCX(finf.FullName.ToString(), strTempAddress);
                                            WordHelper.ReplacePIC(docxFile, int.Parse(strIntIndex), strPicAddress, strTempAddress);
                                            WordHelper.ConvertDOCXtoPDF(docxFile, strOutAddress);
                                            System.Threading.Thread.Sleep(5000);
                                        }
                                    }
                                    break;
                                }
                            case "替换文字":
                                {
                                    strInAddress = dgvMain.Rows[x].Cells["源地址"].Value.ToString();
                                    strOutAddress = dgvMain.Rows[x].Cells["目标地址"].Value.ToString();
                                    strSourceText = dgvActionDetail.Rows[y].Cells["源字段"].Value.ToString();
                                    strReplaceText = dgvActionDetail.Rows[y].Cells["替换字段"].Value.ToString();
                                    strTempAddress = strInAddress + @"\tempout\";
                                    IO.checkDir(strInAddress);
                                    DirectoryInfo dir = new DirectoryInfo(strInAddress);
                                    FileInfo[] inf = dir.GetFiles();
                                    foreach (FileInfo finf in inf)
                                    {
                                        if (finf.Extension.Equals(".pdf"))
                                        {
                                            string inname = Path.GetFileNameWithoutExtension(finf.FullName.ToString());
                                            string docxFile = strTempAddress + inname + ".docx";
                                            PDFHelper.ConvertPDFtoDOCX(finf.FullName.ToString(), strTempAddress);
                                            WordHelper.ReplaceText(docxFile, strSourceText, strReplaceText, strTempAddress);
                                            WordHelper.ConvertDOCXtoPDF(docxFile, strOutAddress);
                                            System.Threading.Thread.Sleep(5000);
                                        }
                                    }
                                    break;
                                }
                            default:
                                {
                                    break;
                                }
                        }
                    }
                }
            }
            MessageBox.Show("已完成所有列表执行动作.");
        }

        private void btnADAdd_Click(object sender, EventArgs e)
        {
            AccessHelper ah = new AccessHelper(DBfile);
            string strSQL = "insert into tabActionDetail(Oid,PicAddress,IntIndex,SourceText,ReplaceText,OFlag) ";
            strSQL = strSQL + " values(" + int.Parse(dgvMain.CurrentRow.Cells["ID"].Value.ToString()) + ",'" + tbPicAddress.Text + "','" + tbIntIndex.Text + "','" + tbSourceText.Text + "','" + tbReplaceText.Text + "','1') ";
            ah.ExecuteNonQuery(strSQL);
            FlashData();
        }

        private void btnADEdit_Click(object sender, EventArgs e)
        {
            AccessHelper ah = new AccessHelper(DBfile);
            //Oid,PicAddress,IntIndex,SourceText,ReplaceText,OFlag
            string strSQL = "update tabActionDetail ";
            strSQL = strSQL + " set PicAddress='" + tbPicAddress.Text + "',IntIndex='" + tbIntIndex.Text + "',SourceText='" + tbSourceText.Text + "',ReplaceText='" + tbReplaceText.Text + "' ";
            strSQL = strSQL + " where oflag='1' and id=" + dgvActionDetail.CurrentRow.Cells["id"].Value.ToString();
            ah.ExecuteNonQuery(strSQL);
            FlashData();
        }

        private void btnADDelete_Click(object sender, EventArgs e)
        {
            AccessHelper ah = new AccessHelper(DBfile);
            string strSQL = "update tabActionDetail ";
            strSQL = strSQL + " set oflag='0' ";
            strSQL = strSQL + " where oflag='1' and id=" + dgvActionDetail.CurrentRow.Cells["id"].Value.ToString();
            ah.ExecuteNonQuery(strSQL);
            FlashData();
        }
    }
}
