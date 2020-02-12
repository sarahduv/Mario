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
    class Bullet : WorldObject, ITickMovable, IEdible
    {
        public Bullet()
        {
            this.Image = Properties.Resources.bullet;
            this.Size = new Size(38, 26);
            this.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        }


        [Category("WorldObject")]
        // action if it hits mario - it disappears and makes him smaller
        // action if it hits other things?

        public void moveTick()
        {
            this.Left -= MainForm.instance.bulletSpeed;
        }

        public void eat()
        {
            this.Parent.Controls.Remove(this);
            WorldObject.allWorldObjects.Remove(this);
            MainForm.instance.mario.Height = MainForm.instance.mario.Height - 4;
            MainForm.instance.mario.Width = MainForm.instance.mario.Width - 4;
            MainForm.instance.baseMarioY += 4;
            MainForm.instance.lives--;
            MainForm.instance.labelLivesNum.Text = MainForm.instance.lives.ToString();
        }
    }
}
