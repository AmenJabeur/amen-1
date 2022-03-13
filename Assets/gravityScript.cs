using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravityScript : MonoBehaviour
{
    float gravity = 0f;
    //Update is called once per frame
    public void Update()
    {
        gravity = Input.GetAxis("Vertical");

    }
    public void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().gravityScale = gravity;
    }
    Vector2 speed;
    //Update is called once per frame
    public void Start()
    {
        Vector2 speed = new Vector2(1, 1);
        GetComponent<Rigidbody2D>().velocity = speed;
    }
}