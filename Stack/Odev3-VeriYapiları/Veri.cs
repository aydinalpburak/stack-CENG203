using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev3_VeriYapiları
{
    public class Veri
    {
        
        public string kitap_adi;
        public Veri sonraki;
        public Veri(string kitap_adi) {
            this.kitap_adi = kitap_adi;
        }
    }
     
    public class liste 
    {
        public int maxDeger;
        public string sonsilinen=null;
        Veri ilk = null;
        Veri son = null;
        public void push(string kitap_adi) {
            if (size()<maxDeger)
            {
                Veri veri = new Veri(kitap_adi);
                if (ilk == null)
                {
                    ilk = veri;
                    son = veri;
                    son.sonraki = null;
                }
                else
                {
                    veri.sonraki = ilk;
                    ilk = veri;
                }
            }
            else
            {
                MessageBox.Show("Yigin MAX Degere Ulasti!!");
            }
            
        }
        public void pop() {
            if (size()!=0)
            {
                if (son == ilk)
                {
                    sonsilinen = ilk.kitap_adi;
                    ilk = null;
                    son = null;
                }
                else
                {
                    sonsilinen = ilk.kitap_adi;
                    ilk = ilk.sonraki;
                }
            }
            else
            {
                MessageBox.Show("Listede Eleman Yok!!");
            }
        }
        public int size() {
            Veri gecici = ilk;
            int sayac = 0;
            while (gecici!=null)
            {
                sayac++;
                gecici = gecici.sonraki;
            }
            return sayac;
        }
        public void listBoxaEkle(ListBox o) {
            Veri gecici = ilk;
            while (gecici!=null)
            {
                o.Items.Add(gecici.kitap_adi);
                gecici = gecici.sonraki;
            }
        }
    }
}
