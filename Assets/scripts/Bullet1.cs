using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{ 
    public float mySpeed;
    public float lifeTime;
    public float gap;
    public LayerMask isSolid;

    public GameObject destroyEffect;

    private void Start()
    {
        Invoke("DestroyProjectile", lifeTime);
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Translate(Vector2.up * mySpeed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player2")
        {
            print("projectile was fired");
            
            
            Destroy(gameObject);
            DestroyProjectile();
        }
    }

    void DestroyProjectile()
    {
        //Sparkle effect 
        Instantiate(destroyEffect, transform.position, Quaternion.identity);

        //Destroy gameobject
        Destroy(gameObject);
    }
}