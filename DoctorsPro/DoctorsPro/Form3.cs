using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DoctorsPro.Excel;

/**
 * authors: Ester Moiseyev 318692464, Yogev Tamir 203762216
 */

namespace DoctorsPro
{
    
    public partial class Form3 : Form
    {
        //Excel xl;
        string WBC, Neut, Lymph, RBC, HCT, Urea, Hb, Crtn, Iron, HDL, AP;
        private bool diag_bt_Click = false, import_bt_click = false;

        MedicalDiag d;
        

        private void importBT_bt_Click(object sender, EventArgs e)
        {
            import_bt_click = true;
            int index;
            label16.Visible = true;
            label17.Visible = true;
            label18.Visible = true;
            label19.Visible = true;
            label20.Visible = true;
            label21.Visible = true;
            label22.Visible = true;
            label23.Visible = true;
            label24.Visible = true;
            label25.Visible = true;
            label26.Visible = true;
            wbc_tb.Visible = true;
            rbc_tb.Visible = true;
            urea_tb.Visible = true;
            neut_tb.Visible = true;
            lymph_tb.Visible = true;
            iron_tb.Visible = true;
            hct_tb.Visible = true;
            hdl_tb.Visible = true;
            hemoglobin_tb.Visible = true;
            ap_tb.Visible = true;
            crtn_tb.Visible = true;
            pictureBox8.Visible = true;

            index = Excel.PatientInExcel(pID_tb.Text);
            if (index != -1)// if the patient is already in the list 
            {
                List<String> list = Excel.importBTest(index);
                foreach (Control c in this.Controls) //getting the data from the array list into the textBox
                {
                    if (c.GetType().Name.ToString() == "TextBox")
                    {
                        if (c == wbc_tb)
                            wbc_tb.Text = list[0];
                        if (c == neut_tb)
                            neut_tb.Text = list[1];
                        if (c == lymph_tb)
                            lymph_tb.Text = list[2];
                        if (c == rbc_tb)
                            rbc_tb.Text = list[3];
                        if (c == hct_tb)
                            hct_tb.Text = list[4];
                        if (c == urea_tb)
                            urea_tb.Text = list[5];
                        if (c == hemoglobin_tb)
                            hemoglobin_tb.Text = list[6];
                        if (c == crtn_tb)
                            crtn_tb.Text = list[7];
                        if (c == iron_tb)
                            iron_tb.Text = list[8];
                        if (c == hdl_tb)
                            hdl_tb.Text = list[9];
                        if (c == ap_tb)
                            ap_tb.Text = list[10];
                    }
                }

                //אם מדובר במשתמש שקיים כבר במערכת יש להכניס את המידע עליו מקובץ האקסל לטקסט בוקס
            }
            else
            {
                //במידה ומדובר במטופל חדש, התיבות טקסט יהיו ריקות..מכאן שעל הרופא לעדכן את פרטי המטופל 
            }

        }
        

       
        private void pLastName_tb_TextChanged(object sender, EventArgs e)
        {
            hasForbiddenChars(pLastName_tb.Text);
        }



        public Form3()
        {
            //xl = new Excel();
            InitializeComponent();
            d=new MedicalDiag();
        }
        private void saveChange_bt_Click(object sender, EventArgs e)
        {
            //flag = true;
        }

       

       
        private void genderF_rb_CheckedChanged(object sender, EventArgs e)
        {

            isPregnet_gb.Visible = true;
            pregnetN_rb.Visible = true;
            pregnetY_rb.Visible = true;
        }



