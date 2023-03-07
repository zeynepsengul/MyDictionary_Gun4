using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary_Gun4
{
    class MyDictionary<T1,T2>
    {
        T1[] items;
        T2[] items2;
        public MyDictionary()
        {
            items = new T1[0];
            items2 = new T2[0];
        }
        public void Add(T1 item, T2 item2)
        {   
            T1[] tempArray1 = items;
            T2[] tempArray2 = items2;
            items= new T1[items.Length+1];
            items2 = new T2[items.Length+1];

            for (int i = 0; i < tempArray1.Length; i++)
            {
                items[i] = tempArray1[i];
                items2[i]=tempArray2[i];
            }
            items[items.Length - 1] = item; 
            items2[items.Length - 1] = item2;   
            
        }
        public int Count()
        {
            return items.Length;
        }
    }
}
