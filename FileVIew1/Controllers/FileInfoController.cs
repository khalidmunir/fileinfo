using FileView1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FileView1.Controllers
{
    public class FileInfoController : Controller
    {
        public IList<FileInfo> rows;

        // GET: FileInfo
        [HttpGet]
        public ActionResult GetFileInfo()
        {
            rows = new List<FileInfo>();
            using (var db = new FileViewDBContext())
            {
                foreach(var row in db.FileInfoDBTable)
                {
                    rows.Add(row);
                }
            }

            return Json(rows, JsonRequestBehavior.AllowGet);
        }
    }
}