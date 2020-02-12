using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mario.GameObjects
{
    abstract class WorldObject : PictureBox
    {
        public static List<WorldObject> allWorldObjects = new List<WorldObject>();

        public WorldObject()
        {
            allWorldObjects.Add(this);
        }

        public override string ToString()
        {
            return GetType().Name;
        }
    }
}
