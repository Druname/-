using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindDistance
{

    public class GeoPoint
    {
        public double latitudeFirst;
        public double longitudeFirst;

    }

        public class CalculateDistance : GeoPoint
        {
        public CalculateDistance(double latitudeFirst, double longitudeFirst) 
        {
            this.latitudeFirst = latitudeFirst;
            this.longitudeFirst = longitudeFirst;
        }

        public double Distance(GeoPoint y)
            {
                var longitude = inRad(this.longitudeFirst - y.longitudeFirst);
                var latitude = inRad(this.latitudeFirst - y.latitudeFirst);

                var a = Math.Pow(Math.Sin(latitude / 2), 2) +
                    Math.Cos(inRad(this.latitudeFirst)) *
                    Math.Cos(inRad(y.latitudeFirst)) *
                    Math.Pow(Math.Sin(longitude / 2), 2);

                var c = 2 * Math.Asin(Math.Sqrt(a));

                var earthRadiusInKms = 6371;
                var distance = earthRadiusInKms * c;
                distance = Convert.ToInt32(distance);
                return distance;


            }
            private double inRad(double inRad)
            {
                return inRad * (Math.PI / 180);
            }


        }
    }

    
