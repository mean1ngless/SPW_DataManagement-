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
            dataGridView_University.Columns.Add("Id", "Id");
            dataGridView_University.Columns.Add("UniversityName", "Назва універитету");
            dataGridView_University.Columns.Add("UniversityAddress", "Адреса");
            dataGridView_University.Columns.Add("IsNew", String.Empty);
        }
        private void CreateColumns_Faculty()
        {
            dataGridView_University.Columns.Add("Id", "Id");
            dataGridView_University.Columns.Add("FacultyName", "Назва факультету");
            dataGridView_University.Columns.Add("UniversityId", "ID університету");
            dataGridView_University.Columns.Add("IsNew", String.Empty);
        }

        private void readSingleRow_University(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), RowState.ModifiedNew);
        }
        private void readSingleRow_Faculty(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), RowState.ModifiedNew);
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
                if(tableSelect.Text == "University")
                {
                    readSingleRow_University(dgw, reader);
                }
                if (tableSelect.Text == "Faculty")
                {
                    readSingleRow_Faculty(dgw, reader);
                }
            }
            reader.Close();
        }


        private void Form1_Load(object sender, EventArgs e)
        {          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView_University.Columns.Clear();
            if (tableSelect.SelectedIndex == 0)
            {
                CreateColumns_University();
            }
            if (tableSelect.SelectedIndex == 1)
            {
                CreateColumns_Faculty();
            }
            string table = tableSelect.Text;
            RefreshDataGrid(dataGridView_University, table);
        }
    }
}
