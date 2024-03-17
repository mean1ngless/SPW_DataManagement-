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
using course_work.forms_for_delete;

namespace course_work
{
    public partial class delete_form : Form
    {
        private SqlDataReader reader;

        DataBase dataBase = new DataBase();
        public delete_form()
        {
            InitializeComponent();
        }

        private void delete_form_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int selected_id = Convert.ToInt32(textBox_selectedId.Text);
                if (comboBox1.SelectedIndex == 0)
                {
                    Form delete_some = new delete_university(selected_id);
                    delete_some.ShowDialog();
                }
                if(comboBox1.SelectedIndex == 1)
                {
                    Form delete_some = new delete_faculty(selected_id);
                    delete_some.ShowDialog();
                }
                if(comboBox1.SelectedIndex == 2)
                {
                    Form delete_some = new delete_department(selected_id);
                    delete_some.ShowDialog();
                }
                if(comboBox1.SelectedIndex == 3)
                {
                    Form delete_some = new delete_spw(selected_id);
                    delete_some.ShowDialog();
                }
                if(comboBox1.SelectedIndex == 4)
                {
                    Form delete_some = new delete_rating(selected_id);
                    delete_some.ShowDialog();
                }
                if(comboBox1.SelectedIndex == 5)
                {
                    Form delete_some = new delete_workindicator(selected_id);
                    delete_some.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Перевірте введені дані", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
