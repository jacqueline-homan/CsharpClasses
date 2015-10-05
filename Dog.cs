using System;

namespace Critters
{
	class Dog : Animal
	{
		public string name;
		public string owner;

		public override void move()
		{
			//base.move ();
			Console.WriteLine("Running");
		}

		public override void makeNoise()
		{
			Console.WriteLine ("Barking");
		}

	}
}

