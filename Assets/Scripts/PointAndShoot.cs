using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAndShoot : MonoBehaviour
{
    public GameObject crosshairs;
    private Vector3 target; //target of shooting

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
        target = transform.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));
        crosshairs.transform.position = new Vector2(target.x, target.y); //Make crosshairs position the same as the mouse
    }

}
