using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private void visible_all(bool turn)
        {
            a.Visible = turn;
            b.Visible = turn;
            c.Visible = turn;
            rectangleRadioButton.Visible = turn;
            circleRadioButton.Visible = turn;
            squareRadioButton.Visible = turn;
            triangleRadioButton.Visible = turn;
            label_A.Visible = turn;
            label_B.Visible = turn;
            label_C.Visible = turn;
            solve.Visible = turn;
            back.Visible = turn;
            button_left.Visible = turn;
            button_right.Visible = turn;
            clean_textbox.Visible = turn;

        }
        private void visible_convert_length(bool turn)
        {
            button_right.Visible = turn;
            button_left.Visible = turn;
            label_m_1.Visible = turn;
            label_m_2.Visible = turn;
            label_s_1.Visible = turn;
            label_s_2.Visible = turn;
            label_mm_1.Visible = turn;
            label_d_1.Visible = turn;
            s_1_textBox.Visible = turn;
            s_2_textBox.Visible = turn;
            m_1_textBox.Visible = turn;
            m_2_textBox.Visible = turn;
            mm_1_textBox.Visible = turn;
            d_textBox.Visible = turn;
            clean_textbox.Visible = turn;
            back.Visible = turn;
        }
        public Form1()
        {
            InitializeComponent();
            visible_all(false);
            visible_convert_length(false);
        }
        private void clean()
        {
            a.Text = "";
            b.Text = "";
            c.Text = "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            clean();
            label_A.Text = "A";
            a.Visible = true;
            b.Visible = true;
            c.Visible = false;
            label_C.Visible = false;
            label_B.Visible = true;
            label_A.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (rectangleRadioButton.Checked == true)
            {
                c.Visible = false;
                label_C.Visible=false;
                Shape rectangle = new Shape();
                rectangle.A = float.Parse(a.Text);
                rectangle.B = float.Parse(b.Text);  
                string s = rectangle.RectangleArea().ToString();
                string p = rectangle.RectanglePerimeter().ToString();
                string d = rectangle.RectangleDiagonal().ToString();
                Form2.a = rectangle.A;
                Form2.b = rectangle.B;
                Form2.s = s;
                Form2.p = p;
                Form2.d = d;
                Form2.mod = "rectangle";
                Form2 fm = new Form2();
                fm.ShowDialog();
                clean();
            }
            if (squareRadioButton.Checked == true)
            {
                c.Visible = false;
                Shape square = new Shape();
                square.A = float.Parse(a.Text);
                string s = square.SquareArea().ToString();
                string p = square.SquarePerimeter().ToString();
                string d = square.SquareDiagonal().ToString();
                Form2.a = square.A;
                Form2.s = s;
                Form2.p = p;
                Form2.d = d;
                Form2.mod = "square";
                Form2 fm = new Form2();
                fm.ShowDialog();
                clean();
            }
            if (triangleRadioButton.Checked == true)
            {
                c.Visible = true;
                Shape triangle = new Shape();
                triangle.A = float.Parse(a.Text);
                triangle.B = float.Parse(b.Text);
                triangle.C = float.Parse(c.Text);
                string s = triangle.SquareArea().ToString();
                string p = triangle.SquarePerimeter().ToString();
                string d = triangle.SquareDiagonal().ToString();

                Form2.a = triangle.A;
                Form2.b = triangle.B;
                Form2.c = triangle.C;
                Form2.s = s;
                Form2.p = p;
                Form2.d = d;
                Form2.sin_ABC = triangle.sin_ABC();
                Form2.sin_ACB = triangle.sin_ACB();
                Form2.sin_BAC = triangle.sin_BAC();
                Form2.cos_ABC = triangle.cos_ABC();
                Form2.cos_ACB = triangle.cos_ACB();
                Form2.cos_BAC = triangle.cos_BAC();
                Form2.mod = "triangle";
                Form2 fm = new Form2();
                fm.ShowDialog();
                clean();
            }
            if (circleRadioButton.Checked == true)
            {
                c.Visible = false;
                b.Visible = false;
                Shape circle = new Shape();
                circle.R = float.Parse(a.Text);
                string s = circle.CircleArea().ToString();
                Form2.r = circle.R;
                Form2.s = s;
                Form2.mod = "circle";
                Form2 fm = new Form2();
                fm.ShowDialog();
                clean();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clean_textbox.Visible = false;
            a.Visible = false;
            b.Visible = false;
            c.Visible = false;
            rectangleRadioButton.Visible = true;
            circleRadioButton.Visible = true;
            squareRadioButton.Visible = true;
            triangleRadioButton.Visible = true;
            label_A.Visible = false;
            label_B.Visible = false;
            label_C.Visible = false;
            solve.Visible = true;
            solve_figure.Visible = false;
            convert_lengths.Visible = false;
            back.Visible = true;
        }

        private void back_Click(object sender, EventArgs e)
        {
            visible_convert_length(false);
            rectangleRadioButton.Checked = false;
            squareRadioButton.Checked = false;
            triangleRadioButton.Checked = false;
            circleRadioButton.Checked = false;
            a.Visible = false;
            b.Visible = false;
            c.Visible = false;
            rectangleRadioButton.Visible = false;
            circleRadioButton.Visible = false;
            squareRadioButton.Visible = false;
            triangleRadioButton.Visible = false;
            label_A.Visible = false;
            label_B.Visible = false;
            label_C.Visible = false;
            solve.Visible = false;
            back.Visible = false;
            solve_figure.Visible = true;
            convert_lengths.Visible = true;
            clean_textbox.Visible = false;
        }

        private void squareRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            clean();
            label_A.Text = "A";
            a.Visible = true;
            b.Visible = false;
            c.Visible = false;
            label_C.Visible = false;
            label_B.Visible = false;
            label_A.Visible = true;
        }

        private void circleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            clean();
            a.Visible = true;
            b.Visible = false;
            c.Visible = false;
            label_C.Visible = false;
            label_B.Visible = false;
            label_A.Text = "R";
            label_A.Visible = true;
        }

        private void triangleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            clean();
            label_A.Text = "A";
            a.Visible = true;
            b.Visible = true;
            c.Visible = true;
            label_C.Visible = true;
            label_B.Visible = true;
            label_A.Visible = true;
        }

        private void convert_lengths_Click(object sender, EventArgs e)
        {
            visible_all(false);
            visible_convert_length(true);
            solve_figure.Visible = false;
            convert_lengths.Visible = false;
            button_left.Visible = true;
            button_right.Visible = true;
            d_textBox.Text = m_1_textBox.Text;
        }
        public void textbox_lengths_clean()
        {
            s_1_textBox.Text = "";
            s_2_textBox.Text = "";
            mm_1_textBox.Text = "";
            d_textBox.Text = "";
            m_1_textBox.Text = "";
            m_2_textBox.Text = "";
        }
        private void button_right_Click(object sender, EventArgs e)
        {
            
            if (m_1_textBox.Text.Length != 0)
            {
                lengths meter_to_decimeter = new lengths();
                meter_to_decimeter.meter = double.Parse(m_1_textBox.Text);
                d_textBox.Text = meter_to_decimeter.meter_to_Decimeter().ToString();
            }
            //-------------------------------------------------------------------
            if (m_2_textBox.Text.Length != 0)
            {
                lengths meter_to_sentimeter = new lengths();
                meter_to_sentimeter.meter = double.Parse(m_2_textBox.Text);
                s_2_textBox.Text = meter_to_sentimeter.meter_to_sentimeter().ToString();
            }
            //-------------------------------------------------------------------
            if (s_1_textBox.Text.Length != 0)
            {
                lengths sentimeter_to_milimeter = new lengths();
                sentimeter_to_milimeter.sentimeter = double.Parse(s_1_textBox.Text);
                mm_1_textBox.Text = sentimeter_to_milimeter.sentimeter_to_milimeter().ToString();
            }
        }

        private void button_left_Click(object sender, EventArgs e)
        {
            
            if (d_textBox.Text.Length != 0)
            {
                lengths decimeter_to_meter = new lengths();
                decimeter_to_meter.decimeter = double.Parse(d_textBox.Text);
                m_1_textBox.Text = decimeter_to_meter.Decimeter_to_meter().ToString();
            }
            //--------------------------------------------------------------------
            if (s_2_textBox.Text.Length != 0)
            {
                lengths sentimeter_to_meter = new lengths();
                sentimeter_to_meter.sentimeter = double.Parse(s_2_textBox.Text);
                m_2_textBox.Text = sentimeter_to_meter.sentimeter_to_meter().ToString();
            }
            //--------------------------------------------------------------------
            if (mm_1_textBox.Text.Length != 0)
            {
                lengths milimeter_to_sentimeter = new lengths();
                milimeter_to_sentimeter.milimeter = double.Parse(mm_1_textBox.Text);
                s_1_textBox.Text = milimeter_to_sentimeter.milimeter_to_sentimeter().ToString();
            }
        }

        private void clean_textbox_Click(object sender, EventArgs e)
        {
            textbox_lengths_clean();
        }

        private void label_m_1_Click(object sender, EventArgs e)
        {

        }
    }
}
