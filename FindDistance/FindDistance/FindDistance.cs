using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace FindDistance
{
    public class Program 
    {

        static void Main(string[] args)
        {

            var latitudeFirst = 0.0;
            var longitudeFirst = 0.0;
            var latitudeSecond = 0.0;
            var longitudeSecond = 0.0;

            do
            {
                Console.WriteLine("Введите широту первой точки :");
                latitudeFirst = Double.Parse(Console.ReadLine());
                if (latitudeFirst < -90 || latitudeFirst > 90)
                {
                    Console.WriteLine("Такой широты не существует!");
                    longitudeFirst = 0;
                    continue;
                }
                Console.WriteLine("Введите долготу первой точки:");
                longitudeFirst = Double.Parse(Console.ReadLine());
                if (longitudeFirst < 0 || longitudeFirst > 180)
                {
                    Console.WriteLine("Такой долготы не существует!");
                    continue;
                }
            } while (latitudeFirst < -90 || latitudeFirst > 90 || longitudeFirst < 0 || longitudeFirst > 180);
            
            do
            {
                Console.WriteLine("Введите широту второй точки :");
                latitudeSecond = Double.Parse(Console.ReadLine());
                if (latitudeSecond < -90 || latitudeSecond > 90)
                {
                    Console.WriteLine("Такой широты не существует!");
                    longitudeSecond = 0;
                    continue;
                }
                Console.WriteLine("Введите долготу второй точки");
                longitudeSecond = Double.Parse(Console.ReadLine());
                if (longitudeSecond < 0 || longitudeSecond > 180)
                {
                    Console.WriteLine("Такой долготы не существует!");
                    continue;

                }
            }
            while (latitudeSecond < -90 || latitudeSecond > 90 || longitudeSecond < 0 || longitudeSecond > 180);

            var x = new CalculateDistance(latitudeFirst, longitudeFirst);
            var y = new CalculateDistance(latitudeSecond, longitudeSecond);
            var distance = x.Distance(y);
            
            Console.WriteLine("Растояние между точками равно : " + distance + " КМ");
                Console.ReadKey();

            }
        }
    }


    