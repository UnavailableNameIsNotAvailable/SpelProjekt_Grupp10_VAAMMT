using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI_Temperature : MonoBehaviour
{
    [SerializeField]
    HeatSystem temperaturepoint;

    [SerializeField]
    GameObject TemperatureText;

    TextMeshProUGUI TextComponent;
    // Start is called before the first frame update
    void Start()
    {
        TextComponent = TemperatureText.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        string HungerNumber = Mathf.Round(temperaturepoint.TemperaturePoint) + "%";
        TextComponent.text = HungerNumber;

    }
}

