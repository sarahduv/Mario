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
        private Collisions collisions;

        public int backgroundSpeed = 0;
        public int baseMarioY = 570;
        // movement
        public bool marioLeft = false;
        public bool marioRight = false;
        // jumping
        public int force;
        public int gravity;
        public bool marioJumping = false;
        //items
        public List<PictureBox> worldItems;

        public Form1()

        {
            InitializeComponent();
            collisions = new Collisions(this);
            worldItems = new List<PictureBox> { pictureBox1, pictureBox2 };
        }

        private void movementTimer_Tick(object sender, EventArgs e)
        {
            if (marioLeft && !collisions.collisionLeft(mario, worldItems)) { backgroundSpeed = 10; }
            if (marioRight && !collisions.collisionRight(mario, worldItems)) { backgroundSpeed = -10; }

            background1.Left += backgroundSpeed;
            background2.Left += backgroundSpeed;
            pictureBox1.Left += backgroundSpeed;
            pictureBox2.Left += backgroundSpeed;

            if (background1.Left < -1000)
            {
                background1.Left = 700;
            }

            if (background2.Left < -1000)
            {
                background2.Left = 700;
            }
        }

        private void gravityTimer_Tick(object sender, EventArgs e)
        {

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
                case Keys.Down:
                    marioJumping = true;
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



        
    }
}
