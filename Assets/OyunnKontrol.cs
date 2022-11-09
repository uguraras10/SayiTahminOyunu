using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunnKontrol : MonoBehaviour
{
    int minSayi = 1;
    int maxSayi = 100;
    int tahmin;
    bool OyunBasladi = false;
    bool OyunBitti = false;
    // Start is called before the first frame update
    void Start()
    {
        print("Benimle oyun oynamak ister misin? (E/H) ");
    }
    // Update is called once per frame
    void Update()
    {
        //--------------> BAÞLANGIÇ <---------- //
        if (!OyunBasladi)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                print("Harika..Aklýndan 1-100 arasý bir sayý tut ve ENTER'a bas. ");
            }
            else if (Input.GetKeyDown(KeyCode.H))
            {
                print("Sen bilirsin gözüm.. ");
            }
            if (Input.GetKeyDown(KeyCode.Return))
            {
                Kontrol();
                OyunBasladi = true;
            }
            //------------> BAÞLANGIÇ <-------- //
        }
        else if(!OyunBitti)
        {

            //----------->OYUN KISMI<---------//
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                minSayi = tahmin;
                Kontrol();
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                maxSayi = tahmin;
                Kontrol();

            }
            else if (Input.GetKeyDown(KeyCode.Space))
            {
                print("Yaþasýn... Aklýndaki sayýyý buldum !!! ");
                OyunBitti = true;
            }
        }
    }
         void Kontrol()
          {
        tahmin = (minSayi + maxSayi) / 2;
        print("Aklýndan tuttuðun sayý" + tahmin + "mi ? Daha büyük ise yukarý, daha küçük ise aþaðý yön tuþuna bas.Doðruysa boþluk'a bas !!");
           }
}
