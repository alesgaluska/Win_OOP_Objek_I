using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win_OOP_Objek_I
{
    public class Zamestnanec
    {
        string name = "Lojza";
        string surname = "Prducha";
        int ID = 10;
        string hiringdate = "28.2.2016";
        
        public string GetName()
        {
            return name;
        }
        public string GetSurname()
        {
            return surname;
        }
        public int GetID()
        {
            return ID;
        }
        public string GetHiringDate()
        {
            return hiringdate;
        }
    }
}
