using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class HungerSystem : MonoBehaviour
{
    public bool StatusAlive;
    public float HungerPoint;
    // Start is called before the first frame update
    void Start()
    {//startar med 100
        HungerPoint = 100;
        StatusAlive = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {//Minskar med 1 varje hunger tick
        if (true)
        {
        HungerPoint -= 1 * Time.deltaTime;
        }
    }
    void Update()
    {
        if (HungerPoint < 1)
        {
            StatusAlive = false;
        }
    }


    public void AddHunger(int amount)
    {//Lägger till hunger från en annan skript
        HungerPoint += amount;
    }
}
