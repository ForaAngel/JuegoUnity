using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteractable : SimpleHingeInteractable
{
    [SerializeField] Transform doorObject;
    void Start()
    {
        
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
        if (doorObject != null)
        {
            Debug.Log("Si sirve");
            doorObject.localEulerAngles = new Vector3(
                doorObject.localEulerAngles.x,
                doorObject.localEulerAngles.y,
                doorObject.localEulerAngles.z);
        }
    }
}
