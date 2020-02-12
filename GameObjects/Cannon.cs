using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace Mario.GameObjects
{
    class Cannon : WorldObject
    {

        public Cannon()
        {
            this.Image = Properties.Resources.cannon;
            this.Size = new Size(60, 70);
            this.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        }

        [Category("WorldObject")]
        
        public void getLocation()
        {

        }
    }
}
