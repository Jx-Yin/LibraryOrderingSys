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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();

            InitGridView();
            LoadData();
        }
        private void InitGridView()
        {
            grid.ReadOnly = true;

            //AddRow(new Student(20210001, "绫波 丽", true));
            //AddRow(new Student(20210002, "惣流·明日香·兰格雷", false));
            //AddRow(new Student(20210003, "碇真 嗣", true));
        }

        public void AddRow(Student stu)
        {
            object[] row =
            {
                stu.account,
                stu.password,
                stu.ordered ? true : false,
                stu.blocked ? true : false
            };

            int rowIndex = grid.Rows.Add(row);
            grid.Rows[rowIndex].Tag = stu; // 关联数据

            SaveData(); //保存数据
        }

        private void grid_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // GetCellAt: 根据点击的位置，判断点中了哪个单元格
                Point p = GetCellAt(grid, e.Location);
                int rowIndex = p.X;

                // 设置选中状态
                grid.ClearSelection();
                if (rowIndex >= 0)
                    grid.Rows[rowIndex].Selected = true;

                // 设置菜单项的状态
                menu_Delete.Enabled = (rowIndex >= 0);
                menu_Edit.Enabled = (rowIndex >= 0);

                contextMenu.Show(grid, e.Location);
            }
        }

        // 根据鼠标点击的位置，判断该位置所在的单位格的索引
        public static Point GetCellAt(DataGridView grid, Point location)
        {
            int row = -1, col = -1;

            // 一共显示的行数: DisplayedRowCount()
            // 第一个显示的行： FirstDisplayedScrollingRowIndex
            // 某行的显示区域:  GetRowDisplayRectangle()
            for (int i = grid.FirstDisplayedScrollingRowIndex;
                i < grid.FirstDisplayedScrollingRowIndex + grid.DisplayedRowCount(true);
                i++)
            {
                Rectangle rect = grid.GetRowDisplayRectangle(i, true);
                if (location.Y > rect.Top && location.Y < rect.Bottom)
                {
                    row = i;
                    break;
                }
            }

            for (int k = grid.FirstDisplayedScrollingColumnIndex;
                k < grid.FirstDisplayedScrollingColumnIndex + grid.DisplayedColumnCount(true);
                k++)
            {
                Rectangle rect = grid.GetColumnDisplayRectangle(k, true);
                if (location.X > rect.Left && location.X < rect.Right)
                {
                    col = k;
                    break;
                }
            }

            return new Point(row, col);
        }

        private void menu_Add_Click_1(object sender, EventArgs e)
        {
            StuEditDialog dlg = new StuEditDialog();
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                Student stu = dlg.GetValue();
                AddRow(stu);
            }
        }

        private void menu_Delete_Click(object sender, EventArgs e)
        {
            MyConfirmDialog dlg = new MyConfirmDialog();

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                foreach (DataGridViewRow row in grid.SelectedRows)
                {
                    grid.Rows.Remove(row);
                }
                SaveData();
            }
        }

        private void menu_Edit_Click(object sender, EventArgs e)
        {
            // 当前行
            int rowIndex = grid.SelectedRows[0].Index;
            // 当前行关联的数据
            Student tag = (Student)grid.Rows[rowIndex].Tag;

            // 弹出对话框
            StuEditDialog dlg = new StuEditDialog();
            dlg.InitValue(tag); 
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                Student stu = dlg.GetValue();
                UpdateRow(rowIndex, stu);
            }
        }

        public void UpdateRow(int rowIndex, Student stu)
        {
            grid.Rows[rowIndex].Tag = stu;
            grid[0, rowIndex].Value = stu.account;
            grid[1, rowIndex].Value = stu.password;
            grid[2, rowIndex].Value = stu.ordered ? true : false;
            grid[3, rowIndex].Value = stu.blocked ? true : false;

            SaveData();
        }

        private void SaveData()
        {
            List<Student> stuList = new List<Student>();
            for (int i = 0; i < grid.Rows.Count; i++)
            {
                Student stu = (Student)grid.Rows[i].Tag;
                stuList.Add(stu);
            }

            string jsonStr = JsonConvert.SerializeObject(stuList, Formatting.Indented);
            AfTextFile.Write("student.json", jsonStr, AfTextFile.UTF8);
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

            // 显示到表格中
            grid.Rows.Clear();
            foreach (Student stu in stuList)
            {
                AddRow(stu);
            }
        }

        private void menu_Exit_Click(object sender, EventArgs e)
        {
            Login frame1 = new Login();
            this.Close();
            frame1.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
