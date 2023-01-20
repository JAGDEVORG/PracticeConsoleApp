using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp
{
    public class InheritanceClass
    {
        public static void Main()
        {
            classA a = new classB();
            Console.WriteLine(a.Print());//class B

            classB b = new classC();
            Console.WriteLine(b.Print());//class B

            /*Why Class B*/
            classA ac = new classC();
            Console.WriteLine(ac.Print());//class B

            classC c = new classC();
            Console.WriteLine(c.Print());//class C
        }

    }
    

    public class classA
    {
        public virtual string Print()
        {
            return "classA";
        }
    }

    public class classB : classA
    {
        public override string Print()
        {
            return "classB";
        }
    }

    public class classC : classB
    {
        public new string Print()
        {
            return "ClassC";
        }
    }

}
