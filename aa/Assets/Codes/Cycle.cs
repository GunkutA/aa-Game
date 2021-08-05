using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cycle : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject RotatingCircle;
    GameObject ThrowingCircle;
    public Animator anim;
    public Text rotatingCircleLevel;
    public Text textRotatingCircle;
    public Text textCircle1;
    public Text textCircle2;
    public int circlesLeft;
    void Start()
    {
        PlayerPrefs.SetInt("save", int.Parse(SceneManager.GetActiveScene().name));
        RotatingCircle = GameObject.FindGameObjectWithTag("RotatingCircle");
        ThrowingCircle = GameObject.FindGameObjectWithTag("ThrowerCircle");
        rotatingCircleLevel.text = SceneManager.GetActiveScene().name;
        if(circlesLeft<2)
        {
            textRotatingCircle.text = circlesLeft+"";
            textCircle1.text = "";
            textCircle2.text = "";
        }
        else if(circlesLeft<3)
        {
            textRotatingCircle.text = circlesLeft + "";
            textCircle1.text = (circlesLeft-1)+"";
            textCircle2.text = "";
        }
        else
        {
            textRotatingCircle.text = "";
            textRotatingCircle.text = "";
            textCircle1.text =(circlesLeft-1)+ "";
            textCircle2.text = (circlesLeft - 2) + "";

        }
    }

    public void TextUpdateCircles()
    {
        if (circlesLeft < 2)
        {
            textRotatingCircle.text = circlesLeft + "";
            textCircle1.text = "";
            textCircle2.text = "";
        }
        else if (circlesLeft < 3)
        {
            textRotatingCircle.text = circlesLeft + "";
            textCircle1.text = (circlesLeft - 1) + "";
            textCircle2.text = "";
        }
        else
        {
            textRotatingCircle.text = "";
            textRotatingCircle.text = "";
            textCircle1.text = (circlesLeft - 1) + "";
            textCircle2.text = (circlesLeft - 2) + "";

        }
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
