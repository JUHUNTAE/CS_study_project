using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace first_study_project_while
{
    public partial class btndowhileResult : Form
    {
        public btndowhileResult()
        {
            InitializeComponent();
        }

        private void btnwhileResult_Click(object sender, EventArgs e)
        {
            //1~45 6개의 번호
            //List<int> iList = new List<int>();

            int[] iArray = new int[6];
            int iCount = 0;

            StringBuilder sb = new StringBuilder();
            Random rd = new Random();

            // iArray가 다 안차면 계속 진행
            while (Array.IndexOf(iArray , 0) != -1)
            {
                int iNumber = rd.Next(1, 46); //1<= x < 46

                if (Array.IndexOf(iArray, iNumber) == -1)
                {
                    iArray[iCount] = iNumber;
                    //sb.Append(string.Format("{0}.", iNumber)); >> 숫자크기 순서상관없이
                    iCount++;
                }

            }
            //작은 숫자 순서대로
            Array.Sort(iArray);
            sb.Append(String.Format("{0},{1},{2},{3},{4},{5}", iArray[0], iArray[1], iArray[2], iArray[3], iArray[4], iArray[5]));
            lblwhileResult.Text = sb.ToString();
            lboxwhileResult.Items.Add(sb.ToString());
        }


    }
}
