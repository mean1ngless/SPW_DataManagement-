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
            int selected_id = Convert.ToInt32(textBox_selectedId.Text);
            Form delete_some = new delete_university(selected_id);
            delete_some.ShowDialog();
        }
    }
}
