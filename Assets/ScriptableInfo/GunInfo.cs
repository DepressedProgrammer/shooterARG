using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GunInfo", menuName = "shootermalvi/GunInfo", order = 0)]
public class GunInfo : ScriptableObject {
    public Vector3 RecoilAxis;
    public int ammocount;
    public float firerate;
    public Vector3 RecoilAim;
    public Vector3 auxAxis;
    public bool isSemiAuto;
}
