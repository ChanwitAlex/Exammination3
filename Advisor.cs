using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exammination3
{
    public class Advisor : Person
    {
        public List<Student> Students { get; set; }

        public Advisor(string name, string major) : base(name, major)
        {
            Students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public string GetStudentList()
        {
            return Students.Count > 0 ? string.Join(", ", Students.Select(s => s.Name)) : "ไม่มีนักศึกษา";
        }

    }
}
