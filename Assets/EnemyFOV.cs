using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyFOV : MonoBehaviour
{
    public float fovAngle = 60f;
    public Transform fovPoint;
    public float range = 4;
    public Transform target; 

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 dir = target.position - transform.position;
        float angle = Vector3.Angle(dir, fovPoint.right);
        RaycastHit2D r = Physics2D.Raycast(fovPoint.position, dir, range);
        //vilket håll enemyn kollar åt och hur långt den kan se

        if (angle < fovAngle / 2)
        {
            if (r.collider.CompareTag("Player"))
            {
                print("Seen");
                Debug.DrawRay(fovPoint.position, dir, Color.red);
            }  //När spelaren blir hittad
            else
            {
                print("we dont seen");
            }
        }
    } //Marcus NW
}
