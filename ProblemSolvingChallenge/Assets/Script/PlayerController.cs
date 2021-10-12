using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    public float Speed;

    private Rigidbody2D rig;
    public float yBoundary = 6.5f;
    public float xBoundary = 2.5f;

    public KeyCode upButton = KeyCode.W;
    public KeyCode leftButton = KeyCode.A;
    public KeyCode downButton = KeyCode.S;
    public KeyCode rightButton = KeyCode.D;

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();

    }

    private void Update()
    {
        Vector2 velocity = rig.velocity;

        if (Input.GetKey(upButton))
        {
            velocity.y = Speed;
        }
        else if (Input.GetKey(downButton))
        {
            velocity.y = -Speed;
        }
        else
        {
            velocity.y = 0.0f;
        }

        if (Input.GetKey(rightButton))
        {
            velocity.x = Speed;
        }
        else if (Input.GetKey(leftButton))
        {
            velocity.x = -Speed;
        }
        else
        {
            velocity.x = 0.0f;
        }

        rig.velocity = velocity;
    }
}
