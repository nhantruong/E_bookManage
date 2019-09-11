using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbookManage.Data
{
    public class ebook
    {
        #region PROPPERTIES
        public enum Chude
        {
            Guildline = 0,
            QTO = 1,
            FM = 2,
            Manual = 3,
            Report = 4,
            Handbook = 5,
            Standard = 6
        }

        private int _id;
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _name;
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _chude;
        public string chude
        {
            get { return _chude; }
            set { _chude = value; }
        }
        private double _namXB;
        public double namXB
        {
            get { return _namXB; }
            set { _namXB = value; }
        }

        private string _tenfile;
        public string tenfile
        {
            get { return _tenfile; }
            set { _tenfile = value; }
        }

        private string[] _tag;
        public string[] tag
        {
            get { return _tag; }
            set { _tag = value; }
        }

        private string _link;
        public string link
        {
            get { return _link; }
            set { _link = value; }
        }

        private double _filesize;

        public double filesize
        {
            get { return _filesize; }
            set { _filesize = value; }
        }
        private string _dinhdang;

        public string dinhdang
        {
            get { return _dinhdang; }
            set { _dinhdang = value; }
        }


        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Khởi tạo ko tham số
        /// </summary>
        public ebook() { }

        /// <summary>
        /// Khởi tạo ebook
        /// </summary>
        /// <param name="_id"></param>
        /// <param name="_name"></param>
        /// <param name="_chude"></param>
        /// <param name="_namXB"></param>
        /// <param name="_tenfile"></param>
        public ebook(int _id, string _name, string _chude, double _namXB, string _tenfile, string _link, double _filesize, string _dinhdang)
        {
            this.id = _id;
            this.name = _name;
            this.chude = _chude;
            this.namXB = _namXB;
            this.tenfile = _tenfile;
            this.link = _link;
            this.filesize = _filesize;
            this.dinhdang = _dinhdang;
        }

        #endregion
        #region METHODS
        

        #endregion
    }
}
