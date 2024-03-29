﻿using EbookManage.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace E_bookManage
{
    public partial class frm_EbookManage : Form
    {
        public static string ebookFolderPath = @"D:\04. Learning\38. Ebook Manage";
        private static List<ebook> cURRENT_EBOOK_LIST = new List<ebook>();
        //public static string TEMP_FOLDERPATH = @"\\coteccons.vn\filesv\DATAPUBLIC\nhantc\ebookManage";
        public static string TEMP_FOLDERPATH = @"D:\BIMtools";

        internal static List<ebook> CURRENT_EBOOK_LIST { get => cURRENT_EBOOK_LIST; set => cURRENT_EBOOK_LIST = value; }

        public frm_EbookManage()
        {
            InitializeComponent();
        }

        #region Methods
        /// <summary>
        /// Get books form path - including SubFolder
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private List<ebook> GetBooks(string path)
        {
            List<ebook> ebooks = new List<ebook>();
            string[] folderlist = Directory.GetDirectories(path);
            List<string[]> AllFileList = new List<string[]>();
            foreach (var _folder in folderlist)
            {
                AllFileList.Add(Directory.GetFiles(_folder));
            }
            List<string> allFiles = new List<string>();
            foreach (var item in AllFileList)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    allFiles.Add(item[i]);
                }
            }
            if (allFiles.Count > 0)
            {                
                foreach (var item in allFiles)
                {
                    ebook _ebook = new ebook();//Tạo ra sách mới
                    //Lấy năm tạo ra
                    DateTime dateTime = File.GetLastWriteTime(item);
                    string _year = dateTime.Year.ToString();
                    string _id = _year.Substring(2);
                    string tenfile = System.IO.Path.GetFileNameWithoutExtension(item);
                    string fileformat = System.IO.Path.GetExtension(item);
                    FileInfo fi = new FileInfo(item);
                    double kichthuoc = fi.Length;

                    //Add value to ebook
                    _ebook.namXB = double.Parse(_year);
                    _ebook.id = int.Parse(_id);
                    _ebook.tenfile = tenfile;
                    _ebook.name = XuLyDuLieu.LoaiBoDauTiengViet(tenfile);
                    _ebook.link = Path.GetFullPath(item);
                    _ebook.dinhdang = fileformat;
                    _ebook.chude = "chưa cập nhật";
                    _ebook.filesize = kichthuoc;

                    string info = _id + "_" + Path.GetFileName(item);

                    ebooks.Add(_ebook);
                    CURRENT_EBOOK_LIST.Add(_ebook);
                }

                return ebooks;
            }
            else
            {
                return null;
            }

        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="dgv_ebooks"></param>
        /// <param name="FolderPath"></param>
        /// <returns></returns>
        private string EditBookLable(DataGridView dgv_ebooks, string FolderPath)
        {
            string kq = "Không sửa được tiêu đề sách";
            try
            {
                List<ebook> books = new List<ebook>();
                books = GetBooks(FolderPath);
                List<ebook> newbook = books.OrderBy(s => s.namXB).ToList();
                if (newbook == null || newbook.Count == 0) return "Không có sách";
                int index = 0;
                int _a = Enum.GetValues(typeof(ebook.Chude)).Length;
                Array listItem = new string[_a];
                listItem = Enum.GetValues(typeof(ebook.Chude));
                StatusProgressBar.Maximum = books.Count;
                StatusProgressBar.Value = 0;
                DataGridViewComboBoxCell cmbCatalogue;
                try
                {
                    foreach (ebook item in books)
                    {
                        dgv_ebooks.Rows.Add();
                        dgv_ebooks.Rows[index].Cells["ID"].Value = item.id;
                        dgv_ebooks.Rows[index].Cells["NamXB"].Value = item.namXB;
                        dgv_ebooks.Rows[index].Cells["tenfile"].Value = item.tenfile;
                        dgv_ebooks.Rows[index].Cells["TenSach"].Value = XuLyDuLieu.LoaiBoDauTiengViet(item.tenfile);
                        dgv_ebooks.Rows[index].Cells["Tag"].Value = item.tag;
                        dgv_ebooks.Rows[index].Cells["link"].Value = item.link;

                        //dgv_ebooks.Rows[index].Cells["cmb_Catalogue"].Value = ebook.Chude.Guildline;
                        cmbCatalogue = (DataGridViewComboBoxCell)dgv_ebooks.Rows[index].Cells["cmb_Catalogue"];

                        foreach (var chude in listItem)
                        {
                            cmbCatalogue.Items.Add(chude.ToString());
                            cmbCatalogue.Value = ebook.Chude.Guildline.ToString(); //tạo giá trị mặc định
                        }
                        index++;
                        StatusProgressBar.Value = index;
                    }
                    return kq = "Cập nhật nội dung thành công";
                }
                catch (ArgumentException ex)
                {
                    cmbCatalogue = (DataGridViewComboBoxCell)dgv_ebooks.Rows[index].Cells[5];
                    cmbCatalogue.Items.Clear();
                    return kq = ex.Message;
                }
            }
            catch (Exception ex)
            {
                return kq = "Có lỗi do " + ex.Message;
            }
        }
        #endregion

        private void btn_EbookManage_Click(object sender, EventArgs e)
        {
            dgv_ebooks.Rows.Clear();
            ebookFolderPath = @"D:\04. Learning\38. Ebook Manage";
            //ebookFolderPath = @"\\coteccons.vn\filesv\DEPARTMENT\BIM\01--Private\7. Shared Book";
            lblStatus.Text = EditBookLable(dgv_ebooks, ebookFolderPath);
        }



        private void selectFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browserDialog = new FolderBrowserDialog();
            if (browserDialog.ShowDialog() == DialogResult.OK)
            {
                dgv_ebooks.Rows.Clear();
                ebookFolderPath = browserDialog.SelectedPath;
                lblStatus.Text = EditBookLable(dgv_ebooks, ebookFolderPath);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            List<ebook> UPDATELIST = new List<ebook>();
            StatusProgressBar.Maximum = dgv_ebooks.Rows.Count;
            StatusProgressBar.Value = 0;
            for (int i = 0; i < dgv_ebooks.Rows.Count; i++)
            {
                ebook _ebook = new ebook();
                _ebook.id = int.Parse(dgv_ebooks.Rows[i].Cells["ID"].Value.ToString());
                _ebook.link = dgv_ebooks.Rows[i].Cells["link"].Value.ToString();
                _ebook.namXB = double.Parse(dgv_ebooks.Rows[i].Cells["NamXB"].Value.ToString());
                _ebook.tenfile = dgv_ebooks.Rows[i].Cells["tenfile"].Value.ToString();
                _ebook.name = dgv_ebooks.Rows[i].Cells["TenSach"].Value.ToString();
                _ebook.chude = dgv_ebooks.Rows[i].Cells["cmb_Catalogue"].Value.ToString();
                //_ebook.tag = dgv_ebooks.Rows[i].Cells["Tag"].Value.ToString();
                UPDATELIST.Add(_ebook);
                StatusProgressBar.Value++;
            }
            lblStatus.Text = WriteXML(TEMP_FOLDERPATH, UPDATELIST);
        }

        private string WriteXML(string path, List<ebook> data)
        {
            string tenfileloi = "";
            try
            {
                //XML
                XmlDocument tailieu = new XmlDocument();
                //tạo node gốc
                XmlElement rootNode = tailieu.CreateElement("EbookList");
                tailieu.AppendChild(rootNode);
                foreach (var _item in data)
                {
                    string bookCode = _item.namXB + "_" + XuLyDuLieu.LoaiBoDauTiengViet(_item.name);
                    XmlElement KeyNodes = tailieu.CreateElement(bookCode);
                    //Tạo node con cấp 2
                    //Tên sách
                    XmlElement nameNode = tailieu.CreateElement("BookName");
                    nameNode.InnerText = XuLyDuLieu.LoaiBoDauTiengViet(_item.name);
                    KeyNodes.AppendChild(nameNode);

                    //string[] projectid = _item.tag != null ? _item.tag : "notset";

                    //ID
                    XmlElement IDNode = tailieu.CreateElement("ID");
                    IDNode.InnerText = _item.id.ToString();
                    nameNode.AppendChild(IDNode);

                    //Chude
                    XmlElement ChuDeNode = tailieu.CreateElement("ChuDe");
                    if (_item.chude != null)
                    {
                        ChuDeNode.InnerText = XuLyDuLieu.LoaiBoDauTiengViet(_item.chude.ToString());
                        nameNode.AppendChild(ChuDeNode);
                    }
                    else
                    {
                        ChuDeNode.InnerText = "Not set";
                        nameNode.AppendChild(ChuDeNode);
                    }


                    //TenFile
                    XmlElement fileNameNode = tailieu.CreateElement("TenFile");
                    fileNameNode.InnerText = XuLyDuLieu.LoaiBoDauTiengViet(_item.tenfile);
                    nameNode.AppendChild(fileNameNode);

                    //Năm Xuất bản
                    XmlElement NamXBNode = tailieu.CreateElement("NamXB");
                    NamXBNode.InnerText = _item.namXB.ToString();
                    nameNode.AppendChild(NamXBNode);

                    //Liên kết
                    XmlElement LinkNode = tailieu.CreateElement("Link");
                    LinkNode.InnerText = XuLyDuLieu.LoaiBoDauTiengViet(_item.link);
                    nameNode.AppendChild(LinkNode);
                    tenfileloi = _item.tenfile;
                }
                tailieu.Save(path);
                return "Ghi file thành công";
            }
            catch (Exception ex)
            {
                return "Ghi file thất bại do " + ex.Message + "- Tên file: " + tenfileloi;
            }
        }

        private string RenameFile(string tenfile, string _path, string tEMP_FOLDERPATH)
        {
            string NEWFILENAME = "";
            string OLDFILENAME = Path.GetFileName(_path);
            //string OLDFILEEXTENSION = Path.GetExtension(_path);
            NEWFILENAME = XuLyDuLieu.LoaiBoDauTiengViet(OLDFILENAME);

            try
            {
                string FullPathNewName = tEMP_FOLDERPATH + NEWFILENAME;
                System.IO.File.Move(_path, FullPathNewName);
                return "Đổi tên file thành công";
            }
            catch (Exception ex)
            {
                return "Đổi tên file thất bại do " + ex.Message;

            }

        }

        private void btn_RenameFile_Click(object sender, EventArgs e)
        {
            try
            {
                List<ebook> books = new List<ebook>();
                books = GetBooks(ebookFolderPath);
                foreach (var item in books)
                {
                    string tenFile = RenameFile(item.name, item.link, TEMP_FOLDERPATH);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Btn_ToExcel_Click(object sender, EventArgs e)
        {
            lblStatus.Text = XuLyDuLieu.WriteToExcel(TEMP_FOLDERPATH, CURRENT_EBOOK_LIST);

        }
    }
}
