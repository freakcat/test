using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Directory = UnityEngine.Windows.Directory;

public class Medias : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string path = Application.dataPath + "/Medias/flv/";
        DirectoryInfo flvfloder = new DirectoryInfo(path);
        var flvitems = flvfloder.GetFiles();
        int i = 0;
        StreamWriter sw =  File.CreateText(path + "/list.txt");
        foreach (var f in flvitems)
        {
            var l = f.Name.Split('.').Length;
             
            FileInfo fileInfo = new FileInfo( f.FullName);
            if (fileInfo.Extension == ".flv")
            {
 
                string id = i < 10 ? "0"+i : i+"";
                i++;
                 
                fileInfo.MoveTo(String.Format("{0}rain{1}{2}",path,id,".flv"));
                
                sw.WriteLine(String.Format("file '{0}'",f.Name),true);
    
            }
            
        }
        sw.Close();
         
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
