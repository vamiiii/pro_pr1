namespace WinFormsApp1
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            groupBox1 = new GroupBox();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            groupBox2 = new GroupBox();
            button7 = new Button();
            button10 = new Button();
            button11 = new Button();
            groupBox3 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox5 = new GroupBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            bindingSource1 = new BindingSource(components);
            groupBox6 = new GroupBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(49, 28);
            button1.TabIndex = 0;
            button1.Text = "...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox6);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Location = new Point(12, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(167, 230);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "menu";
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 7F);
            button5.Location = new Point(7, 170);
            button5.Name = "button5";
            button5.Size = new Size(142, 42);
            button5.TabIndex = 2;
            button5.Text = "Настройка цвета 🎨";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 7F);
            button4.Location = new Point(6, 122);
            button4.Name = "button4";
            button4.Size = new Size(143, 42);
            button4.TabIndex = 3;
            button4.Text = "Контакты компании 📱";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(6, 74);
            button3.Name = "button3";
            button3.Size = new Size(143, 42);
            button3.TabIndex = 2;
            button3.Text = "Задачи \U0001f9d0";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(6, 26);
            button2.Name = "button2";
            button2.Size = new Size(143, 42);
            button2.TabIndex = 1;
            button2.Text = "Профиль 😊";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button7);
            groupBox2.Controls.Add(button10);
            groupBox2.Controls.Add(button11);
            groupBox2.Location = new Point(173, 202);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(414, 87);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "menu цвета";
            // 
            // button7
            // 
            button7.Location = new Point(274, 26);
            button7.Name = "button7";
            button7.Size = new Size(128, 42);
            button7.TabIndex = 3;
            button7.Text = "Синий";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button10
            // 
            button10.Location = new Point(140, 26);
            button10.Name = "button10";
            button10.Size = new Size(128, 42);
            button10.TabIndex = 2;
            button10.Text = "Красный";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Location = new Point(6, 26);
            button11.Name = "button11";
            button11.Size = new Size(128, 42);
            button11.TabIndex = 1;
            button11.Text = "Зеленый";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(173, 49);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(414, 94);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "menu профиль";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 71);
            label3.Name = "label3";
            label3.Size = new Size(158, 20);
            label3.TabIndex = 2;
            label3.Text = "Контакт: 89222222222";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 48);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 1;
            label2.Text = "Имя: Александр";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(155, 20);
            label1.TabIndex = 0;
            label1.Text = "Фамилия: Лазаренко";
            label1.Click += label1_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label7);
            groupBox5.Controls.Add(label8);
            groupBox5.Controls.Add(label9);
            groupBox5.Location = new Point(179, 150);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(414, 94);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "menu контакты";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 71);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 2;
            label7.Text = "Контакт 3";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 48);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 1;
            label8.Text = "Контакт 2";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 23);
            label9.Name = "label9";
            label9.Size = new Size(75, 20);
            label9.TabIndex = 0;
            label9.Text = "Контакт 1";
            label9.Click += label9_Click;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(label10);
            groupBox6.Controls.Add(label11);
            groupBox6.Controls.Add(label12);
            groupBox6.Location = new Point(161, 43);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(414, 94);
            groupBox6.TabIndex = 5;
            groupBox6.TabStop = false;
            groupBox6.Text = "menu задач";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 71);
            label10.Name = "label10";
            label10.Size = new Size(151, 20);
            label10.TabIndex = 2;
            label10.Text = "Продать программу";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 48);
            label11.Name = "label11";
            label11.Size = new Size(147, 20);
            label11.TabIndex = 1;
            label11.Text = "Сделать программу";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 23);
            label12.Name = "label12";
            label12.Size = new Size(169, 20);
            label12.TabIndex = 0;
            label12.Text = "Придумать программу";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox5);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private GroupBox groupBox1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private GroupBox groupBox2;
        private Button button7;
        private Button button10;
        private Button button11;
        private GroupBox groupBox3;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox5;
        private Label label7;
        private Label label8;
        private Label label9;
        private BindingSource bindingSource1;
        private GroupBox groupBox6;
        private Label label10;
        private Label label11;
        private Label label12;
    }
}
