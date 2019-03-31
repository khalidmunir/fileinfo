using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FileView1.Models
{
    public class FileViewDBContext: DbContext
    {
        public FileViewDBContext() : base("daidb")
        {
            Database.SetInitializer<FileViewDBContext>(new DropCreateDatabaseAlways<FileViewDBContext>());

        }
        public DbSet<FileInfo> FileInfoDBTable
        {
            get; set;
        }
    }
}