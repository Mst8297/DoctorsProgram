using System;
using System.Windows.Forms;
using static DoctorsPro.Excel;

/**
 * authors: Ester Moiseyev 318692464, Yogev Tamir 203762216
 */

namespace DoctorsPro
{
    public partial class Form2 : Form
    {
        IronXL.WorkBook workBook;
        IronXL.WorkSheet workSheet;
        //Excel xl;
        string filePath;
        public Form2()
        {
            InitializeComponent();
            newPass_tb.PasswordChar = '*';
            confirmPass_tb.PasswordChar = '*';
        }

        private void back_bt_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            string s = "";
            int count = 0, countD = 0, countL = 0, countS = 0;

            try
            {
                if (newUser_tb.Text.Length < 6 || newUser_tb.Text.Length > 8)
                    s += " \n.שם המשתמש צריך להכיל בין 6 ל-8 תווים";
                for (int i = 0; i < newUser_tb.Text.Length; i++)
                    if (char.IsDigit(newUser_tb.Text[i]) == true)
                        count++;
                if (count > 2)
                    s += " \n.שם המשתמש צריך להכיל עד 2 ספרות";
                if (newPass_tb.Text.Length < 8 || newPass_tb.Text.Length > 10)
                {
                    s += " \n.הסיסמא צריכה להכיל בין 8 ל-10 תווים";
                    count = 0;
                }
                for (int i = 0; i < newPass_tb.Text.Length; i++)
                {
                    if ((newPass_tb.Text[i] >= 'a' && newPass_tb.Text[i] <= 'z') || (newPass_tb.Text[i] >= 'A' && newPass_tb.Text[i] <= 'Z'))
                        countL++;
                    else if (newPass_tb.Text[i] >= '0' && newPass_tb.Text[i] <= '9')
                        countD++;
                    else
                        countS++;
                }
                if (countD == 0)
                    s += " \n.הסיסמא צריכה להכיל לפחות ספרה אחת";
                if (countL == 0)
                    s += " \n.הסיסמא צריכה להכיל לפחות אות אחת";
                if (countS == 0)
                    s += " \n.הסיסמא צריכה להכיל לפחות תו מיוחד אחד";
                if (confirmPass_tb.Text == "" && newPass_tb.Text != "")
                    s += " אנא אמת/י את סיסמתך";
                else if (newPass_tb.Text != confirmPass_tb.Text)
                    s += " \n.אימות הסיסמא לא תואם ";
                else
                {
                    if (DoctorsPro.Excel.DocInExcel(newUser_tb.Text) != "")//in case the user name is already in the list
                    {
                        s += " \n.שם המשתמש קיים כבר במערכת, נסה אחד אחר";
                        this.Show();
                    }
                    else//in case the user name is not in the list.
                    {
                        Excel.AddDocToExcel(newUser_tb.Text, newPass_tb.Text);
                        Form1 f1 = new Form1();
                        f1.Show();
                        this.Hide();
                    }
                }
                if (s != "")//there are errors in the detailes
                {
                    MessageBox.Show(":אנא תקן בהתאם להערות הבאות \n" + s);
                    this.Show();
                }
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
