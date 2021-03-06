using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car1 : MonoBehaviour{


  public float power = 3;
     public float maxspeed = 5;
     public float turnpower = 2;
     public float friction = 3;
     public Vector2 curspeed ;
     Rigidbody2D rb2D;
 
     // Use this for initialization
     void Start () {
         rb2D = GetComponent<Rigidbody2D>();
     }
     
 
     void FixedUpdate()
     {
         curspeed = new Vector2(rb2D.velocity.x,    rb2D.velocity.y);
 
         if (curspeed.magnitude > maxspeed)
         {
             curspeed = curspeed.normalized;
             curspeed *= maxspeed;
         }
 
         if (Input.GetKey(KeyCode.W))
         {
             rb2D.AddForce(transform.up * power);
              rb2D.drag = friction;
         }
         if (Input.GetKey(KeyCode.S))
         {
             rb2D.AddForce(-(transform.up) * (power/2));
             rb2D.drag = friction;
         }
          if (Input.GetKey(KeyCode.A))
         {
             transform.Rotate(Vector3.forward * turnpower);
         }
          if (Input.GetKey(KeyCode.D))
         {
             transform.Rotate(Vector3.forward * -turnpower);
         }
 
         noGas();
 
     }
 
     void noGas()
     {
         bool gas;
         if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
         {
             gas = true;
         }
         else
         {
             gas = false;
         }
 
         if (!gas)
         {
             rb2D.drag = friction * 2;
         }
     }
}