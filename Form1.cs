using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Mario
{
    public partial class Form1 : Form
    {
        public int backgroundSpeed = 0;
        public Form1()

        {
            InitializeComponent();
        }

        private void gravityTimer_Tick(object sender, EventArgs e)
        {
            background1.Left -= backgroundSpeed;
            background2.Left -= backgroundSpeed;

            if (background1.Left < 0)
            {
                background1.Left = 1050;
            }

            if (background2.Left < 0)
            {
                background2.Left = 1050;
            }
        }

        private void move(object sender, KeyEventArgs e)
        {
            Debug.WriteLine("key: " + e.KeyCode);
            if (e.KeyCode == Keys.Left)
            {
                backgroundSpeed += 5;
            }

            if (e.KeyCode == Keys.Right)
            {
                backgroundSpeed -= 5;
            }
        }

        private void stop(object sender, KeyEventArgs e)
        {
            Debug.WriteLine("key: " + e.KeyCode);
            if (e.KeyCode == Keys.Down)
            {
                backgroundSpeed = 0;
            }

        }
    }
}
