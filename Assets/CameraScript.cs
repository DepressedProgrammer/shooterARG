using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
   public GameObject player;
   public Vector3 offset;
   public Vector2 mov;
  
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

        
// mov.y= Mathf.Clamp(mov.y, -40f, 40f);
    
    
    
     }

  

  
 
}
    

