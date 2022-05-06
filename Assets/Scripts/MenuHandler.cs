using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour
{
    public bool Turkiish = false;
    public bool Engliish = false;
    public bool lira = false;
    public GameObject languageCanvas;
    public GameObject startCanvas;

    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(this);
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      lira = true;
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Demo Blend");
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("quit the game");
    }
    public void Turkish()
    {
        Turkiish = true;
        Debug.Log("Turkish choosen");
        languageCanvas.SetActive(false);
        startCanvas.SetActive(true);
        
    }
    public void English()
    {
        Engliish = true;
        Debug.Log("English choosen");
        languageCanvas.SetActive(false);
        startCanvas.SetActive(true);
    }
}


