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
        public int baseMarioY = 570;
        // movement
        public bool marioLeft = false;
        public bool marioRight = false;
        // jumping
        public int force;
        public int gravity;
        public bool jumping = false;

        public Form1()

        {
            InitializeComponent();

        }

        private void movementTimer_Tick(object sender, EventArgs e)
        {
            if(marioLeft && !collisionLeft(mario)) { backgroundSpeed = 5; }
            if (marioRight && !collisionRight(mario)) { backgroundSpeed = -5; }

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


        }

        private void move(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    marioLeft = true;
                    break;
                case Keys.Right:
                    marioRight = true;
                    break;
            }
        }

        private void stop(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    marioLeft = false;
                    backgroundSpeed = 0;
                    break;
                case Keys.Right:
                    marioRight = false;
                    backgroundSpeed = 0;
                    break;
            }
        }

        private bool collisionLeft(PictureBox mario)
        {
            return false;
        }

        private bool collisionRight(PictureBox mario)
        {
            return false;
        }

    }
}
