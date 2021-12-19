using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TddDemo.Business
{
    public class EgnTools
    {
        public Dictionary<int, int> _Collection = new Dictionary<int, int>();
        public void PopulateDaysInMonths(bool isLeap)
        {
            _Collection.Clear();
            _Collection.Add(1, 31);
            if (isLeap)
            {
                _Collection.Add(2, 29);
            }
            else
            {
                _Collection.Add(2, 28);
            }
            _Collection.Add(3, 31);
            _Collection.Add(4, 30);
            _Collection.Add(5, 31);
            _Collection.Add(6, 30);
            _Collection.Add(7, 31);
            _Collection.Add(8, 31);
            _Collection.Add(9, 30);
            _Collection.Add(10, 31);
            _Collection.Add(11, 30);
            _Collection.Add(12, 31);
        }

       public void Algoritam()
        {
            _Collection.Clear();
            _Collection.Add(1, 2);
            _Collection.Add(2, 4);
            _Collection.Add(3, 8);
            _Collection.Add(4, 5);
            _Collection.Add(5, 10);
            _Collection.Add(6, 9);
            _Collection.Add(7, 7);
            _Collection.Add(8, 3);
            _Collection.Add(9, 6);
        }
    }
}
