using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    class Indexes
    {
        public string index1;
        public string index2;
        public string index3;

        string[] indexes;

        public int Length
        {
            get { return indexes.Length; }
        }
        public string this[int i]
        {
            get
            {
                return indexes[i];
            }
            set
            {
                indexes[i] = value;
            }
        } 

    }
}
