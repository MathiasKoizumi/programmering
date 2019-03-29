using System;
using System.Drawing;
using System.Reflection;

namespace Gravity
{
	internal class Ding
	{
		public Random rand = new Random();

		public bool canAdjustCodeWhileRunning = true;

		public Persona persona;

		public Int32 alder
		{
			get;
			set;
		}

		public Color farve
		{
			get;
			set;
		}

		public Int32 hastighedX
		{
			get;
			set;
		}

		public Int32 hastighedY
		{
			get;
			set;
		}

		public Int32 hastighedZ
		{
			get;
			set;
		}

		public Image image
		{
			get;
			set;
		}

		public Int32 masse
		{
			get;
			set;
		}

		public float particles
		{
			get;
			set;
		}

		public float positionX
		{
			get;
			set;
		}

		public float positionY
		{
			get;
			set;
		}

		public float positionZ
		{
			get;
			set;
		}

		public double størrelse
		{
			get;
			set;
		}

		public Int32 vinkel
		{
			get;
			set;
		}

		public Int32 intelligence
		{
			get;
			set;
		}

		public Int32 happy
		{
			get;
			set;
		}

		public Int32 funny
		{
			get;
			set;
		}

		public Int32 trader
		{
			get;
			set;
		}

		public Int32 violent
		{
			get;
			set;
		}

		public Int32 pretty
		{
			get;
			set;
		}

		public Int32 lawfull
		{
			get;
			set;
		}

		public Int32 GoodAtSex
		{
			get;
			set;
		}

		public Int32 Fertile
		{
			get;
			set;
		}

		public Int32 bossy
		{
			get;
			set;
		}

		public Int32 Enjoystravel
		{
			get;
			set;
		}

		public Int32 athlete
		{
			get;
			set;
		}

		public string name
		{
			get;
			set;
		}

		public Int32 isGoodAtProgramming
		{
			get;
			set;
		}

		public Int32 afraid
		{
			get;
			set;
		}

		public Int32 designer
		{
			get;
			set;
		}

		public Int32 leader
		{
			get;
			set;
		}

		public Int32 perfectSoldier
		{
			get;
			set;
		}

		public Int32 regress
		{
			get;
			set;
		}

		public Int32 differentiate
		{
			get;
			set;
		}

		public Int32 easyGoing
		{
			get;
			set;
		}

		public Int32 GoodAtTeamWork
		{
			get;
			set;
		}

		public Int32 respect
		{
			get;
			set;
		}

		public Int32 lovesToProgram
		{
			get;
			set;
		}

		public Int32 buildTerrain
		{
			get;
			set;
		}

		public Int32 ChangeColor
		{
			get;
			set;
		}

		public Int32 ChangeAnyAttribute
		{
			get;
			set;
		}

		public Int32 ChangeSourceCode
		{
			get;
			set;
		}

		public Int32 CanStickToAnotherDing
		{
			get;
			set;
		}

		public Int32 CanChangeFormAndSize
		{
			get;
			set;
		}

		public Int32 WillingnessToGive
		{
			get;
			set;
		}

		public Int32 Moods
		{
			get;
			set;
		}

		public Int32 LikesToShare
		{
			get;
			set;
		}

		public Int32 WeHavevalutaAndCanSpendSome
		{
			get;
			set;
		}

		public Int32 UseResources
		{
			get;
			set;
		}

		public Int32 HasGenes
		{
			get;
			set;
		}

		public Int32 CanHaveOffspring
		{
			get;
			set;
		}

		public Int32 CanHaveSexThatLeadsToPregnancy
		{
			get;
			set;
		}

		public Int32 CanEasilyKill
		{
			get;
			set;
		}

		public Int32 MustUpgradeGraphics
		{
			get;
			set;
		}

		public Int32 BelieveInManyReligions
		{
			get;
			set;
		}

		public Int32 SpeakThroughAudioSystem
		{
			get;
			set;
		}

		public Int32 KnowAlotAboutScience
		{
			get;
			set;
		}

		public Int32 JegKanMåVilMåskeSkal
		{
			get;
			set;
		}

		public Int32 WeHaveManyFastComputers
		{
			get;
			set;
		}

		public Int32 CanAddSpeed
		{
			get;
			set;
		}

		public Int32 SexIsBetterTheHighTheScore
		{
			get;
			set;
		}

		public Int32 WeMayDoAnythingWeWant
		{
			get;
			set;
		}

		public Int32 ableToMakeFastDecisions
		{
			get;
			set;
		}

		public Int32 Dicipline
		{
			get;
			set;
		}

		public Int32 Morale
		{
			get;
			set;
		}

		public double WeHaveAllNeedToTerraform
		{
			get;
			set;
		}

        public Int32 EveryColorCellRepresentsADifferentPartOfTheSameMind
        {
            get;
            set;
        }

        public Material WhatIHave
		{
			get;
			set;
		}

		public Ding(Int32 speed, Int32 massen, Int32 color, Int32 size)
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
			alder = Int32.MaxValue;
			intelligence = Int32.MaxValue;
			happy = Int32.MaxValue;
			funny = Int32.MaxValue;
			trader = Int32.MaxValue;
			violent = Int32.MaxValue;
			pretty = Int32.MaxValue;
			lawfull = Int32.MaxValue;
			GoodAtSex = Int32.MaxValue;
			Fertile = Int32.MaxValue;
			bossy = Int32.MaxValue;
			Enjoystravel = Int32.MaxValue;
			athlete = Int32.MaxValue;
			isGoodAtProgramming = Int32.MaxValue;
			afraid = Int32.MaxValue;
			designer = Int32.MaxValue;
			leader = Int32.MaxValue;
			perfectSoldier = Int32.MaxValue;
			regress = Int32.MaxValue;
			differentiate = Int32.MaxValue;
			easyGoing = Int32.MaxValue;
			respect = Int32.MaxValue;
			GoodAtTeamWork = Int32.MaxValue;
			lovesToProgram = Int32.MaxValue;
			buildTerrain = Int32.MaxValue;
			ChangeColor = Int32.MaxValue;
			ChangeAnyAttribute = Int32.MaxValue;
			ChangeSourceCode = Int32.MaxValue;
			CanStickToAnotherDing = Int32.MaxValue;
			CanChangeFormAndSize = Int32.MaxValue;
			WillingnessToGive = Int32.MaxValue;
			Moods = Int32.MaxValue;
			LikesToShare = Int32.MaxValue;
			WeHavevalutaAndCanSpendSome = Int32.MaxValue;
			UseResources = Int32.MaxValue;
			HasGenes = Int32.MaxValue;
			CanHaveOffspring = Int32.MaxValue;
			CanHaveSexThatLeadsToPregnancy = Int32.MaxValue;
			ableToMakeFastDecisions = Int32.MaxValue;
			MustUpgradeGraphics = Int32.MaxValue;
			BelieveInManyReligions = Int32.MaxValue;
			SpeakThroughAudioSystem = Int32.MaxValue;
			KnowAlotAboutScience = Int32.MaxValue;
			JegKanMåVilMåskeSkal = Int32.MaxValue;
			WeHaveManyFastComputers = Int32.MaxValue;
			CanAddSpeed = Int32.MaxValue;
			WeMayDoAnythingWeWant = Int32.MaxValue;
			Dicipline = Int32.MaxValue;
			Morale = Int32.MaxValue;
            EveryColorCellRepresentsADifferentPartOfTheSameMind = Int32.MaxValue;

        }

		public Ding()
		{
		}
	}
}
