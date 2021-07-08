using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Drawing.Imaging;


namespace Potapanje_brodova
{
    public partial class Form1 : Form
    {

        public string[,] polja_igrac = new string[10, 10];
        public string[,] polja_bot = new string[10, 10];

        public int ponovi_3 = 0;
        bool prikazi_protivnika = false;
        string trenutni_potez = "igrac";

        Image slika_pogodak = Image.FromFile("..\\..\\slike\\pogodak.png");
        Image slika_promasaj = Image.FromFile("..\\..\\slike\\promasaj.png");      
        Image trenutni_brod_za_crtanje;

        Icon ikonica = new Icon("..\\..\\slike\\ikonica.ico", 32, 32);
       
        public string trenutni_brod_postavljanje_orjentacija;
   

        public Form1()
        {
            InitializeComponent();
          
            ime ime_i_raspored = new ime(polja_igrac);
            ime_i_raspored.ShowDialog();

            this.Icon = ikonica;
          
            if (ime_i_raspored.DialogResult != DialogResult.OK)
            {
             
                Environment.Exit(0);
                
            }
            this.Show();
            MessageBox.Show("U desnom gornjem uglu postoji dugme 'Prikazi protivnicke brodove' koje sam koristio radi lakseg testiranja.");

            this.Text = "Potapanje Brodova | Igra";
            rasporedi_bot();
        

        }

  
     

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen olovka = new Pen(new SolidBrush(Color.CadetBlue));

            GraphicsPath gp = new GraphicsPath();

            float sirina_kvadrata = (float)panel2.Width / 10;
            float visina_kvadrata = (float)panel2.Height / 10;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    RectangleF kvadrat = new RectangleF(sirina_kvadrata * j, visina_kvadrata * i, sirina_kvadrata, visina_kvadrata);
                    gp.AddRectangle(kvadrat);
                    g.DrawPath(olovka, gp);

