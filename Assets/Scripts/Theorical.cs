using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Theorical : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Scene kýsmýndaki 2D, oyununuzu 3 boyutlu bir ortamda 2 boyutlu göstermenizi saðlar. 2 boyutlu olduðu için Z axis'inde objeleri yönlendiremezsiniz.

        //.AddTorque: Objeye dönüþ kuvveti uygular.

        //Canvas: içerisinde belirli alanlarda Unity UI bileþenlerini göstermek için kullanýlýr.

        //TextMesh Pro: UI sisteminde Text'e alternatiftir. Yazýlarý blur'suz ve kaliteli bir þekilde ekrana aktarmaktadýr. UI için kullanýlýr. Objelerine eriþebilmek için TMPro namespace'ini aktive etmeniz gerekir. Anchor Points ile belirli UI'ýn belirlediðiniz alanlarda ne olursa olsun kalmasýný saðlar (kamera hareketi vs) 

        //Button: UI sisteminde bir button çýkarmanýzý saðlar. 

        //Eðer bir button'a týklandýðýnda kodlarýný yazdýðýmýz özelliklerine eriþmesini istiyorsak button objesine unity'de týkladýktan sonra Inspector'da On Click() özelliðine, button kodlarýný yazdýðýmýz kodlarý içeren script'i sürükleyerek o objenin metotlarýna ulaþabiliriz.

        //.AddListener: Button'larda metot çaðýrmak için kullanýlýr

        //button.onClick.AddListener(SetDifficulty); (Burada SetDifficulty metodu button'a týklandýðýnda çaðýrýlacak.)

        //UnityEngine.SceneManagement: Bu namespace Unity'de scene'lerin yüklenmesini yönetir. (örneðin oyunu tekrar baþlatmak için bu kütüphanenin aktif olmasý gereklidir)

        //UnityEngine.UI: Unity'nin UI sistemiyle ilgili kod yazarken bu kütüphane kullanýlýr.
    }
}
