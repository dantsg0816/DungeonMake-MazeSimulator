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
    public partial class RoomBlock : UserControl
    {
        private Room room;

        public RoomBlock()
        {
            InitializeComponent();
        }

        private void RoomBlock_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush brush = new SolidBrush(Color.Cornsilk);
            Pen pen = new Pen(Color.Black);
            e.Graphics.DrawRectangle(pen, new Rectangle(new Point(1, 1), new Size(this.Width-2, this.Height-2)));
            e.Graphics.FillRectangle(brush, new Rectangle(new Point(2, 2), new Size(this.Width - 4, this.Height - 4)));
        }

        private void RoomBlock_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetData(typeof(Room)) != null)
            {
                room = (Room)e.Data.GetData(typeof(Room));
                Controls.Add(room);
            }
        }

        private void RoomBlock_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Room)))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        public Room GetRoom()
        {
            return room;
        }

        public void ClearRoom()
        {
            room = null;
        }
    }
}
