using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemypatroll : MonoBehaviour
{
    public GameObject PointA;
    public GameObject PointB;
    public float speed;
    private Rigidbody2D rb;
    private Animator anim;
    private Transform currentpoint;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        currentpoint = PointB.transform;
        anim.SetBool("IsRunning", true);
        //gör så att animationen sätts igång
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 point = currentpoint.position - transform.position;
        //gör så att enemyn kan gå åt ett håll
        if (currentpoint == PointB.transform)
        {
            rb.velocity = new Vector2(speed, 0);
        }
        else
        {
            rb.velocity = new Vector2(-speed, 0);
            //gör så att den går åt andra hållet
        }

        if (Vector2.Distance(transform.position, currentpoint.position) < 0.5f && currentpoint == PointA.transform)
        {
            flip();
            currentpoint = PointB.transform;
        }
        if (Vector2.Distance(transform.position, currentpoint.position) < 0.5f && currentpoint == PointB.transform)
        {
            flip();
            currentpoint = PointA.transform;
        }
        //gör så enemyn kan gå fram och tillbaka
    }



    private void flip()
    {
        Vector3 localScale = transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
        //gör så att enemyn kan vända sig om när den går fram och tillbaka

    }


}
