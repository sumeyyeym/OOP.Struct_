using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.N
{
    public class Kitap //classta istediğin kadar ctor oluşturabilirsin
    {
        public Kitap() // eğer böyle bir yapı olmazsa ve form içerisinde Kitap() gibi bir tanımlama yaparsaqk hata alırız. Ancak struct'ta bu durum söz konusu değil.tek ctor yazarak aşağıdaki tüm tanımlamaları yazmak mümkün
        {

        }

        public Kitap(string kitapadi)
        {
            this.KitapAdi = kitapadi;
        }

        public Kitap(string kitapadi, string yazaradi) : this(kitapadi)
        {
            this.YazarAdi = yazaradi;
        }
        public Kitap(string kitapadi, string yazaradi, string isbn) : this(kitapadi,yazaradi)
        {
            this.ISBN = isbn;
        }

        public Kitap(string kitapadi, string yazaradi, string isbn, string tur) : this(kitapadi, yazaradi, isbn)
        {
            this.Tur = tur;
        }
        public int ID { get; set; }
        public string KitapAdi { get; set; }
        public string YazarAdi { get; set; }
        public string ISBN { get; set; }
        public string Tur { get; set; }
        
    }

    public struct Book //structta parametresiz ctor oluşturamazsın. yalnızca tek bir ctor oluşturulabilir.
    {
        public Book(string kitapadi, string yazaradi, string isbn, string tur)
        {
            this.ID = 0;
            this.KitapAdi = kitapadi;
            this.YazarAdi = yazaradi;
            this.ISBN = isbn;
            this.Tur = tur;
        } //alttaki değişkenlerin hepsini ctor içinde tanımlamak gerek
        public int ID { get; set; }
        public string KitapAdi { get; set; }
        public string YazarAdi { get; set; }
        public string ISBN { get; set; }
        public string Tur { get; set; }

    }
}
