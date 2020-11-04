using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public float movementSpeed = 10f;

    public void FlipFireball()
    {
        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime, 0f, 0f);

        //Flip fireball to the left
        Vector3 fireScale = transform.localScale;
        if (Input.GetAxis("Horizontal") < 0)
        {
            fireScale.x = -4f;
        }

        //Flip fireball to the right
        if (Input.GetAxis("Horizontal") > 0)
        {
            fireScale.x = 4f;
        }
        transform.localScale = fireScale;
    }

    void Update()
    {
        FlipFireball();
        transform.position += transform.right * Time.deltaTime * movementSpeed; //make fireball move
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        //Check if object has enemy script attached
        if (collision.gameObject.TryGetComponent<KnightMovement>(out KnightMovement knight))
        {
            //Destroy knight
            Destroy(collision.gameObject);
        }
    }
}
