namespace IPOTEKA
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
			this.creditAmountText = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.annualPercentageText = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.startDateText = new System.Windows.Forms.TextBox();
			this.paymentWhen = new System.Windows.Forms.ComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.morgageTermText = new System.Windows.Forms.TextBox();
			this.listView1 = new System.Windows.Forms.ListView();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.paymentText = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// creditAmountText
			// 
			this.creditAmountText.Location = new System.Drawing.Point(118, 27);
			this.creditAmountText.Name = "creditAmountText";
			this.creditAmountText.Size = new System.Drawing.Size(210, 20);
			this.creditAmountText.TabIndex = 0;
			this.creditAmountText.Text = "3660000";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Сумма займа";
			// 
			// annualPercentageText
			// 
			this.annualPercentageText.Location = new System.Drawing.Point(118, 60);
			this.annualPercentageText.Name = "annualPercentageText";
			this.annualPercentageText.Size = new System.Drawing.Size(210, 20);
			this.annualPercentageText.TabIndex = 2;
			this.annualPercentageText.Text = "9,75";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "% годовых";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(267, 211);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 6;
			this.button1.Text = "Посчитать";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(267, 211);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 7;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(15, 132);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Начало кредита";
			// 
			// startDateText
			// 
			this.startDateText.Location = new System.Drawing.Point(118, 129);
			this.startDateText.Name = "startDateText";
			this.startDateText.Size = new System.Drawing.Size(210, 20);
			this.startDateText.TabIndex = 9;
			this.startDateText.Text = "04-09-2019";
			// 
			// paymentWhen
			// 
			this.paymentWhen.FormattingEnabled = true;
			this.paymentWhen.Items.AddRange(new object[] {
            "Каждый месяц",
            "Каждые 2 недели"});
			this.paymentWhen.Location = new System.Drawing.Point(118, 185);
			this.paymentWhen.Name = "paymentWhen";
			this.paymentWhen.Size = new System.Drawing.Size(121, 21);
			this.paymentWhen.TabIndex = 10;
			this.paymentWhen.Text = "Каждый месяц";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.morgageTermText);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.paymentWhen);
			this.groupBox1.Controls.Add(this.creditAmountText);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.startDateText);
			this.groupBox1.Controls.Add(this.annualPercentageText);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(348, 258);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Исходные данные ипотеки";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(15, 162);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(76, 13);
			this.label5.TabIndex = 12;
			this.label5.Text = "Срок ипотеки";
			// 
			// morgageTermText
			// 
			this.morgageTermText.Location = new System.Drawing.Point(118, 159);
			this.morgageTermText.Name = "morgageTermText";
			this.morgageTermText.Size = new System.Drawing.Size(210, 20);
			this.morgageTermText.TabIndex = 11;
			this.morgageTermText.Text = "20";
			// 
			// listView1
			// 
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(243, 316);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(8, 8);
			this.listView1.TabIndex = 12;
			this.listView1.UseCompatibleStateImageBehavior = false;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(366, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(907, 612);
			this.dataGridView1.TabIndex = 14;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.comboBox1);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.textBox2);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.button2);
			this.groupBox2.Controls.Add(this.paymentText);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Location = new System.Drawing.Point(12, 276);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(348, 258);
			this.groupBox2.TabIndex = 15;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Изменения договора";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Каждые 2 недели",
            "Каждый месяц"});
			this.comboBox1.Location = new System.Drawing.Point(170, 103);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 11;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(15, 107);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(127, 13);
			this.label7.TabIndex = 10;
			this.label7.Text = "Дата досрочного вноса";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(170, 77);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(121, 20);
			this.textBox2.TabIndex = 8;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(15, 80);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(134, 13);
			this.label6.TabIndex = 9;
			this.label6.Text = "Я вношу досрочно сумму";
			// 
			// paymentText
			// 
			this.paymentText.Location = new System.Drawing.Point(145, 32);
			this.paymentText.Name = "paymentText";
			this.paymentText.Size = new System.Drawing.Size(183, 20);
			this.paymentText.TabIndex = 3;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(15, 35);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(124, 13);
			this.label10.TabIndex = 5;
			this.label10.Text = "Если я буду платить по";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1298, 647);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox creditAmountText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox annualPercentageText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox startDateText;
        private System.Windows.Forms.ComboBox paymentWhen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox morgageTermText;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox paymentText;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label7;
	}
}

