using Af.Common;
using Newtonsoft.Json;
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

namespace NUIST_LibSeatOrdering
{
    public partial class PasswordChange : Form
    {
        public int stu_account { get; set; }
        public string stu_password { get; set; }

        public PasswordChange(int account, string password)
        {
            stu_account = account;
            stu_password = password;
            InitializeComponent();
            label1.Parent = pictureBox1;
            label2.Parent = pictureBox1;
            label3.Parent = pictureBox1;

            Student stu = new Student(stu_account, stu_password);

            InitValue(stu);
        }

        public void InitValue(Student stu)
        {
            account_field.Enabled = false; // 学号不可编辑

            account_field.Text = stu.account + "";
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
            foreach (Student stu in stuList)
            {
                if (stu.account == account)
                    return stu.password;
                else continue;
            }
            MessageBox.Show("找不到账号！");
            return "false";
        }

        private void change_password(string newpassword)
        {
            string jsonFile = "student.json";
            if (!File.Exists(jsonFile))
            {
                MessageBox.Show("找不到数据库");
                return;
            }
            // 从文件中读出文本
            string jsonStr = AfTextFile.Read(jsonFile, AfTextFile.UTF8);
            // 将jsonStr 转成 List<Student>
            List<Student> stuList
                = JsonConvert.DeserializeObject<List<Student>>(jsonStr);

            //搜索密码并修改
            foreach (Student stu in stuList)
            {
                if (stu.password == password_field.Text)
                {
                    stu.password = newpassword;
                }
            }
            string JsonStr = JsonConvert.SerializeObject(stuList, Formatting.Indented);
            AfTextFile.Write("student.json", JsonStr, AfTextFile.UTF8);
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            if (search_password(Convert.ToInt32(account_field.Text)) == password_field.Text)
            {
                change_password(new_password_field.Text);
                MessageBox.Show("您已更换新密码");
                Client frame1 = new Client(Convert.ToInt32(account_field.Text), new_password_field.Text);
                frame1.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("原密码错误！请再次尝试一次 (ﾟДﾟ≡ﾟдﾟ)!?");
            }
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            Client frame1 = new Client(Convert.ToInt32(account_field.Text), password_field.Text);
            frame1.Show();
            this.Close();
        }
    }
}
