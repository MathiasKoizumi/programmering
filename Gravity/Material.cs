using System;

namespace Gravity
{
	internal class Material
	{
		private Random r = new Random();

		private int dung
		{
			get;
			set;
		}

		private int soil
		{
			get;
			set;
		}

		private int rocks
		{
			get;
			set;
		}

		private int water
		{
			get;
			set;
		}

		private int seeds
		{
			get;
			set;
		}

		private int animals
		{
			get;
			set;
		}

		private int minerals
		{
			get;
			set;
		}

		private int elements
		{
			get;
			set;
		}

		private int sand
		{
			get;
			set;
		}

		private int food
		{
			get;
			set;
		}

		private int wood
		{
			get;
			set;
		}

		private int granite
		{
			get;
			set;
		}

		private int saltwater
		{
			get;
			set;
		}

		private int freshwater
		{
			get;
			set;
		}

		public Material()
		{
			dung = r.Next(50000, 55000);
			soil = r.Next(50000, 55000);
			rocks = r.Next(50000, 55000);
			water = r.Next(50000, 55000);
			seeds = r.Next(50000, 55000);
			animals = r.Next(50000, 55000);
			minerals = r.Next(50000, 55000);
			elements = r.Next(50000, 55000);
			sand = r.Next(50000, 55000);
			food = r.Next(50000, 55000);
			wood = r.Next(50000, 55000);
			granite = r.Next(50000, 55000);
			saltwater = r.Next(50000, 55000);
			freshwater = r.Next(50000, 55000);
		}
	}
}
