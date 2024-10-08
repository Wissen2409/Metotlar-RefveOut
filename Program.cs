

// Bir önceki konumuz değer tip ve referans tiplerin,birbirlerine göre farklılıkları ve aynı zamnada
// bellekte nasıl durduklarıydı

// Şimdi yapacağımız konu yine değer ve referans tipler ile ilgili olacak

// ancak hayatımıza iki farklı keyword daha katılacak bunlar; ref ve out


// Ref Keyword'ü : Değer tipli değişkenleri, referans tipli gibi davranmaya zorlar
#region Ref Keyword

/*/
using System.Collections;

int a =10;
Console.WriteLine(a);//10
Degistir(ref a);
Console.WriteLine(a);//11

// Ref Keyword'ü, referans tipli değişkenlerde bir işe yaramaz
// Neydi Ref : Değer tipli değişkenleri referans tip gibi göstermeye yarar
ArrayList liste = new ArrayList{10,20,30,40};
Console.WriteLine(liste[0]);
DegistirArrayList(ref liste);   
Console.WriteLine(liste[1]);    

Console.WriteLine(liste[0]);

static void Degistir(ref int degisken){
    degisken=11;
}
static void DegistirArrayList(ref ArrayList liste){

    liste[0]=100;
}

*/
#endregion

#region Out Keyword

// Out Keyword : Bir metot içerisinden değer çıkartabilmek için kullanılan bir yöntemdir

// Out kullanırken, değişkene başlangıç değeri verilmez, değer metot çalıştıktan sonra değişkene aktarılır


// Out Ref'e benzer bir devranış sergiledi : İkisinin arasındaki en temel fark, ref bağlangıç değeri olan değişkenlerle, out ise, başlangıç değeri olmayan değişkenler ile kullanılır
int a;
DegerAta(out a);
Console.WriteLine("Out : "+a);


// .net içerisindeki out kullanan bir metot var mı ?
// int.TryParse

int b;
bool isOk = int.TryParse("100",out b);
// bu metot ,bir string'i int'e çevirip çevirmeyeceğini kontrol eder, eğer çevirirse, out ile , yukarıdaki 
// yukarıdaki başlangıç değeri olmayan b değişkenine dönüştürülmüş değeri atayacaktır
// dönüştiremez ise, geri dönüş değeri olarak false dönecektir.
// int tipinin başlangıç değeri 0'dir

Console.WriteLine(isOk);
Console.WriteLine(b);


static void DegerAta(out int a)
{
    // out ile gelen a değişkenine metot içerisindeki başlangıç değeri verildi.
    a=10;
}
#endregion
