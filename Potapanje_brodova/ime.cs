using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace Potapanje_brodova
{
   


    public partial class ime : Form
    {   
        
        public static string imeIgraca;
        public string[,] polja_igrac = new string[10, 10];
        public string izabrani_brod_pictureBox;
        public int izabrani_brod = 0;
        public Image kliknuti_brod;
        public string trenutni_brod_postavljanje_orijentacija = "h";
        Icon ikonica = new Icon("..\\..\\slike\\ikonica.ico", 32, 32);

        Image brod_5_v = Image.FromFile("..\\..\\slike\\brod_5_v.png");             //// slike vertikalnih brodova
        Image brod_4_v = Image.FromFile("..\\..\\slike\\brod_4_v.png");
        Image brod_3_v = Image.FromFile("..\\..\\slike\\brod_3_v.png");
        Image brod_2_v = Image.FromFile("..\\..\\slike\\brod_2_v.png");

        Image brod_5 = Image.FromFile("..\\..\\slike\\brod_5.png");             //// slike horizontalnih brodova
        Image brod_4 = Image.FromFile("..\\..\\slike\\brod_4.png");
        Image brod_3 = Image.FromFile("..\\..\\slike\\brod_3.png");
        Image brod_2 = Image.FromFile("..\\..\\slike\\brod_2.png");


        public ime(string[,] raspored_igraca)
        {
            InitializeComponent();
         
            polja_igrac = raspored_igraca;
        
            pictureBox1.Image = brod_5;
            pictureBox2.Image = brod_4;
            pictureBox3.Image = brod_3;
            pictureBox4.Image = brod_3;
            pictureBox5.Image = brod_2;
            this.Text = "Potapanje Brodova | Rasporedjivanje";
            this.Icon = ikonica;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int brojac = 0;

               foreach (Control item in panel2.Controls)
            {
                if (item is PictureBox )
                {
                    PictureBox pb = (PictureBox)item;
                    if(pb.Enabled == true)
                        brojac++;
                }
            }



               
                    
             
             if (textBox1.Text != "" && brojac==0)
            {
               
              
               imeIgraca = textBox1.Text;

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
                MessageBox.Show("Unesite ime igraca i rasporedite sve brodove!", "Greska!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        


        }  //klik igraj

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }  //klik exit



        private void panel1_Paint(object sender, PaintEventArgs e)  //crtanje polja
        {

            Graphics g = e.Graphics;
            Pen olovka = new Pen(new SolidBrush(Color.CadetBlue));

            GraphicsPath gp = new GraphicsPath();
            float sirina_kvadrata = (float)panel1.Width / 10;
            float visina_kvadrata = (float)panel1.Height / 10;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    RectangleF kvadrat = new RectangleF(sirina_kvadrata * j, visina_kvadrata * i, sirina_kvadrata, visina_kvadrata);
                    gp.AddRectangle(kvadrat);
                    g.DrawPath(olovka, gp);

                    if (polja_igrac[j, i] != null)
                    {
                        if (polja_igrac[j,i][1] == 'h' )
                        {
                            if (polja_igrac[j, i] == "bh5**")
                                kliknuti_brod = brod_5;
                            else if (polja_igrac[j, i] == "bh4**")
                                kliknuti_brod = brod_4;
                            else if (polja_igrac[j, i] == "bh3**")
                                kliknuti_brod = brod_3;
                            else if (polja_igrac[j, i] == "bh2**")
                                kliknuti_brod = brod_2;
                            RectangleF kv = new RectangleF(sirina_kvadrata * j, visina_kvadrata * i, sirina_kvadrata, visina_kvadrata);
                            g.DrawImage(kliknuti_brod, kv, new RectangleF(0, 0, 40, 40), GraphicsUnit.Pixel);

                            kv = new RectangleF(sirina_kvadrata * (j + 1), visina_kvadrata * i, sirina_kvadrata, visina_kvadrata);
                            g.DrawImage(kliknuti_brod, kv, new RectangleF(40, 0, 40, 40), GraphicsUnit.Pixel);

                            kv = new RectangleF(sirina_kvadrata * (j + 2), visina_kvadrata * i, sirina_kvadrata, visina_kvadrata);
                            g.DrawImage(kliknuti_brod, kv, new RectangleF(80, 0, 40, 40), GraphicsUnit.Pixel);

                            kv = new RectangleF(sirina_kvadrata * (j + 3), visina_kvadrata * i, sirina_kvadrata, visina_kvadrata);
                            g.DrawImage(kliknuti_brod, kv, new RectangleF(120, 0, 40, 40), GraphicsUnit.Pixel);

                            kv = new RectangleF(sirina_kvadrata * (j + 4), visina_kvadrata * i, sirina_kvadrata, visina_kvadrata);
                            g.DrawImage(kliknuti_brod, kv, new RectangleF(160, 0, 40, 40), GraphicsUnit.Pixel);

                        }
                        if (polja_igrac[j, i][1] == 'v')
                        {
                            if (polja_igrac[j, i] == "bv5**")
                                kliknuti_brod = brod_5_v;
                            else if (polja_igrac[j, i] == "bv4**")
                                kliknuti_brod = brod_4_v;
                            else if (polja_igrac[j, i] == "bv3**")
                                kliknuti_brod = brod_3_v;
                            else if (polja_igrac[j, i] == "bv2**")
                                kliknuti_brod = brod_2_v;
                            RectangleF kv = new RectangleF(sirina_kvadrata * j, visina_kvadrata * i, sirina_kvadrata, visina_kvadrata);
                            g.DrawImage(kliknuti_brod, kv, new RectangleF(0, 0, 40, 40), GraphicsUnit.Pixel);

                            kv = new RectangleF(sirina_kvadrata *j, visina_kvadrata * (i+1), sirina_kvadrata, visina_kvadrata);
                            g.DrawImage(kliknuti_brod, kv, new RectangleF(0, 40, 40, 40), GraphicsUnit.Pixel);

                            kv = new RectangleF(sirina_kvadrata * j, visina_kvadrata * (i + 2), sirina_kvadrata, visina_kvadrata);
                            g.DrawImage(kliknuti_brod, kv, new RectangleF(0, 80, 40, 40), GraphicsUnit.Pixel);

                            kv = new RectangleF(sirina_kvadrata * j, visina_kvadrata * (i + 3), sirina_kvadrata, visina_kvadrata);
                            g.DrawImage(kliknuti_brod, kv, new RectangleF(0, 120, 40, 40), GraphicsUnit.Pixel);

                            kv = new RectangleF(sirina_kvadrata * j, visina_kvadrata * (i + 4), sirina_kvadrata, visina_kvadrata);
                            g.DrawImage(kliknuti_brod, kv, new RectangleF(0, 160, 40, 40), GraphicsUnit.Pixel);

                        }
                    }

                }


                }
        }
        



        private void panel1_Resize(object sender, EventArgs e)//resize panela polja
        {
            panel1.Invalidate();
        }     



        private void klik_na_brod(object sender, EventArgs e)
        {
            PictureBox slika_broda = (PictureBox)sender;
            
            izabrani_brod = Convert.ToInt16(slika_broda.Tag); //uzimanje vrijednosti broda na koji igrac klikne da postavi (5,4,3,3,2)
            pictureBox1.BorderStyle = BorderStyle.None;
            pictureBox2.BorderStyle = BorderStyle.None;
            pictureBox3.BorderStyle = BorderStyle.None;
            pictureBox4.BorderStyle = BorderStyle.None;
            pictureBox5.BorderStyle = BorderStyle.None;
            kliknuti_brod = slika_broda.Image;

            kliknuti_brod.Tag = slika_broda.Tag;
            izabrani_brod_pictureBox = slika_broda.AccessibleName;
            slika_broda.BorderStyle = BorderStyle.Fixed3D;
            button3.Enabled = true;
            panel3.Invalidate();
            
        }





        private void panel1_MouseClick(object sender, MouseEventArgs e)     //klik na polje za postavljanje broda
        {
            if (izabrani_brod == 0)
            {
                MessageBox.Show("Izaberite brod koji zelite da postavite!");
            }
            else
            {
                try
                {
                    int izabrano_polje_X = e.Location.X;
                    int izabrano_polje_Y = e.Location.Y;


                    float sirina_kvadrata = (float)panel1.Width / 10;
                    float visina_kvadrata = (float)panel1.Height / 10;
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (izabrano_polje_X >= sirina_kvadrata * i && izabrano_polje_X < sirina_kvadrata * (i + 1))
                                if (izabrano_polje_Y >= visina_kvadrata * j && izabrano_polje_Y < visina_kvadrata * (j + 1))
                                {
                                    if (polja_igrac[i, j] != null) // postavljanje je dozvoljeno samo na prazno polje
                                    {
                                        if (DialogResult.OK == MessageBox.Show("Na tom mjestu vec postoji brod, izaberite neko drugo mjesto!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error))
                                        {
                                            return;
                                        }
                                    }
                                    else
                                    {
                                        polja_igrac[i, j] = "b" + trenutni_brod_postavljanje_orijentacija + kliknuti_brod.Tag.ToString() + "**";


                                        if (trenutni_brod_postavljanje_orijentacija == "h")
                                        {
                                            for (int k = 1; k < Convert.ToInt16(kliknuti_brod.Tag); k++)
                                                polja_igrac[i + k, j] = "bbb" + trenutni_brod_postavljanje_orijentacija + kliknuti_brod.Tag.ToString();

                                        }
                                        else if (trenutni_brod_postavljanje_orijentacija == "v")
                                        {
                                            for (int k = 1; k < Convert.ToInt16(kliknuti_brod.Tag); k++)
                                                polja_igrac[i, j + k] = "bbb" + trenutni_brod_postavljanje_orijentacija + kliknuti_brod.Tag.ToString();
                                        }
                                        panel1.Invalidate();
                                    }
                                }

                        }
                    }
                    foreach (Control item in panel2.Controls)
                    {
                        if (item is PictureBox)
                        {

                            PictureBox c = (PictureBox)item;
                            if (c.AccessibleName == izabrani_brod_pictureBox)
                            {
                                c.Hide();
                                c.Enabled = false;
                            }
                            izabrani_brod = 0;

                        }

                    }
                    button3.Enabled = false;

                }
                catch (Exception)
                {

                    if (DialogResult.OK == MessageBox.Show("Brod koji zelite postaviti se nalazi van okvira, rasporedite brodove ponovo!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error))
                    {
                        ponovo_rasporedi();
                        button3.Enabled = false;
                    }
                    
                }
         
                
            }

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {


            Graphics g = e.Graphics;
            Pen olovka = new Pen(new SolidBrush(Color.Black));

            GraphicsPath gp = new GraphicsPath();
            float sirina_kvadrata = (float)panel3.Width / 5;
            float visina_kvadrata = (float)panel3.Height / 5;
            int brojac = 0;

            if (trenutni_brod_postavljanje_orijentacija == "h")
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        RectangleF kvadrat = new RectangleF(sirina_kvadrata * j, visina_kvadrata * i, sirina_kvadrata, visina_kvadrata);
                        gp.AddRectangle(kvadrat);
                        g.DrawPath(olovka, gp);


                        if (brojac < izabrani_brod && izabrani_brod != 0)
                        {
                            g.FillPath(new SolidBrush(Color.DarkSlateGray), gp);
                            brojac++;
                        }

                    }
                }
            }
            if (trenutni_brod_postavljanje_orijentacija == "v")
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        RectangleF kvadrat = new RectangleF(sirina_kvadrata * i, visina_kvadrata * j, sirina_kvadrata, visina_kvadrata);
                        gp.AddRectangle(kvadrat);
                        g.DrawPath(olovka, gp);


                        if (brojac < izabrani_brod && izabrani_brod != 0)
                        {
                            g.FillPath(new SolidBrush(Color.DarkSlateGray), gp);
                            brojac++;
                        }

                    }
                }
            }
        }  //orjentacija

        private void button3_Click(object sender, EventArgs e)
        {

            if (trenutni_brod_postavljanje_orijentacija == "h")
            {
                trenutni_brod_postavljanje_orijentacija = "v";
                switch(Convert.ToInt16(kliknuti_brod.Tag))
                {
                    case 5:
                        kliknuti_brod = brod_5_v;
                        kliknuti_brod.Tag = "5";
                        break;
                    case 4:
                        kliknuti_brod = brod_4_v;
                        kliknuti_brod.Tag = "4";
                        break;
                    case 3:
                        kliknuti_brod = brod_3_v;
                        kliknuti_brod.Tag = "3";
                        break;
                    case 2:
                        kliknuti_brod = brod_2_v;
                        kliknuti_brod.Tag = "2";
                        break;
                }

            }
            else
            {
                trenutni_brod_postavljanje_orijentacija = "h";
                switch (Convert.ToInt16(kliknuti_brod.Tag))
                {
                    case 5:
                        
                        kliknuti_brod = brod_5;
                        kliknuti_brod.Tag = "5";
                        break;
                    case 4:
                        kliknuti_brod = brod_4;
                        kliknuti_brod.Tag = "4";
                        break;
                    case 3:
                        kliknuti_brod = brod_3;
                        kliknuti_brod.Tag = "3";
                        break;
                    case 2:
                        kliknuti_brod = brod_2;
                        kliknuti_brod.Tag = "2";
                        break;
                }
               
            }
            panel3.Invalidate();

            
        } //klik rotiranje
        void ponovo_rasporedi()
        {

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    polja_igrac[i, j] = null;
                }
            }

            foreach (Control item in panel2.Controls)
            {
                if (item is PictureBox)
                {

                    PictureBox c = (PictureBox)item;
                    c.Enabled = true;
                    c.Show();


                }

            }
            pictureBox1.Image = brod_5;
            pictureBox2.Image = brod_4;
            pictureBox3.Image = brod_3;
            pictureBox4.Image = brod_3;
            pictureBox5.Image = brod_2;

            panel1.Invalidate();
        }
        private void button4_Click(object sender, EventArgs e)
        {

            ponovo_rasporedi();
            button3.Enabled = false;

        }  ///klik ponovo rasporedi
    }
}

       
        
  
    

