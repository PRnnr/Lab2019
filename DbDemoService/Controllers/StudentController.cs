using DbDemoLib.Entities;
using DbDemoService.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace DbDemoService.Controllers
{
    public class StudentController : Controller
    {
        private DbDemoDal _dal;

        public DbDemoDal Dal
        {
            get
            {
                if (_dal == null)
                    _dal = new DbDemoDal();
                return _dal;
            }
        }


        [System.Web.Http.HttpGet]
        public async Task<Student> GetStudentAsync(int id)
        {
            return await Dal.GetStudentAsync(id);
        }
        [System.Web.Http.HttpGet]
        public async Task<List<Student>> GetStudentsAsync()
        {
            return await Dal.GetStudentsAsync();
        }
        [System.Web.Http.HttpPost]
        public async Task<Student> AddStudentAsync([FromBody]Student studentToAdd)
        {
            return await Dal.AddStudentAsync(studentToAdd);
        }

    }
}