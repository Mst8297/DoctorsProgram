using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;
using IronXL;
using static DoctorsPro.Form3;
using System.Windows.Forms;

namespace DoctorsPro
{
     public class Excel
    {
        public static string filePath1 = "C:/Users/Ester/source/repos/DoctorsPro/DoctorsPro/Excel/DoctorsDetailes.xlsx";
        public static string filePath2 = "C:/Users/Ester/source/repos/DoctorsPro/DoctorsPro/Excel/PatientDetailes.xlsx";
        public static string filePath3 = "C:/Users/Ester/source/repos/DoctorsPro/DoctorsPro/Excel/Diag.xlsx";
        public static WorkBook wb1 = WorkBook.Load(filePath1);
        public static WorkSheet ws1 = wb1.DefaultWorkSheet;
        public static WorkBook wb2 = WorkBook.Load(filePath2);
        public static WorkSheet ws2 = wb2.DefaultWorkSheet;
        public static WorkBook wb3 = WorkBook.Load(filePath3);
        public static WorkSheet ws3 = wb3.DefaultWorkSheet;

        

        public static void AddDocToExcel(string newUser, string password)
        {
            ws1["A" + 1].Value = "User name";
            ws1["B" + 1].Value = "Password";
            int r = ws1.Rows.Length + 1;
            ws1["A" + r].Value = newUser;
            ws1["B" + r].Value = password;
            wb1.SaveAs(filePath1);

        }
        public static void addPatientToExcel(string ID,string fName,string lName,string age, string weight,string height,string birthDate,string bloodPre, string gender ,string pregnet, string smoke,string food,
            string ethni, string WBC, string Neut, string Lymph, string RBC, string HCT, string Urea, string Hb, string Crtn, string Iron, string HDL, string AP, string Diagnosis, string recommendation)
        {
            ws2["A" + 1].Value = "ID";
            ws2["B" + 1].Value = "First name";
            ws2["C" + 1].Value = "Last name";
            ws2["D" + 1].Value = "Age";
            ws2["E" + 1].Value = "Weight";
            ws2["F" + 1].Value = "Height";
            ws2["G" + 1].Value = "Birth Date";
            ws2["H" + 1].Value = "Blood Presure";
            ws2["I" + 1].Value = "Gender";
            ws2["J" + 1].Value = "Pregnet";
            ws2["K" + 1].Value = "Smoke";
            ws2["L" + 1].Value = "Food";
            ws2["M" + 1].Value = "Ethni";
            ws2["N" + 1].Value = "WBC";
            ws2["O" + 1].Value = "Neut";
            ws2["P" + 1].Value = "Lymph";
            ws2["Q" + 1].Value = "RBC";
            ws2["R" + 1].Value = "HCT";
            ws2["S" + 1].Value = "Urea";
            ws2["T" + 1].Value = "Hb";
            ws2["U" + 1].Value = "Crtn";
            ws2["V" + 1].Value = "Iron";
            ws2["W" + 1].Value = "HDL";
            ws2["X" + 1].Value = "AP";
            ws2["Y" + 1].Value = "Diagnosis";
            ws2["Z" + 1].Value = "Recommendation";

            int r = ws2.Rows.Length + 1;

            ws2["A" + r].Value = ID;
            ws2["B" + r].Value = fName;
            ws2["C" + r].Value = lName;
            ws2["D" + r].Value = age;
            ws2["E" + r].Value = weight;
            ws2["F" + r].Value = height;
            ws2["G" + r].Value = birthDate;
            ws2["H"+ r].Value = bloodPre;
            ws2["I"+ r].Value = gender;
            ws2["J"+ r].Value = pregnet;
            ws2["K" + r].Value = smoke;
            ws2["L" + r].Value = food;
            ws2["M" + r].Value = ethni;
            ws2["N" + r].Value = WBC;
            ws2["O" + r].Value = Neut;
            ws2["P" + r].Value = Lymph;
            ws2["Q" + r].Value = RBC;
            ws2["R" + r].Value = HCT;
            ws2["S" + r].Value = Urea;
            ws2["T" + r].Value = Hb;
            ws2["U" + r].Value = Crtn;
            ws2["V" + r].Value = Iron;
            ws2["W" + r].Value = HDL;
            ws2["X" + r].Value = AP;
            ws2["Y" + r].Value = Diagnosis;
            ws2["Z" + r].Value = recommendation;
            wb2.SaveAs(filePath2);

            
        }
        public static void changePatientInfo(string ID, string fName, string lName, string age, string weight, string height, string birthDate, string bloodPre, string gender, string pregnet, string smoke,string food,string ethni, string WBC, string Neut, string Lymph, string RBC, string HCT, string Urea, string Hb, string Crtn, string Iron, string HDL, string AP, string Diagnosis, string recommendation)
        {
            int r = ws2.Rows.Length;
            ws2.Columns[2].Replace(ws2["B" + r].Value.ToString(), fName);
            ws2.Columns[3].Replace(ws2["C" + r].Value.ToString(), lName);
            ws2.Columns[4].Replace(ws2["D" + r].Value.ToString(), age);
            ws2.Columns[5].Replace(ws2["E" + r].Value.ToString(), weight);
            ws2.Columns[6].Replace(ws2["F" + r].Value.ToString(), height);
            ws2.Columns[7].Replace(ws2["G" + r].Value.ToString(), birthDate);
            ws2.Columns[8].Replace(ws2["H" + r].Value.ToString(), bloodPre);
            ws2["B" + r].Value = fName;
            ws2["C" + r].Value = lName;
            ws2["D" + r].Value = age;
            ws2["E" + r].Value = weight;
            ws2["F" + r].Value = height;
            ws2["G" + r].Value = birthDate;
            ws2["H" + r].Value = bloodPre;
            ws2["I" + r].Value = gender;
            ws2["J" + r].Value = pregnet;
            ws2["K" + r].Value = smoke;
            ws2["L" + r].Value = food;
            ws2["M" + r].Value = ethni;
            ws2["N" + r].Value = WBC;
            ws2["O" + r].Value = Neut;
            ws2["P" + r].Value = Lymph;
            ws2["Q" + r].Value = RBC;
            ws2["R" + r].Value = HCT;
            ws2["S" + r].Value = Urea;
            ws2["T" + r].Value = Hb;
            ws2["U" + r].Value = Crtn;
            ws2["V" + r].Value = Iron;
            ws2["W" + r].Value = HDL;
            ws2["X" + r].Value = AP;
            ws2["Y" + r].Value = Diagnosis;
            ws2["Z" + r].Value = recommendation;
            wb2.SaveAs(filePath2);
        }
        public static string DocInExcel(string userName)
        {
            string pass = "";
            for (int i = 2; i <= ws1.Rows.Length; i++)
                if (ws1["A" + i].Value.Equals(userName))
                {
                    pass=ws1["B"+i].ToString();
                    break;
                }
                    
            return pass;
        }


