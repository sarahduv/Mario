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
        private Movement movement;

        public int backgroundSpeed = 0;
        public int bulletSpeed = 15;
        public int baseMarioY = 675;

        // movement
        public bool marioLeft = false;
        public bool marioRight = false;
        // jumping
        public int jumpForce = 0;
        public int gravityForce = 15;
        public bool marioJumping = false;
        //items
        public List<PictureBox> worldItems;
        public List<PictureBox> clouds;
        public List<PictureBox> coins;

        public Form1()

        {
            InitializeComponent();
            collisions = new Collisions(this);
            movement = new Movement(this);
            worldItems = new List<PictureBox> { question1, question2, questionWings1, brick1, brick2, coin1, coin2, coin3, coin4, mushroomRed1, cannon };
            clouds = new List<PictureBox> { cloud1, cloud2, cloud3 };
            coins = new List<PictureBox> { coin1, coin2, coin3, coin4 };
            backgroundSky.Controls.Add(cloud1);
            backgroundSky.Controls.Add(cloud2);
            backgroundSky.Controls.Add(cloud3);
            backgroundSky.Controls.Add(mario);
            backgroundSky.Controls.Add(cannon);
        }

        private void movementTimer_Tick(object sender, EventArgs e)
        {
            if (marioLeft && !collisions.isColliding(mario.Bounds.MoveLeft(10), worldItems)) { backgroundSpeed = 10; }
            else if (marioRight && !collisions.isColliding(mario.Bounds.MoveRight(10), worldItems)) { backgroundSpeed = -10; }
            else { backgroundSpeed = 0; }
            if (marioJumping && collisions.isColliding(mario.Bounds.MoveUp(10), worldItems)) { jumpForce = 0; }

            movement.moveItems();

        }

        private void gravityTimer_Tick(object sender, EventArgs e)
        {
            var newHeight = mario.Location.Y + gravityForce - jumpForce;
            if (newHeight > baseMarioY)
            {
                newHeight = baseMarioY;
                jumpForce = 0;
            }

            mario.Location = new Point(mario.Location.X, newHeight);

            if (jumpForce > 0)
            {
                jumpForce--;
            }
        }

        private void move(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    marioLeft = true;
                    movement.invertImage();
                    break;
                case Keys.Right:
                    movement.invertImage();
                    marioRight = true;
                    break;
                case Keys.Up:
                    if(mario.Location.Y == baseMarioY)
                    {
                        marioJumping = true;
                        jumpForce = 30;
                    }
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

        private void bulletTimer_Tick(object sender, EventArgs e)
        {
            Debug.WriteLine("making a bullet");
            var bullet = new PictureBox();
            var newLoc = collisions.FormToBackgroundCoords(cannon.Location, backgroundSky);
            bullet.Height = 26;
            bullet.Width = 38;
            bullet.Visible = true;
            bullet.Image = Properties.Resources.bullet;
            bullet.SizeMode = PictureBoxSizeMode.StretchImage;
            bullet.BackColor = Color.Transparent;
            bullet.Tag = "bullet";
            bullet.Location = new Point(newLoc.X, newLoc.Y + 5);      
            backgroundSky.Controls.Add(bullet);
            worldItems.Add(bullet);
              
        }
    }
}
