using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private AudioClip Footstep1;
    public float speed = 6f;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        // Get input axes
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        // Calculate movement direction
        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0f);

        // Normalize the movement vector to ensure consistent speed in all directions
        movement.Normalize();

        // Move the player
        transform.Translate(movement * speed * Time.deltaTime);
        
    }
    public void FootstepFunktion()
    {
        AudioSource.PlayClipAtPoint(Footstep1, transform.position);
    }
}

