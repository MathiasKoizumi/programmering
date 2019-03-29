using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LearnBot
{
	public class Form1 : Form
	{
		private Random rand = new Random();

		private string path = "C:\\test\\";

		public string WriteItToPath;

		private IContainer components;

		private Label label1;

		public Form1()
		{
			InitializeComponent();
		}

		private bool MyBool()
		{
			if (rand.Next(0, 100) < 70)
			{
				return false;
			}
			return true;
		}

		private void Dothis()
		{
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
			label1 = new System.Windows.Forms.Label();
			SuspendLayout();
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 36f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label1.Location = new System.Drawing.Point(121, 134);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(420, 65);
			label1.TabIndex = 0;
			label1.Text = "Active Let it run....";
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(800, 450);
			base.Controls.Add(label1);
			base.Name = "Form1";
			Text = "Form1";
			base.Load += new System.EventHandler(Form1_Load);
			ResumeLayout(performLayout: false);
			PerformLayout();
		}
	}
}
