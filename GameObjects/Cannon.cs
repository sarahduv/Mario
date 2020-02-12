using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;
using Mario.Interfaces;

namespace Mario.GameObjects
{
    class Cannon : WorldObject, IFiresBullets
    {
        DateTime lastFired = DateTime.Now;

        public Cannon()
        {
            this.Image = Properties.Resources.cannon;
            this.Size = new Size(60, 70);
            this.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        }

        [Category("WorldObject")]
        public int IntervalMilliseconds { get; set; }

        
        public void getLocation()
        {

        }


        public void maybeFire()
        {
            var now = DateTime.Now;
            if ((now - lastFired).TotalMilliseconds > IntervalMilliseconds)
            {
                // the interval had passed, we should fire
                lastFired = now;
                var bullet = new Bullet();
                MainForm.instance.backgroundSky.Controls.Add(bullet);
                bullet.Location = new Point(Location.X, Location.Y + 5);
                WorldObject.allWorldObjects.Add(bullet);
            }
        }
    }
}
