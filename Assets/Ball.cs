using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 30;
    void Start()
    {
        //initial velocity
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }

   
}
