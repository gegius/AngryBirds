using System;

namespace AngryBirds
{
	public static class AngryBirdsTask
	{
		// Ниже — это XML документация, её использует ваша среда разработки, 
		// чтобы показывать подсказки по использованию методов. 
		// Но писать её естественно не обязательно.
		/// <param name="v">Начальная скорость</param>
		/// <param name="distance">Расстояние до цели</param>
		/// <returns>Угол прицеливания в радианах от 0 до Pi/2</returns>
		public static double FindSightAngle(double v, double distance)
		{
			return 0.5 * Math.Asin((distance * 9.8) / (v * v));
		}

		static void Main(str[] args)
		{

		   internal var v = double.Parse(Console.ReadLine());
		   internal var distance = double.Parse(Console.ReadLine());
		   Console.WriteLine(FindSightAngle(v, distance));
	    }
    }

}