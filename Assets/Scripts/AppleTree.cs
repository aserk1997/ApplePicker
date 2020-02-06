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

    void Start()
    {
        // Dropping apples every second
        Invoke("DropApple", 2f);
    }

    void DropApple()
    {
        GameObject apple = Instantiate<GameObject>(applePrefab);
        apple.transform.position = transform.position;
        Invoke("DropApple", secondsBetweenAppleDrops);
    }

        private void Update()
    {
        //Basic Movement
        Vector3 pos = transform.position; //b

        pos.x += speed * Time.deltaTime; //c

        transform.position = pos; //d
                                  //Changing Direction

        float chanceToChangeDirections = 0;
        if (pos.x < -leftAndRightEdge)
        {
            //a
            speed = Mathf.Abs(speed); //Move right
            //b
        }
        else if (pos.x > leftAndRightEdge)
        {
            //c
            speed = -Mathf.Abs(speed); //Move left
                                       //c
        }else if (Random.value < chanceToChangeDirections) { //a
            speed *= -1; //change direction
            //b
        }
    }
 }
