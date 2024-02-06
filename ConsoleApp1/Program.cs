using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quadrep.CppAlgo;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var my = new Child_A();
            my.ActivateStdException1();

            

            var vec3_nan = new MyVector3();
            MyVector3 vec3 = new MyVector3(1.1, 2.2, 3.3);
            MyCppClass myCppClass = new MyCppClass();
            var num = myCppClass.Add(3.1415926, 31.415926);
            MyCoordinate crd = new MyCoordinate(vec3, vec3, vec3);
            var data = new MyData(1.2, "123456", 255, 34567, 3.1415f);
            var str = crd.CoordinateString;
            var crt = myCppClass.CreateVector3();
            var axis = myCppClass.Cross(new MyVector3(1, 0, 0), new MyVector3(0, 1, 0));
            Quadrep.CppAlgo.MyStaticClass.ShowMessage("ABC");
            var collection = myCppClass.GetMyCollection();
            foreach (var i in collection)
                Console.WriteLine(toString(i));
            Console.WriteLine("collection:\r\n");
            var newCollection = myCppClass.ShiftMyCollection(collection);
            Console.WriteLine("new collection:\r\n");
            foreach (var i in newCollection)
                Console.WriteLine(toString(i));
            Console.WriteLine("expand collection:\r\n");
            myCppClass.ExpandMyCollection(newCollection);
            var tmp = newCollection.ToArray();
            foreach (var i in newCollection)
                Console.WriteLine(toString(i));
            ;
        }


        private static string toString(MyVector3 vec)
        {
            return $"{vec.X:F4},{vec.Y:F4},{vec.Z:F4}";
        }
    }
}
