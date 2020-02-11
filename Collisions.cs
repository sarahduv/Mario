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
                    return true;
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
        }

        public void isQuestion(PictureBox question)
        {
            question.Tag = "brick";
            question.Image = Properties.Resources.brick;
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
