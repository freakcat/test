using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataMgr : MonoBehaviour
{
 
    
    // Start is called before the first frame update
    void Start()
    {
 
        ViewCommit.vc.Cclick += GetName;
    }

    private string GetName(string s)
    {
        Suffer suffer = new Suffer();
        suffer.info.Name = s;
        string a = ControlMyBD.CreateBD(suffer);
        Debug.Log(a);
        return JsonUtility.FromJson<Suffer>(a).info.Name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
