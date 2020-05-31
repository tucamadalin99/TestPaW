using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    public class Student
    {
        public int cod;
        public string nume;
        public int nota;

        public Student(int c, string num, int n)
        {
            cod = c;
            nume = num;
            nota = n;
        }

        public override string ToString()
        {
            return "COD: " + cod + ", NUME: " + nume + " NOTA: " + nota; 
        }

    }
}
