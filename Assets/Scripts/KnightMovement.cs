using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightMovement : MonoBehaviour
{
    public float moveSpeed;
    public Transform knight;
    public float range = 20f;
    public float distance;

    public void Update()
    {
        //EnemyMove();
    }

    public void EnemyMove()
    {
        /*If distance between enemy and dragon is less than 20, soldier in shooting range
        if (Vector2.Distance(knight.position, transform.position) < range)
        {
            transform.position = knight.transform.position;
            transform.rotation = knight.transform.rotation;
        }
        print("Soldier is in range. SHOOT!");
        */
    }
}
