using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_Exercise___08.Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double volumeOfBiggestKeg = 0;
            string biggestVolumeKegName = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string kegModel = Console.ReadLine();
                double radious = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                double kegVolume = Math.PI * radious * radious * height;

                if (kegVolume > volumeOfBiggestKeg)
                {
                    volumeOfBiggestKeg = kegVolume;
                    biggestVolumeKegName = kegModel;
                }


            }

            Console.WriteLine(biggestVolumeKegName);
        }
    }
}
