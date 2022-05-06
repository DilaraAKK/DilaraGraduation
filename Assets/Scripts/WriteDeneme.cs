using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

  [RequireComponent(typeof(AudioSource))]
public class WriteDeneme : MonoBehaviour
{

    // public Button trueButton;
    // public Button falseButton;
    public float delay = 0.1f;
    public GameObject FirstQuestion;
    public GameObject SecondQuestion;
    public GameObject ThirdQuestion;

    public GameObject Dort;
    public GameObject Bes;
    public GameObject Alti;
    public GameObject Seven;
    public GameObject Eight;
    public GameObject Nine;
    public GameObject Ten;
    public GameObject Eleven;
    public GameObject Twelve;
    public GameObject Thirteen;
    public GameObject Fourteen;
    public GameObject Fifteen;
    public GameObject Level0;
    public GameObject Level1;
    public GameObject Level2;
    public GameObject Level3;
    public GameObject Level4;
    // public AudioClip typeSound;
    // AudioSource audioSource;

    [Multiline]  // daha geniş bir string paneli oluşturmak için.
    public string yazi;
    public Text thisText;
    void Start()
    {
        // audioSource = GetComponent<AudioSource>();
        thisText = GetComponent<Text>();


    }
    public IEnumerator TypeWrite()
    {
        //   foreach (char letter in text.ToCharArray())  BU KISIM COPILOTUN OTOMATIK YAZDIĞI KISIM
        //   {
        //    thisText.text += letter;
        //    audioSource.PlayOneShot(typeSound);
        //    yield return new WaitForSeconds(0.05f);
        //   }

        foreach (char i in yazi)
        {
            thisText.text += i.ToString();

            // audSrc.pitch = Random.Range(0.8f, 1.2f);
            // audSrc.PlayOneShot(TypeSound);

            if (i.ToString() == ".") { yield return new WaitForSeconds(1); }
            else { yield return new WaitForSeconds(delay); }
        }
        // // foreach (char i in text)
        // {
        //     thisText.text += i.ToString(); // i, charachter formatnıda olduğu için, tostring yazdık
        //     // audioSource.pitch = Random.Range(0.9f, 1.1f);
        //     // audioSource.PlayOneShot(typeSound);
        //     if (i.ToString() == ".")
        //     {
        //         yield return new WaitForSeconds(1f);
        //     }
        //     else
        //     {

        //         yield return new WaitForSeconds(delay);
        //     }
        //     // how to run text everytime when canvas is active?

        // }
    }
    void Update()
    {
        if (Level0.activeInHierarchy == true)
        {
            if (FirstQuestion.activeInHierarchy == false)
            {
                thisText.text = "What is personal information?";
                GameObject.FindWithTag("FirstOption").GetComponentInChildren<Text>().text = "Your shoe";
                GameObject.FindWithTag("SecondOption").GetComponentInChildren<Text>().text = "Your address";
                
            }
            if (SecondQuestion.activeInHierarchy == false)
            {
                // StartCoroutine(TypeWrite());
                thisText.text = "If you post something on the internet, who may be able to see it?";
                GameObject.FindWithTag("FirstOption").GetComponentInChildren<Text>().text = "Anyone";
                GameObject.FindWithTag("SecondOption").GetComponentInChildren<Text>().text = "Only your friends";
                // StopCoroutine(TypeWrite());
            }
            if (ThirdQuestion.activeInHierarchy == false)
            {
                // StartCoroutine(TypeWrite());
                thisText.text = "Whatever you post online will stay there forever even if you delete it.";
                
                // StopCoroutine(TypeWrite());
            }
        }
        if (Level1.activeInHierarchy == true)
        {
            if (Dort.activeInHierarchy == false)
            {
                // StartCoroutine(TypeWrite());
                thisText.text = "You are playing a fun game on the Internet. Suddenly, you get a pop-up message. The message reads “Click here now to win a brand new iPhone!!!” What would you do?";
                GameObject.FindWithTag("FirstOption").GetComponentInChildren<Text>().text = "Close the window";
                GameObject.FindWithTag("SecondOption").GetComponentInChildren<Text>().text = "Click on the message";
                // StopCoroutine(TypeWrite());
            }
            if (Bes.activeInHierarchy == false)
            {
                // StartCoroutine(TypeWrite());
                thisText.text = "You, want to make more friends. Do you:";
                GameObject.FindWithTag("FirstOption").GetComponentInChildren<Text>().text = "Give out your phone number and ask people to call you if they want to be friends";
                GameObject.FindWithTag("SecondOption").GetComponentInChildren<Text>().text = "Join a sports team/take up a hobby";
            }
            if (Alti.activeInHierarchy == false)
            {
                // StartCoroutine(TypeWrite());
                thisText.text = "You can totally share your password with your best friend, you trust them!";
                // StopCoroutine(TypeWrite());
            }

        }
        if (Level2.activeInHierarchy == true)
        {
            if (Seven.activeInHierarchy == false)
            {
                thisText.text = "Which of the following is an online threat?";
                GameObject.FindWithTag("FirstOption").GetComponentInChildren<Text>().text = "Identity theft";
                GameObject.FindWithTag("SecondOption").GetComponentInChildren<Text>().text = "Surfing";
            }
            if (Eight.activeInHierarchy == false)
            {
                thisText.text = " If someone you meet online asks you for your address you should tell them no.";

            }
            if (Nine.activeInHierarchy == false)
            {
                thisText.text = " Someone leaves a comment on your online profile that says something really rude or mean or make you feel uncomfortable. You:";
                GameObject.FindWithTag("FirstOption").GetComponentInChildren<Text>().text = "Start an online fight with the person";
                GameObject.FindWithTag("SecondOption").GetComponentInChildren<Text>().text = "Ignore it and move on";
            }
        }
        if (Level3.activeInHierarchy == true)
        {
            if (Ten.activeInHierarchy == false)
            {
                thisText.text = " You get an email with attachment from an address you don't know. You:";
                GameObject.FindWithTag("FirstOption").GetComponentInChildren<Text>().text = "Delete it without even opening it";
                GameObject.FindWithTag("SecondOption").GetComponentInChildren<Text>().text = "Open it and download the attachment";
            }

            if (Eleven.activeInHierarchy == false)
            {
                thisText.text = "You’ve gone on a gaming website and it asks you to download a link before you play. What should you do?";
                GameObject.FindWithTag("FirstOption").GetComponentInChildren<Text>().text = "Don’t download it, it must be illegal";
                GameObject.FindWithTag("SecondOption").GetComponentInChildren<Text>().text = "Download it anyway";
            }
            if (Twelve.activeInHierarchy == false)
            {
                thisText.text = "What should you do if you are online and someone you don’t know messages you claiming to be a student at a nearby school?";
                GameObject.FindWithTag("FirstOption").GetComponentInChildren<Text>().text = "Don't accept their invitation chat (it could be someone trying to trick you).";
                GameObject.FindWithTag("SecondOption").GetComponentInChildren<Text>().text = "Accept the invite and chat with them.";
            }
        }
        if (Level4.activeInHierarchy == true)
        {
            if (Thirteen.activeInHierarchy == false)
            {
                thisText.text = "What do you do if someone is bullying you online?";
                GameObject.FindWithTag("FirstOption").GetComponentInChildren<Text>().text = "Say you will tell on them";
                GameObject.FindWithTag("SecondOption").GetComponentInChildren<Text>().text = "Stop, block, tell an adult";
            }
            if (Fourteen.activeInHierarchy == false) // son ikisine bak bakalım biraz zor olabilir
            {
                thisText.text = "Unknown programs that startup when you turn on your computer is because of:";
                GameObject.FindWithTag("FirstOption").GetComponentInChildren<Text>().text = "Computer Virus";
                GameObject.FindWithTag("SecondOption").GetComponentInChildren<Text>().text = "System Issue";
            }
            if (Fifteen.activeInHierarchy == false)
            {
                thisText.text = "File sharing and downloading music without paying for it is:";
                GameObject.FindWithTag("FirstOption").GetComponentInChildren<Text>().text = "Fair use";
                GameObject.FindWithTag("SecondOption").GetComponentInChildren<Text>().text = "Illegal";
            }
        }
    }
    // void TaskOnClick()
    // {
    //     Debug.Log("You have clicked the button!");
    // }

}
