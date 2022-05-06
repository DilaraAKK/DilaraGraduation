using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TotalScore : MonoBehaviour
{
   public Text totalText;
    public int score = 15;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "yenii")
        {
            Debug.Log("total score yazdır");
            totalText.text = "Total Score: " + PlayerPrefs.GetInt("currentscore", 15) + "/15";
    
        
        } 
    }
}