        private void Diagnosis_bt_Click(object sender, EventArgs e)
        {
            diag_bt_Click = true;
            int flag = 0;
            bool eastern = false, ethi = false;
            int number;
            string pregnet = "";
            List<string> diag = new List<string>();
            int index = comboBox1.SelectedIndex;
            if (index == 0)
                eastern = true;
            else if (index == 1)
                ethi = true;
            int i = Excel.PatientInExcel(pID_tb.Text);
            try
            {


                if (i != -1)// if the patient is already in the list 
                {
                    List<string> list = Excel.importBTest(i);
                    for (int j = 0; j < list.Count; j++)
                    {
                        if (list[j] == "")
                            flag++;
                    }

                    if (flag == 11)
                        MessageBox.Show("!למטופל זה אין בדיקות דם קיימות במערכת");
                    else
                    {
                        if (import_bt_click == true)
                        {
                            
                            int age = int.Parse(pAge_tb.Text), whiteCells = int.Parse(wbc_tb.Text), preNeut = int.Parse(neut_tb.Text), preLymph = int.Parse(lymph_tb.Text), rbcCapacitiy = int.Parse(hct_tb.Text);
                            int ur = int.Parse(urea_tb.Text), hemoglobin = int.Parse(hemoglobin_tb.Text), cr = int.Parse(crtn_tb.Text), ir = int.Parse(iron_tb.Text), apPH = int.Parse(ap_tb.Text);
                            float preRbc = float.Parse(rbc_tb.Text), mgHDL = float.Parse(hdl_tb.Text);
                            int wbc = d.WBC(age, whiteCells);
                            int neut = d.Neut(preNeut);
                            int lymph = d.Lymph(preLymph);
                            int rbc = d.RBC(preRbc);
                            int hct = d.HCT(Gender(), rbcCapacitiy);
                            int urea = d.Urea(eastern, ur, pregnet);
                            int hb = d.Hb(age, Gender(), hemoglobin);
                            int crtn = d.Crtn(age, cr);
                            int iron = d.Iron(Gender(), ir);
                            int hdl = d.HDL(ethi, Gender(), mgHDL);
                            int ap = d.Ap(eastern, apPH);
                            List<string> l1 = findProb(diag, wbc, neut, lymph, rbc, hct, urea, hb, crtn, iron, hdl, ap);
                            List<string> l2 = Treatment(diag, wbc, neut, lymph, rbc, hct, urea, hb, crtn, iron, hdl, ap);
                            listBox1.Visible = true;
                            listBox2.Visible = true;
                            label27.Visible = true;
                            label28.Visible = true;
                            for (int k = 0; k < l1.Count; k++)
                                listBox1.Items.Add(l1[k]);
                            for (int k = 0; k < l2.Count; k++)
                                listBox2.Items.Add(l2[k]);

                        }
                        else
                            MessageBox.Show("!תחילה יש לייבא את בדיקות הדם");
                    }
                }
                else
                    MessageBox.Show("מדובר במטופל חדש, אין במערכת תוצאות לבדיקות דם");
            }catch (Exception ex) { MessageBox.Show(ex.Message); }
     
        }



          
        public List<string> findProb( List<string> diag, int wbc, int neut,int lymph,int rbc, int hct, int urea, int hb,int crtn, int iron, int hdl, int ap) 
        {

            //string d="";
            List<List<string>> list = Excel.infoFromDiagXL();
            List<string> d = new List<string>();
            //לוקחים שומרים את הדיאגנוסה בליסט ומוחקים כפילויות ורק לאחר מכן מדפיסים
            for (int i = 0; i < list[0].Count; i++)
            {
                if ((rbc == -1 && hct == -1 && hb == -1) || (rbc == -1 && hct == -1) || (hct == -1 && hb == -1))
                    d.Add(list[0][i]);
                if (urea == 1 || urea == -1)
                    d.Add(list[0][i]);
                if ((rbc == -1 && hct == -1 && hb == -1 && iron == -1) || (rbc == -1 && hct == -1 && hb == -1) || (hct == -1 && hb == -1 && iron == -1) || (rbc == -1 && hct == -1 && iron == -1) || (rbc == -1 && hb == -1 && iron == -1))
                    d.Add(list[0][i]);
                if (hdl == -1)
                    d.Add(list[0][i]);
                if ((neut == -1 && lymph == 1 && rbc == 1) || (neut == -1 && lymph == 1) || lymph == 1 && rbc == 1)
                    d.Add(list[0][i]);
                if (hb == -1)
                    d.Add(list[0][i]);
                if (iron == 1)
                    d.Add(list[0][i]);
                if (urea == 1)
                    d.Add(list[0][i]);
                if ((wbc == 1 && (neut == -1 || neut == 1) && lymph == -1) || (wbc == 1 && (neut == -1 || neut == 1)) || ((neut == -1 || neut == 1) && lymph == -1))
                    d.Add(list[0][i]);
                if (ap == -1)
                    d.Add(list[0][i]);
                if (wbc == -1)
                    d.Add(list[0][i]);
                if (ap == 1)
                    d.Add(list[0][i]);
                if (hdl == -1)
                    d.Add(list[0][i]);
                if (wbc == 1)
                    d.Add(list[0][i]);
                if (urea == -1 || ap == 1)
                    d.Add(list[0][i]);
                if (urea == 1 || crtn == 1)
                    d.Add(list[0][i]);
                if (hb == -1)
                    d.Add(list[0][i]);
                if (crtn == -1 || crtn == 1)
                    d.Add(list[0][i]);
                if (rbc == 1 || hct == 1)
                    d.Add(list[0][i]);
                if (rbc == 1)
                    d.Add(list[0][i]);
                if (ap == 1)
                    d.Add(list[0][i]);
                if (hdl == -1)
                    d.Add(list[0][i]);
                if (((wbc == -1 || wbc == 1) && neut == -1 && lymph == -1) || ((wbc == -1 || wbc == 1) && neut == -1) || (neut == -1 && lymph == -1))
                    d.Add(list[0][i]);
                if (crtn == 1 && vegetarianVegan_rb.Checked == false && meat_rb.Checked == true)
                    d.Add(list[0][i]);
                if (ap == 1)
                    d.Add(list[0][i]);
                if ((urea == -1 && crtn == -1 && iron == -1) || (urea == -1 && crtn == -1) || (crtn == -1 && iron == -1))
                    d.Add(list[0][i]);

            }
            for (int i = 0, j; i < d.Count - 1; ++i)
            {
                j = i + 1;
                while (j < d.Count)
                {

                    if (d[j] == d[i])
                        d.RemoveAt(j);
                    else
                        ++j;
                }
            }
            return d;
        }
        public List<string> Treatment(List<string> diag, int wbc, int neut, int lymph, int rbc, int hct, int urea, int hb, int crtn, int iron, int hdl, int ap)
        {

            List <string> t = new List<string>();
            List<List<string>> list = Excel.infoFromDiagXL();
            for (int i = 0; i < list[1].Count; i++)
            {
                if ((rbc == -1 && hct == -1 && hb == -1) || (rbc == -1 && hct == -1) || (hct == -1 && hb == -1))
                    t.Add(list[1][i]);
                if (urea == 1 || urea == -1)
                    t.Add(list[1][i]);
                if ((rbc == -1 && hct == -1 && hb == -1 && iron == -1) || (rbc == -1 && hct == -1 && hb == -1) || (hct == -1 && hb == -1 && iron == -1) || (rbc == -1 && hct == -1 && iron == -1) || (rbc == -1 && hb == -1 && iron == -1))
                    t.Add(list[1][i]);
                if (hdl == -1)
                    t.Add(list[1][i]);
                if ((neut == -1 && lymph == 1 && rbc == 1) || (neut == -1 && lymph == 1) || lymph == 1 && rbc == 1)
                    t.Add(list[1][i]);
                if (hb == -1)
                    t.Add(list[1][i]);
                if (iron == 1)
                    t.Add(list[1][i]);
                if (urea == 1)
                    t.Add(list[1][i]);
                if ((wbc == 1 && (neut == -1 || neut == 1) && lymph == -1) || (wbc == 1 && (neut == -1 || neut == 1)) || ((neut == -1 || neut == 1) && lymph == -1))
                    t.Add(list[1][i]);
                if (ap == -1)
                    t.Add(list[1][i]);
                if (wbc == -1)
                    t.Add(list[1][i]);
                if (ap == 1)
                    t.Add(list[1][i]);
                if (hdl == -1)
                    t.Add(list[1][i]);
                if (wbc == 1)
                    t.Add(list[1][i]);
                if (urea == -1 || ap == 1)
                    t.Add(list[1][i]);
                if (urea == 1 || crtn == 1)
                    t.Add(list[1][i]);
                if (hb == -1)
                    t.Add(list[1][i]);
                if (crtn == -1 || crtn == 1 )
                    t.Add(list[1][i]);
                if (rbc == 1 || hct == 1)
                    t.Add(list[1][i]);
                if (rbc == 1)
                    t.Add(list[1][i]);
                if (ap == 1)
                    t.Add(list[1][i]);
                if (hdl == -1)
                    t.Add(list[1][i]);
                if (((wbc == -1 || wbc == 1) && neut == -1 && lymph == -1) || ((wbc == -1 || wbc == 1) && neut == -1) || (neut == -1 && lymph == -1))
                    t.Add(list[1][i]);
                if (crtn == 1 && vegetarianVegan_rb.Checked == false && meat_rb.Checked==true)
                    t.Add(list[1][i]);
                if (ap == 1)
                    t.Add(list[1][i]);
                if ((urea == -1 && crtn == -1 && iron == -1) || (urea == -1 && crtn == -1) || (crtn == -1 && iron == -1))
                    t.Add(list[1][i]);

            }
            for (int i = 0, j; i < t.Count - 1; ++i)
            {
                j = i + 1;
                while (j < t.Count)
                {

                    if (t[j] == t[i])
                        t.RemoveAt(j);
                    else
                        ++j;
                }
            }
            return t;
        }


