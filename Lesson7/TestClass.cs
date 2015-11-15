using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNamespace
{
    class TestClass
    {
        private string name;

        public string Name {get; set; }

        public TestClass(string n)
        {
            Name = n;
        }
    }
}
