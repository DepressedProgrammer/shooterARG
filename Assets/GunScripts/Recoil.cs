using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recoil : MonoBehaviour
{ 
    private Vector3 currentrotation;
    private Vector3 targetrotation;
 
 
 [SerializeField] private float snapiness;
 [SerializeField] private float returnSpeed;

    void Start()
    {
        
    }
 
    void Update()
    {   
 
        targetrotation =Vector3.Lerp(targetrotation, Vector3.zero, returnSpeed * Time.deltaTime);
        currentrotation = Vector3.Slerp(currentrotation, targetrotation, snapiness * Time.fixedDeltaTime);
        transform.localRotation = Quaternion.Euler(currentrotation);

        
    }

    public void recoilFire(float recoilX, float recoilY, float recoilZ){
 
        targetrotation += new Vector3(Random.Range(0, recoilX),Random.Range(-recoilY,  recoilY), 0);
    }
}
