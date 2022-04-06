using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Resources;
using UnityEngine;

public class PlayerHealth2 : MonoBehaviour
{
    public int health;
    public int numberOfHearts;
    public GameObject[] heartsOfGameObjects;
    public Sprite fullHeart;
    public Sprite emptyHeart;


    private List<SpriteRenderer> ListHeartsSRen;
    private List<Sprite> ListSpriteHearts;

    private int HeartLastIndex;

    void Start()
    {

    }

    void Update()
    {

        PlayerDeath();

    }

    public void DamageToPlayer()
    {
        print("Got hit Player");
        health--;
    }
    void PlayerDeath()
    {
        if(health <= 0)
        {
            print("Killed");
            //Future: Return to players base
            Destroy(gameObject);
        }
    }

}