using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Pulsado : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{
    public bool Play;

    public void OnPointerDown(PointerEventData eventData)
    {
        Play = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Play = false;
    }

  
}
