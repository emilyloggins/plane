using System;

namespace PlaneClass {

            class Plane
            {
                private int _miles = 0;
                public string Model { get; set; }
                public string Make { get; set; }
                public int Seats { get; set; }

                // constructor (code snippet shortcut - ctor)
                public Plane(int startingMiles)
                {
                    _miles = startingMiles;
                }
                // You can overload constructors
                public Plane()
                {

                }
                public void Fly()
                {
                    Console.WriteLine($"This {Model} model plane, made by {Make}, has a total of {Seats} seats on board.");
                }
                public void Fly(int miles)
                {
                    _miles += miles;
                    Console.WriteLine($"Your odometer is now at {_miles}");
                }
}
}