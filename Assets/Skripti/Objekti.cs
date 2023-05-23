using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Jaimporte lai varetu lietot visus intefeicus
using UnityEngine.EventSystems;
public class Objekti : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler {
	//uzglaba noradi uz objekti skripti
	public Objekti objektuSkripts;
	//velkamam objektam piestiprina canvasgroup komponente
	private CanvasGroup kanvasGrupa;
	//objekta atrasanas vieta kurs tiks parvietots
	private RectTransform velkObjRecTransf;


    void Start() {
    //Pieklust objektam piestiprinatai canvasgroup komponentei
        kanvasGrupa= GetComponent<CanvasGroup>();
        //pieklust objekta reacttransform komponentei
        velkObjRecTransf= GetComponent<RectTransform>();

    }

    public void OnBeginDrag(PointerEventData eventData)
    {

        Debug.Log("Uzklikšķināts uz velkamā objekta");

    }

    public void OnDrag(PointerEventData eventData)
    {
       
    }

    public void OnEndDrag(PointerEventData eventData)
    {
       
    }

    public void OnPointerDown(PointerEventData eventData)
    {
       
    }
}
