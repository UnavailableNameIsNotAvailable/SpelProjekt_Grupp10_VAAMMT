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
        //g�r s� att animationen s�tts ig�ng
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 point = currentpoint.position - transform.position;
        //g�r s� att enemyn kan g� �t ett h�ll
        if (currentpoint == PointB.transform)
        {
            rb.velocity = new Vector2(speed, 0);
        }
        else
        {
            rb.velocity = new Vector2(-speed, 0);
            //g�r s� att den g�r �t andra h�llet
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
        //g�r s� enemyn kan g� fram och tillbaka
    }



    private void flip()
    {
        Vector3 localScale = transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
        //g�r s� att enemyn kan v�nda sig om n�r den g�r fram och tillbaka

    }


}
