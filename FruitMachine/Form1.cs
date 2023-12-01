using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Threading;
namespace FruitMachine
{
    public partial class Form1 : Form
    {
        static Image pearl = FruitMachine.Resource1.tile024_Pearl;
        static Image rainbowPearl = FruitMachine.Resource1.tile071;
        static Image rainbowBall = FruitMachine.Resource1.tile018;
        static Image slime = FruitMachine.Resource1.tile108;
        static Image ruby = FruitMachine.Resource1.tile009;
        static Image blackPrism = FruitMachine.Resource1.tile067;
        static Image passionFruit = FruitMachine.Resource1.tile127;
        static Image[] images = { pearl, rainbowPearl, rainbowBall, slime, ruby, blackPrism, passionFruit };
 

        static Image[] check = new Image[2];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !(timer1.Enabled);
            Image box1 = pictureBox1.BackgroundImage;
            //Console.WriteLine('a');
            check.Append(box1);
            label1.Text = "a";
        }


        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
           pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void pictureBox3_Paint(object sender, PaintEventArgs e)
            {
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
        }
            
        static int len = images.Length;
        static int pos1 = 1;
        static int pos2 = 3;
        static int pos3 = 5;
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pb1Top.BackgroundImageLayout = ImageLayout.Stretch;
            pb1Bottom.BackgroundImageLayout = ImageLayout.Stretch;

            pictureBox1.BackgroundImage = images[pos1];// Middle one
            if (pos1 == 0)// sets the index to the last item when pos1 is the first item
            {
                pb1Top.BackgroundImage = images[len - 1];
                

            }
            else { pb1Top.BackgroundImage = images[pos1 - 1];}// Handles regular for top
            pb1Bottom.BackgroundImage = images[(pos1 + 1) % len];// Bottom one

            pos1 = (pos1 + 1) % images.Length;

        }

        
        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = images[(pos2 + 1) % len];
            pos2 = (pos2 + 1) % images.Length;
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox3.BackgroundImage = images[(pos3 + 1) % len];
            pos3 = (pos3 + 1) % images.Length;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void pb1Bottom_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void pb1Top_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Enabled = !(timer2.Enabled);
            Image box2 = pictureBox2.BackgroundImage;
            //Console.WriteLine('a');
            check.Append(box2);

            label1.Text = sameCheck(check).ToString();
        }

        private bool sameCheck(Image[] check)
        {
            return check[0] != check[1];
        }

    }
}
