using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : IPlayerBaseState
{
 

    public override void onCallisionenter(GameObject player)
    {
     
    }

    public override void onEnter(GameObject player)
    {
          this.player = player;
    }

    public override void onUpdate(GameObject player)
    {
      float horizontal =Input.GetAxisRaw("Horizontal");
      float vertical =Input.GetAxisRaw("Vertical");
        

        if (horizontal!=0f || vertical !=0f)
        {   
           getPScript().onSwicht(getPScript().stateList.getWalkState());
             
        }  
        if (Input.GetKey(KeyCode.Mouse1))
        {
            getPScript().onSwicht(getPScript().stateList.getAimState());
        }

    }
}
