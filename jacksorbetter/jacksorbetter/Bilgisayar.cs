using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace jacksorbetter
{
    class Bilgisayar
    {
        public int index = -1;
        
        public Bilgisayar(Oyuncu oyuncu)
        {
            Sirala(oyuncu.hand);
            if (SinifKontrolu(oyuncu.hand))
                index = Flush(oyuncu.hand);
            else
                index = FlushDegil(oyuncu.hand);

            if(index!=-1)
            {
                switch(index)
                {
                    case 0: // Royal Flush
                        oyuncu.sp += 250 * oyuncu.bet;
                        break;
                    case 1: // Straight Flush
                        oyuncu.sp += 50 * oyuncu.bet;
                        break;
                    case 2: //Four of Kind
                        oyuncu.sp += 25 * oyuncu.bet;
                        break;
                    case 3: // Full House
                        oyuncu.sp += 9 * oyuncu.bet;
                        break;
                    case 4: //Flush
                        oyuncu.sp += 6 * oyuncu.bet;
                        break;
                    case 5: // Straight
                        oyuncu.sp += 4 * oyuncu.bet;
                        break;
                    case 6: // Three of Kind
                        oyuncu.sp += 3 * oyuncu.bet;
                        break;
                    case 7: // Two Pair
                        oyuncu.sp += 2 * oyuncu.bet;
                        break;
                    case 8: // Jacks or Better
                        oyuncu.sp += 1 * oyuncu.bet;
                        break;
                }
            }
        }
        
        private void Sirala(List<Kart> hand)
        {
            for (int i = 0; i < hand.Count - 1; i++)
            {
                for (int j = i + 1; j < hand.Count; j++)
                {
                    if (hand[i].sayi > hand[j].sayi)
                    {
                        Kart temp = hand[i];
                        hand[i] = hand[j];
                        hand[j] = temp;
                    }
                }
            }
        }
        
        private bool SinifKontrolu(List<Kart> hand)
        {
            bool flag = true;
            foreach (Kart k in hand)
            {
                if (k.sinif != hand[0].sinif)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
        
        private int Flush(List<Kart> hand)
        {
            if (hand[0].sayi == 1 && hand[1].sayi == 10 && hand[2].sayi == 11 && hand[3].sayi == 12 && hand[4].sayi == 13)
                return 0; // royal flush
            else if (hand[0].sayi + 1 == hand[1].sayi && hand[0].sayi + 2 == hand[2].sayi && hand[0].sayi + 3 == hand[3].sayi && hand[0].sayi + 4 == hand[4].sayi)
                return 1; // straight flush
            else
                return 4; // flush
        }
        
        private int FlushDegil(List<Kart> hand)
        {
            int[] dizi = new int[5] { 1, 1, 1, 1, 1 };
            int k = 0;

            for (int i = 0; i < 4; i++)
            {
                if (hand[i].sayi == hand[i + 1].sayi)
                    dizi[k]++;
                else 
                    k++;
            }

            if (dizi.Contains<int>(4))
                return 2; // four of a kind
            else if (dizi.Contains<int>(2) && dizi.Contains<int>(3))
                return 3; // full house
            else if (hand[0].sayi + 1 == hand[1].sayi && hand[0].sayi + 2 == hand[2].sayi && hand[0].sayi + 3 == hand[3].sayi && hand[0].sayi + 4 == hand[4].sayi)
                return 5; // straight
            else if (hand[0].sayi == 1 && hand[1].sayi == 10 && hand[2].sayi == 11 && hand[3].sayi == 12 && hand[4].sayi == 13)
                return 5; // straight
            else if (dizi.Contains<int>(3))
                return 6; // three of a kind
            else if (dizi.Contains<int>(2))
            {
                int temp = 0;
                foreach (int i in dizi)
                    if (i == 2)
                        temp++;
                if (temp == 2)
                    return 7; //two pair
                else
                    return Jack(hand);
            }
            else return -1;
        }
        
        private int Jack(List<Kart> hand)
        {
            int[] dizi = new int[4] { 0, 0, 0, 0 };
            foreach (Kart k in hand)
            {
                if (k.sayi == 11)
                    dizi[0]++;
                if (k.sayi == 12)
                    dizi[1]++;
                if (k.sayi == 13)
                    dizi[2]++;
                if (k.sayi == 1)
                    dizi[3]++;
            }
            if (dizi.Contains<int>(2))
                return 8; // jacks or better
            else
                return -1; 
        }
    }
}
