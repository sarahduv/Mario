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
            //MainForm.instance.clouds.Add(this);
        }

        private CloudType cloudType;
        public CloudType CloudType
        {
            get
            {
                return cloudType;
            }
            set
            {
                cloudType = value;
                UpdateCloudImage();
            }
        }

        private void UpdateCloudImage()
        {
            switch (cloudType)
            {
                case CloudType.Cloud1:
                    Image = Properties.Resources.cloud1;
                    break;
                case CloudType.Cloud2:
                    Image = Properties.Resources.cloud2;
                    break;
                case CloudType.Cloud3:
                    Image = Properties.Resources.cloud3;
                    break;
                case CloudType.Cloud4:
                    Image = Properties.Resources.cloud4;
                    break;
                case CloudType.Cloud5:
                    Image = Properties.Resources.cloud5;
                    break;
                case CloudType.Cloud6:
                    Image = Properties.Resources.cloud6;
                    break;
                case CloudType.Cloud7:
                    Image = Properties.Resources.cloud7;
                    break;
                case CloudType.Cloud8:
                    Image = Properties.Resources.cloud8;
                    break;
            }
        }

        public void moveTick()
        {
            this.Left += MainForm.instance.backgroundSpeed / 3;
        }


    }

    enum CloudType
    {
        Cloud1,
        Cloud2,
        Cloud3,
        Cloud4,
        Cloud5,
        Cloud6,
        Cloud7,
        Cloud8
    }
}
