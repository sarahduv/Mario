using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace Mario
{
    public partial class Form1 : Form
    {
        public int backgroundSpeed = 0;
        public int marioUpSpeed = 0;
        public int baseMarioY = 570;
        public Form1()

        {
            InitializeComponent();

        }

        private void movementTimer_Tick(object sender, EventArgs e)
        {

            background1.Left += backgroundSpeed;
            background2.Left += backgroundSpeed;

            if (background1.Left < -1000)
            {
                background1.Left = 700;
            }

            if (background2.Left < -1000)
            {
                background2.Left = 700;
            }

            if(marioUpSpeed > 0)
            {
                mario.Top -= marioUpSpeed;
            }
            else { mario.Top = baseMarioY; }

            /*background1.Location = new Point(background1.Location.X + backgroundSpeed, background1.Location.Y);
            background2.Location = new Point(background2.Location.X + backgroundSpeed, background2.Location.Y);

            if (background1.Left < 0)
            {
                background1.Location = new Point(background1.Location.X + 1050, background1.Location.Y);
            }

            if (background2.Left < 0)
            {
                background2.Location = new Point(background2.Location.X + 1050, background2.Location.Y);
            }*/
        }

        private void move(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                backgroundSpeed += 10;
            }

            if (e.KeyCode == Keys.Right)
            {
                backgroundSpeed -= 10;
            }

            if(e.KeyCode == Keys.Up)
            {
                backgroundSpeed -= 3;
                marioUpSpeed = 10;
            }
        }

        private void stop(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                backgroundSpeed = 0;
            }
            if (e.KeyCode == Keys.Right)
            {
                backgroundSpeed = 0;
            }

        }
    }
}
