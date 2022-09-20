using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections; //Ekle


namespace Maaş_bordro_Hesapllama
{
    public partial class Form1 : Form
    {
        ArrayList maaş = new ArrayList();
        public Form1()
        {
            


            InitializeComponent();
        }
       
        private void btnhesapla_Click(object sender, EventArgs e)
        {  /*--------------- Tanımlama---------------------*/
           if (txtadsoyad.Text.Length >=4)
            {
                //   maaş.Add(txtadsoyad.Text);

                string AdSoyad = txtadsoyad.Text;
                int cgs = int.Parse(txtcgs.Text);
                int kıdem = int.Parse(txtkıdeem.Text);
                int cocuksayısı = int.Parse(txtcocuksayısı.Text);
                int brütücret =0 ;
                int vergi = 0;
                int netücret = 0;
                int cocukYardımı = 0;
                /*----------------------------------------------*/
               
                if (kıdem<10)
                {
                     brütücret = cgs * 250;

                }
                else if (kıdem<20)
                {
                     brütücret = cgs * 350;

                }
                else
                {
                     brütücret = cgs * 400;


                }
                if (cocuksayısı==0)
                {

                    cocukYardımı = 0;
                }
                else if (cocuksayısı==1)
                {

                    cocukYardımı = 300;


                }
                else if (cocuksayısı==2)
                {


                    cocukYardımı = 500;


                }
                else if (cocuksayısı==3)
                {

                    cocukYardımı = 700;


                }
                else if (cocuksayısı>4)
                {

                    cocukYardımı = 900;

                }

                if (brütücret<6500)
                {
                    vergi = 0;
                }
                if (brütücret<10000)
                {
                    vergi = brütücret * 15 / 100;
                }
                if (brütücret < 20000) 
                {
                    vergi = brütücret * 20 / 100;

                }
                else
                {
                    vergi = brütücret*25 / 100;
                }
                netücret = brütücret - vergi + cocukYardımı;
                listbilgiler.Items.Add("Ad Soyad : " + AdSoyad);
                listbilgiler.Items.Add("Calışma Gün Sayısı : " + cgs);
                listbilgiler.Items.Add("Kıdem : " + kıdem);
                listbilgiler.Items.Add("Cocuk Saysısı: " + cocuksayısı);
                listbilgiler.Items.Add("Brüt Ücret:" + brütücret);
                listbilgiler.Items.Add("vergi: " + vergi);
                listbilgiler.Items.Add("Net ücret: " + netücret);

                txtadsoyad.Clear();
                txtcgs.Clear();
                txtkıdeem.Clear();
                txtcocuksayısı.Clear();
            }
            else
            {
                txtadsoyad.Clear();
               
                MessageBox.Show("Müşteri ad soyadı en az 5 karakter olmalıdır!...", "Hatalı Veri girişi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            



        }
        private void btntemizle_Click(object sender, EventArgs e)
        {
            listbilgiler.ClearSelected();
        }
    }
}
