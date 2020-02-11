using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mario
{
    static class ExtensionMethods
    {
        public static Rectangle MoveLeft(this Rectangle rect, int amount)
        {
            return new Rectangle(rect.X - amount, rect.Y, rect.Width, rect.Height);
        }

        public static Rectangle MoveRight(this Rectangle rect, int amount)
        {
            return MoveLeft(rect, -amount);
        }

        public static Rectangle MoveUp(this Rectangle rect, int amount)
        {
            return new Rectangle(rect.X, rect.Y - amount, rect.Width, rect.Height);
        }
    }
}
