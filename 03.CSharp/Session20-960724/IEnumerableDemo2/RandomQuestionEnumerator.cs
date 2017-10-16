using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableDemo2
{
    class RandomQuestionEnumerator : IEnumerator
    {
        private Question[] questions;//آرایه مجموعه سوالات
        private int currentQuestionArrayIndex;//ایندکس فعلی آرایه سوالات
        private int maxQuetions;//حداکثر تعداد سوالات انتخابی
        private int[] randomIndexArray;//آرایه ایندکس های رندم سوالات
        private int currentRandomArrayIndex;//ایندکس فعلی آرایه ایندکس های تصادفی
        public RandomQuestionEnumerator(Question[] _questions, int _max)
        {
            questions = _questions;
            maxQuetions = _max;
            currentRandomArrayIndex = 0;
            currentQuestionArrayIndex = 0;
            randomIndexArray = generateRandomArray(_questions.Length - 1, _max);
        }

        public object Current//بازگرداندن شی جاری که نوبتش شده
        {
            get
            {
                return questions[currentQuestionArrayIndex];
            }
        }

        public bool MoveNext()
        {
            if (maxQuetions - 1 >= currentRandomArrayIndex)//بررسی میکند که آیا به تعداد مورد نیاز تا به حال سوال تولید شده یا نه
            {
                currentQuestionArrayIndex = randomIndexArray[currentRandomArrayIndex++];//ایندکس رندم جاری را مشخص میکند
                return true;
            }
            else
                return false;

        }

        public void Reset()
        {
            currentRandomArrayIndex = 0;
            currentQuestionArrayIndex = 0;
        }



        private int[] generateRandomArray(int maxIndex, int count)
        {
            Random r = new Random();
            var min = 0;
            var max = maxIndex;
            var randomNumbers = new int[count];
            var domain = new int[max + 1];
            for (int i = 0; i < domain.Length; i++)
            {
                domain[i] = min++;
            }
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                var randomIndex = r.Next(0, domain.Length - i);
                randomNumbers[i] = domain[randomIndex];
                domain[randomIndex] = domain[domain.Length - 1 - i];
            }
            Array.Sort(randomNumbers);
            return randomNumbers;
        }
    }
}
