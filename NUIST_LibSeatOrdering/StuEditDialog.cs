using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NUIST_LibSeatOrdering
{
    public partial class StuEditDialog : Form
    {
        public StuEditDialog()
        {
            InitializeComponent();
        }

        public void InitValue(Student stu)
        {
            accountField.Enabled = false; // 学号不可编辑

            accountField.Text = stu.account + "";
            passwordField.Text = stu.password;
            orderedCheck.Checked = stu.ordered;
            blocked_check.Checked = stu.blocked;
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            Student stu = GetValue();
            if (stu == null)
                return;

            this.DialogResult = DialogResult.OK;
        }

        public Student GetValue()
        {
            Student stu = new Student();
            try
            {
                stu.account = Convert.ToInt32(accountField.Text.Trim());
            }
            catch (Exception e)
            {
                MessageBox.Show("学号须为数字!");
                return null;
            }

            stu.password = passwordField.Text.Trim();
            stu.ordered = orderedCheck.Checked;
            stu.blocked = blocked_check.Checked;

            return stu;
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void accountField_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
