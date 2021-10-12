using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Movement")]
    public float moveAccel;


    private Rigidbody2D rig;
    private Vector2 velocity;

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();

        velocity = new Vector2(moveAccel, 0);

    }

    private void FixedUpdate()
    {


        rig.MovePosition(rig.position + velocity * Time.fixedDeltaTime);

    }
}
