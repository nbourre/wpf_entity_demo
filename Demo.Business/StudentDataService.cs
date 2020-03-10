using Demo.Data;
using Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.Business
{
    public class StudentDataService : IDataService<Student>
    {
        SchoolContext db = new SchoolContext();
        List<Student> students = new List<Student>();

        public StudentDataService()
        {
            initValues();
        }

        private void initValues()
        {
            if (db.Database.CanConnect())
            {
                students = db.Students.ToList();
            }
        }

        public IEnumerable<Student> GetAll()
        {
            foreach (Student s in students)
            {
                yield return s;
            }
        }
    }
}

