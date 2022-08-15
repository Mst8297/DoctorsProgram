using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorsPro
{
    internal class MedicalDiag
    {
        public MedicalDiag() { }
        public int WBC(int age, int whiteCell)
        {
            int flag = -2;
            if (age > 17)
            {

                if (whiteCell < 4500)
                    flag = -1;
                else if (whiteCell > 11000)
                    flag = 1;
                else
                    flag = 0;
            }

            else if (4 < age && age <= 17)
            {
                if (whiteCell < 5500)
                    flag = -1;
                else if (whiteCell > 15500)
                    flag = 1;
                else
                    flag = 0;
            }

            else if (0 < age && age <= 4)
            {
                if (whiteCell < 6000)
                    flag = -1;
                else if (whiteCell > 17500)
                    flag = 1;
                else
                    flag = 0;
            }
            return flag;
        }
        
        public int Neut(int preNeut)
        {
            // the values are precentge -> %
            if (preNeut < 28) // 28%
                return -1;
            else if (preNeut > 54) //54 %
                return 1;
            else
                return 0;

        }

        public int Lymph(int preLymph)
        {
            // the values are precentge -> %
            if (preLymph < 36) // 36 %
                return -1;
            else if (preLymph > 52) // 52 %
                return 1;
            else
                return 0;

        }

        // Test 4:
        public int RBC(float preRbc)
        {
            // the values are precentge -> %
            if (preRbc < 4.5) // 4.5 %
                return -1;
            else if (preRbc > 6) // 6 %
                return 1;
            else
                return 0;
        }

        // Test 5:
        public int HCT(string sex, int rbcCapacitiy) // male = m , female = f // WE CAN CHANGE 'SEX' TO BOOL
        {
            int flag = -2;
            if (sex == "Male")
            {
                // the values are precentge -> %
                if (rbcCapacitiy < 37)
                    flag = -1;
                else if (rbcCapacitiy > 54)
                    flag = 1;
                else
                    flag = 0;

            }

            else if (sex == "Female")
            {
                // the values are precentge -> %
                if (rbcCapacitiy < 33) // 4.5 %
                    flag = -1;
                else if (rbcCapacitiy > 47) // 6 %
                    flag = 1;
                else
                    flag = 0;

            }
            return flag;
        }

        // Test 6:
        public int Urea(bool eastern, float ur,string pregnet)
        {
            int flag= -2;
            if (pregnet == "No")
            {
                if (eastern == false)
                {
                    if (ur < 17)
                        flag= -1;
                    else if (ur > 43)
                        flag = 1;
                    else
                        flag = 0;
                }

                else if (eastern == true)
                {
                    if (ur < 17 * 1.1)
                        flag = -1;
                    else if (ur > 43 * 1.1)
                        flag = 1;
                    else
                        flag = 0;
                }
            }
            else
            {
                if (eastern == false)
                {
                    if (ur < 17)
                        flag = 0;
                    else if (ur > 43)
                        flag = 1;
                    else
                        flag = 0;
                }

                else if (eastern == true)
                {
                    if (ur < 17 * 1.1)
                        flag = 0;
                    else if (ur > 43 * 1.1)
                        flag = 1;
                    else
                        flag = 0;
                }
            }
            return flag;

        }
           

        // Test 7:
        public int Hb(int age, string sex, float hb)
        {
            int flag = -2;
            if (age > 17)
            {
                if (sex == "Male") // male
                {
                    if (hb < 12)
                        flag = -1;
                    else if (hb > 18)
                        flag = 1;
                    else
                        flag = 0;
                }

                else // female
                {
                    if (hb < 12)
                        flag = -1;
                    else if (hb > 18)
                        flag = 1;
                    else
                        flag = 0;
                }

            }

            else if (0 <= age && age <= 17)
            {

                if (hb < 11.5)
                    flag = -1;
                else if (hb > 15.5)
                    flag = 1;
                else
                    flag = 0;
            }
            return flag;
            // print illigale value

        }

        // Test 8:
        public int Crtn(int age, float cr)
        {
            int flag = -2;
            if (age > 60) // elders
            {
                if (cr < 0.6)
                    flag = -1;
                else if (cr > 1.2)
                    flag = 1;
                else
                    flag = 0;
            }

            else if (18 <= age && age <= 59) // adults
            {
                if (cr < 0.6)
                    flag = -1;
                else if (cr > 1.0)
                    flag = 1;
                else
                    flag = 0;

            }

            else if (3 <= age && age <= 17) // kids & teens
            {
                if (cr < 0.5)
                    flag = -1;
                else if (cr > 1.0)
                    flag = 1;
                else
                    flag = 0;

            }

            else if (0 <= age && age <= 2) // babies
            {
                if (cr < 0.2)
                    flag = -1;
                else if (cr > 0.5)
                    flag = 1;
                else
                    flag = 0;

            }
            return flag;
        }

        // Test 9:
        public int Iron(string sex, int ir)
        {
            if (sex == "Male") // male
            {
                if (ir < 60)
                    return -1;
                else if (ir > 160)
                    return 1;
                else
                    return 0;
            }

            else // female
            {
                if (ir < 60 * 0.8)
                    return -1;
                else if (ir > 160 * 0.8)
                    return 1;
                else
                    return 0;
            }

        }

        // Test 10:
        public int HDL(bool ethi, string sex, float mgHDL) // 'ethi' = ethiopian-> T/F
        {
            if (ethi == false) // not ethiopian
            {

                if (sex == "Male") // male
                {
                    if (mgHDL < 29)
                        return -1;
                    else if (mgHDL > 62)
                        return 1;
                    else
                        return 0;
                }

                else // female
                {
                    if (mgHDL < 34)
                        return -1;
                    else if (mgHDL > 82)
                        return 1;
                    else
                        return 0;
                }
            }

            else // ethiopian
            {
                if (sex == "Male") // male
                {
                    if (mgHDL < 29 * 1.2)
                        return -1;
                    else if (mgHDL > 62 * 1.2)
                        return 1;
                    else
                        return 0;
                }

                else // female
                {
                    if (mgHDL < 34 * 1.2)
                        return -1;
                    else if (mgHDL > 82 * 1.2)
                        return 1;
                    else
                        return 0;
                }

            }

        }

        // Test 11:
        public int Ap(bool eastern, int apPH)
        {
            if (eastern == true)
            {
                if (apPH < 60)
                    return -1;
                else if (apPH > 120)
                    return 1;
                else
                    return 0;
            }

            else // not eastern
            {
                if (apPH < 30)
                    return -1;
                else if (apPH > 90)
                    return 1;
                else
                    return 0;
            }


        }
    }
}
