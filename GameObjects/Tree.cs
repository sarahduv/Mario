using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mario.GameObjects
{
    class Tree : WorldObject
    {

        public Tree()
        {
            this.Image = Properties.Resources.tree1;
            this.Size = new Size(50, 120);
            this.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        }

        private TreeType treeType;
        public TreeType TreeType
        {
            get
            {
                return treeType;
            }
            set
            {
                treeType = value;
                UpdateTreeImage();
            }
        }

        private void UpdateTreeImage()
        {
            switch (treeType)
            {
                case TreeType.Tree1:
                    Image = Properties.Resources.tree1;
                    break;
                case TreeType.Tree2:
                    Image = Properties.Resources.tree2;
                    break;                
            }
        }

    }

    enum TreeType
    {
        Tree1,
        Tree2
    }
}
