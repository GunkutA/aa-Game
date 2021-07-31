using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LittleCircleScript : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D physics;
    public float speed;
    void Start()
    {
        physics=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame

    void Update()
    {
        
    }
    void FixedUpdate()
    {
        physics.MovePosition(physics.position + Vector2.up * speed * Time.deltaTime);
    }
}
