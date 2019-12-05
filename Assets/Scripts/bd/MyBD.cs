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
        public bool sex;
        public int age;
        public int sicktype;

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
        public string partofbody;
    }

    [Serializable]
    public class Estimate : BaseBd
    {
        public float scores;
        public string anyDirection;
        public string partofbody;
    }

    public abstract class BaseBd
    {
        public int Number;
        public int Id;
        public string Name;
        public string Date;
        public string Doctor;
        public string Describe;
    }
}