using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class TvScript : MonoBehaviour
{
    public UnityEngine.Video.VideoClip videoClip;
    bool isPlayin = false;
    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.Debug.Log("start");
        var videoPlayer = gameObject.GetComponent<UnityEngine.Video.VideoPlayer>();
        videoPlayer.playOnAwake = false;
        videoPlayer.clip = videoClip;
        videoPlayer.renderMode = UnityEngine.Video.VideoRenderMode.MaterialOverride;
        videoPlayer.targetMaterialRenderer = GetComponent<Renderer>();
        videoPlayer.targetMaterialProperty = "_MainTex";
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        UnityEngine.Debug.Log("clcik");
        var vp = GetComponent<UnityEngine.Video.VideoPlayer>();
        if (!isPlayin)
        {
            vp.Play();
            isPlayin = true;
        }
        else
        {
            isPlayin = false;
            vp.Stop();
        }
    }

}