using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    [Serializable]
    public class Hotel
    {
        private int nrCamere;
        private string numeHotel;
        private float[] pretCamere;

        public Hotel(int nrC, string num, float[] pretC)
        {
            NrCamere = nrC;
            NumeHotel = num;
            pretCamere = new float[pretC.Length];
            for(int i = 0; i < pretCamere.Length; i++)
            {
                pretCamere[i] = pretC[i];
            }
        }

        public int NrCamere { get => nrCamere; set => nrCamere = value; }
        public string NumeHotel { get => numeHotel; set => numeHotel = value; }
        public float[] PretCamere { get => pretCamere; set => pretCamere = value; }

        public override string ToString()
        {
           string res = "Hotelul: " + numeHotel + ", Are: " + nrCamere + " camere: ";
            if(pretCamere != null)
            {
                res += "Are urmatoarele camere disponibile: ";
                for (int i = 0; i < pretCamere.Length; i++)
                    res += pretCamere[i] + " ";
            }
            else
            {
                res += "Nu are camere disponibile!";
            }

            return res;
        }
    }
}
