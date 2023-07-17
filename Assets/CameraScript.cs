using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
   
  
   public Vector2 mov;
   
 public GameObject WorldObject;
 
 //this is the ui element
 public RectTransform UI_Element;
 public GameObject Canvas;
   public float sensitivity=1f;
    void Start()
    {
     Cursor.lockState = CursorLockMode.Locked;   
 
   
    }

    // Update is called once per frame
    void Update()
    {
    mov.x+= Input.GetAxis("Mouse X")*sensitivity;
    mov.y+= Input.GetAxis("Mouse Y")*sensitivity;
    mov.y = Mathf.Clamp(mov.y, -40f, 40f);
    transform.localRotation=Quaternion.Euler(-mov.y,mov.x,0);
 
 
//  first you need the RectTransform component of your canvas
 RectTransform CanvasRect=Canvas.GetComponent<RectTransform>();
 
 //then you calculate the position of the UI element
 //0,0 for the canvas is at the center of the screen, whereas WorldToViewPortPoint treats the lower left corner as 0,0. Because of this, you need to subtract the height / width of the canvas * 0.5 to get the correct position.
 

 Vector2 ViewportPosition=gameObject.transform.GetChild(0).transform.GetChild(0).transform.GetComponent<Camera>().WorldToViewportPoint(WorldObject.transform.position);
 Vector2 WorldObject_ScreenPosition=new Vector2(
 ((ViewportPosition.x*CanvasRect.sizeDelta.x)-(CanvasRect.sizeDelta.x*0.5f)),
 ((ViewportPosition.y*CanvasRect.sizeDelta.y)-(CanvasRect.sizeDelta.y*0.5f)));
 
 //now you can set the position of the ui element
 UI_Element.anchoredPosition=WorldObject_ScreenPosition;
     }
 

 


  

  
 
}
    

