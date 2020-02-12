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
    class QuestionWings : WorldObject, ITickMovable
    {
        private bool floatUp = false;
        private int floatPivot = 5;
        public QuestionWings()
        {
            this.Image = Properties.Resources.questionWings;
            this.Size = new Size(65, 35);
            this.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        }

        [Category("WorldObject")]
        public bool IsPopped { get; set; }
        // possible pop ups
        // area that can be popped should only be the bottom middle 25px --> 65 -25 / 2 = 20px starting point --> 45px

        public void moveTick()
        {
            if (!floatUp && floatPivot < 10)
            {
                this.Top += 2;
                floatPivot++;
                if (floatPivot == 10)
                {
                    floatUp = true;
                }
            }
            else if (floatUp)
            {
                floatPivot--;
                this.Top -= 2;
                if (floatPivot == 0)
                {
                    floatUp = false;
                }
            }
        }
    }
}
