
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VidoePlayerEx : MonoBehaviour
{
     public bool lockUrl;
     public VideoPlayer videoPlayer;
      
     public RawImage videoImage;
 
     public void RenderImage()
    {
        if(videoImage != null)
        {
            videoImage.texture  = videoPlayer.texture;
            lockUrl = true;
            Play();
        }
    }
    public string Play()
    {
        if (videoPlayer == null) return "not url or renderiamge";
        videoPlayer.Play();
        return videoPlayer.url;
    }

    public void Pause()
    {
       lockUrl = false;
       videoPlayer.Pause();
    }

    public bool SetVideoUrl(string url)
    {
        if (!lockUrl)
        {
            videoPlayer.source = VideoSource.Url;
            videoPlayer.url = url;
            return true;
        }
        {
            return false;
        }
    }
}
