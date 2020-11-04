using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public float movementSpeed = 10f;
    private SpriteRenderer spriteRenderer;
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
       
        transform.position += transform.right * Time.deltaTime * movementSpeed; //make fireball move
        // If no longer visible
        if (!spriteRenderer.isVisible)
        {
            // Destroy Bullet
            Destroy(gameObject);
        }

    }

    // OnTriggerEnter2D is called when the Collider2D other enters the trigger (2D physics only)
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Check if object has enemy script attached
        if (collision.gameObject.TryGetComponent<KnightMovement>(out KnightMovement knight))
        {
            WinLose.knightsKilled += 1; //When 1 knight dies, add to text
            //Destroy knight
            Destroy(collision.gameObject);
            // Destroy the Bullet
            Destroy(gameObject);
        }
    }
}
