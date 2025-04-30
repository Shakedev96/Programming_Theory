using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bus : Traffic
{
    
    protected override void Awake()
    {
        base.Awake();
        speed = 7.0f;
        VehicleType = "Bus";
    }

    
   
}
