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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_top)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_top
            // 
            this.dataGridView_top.AllowUserToAddRows = false;
            this.dataGridView_top.AllowUserToDeleteRows = false;
            this.dataGridView_top.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_top.Location = new System.Drawing.Point(12, 63);
            this.dataGridView_top.Name = "dataGridView_top";
            this.dataGridView_top.ReadOnly = true;
            this.dataGridView_top.Size = new System.Drawing.Size(655, 242);
            this.dataGridView_top.TabIndex = 0;
            // 
            // tableSelect
            // 
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
            this.tableSelect.Location = new System.Drawing.Point(13, 25);
            this.tableSelect.Name = "tableSelect";
            this.tableSelect.Size = new System.Drawing.Size(306, 33);
            this.tableSelect.TabIndex = 1;
            this.tableSelect.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.tableSelect);
            this.Controls.Add(this.dataGridView_top);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1600, 900);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1600, 900);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Реєстр НПП";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_top)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_top;
        private System.Windows.Forms.ComboBox tableSelect;
    }
}

