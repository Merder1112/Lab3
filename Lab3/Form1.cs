using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<CFS> List_student = new List<CFS>();
        CFS student;
        string ID;
        string Name1;
        double score1;

        double[] BBC_grade = new double[8];
        double[] KKK_weight = { 4.0, 3.5, 3.0, 2.5, 2.0, 1.5, 1.0 };
        int[] K_of_grade = new int[8];


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ID = Student_ID.Text ;
            Name1 = Student_Name.Text ;
            score1 = double.Parse(Student_Score.Text);

            student = new CFS();
            student.Student_ID = ID;
            student.Name = Name1;
            student.Score = score1;

            List_student.Add(student);

            Student_ID.Text = "";
            Student_Name.Text = "";
            Student_Score.Text = "";

            double max = 0;
            foreach (CFS AF in List_student)
            {
                if (AF.Score > max)
                {
                   max = AF.Score;
                   textBox18.Text=max.ToString();
                   textBox16.Text = AF.Name;
                    textBox13.Text = AF.Student_ID;
                }
            }
            double min = max;
            foreach (CFS AF in List_student)
            {
                if (AF.Score < min)
                {
                    min = AF.Score;
                    textBox17.Text=min.ToString();
                    textBox15.Text = AF.Name;
                    textBox14.Text = AF.Student_ID;
                }
            }

            double AH_list = (double)List_student.Sum(PP => PP.Score);
            textBox19.Text = (AH_list / (double)List_student.Count).ToString("0.00");


            double H_point = score1 ;
            
            if (H_point >= 80 && H_point <= 100)
            {
                K_of_grade[0]++;
                BBC_grade[0] = (K_of_grade[0] * KKK_weight[0]);
                textBox4.Text = K_of_grade[0].ToString();
            }
            else if (H_point >= 75 && H_point <= 79)
            {
                K_of_grade[1]++;
                BBC_grade[1] = (K_of_grade[1] * KKK_weight[1]);
                textBox5.Text = K_of_grade[1].ToString();
            }
            else if (H_point >= 70 && H_point <= 74)
            {
                K_of_grade[2]++;
                BBC_grade[2] = (K_of_grade[2] * KKK_weight[2]);
                textBox6.Text = K_of_grade[2].ToString();
            }
            else if (H_point >= 65 && H_point <= 69)
            {
                K_of_grade[3]++;
                BBC_grade[3] = (K_of_grade[3] * KKK_weight[3]);
                textBox7.Text = K_of_grade[3].ToString();
            }
            else if (H_point >= 60 && H_point <= 64)
            {
                K_of_grade[4]++;
                BBC_grade[4] = (K_of_grade[4] * KKK_weight[4]);
                textBox8.Text = K_of_grade[4].ToString();
            }
            else if (H_point >= 55 && H_point <= 59)
            {
                K_of_grade[5]++;
                BBC_grade[5] = (K_of_grade[5] * KKK_weight[5]);
                textBox9.Text = K_of_grade[5].ToString();
            }
            else if (H_point >= 50 && H_point <= 54)
            {
                K_of_grade[6]++;
                BBC_grade[6] = (K_of_grade[6] * KKK_weight[6]);
                textBox10.Text = K_of_grade[6].ToString();
            }
            else
            {
                K_of_grade[7]++;
                textBox11.Text = K_of_grade[7].ToString();
            }
            double MF_result = 0.0;
            for (int i = 0; i < K_of_grade.Length; i++)
            {
                MF_result += (BBC_grade[i]);
            }
            int NG_of_student = List_student.Count;
            double GPA = MF_result / NG_of_student; 
            textBox12.Text = GPA.ToString("0.00");

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
