using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class FoodInteract : MonoBehaviour
{
    HungerSystem hunger;

    // Start is called before the first frame update
    void Start()
    {
        hunger = FindObjectOfType<HungerSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private async void OnCollisionEnter2D(Collision2D collision)
    {//Vid kollision så gömmer sig objektet.
        SpriteRenderer FoodRender = GetComponent<SpriteRenderer>();
        FoodRender.enabled = false;
        BoxCollider2D FoodCollider = GetComponent<BoxCollider2D>();
        FoodCollider.enabled = false;
        hunger.AddHunger(750);
        //Efter en slumpmässig antal sekunder så respawnar maten.
        int waitingTime = Random.Range(40000,90000);
        await Task.Delay(waitingTime);
        FoodRender.enabled = true;
        FoodCollider.enabled = true;
    }
}
