namespace MazeSimulator
{
    partial class MainFrame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();        }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gb_relic = new System.Windows.Forms.GroupBox();
            this.rBtn_realMap = new System.Windows.Forms.RadioButton();
            this.rBtn_fakeMap = new System.Windows.Forms.RadioButton();
            this.rBtn_noRelic = new System.Windows.Forms.RadioButton();
            this.tb_width = new System.Windows.Forms.TextBox();
            this.tb_height = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_create = new System.Windows.Forms.Button();
            this.gb_rooms = new System.Windows.Forms.GroupBox();
            this.gb_remove = new System.Windows.Forms.GroupBox();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.btn_clearResult = new System.Windows.Forms.Button();
            this.tb_calTimes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_removeAll = new System.Windows.Forms.Button();
            this.maze_TrashCan = new MazeSimulator.Maze.Maze();
            this.maze = new MazeSimulator.Maze.Maze();
            this.entrance1 = new MazeSimulator.Maze.Entrance();
            this.room15 = new MazeSimulator.Maze.Room();
            this.room9 = new MazeSimulator.Maze.Room();
            this.room6 = new MazeSimulator.Maze.Room();
            this.room8 = new MazeSimulator.Maze.Room();
            this.room4 = new MazeSimulator.Maze.Room();
            this.room1 = new MazeSimulator.Maze.Room();
            this.room2 = new MazeSimulator.Maze.Room();
            this.room10 = new MazeSimulator.Maze.Room();
            this.room12 = new MazeSimulator.Maze.Room();
            this.room5 = new MazeSimulator.Maze.Room();
            this.room3 = new MazeSimulator.Maze.Room();
            this.room14 = new MazeSimulator.Maze.Room();
            this.room13 = new MazeSimulator.Maze.Room();
            this.room7 = new MazeSimulator.Maze.Room();
            this.room11 = new MazeSimulator.Maze.Room();
            this.gb_relic.SuspendLayout();
            this.gb_rooms.SuspendLayout();
            this.gb_remove.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_relic
            // 
            this.gb_relic.Controls.Add(this.rBtn_realMap);
            this.gb_relic.Controls.Add(this.rBtn_fakeMap);
            this.gb_relic.Controls.Add(this.rBtn_noRelic);
            this.gb_relic.Location = new System.Drawing.Point(420, 320);
            this.gb_relic.Name = "gb_relic";
            this.gb_relic.Size = new System.Drawing.Size(247, 49);
            this.gb_relic.TabIndex = 1;
            this.gb_relic.TabStop = false;
            this.gb_relic.Text = "Relic";
            // 
            // rBtn_realMap
            // 
            this.rBtn_realMap.AutoSize = true;
            this.rBtn_realMap.Location = new System.Drawing.Point(170, 21);
            this.rBtn_realMap.Name = "rBtn_realMap";
            this.rBtn_realMap.Size = new System.Drawing.Size(68, 16);
            this.rBtn_realMap.TabIndex = 2;
            this.rBtn_realMap.Text = "Real Map";
            this.rBtn_realMap.UseVisualStyleBackColor = true;
            this.rBtn_realMap.CheckedChanged += new System.EventHandler(this.Relic_CheckedChanged);
            // 
            // rBtn_fakeMap
            // 
            this.rBtn_fakeMap.AutoSize = true;
            this.rBtn_fakeMap.Location = new System.Drawing.Point(95, 21);
            this.rBtn_fakeMap.Name = "rBtn_fakeMap";
            this.rBtn_fakeMap.Size = new System.Drawing.Size(69, 16);
            this.rBtn_fakeMap.TabIndex = 1;
            this.rBtn_fakeMap.Text = "Fake Map";
            this.rBtn_fakeMap.UseVisualStyleBackColor = true;
            this.rBtn_fakeMap.CheckedChanged += new System.EventHandler(this.Relic_CheckedChanged);
            // 
            // rBtn_noRelic
            // 
            this.rBtn_noRelic.AutoSize = true;
            this.rBtn_noRelic.Checked = true;
            this.rBtn_noRelic.Location = new System.Drawing.Point(20, 21);
            this.rBtn_noRelic.Name = "rBtn_noRelic";
            this.rBtn_noRelic.Size = new System.Drawing.Size(64, 16);
            this.rBtn_noRelic.TabIndex = 0;
            this.rBtn_noRelic.TabStop = true;
            this.rBtn_noRelic.Text = "No Relic";
            this.rBtn_noRelic.UseVisualStyleBackColor = true;
            this.rBtn_noRelic.CheckedChanged += new System.EventHandler(this.Relic_CheckedChanged);
            // 
            // tb_width
            // 
            this.tb_width.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tb_width.Location = new System.Drawing.Point(458, 12);
            this.tb_width.Name = "tb_width";
            this.tb_width.Size = new System.Drawing.Size(40, 22);
            this.tb_width.TabIndex = 2;
            this.tb_width.Text = "3";
            this.tb_width.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_width_KeyPress);
            // 
            // tb_height
            // 
            this.tb_height.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tb_height.Location = new System.Drawing.Point(546, 12);
            this.tb_height.Name = "tb_height";
            this.tb_height.Size = new System.Drawing.Size(40, 22);
            this.tb_height.TabIndex = 4;
            this.tb_height.Text = "3";
            this.tb_height.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_height_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(504, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Height";
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(598, 12);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(69, 23);
            this.btn_create.TabIndex = 7;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // gb_rooms
            // 
            this.gb_rooms.Controls.Add(this.entrance1);
            this.gb_rooms.Controls.Add(this.room15);
            this.gb_rooms.Controls.Add(this.room9);
            this.gb_rooms.Controls.Add(this.room6);
            this.gb_rooms.Controls.Add(this.room8);
            this.gb_rooms.Controls.Add(this.room4);
            this.gb_rooms.Controls.Add(this.room1);
            this.gb_rooms.Controls.Add(this.room2);
            this.gb_rooms.Controls.Add(this.room10);
            this.gb_rooms.Controls.Add(this.room12);
            this.gb_rooms.Controls.Add(this.room5);
            this.gb_rooms.Controls.Add(this.room3);
            this.gb_rooms.Controls.Add(this.room14);
            this.gb_rooms.Controls.Add(this.room13);
            this.gb_rooms.Controls.Add(this.room7);
            this.gb_rooms.Controls.Add(this.room11);
            this.gb_rooms.Location = new System.Drawing.Point(420, 41);
            this.gb_rooms.Name = "gb_rooms";
            this.gb_rooms.Size = new System.Drawing.Size(247, 273);
            this.gb_rooms.TabIndex = 8;
            this.gb_rooms.TabStop = false;
            this.gb_rooms.Text = "Rooms";
            // 
            // gb_remove
            // 
            this.gb_remove.Controls.Add(this.maze_TrashCan);
            this.gb_remove.Location = new System.Drawing.Point(12, 406);
            this.gb_remove.Name = "gb_remove";
            this.gb_remove.Size = new System.Drawing.Size(388, 95);
            this.gb_remove.TabIndex = 9;
            this.gb_remove.TabStop = false;
            this.gb_remove.Text = "Drop here to remove";
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(511, 478);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(75, 23);
            this.btn_calculate.TabIndex = 10;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // btn_clearResult
            // 
            this.btn_clearResult.Location = new System.Drawing.Point(592, 478);
            this.btn_clearResult.Name = "btn_clearResult";
            this.btn_clearResult.Size = new System.Drawing.Size(75, 23);
            this.btn_clearResult.TabIndex = 11;
            this.btn_clearResult.Text = "Clear Result";
            this.btn_clearResult.UseVisualStyleBackColor = true;
            this.btn_clearResult.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // tb_calTimes
            // 
            this.tb_calTimes.Location = new System.Drawing.Point(567, 450);
            this.tb_calTimes.Name = "tb_calTimes";
            this.tb_calTimes.Size = new System.Drawing.Size(100, 22);
            this.tb_calTimes.TabIndex = 12;
            this.tb_calTimes.Text = "1";
            this.tb_calTimes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_calTimes_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(475, 453);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "Simulation Times";
            // 
            // btn_removeAll
            // 
            this.btn_removeAll.Enabled = false;
            this.btn_removeAll.Location = new System.Drawing.Point(546, 375);
            this.btn_removeAll.Name = "btn_removeAll";
            this.btn_removeAll.Size = new System.Drawing.Size(121, 23);
            this.btn_removeAll.TabIndex = 14;
            this.btn_removeAll.Text = "Remove All Room";
            this.btn_removeAll.UseVisualStyleBackColor = true;
            this.btn_removeAll.Click += new System.EventHandler(this.btn_removeAll_Click);
            // 
            // dungeon_TrashCan
            // 
            this.maze_TrashCan.AllowDrop = true;
            this.maze_TrashCan.AutoScroll = true;
            this.maze_TrashCan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.maze_TrashCan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maze_TrashCan.Location = new System.Drawing.Point(3, 18);
            this.maze_TrashCan.Name = "dungeon_TrashCan";
            this.maze_TrashCan.Size = new System.Drawing.Size(382, 74);
            this.maze_TrashCan.TabIndex = 0;
            // 
            // dungeon
            // 
            this.maze.AllowDrop = true;
            this.maze.AutoScroll = true;
            this.maze.BackColor = System.Drawing.SystemColors.Window;
            this.maze.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maze.Location = new System.Drawing.Point(12, 12);
            this.maze.Name = "dungeon";
            this.maze.Size = new System.Drawing.Size(388, 388);
            this.maze.TabIndex = 0;
            // 
            // entrance1
            // 
            this.entrance1.AllowDrop = true;
            this.entrance1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.entrance1.DropMode = MazeSimulator.Maze.DropMode.Copy;
            this.entrance1.Location = new System.Drawing.Point(203, 218);
            this.entrance1.Name = "entrance1";
            this.entrance1.Size = new System.Drawing.Size(20, 20);
            this.entrance1.TabIndex = 15;
            // 
            // room15
            // 
            this.room15.AllowDrop = true;
            this.room15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.room15.DropMode = MazeSimulator.Maze.DropMode.Copy;
            this.room15.Location = new System.Drawing.Point(126, 201);
            this.room15.Name = "room15";
            this.room15.RoomWay = 15;
            this.room15.Size = new System.Drawing.Size(54, 54);
            this.room15.TabIndex = 14;
            // 
            // room9
            // 
            this.room9.AllowDrop = true;
            this.room9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.room9.DropMode = MazeSimulator.Maze.DropMode.Copy;
            this.room9.Location = new System.Drawing.Point(66, 201);
            this.room9.Name = "room9";
            this.room9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.room9.RoomWay = 9;
            this.room9.Size = new System.Drawing.Size(54, 54);
            this.room9.TabIndex = 13;
            // 
            // room6
            // 
            this.room6.AllowDrop = true;
            this.room6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.room6.DropMode = MazeSimulator.Maze.DropMode.Copy;
            this.room6.Location = new System.Drawing.Point(6, 201);
            this.room6.Name = "room6";
            this.room6.RoomWay = 6;
            this.room6.Size = new System.Drawing.Size(54, 54);
            this.room6.TabIndex = 12;
            // 
            // room8
            // 
            this.room8.AllowDrop = true;
            this.room8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.room8.DropMode = MazeSimulator.Maze.DropMode.Copy;
            this.room8.Location = new System.Drawing.Point(186, 141);
            this.room8.Name = "room8";
            this.room8.RoomWay = 8;
            this.room8.Size = new System.Drawing.Size(54, 54);
            this.room8.TabIndex = 11;
            // 
            // room4
            // 
            this.room4.AllowDrop = true;
            this.room4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.room4.DropMode = MazeSimulator.Maze.DropMode.Copy;
            this.room4.Location = new System.Drawing.Point(126, 141);
            this.room4.Name = "room4";
            this.room4.RoomWay = 4;
            this.room4.Size = new System.Drawing.Size(54, 54);
            this.room4.TabIndex = 10;
            // 
            // room1
            // 
            this.room1.AllowDrop = true;
            this.room1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.room1.DropMode = MazeSimulator.Maze.DropMode.Copy;
            this.room1.Location = new System.Drawing.Point(66, 141);
            this.room1.Name = "room1";
            this.room1.RoomWay = 1;
            this.room1.Size = new System.Drawing.Size(54, 54);
            this.room1.TabIndex = 9;
            // 
            // room2
            // 
            this.room2.AllowDrop = true;
            this.room2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.room2.DropMode = MazeSimulator.Maze.DropMode.Copy;
            this.room2.Location = new System.Drawing.Point(6, 141);
            this.room2.Name = "room2";
            this.room2.RoomWay = 2;
            this.room2.Size = new System.Drawing.Size(54, 54);
            this.room2.TabIndex = 8;
            // 
            // room10
            // 
            this.room10.AllowDrop = true;
            this.room10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.room10.DropMode = MazeSimulator.Maze.DropMode.Copy;
            this.room10.Location = new System.Drawing.Point(186, 81);
            this.room10.Name = "room10";
            this.room10.RoomWay = 10;
            this.room10.Size = new System.Drawing.Size(54, 54);
            this.room10.TabIndex = 7;
            // 
            // room12
            // 
            this.room12.AllowDrop = true;
            this.room12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.room12.DropMode = MazeSimulator.Maze.DropMode.Copy;
            this.room12.Location = new System.Drawing.Point(126, 81);
            this.room12.Name = "room12";
            this.room12.RoomWay = 12;
            this.room12.Size = new System.Drawing.Size(54, 54);
            this.room12.TabIndex = 6;
            // 
            // room5
            // 
            this.room5.AllowDrop = true;
            this.room5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.room5.DropMode = MazeSimulator.Maze.DropMode.Copy;
            this.room5.Location = new System.Drawing.Point(66, 81);
            this.room5.Name = "room5";
            this.room5.RoomWay = 5;
            this.room5.Size = new System.Drawing.Size(54, 54);
            this.room5.TabIndex = 5;
            // 
            // room3
            // 
            this.room3.AllowDrop = true;
            this.room3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.room3.DropMode = MazeSimulator.Maze.DropMode.Copy;
            this.room3.Location = new System.Drawing.Point(6, 81);
            this.room3.Name = "room3";
            this.room3.RoomWay = 3;
            this.room3.Size = new System.Drawing.Size(54, 54);
            this.room3.TabIndex = 4;
            // 
            // room14
            // 
            this.room14.AllowDrop = true;
            this.room14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.room14.DropMode = MazeSimulator.Maze.DropMode.Copy;
            this.room14.Location = new System.Drawing.Point(186, 21);
            this.room14.Name = "room14";
            this.room14.RoomWay = 14;
            this.room14.Size = new System.Drawing.Size(54, 54);
            this.room14.TabIndex = 3;
            // 
            // room13
            // 
            this.room13.AllowDrop = true;
            this.room13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.room13.DropMode = MazeSimulator.Maze.DropMode.Copy;
            this.room13.Location = new System.Drawing.Point(126, 21);
            this.room13.Name = "room13";
            this.room13.RoomWay = 13;
            this.room13.Size = new System.Drawing.Size(54, 54);
            this.room13.TabIndex = 2;
            // 
            // room7
            // 
            this.room7.AllowDrop = true;
            this.room7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.room7.DropMode = MazeSimulator.Maze.DropMode.Copy;
            this.room7.Location = new System.Drawing.Point(66, 21);
            this.room7.Name = "room7";
            this.room7.RoomWay = 7;
            this.room7.Size = new System.Drawing.Size(54, 54);
            this.room7.TabIndex = 1;
            // 
            // room11
            // 
            this.room11.AllowDrop = true;
            this.room11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.room11.DropMode = MazeSimulator.Maze.DropMode.Copy;
            this.room11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.room11.Location = new System.Drawing.Point(6, 21);
            this.room11.Name = "room11";
            this.room11.RoomWay = 11;
            this.room11.Size = new System.Drawing.Size(54, 54);
            this.room11.TabIndex = 0;
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 513);
            this.Controls.Add(this.btn_removeAll);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_calTimes);
            this.Controls.Add(this.btn_clearResult);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.gb_remove);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_height);
            this.Controls.Add(this.tb_width);
            this.Controls.Add(this.maze);
            this.Controls.Add(this.gb_relic);
            this.Controls.Add(this.gb_rooms);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maze Simulator";
            this.Load += new System.EventHandler(this.MainFrame_Load);
            this.gb_relic.ResumeLayout(false);
            this.gb_relic.PerformLayout();
            this.gb_rooms.ResumeLayout(false);
            this.gb_remove.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gb_relic;
        private System.Windows.Forms.RadioButton rBtn_realMap;
        private System.Windows.Forms.RadioButton rBtn_fakeMap;
        private System.Windows.Forms.RadioButton rBtn_noRelic;
        private System.Windows.Forms.TextBox tb_width;
        private System.Windows.Forms.TextBox tb_height;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.GroupBox gb_rooms;
        private Maze.Maze maze;
        private Maze.Room room11;
        private Maze.Room room15;
        private Maze.Room room9;
        private Maze.Room room6;
        private Maze.Room room8;
        private Maze.Room room4;
        private Maze.Room room1;
        private Maze.Room room2;
        private Maze.Room room10;
        private Maze.Room room12;
        private Maze.Room room5;
        private Maze.Room room3;
        private Maze.Room room14;
        private Maze.Room room13;
        private Maze.Room room7;
        private System.Windows.Forms.GroupBox gb_remove;
        private Maze.Maze maze_TrashCan;
        private System.Windows.Forms.Button btn_calculate;
        private Maze.Entrance entrance1;
        private System.Windows.Forms.Button btn_clearResult;
        private System.Windows.Forms.TextBox tb_calTimes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_removeAll;
    }
}

