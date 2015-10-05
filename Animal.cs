using System;

namespace Critters
{
	class Animal
	{
		private string type;
		private string color;
		private float weight;
		private float height;
		private int age;
		private int numOfLegs;

		public int Age //Same as 'attr_accessor' in Ruby
		{
			get {return this.age;} //getter method
			set 
			{ 
				if (value < 0) {
					Console.WriteLine ("Age cannot be less than 0");
				} else 
				{
					this.age = value;
				}

				this.age = value;
			} //setter method

		}

		public string Type 
		{
			get {return this.type;}
			set { this.type = value; }
		}

		public float Weight
		{
			get { return this.weight; }
			set 
			{
				if (value < 0 || value == 0) {
					Console.WriteLine("Weight cannot be less than or equal to zero");
				} else
				{
					this.weight = value;
				}
				this.weight = value;
					
			}
		}

		public float Height
		{
			get { return this.height; }
			set 
			{
				if (value < 0 || value == 0) 
				{
					Console.WriteLine ("Height cannot be less than or equal to zero");
				} else 
				{
					this.height = value;
				}
				this.height = value;
			}
		}

		public string Color 
		{
			get { return this.color; }
			set { this.color = value; }
		}

		public int NumOfLegs 
		{
			get { return this.numOfLegs; }
			set { this.numOfLegs = value; }
		}



		public virtual void move()
		{
			Console.WriteLine ("Moved");
		}

		public virtual void makeNoise()
		{
			Console.WriteLine ("Made noise");
		}
	}
}

