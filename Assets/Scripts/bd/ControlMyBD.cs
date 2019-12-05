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
        Debug.Log(tempsuffer.info.uuid==null);
        if(tempsuffer.info.uuid==null) tempsuffer.info.uuid = Guid.NewGuid().ToString();
        if (suffers.ContainsKey(tempsuffer.info.uuid)) return "0此id已使用";
        
        if (tempsuffer.info.name.Equals("")) return "0请输入名字";
 
        suffers.Add(tempsuffer.info.uuid,tempsuffer);
        
        Train train = new Train();
        train.level = 11;
        train.id = 99;
        tempsuffer.info.Trains.Add(train);
        
        Estimate estimate = new Estimate();
        train.level = 11;
        train.id = 99;
        tempsuffer.info.Estimates.Add(estimate);
        curSuffer = tempsuffer;
        
        return 1+JsonUtility.ToJson(curSuffer);
    }
}



public class Suffer
{
    public MyBD info = new MyBD();
}
