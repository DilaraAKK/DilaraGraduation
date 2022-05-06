using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// public class TypeWriter : MonoBehaviour
// {
//     public float delay = 0.1f;
//     public string fullText;
//     private string currentText = "";
// 	public Text textCurrent;
//     bool isCoroutineStarted = false;

//     // Use this for initialization
//     void Start()
//     {
//         StartCoroutine(ShowText());
// 		textCurrent = GetComponent<Text> ();







//     }

//     IEnumerator ShowText()
//     {
// 		isCoroutineStarted = true;
//         for (int i = 0; i < textCurrent.text.Length; i++)
//         {
//             currentText = textCurrent.text.Substring(0, i);
//             this.GetComponent<Text>().text = currentText;
//             yield return new WaitForSeconds(delay);

//         }
//     }
//     // void Update()
//     // {
//     //     if (isCoroutineStarted)
//     //     {
//     //         StartCoroutine(ShowText());
//     //         fullText = "gfhgfjg  kmsdds   sdfmksd  gsgs  sdj";

//     //     }
//     // }


// 	void Update()
// 	{


// 		if (isCoroutineStarted)
//         {
//             StartCoroutine(ShowText());
//             textCurrent.text = "aaa dgdaaa  dfgdfg sdgsdgsd sgsdg sdfs  sd f d  sd f sdg";
//             StopCoroutine(ShowText());
//         }

// 	}
// }
[RequireComponent(typeof(AudioSource))]
public class Write : MonoBehaviour
{
    public float delay = 0.1f;
    public AudioClip TypeSound;
    [Multiline]
    public string yazi;
    public GameObject FirstQuestion;


    // AudioSource audSrc;
    Text thisText;


    private void Start()
    {
        // audSrc = GetComponent<AudioSource>();
        thisText = GetComponent<Text>();

        // get the yazi from the text component
        // //yazi = thisText.text;
        // //thisText.text = "";

        // #get the yazi from the TypeWriter script




    }

    IEnumerator TypeWrite()
    {
        foreach (char i in yazi)
        {
            thisText.text += i.ToString();

            // audSrc.pitch = Random.Range(0.8f, 1.2f);
            // audSrc.PlayOneShot(TypeSound);

            if (i.ToString() == ".") { yield return new WaitForSeconds(1); }
            else { yield return new WaitForSeconds(delay); }
        }
    }
    void Update()
    {

        if (FirstQuestion.activeInHierarchy == false)
        {
            StartCoroutine("TypeWrite");
            this.yazi = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur blandit. ";
            


        }
    }

}

