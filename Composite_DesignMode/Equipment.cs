using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_DesignMode
{
    public class Equipment
    {

        private string name;

        public Equipment(string name)
        {
            this.name = name;
        }

        public string Name()
        {
            return name;
        }

        public virtual double Power()
        {
            return 0;
        }

        public virtual double NetPrice()
        {
            return 0;
        }

        public virtual double DiscountPrice()
        {
            return 0;
        }

        public virtual void Add(Equipment equipment)
        {

        }

        public virtual void Remove(Equipment equipment)
        {

        }

        public virtual Iterator<Equipment> CreateIterator()
        {
            return new Iterator<Equipment>();
        }
    }

    public class Iterator<T>
    {
        List<T> list = new List<T>();
        int count;
        public Iterator()
        {

        }

        public Iterator(List<T> ts)
        {
            list = ts;
        }

        public int First()
        {
            count = 0;
            return count;
        }

        public void Next()
        {
            count++;
        }

        public bool IsDone()
        {
            if(count>=list.Count)
            {
                return false;
            }
            return true;
        }

        public T Current()
        {
            return list[count];
        }
    }
}
