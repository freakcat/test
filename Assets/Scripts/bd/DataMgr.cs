using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Video;

public class DataMgr : MonoBehaviour
{
    private Suffer _suffer;
    // Start is called before the first frame update
    void Start()
    {
        ViewCommit.Vc.Cclick += GetName;
    }

    private string GetName(string s)
    {
        Suffer suffer = new Suffer();
        suffer.Info.name = s;
        string a = ControlMyBd.CreateDefaultBd(suffer);
       
        char isvail = a.First(  (x) => { return x=='0';} );
        string result = a.Remove(0,1);
        Debug.Log(result);    
//        if (isvail == '0')
//        {
//            return result;
//        }
        _suffer = JsonUtility.FromJson<Suffer>(result);
        return "----";  
    }
    // Update is called once per frame
    void Update()
    {
        if (_suffer != null)
        {
            var vidoePlayerEx = new VidoePlayerEx(GameObject.Find("MediaVideo").GetComponent<VideoPlayer>(),ViewCommit.Vc.showVideo);
            print(vidoePlayerEx.SetVideoUrl(_suffer.Info.mediaVideo[0]));
 print("---------------------------------------------");
            vidoePlayerEx.RenderImage();
        }
    }
}
