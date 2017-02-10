using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_OOP_Objek_I
{
    public partial class Form1 : Form
    {
        int cislo1;
        Student Student1;
        Zak zkouskatridy100;
        List<Student> SeznamStudentiku = new List<Student>();
        Zamestnanec borec = new Zamestnanec();

        public Form1()
        {
            InitializeComponent();

            Student1 = new Student();
            Student1.jmeno = "Karel";
            Student1.prijmeni = "Prtka";
            Student1.vek = 20;

            zkouskatridy100 = new Zak();
            zkouskatridy100.name = "Jirka";
            zkouskatridy100.surname = "Hornak";
            zkouskatridy100.cclass = 2;
            zkouskatridy100.age = 13;

            textBox2.Text += zkouskatridy100.name + " " + zkouskatridy100.surname + " " + zkouskatridy100.cclass + " " + zkouskatridy100.age;

            SeznamStudentiku = GenerateStudentList.GetStudents(100);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Student temp in SeznamStudentiku) // projdi cely seznam LIST krok po kroku a davej ho do temp [0], temp [1] atd ...
            {
                textBox1.Text += temp.jmeno + " " + temp.prijmeni + " " + temp.vek + Environment.NewLine;
            }

            textBox3.Text = borec.GetName() + " ";
            textBox3.Text += borec.GetSurname() + " ";
            textBox3.Text += borec.GetID() + " ";
            textBox3.Text += borec.GetHiringDate() + " ";
        }
    }
}
