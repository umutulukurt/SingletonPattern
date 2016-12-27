using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    /* Sembolik bir sınıf oluşturuyoruz. Sınıfımızın içerisindeki static bir method yardımı ile
     * nesnenin bir örneğini alıyoruz.
     * 1) Yapıcı private. new anahtar sözcüğü ile türetilmesine müsade etmemeliyiz.
     * 2) Geri dönüşü Products olan static bir fonksiyonumuz var.
     * 
     */
    public class Foo
    {
        /*This anahtar sözcüğünü hatırlayalım;
         *Bir methodun içerisinde this anahtar sözcüğünü kullandığımızda ,
         *o sınıfın içerisindeki methodlara,fonksiyonlara,propertylere,fieldlara,delegatelere vs.
         *ulaşırız. 
         * -Kesinlikle böyle değil ama basit bir benzetme yaparsak- 
         * her sınıfın içerisinde kendi türünden new anahtar sözcüğü ile türetilmiş bir 
         * örneğinin olduğunu düşünebiliriz.
         */
        private static Foo _Foo { get; set; }
        
        //Yapıcısı private. Çünkü dışarıdan new anahtar sözcüğü ile türetilmemeli.
        private Foo() { }

        /*
         * GetFooInstance methodu çağrıldığında yukarıda tanımlamış olduğumuz
         * propertye gidecek ve daha önce new anahtar sözcüğü ile türedildiyse
         * türetilmiş halini return edecek, eğer türetilmemişse,
         * yeni bir örneğini türetip, return edecek.
         */
        public static Foo GetFooInstance() => _Foo == null ? _Foo = new Foo() : _Foo;
     
    }
}
