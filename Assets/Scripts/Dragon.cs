using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : MonoBehaviour
{
    public Transform dragon;

    [Tooltip("Where the fireball will shoot from.")]
    public GameObject firePoint;

    [Tooltip("The fireball prefab.")]
    public GameObject fireball;

    [Tooltip("How fast the fireball shoots.")]
    public float fireRate = 2f;

    public void Movement()
    {
        //Test move dragon
        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime, 0f, 0f);

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
    }

    
    /*private void OnTriggerEnter2D(Collider2D collision)
    {
       //Check if object has enemy script attached
       if (collision.gameObject.TryGetComponent<KnightMovement>(out KnightMovement knight))
       {
            //Destroy knight
            Destroy(collision.gameObject);
       }
    }*/

    //direction from a to b
    // x = b-a

    
    

    public void ShootFireball() //Function to set the space bar as the one button
    {
        //If space bar pressed then flip x position to left or right.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate<GameObject>(fireball, firePoint.transform.position, Quaternion.identity);

            //if fireball collides with soldier box collider then destroy
           

            //Rotate fire point to face enemy with the player
            //firePoint.transform.rotation.x

            //Clone the fireball prefab and spawn from dragon mouth, then rotate with dragon.
            //Instantiate(fireball, firePoint, dragon movement dragonScale);
        }
    }
    // Update is called once per frame
    void Update()
    {
        Movement();
        ShootFireball();
    }
}
