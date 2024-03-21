using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screamer : MonoBehaviour
{
    public GameObject Susto;

    private void OnTriggerEnter(Collider other){
        if(other.CompareTag("Player")){
            Instantiate(Susto); 
        }
    }
}
