using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroBlobController : MonoBehaviour
{
    public float speed = 5.0f;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Check for touch input on mobile devices
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Moved)
            {
                if (touch.position.x > Screen.width / 2)
                {
                    MoveRight();
                }
                else
                {
                    Debug.Log("Touch detected on the left side of the screen.");
                }
            }
        }
        // Check for mouse input in the Unity Editor
        else if (Input.GetMouseButton(0))
        {
            Vector3 mousePosition = Input.mousePosition;
            if (mousePosition.x > Screen.width / 2)
            {
                MoveRight();
            }
            else
            {
                Debug.Log("Mouse click detected on the left side of the screen.");
            }
        }
        else
        {
            Debug.Log("No touch or mouse input detected.");
        }
    }

    void MoveRight()
    {
        rb.velocity = new Vector2(speed, rb.velocity.y);
    }
}
