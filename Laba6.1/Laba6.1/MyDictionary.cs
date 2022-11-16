using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba6._1
  //Створіть клас MyDictionary <TKey, TValue>.
  //Реалізуйте у найпростішому наближенні можливість використання його екземпляра аналогічно екземпляру
  //класу Dictionary.Мінімально необхідний інтерфейс взаємодії з екземпляром повинен включати метод
  //додавання пар елементів, індексатор для отримання значення елемента за вказаним індексом та
  //властивість тільки для читання для отримання загальної кількості пар елементів.
{
    internal class MyDictionary<TKey, TValue>
    {
        TKey[] Klist = new TKey[0];
        TValue[] Vlist = new TValue[0];

        public void Add(TKey key, TValue value)
        {
            TKey[] newKList = new TKey[GetLengthK() + 1]; //create new array
            TValue[] newVList = new TValue[GetLengthV() + 1];

            Klist.CopyTo(newKList, 0); //coppy elements
            Vlist.CopyTo(newVList, 0);

            newKList[GetLengthK()] = key; // add element to the end
            newVList[GetLengthV()] = value;

            Klist = newKList; // rewrite all elements from new lis to list
            Vlist = newVList;

        }

        public TKey GetValueK(int index)
        {
            return Klist[index];
        }

        public TValue GetValueV(int index)
        {
            return Vlist[index];
        }

        public int GetLengthK()
        {
            return Klist.Length;
        }
        public int GetLengthV()
        {
            return Vlist.Length;
        }

        public void PrintList()
        {
            for (int i = 0; i < GetLengthK(); i++)
            {
                Console.WriteLine((i+1) + ". " + Klist[i] + " : " + Vlist[i]);
            }
        }
    }
}
