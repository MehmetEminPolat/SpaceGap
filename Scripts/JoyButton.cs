using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JoyButton : MonoBehaviour,IPointerUpHandler,IPointerDownHandler
{
    [HideInInspector]
    public bool preesed;
    public void OnPointerDown(PointerEventData eventData)
    {
        preesed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        preesed = false;
    }

}
