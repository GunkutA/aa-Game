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
    public Text text_CirclesLeftToNextLevel;
    public int circlesLeft;
    public int circlesToNextLevel;
    void Start()
    {
        PlayerPrefs.SetInt("save", SceneManager.GetActiveScene().buildIndex);
        RotatingCircle = GameObject.FindGameObjectWithTag("RotatingCircle");
        ThrowingCircle = GameObject.FindGameObjectWithTag("ThrowerCircle");
        //   rotatingCircleLevel.text = SceneManager.GetActiveScene().name;
        text_CirclesLeftToNextLevel.color = new Color(2, 2, 1, 1);
         textRotatingCircle.text = circlesLeft+"";
        
    }

    public void TextUpdateCircles()
    {
 
           textRotatingCircle.text = circlesLeft+"" ;
            text_CirclesLeftToNextLevel.text=circlesToNextLevel.ToString();


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
        anim.SetTrigger("GameOver");
        yield return new WaitForSeconds(1);
        
    }
}
