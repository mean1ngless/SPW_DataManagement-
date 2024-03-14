namespace course_work
{
    partial class add_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_form));
            this.radio_University = new System.Windows.Forms.RadioButton();
            this.radio_Faculty = new System.Windows.Forms.RadioButton();
            this.radio_Department = new System.Windows.Forms.RadioButton();
            this.radio_SPW = new System.Windows.Forms.RadioButton();
            this.radio_Rating = new System.Windows.Forms.RadioButton();
            this.radio_WorkIndicator = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label_universityname = new System.Windows.Forms.Label();
            this.label_universityadress = new System.Windows.Forms.Label();
            this.textBox_universityName = new System.Windows.Forms.TextBox();
            this.textBox_universityAddress = new System.Windows.Forms.TextBox();
            this.label_facultyname = new System.Windows.Forms.Label();
            this.label_facultyuniversityid = new System.Windows.Forms.Label();
            this.textBox_facultyname = new System.Windows.Forms.TextBox();
            this.textBox_facultyuniversityid = new System.Windows.Forms.TextBox();
            this.label_departname = new System.Windows.Forms.Label();
            this.label_departfacultyid = new System.Windows.Forms.Label();
            this.textBox_departName = new System.Windows.Forms.TextBox();
            this.textBox_departFacultyId = new System.Windows.Forms.TextBox();
            this.label_SPWName = new System.Windows.Forms.Label();
            this.label_spwjob = new System.Windows.Forms.Label();
            this.label_spwdepartid = new System.Windows.Forms.Label();
            this.textBox_SPWName = new System.Windows.Forms.TextBox();
            this.textBox_SPWJob = new System.Windows.Forms.TextBox();
            this.textBox_spwdepartid = new System.Windows.Forms.TextBox();
            this.label_ratingspwid = new System.Windows.Forms.Label();
            this.label_ratingyear = new System.Windows.Forms.Label();
            this.label_ratingworkid = new System.Windows.Forms.Label();
            this.label_ratingquantity = new System.Windows.Forms.Label();
            this.label_ratingdescr = new System.Windows.Forms.Label();
            this.textBox_ratingspwid = new System.Windows.Forms.TextBox();
            this.textBox_ratingyear = new System.Windows.Forms.TextBox();
            this.textBox_ratingworkid = new System.Windows.Forms.TextBox();
            this.textBox_ratingquantity = new System.Windows.Forms.TextBox();
            this.textBox_ratingdescr = new System.Windows.Forms.TextBox();
            this.label_workname = new System.Windows.Forms.Label();
            this.label_workscore = new System.Windows.Forms.Label();
            this.textBox_workname = new System.Windows.Forms.TextBox();
            this.textBox_workscore = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.button_closeform = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radio_University
            // 
            this.radio_University.AutoSize = true;
            this.radio_University.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radio_University.Location = new System.Drawing.Point(13, 43);
            this.radio_University.Name = "radio_University";
            this.radio_University.Size = new System.Drawing.Size(106, 20);
            this.radio_University.TabIndex = 0;
            this.radio_University.TabStop = true;
            this.radio_University.Text = "Університет";
            this.radio_University.UseVisualStyleBackColor = true;
            this.radio_University.CheckedChanged += new System.EventHandler(this.radio_University_CheckedChanged);
            // 
            // radio_Faculty
            // 
            this.radio_Faculty.AutoSize = true;
            this.radio_Faculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radio_Faculty.Location = new System.Drawing.Point(125, 43);
            this.radio_Faculty.Name = "radio_Faculty";
            this.radio_Faculty.Size = new System.Drawing.Size(96, 20);
            this.radio_Faculty.TabIndex = 1;
            this.radio_Faculty.TabStop = true;
            this.radio_Faculty.Text = "Факультет";
            this.radio_Faculty.UseVisualStyleBackColor = true;
            this.radio_Faculty.CheckedChanged += new System.EventHandler(this.radio_Faculty_CheckedChanged);
            // 
            // radio_Department
            // 
            this.radio_Department.AutoSize = true;
            this.radio_Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radio_Department.Location = new System.Drawing.Point(227, 43);
            this.radio_Department.Name = "radio_Department";
            this.radio_Department.Size = new System.Drawing.Size(84, 20);
            this.radio_Department.TabIndex = 2;
            this.radio_Department.TabStop = true;
            this.radio_Department.Text = "Кафедра";
            this.radio_Department.UseVisualStyleBackColor = true;
            this.radio_Department.CheckedChanged += new System.EventHandler(this.radio_Department_CheckedChanged);
            // 
            // radio_SPW
            // 
            this.radio_SPW.AutoSize = true;
            this.radio_SPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radio_SPW.Location = new System.Drawing.Point(317, 43);
            this.radio_SPW.Name = "radio_SPW";
            this.radio_SPW.Size = new System.Drawing.Size(55, 20);
            this.radio_SPW.TabIndex = 3;
            this.radio_SPW.TabStop = true;
            this.radio_SPW.Text = "НПП";
            this.radio_SPW.UseVisualStyleBackColor = true;
            this.radio_SPW.CheckedChanged += new System.EventHandler(this.radio_SPW_CheckedChanged);
            // 
            // radio_Rating
            // 
            this.radio_Rating.AutoSize = true;
            this.radio_Rating.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radio_Rating.Location = new System.Drawing.Point(378, 43);
            this.radio_Rating.Name = "radio_Rating";
            this.radio_Rating.Size = new System.Drawing.Size(79, 20);
            this.radio_Rating.TabIndex = 4;
            this.radio_Rating.TabStop = true;
            this.radio_Rating.Text = "Рейтинг";
            this.radio_Rating.UseVisualStyleBackColor = true;
            this.radio_Rating.CheckedChanged += new System.EventHandler(this.radio_Rating_CheckedChanged);
            // 
            // radio_WorkIndicator
            // 
            this.radio_WorkIndicator.AutoSize = true;
            this.radio_WorkIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radio_WorkIndicator.Location = new System.Drawing.Point(463, 43);
            this.radio_WorkIndicator.Name = "radio_WorkIndicator";
            this.radio_WorkIndicator.Size = new System.Drawing.Size(139, 20);
            this.radio_WorkIndicator.TabIndex = 5;
            this.radio_WorkIndicator.TabStop = true;
            this.radio_WorkIndicator.Text = "Показник роботи";
            this.radio_WorkIndicator.UseVisualStyleBackColor = true;
            this.radio_WorkIndicator.CheckedChanged += new System.EventHandler(this.radio_WorkIndicator_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Оберіть довідник для вставки:";
            // 
            // label_universityname
            // 
            this.label_universityname.AutoSize = true;
            this.label_universityname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_universityname.Location = new System.Drawing.Point(9, 70);
            this.label_universityname.Name = "label_universityname";
            this.label_universityname.Size = new System.Drawing.Size(192, 24);
            this.label_universityname.TabIndex = 7;
            this.label_universityname.Text = "Назва університету:";
            // 
            // label_universityadress
            // 
            this.label_universityadress.AutoSize = true;
            this.label_universityadress.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_universityadress.Location = new System.Drawing.Point(9, 101);
            this.label_universityadress.Name = "label_universityadress";
            this.label_universityadress.Size = new System.Drawing.Size(232, 25);
            this.label_universityadress.TabIndex = 8;
            this.label_universityadress.Text = "Адреса університету:";
            // 
            // textBox_universityName
            // 
            this.textBox_universityName.BackColor = System.Drawing.Color.White;
            this.textBox_universityName.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_universityName.Location = new System.Drawing.Point(246, 65);
            this.textBox_universityName.Name = "textBox_universityName";
            this.textBox_universityName.Size = new System.Drawing.Size(356, 30);
            this.textBox_universityName.TabIndex = 9;
            // 
            // textBox_universityAddress
            // 
            this.textBox_universityAddress.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_universityAddress.Location = new System.Drawing.Point(246, 98);
            this.textBox_universityAddress.Name = "textBox_universityAddress";
            this.textBox_universityAddress.Size = new System.Drawing.Size(356, 30);
            this.textBox_universityAddress.TabIndex = 10;
            // 
            // label_facultyname
            // 
            this.label_facultyname.AutoSize = true;
            this.label_facultyname.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_facultyname.Location = new System.Drawing.Point(9, 70);
            this.label_facultyname.Name = "label_facultyname";
            this.label_facultyname.Size = new System.Drawing.Size(199, 25);
            this.label_facultyname.TabIndex = 11;
            this.label_facultyname.Text = "Назва факультету:";
            // 
            // label_facultyuniversityid
            // 
            this.label_facultyuniversityid.AutoSize = true;
            this.label_facultyuniversityid.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_facultyuniversityid.Location = new System.Drawing.Point(9, 101);
            this.label_facultyuniversityid.Name = "label_facultyuniversityid";
            this.label_facultyuniversityid.Size = new System.Drawing.Size(188, 25);
            this.label_facultyuniversityid.TabIndex = 12;
            this.label_facultyuniversityid.Text = "ID Університету:";
            // 
            // textBox_facultyname
            // 
            this.textBox_facultyname.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_facultyname.Location = new System.Drawing.Point(246, 65);
            this.textBox_facultyname.Name = "textBox_facultyname";
            this.textBox_facultyname.Size = new System.Drawing.Size(356, 30);
            this.textBox_facultyname.TabIndex = 13;
            // 
            // textBox_facultyuniversityid
            // 
            this.textBox_facultyuniversityid.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_facultyuniversityid.Location = new System.Drawing.Point(246, 98);
            this.textBox_facultyuniversityid.Name = "textBox_facultyuniversityid";
            this.textBox_facultyuniversityid.Size = new System.Drawing.Size(356, 30);
            this.textBox_facultyuniversityid.TabIndex = 14;
            // 
            // label_departname
            // 
            this.label_departname.AutoSize = true;
            this.label_departname.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_departname.Location = new System.Drawing.Point(9, 70);
            this.label_departname.Name = "label_departname";
            this.label_departname.Size = new System.Drawing.Size(166, 25);
            this.label_departname.TabIndex = 15;
            this.label_departname.Text = "Назва кафедри:";
            // 
            // label_departfacultyid
            // 
            this.label_departfacultyid.AutoSize = true;
            this.label_departfacultyid.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_departfacultyid.Location = new System.Drawing.Point(9, 101);
            this.label_departfacultyid.Name = "label_departfacultyid";
            this.label_departfacultyid.Size = new System.Drawing.Size(166, 25);
            this.label_departfacultyid.TabIndex = 16;
            this.label_departfacultyid.Text = "ID факультету:";
            // 
            // textBox_departName
            // 
            this.textBox_departName.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_departName.Location = new System.Drawing.Point(246, 65);
            this.textBox_departName.Name = "textBox_departName";
            this.textBox_departName.Size = new System.Drawing.Size(356, 30);
            this.textBox_departName.TabIndex = 17;
            // 
            // textBox_departFacultyId
            // 
            this.textBox_departFacultyId.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_departFacultyId.Location = new System.Drawing.Point(246, 98);
            this.textBox_departFacultyId.Name = "textBox_departFacultyId";
            this.textBox_departFacultyId.Size = new System.Drawing.Size(356, 30);
            this.textBox_departFacultyId.TabIndex = 18;
            // 
            // label_SPWName
            // 
            this.label_SPWName.AutoSize = true;
            this.label_SPWName.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_SPWName.Location = new System.Drawing.Point(9, 70);
            this.label_SPWName.Name = "label_SPWName";
            this.label_SPWName.Size = new System.Drawing.Size(100, 25);
            this.label_SPWName.TabIndex = 19;
            this.label_SPWName.Text = "ПІБ НПП:";
            // 
            // label_spwjob
            // 
            this.label_spwjob.AutoSize = true;
            this.label_spwjob.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_spwjob.Location = new System.Drawing.Point(9, 101);
            this.label_spwjob.Name = "label_spwjob";
            this.label_spwjob.Size = new System.Drawing.Size(89, 25);
            this.label_spwjob.TabIndex = 20;
            this.label_spwjob.Text = "Посада:";
            // 
            // label_spwdepartid
            // 
            this.label_spwdepartid.AutoSize = true;
            this.label_spwdepartid.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_spwdepartid.Location = new System.Drawing.Point(9, 132);
            this.label_spwdepartid.Name = "label_spwdepartid";
            this.label_spwdepartid.Size = new System.Drawing.Size(133, 25);
            this.label_spwdepartid.TabIndex = 21;
            this.label_spwdepartid.Text = "ID кафедри:";
            // 
            // textBox_SPWName
            // 
            this.textBox_SPWName.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_SPWName.Location = new System.Drawing.Point(246, 65);
            this.textBox_SPWName.Name = "textBox_SPWName";
            this.textBox_SPWName.Size = new System.Drawing.Size(356, 30);
            this.textBox_SPWName.TabIndex = 22;
            // 
            // textBox_SPWJob
            // 
            this.textBox_SPWJob.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_SPWJob.Location = new System.Drawing.Point(246, 98);
            this.textBox_SPWJob.Name = "textBox_SPWJob";
            this.textBox_SPWJob.Size = new System.Drawing.Size(356, 30);
            this.textBox_SPWJob.TabIndex = 23;
            // 
            // textBox_spwdepartid
            // 
            this.textBox_spwdepartid.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_spwdepartid.Location = new System.Drawing.Point(246, 131);
            this.textBox_spwdepartid.Name = "textBox_spwdepartid";
            this.textBox_spwdepartid.Size = new System.Drawing.Size(356, 30);
            this.textBox_spwdepartid.TabIndex = 24;
            // 
            // label_ratingspwid
            // 
            this.label_ratingspwid.AutoSize = true;
            this.label_ratingspwid.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ratingspwid.Location = new System.Drawing.Point(9, 70);
            this.label_ratingspwid.Name = "label_ratingspwid";
            this.label_ratingspwid.Size = new System.Drawing.Size(89, 25);
            this.label_ratingspwid.TabIndex = 25;
            this.label_ratingspwid.Text = "ID НПП:";
            // 
            // label_ratingyear
            // 
            this.label_ratingyear.AutoSize = true;
            this.label_ratingyear.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ratingyear.Location = new System.Drawing.Point(9, 101);
            this.label_ratingyear.Name = "label_ratingyear";
            this.label_ratingyear.Size = new System.Drawing.Size(166, 25);
            this.label_ratingyear.TabIndex = 26;
            this.label_ratingyear.Text = "Дата рейтингу:";
            // 
            // label_ratingworkid
            // 
            this.label_ratingworkid.AutoSize = true;
            this.label_ratingworkid.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ratingworkid.Location = new System.Drawing.Point(9, 132);
            this.label_ratingworkid.Name = "label_ratingworkid";
            this.label_ratingworkid.Size = new System.Drawing.Size(232, 25);
            this.label_ratingworkid.TabIndex = 27;
            this.label_ratingworkid.Text = "ID показника роботи:";
            // 
            // label_ratingquantity
            // 
            this.label_ratingquantity.AutoSize = true;
            this.label_ratingquantity.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ratingquantity.Location = new System.Drawing.Point(9, 163);
            this.label_ratingquantity.Name = "label_ratingquantity";
            this.label_ratingquantity.Size = new System.Drawing.Size(122, 25);
            this.label_ratingquantity.TabIndex = 28;
            this.label_ratingquantity.Text = "Кількість:";
            // 
            // label_ratingdescr
            // 
            this.label_ratingdescr.AutoSize = true;
            this.label_ratingdescr.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ratingdescr.Location = new System.Drawing.Point(9, 194);
            this.label_ratingdescr.Name = "label_ratingdescr";
            this.label_ratingdescr.Size = new System.Drawing.Size(177, 25);
            this.label_ratingdescr.TabIndex = 29;
            this.label_ratingdescr.Text = "Опис досягнень:";
            // 
            // textBox_ratingspwid
            // 
            this.textBox_ratingspwid.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_ratingspwid.Location = new System.Drawing.Point(246, 65);
            this.textBox_ratingspwid.Name = "textBox_ratingspwid";
            this.textBox_ratingspwid.Size = new System.Drawing.Size(356, 30);
            this.textBox_ratingspwid.TabIndex = 30;
            // 
            // textBox_ratingyear
            // 
            this.textBox_ratingyear.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_ratingyear.Location = new System.Drawing.Point(246, 98);
            this.textBox_ratingyear.Name = "textBox_ratingyear";
            this.textBox_ratingyear.Size = new System.Drawing.Size(356, 30);
            this.textBox_ratingyear.TabIndex = 31;
            // 
            // textBox_ratingworkid
            // 
            this.textBox_ratingworkid.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_ratingworkid.Location = new System.Drawing.Point(246, 131);
            this.textBox_ratingworkid.Name = "textBox_ratingworkid";
            this.textBox_ratingworkid.Size = new System.Drawing.Size(356, 30);
            this.textBox_ratingworkid.TabIndex = 32;
            // 
            // textBox_ratingquantity
            // 
            this.textBox_ratingquantity.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_ratingquantity.Location = new System.Drawing.Point(246, 164);
            this.textBox_ratingquantity.Name = "textBox_ratingquantity";
            this.textBox_ratingquantity.Size = new System.Drawing.Size(356, 30);
            this.textBox_ratingquantity.TabIndex = 33;
            // 
            // textBox_ratingdescr
            // 
            this.textBox_ratingdescr.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_ratingdescr.Location = new System.Drawing.Point(246, 197);
            this.textBox_ratingdescr.Name = "textBox_ratingdescr";
            this.textBox_ratingdescr.Size = new System.Drawing.Size(356, 30);
            this.textBox_ratingdescr.TabIndex = 34;
            // 
            // label_workname
            // 
            this.label_workname.AutoSize = true;
            this.label_workname.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_workname.Location = new System.Drawing.Point(9, 70);
            this.label_workname.Name = "label_workname";
            this.label_workname.Size = new System.Drawing.Size(133, 25);
            this.label_workname.TabIndex = 35;
            this.label_workname.Text = "Вид роботи:";
            // 
            // label_workscore
            // 
            this.label_workscore.AutoSize = true;
            this.label_workscore.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_workscore.Location = new System.Drawing.Point(9, 101);
            this.label_workscore.Name = "label_workscore";
            this.label_workscore.Size = new System.Drawing.Size(188, 25);
            this.label_workscore.TabIndex = 36;
            this.label_workscore.Text = "Ціна за одиницю:";
            // 
            // textBox_workname
            // 
            this.textBox_workname.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_workname.Location = new System.Drawing.Point(246, 65);
            this.textBox_workname.Name = "textBox_workname";
            this.textBox_workname.Size = new System.Drawing.Size(356, 30);
            this.textBox_workname.TabIndex = 37;
            // 
            // textBox_workscore
            // 
            this.textBox_workscore.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_workscore.Location = new System.Drawing.Point(246, 98);
            this.textBox_workscore.Name = "textBox_workscore";
            this.textBox_workscore.Size = new System.Drawing.Size(356, 30);
            this.textBox_workscore.TabIndex = 38;
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.LimeGreen;
            this.button_add.Font = new System.Drawing.Font("Cascadia Mono", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Location = new System.Drawing.Point(413, 251);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(189, 54);
            this.button_add.TabIndex = 39;
            this.button_add.Text = "Додати";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_closeform
            // 
            this.button_closeform.BackColor = System.Drawing.Color.Firebrick;
            this.button_closeform.Font = new System.Drawing.Font("Cascadia Mono", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_closeform.ForeColor = System.Drawing.Color.White;
            this.button_closeform.Location = new System.Drawing.Point(13, 251);
            this.button_closeform.Name = "button_closeform";
            this.button_closeform.Size = new System.Drawing.Size(189, 54);
            this.button_closeform.TabIndex = 40;
            this.button_closeform.Text = "Відминити";
            this.button_closeform.UseVisualStyleBackColor = false;
            this.button_closeform.Click += new System.EventHandler(this.button_closeform_Click);
            // 
            // add_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(613, 316);
            this.Controls.Add(this.button_closeform);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox_workscore);
            this.Controls.Add(this.textBox_workname);
            this.Controls.Add(this.label_workscore);
            this.Controls.Add(this.label_workname);
            this.Controls.Add(this.textBox_ratingdescr);
            this.Controls.Add(this.textBox_ratingquantity);
            this.Controls.Add(this.textBox_ratingworkid);
            this.Controls.Add(this.textBox_ratingyear);
            this.Controls.Add(this.textBox_ratingspwid);
            this.Controls.Add(this.label_ratingdescr);
            this.Controls.Add(this.label_ratingquantity);
            this.Controls.Add(this.label_ratingworkid);
            this.Controls.Add(this.label_ratingyear);
            this.Controls.Add(this.label_ratingspwid);
            this.Controls.Add(this.textBox_spwdepartid);
            this.Controls.Add(this.textBox_SPWJob);
            this.Controls.Add(this.textBox_SPWName);
            this.Controls.Add(this.label_spwdepartid);
            this.Controls.Add(this.label_spwjob);
            this.Controls.Add(this.label_SPWName);
            this.Controls.Add(this.textBox_departFacultyId);
            this.Controls.Add(this.textBox_departName);
            this.Controls.Add(this.label_departfacultyid);
            this.Controls.Add(this.label_departname);
            this.Controls.Add(this.textBox_facultyuniversityid);
            this.Controls.Add(this.textBox_facultyname);
            this.Controls.Add(this.label_facultyuniversityid);
            this.Controls.Add(this.label_facultyname);
            this.Controls.Add(this.textBox_universityAddress);
            this.Controls.Add(this.textBox_universityName);
            this.Controls.Add(this.label_universityadress);
            this.Controls.Add(this.label_universityname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radio_WorkIndicator);
            this.Controls.Add(this.radio_Rating);
            this.Controls.Add(this.radio_SPW);
            this.Controls.Add(this.radio_Department);
            this.Controls.Add(this.radio_Faculty);
            this.Controls.Add(this.radio_University);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(629, 355);
            this.MinimumSize = new System.Drawing.Size(629, 355);
            this.Name = "add_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додати новий запис";
            this.Load += new System.EventHandler(this.add_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radio_University;
        private System.Windows.Forms.RadioButton radio_Faculty;
        private System.Windows.Forms.RadioButton radio_Department;
        private System.Windows.Forms.RadioButton radio_SPW;
        private System.Windows.Forms.RadioButton radio_Rating;
        private System.Windows.Forms.RadioButton radio_WorkIndicator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_universityname;
        private System.Windows.Forms.Label label_universityadress;
        private System.Windows.Forms.TextBox textBox_universityName;
        private System.Windows.Forms.TextBox textBox_universityAddress;
        private System.Windows.Forms.Label label_facultyname;
        private System.Windows.Forms.Label label_facultyuniversityid;
        private System.Windows.Forms.TextBox textBox_facultyname;
        private System.Windows.Forms.TextBox textBox_facultyuniversityid;
        private System.Windows.Forms.Label label_departname;
        private System.Windows.Forms.Label label_departfacultyid;
        private System.Windows.Forms.TextBox textBox_departName;
        private System.Windows.Forms.TextBox textBox_departFacultyId;
        private System.Windows.Forms.Label label_SPWName;
        private System.Windows.Forms.Label label_spwjob;
        private System.Windows.Forms.Label label_spwdepartid;
        private System.Windows.Forms.TextBox textBox_SPWName;
        private System.Windows.Forms.TextBox textBox_SPWJob;
        private System.Windows.Forms.TextBox textBox_spwdepartid;
        private System.Windows.Forms.Label label_ratingspwid;
        private System.Windows.Forms.Label label_ratingyear;
        private System.Windows.Forms.Label label_ratingworkid;
        private System.Windows.Forms.Label label_ratingquantity;
        private System.Windows.Forms.Label label_ratingdescr;
        private System.Windows.Forms.TextBox textBox_ratingspwid;
        private System.Windows.Forms.TextBox textBox_ratingyear;
        private System.Windows.Forms.TextBox textBox_ratingworkid;
        private System.Windows.Forms.TextBox textBox_ratingquantity;
        private System.Windows.Forms.TextBox textBox_ratingdescr;
        private System.Windows.Forms.Label label_workname;
        private System.Windows.Forms.Label label_workscore;
        private System.Windows.Forms.TextBox textBox_workname;
        private System.Windows.Forms.TextBox textBox_workscore;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_closeform;
    }
}