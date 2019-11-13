using DbDemo.Model;
using DbDemoLib.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DbDemo.Controller
{
    class DbDemoController
    {
        public DbDemoController()
        {
            this.ViewData = new DbDemoModel();
        }

        public DbDemoModel ViewData { get; set; }

        public async Task AddStudentAsync(Student student)
        {
            var client = new HttpClient();
            var myContent = JsonConvert.SerializeObject(student);
            var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
            var byteContent = new ByteArrayContent(buffer);

            var result = await client.PostAsync("http://localhost:58917/api/Student", byteContent);
        }
    }
}
