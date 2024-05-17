namespace Week2_Project1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grossIncomeLabel = new System.Windows.Forms.Label();
            this.grossIncomeText = new System.Windows.Forms.TextBox();
            this.w2Text = new System.Windows.Forms.TextBox();
            this.w2Label = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.Next = new System.Windows.Forms.Button();
            this.deductables = new System.Windows.Forms.Label();
            this.deductableText = new System.Windows.Forms.TextBox();
            this.moreButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(267, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(62, 38);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(138, 19);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Married Fiiling Jointly";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(62, 63);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(57, 19);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Single";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(182, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 105);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please Select an Option Below";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // grossIncomeLabel
            // 
            this.grossIncomeLabel.AutoSize = true;
            this.grossIncomeLabel.Location = new System.Drawing.Point(182, 227);
            this.grossIncomeLabel.Name = "grossIncomeLabel";
            this.grossIncomeLabel.Size = new System.Drawing.Size(79, 15);
            this.grossIncomeLabel.TabIndex = 3;
            this.grossIncomeLabel.Text = "Gross Income";
            this.grossIncomeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // grossIncomeText
            // 
            this.grossIncomeText.Location = new System.Drawing.Point(292, 224);
            this.grossIncomeText.Name = "grossIncomeText";
            this.grossIncomeText.Size = new System.Drawing.Size(160, 23);
            this.grossIncomeText.TabIndex = 5;
            this.grossIncomeText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // w2Text
            // 
            this.w2Text.Location = new System.Drawing.Point(387, 185);
            this.w2Text.Name = "w2Text";
            this.w2Text.Size = new System.Drawing.Size(100, 23);
            this.w2Text.TabIndex = 6;
            this.w2Text.TextChanged += new System.EventHandler(this.w2Text_TextChanged);
            // 
            // w2Label
            // 
            this.w2Label.AutoSize = true;
            this.w2Label.Location = new System.Drawing.Point(214, 185);
            this.w2Label.Name = "w2Label";
            this.w2Label.Size = new System.Drawing.Size(168, 15);
            this.w2Label.TabIndex = 7;
            this.w2Label.Text = "How Many w2s are you filling?";
            this.w2Label.Click += new System.EventHandler(this.w2Label_Click);
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(598, 232);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(32, 15);
            this.Total.TabIndex = 8;
            this.Total.Text = "Total";
            this.Total.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(491, 224);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 9;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // deductables
            // 
            this.deductables.AutoSize = true;
            this.deductables.Location = new System.Drawing.Point(182, 287);
            this.deductables.Name = "deductables";
            this.deductables.Size = new System.Drawing.Size(128, 15);
            this.deductables.TabIndex = 10;
            this.deductables.Text = "Enter your deductables";
            this.deductables.Click += new System.EventHandler(this.deductables_Click);
            // 
            // deductableText
            // 
            this.deductableText.Location = new System.Drawing.Point(316, 284);
            this.deductableText.Name = "deductableText";
            this.deductableText.Size = new System.Drawing.Size(100, 23);
            this.deductableText.TabIndex = 11;
            this.deductableText.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // moreButton
            // 
            this.moreButton.Location = new System.Drawing.Point(433, 283);
            this.moreButton.Name = "moreButton";
            this.moreButton.Size = new System.Drawing.Size(94, 24);
            this.moreButton.TabIndex = 12;
            this.moreButton.Text = "Add More...";
            this.moreButton.UseVisualStyleBackColor = true;
            this.moreButton.Click += new System.EventHandler(this.moreButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 399);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "label7";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 209);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(52, 238);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 21;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(52, 267);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 22;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(52, 300);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 23);
            this.textBox4.TabIndex = 23;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(52, 332);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 23);
            this.textBox5.TabIndex = 24;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(52, 362);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 23);
            this.textBox6.TabIndex = 25;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(52, 391);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 23);
            this.textBox7.TabIndex = 26;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 453);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.moreButton);
            this.Controls.Add(this.deductableText);
            this.Controls.Add(this.deductables);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.w2Label);
            this.Controls.Add(this.w2Text);
            this.Controls.Add(this.grossIncomeText);
            this.Controls.Add(this.grossIncomeLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private GroupBox groupBox1;
        private Label grossIncomeLabel;
        private TextBox grossIncomeText;
        private TextBox w2Text;
        private Label w2Label;
        private Label Total;
        private Button Next;
        private Label deductables;
        private TextBox deductableText;
        private Button moreButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
    }
}