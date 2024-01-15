using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class FoodInteract : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private async void OnCollisionEnter2D(Collision2D collision)
    {//Vid kollision s� g�mmer sig objektet.
        SpriteRenderer FoodRender = GetComponent<SpriteRenderer>();
        FoodRender.enabled = false;
        BoxCollider2D FoodCollider = GetComponent<BoxCollider2D>();
        FoodCollider.enabled = false;
        //Efter en slumpm�ssig antal sekunder s� respawnar maten.
        int waitingTime = Random.Range(40000,100000);
        await Task.Delay(waitingTime);
        FoodRender.enabled = true;
        FoodCollider.enabled = true;
    }
}
