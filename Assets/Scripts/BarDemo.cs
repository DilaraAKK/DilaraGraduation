using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarDemo : MonoBehaviour
{
    public ProgressBar bar;
    public int value = 0;
    void Start()
    {
        bar.BarValue = value;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            value += 10;
            bar.BarValue = value;
        }
    }
}
