using DbDemoLib.Entities;
using DbDemoService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace DbDemoService.Dal
{
    public class DbDemoDal
    {
        private DbDemoContext _context;

        public DbDemoContext Context
        {
            get
            {
                if (_context == null)
                    _context = new DbDemoContext();
                return _context;
            }
        }

        public async Task<Student> GetStudentAsync(int id)
        {
            return await Context.Students.FindAsync(id);
        }

        public async Task<Student> AddStudentAsync(Student studentToAdd)
        {
            var result = Context.Students.Add(studentToAdd);
            await Context.SaveChangesAsync();

            return result;
        }

        public async Task<List<Student>> GetStudentsAsync()
        {
            return await Task.Run(() => { return Context.Students.ToList(); });
        }


    }
}