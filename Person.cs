using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exammination3
{
    public class Person
    {
        public string Name { get; set; }
        public string Major { get; set; }

        public Person(string name, string major)
        {
            Name = name;
            Major = major;

        }
    }
}
