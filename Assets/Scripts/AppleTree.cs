using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour {
    [Header("Set in Inspector")]
    // Prefab for instantiating apples
    public GameObject   applePrefab;

    //Speed that Appletree moves
    private float speed = 8f;

    //Distance where Appletree turns around
    public float leftAndRightEdge = 10f;

    //Rate of Appletree is being instantiated
    public float secondsBetweenAppleDrops = 1f;

    public float Speed
    {
        get
        {
            return speed;
        }

        set
        {
            speed = value;
        }
    }

    public float Speed1
    {
        get
        {
            return speed;
        }

        set
        {
            speed = value;
        }
    }

    void Start() {
        //Dropping Apples/Second

    }

    private void Update()
    {
        //Basic Movement
        Vector3 pos = transform.position; //b
    
    pos.x += speed * Time.deltaTime; //c

        transform.position = pos; //d
     //Changing Direction
    }
}
