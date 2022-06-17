using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace first_study_project5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum enumDay
        {
            Monday, //0
            Tuesday, //1
            Wednesday, //2
            Thursday, //3
            Friday, //4
            Saturday, //5
            Sunday, //6
        }

        enum enumTime
        {
            Moring,
            Afternoon,
            Evening,
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lboxDay.Items.Add(enumDay.Monday.ToString());
            lboxDay.Items.Add(enumDay.Tuesday.ToString());
            lboxDay.Items.Add(enumDay.Wednesday.ToString());
            lboxDay.Items.Add(enumDay.Thursday.ToString());
            lboxDay.Items.Add(enumDay.Friday.ToString());
            lboxDay.Items.Add(enumDay.Saturday.ToString());
            lboxDay.Items.Add(enumDay.Sunday.ToString());

            lboxTime.Items.Add(enumTime.Moring.ToString());
            lboxTime.Items.Add(enumTime.Afternoon.ToString());
            lboxTime.Items.Add(enumTime.Evening.ToString());
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            string strResult = tboxName.Text + "와" + lboxDay.SelectedItem + "(요일)" + lboxTime.SelectedItem + "에 보기로 했습니다.";

            tboxResult.Text = strResult;
        }

        private void btnResult2_Click(object sender, EventArgs e)
        {
            string strResult = String.Format("{0} 와 {1}(요일) {2}에 보기로 했습니다.", tboxName.Text, lboxDay.SelectedItem, lboxTime.SelectedItem);

            tboxResult.Text = strResult;
        }
    }

}
