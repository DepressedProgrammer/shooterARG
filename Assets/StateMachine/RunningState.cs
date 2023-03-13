using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunningState : IPlayerBaseState
{
    public override void onCallisionenter(GameObject player)
    {
        throw new System.NotImplementedException();
    }

    public override void onEnter(GameObject player)
    {
         this.player = player;
    }

    public override void onUpdate(GameObject player)
    {    getPScript().Mover(getPScript().ultimaDir);
         if (Input.GetAxisRaw("Run")!=0f)
        {   
            getPScript().speed=13;
   
        }
        else{  getPScript().onSwicht(getPScript().stateList.getWalkState()); }
    }
    
}
