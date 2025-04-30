using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HatchBack : Traffic
{
    protected override void Awake()
    {
        base.Awake();
        speed = 8.0f;
        VehicleType = "HatchBack";
    }
}
