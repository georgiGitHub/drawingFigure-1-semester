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

    public partial class Form2 : Form
    {
        public static string s;
        public static string p;
        public static string d;
        public static float a;
        public static float b;
        public static float c;
        public static float r;
        public static int draw_way;
        public static string mod;
        public static double sin_ABC;
        public static double sin_ACB;
        public static double sin_BAC;
        public static double cos_ABC;
        public static double cos_ACB;
        public static double cos_BAC;
        public Form2()
        {
            InitializeComponent();
        }
        private void visible_sin_cos(bool turn)
        {
            sin_1_label.Visible = turn;
            sin_2_label.Visible = turn;
            sin_3_label.Visible = turn;
            cos_1_label.Visible = turn;
            cos_2_label.Visible = turn;
            cos_3_label.Visible = turn;
        }
        private void visible(bool turn)
        {
            labelS.Visible = turn;
            labelP.Visible = turn;
            labelD.Visible = turn;
            S_label.Visible = turn;
            D_label.Visible = turn;
            P_label.Visible = turn;
        }
        private void Form2_Load_1(object sender, EventArgs e)
        {
            visible(false);
            visible_sin_cos(false);
            if (mod == "rectangle")
            {
                visible(true);
                S_label.Text = s;
                P_label.Text = p;
                D_label.Text = d;
                draw_way = 0;
            }
            if (mod == "square")
            {
                visible(true);
                S_label.Text = s;
                P_label.Text = p;
                D_label.Text = d;
                draw_way = 0;
            }
            if (mod == "triangle")
            {
                visible(true);
                visible_sin_cos(true);
                labelD.Visible = false;
                D_label.Visible = false;
                S_label.Text = s;
                P_label.Text = p;
                sin_ABC_text.Text = sin_ABC.ToString();
                sin_ACB_text.Text = sin_ACB.ToString();
                sin_BAC_text.Text = sin_BAC.ToString();
                cos_ABC_text.Text = cos_ABC.ToString();
                cos_ACB_text.Text = cos_ACB.ToString();
                cos_BAC_text.Text = cos_BAC.ToString();
                draw_way = 0;
            }
            if (mod == "circle")
            {
                visible(false);
                labelS.Visible = true;
                S_label.Visible = true;
                S_label.Text = s;
                draw_way = 0;
            }
        }
        private void D_textbox_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void Form2_MouseUp_1(object sender, MouseEventArgs e)
        {
            if (mod == "rectangle")
            {
                Rectangle_draw rectangle_draw = new Rectangle_draw();
                rectangle_draw.Location = e.Location;
                rectangle_draw.A = a;
                rectangle_draw.B = b;
                if (e.Button == MouseButtons.Right && draw_way == 0)
                {
                    draw_way = 1;
                    using (var graphics = CreateGraphics())
                    {
                        rectangle_draw.Paint(graphics);
                    }
                }
            }
            if (mod == "square")
            {
                Square_draw square_draw = new Square_draw();
                square_draw.Location = e.Location;
                square_draw.A = a;
                if (e.Button == MouseButtons.Right && draw_way == 0)
                {
                    draw_way = 1;
                    using (var graphics = CreateGraphics())
                    {
                        square_draw.Paint(graphics);
                    }
                }
            }
            if (mod == "triangle")
            {
                Triangle_draw triangle_draw = new Triangle_draw();
                triangle_draw.Location = e.Location;
                triangle_draw.A = a;
                triangle_draw.B = b;
                triangle_draw.C = c;
                if (e.Button == MouseButtons.Right && draw_way == 0)
                {
                    draw_way = 1;
                    using (var graphics = CreateGraphics())
                    {
                        triangle_draw.Paint(graphics);
                    }
                }
            }
            if (mod == "circle")
            {
                Circle_draw circle_draw = new Circle_draw();
                circle_draw.Location = e.Location;
                circle_draw.R = r;
                if (e.Button == MouseButtons.Right && draw_way == 0)
                {
                    draw_way = 1;
                    using (var graphics = CreateGraphics())
                    {
                        circle_draw.Paint(graphics);
                    }
                }
            }
        }
    }
}