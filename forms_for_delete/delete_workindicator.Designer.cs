﻿namespace course_work.forms_for_delete
{
    partial class delete_workindicator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(delete_workindicator));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_step = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.label_workname = new System.Windows.Forms.Label();
            this.label_score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вид роботи:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ціна за одиницю:";
            // 
            // button_step
            // 
            this.button_step.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button_step.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_step.Font = new System.Drawing.Font("Cascadia Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_step.Location = new System.Drawing.Point(18, 120);
            this.button_step.Name = "button_step";
            this.button_step.Size = new System.Drawing.Size(149, 68);
            this.button_step.TabIndex = 2;
            this.button_step.Text = "←Назад";
            this.button_step.UseVisualStyleBackColor = false;
            this.button_step.Click += new System.EventHandler(this.button_step_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.Brown;
            this.button_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_delete.Font = new System.Drawing.Font("Cascadia Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.Location = new System.Drawing.Point(173, 120);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(504, 68);
            this.button_delete.TabIndex = 3;
            this.button_delete.Text = "Видалити";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // label_workname
            // 
            this.label_workname.AutoSize = true;
            this.label_workname.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_workname.Location = new System.Drawing.Point(223, 19);
            this.label_workname.Name = "label_workname";
            this.label_workname.Size = new System.Drawing.Size(19, 21);
            this.label_workname.TabIndex = 4;
            this.label_workname.Text = "-";
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_score.Location = new System.Drawing.Point(223, 68);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(19, 21);
            this.label_score.TabIndex = 5;
            this.label_score.Text = "-";
            // 
            // delete_workindicator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(694, 194);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.label_workname);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_step);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "delete_workindicator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Видалити показник роботи";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_step;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Label label_workname;
        private System.Windows.Forms.Label label_score;
    }
}