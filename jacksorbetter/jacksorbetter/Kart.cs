using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace jacksorbetter
{
    class Kart
    {
        public int sayi;
        public string sinif;
        private string imgPath;   
        public Image resim;

        public Kart(int sayi)
        {
            if (sayi <= 13)
            {
                if(sayi<10)
                    imgPath = System.IO.Directory.GetCurrentDirectory() + "\\dood_deck\\" + "10" + sayi.ToString() + ".gif";
                else
                    imgPath = System.IO.Directory.GetCurrentDirectory() + "\\dood_deck\\" + "1" + sayi.ToString() + ".gif";
                this.sinif = "Karo";
                this.sayi = sayi;
                resim=System.Drawing.Image.FromFile(imgPath);
            }
            else if (13 < sayi && sayi <= 26)
            {
                imgPath = System.IO.Directory.GetCurrentDirectory() + "\\dood_deck\\" + "1" + sayi.ToString() + ".gif";
                this.sinif = "Sinek";
                this.sayi = (sayi % 13);
                resim = System.Drawing.Image.FromFile(imgPath);
            }
            else if (26 < sayi && sayi <= 39)
            {
                imgPath = System.IO.Directory.GetCurrentDirectory() + "\\dood_deck\\" + "1" + sayi.ToString() + ".gif";
                this.sinif = "Kupa";
                this.sayi = (sayi % 13);
                resim = System.Drawing.Image.FromFile(imgPath);
            }
            else if (39 < sayi && sayi <= 52)
            {
                imgPath = System.IO.Directory.GetCurrentDirectory() + "\\dood_deck\\" + "1" + sayi.ToString() + ".gif";
                this.sinif = "Maca";
                this.sayi = (sayi % 13);
                resim = System.Drawing.Image.FromFile(imgPath);
            }
            if (this.sayi == 0)
                this.sayi = 13;
        }
    }
}
