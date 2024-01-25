using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeatSystem : MonoBehaviour
{
    public float TemperaturePoint;
    // Start is called before the first frame update
    void Start()
    {
        TemperaturePoint = 100;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (true)
        {
            TemperaturePoint -= 3 * Time.deltaTime;
        }
    }
    void Update()
    {
        if (TemperaturePoint < 1)
        {
            SceneManager.LoadSceneAsync(2);
        }
    }
    public void AddHeat(int amount)
    {//Lägger till hunger från en annan skript
        TemperaturePoint += amount;
    }
}
