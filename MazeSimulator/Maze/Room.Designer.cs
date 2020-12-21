namespace MazeSimulator.Maze
{
    partial class Room
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
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Room
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Room";
            this.Size = new System.Drawing.Size(54, 54);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Room_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Room_DragEnter);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.room_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Room_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
