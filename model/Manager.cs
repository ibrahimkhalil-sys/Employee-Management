using ClosedXML.Excel;
using Employees.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employees
{
    public partial class Manager : Form
    {
        /// <summary>
        /// iscilerin siyahisidi exel atkaz verse lazim olar
        /// </summary>
        List<model.Employees> employees;
        public Manager(List<model.Employees> employees)
        {
            InitializeComponent();
            this.employees = employees;
        }

       

        /// <summary>
        /// manager pencere acilanda adlari getirir(excelden)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Manager_Load(object sender, EventArgs e)
        {
            using (XLWorkbook wb = new XLWorkbook("../../data/employees.xlsx"))
            {
                var ws = wb.Worksheets.First();
                var range = ws.RangeUsed();
                employees_grid.Rows.Add(range.RowCount() - 2);

                for (int i = 2; i < range.RowCount() + 1; i++)
                {
                    for (int j = 1; j < range.ColumnCount() + 1; j++)
                    {
                        employees_grid[j - 1, i - 2].Value = ws.Cell(i, j).Value;
                    }
                }
            }
        }

        /// <summary>
        /// text boxlari dolduran eventdi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fillTheForm();
        }

        /// <summary>
        /// text boxlari doldurur
        /// </summary>
        public void fillTheForm()
        {
            txt_name.Text = employees_grid.CurrentRow.Cells[1].Value.ToString();
            txt_surname.Text = employees_grid.CurrentRow.Cells[2].Value.ToString();
            txt_passportnum.Text = employees_grid.CurrentRow.Cells[3].Value.ToString();
            txt_position.Text = employees_grid.CurrentRow.Cells[4].Value.ToString();

        }

        /// <summary>
        /// clear buton eventi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btn_clear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < groupBox_empprocess.Controls.Count; i++)
            {
                if (groupBox_empprocess.Controls[i] is TextBox || groupBox_empprocess.Controls[i] is MaskedTextBox)
                {
                    groupBox_empprocess.Controls[i].Text = string.Empty;
                }
            }
        }

        /// <summary>
        /// uptate buton eventi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_uptate_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            string surname = txt_surname.Text;
            string passportnum = txt_passportnum.Text;
            string position = txt_position.Text;

            employees_grid[1, employees_grid.CurrentRow.Index].Value = name;
            employees_grid[2, employees_grid.CurrentRow.Index].Value = surname;
            employees_grid[3, employees_grid.CurrentRow.Index].Value = passportnum;
            employees_grid[4, employees_grid.CurrentRow.Index].Value = position;

        }

        /// <summary>
        /// delete buton eventi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btn_delete_Click(object sender, EventArgs e)
        {
            employees_grid.Rows.Remove(employees_grid.CurrentRow);
        }

        /// <summary>
        /// add buton eventi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btn_add_Click(object sender, EventArgs e)
        {
            int i = int.Parse(employees_grid[0, employees_grid.Rows.Count - 1].Value.ToString()) + 1;
            employees_grid.Rows.Add(i, txt_name.Text, txt_surname.Text, txt_passportnum.Text, txt_position.Text);
        }

        /// <summary>
        /// mouseclick eventi(sag basanda contex acilir)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();

                for (int i = 1; i < employees_grid.Columns.Count; i++)
                {
                    m.MenuItems.Add(new MenuItem(employees_grid.Columns[i].HeaderText + " | " + employees_grid.SelectedRows[0].Cells[i].Value.ToString()));
                }

                using (XLWorkbook wb = new XLWorkbook("../../data/employees_info.xlsx"))
                {
                    var ws = wb.Worksheets.First();
                    var range = ws.RangeUsed();

                    for (int i = 1; i <= range.ColumnCount(); i++)
                    {
                        m.MenuItems.Add(new MenuItem(ws.Cell(1, i).Value.ToString() + " | " + ws.Cell((employees_grid.SelectedRows[0].Index + 2), i).Value.ToString()));

                    }
                }
                m.Show(employees_grid, new Point(e.X, e.Y));
            }
        }

        /// <summary>
        /// form baglananda applicationda baglansin
        /// arxada iwlemesin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Manager_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// save excel buton eventi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveExcel_Click(object sender, EventArgs e)
        {
            //save olunasi faylin yeri
            FileInfo outputFile = new FileInfo("../../data/employees.xlsx");
            XLWorkbook wb = new XLWorkbook();
            //DataTable dt = employees_grid.DataSource.<DataTable>();

            //excelde seyfenin adi
            var worksheet = wb.Worksheets.Add("employees");
            //var range = worksheet.Cell(2, 1).InsertData(dt.AsEnumerable());
            for (int i = 0; i < employees_grid.Rows.Count; i++)
            {
                for (int j = 0; j < employees_grid.Columns.Count; j++)
                {
                    worksheet.Cell(1, j + 1).Value = employees_grid.Columns[j].HeaderCell.Value?.ToString();
                    worksheet.Cell(i + 2, j + 1).Value = employees_grid[j, i].Value?.ToString();
                }
            }
            worksheet.Column(2).Width = 8.0;

            using (MemoryStream memoryStream = SaveWorkbookToMemoryStream(wb))
            {
                File.WriteAllBytes(outputFile.FullName, memoryStream.ToArray());
            }
            wb.Dispose();

            MessageBox.Show("Your file was saved as: " + outputFile.FullName);

            MemoryStream SaveWorkbookToMemoryStream(XLWorkbook workbook)
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    workbook.SaveAs(stream, new SaveOptions { EvaluateFormulasBeforeSaving = false, GenerateCalculationChain = false, ValidatePackage = false });
                    return stream;
                }
            }

        }
    }
}

