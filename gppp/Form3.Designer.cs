namespace gppp
{
    partial class Form3
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
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            button3 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox8
            // 
            textBox8.Location = new Point(384, 219);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(192, 27);
            textBox8.TabIndex = 31;
            textBox8.TextChanged += textBox8_TextChanged;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(384, 176);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(192, 27);
            textBox7.TabIndex = 30;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(384, 134);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(192, 27);
            textBox6.TabIndex = 29;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label11.Location = new Point(267, 222);
            label11.Name = "label11";
            label11.Size = new Size(61, 24);
            label11.TabIndex = 28;
            label11.Text = "Süre:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(267, 176);
            label10.Name = "label10";
            label10.Size = new Size(63, 24);
            label10.TabIndex = 27;
            label10.Text = "Fiyat:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.Location = new Point(267, 137);
            label9.Name = "label9";
            label9.Size = new Size(111, 24);
            label9.TabIndex = 26;
            label9.Text = "Servis Adı:";
            // 
            // button3
            // 
            button3.BackColor = Color.LightPink;
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button3.Location = new Point(406, 301);
            button3.Name = "button3";
            button3.Size = new Size(125, 45);
            button3.TabIndex = 25;
            button3.Text = "EKLE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(366, 20);
            label1.Name = "label1";
            label1.Size = new Size(165, 33);
            label1.TabIndex = 32;
            label1.Text = "SERVİS EKLE";
            label1.Click += label1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(889, 440);
            Controls.Add(label1);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(button3);
            Name = "Form3";
            Text = "SERVİS";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private Label label11;
        private Label label10;
        private Label label9;
        private Button button3;
        private Label label1;
    }
}