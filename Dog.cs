using System;

namespace Critters
{
	class Dog : Animal
	{
		public string name;
		public string owner;

		public string Owner 
		{
			get {return this.owner;}
			set { this.owner = value; }
		}

		public string Name 
		{
			get {return this.name;}
			set { this.name = value; }
		}

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

