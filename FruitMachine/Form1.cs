using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        List<Image> images = new List<Image>()
        {
            pearl,
            rainbowPearl,
            rainbowBall,
            slime
        };
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
            //pictureBox1.Image = pearl;
            //e.Graphics.DrawImage(pearl, 50, 50, 10, 10);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                foreach (Image image in images)
                {
                    //pictureBox1.Image = image;
                    //pictureBox1.Refresh();
                    //await Task.Delay(200);
                    Random random = new Random();
                    int index = random.Next(images.Count);
                    Image randomImage = images[index];
                    e.Graphics.DrawImage(randomImage, 50, 50, 90, 90);
                    Thread.Sleep(100);
                }
            }
        }   

    }
}
