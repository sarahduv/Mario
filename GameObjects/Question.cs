using Mario.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mario.GameObjects
{
    class Question : WorldObject, IBumpable
    {
        public Question()
        {
            this.Image = Properties.Resources.question2GIF;
            this.Size = new Size(25, 25);
            this.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        }

        [Category("WorldObject")]
        public bool IsPopped { get; set; }

        public void bump()
        {
            if (IsPopped)
            {
                return;
            }
            IsPopped = true;
            this.Image = Properties.Resources.brick;

            Type[] possiblePopUps = new Type[4] { typeof(Coin), typeof(MushroomRed), typeof(Coin), typeof(MushroomGreen) };
            Random random = new Random();
            int index = random.Next(possiblePopUps.Length);
            Type typeToUse = possiblePopUps[index];

            WorldObject popUp = (WorldObject)Activator.CreateInstance(typeToUse);
            //var newLoc = FormToBackgroundCoords(question.Location, world.backgroundSky);
            MainForm.instance.backgroundSky.Controls.Add(popUp);
            WorldObject.allWorldObjects.Add(popUp);
            popUp.Location = new Point(Location.X, Location.Y - popUp.Height);

        }

        // turn into brick when popped
        // possible pop ups

    }
}
