namespace WindowsFormsApp1
{
    partial class Form1
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
            this.solve = new System.Windows.Forms.Button();
            this.rectangleRadioButton = new System.Windows.Forms.RadioButton();
            this.squareRadioButton = new System.Windows.Forms.RadioButton();
            this.circleRadioButton = new System.Windows.Forms.RadioButton();
            this.triangleRadioButton = new System.Windows.Forms.RadioButton();
            this.a = new System.Windows.Forms.TextBox();
            this.b = new System.Windows.Forms.TextBox();
            this.c = new System.Windows.Forms.TextBox();
            this.label_A = new System.Windows.Forms.Label();
            this.label_B = new System.Windows.Forms.Label();
            this.label_C = new System.Windows.Forms.Label();
            this.solve_figure = new System.Windows.Forms.Button();
            this.convert_lengths = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.label_m_1 = new System.Windows.Forms.Label();
            this.label_m_2 = new System.Windows.Forms.Label();
            this.label_s_2 = new System.Windows.Forms.Label();
            this.label_d_1 = new System.Windows.Forms.Label();
            this.label_s_1 = new System.Windows.Forms.Label();
            this.label_mm_1 = new System.Windows.Forms.Label();
            this.m_1_textBox = new System.Windows.Forms.TextBox();
            this.m_2_textBox = new System.Windows.Forms.TextBox();
            this.s_1_textBox = new System.Windows.Forms.TextBox();
            this.d_textBox = new System.Windows.Forms.TextBox();
            this.s_2_textBox = new System.Windows.Forms.TextBox();
            this.mm_1_textBox = new System.Windows.Forms.TextBox();
            this.button_right = new System.Windows.Forms.Button();
            this.button_left = new System.Windows.Forms.Button();
            this.clean_textbox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // solve
            // 
            this.solve.Location = new System.Drawing.Point(71, 167);
            this.solve.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.solve.Name = "solve";
            this.solve.Size = new System.Drawing.Size(100, 28);
            this.solve.TabIndex = 0;
            this.solve.Text = "Solve";
            this.solve.UseVisualStyleBackColor = true;
            this.solve.Click += new System.EventHandler(this.button1_Click);
            // 
            // rectangleRadioButton
            // 
            this.rectangleRadioButton.AutoSize = true;
            this.rectangleRadioButton.Location = new System.Drawing.Point(7, 51);
            this.rectangleRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rectangleRadioButton.Name = "rectangleRadioButton";
            this.rectangleRadioButton.Size = new System.Drawing.Size(93, 21);
            this.rectangleRadioButton.TabIndex = 1;
            this.rectangleRadioButton.TabStop = true;
            this.rectangleRadioButton.Text = "Rectangle";
            this.rectangleRadioButton.UseVisualStyleBackColor = true;
            this.rectangleRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // squareRadioButton
            // 
            this.squareRadioButton.AutoSize = true;
            this.squareRadioButton.Location = new System.Drawing.Point(7, 80);
            this.squareRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.squareRadioButton.Name = "squareRadioButton";
            this.squareRadioButton.Size = new System.Drawing.Size(75, 21);
            this.squareRadioButton.TabIndex = 2;
            this.squareRadioButton.TabStop = true;
            this.squareRadioButton.Text = "Square";
            this.squareRadioButton.UseVisualStyleBackColor = true;
            this.squareRadioButton.CheckedChanged += new System.EventHandler(this.squareRadioButton_CheckedChanged);
            // 
            // circleRadioButton
            // 
            this.circleRadioButton.AutoSize = true;
            this.circleRadioButton.Location = new System.Drawing.Point(7, 109);
            this.circleRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.circleRadioButton.Name = "circleRadioButton";
            this.circleRadioButton.Size = new System.Drawing.Size(64, 21);
            this.circleRadioButton.TabIndex = 3;
            this.circleRadioButton.TabStop = true;
            this.circleRadioButton.Text = "Circle";
            this.circleRadioButton.UseVisualStyleBackColor = true;
            this.circleRadioButton.CheckedChanged += new System.EventHandler(this.circleRadioButton_CheckedChanged);
            // 
            // triangleRadioButton
            // 
            this.triangleRadioButton.AutoSize = true;
            this.triangleRadioButton.Location = new System.Drawing.Point(7, 138);
            this.triangleRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.triangleRadioButton.Name = "triangleRadioButton";
            this.triangleRadioButton.Size = new System.Drawing.Size(81, 21);
            this.triangleRadioButton.TabIndex = 4;
            this.triangleRadioButton.TabStop = true;
            this.triangleRadioButton.Text = "Triangle";
            this.triangleRadioButton.UseVisualStyleBackColor = true;
            this.triangleRadioButton.CheckedChanged += new System.EventHandler(this.triangleRadioButton_CheckedChanged);
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(168, 51);
            this.a.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(69, 22);
            this.a.TabIndex = 5;
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(168, 81);
            this.b.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(69, 22);
            this.b.TabIndex = 6;
            // 
            // c
            // 
            this.c.Location = new System.Drawing.Point(168, 111);
            this.c.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(69, 22);
            this.c.TabIndex = 9;
            // 
            // label_A
            // 
            this.label_A.AutoSize = true;
            this.label_A.Location = new System.Drawing.Point(144, 53);
            this.label_A.Name = "label_A";
            this.label_A.Size = new System.Drawing.Size(17, 17);
            this.label_A.TabIndex = 10;
            this.label_A.Text = "A";
            // 
            // label_B
            // 
            this.label_B.AutoSize = true;
            this.label_B.Location = new System.Drawing.Point(144, 82);
            this.label_B.Name = "label_B";
            this.label_B.Size = new System.Drawing.Size(17, 17);
            this.label_B.TabIndex = 11;
            this.label_B.Text = "B";
            // 
            // label_C
            // 
            this.label_C.AutoSize = true;
            this.label_C.Location = new System.Drawing.Point(144, 111);
            this.label_C.Name = "label_C";
            this.label_C.Size = new System.Drawing.Size(17, 17);
            this.label_C.TabIndex = 12;
            this.label_C.Text = "C";
            // 
            // solve_figure
            // 
            this.solve_figure.Location = new System.Drawing.Point(62, 51);
            this.solve_figure.Name = "solve_figure";
            this.solve_figure.Size = new System.Drawing.Size(143, 41);
            this.solve_figure.TabIndex = 14;
            this.solve_figure.Text = "solve figure";
            this.solve_figure.UseVisualStyleBackColor = true;
            this.solve_figure.Click += new System.EventHandler(this.button2_Click);
            // 
            // convert_lengths
            // 
            this.convert_lengths.Location = new System.Drawing.Point(62, 95);
            this.convert_lengths.Name = "convert_lengths";
            this.convert_lengths.Size = new System.Drawing.Size(143, 41);
            this.convert_lengths.TabIndex = 16;
            this.convert_lengths.Text = "convert lengths";
            this.convert_lengths.UseVisualStyleBackColor = true;
            this.convert_lengths.Click += new System.EventHandler(this.convert_lengths_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(7, 10);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(64, 34);
            this.back.TabIndex = 17;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label_m_1
            // 
            this.label_m_1.AutoSize = true;
            this.label_m_1.Location = new System.Drawing.Point(4, 56);
            this.label_m_1.Name = "label_m_1";
            this.label_m_1.Size = new System.Drawing.Size(44, 17);
            this.label_m_1.TabIndex = 18;
            this.label_m_1.Text = "Meter";
            this.label_m_1.Click += new System.EventHandler(this.label_m_1_Click);
            // 
            // label_m_2
            // 
            this.label_m_2.AutoSize = true;
            this.label_m_2.Location = new System.Drawing.Point(4, 84);
            this.label_m_2.Name = "label_m_2";
            this.label_m_2.Size = new System.Drawing.Size(44, 17);
            this.label_m_2.TabIndex = 19;
            this.label_m_2.Text = "Meter";
            // 
            // label_s_2
            // 
            this.label_s_2.AutoSize = true;
            this.label_s_2.Location = new System.Drawing.Point(4, 107);
            this.label_s_2.Name = "label_s_2";
            this.label_s_2.Size = new System.Drawing.Size(76, 17);
            this.label_s_2.TabIndex = 20;
            this.label_s_2.Text = "Sentimeter";
            // 
            // label_d_1
            // 
            this.label_d_1.AutoSize = true;
            this.label_d_1.Location = new System.Drawing.Point(129, 56);
            this.label_d_1.Name = "label_d_1";
            this.label_d_1.Size = new System.Drawing.Size(72, 17);
            this.label_d_1.TabIndex = 21;
            this.label_d_1.Text = "Decimeter";
            // 
            // label_s_1
            // 
            this.label_s_1.AutoSize = true;
            this.label_s_1.Location = new System.Drawing.Point(129, 81);
            this.label_s_1.Name = "label_s_1";
            this.label_s_1.Size = new System.Drawing.Size(76, 17);
            this.label_s_1.TabIndex = 22;
            this.label_s_1.Text = "Sentimeter";
            // 
            // label_mm_1
            // 
            this.label_mm_1.AutoSize = true;
            this.label_mm_1.Location = new System.Drawing.Point(131, 109);
            this.label_mm_1.Name = "label_mm_1";
            this.label_mm_1.Size = new System.Drawing.Size(64, 17);
            this.label_mm_1.TabIndex = 23;
            this.label_mm_1.Text = "Milimeter";
            // 
            // m_1_textBox
            // 
            this.m_1_textBox.Location = new System.Drawing.Point(82, 51);
            this.m_1_textBox.Name = "m_1_textBox";
            this.m_1_textBox.Size = new System.Drawing.Size(43, 22);
            this.m_1_textBox.TabIndex = 24;
            // 
            // m_2_textBox
            // 
            this.m_2_textBox.Location = new System.Drawing.Point(82, 77);
            this.m_2_textBox.Name = "m_2_textBox";
            this.m_2_textBox.Size = new System.Drawing.Size(43, 22);
            this.m_2_textBox.TabIndex = 25;
            // 
            // s_1_textBox
            // 
            this.s_1_textBox.Location = new System.Drawing.Point(82, 106);
            this.s_1_textBox.Name = "s_1_textBox";
            this.s_1_textBox.Size = new System.Drawing.Size(43, 22);
            this.s_1_textBox.TabIndex = 26;
            // 
            // d_textBox
            // 
            this.d_textBox.Location = new System.Drawing.Point(207, 50);
            this.d_textBox.Name = "d_textBox";
            this.d_textBox.Size = new System.Drawing.Size(43, 22);
            this.d_textBox.TabIndex = 27;
            // 
            // s_2_textBox
            // 
            this.s_2_textBox.Location = new System.Drawing.Point(207, 79);
            this.s_2_textBox.Name = "s_2_textBox";
            this.s_2_textBox.Size = new System.Drawing.Size(43, 22);
            this.s_2_textBox.TabIndex = 28;
            // 
            // mm_1_textBox
            // 
            this.mm_1_textBox.Location = new System.Drawing.Point(207, 108);
            this.mm_1_textBox.Name = "mm_1_textBox";
            this.mm_1_textBox.Size = new System.Drawing.Size(43, 22);
            this.mm_1_textBox.TabIndex = 29;
            // 
            // button_right
            // 
            this.button_right.Location = new System.Drawing.Point(88, 12);
            this.button_right.Name = "button_right";
            this.button_right.Size = new System.Drawing.Size(43, 23);
            this.button_right.TabIndex = 30;
            this.button_right.Text = ">";
            this.button_right.UseVisualStyleBackColor = true;
            this.button_right.Click += new System.EventHandler(this.button_right_Click);
            // 
            // button_left
            // 
            this.button_left.Location = new System.Drawing.Point(137, 12);
            this.button_left.Name = "button_left";
            this.button_left.Size = new System.Drawing.Size(43, 23);
            this.button_left.TabIndex = 31;
            this.button_left.Text = "<";
            this.button_left.UseVisualStyleBackColor = true;
            this.button_left.Click += new System.EventHandler(this.button_left_Click);
            // 
            // clean_textbox
            // 
            this.clean_textbox.Location = new System.Drawing.Point(185, 12);
            this.clean_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clean_textbox.Name = "clean_textbox";
            this.clean_textbox.Size = new System.Drawing.Size(67, 23);
            this.clean_textbox.TabIndex = 32;
            this.clean_textbox.Text = "clean";
            this.clean_textbox.UseVisualStyleBackColor = true;
            this.clean_textbox.Click += new System.EventHandler(this.clean_textbox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 199);
            this.Controls.Add(this.clean_textbox);
            this.Controls.Add(this.button_left);
            this.Controls.Add(this.button_right);
            this.Controls.Add(this.mm_1_textBox);
            this.Controls.Add(this.s_2_textBox);
            this.Controls.Add(this.d_textBox);
            this.Controls.Add(this.s_1_textBox);
            this.Controls.Add(this.m_2_textBox);
            this.Controls.Add(this.m_1_textBox);
            this.Controls.Add(this.label_mm_1);
            this.Controls.Add(this.label_s_1);
            this.Controls.Add(this.label_d_1);
            this.Controls.Add(this.label_s_2);
            this.Controls.Add(this.label_m_2);
            this.Controls.Add(this.label_m_1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.convert_lengths);
            this.Controls.Add(this.solve_figure);
            this.Controls.Add(this.label_C);
            this.Controls.Add(this.label_B);
            this.Controls.Add(this.label_A);
            this.Controls.Add(this.c);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Controls.Add(this.triangleRadioButton);
            this.Controls.Add(this.circleRadioButton);
            this.Controls.Add(this.squareRadioButton);
            this.Controls.Add(this.rectangleRadioButton);
            this.Controls.Add(this.solve);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button solve;
        private System.Windows.Forms.RadioButton rectangleRadioButton;
        private System.Windows.Forms.RadioButton squareRadioButton;
        private System.Windows.Forms.RadioButton circleRadioButton;
        private System.Windows.Forms.RadioButton triangleRadioButton;
        private System.Windows.Forms.TextBox a;
        private System.Windows.Forms.TextBox b;
        private System.Windows.Forms.TextBox c;
        private System.Windows.Forms.Label label_A;
        private System.Windows.Forms.Label label_B;
        private System.Windows.Forms.Label label_C;
        private System.Windows.Forms.Button solve_figure;
        private System.Windows.Forms.Button convert_lengths;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label_m_1;
        private System.Windows.Forms.Label label_m_2;
        private System.Windows.Forms.Label label_s_2;
        private System.Windows.Forms.Label label_d_1;
        private System.Windows.Forms.Label label_s_1;
        private System.Windows.Forms.Label label_mm_1;
        private System.Windows.Forms.TextBox m_1_textBox;
        private System.Windows.Forms.TextBox m_2_textBox;
        private System.Windows.Forms.TextBox s_1_textBox;
        private System.Windows.Forms.TextBox d_textBox;
        private System.Windows.Forms.TextBox s_2_textBox;
        private System.Windows.Forms.TextBox mm_1_textBox;
        private System.Windows.Forms.Button button_right;
        private System.Windows.Forms.Button button_left;
        private System.Windows.Forms.Button clean_textbox;
    }
}

