using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    public class Rezervari
    {
        private int cod;
        private List<Hotel> listHoteluri;

        public Rezervari(int c)
        {
            cod = c;
            listHoteluri = new List<Hotel>();
        }

        public List<Hotel> ListaHoteluri
        {
            get { return listHoteluri; }
            set
            {
                if (value != null)
                    listHoteluri = value;
            }
        }

        public static Rezervari operator+(Rezervari r, Hotel c)
        {
            r.listHoteluri.Add(c);
            return r;
        }
    }
}
