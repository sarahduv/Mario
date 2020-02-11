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
            worldItems = new List<PictureBox> { question1, question2, coin1, coin2, coin3, coin4 };
            clouds = new List<PictureBox> { cloud1, cloud2, cloud3 };
            coins = new List<PictureBox> { coin1, coin2, coin3, coin4 };
            backgroundSky.Controls.Add(cloud1);
            backgroundSky.Controls.Add(cloud2);
            backgroundSky.Controls.Add(cloud3);
            backgroundSky.Controls.Add(mario);
        }

        private void movementTimer_Tick(object sender, EventArgs e)
        {
            if (collisions.isCoin(mario, worldItems))
            {
                int currentScore = Int32.Parse(labelScoreNum.Text) + 1;
                labelScoreNum.Text = currentScore.ToString();
            }

            if (marioLeft && !collisions.isColliding(mario.Bounds.MoveLeft(10), worldItems)) { backgroundSpeed = 10; }
            else if (marioRight && !collisions.isColliding(mario.Bounds.MoveRight(10), worldItems)) { backgroundSpeed = -10; }
            else { backgroundSpeed = 0; }
            if (marioJumping && collisions.isColliding(mario.Bounds.MoveUp(10), worldItems)) { jumpForce = 0; }

            ground.Left += backgroundSpeed;
            for(var i = 0; i < worldItems.Count; i++)
            {
                worldItems[i].Left += backgroundSpeed;
            }
            for(var i = 0; i < clouds.Count; i++)
            {
                clouds[i].Left += backgroundSpeed/3;
            }
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
                    break;
                case Keys.Right:
                    marioRight = true;
                    break;
                case Keys.Up:
                    // Can Jump (only if touching ground)
                    marioJumping = true;
                    jumpForce = 25;
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
