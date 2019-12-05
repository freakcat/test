using System;
using System.Collections;
using System.Collections.Generic;
using Sufferinfo;
using UnityEngine;
 
public static class ControlMyBD 
{
    public static Dictionary<string, Suffer> suffers = new Dictionary<string, Suffer>();

    public static Suffer curSuffer;
    public static string CreateBD(Suffer tempsuffer)
    {
        Debug.Log(tempsuffer.info.Name);
        
        
        if(null==tempsuffer.info.Uuid) tempsuffer.info.Uuid = Guid.NewGuid().ToString();
        Debug.Log(tempsuffer.info.Uuid);
        if (suffers.ContainsKey(tempsuffer.info.Uuid)) return "此id已使用";
        if (null == tempsuffer.info.Name) return "请输入名字";

       // tempsuffer.info.test = 12;
        
        suffers.Add(tempsuffer.info.Uuid,tempsuffer);
        curSuffer = tempsuffer;
        
        return JsonUtility.ToJson(curSuffer);
    }
}



public class Suffer
{
    public MyBD info = new MyBD();
}
