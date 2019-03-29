using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Thinker
{
	public class Form1 : Form
	{
		private Random r = new Random();

		private IContainer components;

		public Form1()
		{
			InitializeComponent();
			Runner();
		}

		private int MyBool()
		{
			return r.Next(0, 100);
		}

		private void Dothis()
		{
			int num = MyBool();
			int num2 = MyBool();
			int num3 = MyBool();
			int num4 = MyBool();
			int num5 = MyBool();
			int num6 = MyBool();
			int num7 = MyBool();
			int num8 = MyBool();
			int num9 = MyBool();
			int num10 = MyBool();
			int num11 = MyBool();
			int num12 = MyBool();
			int num13 = MyBool();
			int num14 = MyBool();
			int num15 = MyBool();
			int num16 = MyBool();
			int num17 = MyBool();
			int num18 = MyBool();
			int num19 = MyBool();
			int num20 = MyBool();
			int num21 = MyBool();
			int num22 = MyBool();
			int num23 = MyBool();
			int num24 = MyBool();
			int num25 = MyBool();
			int num26 = MyBool();
			int num27 = MyBool();
			int num28 = MyBool();
			int num29 = MyBool();
			int num30 = MyBool();
			int num31 = MyBool();
			int num32 = MyBool();
			int num33 = MyBool();
			int num34 = MyBool();
			int num35 = MyBool();
			int num36 = MyBool();
			int num37 = MyBool();
			int num38 = MyBool();
			int num39 = MyBool();
			int num40 = MyBool();
			int num41 = MyBool();
			int num42 = MyBool();
			int num43 = MyBool();
			int num44 = MyBool();
			int num45 = MyBool();
			int num46 = MyBool();
			int num47 = MyBool();
			int num48 = MyBool();
			int num49 = MyBool();
			int num50 = MyBool();
			int num51 = MyBool();
			int num52 = MyBool();
			int num53 = MyBool();
			int num54 = MyBool();
			int num55 = MyBool();
			int num56 = MyBool();
			int num57 = MyBool();
			int num58 = MyBool();
			int num59 = MyBool();
			int num60 = MyBool();
			int num61 = MyBool();
		}

		private void Runner()
		{
			while (true)
			{
				Dothis();
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
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
			base.ClientSize = new System.Drawing.Size(228, 89);
			base.Name = "Form1";
			Text = "Its thinking...";
			base.Load += new System.EventHandler(Form1_Load);
			ResumeLayout(performLayout: false);
		}
	}
}
