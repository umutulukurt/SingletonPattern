using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    /* Umut Ulukurt
     * umutulukurt@outlook.com
     */
    class Program
    {
        
        static void Main(string[] args)
        {
            //Foo f = new Foo(); --> Yapıcısı private olduğu için nesnenin örneğini alamayız.

            //GetFooInstance methodu ile iki farklı nesne return etmesini istedik.
            var foo =  Foo.GetFooInstance();
            var foo1 = Foo.GetFooInstance();

            //Her iki nesneninde HashCode'unu alarak, gerekli kontrolümüzü yaptık
            //Her iki nesneninde HashCodu'u aynı. 
            //Dikkat edilmesi gereken konu, nesnenin alınan ilk örneği geçerlidir.
            //İkinci ve ya daha sonraki alınan örnekleri, sınıfın içerisindeki method,
            //property,delegate vs. değerleri, içerikleri dinamik olarak değiştirilse dahi,
            //nesnenin alınan ilk örneği geçerli olacaktır.
            Console.WriteLine(foo.GetHashCode());
            Console.WriteLine(foo1.GetHashCode());
        }
    }
}
