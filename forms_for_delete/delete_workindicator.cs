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
    public partial class delete_workindicator : Form
    {
        private SqlDataReader reader;
        DataBase dataBase = new DataBase();
        private int DeleteId;
        public delete_workindicator(int id)
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
                var deleteQuery = "SELECT * FROM WorkIndicator WHERE Id = @SelectedId";
                int selectedId = id;
                var command = new SqlCommand(deleteQuery, dataBase.getConnection());
                command.Parameters.AddWithValue("@SelectedId", selectedId);
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    label_workname.Text = $"{reader[1]}";
                    label_score.Text = $"{reader[2]}";
                }
                dataBase.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
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
                var delete = $"DELETE FROM WorkIndicator WHERE Id=@SelectedId";
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
