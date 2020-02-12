using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Mario.Interfaces;

namespace Mario
{
    class Movement
    {
        private MainForm world;
        //private int bounceFactor = 1;
        

        public Movement(MainForm form)
        {
            world = form;
        }
        public void moveItems()
        {
            
            world.ground.Left += world.backgroundSpeed;
            for (var i = 0; i < world.worldItems.Count; i++)
            {
                if (world.worldItems[i] is ITickMovable)
                {
                    ((ITickMovable)world.worldItems[i]).moveTick();
                }
                world.worldItems[i].Left += world.backgroundSpeed;
            }
            for (var i = 0; i < world.clouds.Count; i++) { world.clouds[i].Left += world.backgroundSpeed / 3; }
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
