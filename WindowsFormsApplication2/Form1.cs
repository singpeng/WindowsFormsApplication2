using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmdCheck_Click(object sender, EventArgs e)
        {
            string n = textBox1.Text;

            string s = textBox2.Text;
            string m = textBox3.Text;
            string f = textBox4.Text;
            string sf = textBox6.Text;
            string fc = textBox8.Text;
            string cc = textBox9.Text;
            string aa = textBox10.Text;
            string bb = textBox11.Text;
            string cm = textBox12.Text;
            string rk = comboBox1.Text;

            string str = "รายการที่เลือก : " + Environment.NewLine;
            {
                str = str + "1.มหาวิทยาลัย/สถาบัน/วิทยาลัย : " + n + Environment.NewLine;
            }
            str = str + "2.ชื่อ-นามสกุล : ชื่อ : " + sf+":  : "+" : : " + "นามสกุล"+" : : " + aa + Environment.NewLine;
            {
                str = str + "3.เลขประจำตัวประชาชน :" + f + " : : " + "เลขประจำตัวนิสิต/นักศึกษา : " + fc + Environment.NewLine;
            }

            if (optMale.Checked == true)
            {
                str = str + "4.เพศ : ชาย " + Environment.NewLine;
            }
            else
            {
                str = str + "4.เพศ : หญิง " + Environment.NewLine;
            }
            {
                str = str + "5. วัน/เดือน/ปี เกิด :  " + cc +" : : " +"อายุ"+": " + aa +" : "+" : " +"ปี" + Environment.NewLine;


            }
            str = str + "6.สำเร็จการศึกษาในระดับ : ";

            if (apt1.Checked == true)
            {
                str = str + "ต่ำกว่าปริญญาตรี" + Environment.NewLine;
            }
            if (apt2.Checked == true)
            {
                str = str + "ปริญญาตรี" + Environment.NewLine;
            }
            if (apt3.Checked == true)
            {

                str = str + "สูงกว่าปริญญาตรี" + Environment.NewLine;

            }
            if (radioButton1.Checked == true)
                str = str + "อื่นๆระบุ : " + s + Environment.NewLine;

            {
                str = str + "7.วุฒิที่สำเร็จการศึกษา(ชื่อปริญญา): " + bb + Environment.NewLine;
            }
            str = str + "8.คะแนนเฉลี่ยตลอดหลักสูตร (GPA) : " + cm + Environment.NewLine;

            {
                str = str + "9.ที่อยู่ปัจจุบัน : " + m + Environment.NewLine;

            }
            str = str + "10.ภูมิลำเนาอยู่ จังหวัด : " + rk + Environment.NewLine;
            {


            }
            str = str + "11.สถานะภาพการทำงานปัจจุบัน : ";
            if (radioButton2.Checked == true)
            {
                str = str + "ทำงานแล้วและกำลังศึกษาต่อ" + Environment.NewLine;
            }
            if (radioButton3.Checked == true)
            {
                str = str + "ทำงานแล้ว" + Environment.NewLine;
            }
            if (radioButton4.Checked == true)
            {
                str = str + "ยังไม่ได้ทำงานและไม่ได้ศึกษาต่อ" + Environment.NewLine;
            }
            if (radioButton5.Checked == true)
            {
                str = str + "กำลังศึกษาต่อ" + Environment.NewLine;



            }




            MessageBox.Show(str, "ผลการตรวจสอบ");
        }
        
            

        private void optMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
    }
}




