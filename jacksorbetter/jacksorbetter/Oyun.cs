using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace jacksorbetter
{
    public partial class Oyun : Form
    {
        int lv_sn = 8, sp_sn = 0, kart_sn = 0, sayi, secilmemiskart = 5;
        Dagitici dagitici;
        Oyuncu oyuncu = new Oyuncu();
        Bilgisayar bilgisayar;
        List<Button> kartButonlari = new List<Button>();
        Color color = Color.FromArgb(255, 0, 64, 0);
        Color color2 = Color.FromArgb(178, 34, 34);

        public Oyun()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dagitici = new Dagitici();
            dagitici.Karistir();
            oyuncu.hand = dagitici.Dagit(dagitici.deste, 5);
            holdButton.Enabled = false;
            kartButonlari.Add(kart1_button);
            kartButonlari.Add(kart2_button);
            kartButonlari.Add(kart3_button);
            kartButonlari.Add(kart4_button);
            kartButonlari.Add(kart5_button);

            foreach (Button kart in kartButonlari)
                kart.Enabled = false;

            hold1_label.Visible = false;
            hold2_label.Visible = false;
            hold3_label.Visible = false;
            hold4_label.Visible = false;
            hold5_label.Visible = false;

            string ad = "Royal Flush";
            string bet1 = "250";
            string bet2 = "500";
            string bet3 = "750";
            string bet4 = "1000";
            string bet5 = "4000";
            string[] bilgiler = { ad, bet1, bet2, bet3, bet4, bet5 };
            kombinasyonTablosu.Items.Add(new ListViewItem(bilgiler));

            ad = "Straight Flush";
            bet1 = "50";
            bet2 = "100";
            bet3 = "150";
            bet4 = "200";
            bet5 = "250";
            string[] bilgiler1 = { ad, bet1, bet2, bet3, bet4, bet5 };
            kombinasyonTablosu.Items.Add(new ListViewItem(bilgiler1));

            ad = "Four of a Kind";
            bet1 = "25";
            bet2 = "50";
            bet3 = "75";
            bet4 = "100";
            bet5 = "125";
            string[] bilgiler2 = { ad, bet1, bet2, bet3, bet4, bet5 };
            kombinasyonTablosu.Items.Add(new ListViewItem(bilgiler2));

            ad = "Full House";
            bet1 = "9";
            bet2 = "18";
            bet3 = "27";
            bet4 = "36";
            bet5 = "45";
            string[] bilgiler3 = { ad, bet1, bet2, bet3, bet4, bet5 };
            kombinasyonTablosu.Items.Add(new ListViewItem(bilgiler3));

            ad = "Flush";
            bet1 = "6";
            bet2 = "12";
            bet3 = "18";
            bet4 = "24";
            bet5 = "30";
            string[] bilgiler4 = { ad, bet1, bet2, bet3, bet4, bet5 };
            kombinasyonTablosu.Items.Add(new ListViewItem(bilgiler4));

            ad = "Straight";
            bet1 = "4";
            bet2 = "8";
            bet3 = "12";
            bet4 = "16";
            bet5 = "20";
            string[] bilgiler5 = { ad, bet1, bet2, bet3, bet4, bet5 };
            kombinasyonTablosu.Items.Add(new ListViewItem(bilgiler5));

            ad = "Three of a Kind";
            bet1 = "3";
            bet2 = "6";
            bet3 = "9";
            bet4 = "12";
            bet5 = "15";
            string[] bilgiler6 = { ad, bet1, bet2, bet3, bet4, bet5 };
            kombinasyonTablosu.Items.Add(new ListViewItem(bilgiler6));

            ad = "Two Pair";
            bet1 = "2";
            bet2 = "4";
            bet3 = "6";
            bet4 = "8";
            bet5 = "10";
            string[] bilgiler7 = { ad, bet1, bet2, bet3, bet4, bet5 };
            kombinasyonTablosu.Items.Add(new ListViewItem(bilgiler7));

            ad = "Jacks or Better";
            bet1 = "1";
            bet2 = "2";
            bet3 = "3";
            bet4 = "4";
            bet5 = "5";
            string[] bilgiler8 = { ad, bet1, bet2, bet3, bet4, bet5 };
            kombinasyonTablosu.Items.Add(new ListViewItem(bilgiler8));
        }

        private void kart1_Click(object sender, EventArgs e)
        {
            if (!hold1_label.Visible)
            {
                secilmemiskart--;
                hold1_label.Visible = true;
                kart1_button.BackColor = Color.Green;
            }
            else
            {
                hold1_label.Visible = false;
                secilmemiskart++;
                kart1_button.BackColor = Color.Red;
            }
        }

        private void kart2_Click(object sender, EventArgs e)
        {
            if (!hold2_label.Visible)
            {
                hold2_label.Visible = true;
                secilmemiskart--;
                kart2_button.BackColor = Color.Green;
            }
            else
            {
                hold2_label.Visible = false;
                secilmemiskart++;
                kart2_button.BackColor = Color.Red;
            }
        }

        private void kart3_Click(object sender, EventArgs e)
        {
            if (!hold3_label.Visible)
            {
                hold3_label.Visible = true;
                secilmemiskart--;
                kart3_button.BackColor = Color.Green;
            }
            else
            {
                hold3_label.Visible = false;
                secilmemiskart++;
                kart3_button.BackColor = Color.Red;
            }
        }

        private void kart4_Click(object sender, EventArgs e)
        {
            if (!hold4_label.Visible)
            {
                hold4_label.Visible = true;
                secilmemiskart--;
                kart4_button.BackColor = Color.Green;
            }
            else
            {
                hold4_label.Visible = false;
                secilmemiskart++;
                kart4_button.BackColor = Color.Red;
            }
        }

        private void kart5_Click(object sender, EventArgs e)
        {
            if (!hold5_label.Visible)
            {
                hold5_label.Visible = true;
                secilmemiskart--;
                kart5_button.BackColor = Color.Green;
            }
            else
            {
                hold5_label.Visible = false;
                secilmemiskart++;
                kart5_button.BackColor = Color.Red;
            }
        }

        private void dealDraw_button_Click(object sender, EventArgs e)
        {
            if (dealDraw_button.Text == "Deal")
            {
                holdButton.Enabled = true;
                dealDraw_button.Enabled = false;
                oyuncu.sp -= oyuncu.bet;
                sp_label.Text = (oyuncu.sp.ToString() + " Sp");
                foreach (Button kart in kartButonlari)
                    kart.BackColor = Color.Red;
                
                int i = 0;
                foreach (Button kart in kartButonlari)
                {
                    kart.Image = oyuncu.hand[i++].resim;
                    kart.Enabled = true;
                }
                betMax_button.Enabled = false;
                betOne_button.Enabled = false;
                dealDraw_button.Enabled = true;
                dealDraw_button.Text = "Draw";
            }
            else
            {
                dealDraw_button.Enabled = false;
                List<Kart> yenikartlar = new List<Kart>();
                yenikartlar = dagitici.Dagit(dagitici.deste, secilmemiskart);
                int i = 0, j = 0;
                foreach (Button kart in kartButonlari)
                {
                    if (kart.BackColor == Color.Red)
                    {
                        int inx = kartButonlari.IndexOf(kart);
                        kart.Image = yenikartlar[i].resim;
                        oyuncu.hand.Remove(oyuncu.hand[inx - j]);
                        j++;
                        i++;
                    }
                }
                foreach (Kart kart in yenikartlar)
                    oyuncu.hand.Add(kart);

                bilgisayar = new Bilgisayar(oyuncu);

                hold1_label.Visible = false;
                hold2_label.Visible = false;
                hold3_label.Visible = false;
                hold4_label.Visible = false;
                hold5_label.Visible = false;
                betMax_button.Enabled = true;
                betOne_button.Enabled = true;
                dealDraw_button.Text = "Deal";
                dealDraw_button.Enabled = false;
                holdButton.Enabled = false;
                timer_listview.Start();
            }
        }

        private void betOne_button_Click(object sender, EventArgs e)
        {
            kombinasyonTablosu.Columns[1].Text = "";
            kombinasyonTablosu.Columns[2].Text = "";
            kombinasyonTablosu.Columns[3].Text = "";
            kombinasyonTablosu.Columns[4].Text = "";
            kombinasyonTablosu.Columns[5].Text = "";

            oyuncu.bet++;
            if (oyuncu.bet == 6)
                oyuncu.bet = 1;
            kombinasyonTablosu.Columns[oyuncu.bet].Text = oyuncu.bet.ToString();
        }

        private void betMax_button_Click(object sender, EventArgs e)
        {
            oyuncu.bet = 5;
            kombinasyonTablosu.Columns[1].Text = "";
            kombinasyonTablosu.Columns[2].Text = "";
            kombinasyonTablosu.Columns[3].Text = "";
            kombinasyonTablosu.Columns[4].Text = "";
            kombinasyonTablosu.Columns[5].Text = "";
            kombinasyonTablosu.Columns[oyuncu.bet].Text = oyuncu.bet.ToString();
        }

        private void timer_listview_Tick(object sender, EventArgs e)
        {
            kart_sn = 0;
            if (lv_sn >= bilgisayar.index && bilgisayar.index != -1)
            {
                ListView listView = this.kombinasyonTablosu;
                kombinasyonTablosu.Items[lv_sn].BackColor = color2;
                if (lv_sn != 8)
                    kombinasyonTablosu.Items[lv_sn + 1].BackColor = color;
                lv_sn--;
            }
            else
            {
                timer_listview.Stop();
                lv_sn = 8;
                timer_sp.Start();
                try
                {
                    sayi = Convert.ToInt16(sp_label.Text.Substring(0, 3));
                }
                catch
                {
                    try
                    {
                        sayi = Convert.ToInt16(sp_label.Text.Substring(0, 2));
                    }
                    catch
                    {
                        sayi = Convert.ToInt16(sp_label.Text.Substring(0, 1));
                    }
                }

            }
        }

        private void timer_sp_Tick(object sender, EventArgs e)
        {
            lv_sn = 8;
            if (sp_sn < oyuncu.sp - sayi && bilgisayar.index != -1)
            {
                try
                {
                    sp_label.Text = (Convert.ToInt16(sp_label.Text.Substring(0, 3)) + 1).ToString() + " Sp";
                }
                catch
                {
                    try
                    {
                        sp_label.Text = (Convert.ToInt16(sp_label.Text.Substring(0, 2)) + 1).ToString() + " Sp";
                    }
                    catch
                    {
                        sp_label.Text = (Convert.ToInt16(sp_label.Text.Substring(0, 1)) + 1).ToString() + " Sp";
                    }
                }
            }

            
            if (sp_sn == oyuncu.sp - sayi || bilgisayar.index == -1)
            {
                try
                {
                    if (bilgisayar.index != -1)
                        kombinasyonTablosu.Items[bilgisayar.index].BackColor = color;
                }
                catch
                {
                }
                timer_sp.Stop();
                dagitici = new Dagitici();
                dagitici.Karistir();
                oyuncu.hand = dagitici.Dagit(dagitici.deste, 5);
                timer_kartlar.Start();
            }
            sp_sn++;
        }

        private void timer_kartlar_Tick(object sender, EventArgs e)
        {
            sp_sn = 0;
            switch(kart_sn)
            {
                case 0:
                    hold1_label.Visible = false;
                    break;
                case 1:
                    hold2_label.Visible = false;
                    break;
                case 2:
                    hold3_label.Visible = false;
                    break;
                case 3:
                    hold4_label.Visible = false;
                    break;
                case 4:
                    hold5_label.Visible = false;
                    break;
                default:
                    break;
            }
            if (kart_sn < 5)
            {
                kartButonlari[kart_sn].Image = System.Drawing.Image.FromFile(System.IO.Directory.GetCurrentDirectory() + "\\dood_deck\\" + "155.gif");
                kartButonlari[kart_sn].BackColor = Color.Red;
            }
            else
            {
                kart_sn = 0;
                
                foreach (Button kart in kartButonlari)
                {
                    kart.Enabled = false;
                    kart.BackColor = Color.Red;
                }
                hold1_label.Visible = false;
                hold2_label.Visible = false;
                hold3_label.Visible = false;
                hold4_label.Visible = false;
                hold5_label.Visible = false;
                secilmemiskart = 5;
                if (oyuncu.sp >= 1000)
                {
                    MessageBox.Show("You have reached maximum sp. The game will ended. Goodbye, " + oyuncu.username + "!", "Congratulations :)");
                    Application.Exit();
                }
                if (oyuncu.sp <= 0)
                {
                    MessageBox.Show("Game over. Goodbye, " + oyuncu.username + "!", ":(");
                    Application.Exit();
                }
                dealDraw_button.Enabled = true;
                timer_kartlar.Stop();
            }
            kart_sn++;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            oyuncu.username = username_textBox.Text;
            oyuncu.username = StringFormat(oyuncu.username);
            isim_label.Text += oyuncu.username + "!";
            username_label.Visible = false;
            username_textBox.Visible = false;
            Start_Button.Visible = false;
            isim_label.Visible = true;
            sp_label.Visible = true;
            kombinasyonTablosu.Visible = true;
            foreach (Button kart in kartButonlari)
                kart.Visible = true;
            betOne_button.Visible = true;
            betMax_button.Visible = true;
            dealDraw_button.Visible = true;
            holdButton.Visible = true;
        }

        private string StringFormat(string text)
        {
            System.Globalization.CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            System.Globalization.TextInfo textInfo = cultureInfo.TextInfo;
            return textInfo.ToTitleCase(text);
        }

        private void HoldButton_Click(object sender, EventArgs e)
        {
            foreach (Button kart in kartButonlari)
            {
                kart.BackColor = Color.Green;
                secilmemiskart = 0;
            }
            hold1_label.Visible = true;
            hold2_label.Visible = true;
            hold3_label.Visible = true;
            hold4_label.Visible = true;
            hold5_label.Visible = true;
            
        }

        private void kombinasyonTablosu_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = kombinasyonTablosu.Columns[e.ColumnIndex].Width;
        }

        private void kombinasyonTablosu_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in kombinasyonTablosu.SelectedItems)
                item.Selected = false;
        }
    }
}
