using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SportsCar : Traffic
{
    protected override void Awake()
    {
        base.Awake();
        speed = 10.0f;
        VehicleType = "Sports Car";
    }
}
