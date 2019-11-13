using DbDemoLib.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbDemo.Model
{
    class DbDemoModel
    {
        public DbDemoModel()
        {
            this.Students = new ObservableCollection<Student>();
        }
        public ObservableCollection<Student> Students { get; set; }
    }
}
