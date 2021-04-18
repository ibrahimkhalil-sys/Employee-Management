using ClosedXML.Excel;
using sirketiscileri.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sirketiscileri
{
    public partial class Login : Form
    {
        List<Employees> employee = new List<Employees>();

        public Login()
        {
            InitializeComponent();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_name.Text = string.Empty;
            textBox_password.Text = string.Empty;
        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            string username, password = "";
            username = textBox_name.Text;
            password = textBox_password.Text;

            bool control = false;

            DataGridView dataGridView1 = new DataGridView();
            using (XLWorkbook wb = new XLWorkbook("../../data/employees.xlsx"))
            {
                var ws = wb.Worksheets.First();
                var range = ws.RangeUsed();

                for (int i = 1; i < range.ColumnCount() + 1; i++)
                {
                    dataGridView1.Columns.Add(ws.Cell(i, 1).Value.ToString(), ws.Cell(i, 1).Value.ToString());
                }

                dataGridView1.Rows.Add(range.RowCount() + 1) ;

                for (int i = 2; i < range.RowCount() + 1; i++)
                {
                    for (int j = 1; j < range.ColumnCount(); j++)
                    {

                        dataGridView1[j, i].Value = ws.Cell(i, j).Value;
                    }
                }
            }


            for (int j = 2; j < dataGridView1.Rows.Count; j++)


            //foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (username.ToLower() == dataGridView1[6, j].Value?.ToString()
                    && password.ToLower() == dataGridView1[7, j].Value?.ToString()
                    && dataGridView1[5, j].Value?.ToString() == "manager")
                {
                    Manager manager = new Manager(employee);
                    manager.Show();
                    this.Hide();
                    control = true;
                    break;
                }
                else if (username.ToLower() == dataGridView1[6, j].Value?.ToString()
                    && password.ToLower() == dataGridView1[7, j].Value?.ToString()
                    && dataGridView1[5, j].Value?.ToString() == "staff")
                {
                    Staff staff = new Staff(username);
                    staff.Show();
                    this.Hide();
                    control = true;
                    break;
                }

            }
            if (!control)
            {
                MessageBox.Show("password or user name is invalid", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        //dubul
        private void Form1_Load(object sender, EventArgs e)
        {
            /*employee.Add(new Employees("musa", "zutov", 456788, "manager","musa","1", "1000000"));
            employee.Add(new Employees("ibrahim", "osmanov", 1234567, "manager","ibo", "2"));
            employee.Add(new Employees("kamil", "hacilov", 675438, "staff", "kamil", "3"));
            employee.Add(new Employees("huseyn", "semedli", 567893, "staff", "huseyn", "4"));
            employee.Add(new Employees("abdul", "memmedli", 987654, "staff", "abdul", "5"));
            employee.Add(new Employees("maykl", "oven", 456738, "staff", "maykl", "6"));
            employee.Add(new Employees("suzuki", "yamanishi", 3546789, "staff", "suzuki", "7"));
            employee.Add(new Employees("samir", "qafarov", 345786, "staff", "samir", "8"));
            employee.Add(new Employees("azer", "zeynalov", 345787, "staff", "azer", "9"));

*/

        }
    }
}
