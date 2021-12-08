using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;

namespace NUIST_LibSeatOrdering
{
    public partial class Ordering : CCSkinMain
    {
        public int account;
        public string password;

        public Ordering(int account, string password)
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
            label1.Parent = skinPictureBox1;
            label2.Parent = skinPictureBox1;
            label3.Parent = skinPictureBox1;
            label4.Parent = skinPictureBox1;
            this.account = account;
            this.password = password;
        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            Client frame = new Client(account, password);
            this.Close();
            frame.Show();
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("您的座位已经预约好啦~");
            this.Close();
            Client form = new Client(account, password);
            form.Show();
        }
    }
}
