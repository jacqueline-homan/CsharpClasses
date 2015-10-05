﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Critters;
using Vehicles;

namespace Critters
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Animal newAnimal = new Animal();
			newAnimal.move();
			Animal Dog = new Animal ();
			Dog.Age = 2;
			Console.WriteLine (Dog.Age);

			Dog Spot = new Dog ();
			Spot.Age = 5;
			Spot.move ();
			Spot.NumOfLegs = 4;
			Spot.makeNoise ();

			Car myCar = new Car ();
			myCar.make = "Ford";
			myCar.model = "F-150";
			myCar.color = "Hunter Green";

			myCar.drive();
			myCar.stop();
				
		}



	}
}
