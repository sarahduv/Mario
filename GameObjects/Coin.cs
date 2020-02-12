using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mario.Interfaces;

namespace Mario.GameObjects
{
    class Coin : WorldObject, IEdible
    {
        public Coin()
        {
            this.Image = Properties.Resources.coinTurning;
            this.Size = new Size(25, 25);
            this.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        }

        [Category("WorldObject")]
        public void eat()
        {
            this.Parent.Controls.Remove(this);
            int currentScore = Int32.Parse(MainForm.instance.labelScoreNum.Text) + 1;
            MainForm.instance.labelScoreNum.Text = currentScore.ToString();
            WorldObject.allWorldObjects.Remove(this);
        }
                
    }
}
