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

namespace course_work.forms_for_delete
{
    public partial class delete_department : Form
    {
        private SqlDataReader reader;
        DataBase dataBase = new DataBase();
        private int DeleteId;
        public delete_department(int id)
        {
            InitializeComponent();
            loadData(id);
            this.DeleteId = id;
        }
        private void loadData(int id)
        {
            try
            {
                dataBase.openConnection();
                var deleteQuery = "SELECT * FROM Department WHERE Id = @SelectedId";
                int selectedId = id;
                var command = new SqlCommand(deleteQuery, dataBase.getConnection());
                command.Parameters.AddWithValue("@SelectedId", selectedId);
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    label_departmentname.Text = $"{reader[1]}";
                    label_departmentfucltyid.Text = $"{reader[2]}";
                }
                dataBase.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void delete_department_Load(object sender, EventArgs e)
        {

        }

        private void button_step_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                dataBase.openConnection();
                var delete = $"DELETE FROM Department WHERE Id=@SelectedId";
                var command = new SqlCommand(delete, dataBase.getConnection());
                command.Parameters.AddWithValue("@SelectedId", DeleteId);
                reader = command.ExecuteReader();
                dataBase.closeConnection();
                MessageBox.Show("Запис успішно видалено.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
        }
    }
}
