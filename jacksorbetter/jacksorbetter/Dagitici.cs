using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace jacksorbetter
{
    class Dagitici
    {
        public int[] deste = new int[53];
        private int sayac = 1;
        
        public void Karistir()
        {
            int rastgeleSayi;
            for (int i = 1; i < 53; i++)
            {
                while (true)
                {
                    Random r = new Random();
                    rastgeleSayi = r.Next(1,53);
                    if (deste[rastgeleSayi] == 0)
                    {
                        deste[rastgeleSayi] = i;
                        break;
                    }
                }
            }
        }
        
        public List<Kart> Dagit(int[] deste, int adet)
        {
            List<Kart> El = new List<Kart>();
            for (int i = sayac; i < sayac + adet; i++)
            {
                Kart yeni = new Kart(deste[i]);
                El.Add(yeni);
            }
            sayac += adet;
            return El;
        }
    }
}
