using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI_Hunger : MonoBehaviour
{
    [SerializeField]
    HungerSystem hungerpoint;

    [SerializeField]
    GameObject HungerText;

    TextMeshProUGUI TextComponent;
    // Start is called before the first frame update
    void Start()
    {
        TextComponent = HungerText.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        string HungerNumber = Mathf.Round(hungerpoint.HungerPoint) + "HP";
        TextComponent.text = HungerNumber;
        
    }
}
