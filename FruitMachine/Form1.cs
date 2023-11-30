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
        //static Image[] images = new Image[7];
        static Image[] images = { pearl, rainbowPearl, rainbowBall, slime, ruby, blackPrism, passionFruit };
 


        List<Image> pictures = new List<Image>()
        {
            pearl,
            rainbowPearl,
            rainbowBall,
            slime,
            ruby,
            blackPrism,
            passionFruit
        };
        //System.Timers.Timer cooldownTimer;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
 
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            
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
            pictureBox1.BackgroundImage = images[pos1];
            if (pos1 == 0)
            {
                pb1Top.BackgroundImage = images[(pos1 + len - 1) % len];
                pb1Top.BackgroundImage = images[len - 1];
            }
            else
            {
                pb1Top.BackgroundImage = images[pos1 - 1];
            }
            //pb1Top.BackgroundImage = images[(pos1-1)%len];// Figure out how to get the previous item in the array
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pb1Top_Paint(object sender, PaintEventArgs e)
        {
            pb1Top.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
