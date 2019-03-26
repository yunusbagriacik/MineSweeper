using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayinTarlasiOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[,] mayinlar = new int[10, 10];

        private void Form1_Load(object sender, EventArgs e)
        {
            tarlayiOlustur();
            mayinlariOlustur(10);
            //mayinlariGoster();
        }


        // CTRL + M + O (Kodları Kapatır)
        // CTRL + M + P (Kodları Açar)

        void mayinlariOlustur(int mayinSayisi)
        {
            lbl_mayinSayisi.Text = mayinSayisi.ToString();
            Random rnd = new Random();

            for (int i = 0; i < mayinSayisi; i++)
            {
                int x = rnd.Next(0, 10);
                int y = rnd.Next(0, 10);

                if (mayinlar[x, y] == 1)
                {
                    i--;
                }
                mayinlar[x, y] = 1;

            }
        }

        void tarlayiOlustur()
        {
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    Button btn = new Button();
                    btn.Width = 40;
                    btn.Height = 40;
                    btn.Left = (x * (btn.Width)) + 50;
                    btn.Top = (y * (btn.Height)) + 80;
                    btn.Name = x.ToString() + y.ToString();
                    btn.Click += btn_Click;
                    btn.MouseUp += btn_MouseUp;
                    btn.MouseDown += btn_MouseDown;

                    this.Controls.Add(btn);

                }
            }
        }
        void mayinlariGoster()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button && c.Name != "btn_YeniOyun")
                {
                    int x = int.Parse(c.Name.Substring(0, 1));
                    int y = int.Parse(c.Name.Substring(1, 1));

                    if (mayinlar[x, y] == 1)
                    {
                        c.BackColor = Color.Yellow;
                    }

                }
            }
        }
        void oyunuBitir()
        {
            timer1.Stop();
            btn_YeniOyun.BackgroundImage = Properties.Resources.logo_dead;
            DialogResult dl =
            MessageBox.Show("Kaybettiniz! Yeniden Oynamak İster Misiniz?", ":(", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dl == DialogResult.Yes)
            {
                Application.Restart();
            }
            else
            {
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_Sure.Text = (Convert.ToInt32(lbl_Sure.Text) + 1).ToString();

        }

        private void btn_YeniOyun_Click(object sender, EventArgs e)
        {
            Array.Clear(mayinlar, 0, mayinlar.Length);
            mayinlariOlustur(10);
            tahtayiTemizle();
            mayinlariGoster();
            lbl_Sure.Text = "0";
            timer1.Start();


        }

        void tahtayiTemizle()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button && c.Name != "btn_YeniOyun")
                {
                    c.Text = "";
                    c.BackgroundImage = null;
                    c.BackColor = Color.Transparent;
                }
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button tiklanan = (Button)sender;
            int x = int.Parse(tiklanan.Name.Substring(0, 1));
            int y = int.Parse(tiklanan.Name.Substring(1, 1));

            if (mayinlar[x, y] == 1)
            {
                oyunuBitir();
            }
            else
            {
                int toplam_Mayin = 0;

                try
                {
                    toplam_Mayin += mayinlar[x - 1, y - 1];
                }
                catch { };

                try
                {
                    toplam_Mayin += mayinlar[x, y - 1];
                }
                catch { };

                try
                {
                    toplam_Mayin += mayinlar[x + 1, y - 1];
                }
                catch { };
                
                try
                {
                    toplam_Mayin += mayinlar[x - 1, y];
                }
                catch { };
                try
                {
                    toplam_Mayin += mayinlar[x + 1, y];
                }
                catch { };

                try
                {
                    toplam_Mayin += mayinlar[x - 1, y + 1];
                }
                catch { };

                try
                {
                    toplam_Mayin += mayinlar[x, y + 1];
                }
                catch { };

                try
                {
                    toplam_Mayin += mayinlar[x + 1, y + 1];
                }
                catch { };


                tiklanan.Text = toplam_Mayin.ToString();

            }
        }
        private void btn_MouseUp(object sender, MouseEventArgs e)
        {
            btn_YeniOyun.BackgroundImage = Properties.Resources.logo;

            if (e.Button == MouseButtons.Right)
            {

                Button tiklanan = (Button)sender;

                if (tiklanan.BackgroundImage == null)
                {
                    tiklanan.BackgroundImage = Properties.Resources.flag;
                    tiklanan.BackgroundImageLayout = ImageLayout.Stretch;
                    lbl_mayinSayisi.Text = (int.Parse(lbl_mayinSayisi.Text) - 1).ToString();
                    tiklanan.Tag = "mayin";
                }
                else
                {
                    tiklanan.BackgroundImage = null;
                    lbl_mayinSayisi.Text = (int.Parse(lbl_mayinSayisi.Text) + 1).ToString();
                }
            }

            kazananiKontrolEt();



        }
        int mayinVarMi(Button btn)
        {
            int x = int.Parse(btn.Name.Substring(0, 1));
            int y = int.Parse(btn.Name.Substring(1, 1));

            return mayinlar[x, y];
        }

        void kazananiKontrolEt()
        {
            int isaretli_sayisi = 0;
            int dogru_isaretli_sayisi = 0;
            foreach (Control c in this.Controls)
            {

                if(c is Button && c.Name != "btn_YeniOyun")
                {
                    Button x = (Button)c;

                    if(c.BackgroundImage != null && mayinVarMi(x)==1) 
                    {
                        dogru_isaretli_sayisi++;
                    }
                    if(c.BackgroundImage != null)
                    {
                        isaretli_sayisi++;
                    }

                }
            }
            if(dogru_isaretli_sayisi == 10 && dogru_isaretli_sayisi==isaretli_sayisi)
            {
                MessageBox.Show("Kazandiniz!");
            }
        }

        private void btn_MouseDown(object sender, MouseEventArgs e)
        {
            btn_YeniOyun.BackgroundImage = Properties.Resources.logo_what;

        }
    }
}
