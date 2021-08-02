using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cycle : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject RotatingCircle;
    GameObject ThrowingCircle;
    public Animator anim;
    void Start()
    {
        RotatingCircle = GameObject.FindGameObjectWithTag("RotatingCircle");
        ThrowingCircle = GameObject.FindGameObjectWithTag("ThrowerCircle");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {
        StartCoroutine(finished()); 
    }
    IEnumerator finished()
    {
        RotatingCircle.GetComponent<Rotation>().enabled = false;
        ThrowingCircle.GetComponent<ThrowerCircleScript>().enabled = false;
        yield return new WaitForSeconds(1);
        anim.SetTrigger("GameOver");
    }
}