                    if (polja_bot[j, i] != null )
                    {
                        if (polja_bot[j, i][1] == 'h' && prikazi_protivnika == true)
                        {
                            if (polja_bot[j, i][2] == '5')
                                trenutni_brod_za_crtanje = Image.FromFile("..\\..\\slike\\brod_5.png");
                            if (polja_bot[j, i][2] == '4')
                                trenutni_brod_za_crtanje = Image.FromFile("..\\..\\slike\\brod_4.png");
                            if (polja_bot[j, i][2] == '3')
                                trenutni_brod_za_crtanje = Image.FromFile("..\\..\\slike\\brod_3.png");
                            if (polja_bot[j, i][2] == '2')
                                trenutni_brod_za_crtanje = Image.FromFile("..\\..\\slike\\brod_2.png");


                            RectangleF kv = new RectangleF(sirina_kvadrata * j, visina_kvadrata * i, sirina_kvadrata, visina_kvadrata);
                            g.DrawImage(trenutni_brod_za_crtanje, kv, new RectangleF(0, 0, 40, 40), GraphicsUnit.Pixel);

                            kv = new RectangleF(sirina_kvadrata * (j + 1), visina_kvadrata * i, sirina_kvadrata, visina_kvadrata);
                            g.DrawImage(trenutni_brod_za_crtanje, kv, new RectangleF(40, 0, 40, 40), GraphicsUnit.Pixel);

                            kv = new RectangleF(sirina_kvadrata * (j + 2), visina_kvadrata * i, sirina_kvadrata, visina_kvadrata);
                            g.DrawImage(trenutni_brod_za_crtanje, kv, new RectangleF(80, 0, 40, 40), GraphicsUnit.Pixel);

                            kv = new RectangleF(sirina_kvadrata * (j + 3), visina_kvadrata * i, sirina_kvadrata, visina_kvadrata);
                            g.DrawImage(trenutni_brod_za_crtanje, kv, new RectangleF(120, 0, 40, 40), GraphicsUnit.Pixel);

                            kv = new RectangleF(sirina_kvadrata * (j + 4), visina_kvadrata * i, sirina_kvadrata, visina_kvadrata);
                            g.DrawImage(trenutni_brod_za_crtanje, kv, new RectangleF(160, 0, 40, 40), GraphicsUnit.Pixel);

                        }
                        if (polja_bot[j, i][1] == 'v' && prikazi_protivnika == true)
                        {
                            if (polja_bot[j, i][2] == '5')
                                trenutni_brod_za_crtanje = Image.FromFile("..\\..\\slike\\brod_5_v.png");
                            if (polja_bot[j, i][2] == '4')
                                trenutni_brod_za_crtanje = Image.FromFile("..\\..\\slike\\brod_4_v.png");
                            if (polja_bot[j, i][2] == '3')
                                trenutni_brod_za_crtanje = Image.FromFile("..\\..\\slike\\brod_3_v.png");
                            if (polja_bot[j, i][2] == '2')
                                trenutni_brod_za_crtanje = Image.FromFile("..\\..\\slike\\brod_2_v.png");

                            RectangleF kv = new RectangleF(sirina_kvadrata * j, visina_kvadrata * i, sirina_kvadrata, visina_kvadrata);
                            g.DrawImage(trenutni_brod_za_crtanje, kv, new RectangleF(0, 0, 40, 40), GraphicsUnit.Pixel);

                            kv = new RectangleF(sirina_kvadrata * j, visina_kvadrata * (i + 1), sirina_kvadrata, visina_kvadrata);
                            g.DrawImage(trenutni_brod_za_crtanje, kv, new RectangleF(0, 40, 40, 40), GraphicsUnit.Pixel);

                            kv = new RectangleF(sirina_kvadrata * j, visina_kvadrata * (i + 2), sirina_kvadrata, visina_kvadrata);
                            g.DrawImage(trenutni_brod_za_crtanje, kv, new RectangleF(0, 80, 40, 40), GraphicsUnit.Pixel);

                            kv = new RectangleF(sirina_kvadrata * j, visina_kvadrata * (i + 3), sirina_kvadrata, visina_kvadrata);
                            g.DrawImage(trenutni_brod_za_crtanje, kv, new RectangleF(0, 120, 40, 40), GraphicsUnit.Pixel);

                            kv = new RectangleF(sirina_kvadrata * j, visina_kvadrata * (i + 4), sirina_kvadrata, visina_kvadrata);
                            g.DrawImage(trenutni_brod_za_crtanje, kv, new RectangleF(0, 160, 40, 40), GraphicsUnit.Pixel);

                        }


                        if (polja_bot[j, i].Contains("pogodak"))
                        {
                            RectangleF kv = new RectangleF(sirina_kvadrata * j, visina_kvadrata * i, sirina_kvadrata, visina_kvadrata);
                            g.DrawImage(slika_pogodak, kv, new RectangleF(0, 0, 40, 40), GraphicsUnit.Pixel);
                        }
                        else if (polja_bot[j, i].Contains("promasaj"))
                        {
                            RectangleF kv = new RectangleF(sirina_kvadrata * j, visina_kvadrata * i, sirina_kvadrata, visina_kvadrata);
                            g.DrawImage(slika_promasaj, kv, new RectangleF(0, 0, 40, 40), GraphicsUnit.Pixel);
                        }
                    }


                }


            } 
        } // crtanje rasporeda brodova kompjutera


        private void panel1_Paint(object sender, PaintEventArgs e)
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
                        if (polja_igrac[j, i][1] == 'h')
                        {
                            if (polja_igrac[j, i][2] == '5')
                                trenutni_brod_za_crtanje = Image.FromFile("..\\..\\slike\\brod_5.png");
                            if (polja_igrac[j, i][2] == '4')
                                trenutni_brod_za_crtanje = Image.FromFile("..\\..\\slike\\brod_4.png");
                            if (polja_igrac[j, i][2] == '3')
                                trenutni_brod_za_crtanje = Image.FromFile("..\\..\\slike\\brod_3.png");
                            if (polja_igrac[j, i][2] == '2')
                                trenutni_brod_za_crtanje = Image.FromFile("..\\..\\slike\\brod_2.png");


                            RectangleF kv = new RectangleF(sirina_kvadrata * j, visina_kvadrata * i, sirina_kvadrata, visina_kvadrata);
                            g.DrawImage(trenutni_brod_za_crtanje, kv, new RectangleF(0, 0, 40, 40), GraphicsUnit.Pixel);

                            kv = new RectangleF(sirina_kvadrata * (j + 1), visina_kvadrata * i, sirina_kvadrata, visina_kvadrata);
                            g.DrawImage(trenutni_brod_za_crtanje, kv, new RectangleF(40, 0, 40, 40), GraphicsUnit.Pixel);

                            kv = new RectangleF(sirina_kvadrata * (j + 2), visina_kvadrata * i, sirina_kvadrata, visina_kvadrata);
                            g.DrawImage(trenutni_brod_za_crtanje, kv, new RectangleF(80, 0, 40, 40), GraphicsUnit.Pixel);

                            kv = new RectangleF(sirina_kvadrata * (j + 3), visina_kvadrata * i, sirina_kvadrata, visina_kvadrata);
                            g.DrawImage(trenutni_brod_za_crtanje, kv, new RectangleF(120, 0, 40, 40), GraphicsUnit.Pixel);

                            kv = new RectangleF(sirina_kvadrata * (j + 4), visina_kvadrata * i, sirina_kvadrata, visina_kvadrata);
                            g.DrawImage(trenutni_brod_za_crtanje, kv, new RectangleF(160, 0, 40, 40), GraphicsUnit.Pixel);

                        }
                        if (polja_igrac[j, i][1] == 'v')
                        {
                            if (polja_igrac[j, i][2] == '5')
                                trenutni_brod_za_crtanje = Image.FromFile("..\\..\\slike\\brod_5_v.png");
                            if (polja_igrac[j, i][2] == '4')
                                trenutni_brod_za_crtanje = Image.FromFile("..\\..\\slike\\brod_4_v.png");
                            if (polja_igrac[j, i][2] == '3')
                                trenutni_brod_za_crtanje = Image.FromFile("..\\..\\slike\\brod_3_v.png");
                            if (polja_igrac[j, i][2] == '2')
                                trenutni_brod_za_crtanje = Image.FromFile("..\\..\\slike\\brod_2_v.png");

                            RectangleF kv = new RectangleF(sirina_kvadrata * j, visina_kvadrata * i, sirina_kvadrata, visina_kvadrata);
                            g.DrawImage(trenutni_brod_za_crtanje, kv, new RectangleF(0, 0, 40, 40), GraphicsUnit.Pixel);

                            kv = new RectangleF(sirina_kvadrata * j, visina_kvadrata * (i + 1), sirina_kvadrata, visina_kvadrata);
                            g.DrawImage(trenutni_brod_za_crtanje, kv, new RectangleF(0, 40, 40, 40), GraphicsUnit.Pixel);

                            kv = new RectangleF(sirina_kvadrata * j, visina_kvadrata * (i + 2), sirina_kvadrata, visina_kvadrata);
                            g.DrawImage(trenutni_brod_za_crtanje, kv, new RectangleF(0, 80, 40, 40), GraphicsUnit.Pixel);

                            kv = new RectangleF(sirina_kvadrata * j, visina_kvadrata * (i + 3), sirina_kvadrata, visina_kvadrata);
                            g.DrawImage(trenutni_brod_za_crtanje, kv, new RectangleF(0, 120, 40, 40), GraphicsUnit.Pixel);

                            kv = new RectangleF(sirina_kvadrata * j, visina_kvadrata * (i + 4), sirina_kvadrata, visina_kvadrata);
                            g.DrawImage(trenutni_brod_za_crtanje, kv, new RectangleF(0, 160, 40, 40), GraphicsUnit.Pixel);

                        }

                        if (polja_igrac[j, i].Contains("pogodak"))
                        {
                            RectangleF kv = new RectangleF(sirina_kvadrata * j, visina_kvadrata * i, sirina_kvadrata, visina_kvadrata);
                            g.DrawImage(slika_pogodak, kv, new RectangleF(0, 0, 40, 40), GraphicsUnit.Pixel);
                        }
                        else if (polja_igrac[j, i].Contains("promasaj"))
                        {
                            RectangleF kv = new RectangleF(sirina_kvadrata * j, visina_kvadrata * i, sirina_kvadrata, visina_kvadrata);
                            g.DrawImage(slika_promasaj, kv, new RectangleF(0, 0, 40, 40), GraphicsUnit.Pixel);
                        }
                    }
                }


            }
            
         

            
        }///crtanje rasporeda brodova igraca

        public void rasporedi_bot()
        {
            Random rnd = new Random();
        
            int izabrano_polje_X, izabrano_polje_Y;

        povratak:  //>>>> dio na koji se vracamo ako dodje do greske u postavljanju, tj. ako zbog random funkcije robot postavi dva broda na isto mjesto ili slicno
            ponovi_3 = 0; 
            for (int i = 0; i < 10; i++)//pobrisemo sve postavljene brodove 
            {
                for (int j = 0; j < 10; j++)
                {
                    polja_bot[i, j] = null;
                }
            }

            for (int velicina_broda = 2; velicina_broda <= 5; velicina_broda++)
            {
              
               
                if (velicina_broda == 4 && ponovi_3==0)  // ponavljanje broda velicine 3 kockice (postoje dva ista pa prolazimo dva puta kroz petlju sa velcinom 3)
                {
                    velicina_broda--;
                    ponovi_3++;
                }


                if (rnd.Next(2) % 2 == 0)  // radnom odredimo da li ce brod biti vertikalno ili horizontalno postavljen
                {
                    trenutni_brod_postavljanje_orjentacija = "h";
                }
                else
                    trenutni_brod_postavljanje_orjentacija = "v";
                  

            
                 if (trenutni_brod_postavljanje_orjentacija == "h")            //
                        {
                            izabrano_polje_X = rnd.Next(panel2.Width - velicina_broda*40);   // Ako je brod horizontalno postavljen, smanjujemo opseg u random funkciji po X osi da 
                            izabrano_polje_Y = rnd.Next(panel2.Height);                      // bi izbjegli da brod izlazi van granica panela
                        } 
                        else
                        {
                            izabrano_polje_X = rnd.Next(panel2.Width);
                            izabrano_polje_Y = rnd.Next(panel2.Height - velicina_broda*40);
                        }
                

                     float sirina_kvadrata = (float)panel2.Width / 10;
                     float visina_kvadrata = (float)panel2.Height / 10;


                     for (int i = 0; i < 10; i++)
                     {
                         for (int j = 0; j < 10; j++)
                         {


                             if (izabrano_polje_X >= sirina_kvadrata * i && izabrano_polje_X < sirina_kvadrata * (i + 1))
                                 if (izabrano_polje_Y >= visina_kvadrata * j && izabrano_polje_Y < visina_kvadrata * (j + 1))
                                 {
                                     
                                 
                                         if (polja_bot[i, j] == null)
                                         {
                                             polja_bot[i, j] = "b" + trenutni_brod_postavljanje_orjentacija + velicina_broda.ToString() + "**";  //na izabrano mjesto upisujemo string odredjenog formata po kojem cemo posle da 
                                                                                                                                                 //crtamo protivnicka polja        

                                            if (trenutni_brod_postavljanje_orjentacija == "h")
                                            {
                                                for (int k = 1; k < velicina_broda; k++)
                                                {
                                                    if (polja_bot[i + k, j] == null)
                                                    {
                                                        polja_bot[i + k, j] = "bbb" + trenutni_brod_postavljanje_orjentacija + velicina_broda.ToString();

                                                    }
                                                    else
                                                        goto povratak;  //ponovo postavljamo brodove jer je doslo do preklapanja 
                                                }

                                            }
                                            else if (trenutni_brod_postavljanje_orjentacija == "v")
                                            {
                                                for (int k = 1; k < velicina_broda; k++)
                                                {
                                                    if (polja_bot[i, j + k] == null)
                                                    {
                                                        polja_bot[i, j + k] = "bbb" + trenutni_brod_postavljanje_orjentacija + velicina_broda.ToString();
                                                    }
                                                    else
                                                        goto povratak;
                                                         
                                                }
                                                
                                            }
                                         }
                                        else  
                                        {
                                            goto povratak;
                                        }
                                        
                                    
         
                                 }

                         }
                     }
          
                
         }
            panel2.Invalidate();
        }//random raspored brodova kompjutera

        private void button1_Click(object sender, EventArgs e)  //prikaz protivnickih brodova
        {
            if (prikazi_protivnika == false)
            {
                prikazi_protivnika = true;
                button1.Text = "Sakrij protivnicke brodove";
            }
            else
            {
                prikazi_protivnika = false;
                button1.Text = "Prikazi protivnicke brodove";
            }
            panel2.Invalidate();
            computer_ime_panel.Invalidate();
        }



        private void gadjanje_protivnika(Point lokacija)
        {
                 int izabrano_polje_X = lokacija.X;
                    int izabrano_polje_Y = lokacija.Y;

                    if (trenutni_potez == "igrac")
                    {
                        float sirina_kvadrata = (float)panel1.Width / 10;
                        float visina_kvadrata = (float)panel1.Height / 10;
                        for (int i = 0; i < 10; i++)
                        {
                            for (int j = 0; j < 10; j++)
                            {
                                if (izabrano_polje_X >= sirina_kvadrata * i && izabrano_polje_X < sirina_kvadrata * (i + 1))
                                    if (izabrano_polje_Y >= visina_kvadrata * j && izabrano_polje_Y < visina_kvadrata * (j + 1))
                                    {
                                        if (polja_bot[i, j] != null)
                                        {
                                            if (polja_bot[i, j].Contains("pogodak") || polja_bot[i, j] == "promasaj")
                                            {

                                                MessageBox.Show("Ovo polje ste vec gadjali!");
                                                return;
                                            }

                                            else
                                            {
                                                polja_bot[i, j] += "pogodak";
                                                panel2.Invalidate();
                                                ispisi_poruku("Pogodak!");
                                                return;
                                            
                                            }

                                        }


                                        else
                                        {
                                            polja_bot[i, j] += "promasaj";
                                            panel2.Invalidate();
                                            trenutni_potez = "robot";
                                            ispisi_poruku("Promasaj!");
                                            return;

                                        }
                                        

                                    }
                            }
                        }

                      
                    }



                    if (trenutni_potez == "robot")
                    {
                        Thread.Sleep(800); // pravimo malu pauzu da bi gadjanje robota bilo sto realnije


                        float sirina_kvadrata = (float)panel1.Width / 10;
                        float visina_kvadrata = (float)panel1.Height / 10;

                        for (int i = 0; i < 10; i++)
                        {
                            for (int j = 0; j < 10; j++)
                            {

                                if (izabrano_polje_X >= sirina_kvadrata * i && izabrano_polje_X < sirina_kvadrata * (i + 1))
                                    if (izabrano_polje_Y >= visina_kvadrata * j && izabrano_polje_Y < visina_kvadrata * (j + 1))
                                    {
                                        if (polja_igrac[i, j] != null)
                                        {
                                            if (polja_igrac[i, j].Contains("pogodak") || polja_igrac[i, j] == "promasaj")
                                            {

                                                Thread.Sleep(200);
                                                potez_kompjutera();
                                                return;
                                            }

                                            else
                                            {
                                                polja_igrac[i, j] += "pogodak";
                                                ispisi_poruku("Pogodak!");
                                                panel1.Invalidate();

                                                potez_kompjutera();
                                                return;

                                            }

                                        }
                                        else
                                        {
                                            polja_igrac[i, j] += "promasaj";
                                            panel1.Invalidate();
                                            trenutni_potez = "igrac";
                                            ispisi_poruku("Promasaj!");
                                            return;
                                        }
                                       

                                    }
                            }
                        }



                    }

                    
        } //metoda za gadjanje protivnika
      




        private void computer_ime_panel_Paint(object sender, PaintEventArgs e)  //ispisisvanje imena computer
        {
            Graphics g = e.Graphics;
            StringFormat format = new StringFormat();
            string text = "Computer";


            Brush boja_cetka = new SolidBrush(Color.MidnightBlue);
            Font font = new Font("Times New Roman", 14, FontStyle.Bold);
            format.Alignment = StringAlignment.Center;

            g.DrawString(text, font, boja_cetka, computer_ime_panel.Width / 2, computer_ime_panel.Height / 2 -12, format);

        }



        private void panel_ime_igraca_Paint(object sender, PaintEventArgs e)  /// ispisivanje imena igraca
        {
            Graphics g = e.Graphics;
            StringFormat format = new StringFormat();
            string text = ime.imeIgraca;


            Brush boja_cetka = new SolidBrush(Color.MidnightBlue);
            Font font = new Font("Times New Roman", 14, FontStyle.Bold);
         
            format.Alignment = StringAlignment.Center;

            g.DrawString(text, font, boja_cetka, panel_ime_igraca.Width / 2, panel_ime_igraca.Height / 2 - 12, format);
        }



        private void splitContainer1_Resize(object sender, EventArgs e)
        {
            
            panel1.Invalidate();
            panel2.Invalidate();
        }



        public void ispisi_poruku(string poruka)  
        {
           
            Graphics g = pogodak_promasaj_panel.CreateGraphics();
            StringFormat format = new StringFormat();
            string text = poruka;

            if (text == "Pogodak!")
                g.Clear(Color.GreenYellow);
            else
                g.Clear(Color.Coral);


            Brush boja_cetka = new SolidBrush(Color.DarkSlateBlue);
            Font font = new Font("Times New Roman", 15);

            format.Alignment = StringAlignment.Center;

            g.DrawString(text, font, boja_cetka, pogodak_promasaj_panel.Width / 2, pogodak_promasaj_panel.Height / 2 -12, format);


            // ispisivanje trenutnog poteza
             g = panel_trenutni_potez.CreateGraphics();
             format = new StringFormat();
             text ="Na potezu je: "+ trenutni_potez;

            g.Clear(Color.Ivory);

             boja_cetka = new SolidBrush(Color.DarkSlateBlue);
             font = new Font("Times New Roman", 15);

            format.Alignment = StringAlignment.Center;

            g.DrawString(text, font, boja_cetka, panel_trenutni_potez.Width / 2, panel_trenutni_potez.Height / 2 - 12, format);

        }  //ispisivanje poruke POGODAK PROMASAJ



        private void panel3_Paint(object sender, PaintEventArgs e) /// ispisivanje Ime_prezime_br_indeksa_projekat_br_projekta_računarska_grafika
        {
            Graphics g = e.Graphics;
            StringFormat format = new StringFormat();
            string text = "Nikola_Kostović_1582_projekat_15_računarska_grafika";


            Brush boja_cetka = new SolidBrush(Color.CadetBlue);
            Font font = new Font("Times New Roman", 11);
           

            format.Alignment = StringAlignment.Center;

            g.DrawString(text, font, boja_cetka, panel3.Width / 2, panel3.Height / 2 - 10, format);
        }



        private void panel2_MouseClick(object sender, MouseEventArgs e)  //klik igraca
        {
            if (trenutni_potez == "igrac")
            {
                gadjanje_protivnika(new Point(e.X, e.Y));
                provjeri_pobjednika();
            }
            else
                MessageBox.Show("Niste na potezu!");
        }

        public void potez_kompjutera()  //simulacija klika kompjutera
        {
    
            Random rnd = new Random();
            
            if (trenutni_potez == "robot")
            {
            
                gadjanje_protivnika(new Point(rnd.Next(panel1.Width), rnd.Next(panel1.Height)));   //simulacija klika na random polje igraca
                
                provjeri_pobjednika();
            }
            else
                MessageBox.Show("Niste na potezu!");

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ispisi_trenutno_stanje_kompjutera();
            ispisi_trenutno_stanje_igraca();
            if (trenutni_potez == "robot")
            {
                
                potez_kompjutera();
            }
         
        }


        void ispisi_trenutno_stanje_igraca()
        {
            int[] niz = new int[5];
            Graphics g = panel4.CreateGraphics();
            StringFormat format = new StringFormat();
            string text="Stanje: ";
            int brojac = 5;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (polja_igrac[j, i] != null)
                    {
                        if (polja_igrac[j, i].Length <= 5)
                        {
                            if (polja_igrac[j, i][2] == '5' || polja_igrac[j, i][4] == '5')
                                niz[0]++;
                            if (polja_igrac[j, i][2] == '4' || polja_igrac[j, i][4] == '4')
                                niz[1]++;
                            if (polja_igrac[j, i][2] == '3' || polja_igrac[j, i][4] == '3')
                                niz[2]++;
                            if (polja_igrac[j, i][2] == '2' || polja_igrac[j, i][4] == '2')
                                niz[3]++;
                        }
                    }
                }
            }

            for (int i = 0; i < 4; i++)
            {
                text +=" brod" + brojac + ": ";
                for (int j = 0; j < niz[i]; j++)
                {
                    text += "*";
                }
                text += " | ";
                brojac--;
            }
            

            g.Clear(Color.PapayaWhip);

            Brush boja_cetka = new SolidBrush(Color.DarkSlateBlue);
            Font font = new Font("Times New Roman", 11);

            format.Alignment = StringAlignment.Center;

            g.DrawString(text, font, boja_cetka, panel4.Width / 2, panel4.Height / 2 - 10, format);

        }   //ispisivanje trenutnog stanja. Prodjemo kroz matricu polja igraca i ispitujemo stanje 

        void ispisi_trenutno_stanje_kompjutera()  //ispisivanje trenutnog stanja. Prodjemo kroz matricu polja robota i ispitujemo stanje 
        {
            int[] niz = new int[5];
            Graphics g = panel5.CreateGraphics();
            StringFormat format = new StringFormat();
            string text = "Stanje: ";
            int brojac = 5;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (polja_bot[j, i] != null)
                    {
                        if (polja_bot[j, i].Length <= 5)
                        {
                            if (polja_bot[j, i][2] == '5' || polja_bot[j, i][4] == '5')
                                niz[0]++;
                            if (polja_bot[j, i][2] == '4' || polja_bot[j, i][4] == '4')
                                niz[1]++;
                            if (polja_bot[j, i][2] == '3' || polja_bot[j, i][4] == '3')
                                niz[2]++;
                            if (polja_bot[j, i][2] == '2' || polja_bot[j, i][4] == '2')
                                niz[3]++;
                        }
                    }
                }
            }

            for (int i = 0; i < 4; i++)
            {
                text += " brod" + brojac + ": ";
                for (int j = 0; j < niz[i]; j++)
                {
                    text += "*";
                }
                text += " | ";
                brojac--;
            }


            g.Clear(Color.PapayaWhip);

            Brush boja_cetka = new SolidBrush(Color.DarkSlateBlue);
            Font font = new Font("Times New Roman", 11);

            format.Alignment = StringAlignment.Center;

            g.DrawString(text, font, boja_cetka, panel5.Width / 2, panel5.Height / 2 - 10, format);

        }

        void provjeri_pobjednika()   //provjera pobjednika. Prodjemo kroz matrice i igraca i robota
        {
            int[] niz_robot = new int[5];
            int brojac_igrac = 0;
            int brojac_robot = 0;


            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (polja_bot[j, i] != null )
                    {
                        if (polja_bot[j, i].Length <= 5)
                        {
                            if (polja_bot[j, i][2] == '5' || polja_bot[j, i][4] == '5')
                                niz_robot[0]++;
                            if (polja_bot[j, i][2] == '4' || polja_bot[j, i][4] == '4')
                                niz_robot[1]++;
                            if (polja_bot[j, i][2] == '3' || polja_bot[j, i][4] == '3')
                                niz_robot[2]++;
                            if (polja_bot[j, i][2] == '2' || polja_bot[j, i][4] == '2')
                                niz_robot[3]++;
                        }
                    }
                }
            }

            for (int i = 0; i < 4; i++)
            {
                if (niz_robot[i] != 0)
                    brojac_robot++;
            }


            int[] niz_igrac = new int[5];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (polja_igrac[j, i] != null)
                    {
                        if (polja_igrac[j, i].Length <= 5)
                        {
                            if (polja_igrac[j, i][2] == '5' || polja_igrac[j, i][4] == '5')
                                niz_igrac[0]++;
                            if (polja_igrac[j, i][2] == '4' || polja_igrac[j, i][4] == '4')
                                niz_igrac[1]++;
                            if (polja_igrac[j, i][2] == '3' || polja_igrac[j, i][4] == '3')
                                niz_igrac[2]++;
                            if (polja_igrac[j, i][2] == '2' || polja_igrac[j, i][4] == '2')
                                niz_igrac[3]++;
                        }
                    }
                }
            }


            for (int i = 0; i < 4; i++)
            {
                if (niz_igrac[i] != 0)
                    brojac_igrac++;
            }


            if (brojac_robot == 0)
            {
    
                prikazi_protivnika = true;  //prikazivanje protivnickih brodova na kraju
                panel2.Invalidate();
                MessageBox.Show("Pobjednik je " + ime.imeIgraca, "Pobjeda!");
                
                Application.Exit();
            }
            else if (brojac_igrac == 0)
            {
                prikazi_protivnika = true;//prikazivanje protivnickih brodova na kraju
                MessageBox.Show("Pobjednik je robot!","Poraz!");
                panel2.Invalidate();
                Application.Exit();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap bitmap = new Bitmap(panel_pozadina.Width, panel_pozadina.Height);
                Rectangle velicina = panel_pozadina.Bounds;

                panel_pozadina.DrawToBitmap(bitmap, velicina);

                string putanja = "..\\" + DateTime.Now.ToFileTime() + "slika_potapanje_brodova.jpg";

                bitmap.Save(putanja, ImageFormat.Jpeg);
                MessageBox.Show("Uspjesno ste napravili snapshot!\nSlika se nalazi u bin folderu projekta.","Snapshot",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
            catch(Exception)
            {
                MessageBox.Show("Nije moguce sacuvati sliku!");
            }
             
             
        }// slikanje ekrana

  


  

      
     
    }
}
