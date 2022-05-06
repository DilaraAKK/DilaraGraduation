using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class engel : MonoBehaviour
{
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

       
    }
