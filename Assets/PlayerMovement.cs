using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody playerRigid;
    // Start is called before the first frame update
    void Start()
    {
        playerRigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            playerRigid.AddForce(new Vector3(7, 0, 0));
        }
        if (Input.GetKey(KeyCode.A))
        {
            playerRigid.AddForce(new Vector3(-7, 0, 0));
        }
        if (Input.GetKey(KeyCode.W))
        {
            playerRigid.AddForce(new Vector3(0, 7,0));
        }
        if (Input.GetKey(KeyCode.S))
        {
            playerRigid.AddForce(new Vector3(0, -7, 0));
        }
    }
}
