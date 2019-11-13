using DbDemoLib.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DbDemoService.Models
{
    public class DbDemoContext :DbContext
    {
        public DbDemoContext() : base()
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}