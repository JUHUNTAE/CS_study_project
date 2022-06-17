using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace first_study_project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnShort_Click(object sender, EventArgs e)
        {
            try
            {
                short sNumber = short.Parse(tboxNumber.Text);

                lblShort.Text = sNumber.ToString();
                lblException.Text = "-";
            }
            catch (Exception ex)//값을 잘못 입력하여 에러가떳을때 프로그램이 꺼지지않게하기위해 예외를둠
            {
                lblException.Text = ex.ToString();
            }
        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            try
            {
                int sNumber = int.Parse(tboxNumber.Text);

                lblInt.Text = sNumber.ToString();
                lblException.Text = "-";
            }
            catch (Exception ex)//값을 잘못 입력하여 에러가떳을때 프로그램이 꺼지지않게하기위해 예외를둠
            {
                lblException.Text = ex.ToString();
            }
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            try
            {
                double sNumber = double.Parse(tboxNumber.Text);

                lblDouble.Text = sNumber.ToString();
                lblException.Text = "-";
            }
            catch (Exception ex)//값을 잘못 입력하여 에러가떳을때 프로그램이 꺼지지않게하기위해 예외를둠
            {
                lblException.Text = ex.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            short sNumber = 0;
            int iNumber = 0;
            double dNumber = 0;

            lblException.Text = "-";

            if (short.TryParse(tboxNumber.Text,out sNumber))
            {
                lblShort.Text = sNumber.ToString(); 
            }
            else if(int.TryParse(tboxNumber.Text,out iNumber))
            {
                lblInt.Text = iNumber.ToString();
            }
            else if(double.TryParse(tboxNumber.Text,out dNumber))
            {
                lblDouble.Text = dNumber.ToString();
            }
            else
            {
                lblException.Text = "변환 할수 없음";
            }
        }
    }
}
