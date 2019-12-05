using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DataMgr : MonoBehaviour
{
 
    
    // Start is called before the first frame update
    void Start()
    {
 
        ViewCommit.Vc.Cclick += GetName;
    }

    private string GetName(string s)
    {
        Suffer suffer = new Suffer();
        suffer.Info.Name = s;
        string a = ControlMyBd.CreateBd(suffer);
       
        char isvail = a.First(  (x) => { return x=='0';} );
        string result = a.Remove(0,1);
        Debug.Log(result);
        if (isvail == '0')
        {
            return result;
        }
        else
        {
            return JsonUtility.FromJson<Suffer>(result).Info.Name;  
        }
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
