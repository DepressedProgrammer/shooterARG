using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MostrarEstado : MonoBehaviour
{
    public TMPro.TMP_Text text;
    public TMPro.TMP_Text text2;
    public GameObject player;
    
    // Update is called once per frame
    void Update()
    {
        text.text = player.GetComponent<PlayerScript>().currenstate.ToString();
    text2.text = player.GetComponent<PlayerScript>().gunReference.currenstate.ToString();
   
    }
}
