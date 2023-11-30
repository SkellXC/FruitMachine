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
        private bool cancelPaint = false;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            cancelPaint = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        private async void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < images.Length; i++)
            {
                pictureBox1.BackgroundImage = images[i];
                //Image.BackgroundImageLayout = ImageLayout.Stretch;
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                await Task.Delay(1000);

            }
        }
        private async Task sleep(int time)
        {
            await Task.Delay(time); // Time is in ms
        }

        private async void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            Random random = new Random();


            
            for(int i = 0; i < images.Length; i++)
            {   //int index = random.Next(0, images.Count);
                try
                {
                    e.Graphics.DrawImage(images[i], 50, 50, 90, 90);
                }
                catch (ArgumentException ex) { }

                await Task.Delay(2000); // Use Task.Delay instead of sleep
                pictureBox2.Invalidate();
            }
        }

        private async void pictureBox3_Paint(object sender, PaintEventArgs e)
        {
            Random random = new Random();

            //int index = random.Next(0, images.Length);
            for (int i = 0; i < images.Length; i++)
            {
                try
                {
                    e.Graphics.DrawImage(images[i], 50, 50, 90, 90);
                }
                catch (ArgumentException ex) { }

                await Task.Delay(2000); // Use Task.Delay instead of sleep
                pictureBox3.Invalidate();
            }
        }

        // Method to resize PictureBox control to fit the image automatically
        private void ResizePictureBox(PictureBox pictureBox)
        {
            if (pictureBox.Image != null)
            {
                pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
                pictureBox.ClientSize = new Size(pictureBox.Image.Width, pictureBox.Image.Height);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
