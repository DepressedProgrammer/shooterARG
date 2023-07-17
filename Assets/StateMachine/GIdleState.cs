using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GIdleState : IGunBaseState
{
  public override void onEnter(GameObject gun) {
    this.gun=gun;
    Debug.Log("balas en cargador "+getGunScript().MagAmmo);
   }
   public override void onCollisionEnter(GameObject gun) {
    
   }
   public override void onUpdate(GameObject gun) {
if (getGunScript().MagAmmo==0)
{
  getGunScript().onSwicht(getGunScript().stateList.getReloadingState());
} 
else 
    if (Input.GetKey(KeyCode.Mouse0) && Time.time >= getGunScript().fireratedowntime)
    {
      getGunScript().fireratedowntime = Time.time + 1f / getGunScript().firerate;
      shoot();
    }  
   }
}
