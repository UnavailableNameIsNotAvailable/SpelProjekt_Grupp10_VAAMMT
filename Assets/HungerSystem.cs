using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HungerSystem : MonoBehaviour
{
    int HungerPoint;
    // Start is called before the first frame update
    void Start()
    {
        HungerPoint = 100;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        HungerPoint -= 1;
        Console.Write(HungerPoint);
    }
}
