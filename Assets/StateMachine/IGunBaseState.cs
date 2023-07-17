using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IGunBaseState 
{
  protected GameObject gun;
    public abstract void onEnter(GameObject gun);
    public abstract void onUpdate(GameObject gun);

    public abstract void onCollisionEnter(GameObject gun);
   
    public IGun getGunScript(){
        return gun.GetComponent<IGun>();
    }
  public Input isSemiAuto(){

  }
    public void shoot(){
         getGunScript().MagAmmo--;
         Debug.Log("quedan "+getGunScript().MagAmmo+ " balas");
               if (getGunScript().bulletQueue.Count==0)
         {  
            getGunScript().fillQueue();
         }
          
        
         getGunScript().recoilreference.recoilFire(getGunScript().guninfo.RecoilAxis.x,getGunScript().guninfo.RecoilAxis.y,getGunScript().guninfo.RecoilAxis.z);
        //  getGunScript().bulletQueue.Peek().GetComponent<Bullet>().stopMovement();
         getGunScript().bulletQueue.Peek().gameObject.SetActive(true);
         getGunScript().bulletQueue.Peek().position=getGunScript().firepoint.position;
         getGunScript().bulletQueue.Peek().rotation=getGunScript().firepoint.rotation;
         getGunScript().bulletQueue.Peek().GetComponent<Bullet>().BulletDir(getGunScript().camDir,getGunScript().firepoint);
         getGunScript().bulletQueue.Dequeue();
  
     
      
       }
}
