
namespace winFormCrypto
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
            this.txt_box_param = new System.Windows.Forms.TextBox();
            this.txt_box_step = new System.Windows.Forms.TextBox();
            this.checkBox_left = new System.Windows.Forms.CheckBox();
            this.checkBox_right = new System.Windows.Forms.CheckBox();
            this.checkBox_russian = new System.Windows.Forms.CheckBox();
            this.checkBox_english = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_run = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_box_param
            // 
            this.txt_box_param.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_box_param.Location = new System.Drawing.Point(131, 90);
            this.txt_box_param.Name = "txt_box_param";
            this.txt_box_param.Size = new System.Drawing.Size(205, 31);
            this.txt_box_param.TabIndex = 0;
            // 
            // txt_box_step
            // 
            this.txt_box_step.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_box_step.Location = new System.Drawing.Point(131, 137);
            this.txt_box_step.Name = "txt_box_step";
            this.txt_box_step.Size = new System.Drawing.Size(205, 31);
            this.txt_box_step.TabIndex = 1;
            // 
            // checkBox_left
            // 
            this.checkBox_left.AutoSize = true;
            this.checkBox_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_left.Location = new System.Drawing.Point(142, 194);
            this.checkBox_left.Name = "checkBox_left";
            this.checkBox_left.Size = new System.Drawing.Size(71, 22);
            this.checkBox_left.TabIndex = 2;
            this.checkBox_left.Text = "Влево";
            this.checkBox_left.UseVisualStyleBackColor = true;
            this.checkBox_left.CheckedChanged += new System.EventHandler(this.checkBox_left_CheckedChanged);
            // 
            // checkBox_right
            // 
            this.checkBox_right.AutoSize = true;
            this.checkBox_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_right.Location = new System.Drawing.Point(232, 194);
            this.checkBox_right.Name = "checkBox_right";
            this.checkBox_right.Size = new System.Drawing.Size(78, 22);
            this.checkBox_right.TabIndex = 3;
            this.checkBox_right.Text = "Вправо";
            this.checkBox_right.UseVisualStyleBackColor = true;
            this.checkBox_right.CheckedChanged += new System.EventHandler(this.checkBox_right_CheckedChanged);
            // 
            // checkBox_russian
            // 
            this.checkBox_russian.AutoSize = true;
            this.checkBox_russian.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_russian.Location = new System.Drawing.Point(142, 222);
            this.checkBox_russian.Name = "checkBox_russian";
            this.checkBox_russian.Size = new System.Drawing.Size(84, 22);
            this.checkBox_russian.TabIndex = 4;
            this.checkBox_russian.Text = "Русский";
            this.checkBox_russian.UseVisualStyleBackColor = true;
            this.checkBox_russian.CheckedChanged += new System.EventHandler(this.checkBox_russian_CheckedChanged);
            // 
            // checkBox_english
            // 
            this.checkBox_english.AutoSize = true;
            this.checkBox_english.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_english.Location = new System.Drawing.Point(232, 222);
            this.checkBox_english.Name = "checkBox_english";
            this.checkBox_english.Size = new System.Drawing.Size(75, 22);
            this.checkBox_english.TabIndex = 5;
            this.checkBox_english.Text = "English";
            this.checkBox_english.UseVisualStyleBackColor = true;
            this.checkBox_english.CheckedChanged += new System.EventHandler(this.checkBox_english_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(43, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Put Param:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(57, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Put Step:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(38, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Result: ";
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(131, 22);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(158, 44);
            this.btn_run.TabIndex = 9;
            this.btn_run.Text = "Run";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 369);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox_english);
            this.Controls.Add(this.checkBox_russian);
            this.Controls.Add(this.checkBox_right);
            this.Controls.Add(this.checkBox_left);
            this.Controls.Add(this.txt_box_step);
            this.Controls.Add(this.txt_box_param);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_box_param;
        private System.Windows.Forms.TextBox txt_box_step;
        private System.Windows.Forms.CheckBox checkBox_left;
        private System.Windows.Forms.CheckBox checkBox_right;
        private System.Windows.Forms.CheckBox checkBox_russian;
        private System.Windows.Forms.CheckBox checkBox_english;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_run;
    }
}

