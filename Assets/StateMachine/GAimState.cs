using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GAimState : IGunBaseState
{   
   public override void onEnter(GameObject gun) {
    this.gun = gun;
    
    getGunScript().guninfo.auxAxis=getGunScript().guninfo.RecoilAxis;
   getGunScript().guninfo.RecoilAxis=getGunScript().guninfo.RecoilAim;
    
   }
   public override void onCollisionEnter(GameObject gun) {
    
   }
   public override void onUpdate(GameObject gun) {
    
       if (getGunScript().MagAmmo==0)
    {   getGunScript().guninfo.RecoilAxis=getGunScript().guninfo.auxAxis;
       getGunScript().onSwicht(getGunScript().stateList.getReloadingState());
    } 
     else if (Input.GetKey(KeyCode.Mouse0) && Time.time >= getGunScript().fireratedowntime)
    {
      
      getGunScript().fireratedowntime = Time.time + 1f / getGunScript().firerate;
      shoot();
      
    }  
     if (Input.GetKeyUp(KeyCode.Mouse1))
    { 
       getGunScript().guninfo.RecoilAxis=getGunScript().guninfo.auxAxis;
        getGunScript().onSwicht(getGunScript().stateList.getIdleState());
    }
   }
}
