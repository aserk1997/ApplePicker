using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour {
    private Vector3 pos;

    // Use this for initialization
    void Update() {
        // Get screen position of mouse from input

        Vector3 mousePos2D = Input.mousePosition; //a

        //The Camera's z position sets how far the to push the mouse

        mousePos2D.z = -Camera.main.transform.position.z; //b

        //Convert 2D to 3D

        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);

        Vector3 pos = this.transform.position;

        pos.x = mousePos3D.x;

        this.transform.position = pos;

    }
    private void OnCollisionEnter(Collision coll)
    {
        GameObject collidedWith = coll.gameObject;
        if (collidedWith.tag == "Apple")
        {
            Destroy(collidedWith);
        }
    }
}