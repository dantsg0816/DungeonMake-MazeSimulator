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
    public enum DropMode
    {
        Move,
        Copy
    }

    public partial class Room : UserControl
    {
        private int roomWay;
        private DropMode dropMode = DropMode.Move;
        private double walkTimes = 0.0;
        private double totalTimes;
        private bool bShowNumber = false;
        private StringFormat sf_center = new StringFormat();
        private Random rand = new Random();

        public Room()
        {
            InitializeComponent();
            sf_center.Alignment = StringAlignment.Center;
            sf_center.LineAlignment = StringAlignment.Center;
        }

        public DropMode DropMode
        {
            get { return dropMode; }
            set { dropMode = value; }
        }

        public int RoomWay
        {
            get { return roomWay; }
            set { roomWay = value; }
        }

        private void room_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush brush_black = new SolidBrush(Color.Black);
            SolidBrush brush_white = new SolidBrush(Color.White);
            e.Graphics.FillRectangle(brush_black, new Rectangle(new Point(0, 0), new Size(this.Width, this.Height)));
            switch (roomWay)
            {
                case 1:
                    e.Graphics.FillRectangle(brush_white, new Rectangle(new Point(5, 5), new Size(this.Width - 6, this.Height -  10)));
                    break;
                case 2:
                    e.Graphics.FillRectangle(brush_white, new Rectangle(new Point(5, 5), new Size(this.Width - 10, this.Height - 6)));
                    break;
                case 3:
                    e.Graphics.FillRectangle(brush_white, new Rectangle(new Point(5, 5), new Size(this.Width - 6, this.Height - 6)));
                    break;
                case 4:
                    e.Graphics.FillRectangle(brush_white, new Rectangle(new Point(5, 1), new Size(this.Width - 10, this.Height - 6)));
                    break;
                case 5:
                    e.Graphics.FillRectangle(brush_white, new Rectangle(new Point(5, 1), new Size(this.Width - 6, this.Height - 6)));
                    break;
                case 6:
                    e.Graphics.FillRectangle(brush_white, new Rectangle(new Point(5, 1), new Size(this.Width - 10, this.Height - 2)));
                    break;
                case 7:
                    e.Graphics.FillRectangle(brush_white, new Rectangle(new Point(5, 1), new Size(this.Width - 6, this.Height - 2)));
                    break;
                case 8:
                    e.Graphics.FillRectangle(brush_white, new Rectangle(new Point(1, 5), new Size(this.Width - 6, this.Height - 10)));
                    break;
                case 9:
                    e.Graphics.FillRectangle(brush_white, new Rectangle(new Point(1, 5), new Size(this.Width - 2, this.Height - 10)));
                    break;
                case 10:
                    e.Graphics.FillRectangle(brush_white, new Rectangle(new Point(1, 5), new Size(this.Width - 6, this.Height - 6)));
                    break;
                case 11:
                    e.Graphics.FillRectangle(brush_white, new Rectangle(new Point(1, 5), new Size(this.Width - 2, this.Height - 6)));
                    break;
                case 12:
                    e.Graphics.FillRectangle(brush_white, new Rectangle(new Point(1, 1), new Size(this.Width - 6, this.Height - 6)));
                    break;
                case 13:
                    e.Graphics.FillRectangle(brush_white, new Rectangle(new Point(1, 1), new Size(this.Width - 2, this.Height - 6)));
                    break;
                case 14:
                    e.Graphics.FillRectangle(brush_white, new Rectangle(new Point(1, 1), new Size(this.Width - 6, this.Height - 2)));
                    break;
                case 15:
                    e.Graphics.FillRectangle(brush_white, new Rectangle(new Point(1, 1), new Size(this.Width - 2, this.Height - 2)));
                    break;
            }
            if (bShowNumber)
            {
                double prob = walkTimes / totalTimes;
                double result = Math.Round(prob, 3, MidpointRounding.AwayFromZero);
                e.Graphics.DrawString(result.ToString(), Font, brush_black, new Rectangle(new Point(0, 35), new Size(this.Width, this.Height - 35)), sf_center);
            }
        }

        private void Room_MouseDown(object sender, MouseEventArgs e)
        {
            if (dropMode == DropMode.Move)
            {
                DoDragDrop(this, DragDropEffects.Copy);
            }
            else
            {
                Room room = new Room();
                room.RoomWay = roomWay;
                room.Location = new Point(1, 1);
                DoDragDrop(room, DragDropEffects.Copy);
            }
        }

        private void Room_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetData(typeof(Entrance)) != null && !Controls.OfType<Entrance>().Any<Entrance>())
            {
                Controls.Add((Entrance)e.Data.GetData(typeof(Entrance)));
            }
        }

        private void Room_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Entrance)) && DropMode == DropMode.Move)
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        public bool IsEntrance()
        {
            if (Controls.OfType<Entrance>().Any<Entrance>())
                return true;
            return false;
        }

        public void ShowNumber(double times)
        {
            totalTimes = times;
            bShowNumber = true;
            Refresh();
        }

        public void HideNumber()
        {
            bShowNumber = false;
            Refresh();
        }

        public int GetNextWay(int source)
        {
            int way;
            if (roomWay > source)
                way = roomWay - source;
            else
                return roomWay;

            int rand_num;
            switch (way)
            {
                case 15:
                    rand_num = rand.Next(WayProb.L + WayProb.U + WayProb.D + WayProb.R);
                    if (rand_num < WayProb.L)
                        return 8;
                    else if (rand_num < WayProb.L + WayProb.U)
                        return 4;
                    else if (rand_num < WayProb.L + WayProb.U + WayProb.D)
                        return 2;
                    else
                        return 1;
                case 14:
                    rand_num = rand.Next(WayProb.L + WayProb.U + WayProb.D);
                    if (rand_num < WayProb.L)
                        return 8;
                    else if (rand_num < WayProb.L + WayProb.U)
                        return 4;
                    else
                        return 2;
                case 13:
                    rand_num = rand.Next(WayProb.L + WayProb.U + WayProb.R);
                    if (rand_num < WayProb.L)
                        return 8;
                    else if (rand_num < WayProb.L + WayProb.U)
                        return 4;
                    else
                        return 1;
                case 12:
                    rand_num = rand.Next(WayProb.L + WayProb.U);
                    if (rand_num < WayProb.L)
                        return 8;
                    else
                        return 4;
                case 11:
                    rand_num = rand.Next(WayProb.L + WayProb.D + WayProb.R);
                    if (rand_num < WayProb.L)
                        return 8;
                    else if (rand_num < WayProb.L + WayProb.D)
                        return 2;
                    else
                        return 1;
                case 10:
                    rand_num = rand.Next(WayProb.L + WayProb.D);
                    if (rand_num < WayProb.L)
                        return 8;
                    else
                        return 2;
                case 9:
                    rand_num = rand.Next(WayProb.L + WayProb.R);
                    if (rand_num < WayProb.L)
                        return 8;
                    else
                        return 1;
                case 8:
                    return 8;
                case 7:
                    rand_num = rand.Next(WayProb.U + WayProb.D + WayProb.R);
                    if (rand_num < WayProb.U)
                        return 4;
                    else if (rand_num < WayProb.U + WayProb.D)
                        return 2;
                    else
                        return 1;
                case 6:
                    rand_num = rand.Next(WayProb.U + WayProb.D);
                    if (rand_num < WayProb.U)
                        return 4;
                    else
                        return 2;
                case 5:
                    rand_num = rand.Next(WayProb.U + WayProb.R);
                    if (rand_num < WayProb.U)
                        return 4;
                    else
                        return 1;
                case 4:
                    return 4;
                case 3:
                    rand_num = rand.Next(WayProb.D + WayProb.R);
                    if (rand_num < WayProb.D)
                        return 2;
                    else
                        return 1;
                case 2:
                    return 2;
                case 1:
                    return 1;
                default:
                    return -1;
            }
        }

        public void Walk()
        {
            walkTimes += 1;
        }

        public void Reset()
        {
            walkTimes = 0.0;
        }

        public double GetWalkTimes()
        {
            return walkTimes;
        }
    }
}
