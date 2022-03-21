using GeoCoordinatePortable;
using System;
using System.Collections.Generic;

namespace Route3
{
    public class Program
    {
        static void Main(string[] args)
        {
            var point1 = new Point() { Latitude = 34.073638, Longitude = -84.677017 };
            var point2 = new Point() { Latitude = 32.92496, Longitude = -85.961342 };
            var point3 = new Point() { Latitude = 34.795116, Longitude = -86.97191 };
            var location1 = new MapPoints() { Location = point1, Name = "Location1", calculated = -1 };
            var location2 = new MapPoints() { Location = point2, Name = "Location2", calculated = -1 };
            var location3 = new MapPoints() { Location = point3, Name = "Location3", calculated = -1 };
            var dummyData = new List<MapPoints>() { location1, location2, location3};
            ShorterDistanceBetweenPoints(location1, location2, location3);

            void ShorterDistanceBetweenPoints(MapPoints one, MapPoints two, MapPoints three)
            {
                var locA = new GeoCoordinate() { Latitude = one.Location.Latitude, Longitude = one.Location.Longitude};
                var locB = new GeoCoordinate() { Latitude = two.Location.Latitude, Longitude = two.Location.Longitude };
                var locC = new GeoCoordinate() { Latitude = three.Location.Latitude, Longitude = three.Location.Longitude };
                var distanceAtoB = locA.GetDistanceTo(locB);
                var distanceAtoC = locA.GetDistanceTo(locC);
                var distanceBtoC = locB.GetDistanceTo(locC);
                var distanceCtoB = locC.GetDistanceTo(locB);
                //The two possibilites from the starting point
                if (distanceAtoB < distanceAtoC)
                {
                    //a to b (which is shorter than a to c) + b to c is shorter than a to c + c to b
                    if (distanceAtoB + distanceBtoC < distanceAtoC + distanceCtoB)
                    {
                        Console.WriteLine("Shorter to go from A to B to C");
                    }
                    else
                    {
                        Console.WriteLine("Shorter to go from A to C to B");
                    }
                }
                else //shorter from a to c than a to b
                {
                    if (distanceAtoC + distanceCtoB < distanceAtoB + distanceBtoC)
                    {
                        Console.WriteLine("Shorter to go from A to C to B");
                    }
                    else
                    {
                        Console.WriteLine("Shorter to go from A to B to C");
                    }
                }
            }
        }
    }
    
}
