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
    }

    public override void onUpdate(GameObject player)
    {
          if (Input.GetKey(KeyCode.Mouse1))
        {
            getPScript().speed=3;
        }
    }
  
}
