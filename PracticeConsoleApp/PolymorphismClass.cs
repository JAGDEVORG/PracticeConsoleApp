using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp
{
    public class PolymorphismClass
    {
        public static void Main()
        {
            /* Diff between both of them */
            NewCar newCar = new NewCar();
            Console.WriteLine(newCar.getCarInfo(50));

            Car car = new NewCar();
            Console.WriteLine(car.getCarInfo(50));
            car = new Car();
            car.getUserDetails(1,"tre");
            car.getUserDetails("trt", 1);

            // Runtime polymophism/dyamic-- upcasting allowed
            // upcasting--Moving subclass object to parent class object.
            // downcasting-- moving parent class object to child object-- it is invalid
            // NewCar newCar2 = new Car();  
        }
    }
    public class Car
    {
        public string getUserDetails(int id, string s)
        {
            return "j1";
        }
        public int getUserDetails(string id,int s)
        {
            return 4;
        }

        public virtual int getCarInfo(int Id)
        {
            return 500;
        }
    }
    public class NewCar : Car
    {
        public override int getCarInfo(int Id)
        {
            return base.getCarInfo(Id) + 600;
        }
    }
}
