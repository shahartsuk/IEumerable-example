using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEumerable
{
    internal class MyList : IEnumerable
    {
        MyEnumerator i = new MyEnumerator();
        public IEnumerator GetEnumerator()
        {
            return i;
        }
    }
    internal class MyEnumerator : IEnumerator
    {
        int[] arr = new int[100];
        int idx= 0;
        int loop =0;

        public void AddToList(int s)
        {
            arr[idx] = s;
            idx++;
        }
        public object Current
        {
            get
            {
                return arr[loop];
            }
        }

        public bool MoveNext()
        {
            if (loop == idx)
            {
                //Reset();
                return false;
            }
            else
            {
                loop++;
                return true;
            }
            
        }
        public void Reset()
        {
            loop = 0;
        }
    }
}
