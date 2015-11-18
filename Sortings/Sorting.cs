using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortings
{
   public class Sorting<T> where T : IComparable<T>
    {
        public T[] array;
        public Sorting(T[] array)
        {
            try
            {
                if (array.Length != 0)
                {
                    this.array = array;
                }
                else throw new Exception();
            }
            catch (Exception)
            {
                Console.WriteLine("Вы ввели пустой массив");
            }
        }

        //сортировка пузырьком: сравниваются два соседние элемента и наиболее легкий из них поднимается наверх
        // время работы алгоритма O(n^2)
       public void SortBubble()
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[j].CompareTo(array[j+1]) > 0)
                    {
                        T tempElement = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tempElement;
                    }
                }
            }
        }
        // сортировка вставками: последовательно берется каждый элемент массива и вставляетсяв нужное место массива
        // время работы O(n^2)
        public void SortInsertion()
        {
            for (int pointerElem = 1; pointerElem < array.Length; pointerElem++)
            {
                for (int i = 0; i < pointerElem; i++)
                {
                    if (array[pointerElem].CompareTo(array[i]) < 0)
                    {
                        T tempElem = array[pointerElem];
                        for (int j = pointerElem; j > i; j--)
                        {
                            array[j] = array[j - 1];
                        }
                        array[i] = tempElem;

                    }
                }
            }
           
        }
        // сортировка выбором: последовательно находится самый маленький элемент из неотсортиврованного массива и длбавляется к концу отсорированного
        // время работы O(n^2)
        public void SortSelection()
        {
            for (int i = 0; i < array.Length; i++)
            {
             
                int indexOfMin = i;
                for (int j = i; j < array.Length; j++)
                {
                    if (array[j].CompareTo(array[indexOfMin]) < 0)
                    {
                        indexOfMin = j;
                    }  

                }
                //замена элементов
                T temp = array[i];
                array[i] = array[indexOfMin];
                array[indexOfMin] = temp;
            }
        }
        public void Print()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Элемент {0} = {1}", i, array[i]);
            }
        }

       
    }
    
    
}
