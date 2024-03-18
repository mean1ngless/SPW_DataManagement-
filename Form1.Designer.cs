namespace course_work
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView_top = new System.Windows.Forms.DataGridView();
            this.tableSelect = new System.Windows.Forms.ComboBox();
            this.label_TableName_top = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button_addnew = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_top
            // 
            this.dataGridView_top.AllowUserToAddRows = false;
            this.dataGridView_top.AllowUserToDeleteRows = false;
            this.dataGridView_top.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_top.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView_top.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_top.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView_top.Location = new System.Drawing.Point(12, 101);
            this.dataGridView_top.Name = "dataGridView_top";
            this.dataGridView_top.ReadOnly = true;
            this.dataGridView_top.Size = new System.Drawing.Size(655, 233);
            this.dataGridView_top.TabIndex = 0;
            // 
            // tableSelect
            // 
            this.tableSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tableSelect.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableSelect.FormattingEnabled = true;
            this.tableSelect.ItemHeight = 25;
            this.tableSelect.Items.AddRange(new object[] {
            "University",
            "Faculty",
            "Department",
            "SPW",
            "Rating",
            "WorkIndicator"});
            this.tableSelect.Location = new System.Drawing.Point(12, 62);
            this.tableSelect.Name = "tableSelect";
            this.tableSelect.Size = new System.Drawing.Size(306, 33);
            this.tableSelect.TabIndex = 1;
            this.tableSelect.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label_TableName_top
            // 
            this.label_TableName_top.AutoSize = true;
            this.label_TableName_top.Font = new System.Drawing.Font("Cascadia Mono", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_TableName_top.Location = new System.Drawing.Point(12, 16);
            this.label_TableName_top.Name = "label_TableName_top";
            this.label_TableName_top.Size = new System.Drawing.Size(342, 43);
            this.label_TableName_top.TabIndex = 4;
            this.label_TableName_top.Text = "Оберіть довідник:";
            this.label_TableName_top.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateGray;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Cascadia Mono", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(449, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 62);
            this.button1.TabIndex = 5;
            this.button1.Text = "Credits";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_addnew
            // 
            this.button_addnew.BackColor = System.Drawing.Color.SteelBlue;
            this.button_addnew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_addnew.Font = new System.Drawing.Font("Cascadia Mono", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_addnew.ForeColor = System.Drawing.Color.White;
            this.button_addnew.Location = new System.Drawing.Point(675, 101);
            this.button_addnew.Name = "button_addnew";
            this.button_addnew.Size = new System.Drawing.Size(197, 62);
            this.button_addnew.TabIndex = 6;
            this.button_addnew.Text = "Додати";
            this.button_addnew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_addnew.UseVisualStyleBackColor = false;
            this.button_addnew.Click += new System.EventHandler(this.button_addnew_Click);
            // 
            // button_edit
            // 
            this.button_edit.BackColor = System.Drawing.Color.SteelBlue;
            this.button_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_edit.Font = new System.Drawing.Font("Cascadia Mono", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_edit.ForeColor = System.Drawing.Color.White;
            this.button_edit.Location = new System.Drawing.Point(675, 169);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(197, 62);
            this.button_edit.TabIndex = 7;
            this.button_edit.Text = "Редагувати";
            this.button_edit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_edit.UseVisualStyleBackColor = false;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.Firebrick;
            this.button_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_delete.Font = new System.Drawing.Font("Cascadia Mono", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.Location = new System.Drawing.Point(675, 272);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(197, 62);
            this.button_delete.TabIndex = 8;
            this.button_delete.Text = "Видалити";
            this.button_delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::course_work.Properties.Resources._1485477118_rotation_right_78579__2_;
            this.pictureBox1.Location = new System.Drawing.Point(325, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(809, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 69);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(724, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 43);
            this.label1.TabIndex = 11;
            this.label1.Text = "Інфо";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(884, 346);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.button_addnew);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_TableName_top);
            this.Controls.Add(this.tableSelect);
            this.Controls.Add(this.dataGridView_top);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 385);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 385);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Реєстр НПП";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_top;
        private System.Windows.Forms.ComboBox tableSelect;
        private System.Windows.Forms.Label label_TableName_top;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_addnew;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}

