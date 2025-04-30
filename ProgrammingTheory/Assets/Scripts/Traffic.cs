using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class Traffic : MonoBehaviour
{

    public string VehicleType = "Generic";

    protected float speed;

    protected Rigidbody rb;
    // Start is called before the first frame update
    protected virtual void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        Move();
    }

    protected virtual void Move()
    {
        //rb.AddForce(Vector3.forward *  speed * Time.deltaTime);
        rb.MovePosition(rb.position + transform.forward * speed * Time.deltaTime);
    }



}

/*

on comming traffic will have different types of vehicles

vehicles will have varying speeds,

type = light and heavy

light cars = sports car, pick up truck, hatchback.

heavy = truck and bus

speed
{
    Light Cars 
                1. sports car = 10f
                2. hatchback = 8f
                3. pick up truck = 6.5f

    Heavy 
                1. Bus = 7f
                2. truck = 5.5f - 6f

}



*/
