using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsScript : MonoBehaviour
{
    public bool isNight = false;
    public Material skyDay;
    public Material skyNight;
    public Material skyExtreme;
    public Light mainLight;


    void EnableLights(bool enable)
    {
        foreach (var light in FindObjectsOfType<Light>()) light.enabled = enable;

    }

    void Start()
    {
        Application.targetFrameRate = 30;
        /*foreach(var light in lights)
        {
            light.active = false;
        }*/
        EnableLights(false);
        RenderSettings.skybox = skyDay;
        mainLight.intensity = 1;
        mainLight.enabled = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            EnableLights(!isNight);
            if (isNight)
            {
                RenderSettings.skybox = skyDay;
                mainLight.enabled = true;
                mainLight.intensity = 1;
            }
            else
            {
                RenderSettings.skybox = skyNight;
                mainLight.enabled = false;
                mainLight.intensity = 0;
            }
            isNight = !isNight;
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            RenderSettings.skybox = skyDay;
            EnableLights(false);
            mainLight.enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            RenderSettings.skybox = skyNight;
            EnableLights(true);
            mainLight.enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            RenderSettings.skybox = skyExtreme;
            EnableLights(false);
            mainLight.enabled = false;
        }
    }

}
