using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    internal class Clock
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
            bool up = true;
            for (int h = hours, m = minutes + 1; h != (h + 2) % 24; m++)
            {
                h = (h + m / 60) % 24;
                m %= 60;
                if (up)
                {
                    curDegree += 5.5f;
                    if (curDegree > 180)
                    {
                        curDegree = 180 - curDegree % 180;
                        up = false;
                    }
                    if (curDegree <= setDegrees)
                    {
                        minutes = m;
                        hours = h;
                        break;
                    }
                }
                else
                {
                    curDegree -= 5.5f;
                    if (curDegree < 0)
                    {
                        curDegree = Math.Abs(curDegree);
                        up = true;
                    }
                    if (curDegree >= setDegrees)
                    {
                        minutes = m;
                        hours = h;
                        break;
                    }
                }
            }
            return String.Format("{0}:{1}", hours, minutes);
        }
        static public float ComputeDegree(int hours, int minutes)
        {
            int minuteDegrees = 6 * minutes;
            float hourDegrees = 30 * hours % 360 + (float)minutes / 2;
            float angle = Math.Abs(minuteDegrees - hourDegrees);

            return angle > 180 ? 360 - angle : angle;
        }
    }
}