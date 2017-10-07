using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] contacts = new string[1];
            Console.WriteLine("Enter First Contact:");
            contacts[0] = Console.ReadLine();
            while (true)
            {
                Console.Clear();
                foreach (var contact in contacts)
                {
                    Console.WriteLine(contact);
                }
                Console.WriteLine("------------------------------");
                Console.WriteLine("What you want to do:");
                Console.WriteLine("1.Add\n2.Delete\n3.Edit\n4.Exit");
                var selectedItem = int.Parse(Console.ReadLine());
                switch (selectedItem)
                {
                    case 1://Add
                        Console.WriteLine("Enter New Contact Name:");
                        AddToArray(ref contacts, Console.ReadLine());
                        break;
                    case 2://Delete
                        Console.WriteLine("Enter Contact Name To Remove:");
                        DeleteFromArray(ref contacts, Console.ReadLine());
                        break;

                    case 4:
                        return;
                    default:
                        break;
                }

            }
        }

        static int DeleteFromArray(ref string[] array, string value)
        {
            var count = 0;
            for (int i = 0; i < array.Length; i++)//شمارش تعداد خانه هایی که باید حذف شود
            {
                if (array[i].ToLower() == value.ToLower())
                    count++;
            }
            var newArray = new string[array.Length - count];
            for (int newArrayIndex = 0, arrayIndex = 0; arrayIndex < array.Length;arrayIndex++)
            {
                if (array[arrayIndex].ToLower() != value.ToLower())
                {
                    newArray[newArrayIndex++] = array[arrayIndex];
                }
            }
            array = newArray;
            return newArray.Length;
        }

        static int AddToArray(ref string[] array, string newValue)
        {
            var newArray = new string[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            newArray[newArray.Length - 1] = newValue;
            array = newArray;
            return newArray.Length;
        }
    }
}
