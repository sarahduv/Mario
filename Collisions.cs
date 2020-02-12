using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;
using Mario.GameObjects;
using Mario.Interfaces;

namespace Mario
{
    class Collisions
    {
        private MainForm world;
        //private int bounceFactor = 1;

        public Collisions(MainForm form)
        {
            world = form;
        }

        public bool isColliding(Rectangle bounds, List<PictureBox> worldItems)
        {
            for (var i = 0; i < worldItems.Count; i++)
            {
                var intersecting = bounds.IntersectsWith(worldItems[i].Bounds);

                if (intersecting)
                {
                    if (worldItems[i] is IEdible)
                    {
                        ((IEdible)worldItems[i]).eat();
                        return false;
                    }
                }
                if (bounds.Bottom == worldItems[i].Bounds.Top)
                {
                    //return isLandingOnItem(worldItems[i]);
                    return false;
                }

                /*if (bounds.IntersectsWith(worldItems[i].Bounds) && (string)worldItems[i].Tag == "question")
                {
                    //isQuestion(worldItems[i]);
                    return true;*/
                //}
                if (bounds.IntersectsWith(worldItems[i].Bounds))
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

        public List<PictureBox> getCollidables()
        {
            return world.worldItems.Where(x => (string)x.Tag != "coin").ToList();
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
