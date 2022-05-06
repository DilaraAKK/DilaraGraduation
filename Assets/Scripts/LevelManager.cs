using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public PlayerScript player;
    public int level;
    public Animator canvas;
    public Text levelText;
    public Animator animm;

    void Awake()
    {
        //PlayerPrefs.SetInt("level", 0);
        //PlayerPrefs.SetInt("tutorial", 1);


        level = PlayerPrefs.GetInt("level");
        levelText.text = "Level " + (level + 1);
        level = level % 5;
        transform.GetChild(level).gameObject.SetActive(true);
        // player.partsObject = transform.GetChild(level).GetChild(0).gameObject;

    }

    void Update()
    {

    }

    public void play()
    {

        player.enabled = true;

        canvas.SetTrigger("start");

    }

    public void fail()
    {
        canvas.SetTrigger("lose");
    }

    // public void failRestart()
    // {
    //     Application.LoadLevel(0);
    // }

    public void win()
    {
         animm.SetBool("isWalking", false);
        player.enabled = false;
        canvas.SetTrigger("win");
    }
    public void winRestart()
    {
        
        if (PlayerPrefs.GetInt("tutorial") == 0)
        {
            PlayerPrefs.SetInt("tutorial", 1);
        }
        else
        {
            PlayerPrefs.SetInt("level", PlayerPrefs.GetInt("level") + 1);
        }
        //     Application.LoadLevel(0);
        // 
        

    }
}