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
    class Mushroom : WorldObject
    {
        public Mushroom()
        {
            this.Size = new Size(25, 25);
            this.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        }

        [Category("WorldObject")]

        public void release()
        {
            // needs to move around once popped
        }        

    }

    class MushroomRed : Mushroom, IEdible
    {
        public MushroomRed()
        {
            this.Image = Properties.Resources.mushroomRed;
        }

        public void eat()
        {
            this.Parent.Controls.Remove(this);
            MainForm.instance.mario.Height = MainForm.instance.mario.Height + 4;
            MainForm.instance.mario.Width = MainForm.instance.mario.Width + 4;
            MainForm.instance.baseMarioY -= 4;
            WorldObject.allWorldObjects.Remove(this);
        }


    }

    class MushroomGreen : Mushroom, IEdible
    {
        public MushroomGreen()
        {
            this.Image = Properties.Resources.mushroomGreen;
        }

        public void eat()
        {
            this.Parent.Controls.Remove(this);
            int currentLives = Int32.Parse(MainForm.instance.labelLivesNum.Text) + 1;
            MainForm.instance.labelLivesNum.Text = currentLives.ToString();
            WorldObject.allWorldObjects.Remove(this);
        }

        // action for eating
        // gives +1 life

    }
}
