using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour
{
    //Uzglabā ainā esošo kanvu
    public Canvas kanva;
    //GameObject, kas uzglabās velkamos objektus
    public GameObject AtkritumuMasina;
    public GameObject AtraPalidziba;
    public GameObject Autobuss;

    //Uzglabā velakmo objektu sākotnējās atrašanās vietas koordinātas
    [HideInInspector]
    public Vector2 atkrMKoord;
    [HideInInspector]
    public Vector2 atrPKoord;
    [HideInInspector]
    public Vector2 bussKoord;

    //Uzglabās audio avotu, kurā atskaņot attēlu skaņas efektus
    public AudioSource skanasAvots;
    //Masīvs, kas uzglabā visas iespējamās skaņas
    public AudioClip[] skanasKoAtskanot;
    //Mainīgais piefiksē vai objekts nolikts īstajāvietā (true/false)
    [HideInInspector]
    public bool vaiIstajaVieta = false;
    //Uzglabās pēdējo objektu, kurš pakustināts
    public GameObject pedejaisVilktais = null;

    // Use this for initialization
    void Start()
    {
        atkrMKoord = AtkritumuMasina.GetComponent<RectTransform>().localPosition;
        atrPKoord = AtraPalidziba.GetComponent<RectTransform>().localPosition;
        bussKoord = Autobuss.GetComponent<RectTransform>().localPosition;
    }
}
