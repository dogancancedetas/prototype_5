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
        //Scene k�sm�ndaki 2D, oyununuzu 3 boyutlu bir ortamda 2 boyutlu g�stermenizi sa�lar. 2 boyutlu oldu�u i�in Z axis'inde objeleri y�nlendiremezsiniz.

        //.AddTorque: Objeye d�n�� kuvveti uygular.

        //Canvas: i�erisinde belirli alanlarda Unity UI bile�enlerini g�stermek i�in kullan�l�r.

        //TextMesh Pro: UI sisteminde Text'e alternatiftir. Yaz�lar� blur'suz ve kaliteli bir �ekilde ekrana aktarmaktad�r. UI i�in kullan�l�r. Objelerine eri�ebilmek i�in TMPro namespace'ini aktive etmeniz gerekir. Anchor Points ile belirli UI'�n belirledi�iniz alanlarda ne olursa olsun kalmas�n� sa�lar (kamera hareketi vs) 

        //Button: UI sisteminde bir button ��karman�z� sa�lar. 

        //E�er bir button'a t�kland���nda kodlar�n� yazd���m�z �zelliklerine eri�mesini istiyorsak button objesine unity'de t�klad�ktan sonra Inspector'da On Click() �zelli�ine, button kodlar�n� yazd���m�z kodlar� i�eren script'i s�r�kleyerek o objenin metotlar�na ula�abiliriz.

        //.AddListener: Button'larda metot �a��rmak i�in kullan�l�r

        //button.onClick.AddListener(SetDifficulty); (Burada SetDifficulty metodu button'a t�kland���nda �a��r�lacak.)

        //UnityEngine.SceneManagement: Bu namespace Unity'de scene'lerin y�klenmesini y�netir. (�rne�in oyunu tekrar ba�latmak i�in bu k�t�phanenin aktif olmas� gereklidir)

        //UnityEngine.UI: Unity'nin UI sistemiyle ilgili kod yazarken bu k�t�phane kullan�l�r.
    }
}
