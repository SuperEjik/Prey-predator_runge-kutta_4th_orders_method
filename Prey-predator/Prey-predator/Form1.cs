using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Prey_predator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            double a = 0, c = 0, b = 0, d = 0, Y1 = 0, Y2 = 0, h = 0, T = 0;

            /* a - коэффициент естественной смертности хищников
            * b - коэффициент естественного прироста жертв
            * с - коэффициент увеличения числа хищников
            * d - коэффициент смертности жертв
            * y1 - начальное колличество жертв
            * y2 - начальное колличество хищников
            * h - шаг интегрирования по времени
            * T - конечное время расчёта
            */

            a = Convert.ToDouble(text_a.Text);
            c = Convert.ToDouble(text_c.Text);
            b = Convert.ToDouble(text_b.Text);
            d = Convert.ToDouble(text_d.Text);
            Y1 = Convert.ToDouble(text_y1.Text);
            Y2 = Convert.ToDouble(text_y2.Text);

            h = Convert.ToInt32(text_h.Text);
            T = Convert.ToInt32(text_T.Text);

            rungeKutta(a, c, b, d, Y1, Y2, h, T);
        }

        private void rungeKutta(double a, double c, double b, double d, double Y1, double Y2, double h, double T)
        {
            double k1 = 0, k2 = 0, k3 = 0, k4 = 0, m1 = 0, m2 = 0, m3 = 0, m4 = 0;
            double prey = Y1, predator = Y2;
            double t = 0;

            double step = 0;

            population_graph.Series[0].Points.Clear();
            population_graph.Series[1].Points.Clear();

            dependency_graph.Series[0].Points.Clear();

            step = h/T;

            population_graph.Series[0].Points.AddXY(0, Y1);
            population_graph.Series[1].Points.AddXY(0, Y2);

            while (t < T)
            {
                t = t + h;

                k1 = step * (b - d * Y2) * Y1; //ж
                m1 = step * (-a + c * Y1) * Y2; //х

                k2 = step * ( (b - d * (Y2 + m1 / 2) ) * (Y1 + (k1/ 2) ) ); //ж
                m2 = step * ( (- a + c * (Y1 + k1 / 2) ) * (Y2 + (m1/ 2) ) ); //х

                k3 = step * ( (b - d * (Y2 + m2/ 2) ) * (Y1 + (k2/ 2) ) ); //ж
                m3 = step * ( (- a + c * (Y1 + k2/ 2) ) * (Y2 + (m2/ 2) ) ); //х

                k4 = step * ( (b - d * (Y2 + (m3) ) ) * (Y1 + (k3) ) ); //ж
                m4 = step * ( (- a + c * (Y1 + (k3) ) ) * (Y2 + (m3) ) ); //х

                Y1 = Y1 + ( (k1 + 2 * k2 + 2 * k3 + k4) / 6 );
                Y2 = Y2 + ( (m1 + 2 * m2 + 2 * m3 + m4) / 6 );

                population_graph.Series[0].Points.AddXY(t, Y1);
                population_graph.Series[1].Points.AddXY(t, Y2);

                dependency_graph.Series[0].Points.AddXY(Y1, Y2);

                //.Series[1].Points.AddXY(Y1, Y2);

                //function_graph.Series[0].Points.AddXY(Y1, Y2);
            }
        }


        private void text_a_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }
    }
}


//Тестовые данные

/*a = 35; // смерть хищников
b = 15; // прирост жертв
c = 1; // прирост хищников
d = 1; // смерть жертв

h = 3;
T = 366;

Y1 = 12; // жертва
Y2 = 39; // хищник*/

// для первого порядка
/*
double test_hi = 0;
double test_je = 0;

test_je = Y1;
test_hi = Y2;
t = t + h;
function_graph.Series[0].Points.AddXY(t, test_hi);

while (t < T)
{
    t = t + h;

    test_je = test_je + b * test_je - d * test_je * test_hi;
    test_hi = test_hi - a * test_hi + c * test_je * test_hi;

    //function_graph.Series[0].Points.AddXY(test_je, test_hi);

    //function_graph.Series[0].Points.AddXY(t, test_je);
    //function_graph.Series[1].Points.AddXY(t, test_hi);

}*/
