using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Tooltip("Enemy soldiers.")]
    public GameObject soldiers; 

    [Tooltip("Spawn Point that will spawn soldiers from left.")]
    public GameObject spawnLeft;

    [Tooltip("Spawn Point that will spawn soldiers from right.")]
    public GameObject spawnRight;

    [Tooltip("How fast the enemies spawn.")]
    public float spawnRate = 0.5f;

    [Tooltip("Time between each enemy spawn.")]
    public float nextSpawn = 0f;

    [Tooltip("Random X position for the edges of the screen so the soldiers do not spawn off screen.")]
    private float randomX;

    [Tooltip("Where the enemies will spawn from.")]
    Vector2 spawnPoint;

    private void Start()
    {
        
    }

    private void Update()
    {
        //If the time taken between each spawn is greater than 0 
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randomX = Random.Range(-7f, 7f); //X positions of left and right of the game scene
            spawnPoint = new Vector2(randomX, transform.position.y);
            Instantiate(soldiers, spawnPoint, Quaternion.identity); //Quaternion.identity means soldiers at the spawn point have no rotation
        }
       
    }
}
