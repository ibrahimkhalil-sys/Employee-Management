
using System;
using System.ComponentModel;

namespace sirketiscileri
{
    partial class Manager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_empprocess = new System.Windows.Forms.GroupBox();
            this.btnSaveExcel = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_uptate = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.txt_position = new System.Windows.Forms.TextBox();
            this.lbl_position = new System.Windows.Forms.Label();
            this.txt_passportnum = new System.Windows.Forms.TextBox();
            this.lbl_passportnum = new System.Windows.Forms.Label();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbl_employees = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SURNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PASSPORTNUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.POSITION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USERNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PASSWORD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SALARY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_empprocess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_empprocess
            // 
            this.groupBox_empprocess.Controls.Add(this.btnSaveExcel);
            this.groupBox_empprocess.Controls.Add(this.btn_add);
            this.groupBox_empprocess.Controls.Add(this.btn_delete);
            this.groupBox_empprocess.Controls.Add(this.btn_uptate);
            this.groupBox_empprocess.Controls.Add(this.btn_clear);
            this.groupBox_empprocess.Controls.Add(this.txt_position);
            this.groupBox_empprocess.Controls.Add(this.lbl_position);
            this.groupBox_empprocess.Controls.Add(this.txt_passportnum);
            this.groupBox_empprocess.Controls.Add(this.lbl_passportnum);
            this.groupBox_empprocess.Controls.Add(this.txt_surname);
            this.groupBox_empprocess.Controls.Add(this.lbl_surname);
            this.groupBox_empprocess.Controls.Add(this.txt_name);
            this.groupBox_empprocess.Controls.Add(this.lbl_name);
            this.groupBox_empprocess.Location = new System.Drawing.Point(12, 12);
            this.groupBox_empprocess.Name = "groupBox_empprocess";
            this.groupBox_empprocess.Size = new System.Drawing.Size(242, 426);
            this.groupBox_empprocess.TabIndex = 0;
            this.groupBox_empprocess.TabStop = false;
            // 
            // btnSaveExcel
            // 
            this.btnSaveExcel.Location = new System.Drawing.Point(17, 401);
            this.btnSaveExcel.Name = "btnSaveExcel";
            this.btnSaveExcel.Size = new System.Drawing.Size(179, 23);
            this.btnSaveExcel.TabIndex = 7;
            this.btnSaveExcel.Text = "Save";
            this.btnSaveExcel.UseVisualStyleBackColor = true;
            this.btnSaveExcel.Click += new System.EventHandler(this.btnSaveExcel_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(17, 265);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(179, 23);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(17, 299);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(179, 23);
            this.btn_delete.TabIndex = 5;
            this.btn_delete.Text = "delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_uptate
            // 
            this.btn_uptate.Location = new System.Drawing.Point(17, 333);
            this.btn_uptate.Name = "btn_uptate";
            this.btn_uptate.Size = new System.Drawing.Size(179, 23);
            this.btn_uptate.TabIndex = 4;
            this.btn_uptate.Text = "uptate";
            this.btn_uptate.UseVisualStyleBackColor = true;
            this.btn_uptate.Click += new System.EventHandler(this.btn_uptate_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(17, 367);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(179, 23);
            this.btn_clear.TabIndex = 3;
            this.btn_clear.Text = "clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // txt_position
            // 
            this.txt_position.Location = new System.Drawing.Point(116, 101);
            this.txt_position.Name = "txt_position";
            this.txt_position.Size = new System.Drawing.Size(100, 19);
            this.txt_position.TabIndex = 1;
            // 
            // lbl_position
            // 
            this.lbl_position.AutoSize = true;
            this.lbl_position.Location = new System.Drawing.Point(15, 104);
            this.lbl_position.Name = "lbl_position";
            this.lbl_position.Size = new System.Drawing.Size(47, 12);
            this.lbl_position.TabIndex = 0;
            this.lbl_position.Text = "position:";
            // 
            // txt_passportnum
            // 
            this.txt_passportnum.Location = new System.Drawing.Point(116, 76);
            this.txt_passportnum.Name = "txt_passportnum";
            this.txt_passportnum.Size = new System.Drawing.Size(100, 19);
            this.txt_passportnum.TabIndex = 1;
            // 
            // lbl_passportnum
            // 
            this.lbl_passportnum.AutoSize = true;
            this.lbl_passportnum.Location = new System.Drawing.Point(15, 79);
            this.lbl_passportnum.Name = "lbl_passportnum";
            this.lbl_passportnum.Size = new System.Drawing.Size(74, 12);
            this.lbl_passportnum.TabIndex = 0;
            this.lbl_passportnum.Text = "passportNum:";
            // 
            // txt_surname
            // 
            this.txt_surname.Location = new System.Drawing.Point(116, 51);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(100, 19);
            this.txt_surname.TabIndex = 1;
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.Location = new System.Drawing.Point(15, 54);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(50, 12);
            this.lbl_surname.TabIndex = 0;
            this.lbl_surname.Text = "surname:";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(116, 26);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 19);
            this.txt_name.TabIndex = 1;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(15, 29);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(34, 12);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "name:";
            // 
            // lbl_employees
            // 
            this.lbl_employees.AutoSize = true;
            this.lbl_employees.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_employees.Location = new System.Drawing.Point(464, 13);
            this.lbl_employees.Name = "lbl_employees";
            this.lbl_employees.Size = new System.Drawing.Size(111, 22);
            this.lbl_employees.TabIndex = 1;
            this.lbl_employees.Text = "employees";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NAME,
            this.SURNAME,
            this.PASSPORTNUM,
            this.POSITION,
            this.USERNAME,
            this.PASSWORD,
            this.SALARY
            });
            this.dataGridView1.Location = new System.Drawing.Point(260, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(583, 397);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // NAME
            // 
            this.NAME.HeaderText = "NAME";
            this.NAME.Name = "NAME";
            // 
            // SURNAME
            // 
            this.SURNAME.HeaderText = "SURNAME";
            this.SURNAME.Name = "SURNAME";
            // 
            // PASSPORTNUM
            // 
            this.PASSPORTNUM.HeaderText = "PASSPORTNUM";
            this.PASSPORTNUM.Name = "PASSPORTNUM";
            // 
            // POSITION
            // 
            this.POSITION.HeaderText = "POSITION";
            this.POSITION.Name = "POSITION";
            // 
            // USERNAME
            // 
            this.USERNAME.HeaderText = "USERNAME";
            this.USERNAME.Name = "USERNAME";
            // 
            // PASSWORD
            // 
            this.PASSWORD.HeaderText = "PASSWORD";
            this.PASSWORD.Name = "PASSWORD";
            // 
            // SALARY
            // 
            this.SALARY.HeaderText = "SALARY";
            this.SALARY.Name = "SALARY";

            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_employees);
            this.Controls.Add(this.groupBox_empprocess);
            this.Name = "Manager";
            this.Text = "manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Manager_FormClosed);
            this.Load += new System.EventHandler(this.Manager_Load);
            this.groupBox_empprocess.ResumeLayout(false);
            this.groupBox_empprocess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }



        #endregion

        private System.Windows.Forms.GroupBox groupBox_empprocess;
        private System.Windows.Forms.TextBox txt_position;
        private System.Windows.Forms.Label lbl_position;
        private System.Windows.Forms.TextBox txt_passportnum;
        private System.Windows.Forms.Label lbl_passportnum;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.Label lbl_surname;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_name;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbl_employees;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn SURNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PASSPORTNUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn POSITION;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_uptate;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btnSaveExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn USERNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PASSWORD;
        private System.Windows.Forms.DataGridViewTextBoxColumn SALARY;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}