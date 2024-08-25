namespace gppp
{
    partial class Form4
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
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            textBox5 = new TextBox();
            button2 = new Button();
            dateTimePicker1 = new DateTimePicker();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Control;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold);
            label8.Location = new Point(216, 221);
            label8.Name = "label8";
            label8.Size = new Size(74, 24);
            label8.TabIndex = 26;
            label8.Text = "Notlar:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Control;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold);
            label7.Location = new Point(131, 171);
            label7.Name = "label7";
            label7.Size = new Size(159, 24);
            label7.TabIndex = 25;
            label7.Text = "Randevu Tarihi:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold);
            label6.Location = new Point(168, 127);
            label6.Name = "label6";
            label6.Size = new Size(122, 24);
            label6.TabIndex = 24;
            label6.Text = "Hizmet Seç:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold);
            label5.Location = new Point(161, 80);
            label5.Name = "label5";
            label5.Size = new Size(129, 24);
            label5.TabIndex = 23;
            label5.Text = "Müşteri Seç:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(334, 221);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(192, 27);
            textBox5.TabIndex = 22;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.LightPink;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            button2.Location = new Point(380, 313);
            button2.Name = "button2";
            button2.Size = new Size(146, 45);
            button2.TabIndex = 21;
            button2.Text = "OLUŞTUR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(334, 171);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 20;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(334, 123);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(192, 28);
            comboBox2.TabIndex = 19;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(334, 76);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(192, 28);
            comboBox1.TabIndex = 18;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(291, 9);
            label1.Name = "label1";
            label1.Size = new Size(235, 33);
            label1.TabIndex = 27;
            label1.Text = "RANDEVU EKLE";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(button2);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Name = "Form4";
            Text = "RANDEVU EKLE";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox textBox5;
        private Button button2;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label1;
    }
}