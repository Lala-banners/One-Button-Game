using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public float movementSpeed;

    void Update()
    {
        transform.position += transform.right * Time.deltaTime * movementSpeed;
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
