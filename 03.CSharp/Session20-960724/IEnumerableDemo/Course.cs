using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace IEnumerableDemo
{
    class Course:IEnumerable
    {
        public string Title { get; set; }
        public Student[] Students { get; set; }

        public IEnumerator GetEnumerator()
        {
            return this.Students.GetEnumerator();
        }
    }
}
