using FileView1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FileView1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //FileViewDBContext fvdb = new FileViewDBContext();
            //fvdb.Database.CreateIfNotExists();
            this.RePopulateDB();


            ViewBag.Title = "Home Page";

            return View();
        }

        public void RePopulateDB()
        {
            using (var db = new FileViewDBContext())
            {
                FileInfo fileRow1 = new FileInfo
                {
                    FileID = 1,
                    FileName = "turpis sed.xls",
                    FilePath = "Audit/Corston/External",
                    Volume = "UK_LondonDC",
                    Size = 105,
                    Ctime = "03/06/2017 01:57",
                    Mtime = "15/06/2017 01:57",
                    Atime = "01/07/2017 01:57",
                    MD5 = "0x398c343ecc07daa68710ee7319bd0750",
                    SecurityClassification = "Secret",
                    BusinessClassification = "Audit",
                    Extension = "xls",
                    MimeType = "application/x-excel",
                    EmployeeNo = 1
                };
                FileInfo fileRow2 = new FileInfo
                {
                   // FileID = 2,
                    FileName = "wonderwoman.png",
                    FilePath = "Audit/Corston/External",
                    Volume = "UK_LondonDC",
                    Size = 8326,
                    Ctime = "03/06/2017 01:57",
                    Mtime = "23/07/2018 11:15",
                    Atime = "03/11/2018 11:15",
                    MD5 = "0x17a5bcb3adbe7623177175fe59fd7810",
                    SecurityClassification = "ClassifiedSen",
                    BusinessClassification = "Audit",
                    Extension = "png",
                    MimeType = "image/png",
                    EmployeeNo = 1
                };
                FileInfo fileRow3 = new FileInfo
                {
                    FileID = 1,
                    FileName = "fred ed.xls",
                    FilePath = "Audit/Corston/External",
                    Volume = "UK_LondonDC",
                    Size = 9967805,
                    Ctime = "03/06/2017 01:57",
                    Mtime = "15/06/2017 01:57",
                    Atime = "01/07/2017 01:57",
                    MD5 = "0x398c343ecc07daa68710ee7319bd0750",
                    SecurityClassification = "Secret",
                    BusinessClassification = "Audit",
                    Extension = "xls",
                    MimeType = "application/x-excel",
                    EmployeeNo = 1
                };
                FileInfo fileRow4 = new FileInfo
                {
                    FileID = 1,
                    FileName = "superman.xls",
                    FilePath = "Audit/Corston/External",
                    Volume = "UK_LondonDC",
                    Size = 1133405,
                    Ctime = "03/06/2017 01:57",
                    Mtime = "15/06/2017 01:57",
                    Atime = "01/07/2017 01:57",
                    MD5 = "0x398c343ecc07daa68710ee7319bd0750",
                    SecurityClassification = "Secret",
                    BusinessClassification = "Audit",
                    Extension = "xls",
                    MimeType = "application/x-excel",
                    EmployeeNo = 1
                };
                FileInfo fileRow5 = new FileInfo
                {
                    FileID = 1,
                    FileName = "flash gordon.xls",
                    FilePath = "Audit/Corston/External",
                    Volume = "UK_LondonDC",
                    Size = 105,
                    Ctime = "03/06/2017 01:57",
                    Mtime = "15/06/2017 01:57",
                    Atime = "01/07/2017 01:57",
                    MD5 = "0x398c343ecc07daa68710ee7319bd0750",
                    SecurityClassification = "Secret",
                    BusinessClassification = "Audit",
                    Extension = "ppt",
                    MimeType = "application/x-ppt",
                    EmployeeNo = 1
                };



                db.FileInfoDBTable.Add(fileRow1);
                db.FileInfoDBTable.Add(fileRow2);
                db.FileInfoDBTable.Add(fileRow3);
                db.FileInfoDBTable.Add(fileRow4);
                db.FileInfoDBTable.Add(fileRow5);

                db.SaveChanges();
            }
            
        }

    }
}
