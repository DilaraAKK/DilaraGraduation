using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxChange : MonoBehaviour
{
    public GameObject Level0;
    public GameObject Level1;
    public GameObject Level2;
    public GameObject Level3;
    public GameObject Level4;
    public Material daySkybox;
    public Material nightSkybox;
    void Start()
    {
        
    }

        void Update()
    {
        if(Level0.activeInHierarchy == true)
        {
            RenderSettings.skybox = daySkybox;
        }
        else if(Level1.activeInHierarchy == true)
        {
            RenderSettings.skybox = nightSkybox;
        }
        else if(Level2.activeInHierarchy == true)
        {
            RenderSettings.skybox = daySkybox;
        }
        else if(Level3.activeInHierarchy == true)
        {
            RenderSettings.skybox = nightSkybox;
        }
        else if(Level4.activeInHierarchy == true)
        {
            RenderSettings.skybox = nightSkybox;
        }
    }
}
