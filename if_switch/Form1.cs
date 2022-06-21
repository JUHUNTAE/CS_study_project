using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace first_study_project_if_switch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ifTest();
            swichTest();
        }

        //switch 예제
        private void swichTest()
        {
            int iRet = 3;

            string strResult = string.Empty;

            switch (iRet)
            {
                case 2:
                case 3:
                    {
                        strResult = "2나 3";
                    }
                    break;
                case 4:
                    {
                        strResult = "4";
                    }
                    break;
                default:
                    {
                        strResult = "몰라";
                    }
                    break;

            }


        }

        //if 예제
        private void ifTest()
        {
            int ia = 30;
            int ib = 20;

            string strResult = string.Empty;

            if (ia > ib)
            {
                strResult = "ia가 크다";
            }
            else if (ia < ib)
            {
                strResult = "ib가 크다";
            }
            else
            {
                strResult = "ia와 ib가 같다";
            }

            //한줄로 축약가능
            //if (ia > ib) strResult = "ia가 크다";
            //else strResult = "같다";

            //strResult=(ia > ib) ? "ia가 크다" : "같다";


            if (ia > 5 && ib > 5)
            {
                strResult = "둘다 크다";
            }

            if (ia > 5 || ib > 5)
            {
                strResult = "적어도 둘중에 하나는 크다";
            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        { 

            int iNumber1 = (int)nNumber1.Value;
            int iNumber2 = (int)nNumber2.Value;

            if (iNumber1 > iNumber2)
            {
                lblifResult.Text = String.Format("Number1이 Number2보다 (0)이 더 큽니다.", iNumber1, iNumber2);
            }
            else if (iNumber1 < iNumber2)
            {
                lblifResult.Text = String.Format("Number2가 Number1보다 (0)이 더 큽니다.", iNumber2, iNumber1);
            }
            else
            {
                lblifResult.Text = String.Format("두 숫자는 같습니다 숫자 : (0).", iNumber1);
            }

        }

        private void btnswitchResult_Click(object sender, EventArgs e)
        {
            string strSelect = cboxDay.Text;

            switch (strSelect)
            {
                case "월":
                    lblswitchResult.Text = "- 선택 날짜는 월요일 입니다.";
                    break;
                case "화":
                    lblswitchResult.Text = "- 선택 날짜는 화요일 입니다.";
                    break;
                case "수":
                    lblswitchResult.Text = "- 선택 날짜는 수요일 입니다.";
                    break;
                case "목":
                case "금":
                    lblswitchResult.Text = "- 선택 날짜는 목요일 또는 금요일 입니다.";
                    break;

                default:
                    lblswitchResult.Text = "- 선택 날짜는 주말 입니다.(토요일, 일요일)";
                    break ;
            }
        }
    }
}
