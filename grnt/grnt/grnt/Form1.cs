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

namespace görüntüişleme1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //YÜKLE
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.DefaultExt = ".jpg";
                openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
                openFileDialog1.ShowDialog();
                String ResminYolu = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(ResminYolu);
            }
            catch { }
        }
        //RESMİ PİKSEL OLARAK AKTAR
        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Picturebox'da Resim yok!");
                return;
            }

            Color OkunanRenk, DonusenRenk;
            int R = 0, G = 0, B = 0;
            Bitmap GirisResmi, CikisResmi;
            GirisResmi = new Bitmap(pictureBox1.Image);
            int ResimGenisligi = GirisResmi.Width;
            int ResimYuksekligi = GirisResmi.Height;
            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
            int i = 0, j = 0; //Çıkış resminin x ve y si olacak.
            for (int x = 0; x < ResimGenisligi; x++)
            {
                for (int y = 0; y < ResimYuksekligi; y++)
                {
                    OkunanRenk = GirisResmi.GetPixel(x, y);
                    R = OkunanRenk.R;
                    G = OkunanRenk.G;
                    B = OkunanRenk.B;
                    DonusenRenk = Color.FromArgb(R, G, B);
                    CikisResmi.SetPixel(x, y, DonusenRenk);
                }
            }
            pictureBox2.Image = CikisResmi;
        }
        //NEGATİF
        private void button3_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Picturebox'da Resim yok!");
                return;
            }

            Color OkunanRenk, DonusenRenk;
            int R = 0, G = 0, B = 0;
            Bitmap GirisResmi, CikisResmi;
            GirisResmi = new Bitmap(pictureBox1.Image);
            int ResimGenisligi = GirisResmi.Width;
            //GirisResmi global tanımlandı. İçerisine görüntü 
            //yüklendi.
            int ResimYuksekligi = GirisResmi.Height;
            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);

            //Cikis resmini oluşturuyor. 
            //Boyutları giriş resmi ile aynı olur. Tanımlaması globalde yapıldı.
            int i = 0, j = 0; //Çıkış resminin x ve y si olacak.
            for (int x = 0; x < ResimGenisligi; x++)
            {
                for (int y = 0; y < ResimYuksekligi; y++)
                {
                    OkunanRenk = GirisResmi.GetPixel(x, y);
                    R = 255 - OkunanRenk.R;
                    G = 255 - OkunanRenk.G;
                    B = 255 - OkunanRenk.B;
                    DonusenRenk = Color.FromArgb(R, G, B);
                    CikisResmi.SetPixel(x, y, DonusenRenk);
                }
            }
            pictureBox2.Image = CikisResmi;

        }
        //GRİ TON
        private void button4_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Picturebox'da Resim yok!");
                return;
            }



            Color OkunanRenk, DonusenRenk;

            Bitmap GirisResmi = new Bitmap(pictureBox1.Image);
            int ResimGenisligi = GirisResmi.Width; //GirisResmi global tanımlandı. Fonksiyonla gelmedi.
            int ResimYuksekligi = GirisResmi.Height;
            Bitmap CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
            //Cikis resmini 
            //oluşturuyor. Boyutları giriş resmi ile aynı olur.
            int GriDeger = 0;
            for (int x = 0; x < ResimGenisligi; x++)
            {
                for (int y = 0; y < ResimYuksekligi; y++)
                {
                    OkunanRenk = GirisResmi.GetPixel(x, y);
                    double R = OkunanRenk.R;
                    double G = OkunanRenk.G;
                    double B = OkunanRenk.B;
                    //GriDeger = Convert.ToInt16((R + G + B) / 3); 

                    GriDeger = Convert.ToInt16(R * 0.3 + G * 0.6 + B * 0.1);
                    DonusenRenk = Color.FromArgb(GriDeger, GriDeger, GriDeger);
                    CikisResmi.SetPixel(x, y, DonusenRenk);
                }
            }
            pictureBox2.Image = CikisResmi;
        }
        //EŞİKLEME
        private void button5_Click(object sender, EventArgs e)
        {

            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Picturebox'da Resim yok!");
                return;
            }


            Color OkunanRenk, DonusenRenk;

            Bitmap GirisResmi = new Bitmap(pictureBox1.Image);
            int ResimGenisligi = GirisResmi.Width; //GirisResmi global tanımlandı. Fonksiyonla gelmedi.
            int ResimYuksekligi = GirisResmi.Height;
            Bitmap CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
            //Cikis resmini oluşturuyor. Boyutları giriş resmi ile aynı olur.

            int GriDeger = 0;
            for (int x = 0; x < ResimGenisligi; x++)
            {
                for (int y = 0; y < ResimYuksekligi; y++)
                {
                    OkunanRenk = GirisResmi.GetPixel(x, y);
                    double R = OkunanRenk.R;
                    double G = OkunanRenk.G;
                    double B = OkunanRenk.B;
                    //GriDeger = Convert.ToInt16((R + G + B) / 3); 

                    GriDeger = Convert.ToInt16(R * 0.3 + G * 0.6 + B * 0.1);
                    if (GriDeger > 150)
                        GriDeger = 255;
                    else
                        GriDeger = 0;
                    DonusenRenk = Color.FromArgb(GriDeger, GriDeger, GriDeger);
                    CikisResmi.SetPixel(x, y, DonusenRenk);
                }
            }
            pictureBox2.Image = CikisResmi;
        }
        //HİSTOGRAM
        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = null;
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Picturebox'da Resim yok!");
                return;
            }

            ArrayList DiziPiksel = new ArrayList();
            int OrtalamaRenk = 0;
            Color OkunanRenk;
            int R = 0, G = 0, B = 0;
            Bitmap GirisResmi; //Histogram için giriş resmi gri-ton olmalıdır.
            GirisResmi = new Bitmap(pictureBox1.Image);
            int ResimGenisligi = GirisResmi.Width; //GirisResmi global tanımlandı.
            int ResimYuksekligi = GirisResmi.Height;
            int i = 0; //piksel sayısı tutulacak.
            for (int x = 0; x < GirisResmi.Width; x++)
            {
                for (int y = 0; y < GirisResmi.Height; y++)
                {
                    OkunanRenk = GirisResmi.GetPixel(x, y);
                    OrtalamaRenk = (int)(OkunanRenk.R + OkunanRenk.G + OkunanRenk.B) / 3; //Griton resimde üç kanal rengi aynı değere sahiptir.
                    DiziPiksel.Add(OrtalamaRenk); //Resimdeki tüm noktaları diziye atıyor. 
                }
            }
            int[] DiziPikselSayilari = new int[256];
            for (int r = 0; r <= 255; r++) //256 tane renk tonu için dönecek.
            {
                int PikselSayisi = 0;
                for (int s = 0; s < DiziPiksel.Count; s++) //resimdeki piksel sayısınca dönecek. 
                {
                    if (r == Convert.ToInt16(DiziPiksel[s]))
                        PikselSayisi++;
                }
                DiziPikselSayilari[r] = PikselSayisi;
            }
            //Değerleri listbox'a ekliyor. 
            int RenkMaksPikselSayisi = 0; //Grafikte y eksenini ölçeklerken kullanılacak. 
            for (int k = 0; k <= 255; k++)
            {
                listBox1.Items.Add("Renk:" + k + "=" + DiziPikselSayilari[k]);
                //Maksimum piksel sayısını bulmaya çalışıyor.
                if (DiziPikselSayilari[k] > RenkMaksPikselSayisi)
                {
                    RenkMaksPikselSayisi = DiziPikselSayilari[k];
                }
            }
            //Grafiği çiziyor. 
            Graphics CizimAlani;
            Pen Kalem1 = new Pen(System.Drawing.Color.Yellow, 1);
            Pen Kalem2 = new Pen(System.Drawing.Color.Red, 1);
            CizimAlani = pictureBox2.CreateGraphics();
            pictureBox2.Refresh();
            int GrafikYuksekligi = 300;
            double OlcekY = RenkMaksPikselSayisi / GrafikYuksekligi;
            double OlcekX = 1.5;
            int X_kaydirma = 10;
            for (int x = 0; x <= 255; x++)
            {
                if (x % 50 == 0)
                    CizimAlani.DrawLine(Kalem2, (int)(X_kaydirma + x * OlcekX),
                   GrafikYuksekligi, (int)(X_kaydirma + x * OlcekX), 0);
                CizimAlani.DrawLine(Kalem1, (int)(X_kaydirma + x * OlcekX), GrafikYuksekligi,
               (int)(X_kaydirma + x * OlcekX), (GrafikYuksekligi - (int)(DiziPikselSayilari[x] / OlcekY)));
                //Dikey kırmızı çizgiler.

            }
            textBox1.Text = "Maks.Piks=" + RenkMaksPikselSayisi.ToString();
        }
        //GÖRÜNTÜYÜ KÜÇÜLTME
        private void button7_Click(object sender, EventArgs e)
        {
            {
                if (pictureBox1.Image == null)
                {
                    MessageBox.Show("Picturebox'da Resim yok!");
                    return;
                }
                Color OkunanRenk, DonusenRenk;
                Bitmap GirisResmi, CikisResmi;
                GirisResmi = new Bitmap(pictureBox1.Image);
                int ResimGenisligi = GirisResmi.Width;
                int ResimYuksekligi = GirisResmi.Height;
                CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
                int x2 = 0, y2 = 0; //Çıkış resminin x ve y si olacak.
                int KucultmeKatsayisi = 2;
                for (int x1 = 0; x1 < ResimGenisligi; x1 = x1 + KucultmeKatsayisi)
                {
                    y2 = 0;
                    for (int y1 = 0; y1 < ResimYuksekligi; y1 = y1 + KucultmeKatsayisi)
                    {
                        OkunanRenk = GirisResmi.GetPixel(x1, y1);
                        DonusenRenk = OkunanRenk;
                        CikisResmi.SetPixel(x2, y2, DonusenRenk);
                        y2++;
                    }
                    x2++;
                }
                pictureBox2.Image = CikisResmi;
            }
        }
        //EĞME
        private void button8_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Picturebox'da Resim yok!");
                return;
            }
            Color OkunanRenk;
            Bitmap GirisResmi, CikisResmi;
            GirisResmi = new Bitmap(pictureBox1.Image);
            int ResimGenisligi = GirisResmi.Width;
            int ResimYuksekligi = GirisResmi.Height;
            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
            //Taşıma mesafelerini atıyor. 
            double EgmeKatsayisi = 0.2;
            double x2 = 0, y2 = 0;
            for (int x1 = 0; x1 < (ResimGenisligi); x1++)
            {
                for (int y1 = 0; y1 < (ResimYuksekligi); y1++)
                {
                    OkunanRenk = GirisResmi.GetPixel(x1, y1);
                    // +X ekseni yönünde
                    //x2 = x1 + EgmeKatsayisi * y1;
                    //y2 = y1;
                    // -X ekseni yönünde
                    //x2 = x1 - EgmeKatsayisi * y1;
                    //y2 = y1;
                    // +Y ekseni yönünde
                    //x2 = x1;
                    //y2 = EgmeKatsayisi * x1 + y1;
                    // -Y ekseni yönünde
                    x2 = x1;
                    y2 = -EgmeKatsayisi * x1 + y1;

                    if (x2 > 0 && x2 < ResimGenisligi && y2 > 0 && y2 < ResimYuksekligi)
                        CikisResmi.SetPixel((int)x2, (int)y2, OkunanRenk);
                }
            }
            pictureBox2.Image = CikisResmi;

        }
        //GÖRÜNTÜ TAŞIMA
        private void button9_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Picturebox'da Resim yok!");
                return;
            }
            Color OkunanRenk;
            Bitmap GirisResmi, CikisResmi;
            GirisResmi = new Bitmap(pictureBox1.Image);
            int ResimGenisligi = GirisResmi.Width;
            int ResimYuksekligi = GirisResmi.Height;
            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
            double x2 = 0, y2 = 0;
            //Taşıma mesafelerini atıyor. 
            int Tx = 100;
            int Ty = 50;
            for (int x1 = 0; x1 < (ResimGenisligi); x1++)
            {
                for (int y1 = 0; y1 < (ResimYuksekligi); y1++)
                {
                    OkunanRenk = GirisResmi.GetPixel(x1, y1);
                    x2 = x1 + Tx;
                    y2 = y1 + Ty;
                    if (x2 > 0 && x2 < ResimGenisligi && y2 > 0 && y2 < ResimYuksekligi)
                        CikisResmi.SetPixel((int)x2, (int)y2, OkunanRenk);
                }
            }
            pictureBox2.Image = CikisResmi;
        }
        //PARLAKLIĞI DEĞİŞTİRME
        private void button10_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Picturebox'da Resim yok!");
                return;
            }
            int R = 0, G = 0, B = 0;
            Color OkunanRenk, DonusenRenk;
            Bitmap GirisResmi, CikisResmi;
            GirisResmi = new Bitmap(pictureBox1.Image);
            int ResimGenisligi = GirisResmi.Width; //GirisResmi global tanımlandı.
            int ResimYuksekligi = GirisResmi.Height;
            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
            int i = 0, j = 0; //Çıkış resminin x ve y si olacak.
            for (int x = 0; x < ResimGenisligi; x++)
            {
                j = 0;
                for (int y = 0; y < ResimYuksekligi; y++)
                {
                    OkunanRenk = GirisResmi.GetPixel(x, y);
                    //Rengini 50 değeri ile açacak.
                    R = OkunanRenk.R + 50;
                    G = OkunanRenk.G + 50;
                    B = OkunanRenk.B + 50;
                    //Renkler 255 geçtiyse son sınır olan 255 alınacak.
                    if (R > 255) R = 255;
                    if (G > 255) G = 255;
                    if (B > 255) B = 255;
                    DonusenRenk = Color.FromArgb(R, G, B);
                    CikisResmi.SetPixel(i, j, DonusenRenk);
                    j++;
                }
                i++;
            }
            pictureBox2.Image = CikisResmi;
        }
        //DÖNDÜRME
        private void button11_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Picturebox'da Resim yok!");
                return;
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("Textbox a değer girmelisin!");
                return;
            }



            Color OkunanRenk;
            Bitmap GirisResmi, CikisResmi;
            GirisResmi = new Bitmap(pictureBox1.Image);
            int ResimGenisligi = GirisResmi.Width;
            int ResimYuksekligi = GirisResmi.Height;
            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
            int Aci = Convert.ToInt16(textBox3.Text);
            double RadyanAci = Aci * 2 * Math.PI / 360;
            double x2 = 0, y2 = 0;
            //Resim merkezini buluyor. Resim merkezi etrafında döndürecek. 
            int x0 = ResimGenisligi / 2;
            int y0 = ResimYuksekligi / 2;
            for (int x1 = 0; x1 < (ResimGenisligi); x1++)
            {
                for (int y1 = 0; y1 < (ResimYuksekligi); y1++)
                {
                    OkunanRenk = GirisResmi.GetPixel(x1, y1);
                    //Döndürme Formülleri
                    x2 = Math.Cos(RadyanAci) * (x1 - x0) - Math.Sin(RadyanAci) * (y1 - y0) + x0;
                    y2 = Math.Sin(RadyanAci) * (x1 - x0) + Math.Cos(RadyanAci) * (y1 - y0) + y0;
                    if (x2 > 0 && x2 < ResimGenisligi && y2 > 0 && y2 < ResimYuksekligi)
                        CikisResmi.SetPixel((int)x2, (int)y2, OkunanRenk);
                }
            }
            pictureBox2.Image = CikisResmi;
        }
        //AYNALAMA
        private void button12_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Picturebox'da Resim yok!");
                return;
            }


            if (textBox4.Text == "")
            {
                MessageBox.Show("Textbox a değer girmelisin!");
                return;
            }


            Color OkunanRenk;
            Bitmap GirisResmi, CikisResmi;
            GirisResmi = new Bitmap(pictureBox1.Image);
            int ResimGenisligi = GirisResmi.Width;
            int ResimYuksekligi = GirisResmi.Height;
            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
            double Aci = Convert.ToDouble(textBox4.Text);
            double RadyanAci = Aci * 2 * Math.PI / 360;
            double x2 = 0, y2 = 0;
            //Resim merkezini buluyor. Resim merkezi etrafında döndürecek. 
            int x0 = ResimGenisligi / 2;
            int y0 = ResimYuksekligi / 2;
            for (int x1 = 0; x1 < (ResimGenisligi); x1++)
            {
                for (int y1 = 0; y1 < (ResimYuksekligi); y1++)
                {
                    OkunanRenk = GirisResmi.GetPixel(x1, y1);
                    //----A-Orta dikey eksen etrafında aynalama ----------------
                    //x2 = Convert.ToInt16(-x1 + 2 * x0); 
                    //y2 = Convert.ToInt16(y1);

                    //----B-Orta yatay eksen etrafında aynalama ----------------
                    //x2 = Convert.ToInt16(x1);
                    //y2 = Convert.ToInt16(-y1 + 2 *y0);

                    //----C-Ortadan geçen 45 açılı çizgi etrafında aynalama----------
                    double Delta = (x1 - x0) * Math.Sin(RadyanAci) - (y1 - y0) * Math.Cos(RadyanAci);
                    x2 = Convert.ToInt16(x1 + 2 * Delta * (-Math.Sin(RadyanAci)));
                    y2 = Convert.ToInt16(y1 + 2 * Delta * (Math.Cos(RadyanAci)));
                    if (x2 > 0 && x2 < ResimGenisligi && y2 > 0 && y2 < ResimYuksekligi)
                        CikisResmi.SetPixel((int)x2, (int)y2, OkunanRenk);
                }
            }
            pictureBox2.Image = CikisResmi;
        }
        //KONTRAST
        private void button13_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Picturebox'da Resim yok!");
                return;

            }
            if (textBox5.Text == "")
            {
                MessageBox.Show("Textbox a değer girmelisin!");
                return;
            }



        }
        //KARŞITLIK
        private void button14_Click(object sender, EventArgs e)
        {

            {
                if (pictureBox1.Image == null)
                {

                    MessageBox.Show("Picturebox'da Resim yok!");
                    return;
                }
                if (textBox2.Text == "")
                {
                    MessageBox.Show("Textbox a değer girmelisin!");
                    return;
                }
                int R = 0, G = 0, B = 0;
                Color OkunanRenk, DonusenRenk;
                Bitmap GirisResmi, CikisResmi;
                GirisResmi = new Bitmap(pictureBox1.Image);
                int ResimGenisligi = GirisResmi.Width; //GirisResmi global tanımlandı.
                int ResimYuksekligi = GirisResmi.Height;
                CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
                //Cikis resmini oluşturuyor. Boyutları giriş resmi ile aynı olur.

                double C_KontrastSeviyesi = Convert.ToInt32(textBox2.Text);
                double F_KontrastFaktoru = (259 * (C_KontrastSeviyesi + 255)) / (255 * (259 -
                C_KontrastSeviyesi));
                for (int x = 0; x < ResimGenisligi; x++)
                {
                    for (int y = 0; y < ResimYuksekligi; y++)
                    {
                        OkunanRenk = GirisResmi.GetPixel(x, y);
                        R = OkunanRenk.R;
                        G = OkunanRenk.G;
                        B = OkunanRenk.B;
                        R = (int)((F_KontrastFaktoru * (R - 128)) + 128);
                        G = (int)((F_KontrastFaktoru * (G - 128)) + 128);
                        B = (int)((F_KontrastFaktoru * (B - 128)) + 128);
                        //Renkler sınırların dışına çıktıysa, sınır değer alınacak.
                        if (R > 255) R = 255;
                        if (G > 255) G = 255;
                        if (B > 255) B = 255;
                        if (R < 0) R = 0;
                        if (G < 0) G = 0;
                        if (B < 0) B = 0;
                        DonusenRenk = Color.FromArgb(R, G, B);
                        CikisResmi.SetPixel(x, y, DonusenRenk);
                    }
                }
                pictureBox2.Image = CikisResmi;

            }
        }
        //KAYDET
        private void button15_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image == null)
            {

                MessageBox.Show("Picturebox'da Resim yok!");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();//yeni bir kaydetme diyaloğu oluşturuyoruz.

            sfd.Filter = "jpeg dosyası(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp";//.bmp veya .jpg olarak kayıt imkanı sağlıyoruz.

            sfd.Title = "Kayıt";//diğaloğumuzun başlığını belirliyoruz.

            sfd.FileName = "resim";//kaydedilen resmimizin adını 'resim' olarak belirliyoruz.

            DialogResult sonuç = sfd.ShowDialog();

            if (sonuç == DialogResult.OK)
            {
                pictureBox2.Image.Save(sfd.FileName);//Böylelikle resmi istediğimiz yere kaydediyoruz.
            }
        }
        //KONSTRAT
        private void button16_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            
                     {

                    MessageBox.Show("Picturebox'da Resim yok!");
                    return;
                }
            if (textBox6.Text == "")
            {
                MessageBox.Show("Textbox a değer girmelisin!");
                return;
            }
            if (textBox7.Text == "")
            {
                MessageBox.Show("Textbox a değer girmelisin!");
                return;
            }
            if (textBox8.Text == "")
            {
                MessageBox.Show("Textbox a değer girmelisin!");
                return;
            }
            if (textBox9.Text == "")
            {
                MessageBox.Show("Textbox a değer girmelisin!");
                return;
            }



            Color OkunanRenk, DonusenRenk;
            int R = 0, G = 0, B = 0;
            Bitmap GirisResmi, CikisResmi;
            GirisResmi = new Bitmap(pictureBox1.Image);
            int ResimGenisligi = GirisResmi.Width; //GirisResmi global tanımlandı. İçerisine görüntü 
            //yüklendi.
            int ResimYuksekligi = GirisResmi.Height;
            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi); //Cikis resmini oluşturuyor. 
            //Boyutları giriş resmi ile aynı olur. Tanımlaması globalde yapıldı.
            int X1 = Convert.ToInt16(textBox6.Text);
            int X2 = Convert.ToInt16(textBox7.Text);
            int Y1 = Convert.ToInt16(textBox8.Text);
            int Y2 = Convert.ToInt16(textBox9.Text);
            int i = 0, j = 0; //Çıkış resminin x ve y si olacak.
            for (int x = 0; x < ResimGenisligi; x++)
            {
                for (int y = 0; y < ResimYuksekligi; y++)
                {
                    OkunanRenk = GirisResmi.GetPixel(x, y);
                    R = OkunanRenk.R;
                    G = OkunanRenk.G;
                    B = OkunanRenk.B;
                    int Gri = (R + G + B) / 3;
                    //*********** Kontras Formülü***************
                    int X = Gri;
                    int Y = ((((X - X1) * Y2 - Y1)) / (X2 - X1)) + Y1;
                    if (Y > 255) Y = 255;
                    if (Y < 0) Y = 0;
                    DonusenRenk = Color.FromArgb(Y, Y, Y);
                    CikisResmi.SetPixel(x, y, DonusenRenk);
                }
            }
            pictureBox2.Refresh();
            pictureBox2.Image = null;
            pictureBox2.Image = CikisResmi;





        }
        //KONTRASTI ALINMIŞ RESMİN HİSTOGRAMI
        private void button13_Click_1(object sender, EventArgs e)
        {

            pictureBox3.Image = null;
            if (pictureBox2.Image == null)
            {
                MessageBox.Show("Picturebox'da Resim yok!");
                return;
            }

            ArrayList DiziPiksel = new ArrayList();
            int OrtalamaRenk = 0;
            Color OkunanRenk;
            int R = 0, G = 0, B = 0;
            Bitmap GirisResmi; //Histogram için giriş resmi gri-ton olmalıdır.
            GirisResmi = new Bitmap(pictureBox2.Image);
            int ResimGenisligi = GirisResmi.Width; //GirisResmi global tanımlandı.
            int ResimYuksekligi = GirisResmi.Height;
            int i = 0; //piksel sayısı tutulacak.
            for (int x = 0; x < GirisResmi.Width; x++)
            {
                for (int y = 0; y < GirisResmi.Height; y++)
                {
                    OkunanRenk = GirisResmi.GetPixel(x, y);
                    OrtalamaRenk = (int)(OkunanRenk.R + OkunanRenk.G + OkunanRenk.B) / 3; //Griton resimde üç kanal rengi aynı değere sahiptir.
                    DiziPiksel.Add(OrtalamaRenk); //Resimdeki tüm noktaları diziye atıyor. 
                }
            }
            int[] DiziPikselSayilari = new int[256];
            for (int r = 0; r <= 255; r++) //256 tane renk tonu için dönecek.
            {
                int PikselSayisi = 0;
                for (int s = 0; s < DiziPiksel.Count; s++) //resimdeki piksel sayısınca dönecek. 
                {
                    if (r == Convert.ToInt16(DiziPiksel[s]))
                        PikselSayisi++;
                }
                DiziPikselSayilari[r] = PikselSayisi;
            }
            //Değerleri listbox'a ekliyor. 
            int RenkMaksPikselSayisi = 0; //Grafikte y eksenini ölçeklerken kullanılacak. 
            for (int k = 0; k <= 255; k++)
            {
                listBox2.Items.Add("Renk:" + k + "=" + DiziPikselSayilari[k]);
                //Maksimum piksel sayısını bulmaya çalışıyor.
                if (DiziPikselSayilari[k] > RenkMaksPikselSayisi)
                {
                    RenkMaksPikselSayisi = DiziPikselSayilari[k];
                }
            }
            //Grafiği çiziyor. 
            Graphics CizimAlani;
            Pen Kalem1 = new Pen(System.Drawing.Color.Yellow, 1);
            Pen Kalem2 = new Pen(System.Drawing.Color.Red, 1);
            CizimAlani = pictureBox3.CreateGraphics();
            pictureBox3.Refresh();
            int GrafikYuksekligi = 300;
            double OlcekY = RenkMaksPikselSayisi / GrafikYuksekligi;
            double OlcekX = 1.5;
            int X_kaydirma = 10;
            for (int x = 0; x <= 255; x++)
            {
                if (x % 50 == 0)
                    CizimAlani.DrawLine(Kalem2, (int)(X_kaydirma + x * OlcekX),
                   GrafikYuksekligi, (int)(X_kaydirma + x * OlcekX), 0);
                CizimAlani.DrawLine(Kalem1, (int)(X_kaydirma + x * OlcekX), GrafikYuksekligi,
               (int)(X_kaydirma + x * OlcekX), (GrafikYuksekligi - (int)(DiziPikselSayilari[x] / OlcekY)));
                //Dikey kırmızı çizgiler.

            }
            textBox10.Text = "Maks.Piks=" + RenkMaksPikselSayisi.ToString();
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}









