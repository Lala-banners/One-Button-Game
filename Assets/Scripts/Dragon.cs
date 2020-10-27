using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : MonoBehaviour
{
    public Transform firePoint;
    public float fireballSpeed = 40f;
    public float moveSpeed = 15f;
    public Vector2 flip;
    public BoxCollider2D attackRange;
    public BoxCollider2D enemyCollider;
    public ColliderDistance2D hasCollided; //Bool to check if attack range and enemy collider have collided

    public void Movement()
    {
        //Test move dragon
        transform.Translate(Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f);

        //Flip Dragon to the left
        Vector3 dragonScale = transform.localScale;
        if (Input.GetAxis("Horizontal") < 0)
        {
            dragonScale.x = -3;
        }

        //Flip Dragon to the right
        if (Input.GetAxis("Horizontal") > 0)
        {
            dragonScale.x = 3;
        }
        transform.localScale = dragonScale;

        //If attack range collides with the enemy collider, then rotate x position to face the soldier FIX
        /*if (attackRange.Distance(enemyCollider, hasCollided))
        {

        }
        */
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }
}
