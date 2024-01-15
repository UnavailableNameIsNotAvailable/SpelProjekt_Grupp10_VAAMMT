using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    // Start is called before the first frame update

    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)) {
            anim.Play("Walk Left");
        } else if (Input.GetKey(KeyCode.D))
        {
            anim.Play("Walk Right");
        }
        else if (Input.GetKey(KeyCode.W))
        {
            anim.Play("Walk up");
        }
        else if (Input.GetKey(KeyCode.S))
        {
            anim.Play("Walkt down");
        }
        else
        {
            anim.Play("Idle");
        }

    }
}
