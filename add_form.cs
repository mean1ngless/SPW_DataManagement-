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
    public partial class add_form : Form
    {
        DataBase database = new DataBase();
        public add_form()
        {
            InitializeComponent();
        }

        private void add_form_Load(object sender, EventArgs e)
        {

        }

        private void ClearTextBoxes()
        {
            label_universityname.Hide();
            textBox_universityName.Clear();
            textBox_universityName.Hide();
            label_universityadress.Hide();
            textBox_universityAddress.Clear();
            textBox_universityAddress.Hide();

            label_facultyname.Hide();
            label_facultyuniversityid.Hide();
            textBox_facultyname.Clear();
            textBox_facultyname.Hide();
            textBox_facultyuniversityid.Clear();
            textBox_facultyuniversityid.Hide();

            label_departname.Hide();
            label_departfacultyid.Hide();
            textBox_departName.Hide();
            textBox_departName.Clear();
            textBox_departFacultyId.Hide();
            textBox_departFacultyId.Clear();

            label_SPWName.Hide();
            label_spwjob.Hide();
            label_spwdepartid.Hide();
            textBox_SPWName.Clear();
            textBox_SPWName.Hide();
            textBox_SPWJob.Clear();
            textBox_SPWJob.Hide();
            textBox_spwdepartid.Clear();
            textBox_spwdepartid.Hide();

            label_ratingspwid.Hide();
            label_ratingyear.Hide();
            label_ratingworkid.Hide();
            label_ratingquantity.Hide();
            label_ratingdescr.Hide();
            textBox_ratingspwid.Hide();
            textBox_ratingquantity.Hide();
            textBox_ratingworkid.Hide();
            textBox_ratingyear.Hide();
            textBox_ratingdescr.Hide();
            textBox_ratingspwid.Clear();
            textBox_ratingquantity.Clear();
            textBox_ratingworkid.Clear();
            textBox_ratingyear.Clear();
            textBox_ratingdescr.Clear();

            label_workname.Hide();
            label_workscore.Hide();
            textBox_workname.Hide();
            textBox_workscore.Hide();
            textBox_workname.Clear();
            textBox_workscore.Clear();

        }

        private void radio_Faculty_CheckedChanged(object sender, EventArgs e)
        {
            ClearTextBoxes();
            label_facultyname.Show();
            textBox_facultyname.Show();
            label_facultyuniversityid.Show();
            textBox_facultyuniversityid.Show();
        }

        private void radio_University_CheckedChanged(object sender, EventArgs e)
        {
            ClearTextBoxes();
            label_universityname.Show();
            textBox_universityName.Show();
            label_universityadress.Show();
            textBox_universityAddress.Show();
        }

        private void radio_Department_CheckedChanged(object sender, EventArgs e)
        {
            ClearTextBoxes();
            label_departname.Show();
            textBox_departName.Show();
            label_departfacultyid.Show();
            textBox_departFacultyId.Show();

        }

        private void radio_SPW_CheckedChanged(object sender, EventArgs e)
        {
            ClearTextBoxes();
            label_SPWName.Show();
            label_spwdepartid.Show();
            label_spwjob.Show();
            textBox_SPWName.Show();
            textBox_SPWJob.Show();
            textBox_spwdepartid.Show();
        }

        private void radio_Rating_CheckedChanged(object sender, EventArgs e)
        {
            ClearTextBoxes();
            label_ratingspwid.Show();
            label_ratingyear.Show();
            label_ratingworkid.Show();
            label_ratingquantity.Show();
            label_ratingdescr.Show();
            textBox_ratingspwid.Show();
            textBox_ratingquantity.Show();
            textBox_ratingworkid.Show();
            textBox_ratingyear.Show();
            textBox_ratingdescr.Show();

        }

        private void radio_WorkIndicator_CheckedChanged(object sender, EventArgs e)
        {
            ClearTextBoxes();
            label_workname.Show();
            label_workscore.Show();
            textBox_workname.Show();
            textBox_workscore.Show();
        }

        private void button_closeform_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (radio_University.Checked)
            {
                var universityName = textBox_universityName.Text;
                var universityAddress = textBox_universityAddress.Text;

                var addQuery = $"insert into University (UniversityName, UniversityAddress) values ({universityName},{universityAddress})";
                var command = new SqlCommand(addQuery, database.getConnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Запис успішно створено.","", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
