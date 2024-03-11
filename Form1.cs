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

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns.Add("UniversityName", "Назва універитету");
            dataGridView1.Columns.Add("UniversityAddress", "Адреса");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }

        private void readSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"select * from University";
            SqlCommand command= new SqlCommand(queryString, dataBase.getConnection());
            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                readSingleRow(dgw, reader);
            }
            reader.Close();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }
    }
}
