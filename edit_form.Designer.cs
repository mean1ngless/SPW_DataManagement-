namespace course_work
{
    partial class edit_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(edit_form));
            this.label1 = new System.Windows.Forms.Label();
            this.radio_university = new System.Windows.Forms.RadioButton();
            this.radio_faculty = new System.Windows.Forms.RadioButton();
            this.radio_department = new System.Windows.Forms.RadioButton();
            this.radio_spw = new System.Windows.Forms.RadioButton();
            this.radio_rating = new System.Windows.Forms.RadioButton();
            this.radio_workindicator = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label_universityname = new System.Windows.Forms.Label();
            this.textBox_universityname = new System.Windows.Forms.TextBox();
            this.label_universityaddress = new System.Windows.Forms.Label();
            this.textBox_universityaddress = new System.Windows.Forms.TextBox();
            this.label_facultyname = new System.Windows.Forms.Label();
            this.textBox_facultyname = new System.Windows.Forms.TextBox();
            this.label_facultyunid = new System.Windows.Forms.Label();
            this.textBox_facultyunid = new System.Windows.Forms.TextBox();
            this.label_departmentname = new System.Windows.Forms.Label();
            this.label_departmentfacultyid = new System.Windows.Forms.Label();
            this.textBox_departmentname = new System.Windows.Forms.TextBox();
            this.textBox_departmentfacultyid = new System.Windows.Forms.TextBox();
            this.label_spwfullname = new System.Windows.Forms.Label();
            this.label_spwjob = new System.Windows.Forms.Label();
            this.label_spwdepartmentid = new System.Windows.Forms.Label();
            this.textBox_spwfullname = new System.Windows.Forms.TextBox();
            this.textBox_spwjob = new System.Windows.Forms.TextBox();
            this.textBox_spwdepartmentid = new System.Windows.Forms.TextBox();
            this.label_ratingspwid = new System.Windows.Forms.Label();
            this.label_ratingdate = new System.Windows.Forms.Label();
            this.label_ratindworkid = new System.Windows.Forms.Label();
            this.label_ratingquantity = new System.Windows.Forms.Label();
            this.label_ratingdescription = new System.Windows.Forms.Label();
            this.textBox_ratingspwid = new System.Windows.Forms.TextBox();
            this.textBox_ratingdate = new System.Windows.Forms.TextBox();
            this.textBox_ratindworkid = new System.Windows.Forms.TextBox();
            this.textBox_ratingquantity = new System.Windows.Forms.TextBox();
            this.textBox_ratingdescription = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_workname = new System.Windows.Forms.Label();
            this.label_workscore = new System.Windows.Forms.Label();
            this.textBox_workname = new System.Windows.Forms.TextBox();
            this.textBox_workscore = new System.Windows.Forms.TextBox();
            this.button_step = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Оберіть довідник для редагування:";
            // 
            // radio_university
            // 
            this.radio_university.AutoSize = true;
            this.radio_university.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radio_university.Location = new System.Drawing.Point(18, 45);
            this.radio_university.Name = "radio_university";
            this.radio_university.Size = new System.Drawing.Size(136, 25);
            this.radio_university.TabIndex = 1;
            this.radio_university.TabStop = true;
            this.radio_university.Text = "Університети";
            this.radio_university.UseVisualStyleBackColor = true;
            this.radio_university.CheckedChanged += new System.EventHandler(this.radio_university_CheckedChanged);
            // 
            // radio_faculty
            // 
            this.radio_faculty.AutoSize = true;
            this.radio_faculty.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radio_faculty.Location = new System.Drawing.Point(160, 45);
            this.radio_faculty.Name = "radio_faculty";
            this.radio_faculty.Size = new System.Drawing.Size(118, 25);
            this.radio_faculty.TabIndex = 2;
            this.radio_faculty.TabStop = true;
            this.radio_faculty.Text = "Факультети";
            this.radio_faculty.UseVisualStyleBackColor = true;
            this.radio_faculty.CheckedChanged += new System.EventHandler(this.radio_faculty_CheckedChanged);
            // 
            // radio_department
            // 
            this.radio_department.AutoSize = true;
            this.radio_department.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radio_department.Location = new System.Drawing.Point(284, 45);
            this.radio_department.Name = "radio_department";
            this.radio_department.Size = new System.Drawing.Size(91, 25);
            this.radio_department.TabIndex = 3;
            this.radio_department.TabStop = true;
            this.radio_department.Text = "Кафедри";
            this.radio_department.UseVisualStyleBackColor = true;
            this.radio_department.CheckedChanged += new System.EventHandler(this.radio_department_CheckedChanged);
            // 
            // radio_spw
            // 
            this.radio_spw.AutoSize = true;
            this.radio_spw.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radio_spw.Location = new System.Drawing.Point(381, 45);
            this.radio_spw.Name = "radio_spw";
            this.radio_spw.Size = new System.Drawing.Size(55, 25);
            this.radio_spw.TabIndex = 4;
            this.radio_spw.TabStop = true;
            this.radio_spw.Text = "НПП";
            this.radio_spw.UseVisualStyleBackColor = true;
            this.radio_spw.CheckedChanged += new System.EventHandler(this.radio_spw_CheckedChanged);
            // 
            // radio_rating
            // 
            this.radio_rating.AutoSize = true;
            this.radio_rating.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radio_rating.Location = new System.Drawing.Point(442, 45);
            this.radio_rating.Name = "radio_rating";
            this.radio_rating.Size = new System.Drawing.Size(100, 25);
            this.radio_rating.TabIndex = 5;
            this.radio_rating.TabStop = true;
            this.radio_rating.Text = "Рейтинги";
            this.radio_rating.UseVisualStyleBackColor = true;
            this.radio_rating.CheckedChanged += new System.EventHandler(this.radio_rating_CheckedChanged);
            // 
            // radio_workindicator
            // 
            this.radio_workindicator.AutoSize = true;
            this.radio_workindicator.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radio_workindicator.Location = new System.Drawing.Point(548, 45);
            this.radio_workindicator.Name = "radio_workindicator";
            this.radio_workindicator.Size = new System.Drawing.Size(163, 25);
            this.radio_workindicator.TabIndex = 6;
            this.radio_workindicator.TabStop = true;
            this.radio_workindicator.Text = "Показники робіт";
            this.radio_workindicator.UseVisualStyleBackColor = true;
            this.radio_workindicator.CheckedChanged += new System.EventHandler(this.radio_workindicator_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Вкажіть номер запису:";
            // 
            // label_universityname
            // 
            this.label_universityname.AutoSize = true;
            this.label_universityname.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_universityname.Location = new System.Drawing.Point(13, 161);
            this.label_universityname.Name = "label_universityname";
            this.label_universityname.Size = new System.Drawing.Size(221, 25);
            this.label_universityname.TabIndex = 8;
            this.label_universityname.Text = "Назва університету:";
            // 
            // textBox_universityname
            // 
            this.textBox_universityname.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_universityname.Location = new System.Drawing.Point(240, 158);
            this.textBox_universityname.Name = "textBox_universityname";
            this.textBox_universityname.Size = new System.Drawing.Size(837, 30);
            this.textBox_universityname.TabIndex = 10;
            // 
            // label_universityaddress
            // 
            this.label_universityaddress.AutoSize = true;
            this.label_universityaddress.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_universityaddress.Location = new System.Drawing.Point(13, 194);
            this.label_universityaddress.Name = "label_universityaddress";
            this.label_universityaddress.Size = new System.Drawing.Size(232, 25);
            this.label_universityaddress.TabIndex = 11;
            this.label_universityaddress.Text = "Адреса університету:";
            // 
            // textBox_universityaddress
            // 
            this.textBox_universityaddress.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_universityaddress.Location = new System.Drawing.Point(240, 191);
            this.textBox_universityaddress.Name = "textBox_universityaddress";
            this.textBox_universityaddress.Size = new System.Drawing.Size(837, 30);
            this.textBox_universityaddress.TabIndex = 12;
            // 
            // label_facultyname
            // 
            this.label_facultyname.AutoSize = true;
            this.label_facultyname.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_facultyname.Location = new System.Drawing.Point(13, 161);
            this.label_facultyname.Name = "label_facultyname";
            this.label_facultyname.Size = new System.Drawing.Size(199, 25);
            this.label_facultyname.TabIndex = 13;
            this.label_facultyname.Text = "Назва факультету:";
            // 
            // textBox_facultyname
            // 
            this.textBox_facultyname.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_facultyname.Location = new System.Drawing.Point(240, 158);
            this.textBox_facultyname.Name = "textBox_facultyname";
            this.textBox_facultyname.Size = new System.Drawing.Size(837, 30);
            this.textBox_facultyname.TabIndex = 14;
            // 
            // label_facultyunid
            // 
            this.label_facultyunid.AutoSize = true;
            this.label_facultyunid.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_facultyunid.Location = new System.Drawing.Point(13, 194);
            this.label_facultyunid.Name = "label_facultyunid";
            this.label_facultyunid.Size = new System.Drawing.Size(177, 25);
            this.label_facultyunid.TabIndex = 15;
            this.label_facultyunid.Text = "ID університету";
            // 
            // textBox_facultyunid
            // 
            this.textBox_facultyunid.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_facultyunid.Location = new System.Drawing.Point(240, 191);
            this.textBox_facultyunid.Name = "textBox_facultyunid";
            this.textBox_facultyunid.Size = new System.Drawing.Size(837, 30);
            this.textBox_facultyunid.TabIndex = 16;
            // 
            // label_departmentname
            // 
            this.label_departmentname.AutoSize = true;
            this.label_departmentname.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_departmentname.Location = new System.Drawing.Point(13, 161);
            this.label_departmentname.Name = "label_departmentname";
            this.label_departmentname.Size = new System.Drawing.Size(166, 25);
            this.label_departmentname.TabIndex = 17;
            this.label_departmentname.Text = "Назва кафедри:";
            // 
            // label_departmentfacultyid
            // 
            this.label_departmentfacultyid.AutoSize = true;
            this.label_departmentfacultyid.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_departmentfacultyid.Location = new System.Drawing.Point(13, 194);
            this.label_departmentfacultyid.Name = "label_departmentfacultyid";
            this.label_departmentfacultyid.Size = new System.Drawing.Size(166, 25);
            this.label_departmentfacultyid.TabIndex = 18;
            this.label_departmentfacultyid.Text = "ID факультету:";
            // 
            // textBox_departmentname
            // 
            this.textBox_departmentname.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_departmentname.Location = new System.Drawing.Point(240, 158);
            this.textBox_departmentname.Name = "textBox_departmentname";
            this.textBox_departmentname.Size = new System.Drawing.Size(837, 30);
            this.textBox_departmentname.TabIndex = 19;
            // 
            // textBox_departmentfacultyid
            // 
            this.textBox_departmentfacultyid.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_departmentfacultyid.Location = new System.Drawing.Point(240, 191);
            this.textBox_departmentfacultyid.Name = "textBox_departmentfacultyid";
            this.textBox_departmentfacultyid.Size = new System.Drawing.Size(837, 30);
            this.textBox_departmentfacultyid.TabIndex = 20;
            // 
            // label_spwfullname
            // 
            this.label_spwfullname.AutoSize = true;
            this.label_spwfullname.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_spwfullname.Location = new System.Drawing.Point(13, 161);
            this.label_spwfullname.Name = "label_spwfullname";
            this.label_spwfullname.Size = new System.Drawing.Size(56, 25);
            this.label_spwfullname.TabIndex = 21;
            this.label_spwfullname.Text = "ПІБ:";
            // 
            // label_spwjob
            // 
            this.label_spwjob.AutoSize = true;
            this.label_spwjob.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_spwjob.Location = new System.Drawing.Point(13, 194);
            this.label_spwjob.Name = "label_spwjob";
            this.label_spwjob.Size = new System.Drawing.Size(89, 25);
            this.label_spwjob.TabIndex = 22;
            this.label_spwjob.Text = "Посада:";
            // 
            // label_spwdepartmentid
            // 
            this.label_spwdepartmentid.AutoSize = true;
            this.label_spwdepartmentid.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_spwdepartmentid.Location = new System.Drawing.Point(13, 227);
            this.label_spwdepartmentid.Name = "label_spwdepartmentid";
            this.label_spwdepartmentid.Size = new System.Drawing.Size(133, 25);
            this.label_spwdepartmentid.TabIndex = 0;
            this.label_spwdepartmentid.Text = "ID кафедри:";
            // 
            // textBox_spwfullname
            // 
            this.textBox_spwfullname.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_spwfullname.Location = new System.Drawing.Point(240, 158);
            this.textBox_spwfullname.Name = "textBox_spwfullname";
            this.textBox_spwfullname.Size = new System.Drawing.Size(837, 30);
            this.textBox_spwfullname.TabIndex = 23;
            // 
            // textBox_spwjob
            // 
            this.textBox_spwjob.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_spwjob.Location = new System.Drawing.Point(240, 191);
            this.textBox_spwjob.Name = "textBox_spwjob";
            this.textBox_spwjob.Size = new System.Drawing.Size(837, 30);
            this.textBox_spwjob.TabIndex = 24;
            // 
            // textBox_spwdepartmentid
            // 
            this.textBox_spwdepartmentid.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_spwdepartmentid.Location = new System.Drawing.Point(240, 224);
            this.textBox_spwdepartmentid.Name = "textBox_spwdepartmentid";
            this.textBox_spwdepartmentid.Size = new System.Drawing.Size(837, 30);
            this.textBox_spwdepartmentid.TabIndex = 25;
            // 
            // label_ratingspwid
            // 
            this.label_ratingspwid.AutoSize = true;
            this.label_ratingspwid.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ratingspwid.Location = new System.Drawing.Point(13, 161);
            this.label_ratingspwid.Name = "label_ratingspwid";
            this.label_ratingspwid.Size = new System.Drawing.Size(89, 25);
            this.label_ratingspwid.TabIndex = 26;
            this.label_ratingspwid.Text = "ID НПП:";
            // 
            // label_ratingdate
            // 
            this.label_ratingdate.AutoSize = true;
            this.label_ratingdate.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ratingdate.Location = new System.Drawing.Point(13, 194);
            this.label_ratingdate.Name = "label_ratingdate";
            this.label_ratingdate.Size = new System.Drawing.Size(166, 25);
            this.label_ratingdate.TabIndex = 27;
            this.label_ratingdate.Text = "Дата рейтингу:";
            // 
            // label_ratindworkid
            // 
            this.label_ratindworkid.AutoSize = true;
            this.label_ratindworkid.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ratindworkid.Location = new System.Drawing.Point(13, 227);
            this.label_ratindworkid.Name = "label_ratindworkid";
            this.label_ratindworkid.Size = new System.Drawing.Size(155, 25);
            this.label_ratindworkid.TabIndex = 28;
            this.label_ratindworkid.Text = "ID показника:";
            // 
            // label_ratingquantity
            // 
            this.label_ratingquantity.AutoSize = true;
            this.label_ratingquantity.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ratingquantity.Location = new System.Drawing.Point(13, 260);
            this.label_ratingquantity.Name = "label_ratingquantity";
            this.label_ratingquantity.Size = new System.Drawing.Size(122, 25);
            this.label_ratingquantity.TabIndex = 29;
            this.label_ratingquantity.Text = "Кількість:";
            // 
            // label_ratingdescription
            // 
            this.label_ratingdescription.AutoSize = true;
            this.label_ratingdescription.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ratingdescription.Location = new System.Drawing.Point(13, 293);
            this.label_ratingdescription.Name = "label_ratingdescription";
            this.label_ratingdescription.Size = new System.Drawing.Size(177, 25);
            this.label_ratingdescription.TabIndex = 30;
            this.label_ratingdescription.Text = "Опис досягнень:";
            // 
            // textBox_ratingspwid
            // 
            this.textBox_ratingspwid.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_ratingspwid.Location = new System.Drawing.Point(240, 158);
            this.textBox_ratingspwid.Name = "textBox_ratingspwid";
            this.textBox_ratingspwid.Size = new System.Drawing.Size(837, 30);
            this.textBox_ratingspwid.TabIndex = 31;
            // 
            // textBox_ratingdate
            // 
            this.textBox_ratingdate.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_ratingdate.Location = new System.Drawing.Point(240, 191);
            this.textBox_ratingdate.Name = "textBox_ratingdate";
            this.textBox_ratingdate.Size = new System.Drawing.Size(837, 30);
            this.textBox_ratingdate.TabIndex = 32;
            // 
            // textBox_ratindworkid
            // 
            this.textBox_ratindworkid.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_ratindworkid.Location = new System.Drawing.Point(240, 224);
            this.textBox_ratindworkid.Name = "textBox_ratindworkid";
            this.textBox_ratindworkid.Size = new System.Drawing.Size(837, 30);
            this.textBox_ratindworkid.TabIndex = 33;
            // 
            // textBox_ratingquantity
            // 
            this.textBox_ratingquantity.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_ratingquantity.Location = new System.Drawing.Point(240, 257);
            this.textBox_ratingquantity.Name = "textBox_ratingquantity";
            this.textBox_ratingquantity.Size = new System.Drawing.Size(837, 30);
            this.textBox_ratingquantity.TabIndex = 34;
            // 
            // textBox_ratingdescription
            // 
            this.textBox_ratingdescription.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_ratingdescription.Location = new System.Drawing.Point(240, 290);
            this.textBox_ratingdescription.Name = "textBox_ratingdescription";
            this.textBox_ratingdescription.Size = new System.Drawing.Size(837, 30);
            this.textBox_ratingdescription.TabIndex = 35;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(18, 104);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(259, 33);
            this.comboBox1.TabIndex = 36;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label_workname
            // 
            this.label_workname.AutoSize = true;
            this.label_workname.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_workname.Location = new System.Drawing.Point(13, 161);
            this.label_workname.Name = "label_workname";
            this.label_workname.Size = new System.Drawing.Size(133, 25);
            this.label_workname.TabIndex = 37;
            this.label_workname.Text = "Вид роботи:";
            // 
            // label_workscore
            // 
            this.label_workscore.AutoSize = true;
            this.label_workscore.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_workscore.Location = new System.Drawing.Point(13, 194);
            this.label_workscore.Name = "label_workscore";
            this.label_workscore.Size = new System.Drawing.Size(188, 25);
            this.label_workscore.TabIndex = 38;
            this.label_workscore.Text = "Ціна за одиницю:";
            // 
            // textBox_workname
            // 
            this.textBox_workname.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_workname.Location = new System.Drawing.Point(240, 158);
            this.textBox_workname.Name = "textBox_workname";
            this.textBox_workname.Size = new System.Drawing.Size(837, 30);
            this.textBox_workname.TabIndex = 39;
            // 
            // textBox_workscore
            // 
            this.textBox_workscore.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_workscore.Location = new System.Drawing.Point(240, 191);
            this.textBox_workscore.Name = "textBox_workscore";
            this.textBox_workscore.Size = new System.Drawing.Size(837, 30);
            this.textBox_workscore.TabIndex = 40;
            // 
            // button_step
            // 
            this.button_step.BackColor = System.Drawing.Color.LightCoral;
            this.button_step.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_step.Font = new System.Drawing.Font("Cascadia Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_step.Location = new System.Drawing.Point(18, 362);
            this.button_step.Name = "button_step";
            this.button_step.Size = new System.Drawing.Size(165, 56);
            this.button_step.TabIndex = 41;
            this.button_step.Text = "←Назад";
            this.button_step.UseVisualStyleBackColor = false;
            this.button_step.Click += new System.EventHandler(this.button_step_Click);
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_save.Font = new System.Drawing.Font("Cascadia Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_save.ForeColor = System.Drawing.Color.White;
            this.button_save.Location = new System.Drawing.Point(189, 362);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(888, 56);
            this.button_save.TabIndex = 42;
            this.button_save.Text = "Зберегти зміни";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // edit_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1097, 427);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_step);
            this.Controls.Add(this.label_workscore);
            this.Controls.Add(this.label_workname);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label_ratingdescription);
            this.Controls.Add(this.label_ratingquantity);
            this.Controls.Add(this.label_ratindworkid);
            this.Controls.Add(this.label_ratingdate);
            this.Controls.Add(this.label_ratingspwid);
            this.Controls.Add(this.label_spwdepartmentid);
            this.Controls.Add(this.label_spwjob);
            this.Controls.Add(this.label_spwfullname);
            this.Controls.Add(this.label_departmentfacultyid);
            this.Controls.Add(this.label_departmentname);
            this.Controls.Add(this.label_facultyunid);
            this.Controls.Add(this.label_facultyname);
            this.Controls.Add(this.label_universityname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radio_workindicator);
            this.Controls.Add(this.radio_rating);
            this.Controls.Add(this.radio_spw);
            this.Controls.Add(this.radio_department);
            this.Controls.Add(this.radio_faculty);
            this.Controls.Add(this.radio_university);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_workname);
            this.Controls.Add(this.textBox_ratingspwid);
            this.Controls.Add(this.textBox_spwfullname);
            this.Controls.Add(this.textBox_departmentname);
            this.Controls.Add(this.textBox_facultyname);
            this.Controls.Add(this.textBox_universityname);
            this.Controls.Add(this.textBox_ratingdate);
            this.Controls.Add(this.textBox_spwjob);
            this.Controls.Add(this.textBox_departmentfacultyid);
            this.Controls.Add(this.textBox_facultyunid);
            this.Controls.Add(this.textBox_universityaddress);
            this.Controls.Add(this.textBox_workscore);
            this.Controls.Add(this.textBox_ratindworkid);
            this.Controls.Add(this.textBox_spwdepartmentid);
            this.Controls.Add(this.textBox_ratingquantity);
            this.Controls.Add(this.textBox_ratingdescription);
            this.Controls.Add(this.label_universityaddress);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "edit_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редагування довідників";
            this.Load += new System.EventHandler(this.edit_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radio_university;
        private System.Windows.Forms.RadioButton radio_faculty;
        private System.Windows.Forms.RadioButton radio_department;
        private System.Windows.Forms.RadioButton radio_spw;
        private System.Windows.Forms.RadioButton radio_rating;
        private System.Windows.Forms.RadioButton radio_workindicator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_universityname;
        private System.Windows.Forms.TextBox textBox_universityname;
        private System.Windows.Forms.Label label_universityaddress;
        private System.Windows.Forms.TextBox textBox_universityaddress;
        private System.Windows.Forms.Label label_facultyname;
        private System.Windows.Forms.TextBox textBox_facultyname;
        private System.Windows.Forms.Label label_facultyunid;
        private System.Windows.Forms.TextBox textBox_facultyunid;
        private System.Windows.Forms.Label label_departmentname;
        private System.Windows.Forms.Label label_departmentfacultyid;
        private System.Windows.Forms.TextBox textBox_departmentname;
        private System.Windows.Forms.TextBox textBox_departmentfacultyid;
        private System.Windows.Forms.Label label_spwfullname;
        private System.Windows.Forms.Label label_spwjob;
        private System.Windows.Forms.Label label_spwdepartmentid;
        private System.Windows.Forms.TextBox textBox_spwfullname;
        private System.Windows.Forms.TextBox textBox_spwjob;
        private System.Windows.Forms.TextBox textBox_spwdepartmentid;
        private System.Windows.Forms.Label label_ratingspwid;
        private System.Windows.Forms.Label label_ratingdate;
        private System.Windows.Forms.Label label_ratindworkid;
        private System.Windows.Forms.Label label_ratingquantity;
        private System.Windows.Forms.Label label_ratingdescription;
        private System.Windows.Forms.TextBox textBox_ratingspwid;
        private System.Windows.Forms.TextBox textBox_ratingdate;
        private System.Windows.Forms.TextBox textBox_ratindworkid;
        private System.Windows.Forms.TextBox textBox_ratingquantity;
        private System.Windows.Forms.TextBox textBox_ratingdescription;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label_workname;
        private System.Windows.Forms.Label label_workscore;
        private System.Windows.Forms.TextBox textBox_workname;
        private System.Windows.Forms.TextBox textBox_workscore;
        private System.Windows.Forms.Button button_step;
        private System.Windows.Forms.Button button_save;
    }
}