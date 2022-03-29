using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car2 : MonoBehaviour{


  public float power = 3;
     public float maxspeed = 5;
     public float turnpower = 2;
     public float friction = 3;
     public Vector2 curspeed ;
     Rigidbody2D rigdbody2D;
 
     // Use this for initialization
     void Start () {
         rigdbody2D = GetComponent<Rigidbody2D>();
     }
     
 
     void FixedUpdate()
     {
         curspeed = new Vector2(rigdbody2D.velocity.x,    rigdbody2D.velocity.y);
 
         if (curspeed.magnitude > maxspeed)
         {
             curspeed = curspeed.normalized;
             curspeed *= maxspeed;
         }
 
         if (Input.GetKey(KeyCode.UpArrow))
         {
             rigdbody2D.AddForce(transform.up * power);
              rigdbody2D.drag = friction;
         }
         if (Input.GetKey(KeyCode.DownArrow))
         {
             rigdbody2D.AddForce(-(transform.up) * (power/2));
             rigdbody2D.drag = friction;
         }
          if (Input.GetKey(KeyCode.LeftArrow))
         {
             transform.Rotate(Vector3.forward * turnpower);
         }
          if (Input.GetKey(KeyCode.RightArrow))
         {
             transform.Rotate(Vector3.forward * -turnpower);
         }
 
         noGas();
 
     }
 
     void noGas()
     {
         bool gas;
         if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
         {
             gas = true;
         }
         else
         {
             gas = false;
         }
 
         if (!gas)
         {
             rigdbody2D.drag = friction * 2;
         }
     }
}