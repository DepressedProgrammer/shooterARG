using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GReloadingState : IGunBaseState
{
  public override void onEnter(GameObject gun) {
    Debug.Log("toca recargar");
    this.gun=gun;
   }
   public override void onCollisionEnter(GameObject gun) {
    
   }
   public override void onUpdate(GameObject gun) {
     if (Input.GetKeyDown(KeyCode.R))
    {   getGunScript().MagAmmo=getGunScript().guninfo.ammocount;
        getGunScript().onSwicht(getGunScript().stateList.getIdleState());
    }
   }
}
