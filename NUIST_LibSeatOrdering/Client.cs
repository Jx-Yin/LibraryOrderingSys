using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Af.Common;
using MetroFramework;
using Newtonsoft.Json;

namespace NUIST_LibSeatOrdering
{
    public partial class Client : MetroFramework.Forms.MetroForm
    {
        public int stu_account { get; set; }
        public string stu_password { get; set; }
        public bool stu_ordered { get; set; }
        public bool stu_blocked { get; set; }
        public Student stu;

        public Client(int account, string password)
        {
            stu_account = account;
            stu_password = password;
            LoadData();
            InitializeComponent();
            title_box.BackColor = System.Drawing.Color.Transparent;
            title_box.Parent = pictureBox1;
        }

        // 数据的加载
        private void LoadData()
        {
            string jsonFile = "student.json";
            if (!File.Exists(jsonFile)) return;

            // 从文件中读出文本
            string jsonStr = AfTextFile.Read(jsonFile, AfTextFile.UTF8);

            // 将jsonStr 转成 List<Student>
            List<Student> stuList
                = JsonConvert.DeserializeObject<List<Student>>(jsonStr);

            //惩罚信息确认
            foreach (Student stu in stuList)
            {
                if (stu_account == stu.account)
                {
                    stu_blocked = stu.blocked;
                    stu_ordered = stu.ordered;
                    this.stu = stu;
                }
            }
        }

        private void Client_Load(object sender, EventArgs e)
        {
            MessageBox.Show("欢迎来到NUIST图书馆座位预约！");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login frame1 = new Login();
            MessageBox.Show("欢迎您再次使用本系统❤");
            this.Close();
            frame1.Show();
        }

        private void Call_admin_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("  √管理员是形P，形P是管理员，请别找形P，找管理员。\n管理员可能删库跑路了，但形P不可能。");
        }

        private void Password_change_button_Click(object sender, EventArgs e)
        {
            PasswordChange frame2 = new PasswordChange(stu_account, stu_password);
            this.Close();
            frame2.Show();
        }

        private void Seat_info_button_Click(object sender, EventArgs e)
        {
            LibWeb library = new LibWeb();
            library.Show();
        }

        private void Order_button_Click(object sender, EventArgs e)
        {
            if(stu_blocked)
                MessageBox.Show("您已被列入预约黑名单！\n请向管理员申请检讨解除或者等待新学期自动解除！");
            else
            {
                Ordering frame = new Ordering(stu_account, stu_password);
                this.Close();
                frame.Show();
            }
        }

        private void Blocked_check_button_Click(object sender, EventArgs e)
        {
            if (stu_blocked)
                MessageBox.Show("您已被列入预约黑名单！\n请向管理员申请检讨解除或者等待新学期自动解除！");
            else
                MessageBox.Show("您的账号正常！\n请继续保持良好公德心！");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (stu_ordered)
            {

            }
            else
                MessageBox.Show("您还未预约，请点击座位预约预约座位~");
        }
    }
}
