using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeSimulator.Maze
{
    public partial class Entrance : UserControl
    {
        private DropMode dropMode;

        public Entrance()
        {
            InitializeComponent();
            DropMode = DropMode.Move;
        }

        public DropMode DropMode
        {
            get { return dropMode; }
            set { dropMode = value; }
        }

        private void Entrance_Paint(object sender, PaintEventArgs e)
        {
            Pen pen_red = new Pen(Color.Red, 5);
            e.Graphics.DrawLine(pen_red, 0, 0, Width, Height);
            e.Graphics.DrawLine(pen_red, Width, 0, 0, Height);
        }

        private void Entrance_MouseDown(object sender, MouseEventArgs e)
        {
            if (dropMode == DropMode.Move)
            {
                DoDragDrop(this, DragDropEffects.All);
            }
            else
            {
                Entrance entrance = new Entrance();
                entrance.Location = new Point(17, 17);
                DoDragDrop(entrance, DragDropEffects.Move);
            }
        }
    }
}
