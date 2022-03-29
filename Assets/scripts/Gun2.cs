using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun2 : MonoBehaviour
{
    public GameObject projectile;
    public Transform shotpoint;
    public Transform weapon;

    private float timeBtwShots;
    public float startTimeBtwShots;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.K) && timeBtwShots <= 0)
        {
            Instantiate(projectile, shotpoint.position, weapon.rotation);
            timeBtwShots = startTimeBtwShots;
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }
    }


}