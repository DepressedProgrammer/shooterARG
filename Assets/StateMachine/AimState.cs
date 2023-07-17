using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimState : IPlayerBaseState
{
    public override void onCallisionenter(GameObject player)
    {
 
    }

    public override void onEnter(GameObject player)
    {
      this.player=player;
       getPScript().speed=3;
       getPScript().gunReference.onSwicht(getPScript().gunReference.stateList.getAimState());
    }

    public override void onUpdate(GameObject player)
    {    float horizontal =Input.GetAxisRaw("Horizontal");
      float vertical =Input.GetAxisRaw("Vertical");
        
      

        if (horizontal!=0f || vertical !=0f)
        {   
           getPScript().Mover(new Vector3(horizontal,vertical,0));
             if (Input.GetAxisRaw("Run")!=0f)
        {
            getPScript().onSwicht(getPScript().stateList.getRunningState());
        }
        }  
     if (Input.GetKeyUp(KeyCode.Mouse1))
    {
        getPScript().onSwicht(getPScript().stateList.getIdleState());
    }
       
    }
  
}
