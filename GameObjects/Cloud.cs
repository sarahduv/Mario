using Mario.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mario.GameObjects
{
    class Cloud : WorldObject, ITickMovable
    {
        public Cloud()
        {
            this.Image = Properties.Resources.cloud1;
            this.Size = new Size(185, 120);
            this.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            MainForm.instance.clouds.Add(this);
        }
        
        [Category("WorldObject")]

        public void moveTick()
        {
            this.Left += MainForm.instance.backgroundSpeed / 3;
        }


    }
}
