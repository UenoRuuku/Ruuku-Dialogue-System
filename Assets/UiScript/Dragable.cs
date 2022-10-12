using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System;
using TMPro;
 
public class Dragable : MonoBehaviour,IBeginDragHandler,IDragHandler,IEndDragHandler
{

    TextMeshProUGUI Text;

    private void Start() {
        Text = transform.GetComponent<TextMeshProUGUI>();
    }


    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
    {
        print("start drag");
        print(Input.mousePosition);
    }
 
    void IDragHandler.OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;//eventData就是屏幕坐标下的鼠标位置
    }
 
    void IEndDragHandler.OnEndDrag(PointerEventData eventData)
    {
        print("end drag");
    }

}