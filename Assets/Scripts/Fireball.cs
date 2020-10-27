using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{

    [Tooltip("Where the fireball will shoot from.")]
    public GameObject firePoint;

    [Tooltip("The fireball prefab.")]
    public GameObject fireball;

    [Tooltip("Where the fireball will shoot from.")]
    Vector2 fireballSpawnPoint;

    /*[Tooltip("Shoot fireball to the left.")]
    public GameObject fireLeft;
    [Tooltip("Shoot fireball to the right.")]
    public GameObject fireRight;
    */

    [Tooltip("How fast the fireball shoots.")]
    public float fireRate = 2f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3f);
    }

    public void ShootFireball() //Function to set the space bar as the one button
    {
        //If space bar pressed then flip x position to left or right.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Rotate fire point to face enemy with the player
            //firePoint.transform.rotation.x

            //Clone the fireball prefab and spawn from dragon mouth, then rotate with dragon.
            //Instantiate(fireball, firePoint, dragon movement dragonScale);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Check if object has Spawner script attached
        if (collision.gameObject.GetComponent<Spawner>() != null)
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
