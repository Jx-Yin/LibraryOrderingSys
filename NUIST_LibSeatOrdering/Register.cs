using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using System.IO;
using System.Configuration;
using Newtonsoft.Json.Linq;
using Af.Common;

namespace NUIST_LibSeatOrdering
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            label3.Parent = pictureBox1;
        }

        private void SaveData()
        {
            List<Student> stuList = new List<Student>();
            Student stu = new Student(Convert.ToInt32(account_field.Text.Trim()), password_field.Text.Trim());
            stuList.Add(stu);

            string jsonStr = JsonConvert.SerializeObject(stuList, Formatting.Indented);
            AfTextFile.Write("student.json", jsonStr, AfTextFile.UTF8);
        }

        public Student GetValue()
        {
            Student stu = new Student();
            try
            {
                stu.account = Convert.ToInt32(account_field.Text.Trim());
            }
            catch (System.FormatException e)
            {
                MessageBox.Show("学号须为数字!");
                return null;
            }

            stu.password = password_field.Text.Trim();
            stu.ordered = false;

            return stu;
        }

        private void register_in_Click(object sender, EventArgs e)
        {
            //string jsonStr = JsonConvert.SerializeObject(stu);  //POJO转换为JSON string （pojo：java简单实体类
            //Student pojo = JsonConvert.DeserializeObject<Student>(jsonStr);   //JSON string转换为POJO

            //JObject j2 = JObject.FromObject(stu);
            //Student stu2 = j2.ToObject<Student>();    //POJO转换为JObject
            if (password_field.Text == password_repeat_field.Text)
            {
                Student stu = GetValue();
                Admin admin_backwork = new Admin();
                admin_backwork.AddRow(stu);
                MessageBox.Show("您已成功注册！请重新登录您的账号！");
                Login fram = new Login();
                this.Close();
                fram.Show();
            }
            else
                MessageBox.Show("请确保密码再次正确输入~");
        }

        public void TextFile_output(string path, JObject j2)
        {
            FileStream F = new FileStream(@"\student_info.json", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            Student.count++;
        }

        private void register_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Login frame1 = new Login();
            frame1.Show();
        }
    }
}
