using System;

namespace P05TrainingLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Учебна зала има правоъгълен размер w на h метра, без колони във вътрешността си.
            //Залата е разделена на две части – лява и дясна, с коридор приблизително по средата.
            //В лявата и в дясната част има редици с бюра. В задната част на залата има голяма входна врата.
            //В предната част на залата има катедра с подиум за преподавателя.
            //Едно работно място заема 70 на 120 cm (маса с размер 70 на 40 cm + място за стол и преминаване с размер 70 на 80 cm).
            //Коридорът е широк поне 100 cm. Изчислено е, че заради входната врата (която е с отвор 160 cm) се губи точно
            //1 работно място, а заради катедрата (която е с размер 160 на 120 cm) се губят точно 2 работни места.
            //Напишете програма, която въвежда размери на учебната зала и изчислява броя работни места в нея при описаното разположение
            //(вж. фигурата). 

            double sideW = double.Parse(Console.ReadLine());
            double sideH = double.Parse(Console.ReadLine());
            double sideWinSm = sideW * 100;
            int sideWintSmInt = (int)sideWinSm;
            double sideHinSm = sideH * 100;
            double sideHwithCoridor = sideHinSm - 100;
            int sideHwithCoridorInt = (int)sideHwithCoridor;
            int workPlaceH = 70;
            int placesPerH = sideHwithCoridorInt / workPlaceH;
            int workPlaceW = 120;
            int placesPerW = sideWintSmInt / workPlaceW;
            double allPlaces = placesPerW * placesPerH - 3;
            Console.WriteLine(allPlaces);
        }
    }
}
