using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    public class MyDictionary<T1, T2>
    {
        T1[] items1;
        T2[] items2;
        public MyDictionary()
        {
            items1 = new T1[0];
            items2 = new T2[0];
        }
        public void Add(T1 item1, T2 item2)
        {
            T1[] tempArray1 = items1;
            T2[] tempArray2 = items2;

            items1 = new T1[items1.Length];
            for (int i = 0; i < tempArray1.Length; i++)
            {
                items1[i] = tempArray1[i];
            }
            items1[items1.Length - 1] = item1;

            items2 = new T2[items2.Length];
            for (int i = 0; i < tempArray2.Length; i++)
            {
                items2[i] = tempArray2[i];
            }
            items2[items2.Length - 1] = item2;
        }
    }
}
