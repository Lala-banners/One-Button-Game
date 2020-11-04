using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAndShoot : MonoBehaviour
{
    public GameObject crosshairs;
    private Vector3 knightTarget; //target of shooting
    public GameObject firePoint;

  


    // Start is called before the first frame update
    void Start()
    {
        //Hide cursor
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        

        //Make crosshairs follow mouse
        knightTarget = transform.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));
        crosshairs.transform.position = new Vector2(knightTarget.x, knightTarget.y); //Make crosshairs position the same as the knights

        //Calculate difference between the firepoint and the target
        Vector3 difference = knightTarget - firePoint.transform.position;

        
    }
}
