﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Mario.Interfaces;
using Mario.GameObjects;

namespace Mario
{
    public partial class MainForm : Form
    {
        public static MainForm instance;
        
        private Collisions collisions;
        private Movement movement;
        private Tools tools;

        public int backgroundSpeed = 0;
        public int bulletSpeed = 15;
        public int baseMarioY = 672;
        public int lives = 3;

        // movement
        public bool marioLeft = false;
        public bool marioRight = false;
        public bool marioTouchingFloor = false;

        // jumping
        public int jumpForce = 0;
        public int gravityForce = 15;
        public bool marioJumping = false;
        //items
        public List<PictureBox> clouds;
        public List<PictureBox> coins;
        public List<Label> labels;
        

        public MainForm()

        {
            InitializeComponent();
            instance = this;
            collisions = new Collisions(this);
            movement = new Movement(this);
            tools = new Tools(this);
            clouds = new List<PictureBox> { };
            labels = new List<Label> { labelScore, labelScoreNum, labelLives, labelLivesNum };
            backgroundSky.Controls.Add(mario);
            backgroundSky.Controls.AddRange(clouds.ToArray());
            backgroundSky.Controls.AddRange(WorldObject.allWorldObjects.ToArray());
            labelLivesNum.Text = lives.ToString();
        }

        private void movementTimer_Tick(object sender, EventArgs e)
        {
            if (marioLeft && !collisions.isColliding(mario.Bounds.MoveLeft(10), WorldObject.allWorldObjects)) { backgroundSpeed = 10; }
            else if (marioRight && !collisions.isColliding(mario.Bounds.MoveRight(10), WorldObject.allWorldObjects)) { backgroundSpeed = -10; }
            else { backgroundSpeed = 0; }
            //if (marioJumping && collisions.isColliding(mario.Bounds.MoveUp(10), worldItems)) { jumpForce = 0; }

            movement.moveItems();

        }

        private void gravityTimer_Tick(object sender, EventArgs e)
        {
            var amountToMoveUp = jumpForce - gravityForce;
            var newHeight = mario.Location.Y - amountToMoveUp;
            if (newHeight >= baseMarioY)
            {
                newHeight = baseMarioY;
                marioTouchingFloor = true;
                jumpForce = 0;
            }

            foreach (var collidable in collisions.getCollidables())
            {
                // Mario is touching a collidable
                if (collidable.Bounds.IntersectsWith(mario.Bounds.MoveUp(amountToMoveUp)))
                {
                    if (collidable is IEdible)
                    {
                        ((IEdible)collidable).eat();
                        continue;
                    }

                    if (amountToMoveUp > 0)
                    {
                        // we are moving up, we hit a ceiling
                        newHeight = collidable.Bounds.Bottom;
                        jumpForce = gravityForce;
                        
                        if (collidable is IBumpable)
                        {
                            ((IBumpable)collidable).bump();
                        }
                    }
                    else
                    {
                        // we are moving down, we hit a floor
                        marioTouchingFloor = true;
                        newHeight = collidable.Bounds.Top - mario.Height;
                        jumpForce = 0;
                    }                 
                }
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
                    if(marioTouchingFloor)
                    {
                        marioJumping = true;
                        jumpForce = 30;
                        marioTouchingFloor = false;
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
            foreach (var collidable in collisions.getCollidables())
            {
                if (collidable is IFiresBullets)
                {
                    ((IFiresBullets)collidable).maybeFire();
                }
            }
        }
    }
}
