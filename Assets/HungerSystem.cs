using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HungerSystem : MonoBehaviour
{//Skript av Vincent 
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
    {//Om Hungerpoint < 1 så ändras karaktärens status till död.
        if (HungerPoint < 1)
        {
            StatusAlive = false;
            SceneManager.LoadSceneAsync(2);
        }
    }


    public void AddHunger(int amount)
    {//Lägger till hunger från en annan skript
        HungerPoint += amount;
    }
}
