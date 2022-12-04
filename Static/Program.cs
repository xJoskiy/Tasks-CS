using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{

    public static class MyStaticClass
    {
        static class Inner
        {
            static public int a = 3;
        }
        public static int Method(int a)
        {
            
            return a;
        }

        public static float Method(float a)
        {
            return Inner.a + a;
        }
        static int MyProperty { get; set; }
    }

    public class MyClass
    {
        public int field = 1;
        private int pole = 1;
        public static int field2 = 2;
        static MyClass()
        {   
            MyClass a = new MyClass();
            StaticMethod(ref a);
        }

        public void Method()
        {
            MyClass obj = new MyClass();
            
            obj.pole = pole;
        }
        public static void StaticMethod(ref MyClass obj)
        {
            obj.field = 1;
            obj.pole = 3;
        }
        public MyClass()
        {

        }
    }
    internal class Static
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            
            
        }
    }
}
