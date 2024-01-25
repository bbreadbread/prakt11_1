using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PR_11_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Student
        {
            public string name;
            public double rost;
            public double after;
            public double before = 0 ;
            public double GetEat()
            {
                return before;
            }
            public double AfterEat(double eda, double after)
            {
                before = before + eda - 2800 / 1000;
                return before;
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Student student1 = new Student();
            double eda = 5;
            student1.name = textBox1.Text;
            student1.rost = (double)(numericUpDown1.Value);
            student1.before = (double)(numericUpDown2.Value);
            double before = student1.before;
            student1.after =  student1.AfterEat(eda,student1.before);
            MessageBox.Show(string.Format($"Студент: {student1.name}\nРост: {student1.rost} см.\nВес: {before} кг.\nСъел/а: {eda} кг. еды. \nВес после еды: {student1.after}"));
        }
    }
}
