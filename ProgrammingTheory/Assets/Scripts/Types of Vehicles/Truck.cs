using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Truck : Traffic
{
    protected override void Awake()
    {
        base.Awake();
        speed = 5.5f;
        VehicleType = "Truck";
    }

}
