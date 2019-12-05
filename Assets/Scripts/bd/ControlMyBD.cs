using System;
using System.Collections;
using System.Collections.Generic;
using Sufferinfo;
using UnityEngine;
 

public static class ControlMyBd 
{
    public static Dictionary<string, Suffer> Suffers = new Dictionary<string, Suffer>();

    public static Suffer CurSuffer;
    public static string CreateBd(Suffer tempsuffer)
    {
        Debug.Log(tempsuffer.Info.uuid==null);
        if(tempsuffer.Info.uuid==null) tempsuffer.Info.uuid = Guid.NewGuid().ToString();
        if (Suffers.ContainsKey(tempsuffer.Info.uuid)) return "0此id已使用";
        
        if (tempsuffer.Info.Name.Equals("")) return "0请输入名字";
 
        Suffers.Add(tempsuffer.Info.uuid,tempsuffer);
        
        Train train = new Train();
        train.level = 11;
        train.Id = 99;
        tempsuffer.Info.trains.Add(train);
        
        Estimate estimate = new Estimate();
        train.level = 11;
        train.Id = 99;
        tempsuffer.Info.estimates.Add(estimate);
        CurSuffer = tempsuffer;
        
        return 1+JsonUtility.ToJson(CurSuffer);
    }
}



public class Suffer
{
    public MyBd Info = new MyBd();
}
