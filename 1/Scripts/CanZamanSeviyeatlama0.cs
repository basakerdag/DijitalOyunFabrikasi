using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanZamanSeviyeatlama0 : MonoBehaviour
{
   
   
   public Text can,zaman,durum;
   float zamanS = 50;
   
   bool devam = true;
   bool tamam = false;
   


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
         if(devam && !tamam)
        {
          zamanS -= Time.deltaTime;
          zaman.text = (int)zamanS+"";
        }
        else if(!tamam)
        {
          durum.text="��k��a ula�amad�n :(";
        }
 
        if (zamanS<0)
        {
            devam = false;
        }
    }
       
    
   
    private void OnCollisionEnter(Collision other)
    {
        string obje = other.gameObject.name;
        if(obje.Equals("C�k�s"))
        {
           tamam=true;
           durum.text="��k��a ula�t�n,tebrikler ^-^";
        }
        
      
    }

   

}
