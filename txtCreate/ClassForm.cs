using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace txtCreate
{
    public class ClassForm
    {
        public string Name { get; set; }
        public Student[] StudentArray { get; set; }
        public ClassForm()
        {
            this.Name = "1-ci sinif";
        }
        public ClassForm(string _name, Student[] _arrS)
        {
            this.Name = _name;
            this.StudentArray = _arrS;
        }
    }
}
