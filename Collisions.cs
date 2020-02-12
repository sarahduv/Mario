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

        public bool isColliding(Rectangle bounds, List<WorldObject> worldItems)
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
                    if (worldItems[i] is Tree)
                    {
                        return false;
                    }
                }
                if (bounds.Bottom == worldItems[i].Bounds.Top)
                {
                    return false;
                }

                if (bounds.IntersectsWith(worldItems[i].Bounds))
                {
                    return true;
                }
            }
            return false;
        }



        public Point FormToBackgroundCoords(Point src, Control background)
        {
            return new Point(src.X - background.Location.X, src.Y - background.Location.Y);
        }

        public List<WorldObject> getCollidables()
        {
            return WorldObject.allWorldObjects.ToList();
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
