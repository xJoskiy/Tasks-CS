using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    public class Clock
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                int hours, minutes;
                float setDegrees;
                do
                {
                    Console.Write("Enter hours: ");

                    if (int.TryParse(Console.ReadLine(), out hours) && hours < 24 && hours >= 0)
                        break;

                    Console.WriteLine("Your input is not an integer number in the interval [0;24), try again");

                } while (true);

                do
                {
                    Console.Write("Enter minutes: ");

                    if (int.TryParse(Console.ReadLine(), out minutes) && minutes < 60 && minutes >= 0)
                        break;

                    Console.WriteLine("Your input is not an integer number in the interval [0;59), try again");

                } while (true);

                do
                {
                    Console.Write("Enter degrees: ");

                    if (float.TryParse(Console.ReadLine(), out setDegrees) && setDegrees <= 180 && setDegrees >= 0)
                        break;

                    Console.WriteLine("Your input is not an integer number in the interval [0;), try again");

                } while (true);

                Console.WriteLine();
                string time = ComputeTime(setDegrees, hours, minutes);
                Console.WriteLine(time + "\n");
            }
        }
        static public string ComputeTime(float setDegrees, int hours, int minutes)
        {
            float curDegree = ComputeDegree(hours, minutes);

            if (setDegrees >= curDegree)
                minutes += (int)Math.Ceiling((setDegrees - curDegree) / 5.5);
            else
                minutes += (int)((Math.Abs(360 - curDegree - setDegrees)) / 5.5);
                

            return String.Format((minutes % 60 > 9 ? "{0}:{1}" : "{0}:0{1}"), (hours + minutes / 60) % 24, minutes % 60);
        }
        static public float ComputeDegree(int hours, int minutes) // Угол между часовой и минутной считая по часовой стрелке
        {
            int minuteDegrees = 6 * minutes;
            float hourDegrees = 30 * hours % 360 + (float)minutes / 2;
            float angle = minuteDegrees - hourDegrees;

            return angle < 0 ? 360 + angle : angle;
        }
    }
}