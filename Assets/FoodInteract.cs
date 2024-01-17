using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class FoodInteract : MonoBehaviour
{
    HungerSystem hunger;
    AudioSource foodPickUp;
    // Start is called before the first frame update
    void Start()
    {
        hunger = FindObjectOfType<HungerSystem>();
        foodPickUp = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private async void OnCollisionEnter2D(Collision2D collision)
    {
        foodPickUp.Play();


        //Vid kollision s� g�mmer sig objektet.
        SpriteRenderer FoodRender = GetComponent<SpriteRenderer>();
        FoodRender.enabled = false;
        BoxCollider2D FoodCollider = GetComponent<BoxCollider2D>();
        FoodCollider.enabled = false;
        hunger.AddHunger(8);
        //Efter en slumpm�ssig antal sekunder mellan en och tv� minuter s� respawnar maten.
        int waitingTime = Random.Range(60000,120000);
        await Task.Delay(waitingTime);
        FoodRender.enabled = true;
        FoodCollider.enabled = true;



    }
}
