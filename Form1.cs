using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course_work
{
    public partial class Form1 : Form
    {
        enum RowState
        {
            Existed, 
            New,
            Modified,
            ModifiedNew,
            Deleted
        }

        DataBase dataBase = new DataBase();

        public Form1()
        {
            InitializeComponent();
        }

        private void CreateColumns_University()
        {
            dataGridView_top.Columns.Add("Id", "Id");
            dataGridView_top.Columns.Add("UniversityName", "Назва універитету");
            dataGridView_top.Columns.Add("UniversityAddress", "Адреса");
            dataGridView_top.Columns.Add("IsNew", String.Empty);
            dataGridView_top.Columns[0].Width = 27;
            dataGridView_top.Columns[1].Width = 310;
            dataGridView_top.Columns[2].Width = 200;
            dataGridView_top.Columns[3].Width = 75;
        }
        private void CreateColumns_Faculty()
        {
            dataGridView_top.Columns.Add("Id", "Id");
            dataGridView_top.Columns.Add("FacultyName", "Назва факультету");
            dataGridView_top.Columns.Add("UniversityId", "ID університету");
            dataGridView_top.Columns.Add("IsNew", String.Empty);
            dataGridView_top.Columns[0].Width = 27;
            dataGridView_top.Columns[1].Width = 413;
            dataGridView_top.Columns[2].Width = 80;
            dataGridView_top.Columns[3].Width = 75;
        }
        private void CreateColumns_Department()
        {
            dataGridView_top.Columns.Add("Id", "Id");
            dataGridView_top.Columns.Add("DepartmentName", "Назва кафедри");
            dataGridView_top.Columns.Add("FacultyId", "ID факультету");
            dataGridView_top.Columns.Add("IsNew", String.Empty);
            dataGridView_top.Columns[0].Width = 37;
            dataGridView_top.Columns[1].Width = 413;
            dataGridView_top.Columns[2].Width = 70;
            dataGridView_top.Columns[3].Width = 75;
        }
        private void CreateColumns_SPW()
        {
            dataGridView_top.Columns.Add("Id", "Id");
            dataGridView_top.Columns.Add("FullName", "ПІБ НПП");
            dataGridView_top.Columns.Add("JobTitle", "Посада");
            dataGridView_top.Columns.Add("DepartmentId", "ID кафедри");
            dataGridView_top.Columns.Add("IsNew", String.Empty);
            dataGridView_top.Columns[0].Width = 27;
            dataGridView_top.Columns[1].Width = 213;
            dataGridView_top.Columns[2].Width = 200;
            dataGridView_top.Columns[3].Width = 80;
            dataGridView_top.Columns[4].Width = 75;
        }
        private void CreateColumns_Rating()
        {
            dataGridView_top.Columns.Add("Id", "Id");
            dataGridView_top.Columns.Add("SPW_Id", "ID НПП");
            dataGridView_top.Columns.Add("RatingYear", "Дата рейтингу");
            dataGridView_top.Columns.Add("WorkIndicator_Id", "ID пкз. роботи");
            dataGridView_top.Columns.Add("Quantity", "Кількість");
            dataGridView_top.Columns.Add("AchievementsDescription", "Опис наукових досягнень");
            dataGridView_top.Columns.Add("IsNew", String.Empty);
            dataGridView_top.Columns[0].Width = 30;
            dataGridView_top.Columns[1].Width = 45;
            dataGridView_top.Columns[2].Width = 115;
            dataGridView_top.Columns[3].Width = 45;
            dataGridView_top.Columns[4].Width = 60;
            dataGridView_top.Columns[5].Width = 225;
            dataGridView_top.Columns[6].Width = 75;
        }
        private void CreateColumns_WorkIndicator()
        {
            dataGridView_top.Columns.Add("Id", "Id");
            dataGridView_top.Columns.Add("WorkName", "Вид роботи");
            dataGridView_top.Columns.Add("Score", "Кількість балів");
            dataGridView_top.Columns.Add("IsNew", String.Empty);
            dataGridView_top.Columns[0].Width = 37;
            dataGridView_top.Columns[1].Width = 413;
            dataGridView_top.Columns[2].Width = 70;
            dataGridView_top.Columns[3].Width = 75;
        }
        private void readSingleRow_University(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), RowState.ModifiedNew);
        }
        private void readSingleRow_Faculty(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), RowState.ModifiedNew);
        }
        private void readSingleRow_Department(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), RowState.ModifiedNew);
        }
        private void readSingleRow_SPW(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetInt32(3), RowState.ModifiedNew);
        }
        private void readSingleRow_Rating(DataGridView dgw, IDataRecord record)
        {
            int id = record.GetInt32(0);
            int spwId = record.GetInt32(1);
            DateTime ratingYear = record.GetDateTime(2);
            int workIndicatorId = record.GetInt32(3);
            double quantity = record.GetDouble(4);
            string achievementsDescription = record.IsDBNull(5) ? null : record.GetString(5);

            dgw.Rows.Add(id, spwId, ratingYear, workIndicatorId, quantity, achievementsDescription, RowState.ModifiedNew);
        }
        private void readSingleRow_WorkIndicator(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetDouble(2), RowState.ModifiedNew);
        }
        private void RefreshDataGrid(DataGridView dgw, string tableSelected)
        {
            dgw.Rows.Clear();
            string queryString = $"select * from {tableSelected}";
            SqlCommand command= new SqlCommand(queryString, dataBase.getConnection());
            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if(tableSelect.SelectedIndex == 0)
                {
                    readSingleRow_University(dgw, reader);
                }
                if (tableSelect.SelectedIndex == 1)
                {
                    readSingleRow_Faculty(dgw, reader);
                }
                if (tableSelect.SelectedIndex == 2)
                {
                    readSingleRow_Department(dgw, reader);
                }
                if (tableSelect.SelectedIndex == 3)
                {
                    readSingleRow_SPW(dgw, reader);
                }
                if (tableSelect.SelectedIndex == 4)
                {
                    readSingleRow_Rating(dgw, reader);
                }
                if (tableSelect.SelectedIndex == 5)
                {
                    readSingleRow_WorkIndicator(dgw, reader);
                }
            }
            reader.Close();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView_top.Columns.Clear();
            if (tableSelect.SelectedIndex == 0)
            {
                CreateColumns_University();
            }
            if (tableSelect.SelectedIndex == 1)
            {
                CreateColumns_Faculty();
            }
            if (tableSelect.SelectedIndex == 2)
            {
                CreateColumns_Department();
            }
            if (tableSelect.SelectedIndex == 3)
            {
                CreateColumns_SPW();
            }
            if (tableSelect.SelectedIndex == 4)
            {
                CreateColumns_Rating();
            }
            if (tableSelect.SelectedIndex == 5)
            {
                CreateColumns_WorkIndicator();
            }
            string table = tableSelect.Text;
            RefreshDataGrid(dataGridView_top, table);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form about_me = new about_meForm();
            about_me.ShowDialog();
        }

        private void button_addnew_Click(object sender, EventArgs e)
        {
            Form add_new = new add_form();
            add_new.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string table = tableSelect.Text;
            RefreshDataGrid(dataGridView_top, table);
        }
    }
}
