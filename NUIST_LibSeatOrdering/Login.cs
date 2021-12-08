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
using Newtonsoft.Json;

namespace NUIST_LibSeatOrdering
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            title_box.Parent = pictureBox1;
            label1.Parent = pictureBox1;
            label2.Parent = pictureBox1;
            hello.Parent = pictureBox1;
            pictureBox3.Parent = pictureBox1;

            LoadData();
        }

        private int stu_account { get; set; }
        private string stu_password { get; set; }
        private bool stu_ordered { get; set; }

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

            // 显示到下拉栏中

            foreach (Student stu in stuList)
            {
                AddAccount(stu);
            }
        }

        private string search_password(int account)
        {
            string jsonFile = "student.json";
            if (!File.Exists(jsonFile))
            {
                MessageBox.Show("找不到数据库");
                return "false";
            }
            // 从文件中读出文本
            string jsonStr = AfTextFile.Read(jsonFile, AfTextFile.UTF8);
            // 将jsonStr 转成 List<Student>
            List<Student> stuList
                = JsonConvert.DeserializeObject<List<Student>>(jsonStr);

            //搜索密码
            foreach(Student stu in stuList)
            {
                if (stu.account == account)
                    return stu.password;
                else continue;
            }
            MessageBox.Show("找不到账号！");
            return "false";
        }

        //下拉列表显示现有账号
        private void AddAccount(Student stu)
        {
            object[] row =
            {
                stu.account,
                stu.password,
                stu.ordered ? true : false
            };

            int rowIndex = Account_in.Items.Add(row[0]);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool password_str = checkBox1.Checked;
            if (password_str)
                Password_in.PasswordChar = '\0';
            else
                Password_in.PasswordChar = '❤';
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("  “君住长江头，我住长江尾。日夜思君不见君，共饮长江水。”\n\n" +
                "                   欢迎使用图书馆座位预约系统❤！");
        }

        //前往注册
        private void register_button_Click(object sender, EventArgs e)
        {
            Register form2 = new Register();
            form2.Show();
            this.Hide();
        }

        //登录操作
        private void log_in_button_Click(object sender, EventArgs e)
        {
            if (Account_in.Text == "admin" && admin_check.Checked)      //管理员登录
            {
                if (Password_in.Text == "nopassword")
                {
                    Admin form3 = new Admin();
                    MessageBox.Show("欢迎admin管理员掌握权力的法杖_(:з」∠)_");
                    this.Hide();
                    form3.Show();
                }
                else
                    MessageBox.Show("管理员密码错误！请思考你的身份 (ﾟДﾟ≡ﾟдﾟ)!?");
            }
            else    //正常登录
            {
                try
                {
                    if (search_password(Convert.ToInt32(Account_in.Text)) == Password_in.Text)
                    {
                        stu_account = Convert.ToInt32(Account_in.Text);
                        stu_password = Password_in.Text;

                        Client frame1 = new Client(Convert.ToInt32(Account_in.Text), stu_password);
                        frame1.Show();
                        this.Hide();
                    }
                    else
                        MessageBox.Show("密码错误！请再次尝试一次 (ﾟДﾟ≡ﾟдﾟ)!?");
                }
                catch(Exception ec)
                {
                    MessageBox.Show("请输入十位以下数字学号！\n管理员请勾选管理员登录√");
                }
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //获得已登录学生的账号和密码
        public int get_account()
        {
            return stu_account;
        }
        public string get_password()
        {
            return stu_password;
        }
    }
}
