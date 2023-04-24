using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroBlobController : MonoBehaviour
{
    public float speed = 5.0f;
    public Sprite[] heroBlobSprites;
    private float moveDirection = 0.0f;
    private Rigidbody2D rb;
    private SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>(); // Get the reference to the SpriteRenderer component
        sr.sprite = heroBlobSprites[0]; // Set the initial sprite to the idle sprite
    }

    // Update is called once per frame
    void Update()
    {
        // Check if there is any touch input.
        if (Input.touchCount > 0)
        {
            // Reset moveDirection
            moveDirection = 0.0f;

            Touch touch = Input.GetTouch(0); // Get the first touch (assuming a single touch input).

            // Check if the touch is in the "Began", "Stationary", or "Moved" phase.
            if (touch.phase == TouchPhase.Began || touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Moved)
            {
                // Check if the touch is on the right side of the screen.
                if (touch.position.x > Screen.width / 2)
                {
                    moveDirection = 1.0f; // Move right
                }
                else
                {
                    moveDirection = -1.0f; // Move left
                }
            }

            Move();
        }
        else
        {
            // If there's no touch input, set moveDirection to 0 (idle)
            moveDirection = 0.0f;
        }

        UpdateSprite(); // Call this method to update the sprite based on the movement
    }
        
    void Move()
    {
        rb.velocity = new Vector2(moveDirection * speed, rb.velocity.y);
    }

    void UpdateSprite()
    {
        if (moveDirection > 0)
        {
            sr.sprite = heroBlobSprites[1]; // Moving right sprite
        }
        else if (moveDirection < 0)
        {
            sr.sprite = heroBlobSprites[2]; // Moving left sprite
        }
        else
        {
            sr.sprite = heroBlobSprites[0]; // Idle sprite
        }
    }
}
