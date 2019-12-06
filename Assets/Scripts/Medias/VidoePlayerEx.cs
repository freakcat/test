
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VidoePlayerEx  
{
     public bool lockUrl;
     private  VideoPlayer videoPlayer;
      
     public RawImage videoImage;

     public VidoePlayerEx(VideoPlayer vp,RawImage ri)
     {
         videoPlayer = vp;
         videoImage = ri;
     }
    
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
