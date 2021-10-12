using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseController : MonoBehaviour
{
    private Vector2 mousePosition;
    private Vector2 initalPosition;



    [SerializeField]
    private Transform circlePosition;
    private float deltaX, deltaY;
    public float yBoundary;
    public float xBoundary;


    public static bool locked;

    private void Start()
    {

    }


    private void OnMouseDown()
    {
        locked = false;
        if (!locked)
        {
            deltaX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x;
            deltaY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y - transform.position.y;
        }
    }

    private void OnMouseDrag()
    {

        if (!locked)
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector2(mousePosition.x - deltaX, mousePosition.y - deltaY);



            if (transform.position.x > xBoundary)
            {
                transform.position = new Vector2(xBoundary, mousePosition.y - deltaY);
                if (transform.position.y > yBoundary)
                {
                    transform.position = new Vector2(xBoundary, yBoundary);
                }
                else if (transform.position.y < -yBoundary)
                {
                    transform.position = new Vector2(xBoundary, -yBoundary);
                }
            }
            else if (transform.position.x < -xBoundary)
            {
                transform.position = new Vector2(-xBoundary, mousePosition.y - deltaY);
                if (transform.position.y > yBoundary)
                {
                    transform.position = new Vector2(-xBoundary, yBoundary);
                }
                else if (transform.position.y < -yBoundary)
                {
                    transform.position = new Vector2(-xBoundary, -yBoundary);
                }
            }

            if (transform.position.y > yBoundary)
            {
                transform.position = new Vector2(mousePosition.x - deltaX, yBoundary);
            }
            else if (transform.position.y < -yBoundary)
            {
                transform.position = new Vector2(mousePosition.x - deltaX, -yBoundary);
            }


        }


    }

    private void OnMouseUp()
    {
        transform.position = new Vector2(circlePosition.position.x, circlePosition.position.y);
        locked = true;
    }
}
