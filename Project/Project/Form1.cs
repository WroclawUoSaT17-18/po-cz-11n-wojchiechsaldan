using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAddEvent_Click(object sender, EventArgs e)
        {
            if(textBoxDay.Text == "Poniedziałek")
            {
                if (textBoxHours.Text == "8" || textBoxHours.Text == "9")
                {
                    labelPon89.Text = textBoxSubject.Text;
                }
                else if (textBoxHours.Text == "9" || textBoxHours.Text == "10")
                {
                    labelPon910.Text = textBoxSubject.Text;
                }
                else if (textBoxHours.Text == "10" || textBoxHours.Text == "11")
                {
                    labelPon1011.Text = textBoxSubject.Text;
                }
                else if (textBoxHours.Text == "11" || textBoxHours.Text == "12")
                {
                    labelPon1112.Text = textBoxSubject.Text;
                }
                else if (textBoxHours.Text == "12" || textBoxHours.Text == "13")
                {
                    labelPon1213.Text = textBoxSubject.Text;
                }
                else if (textBoxHours.Text == "13" || textBoxHours.Text == "14")
                {
                    labelPon1314.Text = textBoxSubject.Text;
                }
                else if (textBoxHours.Text == "14" || textBoxHours.Text == "15")
                {
                    labelPon1415.Text = textBoxSubject.Text;
                }
                else if (textBoxHours.Text == "15" || textBoxHours.Text == "16")
                {
                    labelPon1516.Text = textBoxSubject.Text;
                }
                else if (textBoxHours.Text == "16" || textBoxHours.Text == "17")
                {
                    labelPon1617.Text = textBoxSubject.Text;
                }
                else if (textBoxHours.Text == "17" || textBoxHours.Text == "18")
                {
                    labelPon1718.Text = textBoxSubject.Text;
                }
                else if (textBoxHours.Text == "18" || textBoxHours.Text == "19")
                {
                    labelPon1819.Text = textBoxSubject.Text;
                }
                else if (textBoxHours.Text == "19" || textBoxHours.Text == "20")
                {
                    labelPon1920.Text = textBoxSubject.Text;
                }
            }
            else if (textBoxDay.Text == "Wtorek")
            {
                if (textBoxHours.Text == "8" || textBoxHours.Text == "9")
                {
                    labelWt89.Text = textBoxSubject.Text;
                }
                else if (textBoxHours.Text == "9" || textBoxHours.Text == "10")
                {
                    labelWt910.Text = textBoxSubject.Text;
                }
                else if (textBoxHours.Text == "10" || textBoxHours.Text == "11")
                {
                    labelWt1011.Text = textBoxSubject.Text;
                }
                else if (textBoxHours.Text == "11" || textBoxHours.Text == "12")
                {
                    labelWt1112.Text = textBoxSubject.Text;
                }
                else if (textBoxHours.Text == "12" || textBoxHours.Text == "13")
                {
                    labelWt1213.Text = textBoxSubject.Text;
                }
                else if (textBoxHours.Text == "13" || textBoxHours.Text == "14")
                {
                    labelWt1314.Text = textBoxSubject.Text;
                }
                else if (textBoxHours.Text == "14" || textBoxHours.Text == "15")
                {
                    labelWt1415.Text = textBoxSubject.Text;
                }
                else if (textBoxHours.Text == "15" || textBoxHours.Text == "16")
                {
                    labelWt1516.Text = textBoxSubject.Text;
                }
                else if (textBoxHours.Text == "16" || textBoxHours.Text == "17")
                {
                    labelWt1617.Text = textBoxSubject.Text;
                }
                else if (textBoxHours.Text == "17" || textBoxHours.Text == "18")
                {
                    labelWt1718.Text = textBoxSubject.Text;
                }
                else if (textBoxHours.Text == "18" || textBoxHours.Text == "19")
                {
                    labelWt1819.Text = textBoxSubject.Text;
                }
                else if (textBoxHours.Text == "19" || textBoxHours.Text == "20")
                {
                    labelWt1920.Text = textBoxSubject.Text;
                }
            }
             else if (textBoxDay.Text == "Środa")
            {
                if (textBoxHours.Text == "8" || textBoxHours.Text == "9")
                {
                    labelSr89.Text = textBoxSubject.Text;
                }
                else if (textBoxHours.Text == "9" || textBoxHours.Text == "10")
                {
                    labelSr910.Text = textBoxSubject.Text;
                }
                else if (textBoxHours.Text == "10" || textBoxHours.Text == "11")
                {
                    labelSr1011.Text = textBoxSubject.Text;
                }
                else if (textBoxHours.Text == "11" || textBoxHours.Text == "12")
                {
                    labelSr1112.Text = textBoxSubject.Text;
                }
                else if (textBoxHours.Text == "12" || textBoxHours.Text == "13")
                {
                    labelSr1213.Text = textBoxSubject.Text;
                }
                else if (textBoxHours.Text == "13" || textBoxHours.Text == "14")
                {
                    labelSr1314.Text = textBoxSubject.Text;
                }
                else if (textBoxHours.Text == "14" || textBoxHours.Text == "15")
                {
                    labelSr1415.Text = textBoxSubject.Text;
                }
                else if (textBoxHours.Text == "15" || textBoxHours.Text == "16")
                {
                    labelSr1516.Text = textBoxSubject.Text;
                }
                else if (textBoxHours.Text == "16" || textBoxHours.Text == "17")
                {
                    labelSr1617.Text = textBoxSubject.Text;
                }
                else if (textBoxHours.Text == "17" || textBoxHours.Text == "18")
                {
                    labelSr1718.Text = textBoxSubject.Text;
                }
                else if (textBoxHours.Text == "18" || textBoxHours.Text == "19")
                {
                    labelSr1819.Text = textBoxSubject.Text;
                }
                else if (textBoxHours.Text == "19" || textBoxHours.Text == "20")
                {
                    labelSr1920.Text = textBoxSubject.Text;
                }
            }
            else if (textBoxDay.Text == "Czwartek")
            {
                if (textBoxHours.Text == "8" || textBoxHours.Text == "9")
                {
                    labelCz89.Text = textBoxSubject.Text;
                }
                else if (textBoxHours.Text == "9" || textBoxHours.Text == "10")
                {
                    labelCz910.Text = textBoxSubject.Text;
                }
                else if (textBoxHours.Text == "10" || textBoxHours.Text == "11")
                {
                    labelCz1011.Text = textBoxSubject.Text;
                }
                else if (textBoxHours.Text == "11" || textBoxHours.Text == "12")
                {
                    labelCz1112.Text = textBoxSubject.Text;
                }
                else if (textBoxHours.Text == "12" || textBoxHours.Text == "13")
                {
                    labelCz1213.Text = textBoxSubject.Text;
                }
                else if (textBoxHours.Text == "13" || textBoxHours.Text == "14")
                {
                    labelCz1314.Text = textBoxSubject.Text;
                }
                else if (textBoxHours.Text == "14" || textBoxHours.Text == "15")
                {
                    labelCz1415.Text = textBoxSubject.Text;
                }
                else if (textBoxHours.Text == "15" || textBoxHours.Text == "16")
                {
                    labelCz1516.Text = textBoxSubject.Text;
                }
                else if (textBoxHours.Text == "16" || textBoxHours.Text == "17")
                {
                    labelCz1617.Text = textBoxSubject.Text;
                }
                else if (textBoxHours.Text == "17" || textBoxHours.Text == "18")
                {
                    labelCz1718.Text = textBoxSubject.Text;
                }
                else if (textBoxHours.Text == "18" || textBoxHours.Text == "19")
                {
                    labelCz1819.Text = textBoxSubject.Text;
                }
                else if (textBoxHours.Text == "19" || textBoxHours.Text == "20")
                {
                    labelCz1920.Text = textBoxSubject.Text;
                }
            }
            else if (textBoxDay.Text == "Piątek")
            {
                if (textBoxHours.Text == "8" || textBoxHours.Text == "9")
                {
                    labelPt89.Text = textBoxSubject.Text;
                }
                else if (textBoxHours.Text == "9" || textBoxHours.Text == "10")
                {
                    labelPt910.Text = textBoxSubject.Text;
                }
                else if (textBoxHours.Text == "10" || textBoxHours.Text == "11")
                {
                    labelPt1011.Text = textBoxSubject.Text;
                }
                else if (textBoxHours.Text == "11" || textBoxHours.Text == "12")
                {
                    labelPt1112.Text = textBoxSubject.Text;
                }
                else if (textBoxHours.Text == "12" || textBoxHours.Text == "13")
                {
                    labelPt1213.Text = textBoxSubject.Text;
                }
                else if (textBoxHours.Text == "13" || textBoxHours.Text == "14")
                {
                    labelPt1314.Text = textBoxSubject.Text;
                }
                else if (textBoxHours.Text == "14" || textBoxHours.Text == "15")
                {
                    labelPt1415.Text = textBoxSubject.Text;
                }
                else if (textBoxHours.Text == "15" || textBoxHours.Text == "16")
                {
                    labelPt1516.Text = textBoxSubject.Text;
                }
                else if (textBoxHours.Text == "16" || textBoxHours.Text == "17")
                {
                    labelPt1617.Text = textBoxSubject.Text;
                }
                else if (textBoxHours.Text == "17" || textBoxHours.Text == "18")
                {
                    labelPt1718.Text = textBoxSubject.Text;
                }
                else if (textBoxHours.Text == "18" || textBoxHours.Text == "19")
                {
                    labelPt1819.Text = textBoxSubject.Text;
                }
                else if (textBoxHours.Text == "19" || textBoxHours.Text == "20")
                {
                    labelPt1920.Text = textBoxSubject.Text;
                }
            }
            
            

        }

        private void textBoxHours_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
