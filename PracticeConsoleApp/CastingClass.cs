using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp
{
    public class CastingClass
    {
        public static void Main()
        {
            parent a = new parent();
            a.GetName();

            //The up-casting is implicit
            //An assignment of derived class object to a base class reference in C# inheritance is known as up-casting. 
            //Assigning child object to parent ref. variable  
            parent b = new child();
            b.GetName();

            //An assignment of base class object to derived class object is known as Down-casting. 
            child c = (child)b;
            c.GetName();
            //Why Down-Casting is required in C# programming?
            //It is possible that derived class has some specialized method.
            //For example, in above derived class Circle, FillCircle() method is specialized and only available to Circle class not in Shape base class.
        }
    }
    public class parent
    {
        public virtual string GetName()
        {
            return "Jagdev";
        }
    }
    public class child:parent
    {
        public override string GetName()
        {
            return "Jagdev";
        }
    }
}
