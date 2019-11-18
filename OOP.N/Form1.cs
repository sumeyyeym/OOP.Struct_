using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.N
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Kitap ktp;
        private void BtnClass_Click(object sender, EventArgs e)
        {
            ktp = new Kitap(); // eğer bunu vermezsek çalışmaz. çünkü değerler stack'a çıkar ama heap'te bir karşılığı olmadığından patlar.
            ktp.ID = 1;
            ktp.ISBN = "1111111";
            ktp.KitapAdi = "Fakirler";
            ktp.Tur = "Dram";
            ktp.YazarAdi = "Züğürt Ağa";

            Kitap k = new Kitap()
        }

        Book bk;
        private void BtnStruck_Click(object sender, EventArgs e)
        {
            //struct kullandığımızda ise new yapmamıza gerek yok çünkü arkadaş kendi içinde her şeyi hallediyo. değerler stack'a çıkmadan struck içinde dönüyor ve proje çalışıyor. ama istersek new kullanabiliriz de bunda bir sakınca yok.
            bk.ID = 1;
            bk.ISBN = "22222222222";
            bk.KitapAdi = "Saplık";
            bk.Tur = "Trajedi";
            bk.YazarAdi = ":)";
        }

        //heap yığın kısmı. stack ise anlık değşimlerin gittiği ön bellek gibi düşünülebilir. heape ulaşmak için stackteki referansına ihtiyaç var.
        //reference types: class, string, delegate
        //heapde değer atayacağı bir karşılık oluşturmak için class için new komutu vermek gerek. (new Class() gibi). böylece rame çıkardık
        //Class cls = new Class() demek, stack kısmındaki p değişkeni heapteki Class'a eşit. yani birbirlerine referans olmuş. ancak cls için farklı bir tanımlama yaptığımızda heapte oluşturulan önceki nesne referanssız kalacağından silinecektir.
    }
}
