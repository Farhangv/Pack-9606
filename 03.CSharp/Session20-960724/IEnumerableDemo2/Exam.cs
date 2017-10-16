using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableDemo2
{
    class Exam:IEnumerable
    {
        public string Title { get; set; }
        public Question[] Questions { get; set; }

        public IEnumerator GetEnumerator()
        {
            //return Questions.GetEnumerator();
            return new RandomQuestionEnumerator(this.Questions, 3);
        }
    }
}
