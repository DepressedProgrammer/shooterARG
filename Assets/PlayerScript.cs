using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : Subject
{   public int speed;
   public Transform cam ;
    public IPlayerBaseState currenstate;
    public StateInitializer stateList;
    public Vector3 ultimaDir;
    public IGun gunReference;
    void Start()
    {   
        stateList = new StateInitializer();
        currenstate = stateList.getIdleState();
        currenstate.onEnter(gameObject);
     
    }


void Update()
    {   
        currenstate.onUpdate(gameObject);
       
        Debug.DrawRay(cam.transform.position, cam.forward*30, Color.red);

    }

    public void onSwicht(IPlayerBaseState state){
        currenstate=state;
        currenstate.onEnter(gameObject);
    }

public void Mover(Vector3 direccion)
    {  
         
    ultimaDir=direccion;
    Vector3 camf = cam.forward; camf.y=0; camf= camf.normalized;
    Vector3 camr =cam.right;camr.y=0; camr= camr.normalized;
    GetComponent<Rigidbody>().MovePosition(transform.position+=(camf*direccion.y+ camr*direccion.x)*speed*Time.deltaTime);
        // transform.position+=(camf*direccion.y+ camr*direccion.x)*speed*Time.deltaTime;
    }

}












 public class StateInitializer{
     AimState aimState;
    DeathState deathState;
    CrouchState crouchState;
    IdleState idleState;
    InjuredState injuredState;
    JumpState jumpState;
    InteractState interactState;
    WalkState walkState;
    RunningState runningState;
    public StateInitializer(){
     aimState= new AimState();
     deathState= new DeathState();
     crouchState= new CrouchState();
     idleState= new IdleState();
     injuredState= new InjuredState();
     jumpState= new JumpState();
     interactState= new InteractState();
     walkState= new WalkState();
     runningState= new RunningState();
    
    }
    public IPlayerBaseState getAimState(){
        return aimState;
    }
     public IPlayerBaseState getDeathState(){
        return deathState;
    }
     public IPlayerBaseState getCrouchState(){
        return crouchState;
    }

     public IPlayerBaseState getInjuredState(){
        return injuredState;
    }
     public IPlayerBaseState getJumpState(){
        return jumpState;
    }
    public IPlayerBaseState getWalkState(){
        return walkState;
    }
    public IPlayerBaseState getRunningState(){
        return runningState;
    }
    public IPlayerBaseState getIdleState(){
        return idleState;
    }
    public IPlayerBaseState  getIntecactState(){
        return interactState;
    }

}