using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowerCircleScript : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject littleCircle;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            CreateLittleCircle();
        }
    }
    void CreateLittleCircle()
    {
        Instantiate(littleCircle, transform.position, transform.rotation);
    }
}


