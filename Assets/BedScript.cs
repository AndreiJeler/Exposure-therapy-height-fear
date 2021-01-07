using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedScript : MonoBehaviour
{
    public bool isNight = false;
    public Material skyDay;
    public Material skyNight;
    public Light mainLight;
    // Start is called before the first frame update

    void EnableLights(bool enable)
    {
        foreach (var light in FindObjectsOfType<Light>()) light.enabled = enable;

    }

    private void OnMouseDown()
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

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
