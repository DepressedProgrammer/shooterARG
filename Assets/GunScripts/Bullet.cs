using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
   private Vector3 shootdir;
    public float moveSpeed;
    private float updTimer;
    private Transform firepoint;
    Rigidbody rb ;
    private void Start() {
  
     rb=GetComponent<Rigidbody>();   
    }
    public void BulletDir(Vector3 shootdir,Transform firepoint){
        this.shootdir=shootdir;
        this.firepoint=firepoint;
    // Debug.Log(shootdir+","+firepoint);
         //TODO script para devolver la bala a la pool
         updTimer=0f;
       
          rb.AddForce(shootdir.normalized * moveSpeed, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {   
      // Debug.Log("la velocidad de la bala es "+rb.velocity);
        
       
        updTimer+=.1f;
        if (updTimer>8&& gameObject.active)
        {
            stopMovement();
            
        }
       
        
    }

  public void stopMovement(){
    rb.velocity=Vector3.zero;
    transform.position=firepoint.position;
    gameObject.SetActive(false);
  }
   private void OnTriggerEnter(Collider other) {
    Debug.Log("choque con algo");
    stopMovement();
   }
}
