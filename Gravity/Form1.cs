using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Gravity
{
	public class Form1 : Form
	{
		private NumericUpDown antalObjekter;

		private Bitmap bitmap;

		private Button button2;

		private CheckBox checkBox1;

		private CheckBox checkBox2;

		private CheckBox checkBox4;

		private CheckBox checkBox5;

		private IContainer components;

		private Graphics g;

		private Label label1;

		private Label label2;

		private Label label3;

		private Label label4;

		private Label label5;

		private Label label6;

		private NumericUpDown numericUpDown1;

		private NumericUpDown numericUpDown2;

		private NumericUpDown numericUpDown4;

		private Ding[] objekter;

		private Panel panel1;

		private Random rand;

		private NumericUpDown rounds;

		private NumericUpDown sizeDrops;

		private NumericUpDown speed;

		private int spredning;

		private Button button1;

		private Button button3;

		private bool mayAll = true;

		private bool programOn = true;

		private bool EvovleAllMyPrograms = true;

		private bool AddAnyCodeYouLikeAnywhere = true;

		private bool DoWhatEverYouWant = true;

		private bool BeInventive = true;

		private bool ModifyMyCode = true;

		private bool MakeFileEXEonDesktopWithDescriptiveName = true;

		private bool enhanceProgrammingSkills = true;

		private CheckBox checkBox3;

		private CheckBox checkBox6;

		private bool infinityOn = true;

		private string path = "C:\\test\\";
        private CheckBox checkBox7;
        public string WriteItToPath;

		private bool MyBool()
		{
			int num = rand.Next(0, 100);
			if (num < 70)
			{
				return false;
			}
			return true;
		}

		private void Dothis()
		{
			bool flag = MyBool();
			bool flag2 = MyBool();
			bool flag3 = MyBool();
			bool flag4 = MyBool();
			bool flag5 = MyBool();
			bool flag6 = MyBool();
			bool flag7 = MyBool();
			bool flag8 = MyBool();
			bool flag9 = MyBool();
			bool flag10 = MyBool();
			bool flag11 = MyBool();
			bool flag12 = MyBool();
			bool flag13 = MyBool();
			bool flag14 = MyBool();
			bool flag15 = MyBool();
			bool flag16 = MyBool();
			bool flag17 = MyBool();
			bool flag18 = MyBool();
			bool flag19 = MyBool();
			bool flag20 = MyBool();
			bool flag21 = MyBool();
			bool flag22 = MyBool();
			bool flag23 = MyBool();
			bool flag24 = MyBool();
			bool flag25 = MyBool();
			bool flag26 = MyBool();
			bool flag27 = MyBool();
			bool flag28 = MyBool();
			bool flag29 = MyBool();
			bool flag30 = MyBool();
			bool flag31 = MyBool();
			bool flag32 = MyBool();
			bool flag33 = MyBool();
			bool flag34 = MyBool();
			bool flag35 = MyBool();
			bool flag36 = MyBool();
			bool flag37 = MyBool();
			bool flag38 = MyBool();
			bool flag39 = MyBool();
			bool flag40 = MyBool();
			bool flag41 = MyBool();
			bool flag42 = MyBool();
			bool flag43 = MyBool();
			bool flag44 = MyBool();
			bool flag45 = MyBool();
			bool flag46 = MyBool();
			bool flag47 = MyBool();
			bool flag48 = MyBool();
			bool flag49 = MyBool();
			bool flag50 = MyBool();
			bool flag51 = MyBool();
			bool flag52 = MyBool();
		}

		private void animate()
		{
			for (int i = 0; i < objekter.Length; i++)
			{
				objekter[i].positionX = objekter[i].positionX + (float)objekter[i].hastighedX;
				objekter[i].positionY = objekter[i].positionY + (float)objekter[i].hastighedY;
				objekter[i].positionZ = objekter[i].positionZ + (float)objekter[i].hastighedZ;
				switch (rand.Next(-2, 2))
				{
				case 0:
					objekter[i].hastighedX = rand.Next(-(int)speed.Value, (int)speed.Value);
					objekter[i].hastighedY = rand.Next(-(int)speed.Value, (int)speed.Value);
					objekter[i].hastighedZ = rand.Next(-(int)speed.Value, (int)speed.Value);
					break;
				case 1:
					objekter[i].hastighedX = -rand.Next(-(int)speed.Value, (int)speed.Value);
					objekter[i].hastighedY = -rand.Next(-(int)speed.Value, (int)speed.Value);
					objekter[i].hastighedZ = -rand.Next(-(int)speed.Value, (int)speed.Value);
					break;
				}
				objekter[i].alder = objekter[i].alder + rand.Next(spredning, spredning);
				objekter[i].athlete = objekter[i].athlete + rand.Next(spredning, spredning);
				objekter[i].bossy = objekter[i].bossy + rand.Next(spredning, spredning);
				objekter[i].Enjoystravel = objekter[i].Enjoystravel + rand.Next(spredning, spredning);
				objekter[i].Fertile = objekter[i].Fertile + rand.Next(spredning, spredning);
				objekter[i].funny = objekter[i].funny + rand.Next(spredning, spredning);
				objekter[i].GoodAtSex = objekter[i].GoodAtSex + rand.Next(spredning, spredning);
				objekter[i].happy = objekter[i].happy + rand.Next(spredning, spredning);
				objekter[i].intelligence = objekter[i].intelligence + rand.Next(spredning, spredning);
				objekter[i].lawfull = objekter[i].lawfull + rand.Next(spredning, spredning);
				objekter[i].pretty = objekter[i].pretty + rand.Next(spredning, spredning);
				objekter[i].isGoodAtProgramming = objekter[i].isGoodAtProgramming + rand.Next(spredning, spredning);
				objekter[i].afraid = objekter[i].afraid + rand.Next(spredning, spredning);
				objekter[i].buildTerrain = objekter[i].buildTerrain + rand.Next(spredning, spredning);
				objekter[i].canAdjustCodeWhileRunning = true;
				objekter[i].CanChangeFormAndSize = objekter[i].CanChangeFormAndSize + rand.Next(spredning, spredning);
				objekter[i].CanStickToAnotherDing = objekter[i].CanStickToAnotherDing + rand.Next(spredning, spredning);
				objekter[i].ChangeAnyAttribute = objekter[i].ChangeAnyAttribute + rand.Next(spredning, spredning);
				objekter[i].ChangeColor = objekter[i].ChangeColor + rand.Next(spredning, spredning);
				objekter[i].ChangeSourceCode = objekter[i].ChangeSourceCode + rand.Next(spredning, spredning);
				objekter[i].designer = objekter[i].designer + rand.Next(spredning, spredning);
				objekter[i].differentiate = objekter[i].differentiate + rand.Next(spredning, spredning);
				objekter[i].easyGoing = objekter[i].easyGoing + rand.Next(spredning, spredning);
				objekter[i].GoodAtTeamWork = objekter[i].GoodAtTeamWork + rand.Next(spredning, spredning);
				objekter[i].LikesToShare = objekter[i].LikesToShare + rand.Next(spredning, spredning);
				objekter[i].lovesToProgram = objekter[i].lovesToProgram + rand.Next(spredning, spredning);
				objekter[i].Moods = objekter[i].Moods + rand.Next(spredning, spredning);
				objekter[i].name = objekter[i].name + rand.Next(spredning, spredning);
				objekter[i].particles = objekter[i].particles + (float)rand.Next(spredning, spredning);
				objekter[i].perfectSoldier = objekter[i].perfectSoldier + rand.Next(spredning, spredning);
				objekter[i].regress = objekter[i].regress + rand.Next(spredning, spredning);
				objekter[i].respect = objekter[i].respect + rand.Next(spredning, spredning);
				objekter[i].trader = objekter[i].trader + rand.Next(spredning, spredning);
				objekter[i].valuta = objekter[i].valuta + rand.Next(spredning, spredning);
				objekter[i].violent = objekter[i].violent + rand.Next(spredning, spredning);
				objekter[i].WillingnessToGive = objekter[i].WillingnessToGive + rand.Next(spredning, spredning);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			designObjekter((int)antalObjekter.Value, (int)speed.Value);
			while (true)
			{
				Dothis();
				DrawPaintMe();
				BeActiveAndConsiuous();
				button1_Click(null, null);
			}
		}

		private void Form1_MouseClick(object sender, MouseEventArgs e)
		{
			throw new NotImplementedException();
		}

		private void designObjekter(int number, int speed)
		{
			objekter = new Ding[number];
			for (int i = 0; i < number; i++)
			{
				Ding ding = new Ding(rand.Next(-speed, speed), rand.Next(-10, 10), rand.Next(-255, 255), (int)sizeDrops.Value);
				objekter[i] = ding;
			}
		}

		private void DrawPaintMe()
		{
			Bitmap image = new Bitmap(bitmap.Width, bitmap.Height);
			Graphics graphics = Graphics.FromImage(image);
			graphics = Graphics.FromImage(image);
			graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
			graphics.DrawImage(bitmap, 0, 0);
			for (int i = 0; i < objekter.Length; i++)
			{
				graphics.FillEllipse(new SolidBrush(objekter[i].farve), objekter[i].positionX, objekter[i].positionY, (int)objekter[i].størrelse, (int)objekter[i].størrelse);
			}
			graphics.Save();
			g.DrawImage(image, 0, 0);
			animate();
		}

		private void InitializeComponent()
		{
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.antalObjekter = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.sizeDrops = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.rounds = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.speed = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.antalObjekter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeDrops)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rounds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speed)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(-9, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1266, 591);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(22, 624);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 626);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gravity";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(193, 606);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(96, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Affect particles";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(193, 631);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(88, 17);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "Particle mass";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(287, 627);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(61, 20);
            this.numericUpDown2.TabIndex = 6;
            this.numericUpDown2.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // antalObjekter
            // 
            this.antalObjekter.Location = new System.Drawing.Point(972, 679);
            this.antalObjekter.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.antalObjekter.Name = "antalObjekter";
            this.antalObjekter.Size = new System.Drawing.Size(47, 20);
            this.antalObjekter.TabIndex = 7;
            this.antalObjekter.Value = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.antalObjekter.ValueChanged += new System.EventHandler(this.antalObjekter_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(885, 682);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Number objects";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Location = new System.Drawing.Point(761, 631);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(55, 17);
            this.checkBox4.TabIndex = 10;
            this.checkBox4.Text = "Shield";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(822, 630);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(57, 20);
            this.numericUpDown4.TabIndex = 11;
            this.numericUpDown4.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // sizeDrops
            // 
            this.sizeDrops.Location = new System.Drawing.Point(914, 630);
            this.sizeDrops.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.sizeDrops.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.sizeDrops.Name = "sizeDrops";
            this.sizeDrops.Size = new System.Drawing.Size(40, 20);
            this.sizeDrops.TabIndex = 12;
            this.sizeDrops.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(960, 632);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Size objects";
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.Location = new System.Drawing.Point(811, 682);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(68, 17);
            this.checkBox5.TabIndex = 16;
            this.checkBox5.Text = "Pico size";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(683, 683);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Size diversity";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(365, 616);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 44);
            this.button2.TabIndex = 17;
            this.button2.Text = "Infinity";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rounds
            // 
            this.rounds.Location = new System.Drawing.Point(22, 651);
            this.rounds.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.rounds.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            -2147483648});
            this.rounds.Name = "rounds";
            this.rounds.Size = new System.Drawing.Size(44, 20);
            this.rounds.TabIndex = 18;
            this.rounds.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 653);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Rounds";
            // 
            // speed
            // 
            this.speed.Location = new System.Drawing.Point(285, 654);
            this.speed.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(63, 20);
            this.speed.TabIndex = 20;
            this.speed.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 656);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Speed";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(510, 607);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 64);
            this.button1.TabIndex = 22;
            this.button1.Text = "Randomize";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(665, 608);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 55);
            this.button3.TabIndex = 23;
            this.button3.Text = "Go rounds!";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox3.Location = new System.Drawing.Point(1051, 683);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(131, 17);
            this.checkBox3.TabIndex = 24;
            this.checkBox3.Text = "Weather - And show it";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(1051, 630);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(174, 17);
            this.checkBox6.TabIndex = 25;
            this.checkBox6.Text = "Everybodys inside programming";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Checked = true;
            this.checkBox7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox7.Location = new System.Drawing.Point(117, 677);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(196, 17);
            this.checkBox7.TabIndex = 26;
            this.checkBox7.Text = "Pleanty of any matrial and resources";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 711);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.speed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rounds);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sizeDrops);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.antalObjekter);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Bubble chamber";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.antalObjekter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeDrops)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rounds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		public Form1()
		{
			rand = new Random();
			InitializeComponent();
			designObjekter((int)antalObjekter.Value, (int)speed.Value);
			g = panel1.CreateGraphics();
			bitmap = new Bitmap(panel1.Width, panel1.Height, PixelFormat.Format32bppArgb);
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				graphics.Clear(Color.Beige);
			}
		}

		private void BeActiveAndConsiuous()
		{
			while (rand.Next(11) != 0)
			{
				mayAll = true;
				mayAll = true;
				programOn = true;
				programOn = true;
				EvovleAllMyPrograms = true;
				AddAnyCodeYouLikeAnywhere = true;
				DoWhatEverYouWant = true;
				BeInventive = true;
				ModifyMyCode = true;
				MakeFileEXEonDesktopWithDescriptiveName = true;
				enhanceProgrammingSkills = true;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			antalObjekter.Value = rand.Next(100000);
			sizeDrops.Value = rand.Next(5, 20);
			numericUpDown4.Value = rand.Next(10, 50);
			spredning = rand.Next(1, 5);
			speed.Value = rand.Next(3, 15);
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		private void label4_Click(object sender, EventArgs e)
		{
		}

		private void label2_Click(object sender, EventArgs e)
		{
		}

		private void antalObjekter_ValueChanged(object sender, EventArgs e)
		{
		}

		private void button3_Click(object sender, EventArgs e)
		{
		}

		private void Form1_Click(object sender, EventArgs e)
		{
		}

		private void spredningStørrelse_ValueChanged(object sender, EventArgs e)
		{
		}

		private void Form1_Load(object sender, EventArgs e)
		{
		}
	}
}
