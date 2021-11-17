using System;

namespace PulseRate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isPeak = false;
            double totalBill = 0.0;

            Console.WriteLine("Enter a date: ");

            DateTime startTime = DateTime.Parse(Console.ReadLine());

            DateTime endTime = DateTime.Parse(Console.ReadLine());

            double getRate(bool isPeak)
            {
                if (isPeak)
                    return 0.30;
                else
                    return 0.20;
            }

            while(startTime <= endTime)
            {
                if (!isPeak)
                {
                    if (startTime.AddSeconds(20).Hour >= 9 && startTime.Hour < 23)
                        isPeak = true;
                    else
                        isPeak = false;
                }

                startTime = startTime.AddSeconds(20);
                totalBill += getRate(isPeak);                
            }

            Console.WriteLine("Bill:" + totalBill);
            Console.ReadLine();
        }
    }
}