        private void ExitUser_bt_Click(object sender, EventArgs e)
        {
           
            Application.Exit();
            saveD_bt_Click(sender, e);
        }

        

        private void pFirstName_tb_TextChanged(object sender, EventArgs e)
        {
            hasForbiddenChars(pFirstName_tb.Text);
        }

        private void enterPFile_bt_Click(object sender, EventArgs e)
        {
            if (validID(pID_tb.Text) == true){
                
                int index;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                pFirstName_tb.Visible = true;
                pLastName_tb.Visible = true;
                pHeight_tb.Visible = true;
                pWeigth_tb.Visible = true;
                pAge_tb.Visible = true;
                bloodPre_tb.Visible = true;
                birthDate_tb.Visible = true;
                importBT_bt.Visible = true;
                saveD_bt.Visible = true;
                smokeN_rb.Visible = true;
                smokeY_rd.Visible = true;
                gender_gb.Visible = true;
                isSmoking_gb.Visible = true;
                genderF_rb.Visible = true;
                genderM_rb.Visible = true;
                comboBox1.Visible = true;
                vegetarianVegan_rb.Visible = true;
                meat_rb.Visible = true;
                food_gb.Visible = true;
                Diagnosis_bt.Visible = true;
                saveD_bt.Visible=true;
                pictureBox1.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;

                index = Excel.PatientInExcel(pID_tb.Text);
                if (index != -1)// if the patient is already in the list 
                {
                    List<String> list = Excel.findInXL(index);
                    foreach (Control c in this.Controls) //getting the data from the array list into the textBox
                    {
                        if (c.GetType().Name.ToString() == "TextBox")
                        {
                            if (c == pID_tb)
                                pID_tb.Text = list[0];
                            if (c == pFirstName_tb)
                                pFirstName_tb.Text = list[1];
                            if (c == pLastName_tb)
                                pLastName_tb.Text = list[2];
                            if (c == pAge_tb)
                                pAge_tb.Text = list[3];
                            if (c == pWeigth_tb)
                                pWeigth_tb.Text = list[4];
                            if (c == pHeight_tb)
                                pHeight_tb.Text = list[5];
                            if (c == birthDate_tb)
                                birthDate_tb.Text = list[6];
                            if (c == bloodPre_tb)
                                bloodPre_tb.Text = list[7];    
                        }
                    }
                    for (int i = 7; i < list.Count; i++)
                    {
                        if (list[i]=="Male")
                            genderM_rb.Checked = true;
                        if (list[i]=="Female")
                            genderF_rb.Checked = true;
                        if (list[i]=="YesP")
                            pregnetY_rb.Checked = true;
                        if (list[i]=="NoP")
                            pregnetN_rb.Checked = true;
                        if (list[i] == "YesS")
                            smokeY_rd.Checked = true;
                        if (list[i] == "NoS")
                            smokeN_rb.Checked = true;
                        if(list[i] =="meat")
                            meat_rb.Checked = true;
                        if (list[i] == "not meat") 
                            vegetarianVegan_rb.Checked=true;
                        if (list[i] == "אתיופי")
                            comboBox1.SelectedIndex = comboBox1.FindString("אתיופי");
                        if (list[i] =="מזרחי")
                            comboBox1.SelectedIndex = comboBox1.FindString("מזרחי");
                        if (list[i] =="אשכנזי")
                            comboBox1.SelectedIndex = comboBox1.FindString("אשכנזי");
                        if (list[i]=="דרום אמריקה")
                            comboBox1.SelectedIndex = comboBox1.FindString("דרום אמריקה");


                    }
                }


            }
        }
        public Boolean validID(string s)
        {
            bool b=true;
            int countD = 0, countS = 0, countCh = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]) == true)
                    countD++;
                if (char.IsLetter(s[i]) == true)
                    countCh++;
                else if (char.IsDigit(s[i]) == false && char.IsLetter(s[i]) == false)
                    countS++;
            }
            try
            {

                if (pID_tb.Text == "")
                {
                    MessageBox.Show(".הכנס את תעודת הזהות של המטופל על מנת להיכנס לתיק הרפואי שלו");
                    b = false;
                }
                else if (pID_tb.Text.Length != 9)
                {
                    MessageBox.Show(".הכנסת ערך לא חוקי, על התעודת זהות להיות באורך של 9 תווים");
                    b = false;
                }
                if ((countCh != 0) && (countS != 0))
                {
                    MessageBox.Show(".אין להכניס אותיות ותווים מיוחדים");
                    b = false;
                }
                if ((countCh != 0) && (countS == 0))
                {
                    MessageBox.Show(".אין להכניס אותיות ");
                    b = false;
                }
                if ((countCh == 0) && (countS != 0))
                {
                    MessageBox.Show(".אין להכניס תווית מיוחדים ");
                    b = false;
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            return b;

        }
        public string Gender()
        {
            if (genderF_rb.Checked)
                return "Female";
            return "Male";
        }
        public string isPregnet()
        {
            if (pregnetY_rb.Checked)
                return "YesP";
            return "NoP";
        }
        public string isSmoking()
        {
            if (smokeY_rd.Checked)
                return "YesS";
            return "NoS";

        }

        public string Diagnosis()
        {
            string s = "";
            for (int i = 0; i < listBox1.Items.Count; i++)
               s += listBox1.Items[i].ToString()+"\n";
            return s;

        }
        public string Recommendation()
        {
            string s = "";
            for (int i = 0; i < listBox2.Items.Count; i++)
                s += listBox2.Items[i].ToString() + "\n";
            return s;
        }

        private void saveD_bt_Click(object sender, EventArgs e)
        {
            
            string s = "", error = "";
            try
            {
                if (pFirstName_tb.Text == "" || pLastName_tb.Text == "" || pAge_tb.Text == "" || pHeight_tb.Text == "" 
                    || pWeigth_tb.Text == "" || birthDate_tb.Text == "" || bloodPre_tb.Text == "" || comboBox1.SelectedIndex == -1
                    || genderF_rb.Checked==false || genderM_rb.Checked == false || meat_rb.Checked ==false || vegetarianVegan_rb.Checked == false 
                    || pregnetN_rb.Checked == false || pregnetY_rb.Checked == false || smokeN_rb.Checked == false || smokeY_rd.Checked ==false)
                {
                    if (pFirstName_tb.Text == "")
                        s += "שם פרטי\n";
                    if (pLastName_tb.Text == "")
                        s += "שם משפחה\n";
                    if (pAge_tb.Text == "")
                        s += "גיל\n";
                    if (pHeight_tb.Text == "")
                        s += "גובה\n";
                    if (pWeigth_tb.Text == "")
                        s += "משקל\n";
                    if (birthDate_tb.Text == "")
                        s += "תאריך לידה\n";
                    if (bloodPre_tb.Text == "")
                        s += "לחץ דם\n";
                    if (comboBox1.SelectedIndex == -1)
                        s += "עדה\n";
                    if (genderF_rb.Checked == false && genderM_rb.Checked == false)
                        s += "מין\n";
                    if (smokeN_rb.Checked == false && smokeY_rd.Checked == false)
                        s += " ?מעשן/ת\n";
                    if ((pregnetN_rb.Checked == false && pregnetY_rb.Checked == false) && genderF_rb.Checked == true && genderM_rb.Checked == false)
                        s += "?בהריון\n";
                    if ((pregnetN_rb.Checked == false && pregnetY_rb.Checked == false) && genderF_rb.Checked == false && genderM_rb.Checked == false)
                        s += "?בהריון\n";
                    if (meat_rb.Checked == false && vegetarianVegan_rb.Checked == false)
                        s += "?צמחוני/אוכל בשר\n";
                    /*if (int.Parse(pAge_tb.Text) <= 0 && pAge_tb.Text != "")
                        error += "גיל\n";*/
                    if (validDate(birthDate_tb.Text) == false && birthDate_tb.Text != "")
                        error += "תאריך לידה\n";    
                }
                if (s != "" && error=="")
                    MessageBox.Show("אנא הכנס את פרטי המטופל:\n" + s);
                if (s != "" && error != "")
                    MessageBox.Show("(יש להוסיף את הפריטים החסרים ולתקן את הערכים הלא תקינים(גיל/ תאריך לידה\n" + s);
                if (error != "" && s == "")
                    MessageBox.Show(":ערכים לא תקינים\n" +error);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message);
                this.Show();
            }
            if (s == "" && error =="")
            {
                if (Excel.PatientInExcel(pID_tb.Text) == -1)//if the patient is not in the list
                {
                    Excel.addPatientToExcel(pID_tb.Text, pFirstName_tb.Text, pLastName_tb.Text, pAge_tb.Text, pWeigth_tb.Text, pHeight_tb.Text, birthDate_tb.Text, bloodPre_tb.Text, Gender(), isPregnet(), isSmoking(), food(), ethni(), WBC, Neut, Lymph, RBC, HCT, Urea, Hb, Crtn, Iron, HDL, AP, Diagnosis(), Recommendation());
                    MessageBox.Show("Saved seccecfully!");
                }
                else//if the patient is in the list
                {
                    int index = PatientInExcel(pID_tb.Text);
                    List<string> lst = importBTest(index);
                    //WBC, Neut, Lymph, RBC, HCT, Urea, Hb, Crtn, Iron, HDL, AP
                    WBC = lst[0].ToString();
                    Neut = lst[1].ToString();
                    Lymph = lst[2].ToString();
                    RBC = lst[3].ToString();
                    HCT = lst[4].ToString();
                    Urea = lst[5].ToString();
                    Hb = lst[6].ToString();
                    Crtn = lst[7].ToString();
                    Iron = lst[8].ToString();
                    HDL = lst[9].ToString();
                    AP = lst[10].ToString();
                    string d = importDiagnosis(index);
                    string r = importRec(index);
                    int count = 0;
                    foreach (string l in lst)
                    {
                        if (l.Equals("") == true)
                            count++;
                    }
                    if (count==0)//has blood test result in the system
                    {
                        if (diag_bt_Click)
                        {
                            if (d=="" && r =="")//the program didnt gave a diagnosis and recomandation
                                Excel.changePatientInfo(pID_tb.Text, pFirstName_tb.Text, pLastName_tb.Text, pAge_tb.Text, pWeigth_tb.Text, pHeight_tb.Text, birthDate_tb.Text, bloodPre_tb.Text, Gender(), isPregnet(), isSmoking(), food(), ethni(), WBC, Neut, Lymph, RBC, HCT, Urea, Hb, Crtn, Iron, HDL, AP, Diagnosis(), Recommendation());
                            else if ((d != "" && r != ""))
                                Excel.changePatientInfo(pID_tb.Text, pFirstName_tb.Text, pLastName_tb.Text, pAge_tb.Text, pWeigth_tb.Text, pHeight_tb.Text, birthDate_tb.Text, bloodPre_tb.Text, Gender(), isPregnet(), isSmoking(), food(), ethni(), WBC, Neut, Lymph, RBC, HCT, Urea, Hb, Crtn, Iron, HDL, AP, d, r);

                            MessageBox.Show("Changed seccecfully!");
                        }
                        else
                            Excel.changePatientInfo(pID_tb.Text, pFirstName_tb.Text, pLastName_tb.Text, pAge_tb.Text, pWeigth_tb.Text, pHeight_tb.Text, birthDate_tb.Text, bloodPre_tb.Text, Gender(), isPregnet(), isSmoking(), food(), ethni(), WBC, Neut, Lymph, RBC, HCT, Urea, Hb, Crtn, Iron, HDL, AP, "", "");

                    }
                    else //no blood test result in the system
                    {
                        Excel.changePatientInfo(pID_tb.Text, pFirstName_tb.Text, pLastName_tb.Text, pAge_tb.Text, pWeigth_tb.Text, pHeight_tb.Text, birthDate_tb.Text, bloodPre_tb.Text, Gender(), isPregnet(), isSmoking(), food(), ethni(), "", "", "", "", "", "", "", "", "", "", "", "", "");
                    }
                    
                }
                exitFile();
            }


        }

        public void exitFile()
        {
            foreach (Control c in this.Controls) //getting the data from the array list into the textBox
            {
                if (c.GetType().Name.ToString() == "TextBox")
                {
                    c.Text = "";
                    if (c!=pID_tb)
                        c.Visible = false;
                }
                if (c.GetType().Name.ToString() == "Label")
                {
                    if (c != label1)
                        c.Visible = false;
                }
                genderM_rb.Checked = false;
                genderF_rb.Checked = false;
                pregnetY_rb.Checked = false;
                pregnetN_rb.Checked = false;
                smokeY_rd.Checked = false;
                smokeN_rb.Checked = false;
                meat_rb.Checked = false;
                vegetarianVegan_rb.Checked = false;
                food_gb.Visible = false;
                gender_gb.Visible = false;
                isPregnet_gb.Visible = false;
                isSmoking_gb.Visible = false;
                comboBox1.Visible = false;
                saveD_bt.Visible = false;
                Diagnosis_bt.Visible = false;
                importBT_bt.Visible = false;
                listBox1.Visible = false;
                listBox2.Visible = false;
                pictureBox1.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;

            }

        }
        public string ethni()
        {
            string s = "";
            int i = comboBox1.SelectedIndex;
            if (i != -1)
                s = comboBox1.Items[i].ToString();
            return s;

        }

        public string food()
        {
            if (meat_rb.Checked == true)
                return "meat";
            else return "not meat";

        }

        public void hasForbiddenChars(string s)
        {
            int countD=0, countS = 0, countCh = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]) == true)
                    countD++;
                if (char.IsLetter(s[i]) == true)
                    countCh++;
                else
                    countS++;
            }
            try
            {
                if (countD != 0 && countS != 0)
                    MessageBox.Show(".אין להכניס מספרים ותווים מיוחדים");
                if (countD != 0 && countS == 0)
                    MessageBox.Show(".אין להכניס מספרים ");
                if (countD != 0 && countS == 0)
                    MessageBox.Show(".אין להכניס תווים מיוחדים");
            }catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        public Boolean validDate(string date)
        {
            bool f = false;
            DateTime dDate;
            if (DateTime.TryParse(date, out dDate))
            {
                String.Format("{0:d/MM/yyyy}", dDate);
                f = true;
            }
            return f;
            

        }
    }
}
