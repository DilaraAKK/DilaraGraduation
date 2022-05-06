using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; //ayni tipte nesne olustur
    
    // public Text totalText;
    // public GameObject newLevelManager;
    // private static int scoree;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);

    }
    void Start()
    {
        PlayerPrefs.SetInt("currentscore", 15);
        // newLevelManager = GameObject.Find("Level Manager");
        // scoree=NewLevelManager.score;
        // totalText = GameObject.Find("TotalText").GetComponentInChildren<Text>();

    }
   

    // void Update()
    // {
    //     if (SceneManager.GetActiveScene().name == "yenii")
    //     {
    //         totalText = GameObject.FindGameObjectWithTag("TotalText").GetComponent<Text>();
    //         totalText.text = "Total Score: " + scoree + "/15";
    //         Debug.Log("total score yazdır");



    //     }
}
