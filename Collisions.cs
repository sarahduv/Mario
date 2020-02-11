using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;

namespace Mario
{
    class Collisions
    {
        private Form1 world;
        //private int bounceFactor = 1;

        public Collisions(Form1 form)
        {
            world = form;
        }

        public bool isColliding(Rectangle bounds, List<PictureBox> worldItems)
        {
            for (var i = 0; i < worldItems.Count; i++)
            {
                if(bounds.IntersectsWith(worldItems[i].Bounds) && (string)worldItems[i].Tag == "coin")
                {
                    isCoin(worldItems[i]);
                    return false;
                }
                if(bounds.IntersectsWith(worldItems[i].Bounds) && (string)worldItems[i].Tag == "mushroomRed")
                {
                    isMushroom(worldItems[i]);
                    return false;
                }
                if (bounds.IntersectsWith(worldItems[i].Bounds) && (string)worldItems[i].Tag == "bullet")
                {
                    isBullet(worldItems[i]);
                    return true;
                }
                if (bounds.Bottom == worldItems[i].Bounds.Top)
                {
                    return isLandingOnItem(worldItems[i]);
                }

                if (bounds.IntersectsWith(worldItems[i].Bounds) && (string)worldItems[i].Tag == "question")
                {
                    isQuestion(worldItems[i]);
                    return true;
                }
                if (bounds.IntersectsWith(worldItems[i].Bounds) && (string)worldItems[i].Tag != "coin" && (string)worldItems[i].Tag != "coinInvisible")
                {
                    return true;
                }
            }
            return false;
        }

        public bool isColliding(PictureBox mario, List<PictureBox> worldItems)
        {
            return isColliding(mario.Bounds, worldItems);
        }


        public void isCoin(PictureBox coin)
        {
            coin.Visible = false;
            coin.Tag = "coinInvisible";
            int currentScore = Int32.Parse(world.labelScoreNum.Text) + 1;
            world.labelScoreNum.Text = currentScore.ToString();
            world.worldItems.Remove(coin);
        }

        public void isMushroom(PictureBox mushroom)
        {
            mushroom.Visible = false;
            mushroom.Tag = "mushroomRedInvisible";
            world.mario.Height = world.mario.Height + 4;
            world.mario.Width = world.mario.Width + 4;
            world.baseMarioY -= 4;
            world.worldItems.Remove(mushroom);
        }

        public void isQuestion(PictureBox question)
        {
            question.Tag = "brick";
            question.Image = Properties.Resources.brick;

            Image[] possiblePopUps = new Image[4] { Properties.Resources.coinTurning, Properties.Resources.mushroomRed, Properties.Resources.coinTurning, Properties.Resources.coinTurning };
            Random random = new Random();
            int index = random.Next(possiblePopUps.Length);
            Image imgToUse = possiblePopUps[index];

            var popUp = new PictureBox();
            var newLoc = FormToBackgroundCoords(question.Location, world.backgroundSky);
            popUp.Size = world.coins[0].Size;
            popUp.Visible = true;
            popUp.Image = imgToUse;
            popUp.SizeMode = PictureBoxSizeMode.StretchImage;
            popUp.BackColor = Color.Transparent;
            popUp.Location = new Point(newLoc.X, newLoc.Y - popUp.Height);
            world.backgroundSky.Controls.Add(question);
            world.backgroundSky.Controls.Add(popUp);
            world.worldItems.Add(popUp);
            world.coins.Add(popUp);

            if(popUp.Image == possiblePopUps[0] || popUp.Image == possiblePopUps[2] || popUp.Image == possiblePopUps[2])
            {
                popUp.Tag = "coin";
            }
            else if(popUp.Image == possiblePopUps[1])
            {
                popUp.Tag = "mushroomRed";
            }
     
        }

        public void isBullet(PictureBox bullet)
        {
            bullet.Image = null;
            world.mario.Height = world.mario.Height - 4;
            world.mario.Width = world.mario.Width - 4;
            world.baseMarioY += 4;
        }

        public bool isLandingOnItem(PictureBox item)
        {
            String[] landableItems = new string[2] { "question", "brick" };
            for(var i = 0; i <landableItems.Length; i++)
            {
                if((string)item.Tag == landableItems[i])
                {
                   // world.baseMarioY -= item.Height;
                    return true;
                }
            }
            return false;
        }

        public Point FormToBackgroundCoords(Point src, Control background)
        {
            return new Point(src.X - background.Location.X, src.Y - background.Location.Y);
        }

        /*   private void bounce(PictureBox mario, string direction)
           {
               int bounce = 5;

               for(var i = 0; i < bounceFactor; i++)
               {
                   if(direction == "right")
                   {
                       mario.Left += bounce;
                       world.backgroundSpeed -= bounce;
                   }
                   else 
                   {
                       mario.Left -= bounce;
                       world.backgroundSpeed += bounce;
                   }

               }
           }*/
    }
}
