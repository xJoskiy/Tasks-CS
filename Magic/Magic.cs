using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic
{
    public class MyClass
    {
        public string Name { get; set; }
        public MyClass()
        {
            Name = "MyName";
            MyClass myClass = new MyClass();
        }
    }
    public class Magic
    { 
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
        }
    }
    
}
