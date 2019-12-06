using System.Collections.Generic;
using System;
using UnityEngine.Serialization;

namespace Sufferinfo
{
    [Serializable]
    public class MyBd : BaseBd
    {
        public string uuid;
        public string pw;
        public string hospital;
        public int gender;
        public int age;
        public int sickType;

        [FormerlySerializedAs("Trains")] public List<Train> trains = new List<Train>();
        [FormerlySerializedAs("Estimates")] public List<Estimate> estimates = new List<Estimate>();
    }

    [Serializable]
    public class Train : BaseBd
    {
        public int level;
        public float scores;
        public float elapsedTime;
        public string anyDirection;
        public string partOfBody;
    }

    [Serializable]
    public class Estimate : BaseBd
    {
        public float scores;
        public string anyDirection;
        public string partOfBody;
    }

    
    [Serializable]
    public class BaseBd
    {
        public int number;
        public int id;
        public string name;
        public string date;
        public string doctor;
        public string describe;
        public string avatar;
        public  List<string> mediaVideo = new List<string>();
        public List<string> mediaAudio = new List<string>();
        public List<string> mediaPicture = new List<string>();
    }
}