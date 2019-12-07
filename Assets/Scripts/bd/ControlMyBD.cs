using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Sufferinfo;
using UnityEngine;
using Debug = System.Diagnostics.Debug;


public static class ControlMyBd 
{
    public static Dictionary<string, Suffer> Suffers = new Dictionary<string, Suffer>();
    public static Suffer CurSuffer;
    
    public static string CreateDefaultBd(Suffer tempsuffer)
    {
        if(tempsuffer.Info.uuid==null) tempsuffer.Info.uuid = Guid.NewGuid().ToString();
        if (Suffers.ContainsKey(tempsuffer.Info.uuid)) return "0此id已使用";
        if (tempsuffer.Info.name.Equals("")) return "0请输入名字";

        MyBd my = tempsuffer.Info;
        my.number = 0;
        my.id = 0;
        my.date =  DateTime.Now.ToString(CultureInfo.InvariantCulture);
        my.doctor = "doctor";
        my.describe = "a suffer";
        my.avatar = "/defaultavatar.png";
        my.mediaVideo.Add("https://sec.ch9.ms/ch9/f9fc/04e1404f-2a51-4ad7-9eea-0a3bb053f9fc/devtestlabsintro_mid.mp4");  
        my.mediaAudio.Add("");
        my.mediaPicture.Add("");
        my.pw = "123";
        my.hospital = "MariaHospital";
        my.gender = 1;
        my.age = 18;
        my.sickType = 0;
        Train train = new Train();
        train.level = 11;
        train.id = 99;
        train.name = "daydayup";
        train.scores = 12f;
        train.anyDirection = "left";
        train.partOfBody = "leg";
        train.mediaVideo.Add("https://sec.ch9.ms/ch9/f9fc/04e1404f-2a51-4ad7-9eea-0a3bb053f9fc/devtestlabsintro_mid.mp4");
        my.trains.Add(train);
        
        Estimate estimate = new Estimate();
        estimate.id = 99;
        estimate.name = "daydayup";
        estimate.scores = 12f;
        estimate.anyDirection = "left";
        estimate.partOfBody = "leg";
        estimate.mediaPicture.Add("/defualt.png");
        my.estimates.Add(estimate);
        
        tempsuffer.Info = my;
        
        Suffers.Add(tempsuffer.Info.uuid,tempsuffer);
        CurSuffer = tempsuffer;
        return 1+JsonUtility.ToJson(CurSuffer);
    }
}
 
public class Suffer
{
    public MyBd Info = new MyBd();
}
