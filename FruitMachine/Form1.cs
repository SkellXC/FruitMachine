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
using System.Reflection;
using System.CodeDom.Compiler;
using System.Runtime.InteropServices;
/*Special item that when is used, slows down tick speed of other timers
 * Spend money
 * Buy upgrades (slows down tick speed minimally)
 * History of bets
 * Figure out how to do seperate pages to allow for a main menu and other stuff. Maybe new games?
 * Hyper link to my github 
 * Calculate win rate
 * If you get multiple in a row, you get more money or you get crates
 * Shop with backgrounds 
 * Seperate enviroment that you use money to build stuff. coinmaster style 
 * 
 * Bit more far fetched. You need to raid ai bases
 */
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
        static Image startbg = FruitMachine.Resource1.tile190;
        static Image[] images = { pearl, rainbowPearl, rainbowBall, slime, ruby, blackPrism, passionFruit };

        static int len = images.Length;
        static int pos1 = 1;
        static int pos2 = 2;
        static int pos3 = 3;

        static int gold = 1_000;
        static bool halfTick = false;
        static bool spin = true;// Enables the timers
        static bool box1 = true;// boxN is true when its spinning
        static bool box2 = true;
        static bool box3 = true;

        public Form1() { InitializeComponent();}

        private void Form1_Load(object sender, EventArgs e)
        {
        }


           
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = images[pos1];// Middle one

            pb1Top.BackgroundImage = images[((pos1 ==0)? len : pos1)-1];// Top one
            //sets the index to the last item when pos1 is the first item

            pb1Bottom.BackgroundImage = images[(pos1 + 1) % len];// Bottom one
            pos1 = (pos1 + 1) % images.Length;// Increments it
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
        private void StartButton_Click(object sender, EventArgs e)
        {
            if ((box1))// If box1 is spinning then this can stop it
            { 
            timer1.Enabled = false;//!(timer1.Enabled);
            }

            box1 = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if ((box2))// If box1 is spinning then this can stop it  { timer2.Enabled = false; }
                timer2.Enabled = false;
            box2 = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((box3))
            {
                timer3.Enabled = false;
                box3 = false;
            }
        }

        private void boolcheck_Tick(object sender, EventArgs e)// Run checks in here
        {
            label1.Text = (pos1 == pos2 + 1).ToString();// Box 1 and 2 are the same
            label2.Text = (pos2 == pos3).ToString();// Box 2 and 3 are the same
            label3.Text = (pos1 == pos3+1).ToString();// Box 1 and 3 are the same
            halfTick = !halfTick;
            if (halfTick) { goldLabel.Text = gold.ToString(); }
            if(!box1 && !box2 && !box3) 
            { 
                spin = true; box1 = true; box2 = true; box3 = true;// Resets everything and lets you spin again
                checkWin();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (gold > 0 && spin)
            {
                textBox1.Enabled = false;// Disables teh textbox
                goldLabel.Text = gold.ToString();
                gold -= Int32.Parse(textBox1.Text);
                timer1.Enabled = true;// Spins everything
                timer2.Enabled = true;
                timer3.Enabled = true;
                spin = false;// Doesn't let you spin again
                
            }
            else { MessageBox.Show("You have no money left"); }
        }
        private void checkWin()
        {
            bool oneTwo = pos1 == (pos2 + 1);
            bool twoThree = pos2 == pos3;
            bool oneThree = pos1 == (pos3 + 1);
            if (oneTwo && twoThree && oneThree)
            {
                // MessageBox.Show("You win");
                gold += Int32.Parse(textBox1.Text) * 3;
                    
            }
            textBox1.Enabled = true;
        }
    }
}
