using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBear : MonoBehaviour
{

    public Rigidbody2D body;

    public float walkingSpeed;
    public float jumpSpeed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        { // x-axis movement
            body.velocity += jumpSpeed * Vector2.up;
        }

        { // x-axis movement
            var v = body.velocity;
            var speed = 0f;
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.localScale = new Vector2(-0.5f, 0.5f);
                speed += -walkingSpeed;
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.localScale = new Vector2(0.5f, 0.5f);
                speed += walkingSpeed;
            }
            v.x = speed;
            body.velocity = v;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var otherObject = collision.collider.gameObject;
        if (otherObject.tag == "Good")
        {
            GameObject.Destroy(otherObject);
        }
    }
}
