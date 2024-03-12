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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_top)).BeginInit();
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.label_TableName_top);
            this.Controls.Add(this.tableSelect);
            this.Controls.Add(this.dataGridView_top);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Реєстр НПП";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_top)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_top;
        private System.Windows.Forms.ComboBox tableSelect;
        private System.Windows.Forms.Label label_TableName_top;
    }
}

