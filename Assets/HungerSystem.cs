using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HungerSystem : MonoBehaviour
{//Skript av Vincent 
    public float HungerPoint;
    // Start is called before the first frame update
    void Start()
    {//startar med 100
        HungerPoint = 100;
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
    {//Om Hungerpoint < 1 s� hamnar man i death screen scenet.
        if (HungerPoint < 1)
        {
            SceneManager.LoadSceneAsync(2);
        }
    }


    public void AddHunger(int amount)
    {//L�gger till hunger fr�n en annan skript
        HungerPoint += amount;
    }
}
