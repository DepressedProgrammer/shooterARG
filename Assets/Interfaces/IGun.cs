using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IGun : MonoBehaviour
{   public float firerate;
    public float fireratedowntime;
      public IGunBaseState currenstate;
    public Transform firepoint;
    public static GameObject go;
    public Vector3 camDir;
    public int MagAmmo;
    public GameObject bulletpool;
   [SerializeField] public GunInfo guninfo;
    public Queue<Transform> bulletQueue;
    public Recoil recoilreference;   
     public GunStateInitializer stateList;
    
       
       public void setGunProperties(Transform firepoint){
        Debug.Log("loaded gun properties");
       this.firepoint=firepoint;
        this.firerate= guninfo.firerate;
        stateList = new GunStateInitializer();
        bulletQueue= new Queue<Transform>();
         fillQueue();
         recoilreference= transform.parent.root.gameObject.transform.GetChild(0).transform.GetChild(0).GetComponent<Recoil>();
         MagAmmo=guninfo.ammocount;

       }

       

       public void fillQueue(){
          foreach (Transform child in bulletpool.transform)
        {     
         child.gameObject.SetActive(false);
            bulletQueue.Enqueue(child);
   
        }
       }
   public void onSwicht(IGunBaseState state){
        currenstate=state;
        currenstate.onEnter(gameObject);
    }   
} 

 public class GunStateInitializer{
    GAimState gaimState;
    GIdleState gidleState;
   
    GReloadingState greloadingState;
    // DeathState deathState;
    // CrouchState crouchState;
    // JumpState jumpState;
    // InteractState interactState;
    public GunStateInitializer(){
      Debug.Log("inicializando gunstates");
      gaimState= new GAimState();
      gidleState= new GIdleState();
      
      greloadingState = new GReloadingState();
    //  jumpState= new JumpState();
    //  interactState= new InteractState();
    //  deathState= new DeathState();
    //  crouchState= new CrouchState();
    }


    public IGunBaseState getAimState(){
      Debug.Log("devolviendo gaimstate");
        return gaimState;
    }
        
    public IGunBaseState getIdleState(){
        return gidleState;
    }
 
    public IGunBaseState getReloadingState(){
      return greloadingState;
    }
    //  public IPlayerBaseState getDeathState(){
    //     return deathState;
    // }
    //  public IPlayerBaseState getCrouchState(){
    //     return crouchState;
    // }
 
    //  public IPlayerBaseState getJumpState(){
    //     return jumpState;
    // }
    
    // public IGunBaseState  getIntecactState(){
    //     return interactState;
    // }

    
}