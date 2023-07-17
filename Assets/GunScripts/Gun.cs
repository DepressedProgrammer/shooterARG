using System.Runtime.ExceptionServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : IGun
{
   
  

    void Start()
    {  
      setGunProperties(transform.Find("Firepoint").gameObject.transform);
      stateList= new GunStateInitializer();
      currenstate= stateList.getIdleState();
      currenstate.onEnter(gameObject);
    go=gameObject;
    
    
    }

    // Update is called once per frame
    void Update()
    {   
        currenstate.onUpdate(gameObject);
        Transform Cameratransform=go.transform.parent.root.GetComponent<PlayerScript>().cam;
        camDir= Cameratransform.forward;
        firepoint.rotation=Cameratransform.rotation;
      
     

    Debug.DrawRay(firepoint.transform.position, (camDir*30), Color.blue);
 



    }

      
    

}
