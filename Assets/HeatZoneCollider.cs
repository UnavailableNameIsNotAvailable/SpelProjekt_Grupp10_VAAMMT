using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeatZoneCollider : MonoBehaviour
{
    HeatSystem Heat;
    bool ifInsideZone = false;
    // Start is called before the first frame update
    void Start()
    {
        Heat = FindObjectOfType<HeatSystem>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private async void OnTriggerStay2D(Collider2D collision)
    {
            Heat.AddHeat(1);
    }
}
