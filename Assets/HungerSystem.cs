using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class HungerSystem : MonoBehaviour
{
    public int HungerPoint;
    // Start is called before the first frame update
    void Start()
    {
        HungerPoint = 100;
    }

    // Update is called once per frame
    async void FixedUpdate()
    {
        HungerPoint -= 1;
        int milliseconds = 2000;
        Thread.Sleep(milliseconds);
    }

    public void AddHunger(int amount)
    {
        HungerPoint += amount;
    }
}
