using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewLevelManager : MonoBehaviour
{
    // private int currentLevel;
    public GameObject[] levels;
    public PlayerScript player;
    public Animator canvas;
    public int level;
    public Text levelText;

    public Animator animm;
    public GameObject LevelSon;
    public GameObject MenuCanvas;
    public GameObject Player;


    //score countera başla
    public Text scoreText;

    public int score = 15;

    void Awake()
    {
        // currentLevel = PlayerPrefs.GetInt("level", 0);
        level = 1;
        // currentLevel = 0;
        // PlayerPrefs.SetInt("level", 0);
        /*level = PlayerPrefs.GetInt("level", 0);*/  //önceki halinde parantez içinde 0 yoktu boştu orası, aklında bulunsun.
        levelText.text = "Level " + (level + 1);
        level = level % 6;
        transform.GetChild(level).gameObject.SetActive(true);
       

        // score = PlayerPrefs.GetInt("score"); bunu kapadım çünkü scorun başta 15 olmasını istiyordum.
        if (LevelSon.activeInHierarchy == true)
        {
            score = PlayerPrefs.GetInt("currentscore", score);
            scoreText.text = "Total Score: " + score + "/15";
            Debug.Log("son level");   // bu kısımlar çalışıyor.
            MenuCanvas.SetActive(false);
            Player.SetActive(false);

        }
        else
        {
            score = PlayerPrefs.GetInt("currentscore", score);
            scoreText.text = "Score: " + score + "/15";
            Debug.Log("new level manager start");

        }


    }


    void Update()
    {
        levelText.text = "Level " + (level + 1); //bu aslında startta çalışıyordu diğer oyunlarda, ama updatede benim oyunum için daha uygun oldu şimdilik.


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

    public void failRestart()
    {
        Application.LoadLevel(0);

    }


    public void win()
    {
        animm.SetBool("isWalking", false);
        player.enabled = false;
        canvas.SetTrigger("win");

        // currentLevel = PlayerPrefs.GetInt("level", 0);
        // currentLevel += 1;
        // if (currentLevel >= levels.Length)
        // {
        //     currentLevel = 0;
        // }
        // PlayerPrefs.SetInt("level", currentLevel);
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
            PlayerPrefs.SetInt("currentscore", score);
        }
        Application.LoadLevel(1);
    }
    public void final()
    {

        SceneManager.LoadScene(1);
    }
    public void addScore()
    {
        score -= 1;
        scoreText.text = "Score: " + score + "/15";
        PlayerPrefs.SetInt("score", score);


        // scoreText.text = "Score:  "  + score + "/15";
        // PlayerPrefs.SetInt("score", score);

    }
}
