using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IPlayerBaseState 
{   protected GameObject player;
    public abstract void onEnter(GameObject player);
    public abstract void onUpdate(GameObject player);

    public abstract void onCallisionenter(GameObject player);
    public   PlayerScript getPScript(){
        return player.GetComponent<PlayerScript>();
    }
}
