using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionBox : MonoBehaviour
{
    float degreesPerSecond = 70;
    public GameObject Canvas;
    void Start()
    {

    }
   private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {


            Debug.Log("hit");
            Canvas.SetActive(true);

        }
    }
    // Update is called once per frame
    void Update()
    {

        transform.Rotate(new Vector3(0, degreesPerSecond, 0) * Time.deltaTime);

    }
}
