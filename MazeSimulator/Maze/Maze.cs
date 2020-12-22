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
    public partial class Maze : UserControl
    {
        private int rows;
        private int cols;
        private RoomBlocks roomBlocks;
        private List<Point> entranceList = new List<Point>();
        Random rand = new Random();

        public Maze()
        {
            InitializeComponent();
            InitializeNumberPanel();
        }

        public void InitializeNumberPanel()
        {
        }

        public void CreateRoomBlocks(int width, int height)
        {
            this.Controls.Clear();
            roomBlocks = new RoomBlocks();

            rows = height;
            cols = width;

            for (int i = 0; i < height; i++)
            {
                List<RoomBlock> blockList = new List<RoomBlock>();
                for (int j = 0; j < width; j++)
                {
                    RoomBlock roomBlock = new RoomBlock();
                    roomBlock.Location = new Point(j * 55, i * 55);
                    this.Controls.Add(roomBlock);
                    blockList.Add(roomBlock);
                }
                roomBlocks.Add(blockList);
            }
        }

        public void RemoveRooms()
        {
            if (roomBlocks == null)
                return;
            foreach (List<RoomBlock> blocks in roomBlocks)
            {
                foreach (RoomBlock block in blocks)
                {
                    Room room = block.GetRoom();
                    if (room != null)
                        room.Dispose();
                }
            }
        }

        private void Dungeon_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Room)) || e.Data.GetDataPresent(typeof(Entrance)))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void Dungeon_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetData(typeof(Room)) != null)
            {
                Room room = (Room)e.Data.GetData(typeof(Room));
                room.Dispose();
            }
            if (e.Data.GetData(typeof(Entrance)) != null)
            {
                Entrance entrance = (Entrance)e.Data.GetData(typeof(Entrance));
                entrance.Dispose();
            }
        }

        public void ShowNumber(double totalWalkTimes)
        {
            foreach(List<RoomBlock> blocks in roomBlocks)
            {
                foreach(RoomBlock block in blocks)
                {
                    Room room = block.GetRoom();
                    if (room != null)
                        room.ShowNumber(totalWalkTimes);
                }
            }
        }

        public void HideNumber()
        {
            if (roomBlocks == null)
                return;

            foreach (List<RoomBlock> blocks in roomBlocks)
            {
                foreach (RoomBlock block in blocks)
                {
                    Room room = block.GetRoom();
                    if (room != null)
                        room.HideNumber();
                }
            }
        }

        public void Calculate(int times, string relic)
        {
            switch (relic)
            {
                case "No Relic":
                    WayProb.L = 1;
                    WayProb.U = 1;
                    WayProb.D = 1;
                    WayProb.R = 1;
                    break;
                case "Fake Map":
                    WayProb.L = 3;
                    WayProb.U = 6;
                    WayProb.D = 6;
                    WayProb.R = 5;
                    break;
                case "Real Map":
                    WayProb.L = 2;
                    WayProb.U = 3;
                    WayProb.D = 3;
                    WayProb.R = 0;
                    break;
            }

            if (!CheckDungeon())
                return;

            for (int i = 0; i < times; i++)
            {
                if (!Simulate())
                    return;
            }

            double totalWalkTimes = GetTotalWalkTimes();

            ShowNumber(totalWalkTimes);
        }

        private bool CheckDungeon()
        {
            if (roomBlocks == null)
            {
                MessageBox.Show("No block in the dungeon.");
                return false;
            }

            HideNumber();
            entranceList.Clear();

            bool bHasRoom = false;
            bool bHasExit = false;
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (!roomBlocks[r][c].Controls.OfType<Room>().Any<Room>())
                        roomBlocks[r][c].ClearRoom();
                    else
                    {
                        Room room = GetRoom(r, c);

                        if (room != null)
                        {
                            room.Reset();
                            if (c == 0 && room.RoomWay > 8)
                                bHasExit = true;
                            bHasRoom = true;
                            if (room.IsEntrance())
                                entranceList.Add(new Point(c, r));
                        }
                    }
                }
            }

            if (!bHasRoom)
            {
                MessageBox.Show("No room in blocks.");
                return false;
            }
            if (entranceList.Count == 0)
            {
                MessageBox.Show("No entrance in rooms.");
                return false;
            }
            if (!bHasExit)
            {
                MessageBox.Show("No exit in dungeon.");
                return false;
            }

            return true;
        }

        private bool Simulate()
        {
            Point curPoint = entranceList[rand.Next(entranceList.Count)];
            int source = 0;
            while (true)
            {
                Room curRoom = GetRoom(curPoint);
                if (curRoom == null)
                {
                    MessageBox.Show("Walk to empty block or out of map. Please check your map.");
                    return false;
                }
                curRoom.Walk();
                int way = curRoom.GetNextWay(source);

                if (way == 8)
                {
                    curPoint.X -= 1;
                    source = 1;
                }
                else if (way == 4)
                {
                    curPoint.Y -= 1;
                    source = 2;
                }
                else if (way == 2)
                {
                    curPoint.Y += 1;
                    source = 4;
                }
                else
                {
                    curPoint.X += 1;
                    source = 8;
                }

                if (curPoint.X < 0)
                    return true;
            }
        }

        private Room GetRoom(Point pt)
        {
            Room room;
            try
            {
                room = roomBlocks[pt.Y][pt.X].GetRoom();
            }
            catch
            {
                return null;
            }
            return room;
        }

        private Room GetRoom(int row, int col)
        {
            return roomBlocks[row][col].GetRoom();
        }

        private double GetTotalWalkTimes()
        {
            double totalWalkTimes = 0;
            foreach (List<RoomBlock> blocks in roomBlocks)
            {
                foreach (RoomBlock block in blocks)
                {
                    Room room = block.GetRoom();
                    if (room != null)
                        totalWalkTimes += room.GetWalkTimes();
                }
            }
            return totalWalkTimes;
        }
    }

    static public class WayProb
    {
        static public int L = 1;
        static public int U = 1;
        static public int D = 1;
        static public int R = 1;
    }

    public class RoomBlocks : List<List<RoomBlock>> { }
}
