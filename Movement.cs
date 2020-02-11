using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mario
{
    class Movement
    {
        private Form1 world;
        //private int bounceFactor = 1;

        public Movement(Form1 form)
        {
            world = form;
        }
        public void moveItems()
        {
            world.ground.Left += world.backgroundSpeed;
            for (var i = 0; i < world.worldItems.Count; i++)
            {
                world.worldItems[i].Left += world.backgroundSpeed;
            }
            for (var i = 0; i < world.clouds.Count; i++)
            {
                world.clouds[i].Left += world.backgroundSpeed / 3;
            }
            world.bullet.Left -= world.bulletSpeed;
        }

        public void invertImage()
        {
            if (world.marioLeft)
            {
                world.mario.Image = Properties.Resources.marioMirror;
            }
            else { world.mario.Image = Properties.Resources.mario; }
        }
    }
}
