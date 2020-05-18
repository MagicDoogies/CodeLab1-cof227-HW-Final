using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    

    public float MoveSpeed; // How fast the character moves.
    public bool Active;

    public Sprite up, down, left, right;
    private SpriteRenderer rend;
   

    public Rigidbody2D rb;
    Vector2 movement;

    // Start is called before the first frame update
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();//referencing the sprite renderer of the game object. 

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && !Active)
        {
            
        }

        //player input.
        movement.x =Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        //Sprite of the character changes based on which direction the player is going.
        if (movement.x >0)
        {
            this.rend.sprite = right;
        }
        else
        if(movement.x <0)
        {
            this.rend.sprite = left;
        }

        if (movement.y > 0)
        {
            this.rend.sprite = up;
        }
        else
        if (movement.y < 0)
        {
            this.rend.sprite = down;
        }
    }

    private void FixedUpdate()
    {
        //The actual movement
        rb.MovePosition(rb.position + movement * MoveSpeed * Time.fixedDeltaTime);
    }
}
