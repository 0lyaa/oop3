using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba6
    //Створіть клас MyList<T>. Реалізуйте у найпростішому наближенні можливість використання його екземпляра
    //аналогічно екземпляру класу List<T>.
    //Мінімально необхідний інтерфейс взаємодії з екземпляром повинен включати метод додавання елемента,
    //індексатор для отримання значення елемента за вказаним індексом та властивість тільки для читання
    //для отримання загальної кількості елементів.
{
    internal class MyList<T>
    {
        T[] list = new T[0];

        public T this[int i]
        {
            get
            {
                if (i > list.Length && i < 0) throw new IndexOutOfRangeException();
                return list[i];
            }

            set
            {
                if (i > list.Length && i < 0) throw new IndexOutOfRangeException();
                list[i] = value;
            }

        }
        public void Add(T value)
        {
            T[] newList = new T[GetLength() + 1]; //create new array
            list.CopyTo(newList, 0); //coppy elements
            newList[GetLength()] = value; // add element to the end
            list = newList; // rewrite all elements from new lis to list

        }

        public void Remove(T value)
        {
            int i = Array.IndexOf(list, value);

            if (i == -1)
            {
                Console.WriteLine("There is no such element in the list");
                return;
            }

            //T[] newList = new T[GetLength() - 1];

            for (int j=i; j<GetLength()-1; j++)
            {
                list[j] = list[j+1];//displacement element
            }
            Array.Resize(ref list, GetLength() - 1); //change size
        }

        public T GetValue(int index)
        {
            return list[index];
        }

        public int GetLength()
        {
            return list.Length;
        }

        public void PrintList()
        {
            foreach (T value in list)
            {
                System.Console.Write(value.ToString() + " ");
            }
            Console.WriteLine();
        }
    }
}
