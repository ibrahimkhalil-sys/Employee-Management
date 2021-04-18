using ClosedXML.Excel;
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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }

        public Staff(string username)
        {
            Username = username;
            InitializeComponent();

            using (XLWorkbook wb = new XLWorkbook("../../employees.xlsx"))
            {
                var ws = wb.Worksheets.First();
                var range = ws.RangeUsed();

                for (int i = 2; i < range.RowCount() + 1; i++)
                {
                    if (Username == ws.Cell(i, 6).Value.ToString().ToLower())
                    {
                        txtName_name.Text = ws.Cell(i, 2).Value.ToString();
                        textBox1_surname.Text = ws.Cell(i, 3).Value.ToString();
                        textBox2_passport.Text = ws.Cell(i, 4).Value.ToString();
                        textBox3_position.Text = ws.Cell(i, 5).Value.ToString();
                        textBox4_username.Text = ws.Cell(i, 6).Value.ToString();
                        textBox5_password.Text = ws.Cell(i, 7).Value.ToString();
                        textBox_salary.Text = ws.Cell(i, 8).Value.ToString();

                        break;

                    }
                }
            }
        }

        public string Username { get; }

        private void Staff_Load(object sender, EventArgs e)
        {
            
        }
    }
}
