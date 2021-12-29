using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    public float movement = 0f;
    public float movementSpeed = 5f;

    Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // TODO:
        // for pc
        //movement = Input.GetAxis("Horizontal") * movementSpeed;

        // for phone
        //movement = Input.acceleration.x * movementSpeed;

    }
    private void FixedUpdate()
    {
        Vector2 velocity = rigidbody.velocity;
        velocity.x = movement;
        rigidbody.velocity = velocity;
    }
}
