using System;
using System.Windows.Forms;
using static DoctorsPro.Excel;

/**
 * authors: Ester Moiseyev 318692464, Yogev Tamir 203762216
 */
namespace DoctorsPro
{
    public partial class Form1 : Form
    {
        //Excel xl;
        public Form1()
        {
            InitializeComponent();
            userName_tb.Text = "esterm1";
            password_tb.Text = "Aa123456^";
            password_tb.PasswordChar = '*';
            //xl = new Excel();
        }

        private void login_b_Click(object sender, EventArgs e)
        {
            string pass = DocInExcel(userName_tb.Text).ToString();
            try
            {
                if (userName_tb.Text == "" || password_tb.Text == "")
                {
                    MessageBox.Show(".יש להכניס את שם המשתמש והסיסמא על מנת להיכנס");
                    userName_tb.Text = "";
                    password_tb.Text = "";
                }
                else if (pass == "")//if the user name enterd is not in the list
                {
                    MessageBox.Show(".המשתמש לא קיים, יש להירשם");
                    userName_tb.Text = "";
                    password_tb.Text = "";
                }

                else //if the user name is in the list
                {
                    if (pass != password_tb.Text)
                        MessageBox.Show("הסיסמא לא נכונה. תקנו ונסו שנית");
                    else
                    {
                        Form3 f3 = new Form3();
                        f3.Show();
                        this.Hide();
                    }
                   
                }

            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
           
        }

        /*private void createNew_b_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }*/

        private void exit1_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*DialogResult dialog = MessageBox.Show("?האם את/ה בטוח/ה שברצונך לצאת מהתכנית", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
                Application.Exit();
            else if (dialog == DialogResult.No)
                e.Cancel = true;*/
        }

        private void signIn_bt_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}
