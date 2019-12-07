using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Video;

public class DataMgr : MonoBehaviour
{
    private Suffer _suffer;

    public VidoePlayerEx vpx;
    // Start is called before the first frame update
    void Start()
    {
        ViewCommit.Vc.Cclick += GetName;
        vpx.SetVideoUrl("https://sec.ch9.ms/ch9/f9fc/04e1404f-2a51-4ad7-9eea-0a3bb053f9fc/devtestlabsintro_mid.mp4");
    }

    private string GetName(string s)
    {
        Suffer suffer = new Suffer();
        suffer.Info.name = s;
        string a = ControlMyBd.CreateDefaultBd(suffer);
       
        char isvail = a[0];
        string result = a.Remove(0,1);
        Debug.Log(result);    
        if (isvail == '0')
        {
            return result;
        }
        _suffer = JsonUtility.FromJson<Suffer>(result);
 
        return _suffer.Info.name;  
    }
    // Update is called once per frame
    void Update()
    {
        if (_suffer != null)
        {
            vpx.RenderImage();
            
        }
    }
}
