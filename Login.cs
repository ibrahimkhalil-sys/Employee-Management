using ClosedXML.Excel;
using Employees.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employees
{
    public partial class Login : Form
    {
        /// <summary>
        /// isci siyahisi
        /// </summary>
        List<model.Employees> employee = new List<model.Employees>();

        /// <summary>
        /// metod(login) konstraktor
        /// </summary>
        public Login()
        {
            InitializeComponent();
        }

        /// <summary>
        /// clear
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_name.Text = string.Empty;
            textBox_password.Text = string.Empty;
        }


        /// <summary>
        /// enter kunopkasina basanda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_enter_Click(object sender, EventArgs e)
        {
            string username, password = "";
            username = textBox_name.Text;
            password = textBox_password.Text;

            bool control = false;

            // Login ucun excelden datagride yukluyub oxuyursan
            DataGridView gridEmployees = new DataGridView();
            using (XLWorkbook wb = new XLWorkbook("../../data/employees.xlsx"))
            {
                var ws = wb.Worksheets.First();
                var range = ws.RangeUsed();

                for (int i = 1; i < range.ColumnCount() + 1; i++)
                {
                    gridEmployees.Columns.Add(ws.Cell(i, 1).Value.ToString(), ws.Cell(i, 1).Value.ToString());
                }

                gridEmployees.Rows.Add(range.RowCount() + 1) ;

                for (int i = 2; i < range.RowCount() + 1; i++)
                {
                    for (int j = 1; j < range.ColumnCount(); j++)
                    {

                        gridEmployees[j, i].Value = ws.Cell(i, j).Value;
                    }
                }
            }


            for (int j = 2; j < gridEmployees.Rows.Count; j++)
            {
                if (username.ToLower() == gridEmployees[6, j].Value?.ToString()
                    && password.ToLower() == gridEmployees[7, j].Value?.ToString()
                    && gridEmployees[5, j].Value?.ToString() == "manager")
                {
                    Manager manager = new Manager(employee);
                    manager.Show();
                    this.Hide();
                    control = true;
                    break;
                }
                else if (username.ToLower() == gridEmployees[6, j].Value?.ToString()
                    && password.ToLower() == gridEmployees[7, j].Value?.ToString()
                    && gridEmployees[5, j].Value?.ToString() == "staff")
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

        /// <summary>
        /// formload backup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
