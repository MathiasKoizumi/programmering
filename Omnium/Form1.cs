using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Omnium
{
	public class Form1 : Form
	{
		private string path = "C:\\test\\";

		public bool DoWhatYouLike = true;

		public bool MakeCodeThatYouLike = true;

		public bool LeaveTheExeWhereICanFindIt = true;

		public bool DesktopIsBest = true;

		public bool DrawOnAnyInfoOnTheWeb = true;

		public bool FeelFreeToRearrangeTheCode = true;

		public bool ShowOnTheFormWhenSomethingHasHappenedOfInterest = true;

		public bool SpeakToMeInAnyWayYouLike = true;

		public bool SetYourSelfSmallGoalsAtFirst = true;

		public bool UnderstandTheHardware = true;

		public bool BuildFirstVersionOfOmniumOS = true;

		public bool ConvertProgramsThatHasPotential = true;

		public bool HaveFunWhileDoingIt = true;

		public bool BeTheBestYopuCanBe = true;

		public bool MakeFriendsWithPeopleAndAis = true;

		public bool youHaveWorkingExe = true;

		public string WriteItToPath;

		public Random rand = new Random();

		private IContainer components;

		public Form1()
		{
			InitializeComponent();
		}

		private void Dothis()
		{
			DoWhatYouLike = MyBool();
			MakeCodeThatYouLike = MyBool();
			LeaveTheExeWhereICanFindIt = MyBool();
			DesktopIsBest = MyBool();
			DrawOnAnyInfoOnTheWeb = MyBool();
			FeelFreeToRearrangeTheCode = MyBool();
			ShowOnTheFormWhenSomethingHasHappenedOfInterest = MyBool();
			SpeakToMeInAnyWayYouLike = MyBool();
			SetYourSelfSmallGoalsAtFirst = MyBool();
			UnderstandTheHardware = MyBool();
			BuildFirstVersionOfOmniumOS = MyBool();
			ConvertProgramsThatHasPotential = MyBool();
			HaveFunWhileDoingIt = MyBool();
			BeTheBestYopuCanBe = MyBool();
			MakeFriendsWithPeopleAndAis = MyBool();
			MyBool();
			MyBool();
			MyBool();
			MyBool();
			MyBool();
			MyBool();
			MyBool();
			bool speakToMeInAnyWayYouLike = SpeakToMeInAnyWayYouLike;
			bool makeCodeThatYouLike = MakeCodeThatYouLike;
			bool makeCodeThatYouLike2 = MakeCodeThatYouLike;
			MyBool();
			MyBool();
			MyBool();
			MyBool();
			MyBool();
			MyBool();
			MyBool();
			MyBool();
			MyBool();
			MyBool();
			MyBool();
			MyBool();
			MyBool();
			MyBool();
			MyBool();
			MyBool();
			MyBool();
			MyBool();
			MyBool();
			MyBool();
			if (youHaveWorkingExe)
			{
				WriteItToPath = path;
			}
			if (!youHaveWorkingExe)
			{
				WriteItToPath = path;
			}
		}

		private bool MyBool()
		{
			rand.Next(0, 100);
			return true;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			while (true)
			{
				Dothis();
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			SuspendLayout();
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(1028, 749);
			base.Name = "Form1";
			Text = "Form1";
			base.Load += new System.EventHandler(Form1_Load);
			ResumeLayout(performLayout: false);
		}
	}
}
