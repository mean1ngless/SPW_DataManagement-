﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using course_work;

namespace course_work.forms_for_delete
{
    public partial class delete_university : Form
    {
        private SqlDataReader reader;
        DataBase dataBase = new DataBase();
        private int DeleteId;
        public delete_university(int id)
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
                var deleteQuery = "SELECT * FROM University WHERE Id = @SelectedId";
                int selectedId = id;
                var command = new SqlCommand(deleteQuery, dataBase.getConnection());
                command.Parameters.AddWithValue("@SelectedId", selectedId);
                reader = command.ExecuteReader();
                if(reader.Read())
                {
                    label1.Text = $"{reader[1]}";
                    label2.Text = $"{reader[2]}";
                }
                dataBase.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }            
        }

        private void delete_university_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataBase.openConnection();
                var delete = $"DELETE FROM University WHERE Id=@SelectedId";
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
