using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mario.GameObjects
{
    class Tunnel : WorldObject
    {
        public Tunnel()
        {
            this.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        }

        //[Category("WorldObject")]
    }

    class SmallTunnel : Tunnel
    {
        public SmallTunnel()
        {
            this.Image = Properties.Resources.tunnel;
            this.Size = new Size(60, 70);
        }        
    }
}
