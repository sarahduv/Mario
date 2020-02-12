using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mario.GameObjects
{
    class Shell : WorldObject
    {
        public Shell()
        {
            this.Image = Properties.Resources.redShell;
            this.Size = new Size(30, 25);
            this.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        }

        [Category("WorldObject")]

        public void moveShell()
        {
            // make the shell move
        }
    }
}
