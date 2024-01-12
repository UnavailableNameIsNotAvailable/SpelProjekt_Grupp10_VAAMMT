using System.Collections;
using System.Collections.Generic;
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
    private void OnCollisionEnter2D(Collision2D collision)
    {//Vid kollision så gömmer sig objektet.
        SpriteRenderer FoodRender = GetComponent<SpriteRenderer>();
        FoodRender.enabled = false;
        BoxCollider2D FoodCollider = GetComponent<BoxCollider2D>();
        FoodCollider.enabled = false;
    }
}
