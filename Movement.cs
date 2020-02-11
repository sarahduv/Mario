using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Mario
{
    class Movement
    {
        private Form1 world;
        //private int bounceFactor = 1;
        private bool floatUp = false;
        private int floatPivot = 5;

        public Movement(Form1 form)
        {
            world = form;
        }
        public void moveItems()
        {
            moveWings();
            world.ground.Left += world.backgroundSpeed;
            for (var i = 0; i < world.worldItems.Count; i++)
            {
                if((string)world.worldItems[i].Tag == "bullet")
                {
                    world.worldItems[i].Left -= world.bulletSpeed;
                }
                world.worldItems[i].Left += world.backgroundSpeed;
            }
            for (var i = 0; i < world.clouds.Count; i++)
            {
                world.clouds[i].Left += world.backgroundSpeed / 3;
            }
        }

        public void invertImage()
        {
            if (world.marioLeft)
            {
                world.mario.Image = Properties.Resources.marioMirror;
            }
            else { world.mario.Image = Properties.Resources.mario; }
        }

        public void moveWings()
        { 
            if(!floatUp && floatPivot < 10)
            {
                world.questionWings1.Top += 2;
                floatPivot++;
                if (floatPivot == 10)
                {
                    floatUp = true;
                }
            }
            else if(floatUp)
            {
                floatPivot--;
                world.questionWings1.Top -= 2;
                if(floatPivot == 0)
                {
                    floatUp = false;
                }
            }
        }
    }
}
