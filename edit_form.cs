using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace course_work
{
    public partial class edit_form : Form
    {
        DataBase dataBase = new DataBase();
        private SqlDataReader reader;
        public edit_form()
        {
            InitializeComponent();
            clearBox();
        }
        private void clearBox()
        {
            label_universityname.Hide();
            label_universityaddress.Hide();
            textBox_universityname.Clear();
            textBox_universityaddress.Clear();
            textBox_universityname.Hide();
            textBox_universityaddress.Hide();

            label_facultyname.Hide();
            label_facultyunid.Hide();
            textBox_facultyname.Clear();
            textBox_facultyname.Hide();
            textBox_facultyunid.Clear();
            textBox_facultyunid.Hide();

            label_departmentname.Hide();
            label_departmentfacultyid.Hide();
            textBox_departmentname.Clear();
            textBox_departmentfacultyid.Clear();
            textBox_departmentname.Hide();
            textBox_departmentfacultyid.Hide();

            label_spwfullname.Hide();
            label_spwjob.Hide();
            label_spwdepartmentid.Hide();
            textBox_spwfullname.Clear();
            textBox_spwfullname.Hide();
            textBox_spwjob.Clear();
            textBox_spwjob.Hide();
            textBox_spwdepartmentid.Clear();
            textBox_spwdepartmentid.Hide();

            label_ratindworkid.Hide();
            label_ratingdate.Hide();
            label_ratingspwid.Hide();
            label_ratingquantity.Hide();
            label_ratingdescription.Hide();
            textBox_ratingdate.Hide();
            textBox_ratindworkid.Hide();
            textBox_ratingdescription.Hide();
            textBox_ratingspwid.Hide();
            textBox_ratingquantity.Hide();
            textBox_ratingdate.Clear();
            textBox_ratindworkid.Clear();
            textBox_ratingdescription.Clear();
            textBox_ratingspwid.Clear();
            textBox_ratingquantity.Clear();

            label_workname.Hide();
            label_workscore.Hide();
            textBox_workname.Hide();
            textBox_workscore.Hide();
            textBox_workname.Clear();
            textBox_workscore.Clear();
        }

        private void radio_university_CheckedChanged(object sender, EventArgs e)
        {
            clearBox();
            label_universityname.Show();
            label_universityaddress.Show();
            textBox_universityname.Show();
            textBox_universityaddress.Show();
            FillComboBox("University");
        }

        private void radio_faculty_CheckedChanged(object sender, EventArgs e)
        {
            clearBox();
            label_facultyname.Show();
            label_facultyunid.Show();
            textBox_facultyname.Show();
            textBox_facultyunid.Show();
            FillComboBox("Faculty");
        }

        private void radio_department_CheckedChanged(object sender, EventArgs e)
        {
            clearBox();
            label_departmentname.Show();
            label_departmentfacultyid.Show();
            textBox_departmentname.Show();
            textBox_departmentfacultyid.Show();
            FillComboBox("Department");
        }

        private void radio_spw_CheckedChanged(object sender, EventArgs e)
        {
            clearBox();
            label_spwfullname.Show();
            label_spwjob.Show();
            label_spwdepartmentid.Show();
            textBox_spwfullname.Show();
            textBox_spwjob.Show();
            textBox_spwdepartmentid.Show();
            FillComboBox("SPW");
        }

        private void radio_rating_CheckedChanged(object sender, EventArgs e)
        {
            clearBox();
            label_ratindworkid.Show();
            label_ratingdate.Show();
            label_ratingspwid.Show();
            label_ratingquantity.Show();
            label_ratingdescription.Show();
            textBox_ratingdate.Show();
            textBox_ratindworkid.Show();
            textBox_ratingdescription.Show();
            textBox_ratingspwid.Show();
            textBox_ratingquantity.Show();
            FillComboBox("Rating");
        }

        private void radio_workindicator_CheckedChanged(object sender, EventArgs e)
        {
            clearBox();
            label_workname.Show();
            label_workscore.Show();
            textBox_workname.Show();
            textBox_workscore.Show();
            FillComboBox("WorkIndicator");
        }

        private void edit_form_Load(object sender, EventArgs e)
        {
           
        }
        private void FillComboBox(string table)
        {
            dataBase.openConnection();
            List<int> ids = new List<int>();

            SqlCommand command = new SqlCommand($"SELECT Id FROM {table}", dataBase.getConnection());
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                ids.Add(id);
            }

            reader.Close();

            comboBox1.DataSource = ids;
            dataBase.closeConnection();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(radio_university.Checked)
            {
                FillUniversity();
            }
            if (radio_faculty.Checked)
            {
                FillFaculty();
            }
            if(radio_department.Checked)
            {
                FillDepartment();
            }
            if(radio_spw.Checked) 
            {
                FillSpw();
            }
            if(radio_rating.Checked)
            {
                FillRating();
            }
            if (radio_workindicator.Checked)
            {
                FillWorkIndicator();
            }
        }
        private void FillUniversity()
        {
            int selected_id = int.Parse(comboBox1.Text);
            dataBase.openConnection();
            var query = $"SELECT * FROM University WHERE Id = {selected_id}";
            var command = new SqlCommand(query, dataBase.getConnection());
            command.Parameters.AddWithValue("@SelectedId", selected_id);
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                textBox_universityname.Text = $"{reader[1]}";
                textBox_universityaddress.Text = $"{reader[2]}";
            }
            dataBase.closeConnection();
        }
        private void FillFaculty()
        {
            int selected_id = int.Parse(comboBox1.Text);
            dataBase.openConnection();
            var query = $"SELECT * FROM Faculty WHERE Id = {selected_id}";
            var command = new SqlCommand(query, dataBase.getConnection());
            command.Parameters.AddWithValue("@SelectedId", selected_id);
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                textBox_facultyname.Text = $"{reader[1]}";
                textBox_facultyunid.Text = $"{reader[2]}";
            }
            dataBase.closeConnection();
        }
        private void FillDepartment()
        {
            int selected_id = int.Parse(comboBox1.Text);
            dataBase.openConnection();
            var query = $"SELECT * FROM Department WHERE Id = {selected_id}";
            var command = new SqlCommand(query, dataBase.getConnection());
            command.Parameters.AddWithValue("@SelectedId", selected_id);
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                textBox_departmentname.Text = $"{reader[1]}";
                textBox_departmentfacultyid.Text = $"{reader[2]}";
            }
            dataBase.closeConnection();
        }
        private void FillSpw()
        {
            int selected_id = int.Parse(comboBox1.Text);
            dataBase.openConnection();
            var query = $"SELECT * FROM SPW WHERE Id = {selected_id}";
            var command = new SqlCommand(query, dataBase.getConnection());
            command.Parameters.AddWithValue("@SelectedId", selected_id);
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                textBox_spwfullname.Text = $"{reader[1]}";
                textBox_spwjob.Text = $"{reader[2]}";
                textBox_spwdepartmentid.Text = $"{reader[3]}";
            }
            dataBase.closeConnection();
        }
        private void FillRating()
        {
            int selected_id = int.Parse(comboBox1.Text);
            dataBase.openConnection();
            var query = $"SELECT * FROM Rating WHERE Id = {selected_id}";
            var command = new SqlCommand(query, dataBase.getConnection());
            command.Parameters.AddWithValue("@SelectedId", selected_id);
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                textBox_ratingspwid.Text = $"{reader[1]}";
                textBox_ratingdate.Text = $"{reader[2]}";
                textBox_ratindworkid.Text = $"{reader[3]}";
                textBox_ratingquantity.Text = $"{reader[4]}";
                textBox_ratingdescription.Text = $"{reader[5]}";
            }
            dataBase.closeConnection();
        }
        private void FillWorkIndicator()
        {
            int selected_id = int.Parse(comboBox1.Text);
            dataBase.openConnection();
            var query = $"SELECT * FROM WorkIndicator WHERE Id = {selected_id}";
            var command = new SqlCommand(query, dataBase.getConnection());
            command.Parameters.AddWithValue("@SelectedId", selected_id);
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                textBox_workname.Text = $"{reader[1]}";
                textBox_workscore.Text = $"{reader[2]}";
            }
            dataBase.closeConnection();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (radio_university.Checked)
                {
                    dataBase.openConnection();
                    var university_name = textBox_universityname.Text;
                    var university_address = textBox_universityaddress.Text;

                    var query = "UPDATE University SET UniversityName = @UniversityName, UniversityAddress = @UniversityAddress WHERE Id = @Id";
                    var command = new SqlCommand(query, dataBase.getConnection());
                    command.Parameters.AddWithValue("@UniversityName", university_name);
                    command.Parameters.AddWithValue("@UniversityAddress", university_address);
                    command.Parameters.AddWithValue("@Id", int.Parse(comboBox1.Text));

                    command.ExecuteNonQuery();
                    dataBase.closeConnection();
                    MessageBox.Show("Запис успішно відредаговано.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if(radio_faculty.Checked)
                {
                    dataBase.openConnection();
                    var faculty_name = textBox_facultyname.Text;
                    int faculty_university_id;
                    if (int.TryParse(textBox_facultyunid.Text, out faculty_university_id))
                    {
                        var query = "UPDATE Faculty SET FacultyName = @FacultyName, UniversityId = @FacultyUnId WHERE Id = @Id";
                        var command = new SqlCommand(query, dataBase.getConnection());
                        command.Parameters.AddWithValue("@FacultyName", faculty_name);
                        command.Parameters.AddWithValue("@FacultyUnId", faculty_university_id);
                        command.Parameters.AddWithValue("@Id", int.Parse(comboBox1.Text));

                        command.ExecuteNonQuery();
                        dataBase.closeConnection();
                        MessageBox.Show("Запис успішно відредаговано.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Виникла помилка, перевірте введені дані.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if(radio_department.Checked)
                {
                    dataBase.openConnection();
                    var department_name = textBox_departmentname.Text;
                    int department_facultyId;
                    if (int.TryParse(textBox_departmentfacultyid.Text, out department_facultyId))
                    {

                        var query = "UPDATE Department SET DepartmentName = @DepartmentName, FacultyId = @FacultyID WHERE Id = @Id";
                        var command = new SqlCommand(query, dataBase.getConnection());

                        command.Parameters.AddWithValue("@DepartmentName", department_name);
                        command.Parameters.AddWithValue("@FacultyId", department_facultyId);
                        command.Parameters.AddWithValue("@Id", int.Parse(comboBox1.Text));

                        command.ExecuteNonQuery();
                        dataBase.closeConnection();
                        MessageBox.Show("Запис успішно відредаговано.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Виникла помилка, перевірте введені дані.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if(radio_spw.Checked)
                {
                    dataBase.openConnection();
                    var fullname = textBox_spwfullname.Text;
                    var jobtitle = textBox_spwjob.Text;
                    int departmentid;
                    if(int.TryParse(textBox_spwdepartmentid.Text, out departmentid))
                    {
                        var query = "UPDATE SPW SET FullName = @FullName, JobTitle = @JobTitle, DepartmentId = @DepartmentId WHERE Id = @Id";
                        var command = new SqlCommand(query, dataBase.getConnection());

                        command.Parameters.AddWithValue("@FullName", fullname);
                        command.Parameters.AddWithValue("@JobTitle", jobtitle);
                        command.Parameters.AddWithValue("@DepartmentId", departmentid);
                        command.Parameters.AddWithValue("@Id", int.Parse(comboBox1.Text));

                        command.ExecuteNonQuery();
                        dataBase.closeConnection();
                        MessageBox.Show("Запис успішно відредаговано.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Виникла помилка, перевірте введені дані.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if(radio_rating.Checked)
                {
                    dataBase.openConnection();
                    int SPW_Id;
                    string Rating = textBox_ratingdate.Text;
                    DateTime RatingDate;
                    int workIndicatorId;
                    double Quantity;
                    var Description = textBox_ratingdescription.Text;

                    if (int.TryParse(textBox_ratingspwid.Text, out SPW_Id))
                    {
                        if (DateTime.TryParse(Rating, out RatingDate))
                        {
                            if (int.TryParse(textBox_ratindworkid.Text, out workIndicatorId))
                            {
                                if (double.TryParse(textBox_ratingquantity.Text, out Quantity))
                                {
                                    var Query = "UPDATE Rating SET SPW_Id = @SPW_Id, RatingYear = @RatingYear, WorkIndicator_Id = @WorkId, Quantity = @Quantity, AchievementsDescription = @Description WHERE Id = @Id";
                                    var command = new SqlCommand(Query, dataBase.getConnection());

                                    command.Parameters.AddWithValue("@SPW_Id", SPW_Id);
                                    command.Parameters.AddWithValue("@RatingYear", RatingDate);
                                    command.Parameters.AddWithValue("@WorkId", workIndicatorId);
                                    command.Parameters.AddWithValue("@Quantity", Quantity);
                                    command.Parameters.AddWithValue("@Description", Description);
                                    command.Parameters.AddWithValue("@Id", int.Parse(comboBox1.Text));
                                    command.ExecuteNonQuery();
                                    dataBase.closeConnection();
                                    MessageBox.Show("Запис успішно відредаговано.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Виникла помилка, перевірте введені дані.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                }
                if(radio_workindicator.Checked)
                {
                    dataBase.openConnection();
                    var WorkName = textBox_workname.Text;
                    double Score;
                    if (double.TryParse(textBox_workscore.Text, out Score))
                    {
                        var addQuery = "UPDATE WorkIndicator SET WorkName = @WorkName, Score = @Score Where Id = @Id";

                        var command = new SqlCommand(addQuery, dataBase.getConnection());
                        command.Parameters.AddWithValue("@WorkName", WorkName);
                        command.Parameters.AddWithValue("@Score", Score);
                        command.Parameters.AddWithValue("Id", int.Parse(comboBox1.Text));

                        command.ExecuteNonQuery();
                        dataBase.closeConnection();
                        MessageBox.Show("Запис успішно відредаговано.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Виникла помилка, перевірте введені дані.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_step_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
