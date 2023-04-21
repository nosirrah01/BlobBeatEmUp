using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroBlobController : MonoBehaviour
{
    public float speed = 5.0f;
    private bool moveRight = false;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Check if there is any touch input.
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0); // Get the first touch (assuming a single touch input).

            // Check if the touch is on the right side of the screen.
            if (touch.position.x > Screen.width / 2)
            {
                // Set moveRight to true only if the touch is in the "Began" or "Stationary" phase.
                // This means the finger is currently pressing the screen.
                moveRight = touch.phase == TouchPhase.Began || touch.phase == TouchPhase.Stationary;
            }
            else
            {
                // If the touch is on the left side of the screen, set moveRight to false.
                moveRight = false;
            }
        }
        else
        {
            // If there's no touch input, set moveRight to false.
            moveRight = false;
        }

        // If moveRight is true, move the HeroBlob to the right.
        if (moveRight)
        {
            MoveRight();
        }
        else
        {
            StopMoving();
        }
    }

    void MoveRight()
    {
        rb.velocity = new Vector2(speed, rb.velocity.y);
    }

    void StopMoving()
    {
        rb.velocity = new Vector2(0, rb.velocity.y);
    }
}
