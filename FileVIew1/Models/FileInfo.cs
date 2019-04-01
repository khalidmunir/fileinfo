using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FileView1.Models
{
    public class FileInfo
    {
        [Key]
        public int FileID { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string Volume { get; set; }
        public int Size { get; set; }
        public string Ctime { get; set; }
        public string Mtime { get; set; }
        public string Atime { get; set; }
        public string MD5 { get; set; }
        public string SecurityClassification { get; set; }
        public string BusinessClassification { get; set; }
        public string Extension { get; set; }
        public string MimeType { get; set; }
        public int EmployeeNo { get; set; }
    }
}