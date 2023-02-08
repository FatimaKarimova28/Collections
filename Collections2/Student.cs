using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2
{
    internal class Student
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Pin { get; set; }

        public string GetDetails()
        {
            return $"{Name} {Surname} {Pin}";
        }
    }
}
