using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LittleCircleScript : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D physics;
    public float speed;
    bool isMovement = false;
    GameObject cycle;
    void Start()
    {
        physics=GetComponent<Rigidbody2D>();
        cycle = GameObject.FindGameObjectWithTag("Cycle");
           
    }

    // Update is called once per frame

    void Update()
    {
        
    }
    void FixedUpdate()
    {
        if(!isMovement)
        {
            physics.MovePosition(physics.position + Vector2.up * speed * Time.deltaTime);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.tag=="RotatingCircle")
        {
            isMovement = true;
            transform.SetParent(collider.transform);
        }
        if(collider.tag=="LittleCircle")
        {
            cycle.GetComponent<Cycle>().GameOver();
        }
    }
}
