using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Movement")]
    public float xForce;
    public float yForce;

    private Rigidbody2D rig;

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();

        PushBall();
    }


    void PushBall()
    {
        float randomDirection = Random.Range(0, 2);

        if (randomDirection < 1.0f)
        {
            rig.AddForce(new Vector2(xForce, yForce));
        }
        else
        {

            rig.AddForce(new Vector2(-xForce, yForce));
        }
    }
}
