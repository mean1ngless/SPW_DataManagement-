namespace course_work
{
    partial class delete_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(delete_form));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_over_select = new System.Windows.Forms.Label();
            this.label_over_id = new System.Windows.Forms.Label();
            this.textBox_selectedId = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.Font = new System.Drawing.Font("Cascadia Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "University",
            "Faculty",
            "Department",
            "SPW",
            "Rating",
            "WorkIndicator"});
            this.comboBox1.Location = new System.Drawing.Point(12, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(384, 36);
            this.comboBox1.TabIndex = 0;
            // 
            // label_over_select
            // 
            this.label_over_select.AutoSize = true;
            this.label_over_select.Font = new System.Drawing.Font("Cascadia Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_over_select.Location = new System.Drawing.Point(7, 9);
            this.label_over_select.Name = "label_over_select";
            this.label_over_select.Size = new System.Drawing.Size(384, 28);
            this.label_over_select.TabIndex = 1;
            this.label_over_select.Text = "Оберіть довідник для видалення:";
            // 
            // label_over_id
            // 
            this.label_over_id.AutoSize = true;
            this.label_over_id.Font = new System.Drawing.Font("Cascadia Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_over_id.Location = new System.Drawing.Point(7, 88);
            this.label_over_id.Name = "label_over_id";
            this.label_over_id.Size = new System.Drawing.Size(300, 56);
            this.label_over_id.TabIndex = 2;
            this.label_over_id.Text = "Вкажіть номер запису, \r\nякий необхідно видалити:";
            // 
            // textBox_selectedId
            // 
            this.textBox_selectedId.Font = new System.Drawing.Font("Cascadia Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_selectedId.Location = new System.Drawing.Point(12, 147);
            this.textBox_selectedId.Name = "textBox_selectedId";
            this.textBox_selectedId.Size = new System.Drawing.Size(384, 32);
            this.textBox_selectedId.TabIndex = 3;
            this.textBox_selectedId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.Font = new System.Drawing.Font("Cascadia Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(13, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(383, 47);
            this.button1.TabIndex = 4;
            this.button1.Text = "Видалити→";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // delete_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(411, 255);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_selectedId);
            this.Controls.Add(this.label_over_id);
            this.Controls.Add(this.label_over_select);
            this.Controls.Add(this.comboBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "delete_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Видалення запису";
            this.Load += new System.EventHandler(this.delete_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label_over_select;
        private System.Windows.Forms.Label label_over_id;
        private System.Windows.Forms.TextBox textBox_selectedId;
        private System.Windows.Forms.Button button1;
    }
}