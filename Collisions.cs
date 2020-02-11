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
                if (bounds.IntersectsWith(worldItems[i].Bounds) && (string)worldItems[i].Tag != "coin")
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

        public bool isCoin(PictureBox mario, List<PictureBox> worldItems)
        {
            for (var i = 0; i < worldItems.Count; i++)
            {
                if (mario.Bounds.IntersectsWith(worldItems[i].Bounds) && (string)worldItems[i].Tag == "coin")
                {
                    worldItems[i].Visible = false;
                    worldItems[i].Tag = null;
                    return true;
                }
            }
            return false;
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
