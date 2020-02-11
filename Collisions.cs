using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;


namespace Mario
{
    class Collisions
    {
        private Form1 world;
        private int bounceFactor = 1;

        public Collisions(Form1 form)
        {
            world = form;
        }

        public bool collisionLeft(PictureBox mario, List<PictureBox> worldItems)
        {
            for (var i = 0; i < worldItems.Count; i++)
            {
                if (mario.Bounds.IntersectsWith(worldItems[i].Bounds))
                {
                    bounce(mario, "right");
                    return true;
                }
            }
            return false;
        }

        public bool collisionRight(PictureBox mario, List<PictureBox> worldItems)
        {
            for (var i = 0; i < worldItems.Count; i++)
            {
                if (mario.Bounds.IntersectsWith(worldItems[i].Bounds))
                {
                    Debug.Write("collision right");
                    bounce(mario, "left");
                    return true;
                }
            }
            return false;
        }

        private void bounce(PictureBox mario, string direction)
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
        }
    }
}
