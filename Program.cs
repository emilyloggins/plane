using System;
using System.Collections.Generic;
using PlaneClass;

namespace plane_class
{
    class Program
    {
        static void Main(string[] args)
        {
            var plane1 = new Plane() {
                Make = "The Fly Boys",
                Model = "Wingy Thingy",
                Seats = 624
            };

            plane1.Fly();
            plane1.Fly(10000);
        }
    }
}
