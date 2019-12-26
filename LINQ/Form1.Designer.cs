namespace LINQ
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Q29 = new System.Windows.Forms.Button();
            this.btn_Q30 = new System.Windows.Forms.Button();
            this.textBox_time = new System.Windows.Forms.TextBox();
            this.checkBox_Plinq = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 358);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_Q29
            // 
            this.btn_Q29.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Q29.Location = new System.Drawing.Point(13, 378);
            this.btn_Q29.Name = "btn_Q29";
            this.btn_Q29.Size = new System.Drawing.Size(75, 23);
            this.btn_Q29.TabIndex = 1;
            this.btn_Q29.Text = "Q29";
            this.btn_Q29.UseVisualStyleBackColor = true;
            this.btn_Q29.Click += new System.EventHandler(this.btn_Q29_Click);
            // 
            // btn_Q30
            // 
            this.btn_Q30.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Q30.Location = new System.Drawing.Point(12, 407);
            this.btn_Q30.Name = "btn_Q30";
            this.btn_Q30.Size = new System.Drawing.Size(75, 23);
            this.btn_Q30.TabIndex = 2;
            this.btn_Q30.Text = "Q30";
            this.btn_Q30.UseVisualStyleBackColor = true;
            this.btn_Q30.Click += new System.EventHandler(this.btn_Q30_Click);
            // 
            // textBox_time
            // 
            this.textBox_time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_time.Location = new System.Drawing.Point(95, 380);
            this.textBox_time.Name = "textBox_time";
            this.textBox_time.ReadOnly = true;
            this.textBox_time.Size = new System.Drawing.Size(100, 20);
            this.textBox_time.TabIndex = 3;
            // 
            // checkBox_Plinq
            // 
            this.checkBox_Plinq.AutoSize = true;
            this.checkBox_Plinq.Location = new System.Drawing.Point(95, 412);
            this.checkBox_Plinq.Name = "checkBox_Plinq";
            this.checkBox_Plinq.Size = new System.Drawing.Size(58, 17);
            this.checkBox_Plinq.TabIndex = 4;
            this.checkBox_Plinq.Text = "PLINQ";
            this.checkBox_Plinq.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox_Plinq);
            this.Controls.Add(this.textBox_time);
            this.Controls.Add(this.btn_Q30);
            this.Controls.Add(this.btn_Q29);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Q29;
        private System.Windows.Forms.Button btn_Q30;
        private System.Windows.Forms.TextBox textBox_time;
        private System.Windows.Forms.CheckBox checkBox_Plinq;
    }
}

