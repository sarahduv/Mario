using System;
using System;
using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mario.GameObjects
{
    class Brick : WorldObject
    {
        public Brick()
        {
            this.Image = Properties.Resources.brick;
            this.Size = new Size(25, 25);
            this.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        }

        [Category("WorldObject")]

        public void bust()
        {
            // bust the brick if it's hit X amount of times?
        }
        
    }
}
