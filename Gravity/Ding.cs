using System;
using System.Drawing;
using System.Reflection;

namespace Gravity
{
	internal class Ding
	{
		public int alder;

		public Color farve;

		public int hastighedX;

		public int hastighedY;

		public int hastighedZ;

		public Image image;

		public int masse;

		public float particles;

		public float positionX;

		public float positionY;

		public float positionZ;

		public Random rand = new Random();

		public double størrelse = 50.0;

		public int vinkel;

		public int intelligence;

		public int happy;

		public int funny;

		public int trader;

		public int violent;

		public int pretty;

		public int lawfull;

		public int GoodAtSex;

		public int Fertile;

		public int bossy;

		public int Enjoystravel;

		public int athlete;

		public string name;

		public int isGoodAtProgramming;

		public bool canAdjustCodeWhileRunning = true;

		public int afraid;

		public int designer;

		public int leader;

		public int perfectSoldier;

		public int regress;

		public int differentiate;

		public int easyGoing;

		public int GoodAtTeamWork;

		public int respect;

		public int lovesToProgram;

		public int buildTerrain;

		public int ChangeColor;

		public int ChangeAnyAttribute;

		public int ChangeSourceCode;

		public int CanStickToAnotherDing;

		public int CanChangeFormAndSize;

		public int WillingnessToGive;

		public int Moods;

		public int LikesToShare;

		public int valuta;

		public int resources;

		public Ding(int speed, int massen, int color, int size)
		{
			if (speed <= 0)
			{
				speed *= -1;
			}
			størrelse = size;
			hastighedX = rand.Next(speed);
			hastighedY = rand.Next(speed);
			hastighedZ = rand.Next(speed);
			positionX = rand.Next(10, 1000);
			positionY = rand.Next(30, 1000);
			positionZ = rand.Next(30, 3000);
			Assembly.GetExecutingAssembly();
			masse = massen;
			alder = 0;
			vinkel = rand.Next(-360, 360);
			if (color <= 0)
			{
				color *= -1;
			}
			farve = Color.FromArgb(rand.Next(color), rand.Next(color), rand.Next(color), rand.Next(color));
			alder = rand.Next(100);
			intelligence = rand.Next(300);
			happy = rand.Next(200);
			funny = rand.Next(1000);
			trader = rand.Next(100);
			violent = rand.Next(20);
			pretty = rand.Next(1000);
			lawfull = rand.Next(100, 200);
			GoodAtSex = rand.Next(1000);
			Fertile = rand.Next(alder);
			bossy = rand.Next(100);
			Enjoystravel = rand.Next(1000);
			athlete = rand.Next(1000);
			isGoodAtProgramming = rand.Next(100000, 20000000);
			afraid = rand.Next(100);
			designer = rand.Next(10000);
			leader = rand.Next(2000);
			perfectSoldier = rand.Next(10000);
			regress = rand.Next(10000);
			differentiate = rand.Next(10000);
			easyGoing = rand.Next(10000);
			respect = rand.Next(10000);
			GoodAtTeamWork = rand.Next(10000);
			lovesToProgram = rand.Next(10000);
			buildTerrain = rand.Next(10000);
			ChangeColor = rand.Next(10000);
			ChangeAnyAttribute = rand.Next(10000);
			ChangeSourceCode = rand.Next(10000);
			CanStickToAnotherDing = rand.Next(10000);
			CanChangeFormAndSize = rand.Next(10000);
			WillingnessToGive = rand.Next(10000);
			Moods = rand.Next(10000);
			LikesToShare = rand.Next(10000);
			valuta = rand.Next(1000000);
			resources = rand.Next(1000000);
		}

		public Ding()
		{
		}
	}
}
