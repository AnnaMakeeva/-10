using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Angle MyAngle = new Angle();     //создали объект


            Console.WriteLine("Введите количество градусов угла");
            MyAngle.Grade =double.Parse(Console.ReadLine());       // вводим 

            Console.WriteLine("Введите количество минут угла");
            MyAngle.Minutes = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество секунд угла");
            MyAngle.Seconds = double.Parse(Console.ReadLine());

            MyAngle.Calc();

            Console.WriteLine("Значение данного угла в радианах={0}", +MyAngle.Radians);
            Console.ReadKey();



        }
    }

    class Angle
    {
        public double Grade    //класс-описали
        {
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Градус не может быть отрицательным");//исключения
                }
                else if (value > 360)
                {
                    Console.WriteLine("Градус не может быть больше 360");//исключения
                }
                else
                {
                    Grade = value;
                }
            }

            get
            {
                return Grade;
            }
        }   

           
        public double Minutes
        {
            set
            {
                if (value< 0)
                {
                    Console.WriteLine("Минуты не могут быть отрицательными");//исключения
                }
                else if (value > 60)
                {
                    Console.WriteLine("Минуты не могут быть больше 60");//исключения
                }
                else
                {
                    Minutes = value;
                }
            }
            get
            {
             return Minutes;
            }
        }   


        public double Seconds

        {
            set
            {
                if (value< 0)
                {
                    Console.WriteLine("Секунды не могут быть отрицательными");//исключения
                }
                else if (value > 60)
                {
                    Console.WriteLine("Секунды не могут быть больше 60");//исключения
                }
                else
                {
                   Seconds = value;
                }
            }
            get
            {
               return Seconds;
            }
        }   

        public double Radians;

        public void Calc()   //перевод-формула
        {
            Radians = (Grade + Minutes / 60 + Seconds / 3600) * (Math.PI) / 180;
        }
    }

}
