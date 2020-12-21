using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeSimulator
{
    public partial class MainFrame : Form
    {
        private string relic;

        public MainFrame()
        {
            InitializeComponent();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            int width, height;
            if (tb_width.Text == "")
                width = 1;
            else
                width = int.Parse(tb_width.Text);
            if (tb_height.Text == "")
                height = 1;
            else
                height = int.Parse(tb_height.Text);

            maze.CreateRoomBlocks(width, height);

            btn_removeAll.Enabled = true;
        }

        private void tb_width_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tb_height_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tb_calTimes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            //btn_create_Click(null, null);
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            if (tb_calTimes.Text == "")
                return;
            maze.Calculate(int.Parse(tb_calTimes.Text), relic);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            maze.HideNumber();
        }

        private void btn_removeAll_Click(object sender, EventArgs e)
        {
            maze.RemoveRooms();
        }

        private void Relic_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rBtn = sender as RadioButton;
            if (rBtn.Checked)
                relic = rBtn.Text;
        }
    }
}
