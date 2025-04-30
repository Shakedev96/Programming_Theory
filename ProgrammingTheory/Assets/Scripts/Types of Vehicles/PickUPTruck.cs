using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUPTruck : Traffic
{
    protected override void Awake()
    {
        base.Awake();
        speed = 6.5f;
        VehicleType = "Pick UP Truck";
    }
}