        public static int PatientInExcel(string id)
        {
            int temp=-1;
            for (int i = 2; i <= ws2.Rows.Length; i++)
            {
                if (ws2["A" + i].Value.ToString()==id)
                {
                    temp= i;
                    break;
                }
            }
            return temp;
        }

        public static List<string> findInXL(int index)
        {
            List<string> list = new List<string>();
            list.Add(ws2["A" + index].Value.ToString());
            list.Add(ws2["B" + index].Value.ToString());
            list.Add(ws2["C" + index].Value.ToString());
            list.Add(ws2["D" + index].Value.ToString());
            list.Add(ws2["E" + index].Value.ToString());
            list.Add(ws2["F" + index].Value.ToString());
            list.Add(ws2["G" + index].Value.ToString());
            list.Add(ws2["H" + index].Value.ToString());
            list.Add(ws2["I" + index].Value.ToString());
            list.Add(ws2["J" + index].Value.ToString());
            list.Add(ws2["K" + index].Value.ToString());
            list.Add(ws2["L" + index].Value.ToString());
            list.Add(ws2["M" + index].Value.ToString());
            return list;
        }
        public static List<string> importBTest(int index)
        {
            List<string> lst = new List<string>();
            lst.Add(ws2["N" + index].Value.ToString());
            lst.Add(ws2["O" + index].Value.ToString());
            lst.Add(ws2["P" + index].Value.ToString());
            lst.Add(ws2["Q" + index].Value.ToString());
            lst.Add(ws2["R" + index].Value.ToString());
            lst.Add(ws2["S" + index].Value.ToString());
            lst.Add(ws2["T" + index].Value.ToString());
            lst.Add(ws2["U" + index].Value.ToString());
            lst.Add(ws2["V" + index].Value.ToString());
            lst.Add(ws2["W" + index].Value.ToString());
            lst.Add(ws2["X" + index].Value.ToString());
            return lst;

        }
        public static List<List<String>> infoFromDiagXL()
        {
            List <string>disease=new List<string> ();
            List <String> treat=new List<string>(); 
            List<List<String>> list=new List<List<String>> ();
           for (int i = 2; i < ws3.Rows.Length; i++)
                disease.Add (ws3["B"+i].ToString());              
            for (int i = 2; i < ws3.Rows.Length; i++)
                treat.Add(ws3["C" + i].ToString());
            list.Add(disease);
            list.Add(treat);
            return list;
        }
        public static string importDiagnosis(int index)
        {
            return ws2["Y" + index].ToString();
               
        }
        public static string importRec(int index)
        {
            return ws2["Z" + index].ToString();
        }


    }
}
