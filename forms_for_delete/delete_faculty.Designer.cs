namespace course_work.forms_for_delete
{
    partial class delete_faculty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(delete_faculty));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_facultyname = new System.Windows.Forms.Label();
            this.label_facultyuniverId = new System.Windows.Forms.Label();
            this.button_step = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Назва факультету:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID університету:";
            // 
            // label_facultyname
            // 
            this.label_facultyname.AutoSize = true;
            this.label_facultyname.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_facultyname.Location = new System.Drawing.Point(235, 19);
            this.label_facultyname.Name = "label_facultyname";
            this.label_facultyname.Size = new System.Drawing.Size(19, 21);
            this.label_facultyname.TabIndex = 2;
            this.label_facultyname.Text = "-";
            // 
            // label_facultyuniverId
            // 
            this.label_facultyuniverId.AutoSize = true;
            this.label_facultyuniverId.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_facultyuniverId.Location = new System.Drawing.Point(235, 59);
            this.label_facultyuniverId.Name = "label_facultyuniverId";
            this.label_facultyuniverId.Size = new System.Drawing.Size(19, 21);
            this.label_facultyuniverId.TabIndex = 3;
            this.label_facultyuniverId.Text = "-";
            // 
            // button_step
            // 
            this.button_step.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button_step.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_step.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_step.Location = new System.Drawing.Point(18, 108);
            this.button_step.Name = "button_step";
            this.button_step.Size = new System.Drawing.Size(155, 53);
            this.button_step.TabIndex = 4;
            this.button_step.Text = "←Назад";
            this.button_step.UseVisualStyleBackColor = false;
            this.button_step.Click += new System.EventHandler(this.button_step_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(179, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(506, 53);
            this.button1.TabIndex = 5;
            this.button1.Text = "Видалити";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // delete_faculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(706, 171);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_step);
            this.Controls.Add(this.label_facultyuniverId);
            this.Controls.Add(this.label_facultyname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "delete_faculty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Видалити факультет";
            this.Load += new System.EventHandler(this.delete_faculty_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_facultyname;
        private System.Windows.Forms.Label label_facultyuniverId;
        private System.Windows.Forms.Button button_step;
        private System.Windows.Forms.Button button1;
    }
}